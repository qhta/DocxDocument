using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Schema;
using Microsoft.EntityFrameworkCore;
using ModelXmlSchema;

namespace ModelXmlSchemaApp;


/// <summary>
/// Parser that reads XML schema files and stores the schema in a database.
/// </summary>
public class XmlSchemaParser
{
  public string SourceXsdPath { get; set; } = null!;
  public int SchemaFilesTotal, SchemaFilesAdded;
  public int SchemaNamespacesTotal, SchemaNamespacesAdded, SchemaNamespacesUpdates;
  public int UsedNamespacesTotal, UsedNamespacesAdded;
  public int SchemaSimpleTypesTotal, SchemaSimpleTypesAdded, SchemaSimpleTypesUpdates;
  public int SchemaComplexTypesTotal, SchemaComplexTypesAdded;
  public int SchemaAttributesTotal, SchemaAttributesAdded, SchemaAttributesUpdates;
  public int SchemaAttributeGroupsTotal, SchemaAttributeGroupsAdded;
  public int SchemaAttributeGroupRefsTotal, SchemaAttributeGroupRefsAdded;
  public int SchemaParticlesTotal, SchemaParticlesAdded, SchemaParticlesUpdates;
  public int SchemaEnumValuesTotal, SchemaEnumValuesAdded;
  public int SchemaPatternsTotal, SchemaPatternsAdded;
  public int SchemaListItemsTotal, SchemaListItemsAdded, SchemaListItemsUpdates;
  public int SchemaUnionMembersTotal, SchemaUnionMembersAdded, SchemaUnionMembersUpdates;
  public int SchemaGroupsTotal, SchemaGroupsAdded;
  public int SchemaGroupRefsTotal, SchemaGroupRefsAdded, SchemaGroupRefsUpdates;
  public int SchemaElementsTotal, SchemaElementsAdded, SchemaElementsUpdates;

  public void ParseSchemaFiles(string sourceXsdPath, string dbFilename)
  {
    SourceXsdPath = sourceXsdPath;
    var schemaSet = LoadSchemaFiles();
    using (dbContext = new XmlSchemaDbContext(dbFilename))
    {
      ParseSchemaFilesAndNamespaces(schemaSet);
      SetNamespacePrefixes();
      ParseXmlSchemaSet(schemaSet);
    }
  }

  internal int AnonSimpleTypes = 0;
  internal XmlSchemaDbContext dbContext = null!;

  internal XmlSchemaSet LoadSchemaFiles()
  {
    var files = Directory.GetFiles(SourceXsdPath, "*.xsd");
    var schemaSet = new XmlSchemaSet();
    foreach (var file in files)
    {
      var filename = Path.GetFileNameWithoutExtension(Path.GetFileName(file));
      Console.WriteLine($"Reading schema {filename}");
      using (var reader = new StreamReader(file))
      {
        XmlSchema? schema = XmlSchema.Read(reader, ValidationCallback);
        if (schema != null)
        {
          schema.Id = filename;
          schemaSet.Add(schema);
        }
      }
    }
    schemaSet.Compile();
    return schemaSet;
  }

  internal void ValidationCallback(object? sender, ValidationEventArgs args)
  {
    var msg = args.Message;
    if (args.Severity == XmlSeverityType.Warning)
      msg = "WARNING: " + msg;
    else if (args.Severity == XmlSeverityType.Error)
      msg = "ERROR: " + msg;

    Console.WriteLine(msg);
    throw new InvalidDataException(msg);
  }

  internal int SaveChanges()
  {
    try
    {
      var changes = dbContext.SaveChanges();
      return changes;
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      //throw;
      return -1;

    }
  }

  internal void ParseSchemaFilesAndNamespaces(XmlSchemaSet schemaSet)
  {
    foreach (XmlSchema schema in schemaSet.Schemas())
    {
      Console.WriteLine($"Checking schema file \"{schema.Id}\" targeting namespace={schema.TargetNamespace}");
      if (schema.Id != null)
      {
        string id = schema.Id;
        var schemaFile = dbContext.SchemaFiles.FirstOrDefault(item => item.FileName == id);
        if (schemaFile == null)
        {
          Console.WriteLine($"  Adding schema file {id}");
          schemaFile = new SchemaFile { FileName = id };
          dbContext.SchemaFiles.Add(schemaFile);
          if (SaveChanges() > 0)
            SchemaFilesAdded++;
        }
        if (schema.TargetNamespace != null)
        {
          var schemaNamespace = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == schema.TargetNamespace);
          if (schemaNamespace == null)
          {
            Console.WriteLine($"  Adding schema namespace {schema.TargetNamespace}");
            schemaNamespace = new SchemaNamespace { Url = schema.TargetNamespace };
            dbContext.SchemaNamespaces.Add(schemaNamespace);
            if (SaveChanges() > 0)
              SchemaNamespacesAdded++;
          }
          schemaFile.TargetNamespaceId = schemaNamespace.Id;
        }
        var namespaces = schema.Namespaces.ToArray();
        for (int i = 0; i < namespaces.Count(); i++)
        {
          var ns = namespaces[i];
          if (ns.Namespace != schema.TargetNamespace && ns.Namespace != "#all")
          {
            var schemaNamespace = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == ns.Namespace);
            if (schemaNamespace == null)
            {
              Console.WriteLine($"  adding namespace {ns.Namespace}");
              schemaNamespace = new SchemaNamespace { Url = ns.Namespace };
              dbContext.SchemaNamespaces.Add(schemaNamespace);
              if (SaveChanges() > 0)
                SchemaNamespacesAdded++;
            }
            var schemaUsedNamespace = dbContext.SchemaUsedNamespaces.FirstOrDefault(item =>
                      item.SchemaFileId == schemaFile.Id && item.SchemaNamespaceId == schemaNamespace.Id && item.Prefix == ns.Name);
            if (schemaUsedNamespace == null)
            {
              Console.WriteLine($"  adding used namespace {schemaFile.Id} -> {schemaNamespace.Id}");
              schemaUsedNamespace = new SchemaUsedNamespace { SchemaFileId = schemaFile.Id, SchemaNamespaceId = schemaNamespace.Id, Prefix = ns.Name };
              dbContext.SchemaUsedNamespaces.Add(schemaUsedNamespace);
              if (SaveChanges() > 0)
                UsedNamespacesAdded++;
            }
          }
        }
      }
    }

    SchemaFilesTotal = dbContext.SchemaFiles.Count();
    SchemaNamespacesTotal = dbContext.SchemaNamespaces.Count();
    UsedNamespacesTotal = dbContext.SchemaUsedNamespaces.Count();
  }

  internal void SetNamespacePrefixes()
  {
    var schemaNamespacePrefixes = dbContext.SchemaUsedNamespaces
      .GroupBy(item => new { item.SchemaNamespaceId, item.Prefix })
      .Select(group => new SchemaNamespacePrefix()
      {
        SchemaNamespaceId = group.Key.SchemaNamespaceId,
        Prefix = group.Key.Prefix,
        Count = group.Count()
      });
    foreach (var schemaNamespacePrefix in schemaNamespacePrefixes)
    {
      var schemaNamespace = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Id == schemaNamespacePrefix.SchemaNamespaceId);
      if (schemaNamespace != null)
      {
        schemaNamespace.Prefix = schemaNamespacePrefix.Prefix;
      }
    }

    if (SaveChanges() > 0)
    {
      Console.WriteLine("Setting namespace prefix");
      SchemaNamespacesUpdates++;
    }
  }

  internal void ParseXmlSchemaSet(XmlSchemaSet schemaSet)
  {
    foreach (XmlSchema schema in schemaSet.Schemas())
    {
      ParseXmlSchema(schema);
    }
    SchemaSimpleTypesTotal = dbContext.SchemaSimpleTypes.Count();
    SchemaComplexTypesTotal = dbContext.SchemaComplexTypes.Count();
    SchemaAttributesTotal = dbContext.SchemaAttributes.Count();
    SchemaAttributeGroupsTotal = dbContext.SchemaAttributeGroups.Count();
    SchemaAttributeGroupRefsTotal = dbContext.SchemaAttributeGroupRefs.Count();
    SchemaParticlesTotal = dbContext.SchemaParticles.Count();
    SchemaEnumValuesTotal = dbContext.SchemaEnumValues.Count();
    SchemaPatternsTotal = dbContext.SchemaPatterns.Count();
    SchemaListItemsTotal = dbContext.SchemaListItems.Count();
    SchemaUnionMembersTotal = dbContext.SchemaUnionMembers.Count();
    SchemaGroupsTotal = dbContext.SchemaGroups.Count();
    SchemaGroupRefsTotal = dbContext.SchemaGroupRefs.Count();
    SchemaElementsTotal = dbContext.SchemaElements.Count();
  }

  internal void ParseXmlSchema(XmlSchema schema)
  {
    Console.WriteLine($"Checking {schema.Id} items");
    if (schema.Id != null)
    {
      string id = schema.Id;
      var schemaFile = dbContext.SchemaFiles.Include(file => file.TargetNamespace).FirstOrDefault(item => item.FileName == id);
      if (schemaFile == null)
      {
        throw new Exception($"Schema file {id} must be created first");
      }


      var ns = schemaFile.TargetNamespace;
      if (ns == null)
      {
        throw new Exception($"Schema file {id} has no target namespace");
      }


      foreach (var item in schema.Items)
      {
        if (item is XmlSchemaSimpleType xmlSchemaSimpleType)
        {
          ParseXmlSchemaSimpleType(ns, xmlSchemaSimpleType);
        }
        else
        if (item is XmlSchemaComplexType xmlSchemaComplexType)
        {
          ParseXmlSchemaComplexType(ns, xmlSchemaComplexType);
        }
        else
        if (item is XmlSchemaGroup xmlSchemaGroup)
        {
          ParseXmlSchemaGroup(ns, xmlSchemaGroup);
        }
        else
        if (item is XmlSchemaElement xmlSchemaElement)
        {
          ParseXmlSchemaGlobalElement(ns, xmlSchemaElement);
        }
        else
        if (item is XmlSchemaAttributeGroup xmlSchemaAttributeGroup)
        {
          ParseXmlSchemaAttributeGroup(ns, xmlSchemaAttributeGroup);
        }
        else
        if (item is XmlSchemaAttribute xmlSchemaAttribute)
        {
          ParseXmlSchemaGlobalAttribute(ns, xmlSchemaAttribute);
        }
        else
        {
          throw new NotImplementedException($"Schema type {item.GetType()} not supported");
        }
      }
    }
  }

  internal SchemaSimpleType ParseXmlSchemaSimpleType(SchemaNamespace parentNamespace, XmlSchemaSimpleType xmlSchemaSimpleType, string? defaultTypeName = null)
  {
    var nsId = parentNamespace.Id;
    var typeName = xmlSchemaSimpleType.Name ?? defaultTypeName;
    var schemaSimpleType = dbContext.SchemaSimpleTypes.FirstOrDefault(item =>
        item.SchemaNamespaceId == nsId && item.TypeName == typeName);
    if (schemaSimpleType == null)
    {
      Console.WriteLine($"Adding simple type {typeName}");
      schemaSimpleType = new SchemaSimpleType
      {
        SchemaNamespaceId = nsId,
        TypeName = typeName
      };
      dbContext.SchemaSimpleTypes.Add(schemaSimpleType);
      if (SaveChanges() > 0)
        SchemaSimpleTypesAdded++;
    }
    if (xmlSchemaSimpleType.BaseXmlSchemaType != null)
    {
      if (xmlSchemaSimpleType.BaseXmlSchemaType.Name != null)
        schemaSimpleType.BaseTypeName = xmlSchemaSimpleType.BaseXmlSchemaType.Name;
      ParseXmlSimpleTypeDetails(schemaSimpleType, xmlSchemaSimpleType);
    }
    return schemaSimpleType;
  }

  internal void ParseXmlSimpleTypeDetails(SchemaSimpleType schemaSimpleType, XmlSchemaSimpleType xmlSchemaSimpleType)
  {
    if (xmlSchemaSimpleType.Content is XmlSchemaSimpleTypeRestriction restriction)
    {
      if (restriction.Facets.Count > 0)
      {
        var facet = restriction.Facets[0];
        if (facet is XmlSchemaEnumerationFacet enumerationFacet)
        {
          ParseXmlSimpleTypeEnumRestriction(schemaSimpleType, restriction);
        }
        else if (facet is XmlSchemaPatternFacet patternFacet)
        {
          ParseXmlSimpleTypePatternRestriction(schemaSimpleType, restriction);
        }
        else
        {
          ParseXmlSimpleTypeOtherRestriction(schemaSimpleType, restriction);
        }
      }
      else
      {
        schemaSimpleType.BaseTypeName = restriction.BaseTypeName.Name;
        if (SaveChanges() > 0)
        {
          Console.WriteLine($"  Updating simple type {schemaSimpleType.TypeName} settings");
          SchemaSimpleTypesUpdates++;
        }
      }
    }
    else
    if (xmlSchemaSimpleType.Content is XmlSchemaSimpleTypeUnion union)
    {
      ParseXmlSimpleTypeUnion(schemaSimpleType, union);
    }
    else
    if (xmlSchemaSimpleType.Content is XmlSchemaSimpleTypeList list)
    {
      ParseXmlSimpleTypeList(schemaSimpleType, list);
    }
    else
      throw new NotImplementedException($"Simple type content {xmlSchemaSimpleType.Content} not supported");
  }

  internal void ParseXmlSimpleTypeEnumRestriction(SchemaSimpleType schemaSimpleType, XmlSchemaSimpleTypeRestriction restriction)
  {
    int n = 0;
    schemaSimpleType.BaseTypeName = "enum";
    foreach (var facet in restriction.Facets)
    {
      var enumerationFacet = (XmlSchemaEnumerationFacet)facet;
      var schemaEnumValue = dbContext.SchemaEnumValues.FirstOrDefault(item =>
        item.SimpleTypeId == schemaSimpleType.Id && item.EnumValueStr == enumerationFacet.Value);
      if (schemaEnumValue == null)
      {
        Console.WriteLine($"  Adding enum value {enumerationFacet.Value}");
        schemaEnumValue = new SchemaEnumValue { SimpleTypeId = schemaSimpleType.Id, EnumValueStr = enumerationFacet.Value };
        dbContext.SchemaEnumValues.Add(schemaEnumValue);
        schemaEnumValue.EnumValueNum = n++;
        if (SaveChanges() > 0)
          SchemaEnumValuesAdded++;
      }
    }
    schemaSimpleType.BaseTypeName = restriction.BaseTypeName.Name;
    if (SaveChanges() > 0)
    {
      Console.WriteLine($"  Updating simple type {schemaSimpleType.TypeName} settings");
      SchemaSimpleTypesUpdates++;
    }
  }

  internal void ParseXmlSimpleTypePatternRestriction(SchemaSimpleType schemaSimpleType, XmlSchemaSimpleTypeRestriction restriction)
  {
    schemaSimpleType.BaseTypeName = "string";
    foreach (var facet in restriction.Facets)
    {
      var patternFacet = (XmlSchemaPatternFacet)facet;
      var schemaPattern = dbContext.SchemaPatterns.FirstOrDefault(item =>
        item.SimpleTypeId == schemaSimpleType.Id && item.Pattern == patternFacet.Value);
      if (schemaPattern == null)
      {
        Console.WriteLine($"  Adding pattern value {patternFacet.Value}");
        schemaPattern = new SchemaPattern { SimpleTypeId = schemaSimpleType.Id, Pattern = patternFacet.Value };
        dbContext.SchemaPatterns.Add(schemaPattern);
        if (SaveChanges() > 0)
          SchemaPatternsAdded++;
      }
    }
  }

  internal void ParseXmlSimpleTypeOtherRestriction(SchemaSimpleType schemaSimpleType, XmlSchemaSimpleTypeRestriction restriction)
  {
    schemaSimpleType.BaseTypeName = restriction.BaseTypeName.Name;
    foreach (var facet in restriction.Facets)
    {
      if (facet is XmlSchemaMinExclusiveFacet minExclusiveFacet)
        schemaSimpleType.MinExclusive = minExclusiveFacet.Value;
      else
      if (facet is XmlSchemaMinInclusiveFacet minInclusiveFacet)
        schemaSimpleType.MinInclusive = minInclusiveFacet.Value;
      else
      if (facet is XmlSchemaMaxInclusiveFacet maxInclusiveFacet)
        schemaSimpleType.MaxInclusive = maxInclusiveFacet.Value;
      else
      if (facet is XmlSchemaMaxExclusiveFacet maxExclusiveFacet)
        schemaSimpleType.MaxExclusive = maxExclusiveFacet.Value;
      else
      if (facet is XmlSchemaMinLengthFacet minLengthFacet)
        schemaSimpleType.MinLength = GetIntegerValue(minLengthFacet.Value);
      else
      if (facet is XmlSchemaLengthFacet lengthFacet)
        schemaSimpleType.Length = GetIntegerValue(lengthFacet.Value);
      else
      if (facet is XmlSchemaMaxLengthFacet maxLengthFacet)
        schemaSimpleType.MaxLength = GetIntegerValue(maxLengthFacet.Value);
      else
        throw new NotImplementedException($"Restriction type {facet.GetType()} not supported");
    }
  }

  internal int GetIntegerValue(string? value)
  {
    if (int.TryParse(value, CultureInfo.InvariantCulture, out var val))
      return val;
    throw new NotImplementedException($"Value {value} should be int number");
  }

  internal decimal GetDecimalValue(string? value)
  {
    if (decimal.TryParse(value, CultureInfo.InvariantCulture, out var val))
      return val;
    throw new NotImplementedException($"Value {value} should be decimal number");
  }

  internal void ParseXmlSimpleTypeUnion(SchemaSimpleType schemaSimpleType, XmlSchemaSimpleTypeUnion union)
  {
    if (union.MemberTypes != null)
    {
      if (union.MemberTypes.Length == 1)
      {
        var memberType = union.MemberTypes[0];
        schemaSimpleType.BaseTypeName = memberType.Name;
        var memberNamespace = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == memberType.Namespace);
        if (memberNamespace == null)
          throw new NotImplementedException($"Namespace {memberType.Namespace} in type {schemaSimpleType.TypeName} not found");
        schemaSimpleType.BaseNamespaceId = memberNamespace.Id;
        if (SaveChanges() > 0)
        {
          Console.WriteLine($"  Updating simple type {schemaSimpleType.TypeName} settings");
          SchemaSimpleTypesUpdates++;
        }
      }
      else
      {
        schemaSimpleType.BaseTypeName = "union";
        foreach (var memberType in union.MemberTypes)
        {
          var type = memberType;
          var schemaUnionMember = dbContext.SchemaUnionMembers.FirstOrDefault(item =>
            item.SimpleTypeId == schemaSimpleType.Id && item.MemberTypeName == type.Name);
          if (schemaUnionMember == null)
          {
            Console.WriteLine($"  Adding member value {memberType.Name}");
            schemaUnionMember = new SchemaUnionMember { SimpleTypeId = schemaSimpleType.Id, MemberTypeName = memberType.Name };
            dbContext.SchemaUnionMembers.Add(schemaUnionMember);
            if (SaveChanges() > 0)
              SchemaUnionMembersAdded++;
          }
          var memberNamespace = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == memberType.Namespace);
          if (memberNamespace == null)
            throw new NotImplementedException($"Namespace {memberType.Namespace} in type {schemaSimpleType.TypeName} not found");
          schemaUnionMember.MemberNamespaceId = memberNamespace.Id;
          if (SaveChanges() > 0)
          {
            Console.WriteLine($"  Updating union member {schemaUnionMember.MemberTypeName} settings");
            SchemaUnionMembersUpdates++;
          }
        }
      }
    }
    else
    if (union.BaseMemberTypes != null)
    {
      schemaSimpleType.BaseTypeName = "union";
      foreach (var memberType in union.BaseMemberTypes)
      {
        var memberSimpleType = ParseXmlSchemaSimpleType(schemaSimpleType.SchemaNamespace!, memberType, $"_anon_{(++AnonSimpleTypes)}");
        var schemaUnionMember = dbContext.SchemaUnionMembers.FirstOrDefault(item =>
          item.SimpleTypeId == schemaSimpleType.Id && item.MemberTypeName == memberSimpleType.TypeName);
        if (schemaUnionMember == null)
        {
          Console.WriteLine($"  Adding member value {memberSimpleType.TypeName}");
          schemaUnionMember = new SchemaUnionMember { SimpleTypeId = schemaSimpleType.Id, MemberTypeName = memberSimpleType.TypeName };
          dbContext.SchemaUnionMembers.Add(schemaUnionMember);
          if (SaveChanges() > 0)
            SchemaUnionMembersAdded++;
        }
        var url = memberSimpleType.SchemaNamespace!.Url;
        var memberNamespace = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == url);
        if (memberNamespace == null)
          throw new NotImplementedException($"Namespace {url} in type {schemaSimpleType.TypeName} not found");
        schemaUnionMember.MemberNamespaceId = memberNamespace.Id;
        if (SaveChanges() > 0)
        {
          Console.WriteLine($"  Updating union member {schemaUnionMember.MemberTypeName} settings");
          SchemaUnionMembersUpdates++;
        }
      }
    }
  }

  internal void ParseXmlSimpleTypeList(SchemaSimpleType schemaSimpleType, XmlSchemaSimpleTypeList list)
  {
    schemaSimpleType.BaseTypeName = "list";
    var itemType = list.ItemTypeName;
    var schemaListItem = dbContext.SchemaListItems.FirstOrDefault(item =>
      item.SimpleTypeId == schemaSimpleType.Id && item.ItemTypeName == itemType.Name);
    if (schemaListItem == null)
    {
      Console.WriteLine($"  Adding listItem {itemType.Name}");
      schemaListItem = new SchemaListItem { SimpleTypeId = schemaSimpleType.Id, ItemTypeName = itemType.Name };
      dbContext.SchemaListItems.Add(schemaListItem);
      if (SaveChanges() > 0)
        SchemaListItemsAdded++;
    }

    var itemNamespace = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == itemType.Namespace);
    if (itemNamespace == null)
      throw new NotImplementedException(
        $"Namespace {itemType.Namespace} in type {schemaSimpleType.TypeName} not found");
    schemaListItem.ItemNamespaceId = itemNamespace.Id;
    if (SaveChanges() > 0)
    {
      Console.WriteLine($"  Updating type list item {itemType.Name} settings");
      SchemaListItemsUpdates++;
    }
  }

  internal SchemaComplexType ParseXmlSchemaComplexType(SchemaNamespace parentNamespace, XmlSchemaComplexType xmlSchemaComplexType, string? defaultTypeName = null)
  {
    var nsId = parentNamespace.Id;
    var typeName = xmlSchemaComplexType.Name ?? defaultTypeName;
    var schemaComplexType = dbContext.SchemaComplexTypes.FirstOrDefault(item =>
      item.SchemaNamespaceId == nsId && item.TypeName == typeName);
    if (schemaComplexType == null)
    {
      Console.WriteLine($"Adding complex type {typeName}");
      schemaComplexType = new SchemaComplexType { SchemaNamespaceId = nsId, TypeName = typeName };
      dbContext.SchemaComplexTypes.Add(schemaComplexType);
      if (SaveChanges() > 0)
        SchemaComplexTypesAdded++;
    }
    if (xmlSchemaComplexType.BaseXmlSchemaType is { Name: not null })
    {
      schemaComplexType.BaseTypeName = xmlSchemaComplexType.BaseXmlSchemaType.Name;
      var ns = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == xmlSchemaComplexType.BaseXmlSchemaType.QualifiedName.Namespace);
      if (ns != null && ns.Id != nsId)
        schemaComplexType.BaseNamespaceId = ns.Id;
    }
    ParseXmlSchemaComplexTypeDetails(schemaComplexType, xmlSchemaComplexType);
    return schemaComplexType;
  }

  internal void ParseXmlSchemaComplexTypeDetails(SchemaComplexType schemaComplexType, XmlSchemaComplexType xmlSchemaComplexType)
  {
    foreach (var attribute in xmlSchemaComplexType.Attributes)
    {
      if (attribute is XmlSchemaAttribute xmlSchemaAttribute)
      {
        ParseXmlSchemaComplexTypeAttribute(schemaComplexType, xmlSchemaAttribute);
      }
      else
      if (attribute is XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef)
      {
        ParseXmlSchemaAttributeGroupRef(schemaComplexType, xmlSchemaAttributeGroupRef);
      }
      else
      {
        throw new NotImplementedException($"Attribute type {attribute.GetType()} not supported");
      }
    }

    schemaComplexType.ContentType = xmlSchemaComplexType.ContentType switch
    {
      XmlSchemaContentType.Empty => ContentType.Empty,
      XmlSchemaContentType.TextOnly => ContentType.TextOnly,
      XmlSchemaContentType.ElementOnly => ContentType.ElementOnly,
      XmlSchemaContentType.Mixed => ContentType.Mixed,
      _ => throw new NotImplementedException($"Content type {xmlSchemaComplexType.ContentType} not supported")
    };
    if (xmlSchemaComplexType.Particle != null)
      ParseXmlSchemaParticle(schemaComplexType, null, xmlSchemaComplexType.Particle, null);
  }

  internal void ParseXmlSchemaComplexTypeAttribute(SchemaComplexType schemaComplexType, XmlSchemaAttribute xmlSchemaAttribute)
  {
    SchemaAttribute? schemaAttribute;
    if (xmlSchemaAttribute.Name != null)
    {
      schemaAttribute = dbContext.SchemaAttributes.FirstOrDefault(item =>
        item.ComplexTypeId == schemaComplexType.Id && item.AttributeName == xmlSchemaAttribute.Name);
      if (schemaAttribute == null)
      {
        Console.WriteLine($"Adding attribute {xmlSchemaAttribute.Name}");
        schemaAttribute = new SchemaAttribute
        {
          ComplexTypeId = schemaComplexType.Id,
          AttributeName = xmlSchemaAttribute.Name,
        };
        dbContext.SchemaAttributes.Add(schemaAttribute);
        if (SaveChanges() > 0)
          SchemaAttributesAdded++;
      }
    }
    else
    {
      var ns = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == xmlSchemaAttribute.RefName.Namespace);
      if (ns == null)
        throw new DataException($"Namespace {xmlSchemaAttribute.RefName.Namespace} not found");
      schemaAttribute = dbContext.SchemaAttributes.FirstOrDefault(item =>
        item.ComplexTypeId == schemaComplexType.Id && item.AttributeName == xmlSchemaAttribute.RefName.Name && item.RefNamespaceId == ns.Id);
      if (schemaAttribute == null)
      {
        Console.WriteLine($"Adding attribute reference to {ns.Url} {xmlSchemaAttribute.RefName.Name}");
        schemaAttribute = new SchemaAttribute
        {
          ComplexTypeId = schemaComplexType.Id,
          AttributeName = xmlSchemaAttribute.RefName.Name,
          RefNamespaceId = ns.Id
        };
        dbContext.SchemaAttributes.Add(schemaAttribute);
        if (SaveChanges() > 0)
          SchemaAttributesAdded++;
      }
    }
    ParseXmlSchemaAttributeDetails(schemaAttribute, xmlSchemaAttribute);
  }

  internal void ParseXmlSchemaGlobalAttribute(SchemaNamespace parentNamespace, XmlSchemaAttribute xmlSchemaAttribute)
  {
    int nsId = parentNamespace.Id;
    SchemaAttribute? schemaAttribute;
    if (xmlSchemaAttribute.Name != null)
    {
      schemaAttribute = dbContext.SchemaAttributes.FirstOrDefault(item =>
        item.SchemaNamespaceId == nsId && item.AttributeName == xmlSchemaAttribute.Name);
      if (schemaAttribute == null)
      {
        Console.WriteLine($"Adding global attribute {xmlSchemaAttribute.Name}");
        schemaAttribute = new SchemaAttribute
        {
          SchemaNamespaceId = nsId,
          AttributeName = xmlSchemaAttribute.Name,
        };
        dbContext.SchemaAttributes.Add(schemaAttribute);
        if (SaveChanges() > 0)
          SchemaAttributesAdded++;
      }
    }
    else
    {
      var ns = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == xmlSchemaAttribute.RefName.Namespace);
      if (ns == null)
        throw new DataException($"Namespace {xmlSchemaAttribute.RefName.Namespace} not found");
      schemaAttribute = dbContext.SchemaAttributes.FirstOrDefault(item =>
        item.SchemaNamespaceId == nsId && item.AttributeName == xmlSchemaAttribute.RefName.Name && item.RefNamespaceId == ns.Id);
      if (schemaAttribute == null)
      {
        Console.WriteLine($"Adding global attribute reference to {ns.Url} {xmlSchemaAttribute.RefName.Name}");
        schemaAttribute = new SchemaAttribute
        {
          SchemaNamespaceId = nsId,
          AttributeName = xmlSchemaAttribute.RefName.Name,
          RefNamespaceId = ns.Id
        };
        dbContext.SchemaAttributes.Add(schemaAttribute);
        if (SaveChanges() > 0)
          SchemaAttributesAdded++;
      }
    }
    ParseXmlSchemaAttributeDetails(schemaAttribute, xmlSchemaAttribute);
  }

  internal void ParseXmlSchemaAttributeDetails(SchemaAttribute schemaAttribute, XmlSchemaAttribute xmlSchemaAttribute)
  {
    if (!string.IsNullOrEmpty(xmlSchemaAttribute.SchemaTypeName.Namespace))
    {
      var ns = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == xmlSchemaAttribute.SchemaTypeName.Namespace);
      if (ns == null)
        throw new DataException($"Namespace {xmlSchemaAttribute.SchemaTypeName.Namespace} not found");
      schemaAttribute.TypeNamespaceId = ns.Id;
    }
    else
      schemaAttribute.TypeNamespaceId = null;
    schemaAttribute.TypeName = xmlSchemaAttribute.SchemaTypeName.Name;
    schemaAttribute.Use = xmlSchemaAttribute.Use switch
    {
      XmlSchemaUse.None => null, //AttributeUse.None,
      XmlSchemaUse.Optional => AttributeUse.Optional,
      XmlSchemaUse.Prohibited => AttributeUse.Prohibited,
      XmlSchemaUse.Required => AttributeUse.Required,
      _ => null
    };
    schemaAttribute.DefaultValue = xmlSchemaAttribute.DefaultValue ?? xmlSchemaAttribute.FixedValue;
    schemaAttribute.IsFixed = xmlSchemaAttribute.FixedValue != null;
    if (SaveChanges() > 0)
    {
      Console.WriteLine($"  Updating attribute {schemaAttribute.AttributeName} settings");
      SchemaAttributesUpdates++;
    }
  }


  internal void ParseXmlSchemaAttributeGroup(SchemaNamespace parentNamespace, XmlSchemaAttributeGroup xmlSchemaAttributeGroup)
  {
    int nsId = parentNamespace.Id;
    if (xmlSchemaAttributeGroup.Name != null)
    {
      var schemaAttributeGroup = dbContext.SchemaAttributeGroups.FirstOrDefault(item =>
        item.SchemaNamespaceId == nsId && item.GroupName == xmlSchemaAttributeGroup.Name);
      if (schemaAttributeGroup == null)
      {
        Console.WriteLine($"Adding attribute group {xmlSchemaAttributeGroup.Name}");
        schemaAttributeGroup = new SchemaAttributeGroup
        {
          SchemaNamespaceId = nsId,
          GroupName = xmlSchemaAttributeGroup.Name,
        };
        dbContext.SchemaAttributeGroups.Add(schemaAttributeGroup);
        if (SaveChanges() > 0)
          SchemaAttributeGroupsAdded++;
      }
      foreach (var attribute in xmlSchemaAttributeGroup.Attributes)
      {
        if (attribute is XmlSchemaAttribute xmlSchemaAttribute)
        {
          ParseXmlSchemaGroupAttribute(schemaAttributeGroup, xmlSchemaAttribute);
        }
        else
        if (attribute is XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef)
        {
          ParseXmlSchemaAttributeGroupRef(schemaAttributeGroup, xmlSchemaAttributeGroupRef);
        }
        else
        {
          throw new NotImplementedException($"Attribute type {attribute.GetType()} not supported");
        }
      }
    }
    else
    {
      throw new NotImplementedException("Anonymous attribute group not supported");
    }
    if (xmlSchemaAttributeGroup.AnyAttribute != null)
    {
      throw new NotImplementedException("Any attribute not supported");
    }
    if (xmlSchemaAttributeGroup.RedefinedAttributeGroup != null)
    {
      throw new NotImplementedException("Redefined attribute group not supported");
    }
  }

  internal void ParseXmlSchemaGroupAttribute(SchemaAttributeGroup schemaAttributeGroup, XmlSchemaAttribute xmlSchemaAttribute)
  {
    SchemaAttribute? schemaAttribute;
    if (xmlSchemaAttribute.Name != null)
    {
      schemaAttribute = dbContext.SchemaAttributes.FirstOrDefault(item =>
        item.AttributeGroupId == schemaAttributeGroup.Id && item.AttributeName == xmlSchemaAttribute.Name);
      if (schemaAttribute == null)
      {
        Console.WriteLine($"Adding group attribute {xmlSchemaAttribute.Name}");
        schemaAttribute = new SchemaAttribute
        {
          AttributeGroupId = schemaAttributeGroup.Id,
          AttributeName = xmlSchemaAttribute.Name,
        };
        dbContext.SchemaAttributes.Add(schemaAttribute);
        if (SaveChanges() > 0)
          SchemaAttributeGroupsAdded++;
      }
    }
    else
    {
      var ns = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == xmlSchemaAttribute.RefName.Namespace);
      if (ns == null)
        throw new DataException($"Namespace {xmlSchemaAttribute.RefName.Namespace} not found");
      schemaAttribute = dbContext.SchemaAttributes.FirstOrDefault(item =>
        item.AttributeGroupId == schemaAttributeGroup.Id && item.AttributeName == xmlSchemaAttribute.RefName.Name && item.RefNamespaceId == ns.Id);
      if (schemaAttribute == null)
      {
        Console.WriteLine($"Adding group attribute reference to {ns.Url} {xmlSchemaAttribute.RefName.Name}");
        schemaAttribute = new SchemaAttribute
        {
          AttributeGroupId = schemaAttributeGroup.Id,
          AttributeName = xmlSchemaAttribute.RefName.Name,
          RefNamespaceId = ns.Id
        };
        dbContext.SchemaAttributes.Add(schemaAttribute);
        if (SaveChanges() > 0)
          SchemaAttributeGroupsAdded++;
      }
    }
    ParseXmlSchemaAttributeDetails(schemaAttribute, xmlSchemaAttribute);
  }

  internal void ParseXmlSchemaAttributeGroupRef(SchemaComplexType parentComplexType, XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef)
  {
    var ns = dbContext.SchemaNamespaces.First(item => item.Url == xmlSchemaAttributeGroupRef.RefName.Namespace);
    int? nsId = parentComplexType.SchemaNamespaceId;
    if (ns.Id == nsId)
      nsId = null;
    var schemaAttributeGroupRef = dbContext.SchemaAttributeGroupRefs.FirstOrDefault(item =>
      item.ComplexTypeId == parentComplexType.Id && item.RefName == xmlSchemaAttributeGroupRef.RefName.Name && item.RefNamespaceId == nsId);
    if (schemaAttributeGroupRef == null)
    {
      Console.WriteLine($"Adding attribute group ref {xmlSchemaAttributeGroupRef.RefName.Name}");
      schemaAttributeGroupRef = new SchemaAttributeGroupRef
      {
        ComplexTypeId = parentComplexType.Id,
        RefName = xmlSchemaAttributeGroupRef.RefName.Name,
        RefNamespaceId = nsId
      };
      dbContext.SchemaAttributeGroupRefs.Add(schemaAttributeGroupRef);
      if (SaveChanges() > 0)
        SchemaAttributeGroupRefsAdded++;
    }
  }

  internal void ParseXmlSchemaAttributeGroupRef(SchemaAttributeGroup parentAttributeGroup, XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef)
  {
    var ns = dbContext.SchemaNamespaces.First(item => item.Url == xmlSchemaAttributeGroupRef.RefName.Namespace);
    int? nsId = parentAttributeGroup.SchemaNamespaceId;
    if (ns.Id == nsId)
      nsId = null;
    var schemaAttributeGroupRef = dbContext.SchemaAttributeGroupRefs.FirstOrDefault(item =>
      item.AttributeGroupId == parentAttributeGroup.Id && item.RefName == xmlSchemaAttributeGroupRef.RefName.Name && item.RefNamespaceId == nsId);
    if (schemaAttributeGroupRef == null)
    {
      Console.WriteLine($"Adding attribute group ref {xmlSchemaAttributeGroupRef.RefName.Name}");
      schemaAttributeGroupRef = new SchemaAttributeGroupRef
      {
        AttributeGroupId = parentAttributeGroup.Id,
        RefName = xmlSchemaAttributeGroupRef.RefName.Name,
        RefNamespaceId = nsId
      };
      dbContext.SchemaAttributeGroupRefs.Add(schemaAttributeGroupRef);
      if (SaveChanges() > 0)
        SchemaAttributeGroupRefsAdded++;
    }
  }

  internal void ParseXmlSchemaParticle(SchemaComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaParticle xmlSchemaParticle, int? ordNum)
  {
    if (xmlSchemaParticle is XmlSchemaElement xmlSchemaElement)
    {
      ParseXmlSchemaElement(parentComplexType, parentParticle, xmlSchemaElement, ordNum);
    }
    else
    if (xmlSchemaParticle is XmlSchemaSequence xmlSchemaSequence)
    {
      ParseXmlSchemaSequence(parentComplexType, parentParticle, xmlSchemaSequence, ordNum);
    }
    else
    if (xmlSchemaParticle is XmlSchemaAny xmlSchemaAny)
    {
      ParseXmlSchemaAny(parentComplexType, parentParticle, xmlSchemaAny, ordNum);
    }
    else
    if (xmlSchemaParticle is XmlSchemaAll xmlSchemaAll)
    {
      ParseXmlSchemaAll(parentComplexType, parentParticle, xmlSchemaAll, ordNum);
    }
    else
    if (xmlSchemaParticle is XmlSchemaChoice xmlSchemaChoice)
    {
      ParseXmlSchemaChoice(parentComplexType, parentParticle, xmlSchemaChoice, ordNum);
    }
    else

    if (xmlSchemaParticle is XmlSchemaGroupRef xmlSchemaGroupRef)
    {
      ParseXmlSchemaGroupRef(parentComplexType, parentParticle, xmlSchemaGroupRef, ordNum);
    }
    else
    {
      throw new NotImplementedException($"Sequence item type {xmlSchemaParticle.GetType()} not supported");
    }
  }

  internal void ParseXmlSchemaParticle(SchemaGroup parentGroup, SchemaParticle? parentParticle, XmlSchemaParticle xmlSchemaParticle, int? ordNum)
  {
    if (xmlSchemaParticle is XmlSchemaElement xmlSchemaElement)
    {
      ParseXmlSchemaElement(parentGroup, parentParticle, xmlSchemaElement, ordNum);
    }
    else
    if (xmlSchemaParticle is XmlSchemaSequence xmlSchemaSequence)
    {
      ParseXmlSchemaSequence(parentGroup, parentParticle, xmlSchemaSequence, ordNum);
    }
    else
    if (xmlSchemaParticle is XmlSchemaAny xmlSchemaAny)
    {
      ParseXmlSchemaAny(parentGroup, parentParticle, xmlSchemaAny, ordNum);
    }
    else
    if (xmlSchemaParticle is XmlSchemaAll xmlSchemaAll)
    {
      ParseXmlSchemaAll(parentGroup, parentParticle, xmlSchemaAll, ordNum);
    }
    else
    if (xmlSchemaParticle is XmlSchemaChoice xmlSchemaChoice)
    {
      ParseXmlSchemaChoice(parentGroup, parentParticle, xmlSchemaChoice, ordNum);
    }
    else

    if (xmlSchemaParticle is XmlSchemaGroupRef xmlSchemaGroupRef)
    {
      ParseXmlSchemaGroupRef(parentGroup, parentParticle, xmlSchemaGroupRef, ordNum);
    }
    else
    {
      throw new NotImplementedException($"Sequence item type {xmlSchemaParticle.GetType()} not supported");
    }
  }
  internal void ParseXmlSchemaAny(SchemaComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaAny xmlSchemaAny, int? ordNum)
  {
    var schemaAny = (SchemaAny?)dbContext.SchemaParticles.FirstOrDefault(item =>
      item.ComplexTypeId == parentComplexType.Id && item.OrdNum == ordNum && item.ParticleType == ParticleType.Any);
    if (schemaAny == null)
    {
      schemaAny = new SchemaAny
      {
        ComplexTypeId = parentComplexType.Id,
        ParentParticleId = parentParticle?.Id,
        OrdNum = ordNum
      };
      dbContext.SchemaParticles.Add(schemaAny);
      if (SaveChanges() > 0)
      {
        Console.WriteLine($"Adding Any particle {schemaAny.Id}");
        SchemaParticlesAdded++;
      }
    }
    ParseXmlSchemaAnyDetails(schemaAny, xmlSchemaAny);
  }

  internal void ParseXmlSchemaAny(SchemaGroup parentGroup, SchemaParticle? parentParticle, XmlSchemaAny xmlSchemaAny, int? ordNum)
  {
    var schemaAny = (SchemaAny?)dbContext.SchemaParticles.FirstOrDefault(item =>
      item.GroupId == parentGroup.Id && item.OrdNum == ordNum && item.ParticleType == ParticleType.Any);
    if (schemaAny == null)
    {
      schemaAny = new SchemaAny
      {
        GroupId = parentGroup.Id,
        ParentParticleId = parentParticle?.Id,
        OrdNum = ordNum
      };
      dbContext.SchemaParticles.Add(schemaAny);
      if (SaveChanges() > 0)
      {
        Console.WriteLine($"Adding Any particle {schemaAny.Id}");
        SchemaParticlesAdded++;
      }
    }
    ParseXmlSchemaAnyDetails(schemaAny, xmlSchemaAny);
  }

  internal void ParseXmlSchemaAnyDetails(SchemaAny schemaAny, XmlSchemaAny xmlSchemaAny)
  {
    schemaAny.Namespace = xmlSchemaAny.Namespace;
    schemaAny.ProcessContents = xmlSchemaAny.ProcessContents switch
    {
      XmlSchemaContentProcessing.Lax => ContentProcessing.Lax,
      XmlSchemaContentProcessing.Skip => ContentProcessing.Skip,
      XmlSchemaContentProcessing.Strict => ContentProcessing.Strict,
      _ => null
    };
    schemaAny.MinOccurs = GetOccurs(xmlSchemaAny.MinOccurs, xmlSchemaAny.MinOccursString);
    schemaAny.MaxOccurs = GetOccurs(xmlSchemaAny.MaxOccurs, xmlSchemaAny.MaxOccursString);
    if (SaveChanges() > 0)
    {
      Console.WriteLine($"  Updating Any particle {schemaAny.Id} settings");
      SchemaParticlesUpdates++;
    }
  }

  internal void ParseXmlSchemaGroupRef(SchemaComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaGroupRef xmlSchemaGroupRef, int? ordNum)
  {
    var parentParticleId = parentParticle?.Id; var schemaGroupRef = (SchemaGroupRef?)dbContext.SchemaParticles.FirstOrDefault(item =>
      item.ComplexTypeId == parentComplexType.Id && item.ParentParticleId == parentParticleId && item.OrdNum == ordNum && item.ParticleType == ParticleType.GroupRef);
    if (schemaGroupRef == null)
    {
      schemaGroupRef = new SchemaGroupRef
      {
        ComplexTypeId = parentComplexType.Id,
        ParentParticleId = parentParticle?.Id,
        OrdNum = ordNum
      };
      dbContext.SchemaParticles.Add(schemaGroupRef);
      if (SaveChanges() > 0)
      {
        Console.WriteLine($"Adding GroupRef particle {schemaGroupRef.Id}");
        SchemaGroupRefsAdded++;
      }
    }
    ParseXmlSchemaGroupRefDetails(schemaGroupRef, xmlSchemaGroupRef);
  }
  internal void ParseXmlSchemaGroupRef(SchemaGroup parentGroup, SchemaParticle? parentParticle, XmlSchemaGroupRef xmlSchemaGroupRef, int? ordNum)
  {
    var parentParticleId = parentParticle?.Id;
    var schemaGroupRef = (SchemaGroupRef?)dbContext.SchemaParticles.FirstOrDefault(item =>
      item.GroupId == parentGroup.Id && item.ParentParticleId == parentParticleId && item.OrdNum == ordNum && item.ParticleType == ParticleType.GroupRef);
    if (schemaGroupRef == null)
    {
      schemaGroupRef = new SchemaGroupRef
      {
        GroupId = parentGroup.Id,
        ParentParticleId = parentParticle?.Id,
        OrdNum = ordNum
      };
      dbContext.SchemaParticles.Add(schemaGroupRef);
      if (SaveChanges() > 0)
      {
        Console.WriteLine($"Adding GroupRef particle {schemaGroupRef.Id}");
        SchemaGroupRefsAdded++;
      }
    }
    ParseXmlSchemaGroupRefDetails(schemaGroupRef, xmlSchemaGroupRef);
  }

  private void ParseXmlSchemaGroupRefDetails(SchemaGroupRef schemaGroupRef, XmlSchemaGroupRef xmlSchemaGroupRef)
  {
    schemaGroupRef.RefName = xmlSchemaGroupRef.RefName.Name;
    var ns = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == xmlSchemaGroupRef.RefName.Namespace);
    if (ns == null)
      throw new DataException($"Namespace {xmlSchemaGroupRef.RefName.Namespace} not found");
    int? nsId = ns.Id;
    if (nsId == schemaGroupRef.OwnerNamespace?.Id)
      nsId = null;

    schemaGroupRef.RefNamespaceId = nsId;
    schemaGroupRef.MinOccurs = GetOccurs(xmlSchemaGroupRef.MinOccurs, xmlSchemaGroupRef.MinOccursString);
    schemaGroupRef.MaxOccurs = GetOccurs(xmlSchemaGroupRef.MaxOccurs, xmlSchemaGroupRef.MaxOccursString);
    if (SaveChanges() > 0)
    {
      Console.WriteLine($"  Updating GroupRef {schemaGroupRef.Id} settings");
      SchemaGroupRefsUpdates++;
    }
  }

  internal void ParseXmlSchemaSequence(SchemaComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaSequence xmlSchemaSequence, int? ordNum)
  {
    var parentParticleId = parentParticle?.Id;
    var particle = (SchemaSequence?)dbContext.SchemaParticles.FirstOrDefault(item =>
      item.ComplexTypeId == parentComplexType.Id && item.ParentParticleId == parentParticleId && item.OrdNum == ordNum && item.ParticleType == ParticleType.Sequence);
    if (particle == null)
    {
      particle = new SchemaSequence
      {
        ComplexTypeId = parentComplexType.Id,
        ParentParticleId = parentParticle?.Id,
        OrdNum = ordNum
      };
      dbContext.SchemaParticles.Add(particle);
      if (SaveChanges() > 0)
      {
        Console.WriteLine($"Adding Sequence particle {particle.Id}");
        SchemaParticlesAdded++;
      }
    }
    ParseXmlSchemaGroupBaseDetails(particle, parentComplexType, xmlSchemaSequence);
  }

  internal void ParseXmlSchemaSequence(SchemaGroup parentGroup, SchemaParticle? parentParticle, XmlSchemaSequence xmlSchemaSequence, int? ordNum)
  {
    var parentParticleId = parentParticle?.Id;
    var particle = (SchemaSequence?)dbContext.SchemaParticles.FirstOrDefault(item =>
      item.GroupId == parentGroup.Id && item.ParentParticleId == parentParticleId && item.OrdNum == ordNum && item.ParticleType == ParticleType.Sequence);
    if (particle == null)
    {
      particle = new SchemaSequence
      {
        GroupId = parentGroup.Id,
        ParentParticleId = parentParticle?.Id,
        OrdNum = ordNum
      };
      dbContext.SchemaParticles.Add(particle);
      if (SaveChanges() > 0)
      {
        Console.WriteLine($"Adding Sequence particle {particle.Id}");
        SchemaParticlesAdded++;
      }
    }
    ParseXmlSchemaGroupBaseDetails(particle, parentGroup, xmlSchemaSequence);
  }

  internal void ParseXmlSchemaChoice(SchemaComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaChoice xmlSchemaChoice, int? ordNum)
  {
    var parentParticleId = parentParticle?.Id;
    var particle = (SchemaChoice?)dbContext.SchemaParticles.FirstOrDefault(item =>
      item.ComplexTypeId == parentComplexType.Id && item.ParentParticleId == parentParticleId && item.OrdNum == ordNum && item.ParticleType == ParticleType.Choice);
    if (particle == null)
    {
      particle = new SchemaChoice
      {
        ComplexTypeId = parentComplexType.Id,
        ParentParticleId = parentParticle?.Id,
        OrdNum = ordNum
      };
      dbContext.SchemaParticles.Add(particle);
      if (SaveChanges() > 0)
      {
        Console.WriteLine($"Adding Choice particle {particle.Id}");
        SchemaParticlesAdded++;
      }
    }
    ParseXmlSchemaGroupBaseDetails(particle, parentComplexType, xmlSchemaChoice);
  }

  internal void ParseXmlSchemaChoice(SchemaGroup parentGroup, SchemaParticle? parentParticle, XmlSchemaChoice xmlSchemaChoice, int? ordNum)
  {
    var parentParticleId = parentParticle?.Id;
    var particle = (SchemaChoice?)dbContext.SchemaParticles.FirstOrDefault(item =>
      item.GroupId == parentGroup.Id && item.ParentParticleId == parentParticleId && item.OrdNum == ordNum && item.ParticleType == ParticleType.Choice);
    if (particle == null)
    {
      particle = new SchemaChoice
      {
        GroupId = parentGroup.Id,
        ParentParticleId = parentParticle?.Id,
        OrdNum = ordNum
      };
      dbContext.SchemaParticles.Add(particle);
      if (SaveChanges() > 0)
      {
        Console.WriteLine($"Adding Choice particle {particle.Id}");
        SchemaParticlesAdded++;
      }
    }
    ParseXmlSchemaGroupBaseDetails(particle, parentGroup, xmlSchemaChoice);
  }

  internal void ParseXmlSchemaAll(SchemaComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaAll xmlSchemaAll, int? ordNum)
  {
    var parentParticleId = parentParticle?.Id;
    var particle = (SchemaAll?)dbContext.SchemaParticles.FirstOrDefault(item =>
      item.ComplexTypeId == parentComplexType.Id && item.ParentParticleId == parentParticleId && item.OrdNum == ordNum && item.ParticleType == ParticleType.All);
    if (particle == null)
    {
      particle = new SchemaAll
      {
        ComplexTypeId = parentComplexType.Id,
        ParentParticleId = parentParticle?.Id,
        OrdNum = ordNum
      };
      dbContext.SchemaParticles.Add(particle);
      if (SaveChanges() > 0)
      {
        Console.WriteLine($"Adding All particle {particle.Id}");
        SchemaParticlesAdded++;
      }
    }
    ParseXmlSchemaGroupBaseDetails(particle, parentComplexType, xmlSchemaAll);
  }

  internal void ParseXmlSchemaAll(SchemaGroup parentGroup, SchemaParticle? parentParticle, XmlSchemaAll xmlSchemaAll, int? ordNum)
  {
    var parentParticleId = parentParticle?.Id;
    var particle = (SchemaAll?)dbContext.SchemaParticles.FirstOrDefault(item =>
      item.GroupId == parentGroup.Id && item.ParentParticleId == parentParticleId && item.OrdNum == ordNum && item.ParticleType == ParticleType.All);
    if (particle == null)
    {
      particle = new SchemaAll
      {
        GroupId = parentGroup.Id,
        ParentParticleId = parentParticle?.Id,
        OrdNum = ordNum
      };
      dbContext.SchemaParticles.Add(particle);
      if (SaveChanges() > 0)
      {
        Console.WriteLine($"Adding All particle {particle.Id}");
        SchemaParticlesAdded++;
      }
    }
    ParseXmlSchemaGroupBaseDetails(particle, parentGroup, xmlSchemaAll);
    }

    private void ParseXmlSchemaGroupBaseDetails(SchemaGroupBase particle, SchemaComplexType parentComplexType,
      XmlSchemaGroupBase xmlSchemaGroupBase)
    {
      particle.MinOccurs = GetOccurs(xmlSchemaGroupBase.MinOccurs, xmlSchemaGroupBase.MinOccursString);
      particle.MaxOccurs = GetOccurs(xmlSchemaGroupBase.MaxOccurs, xmlSchemaGroupBase.MaxOccursString);
      if (SaveChanges() > 0)
        Console.WriteLine($"  Updating Sequence particle {particle.Id} settings");
      int ordNum1 = 0;
      foreach (var item in xmlSchemaGroupBase.Items)
      {
        ordNum1++;
        if (item is XmlSchemaParticle xmlSchemaParticle)
          ParseXmlSchemaParticle(parentComplexType, particle, xmlSchemaParticle, ordNum1);
        else
        {
          throw new NotImplementedException($"Sequence item type {item.GetType()} not supported");
        }
      }
    }

    private void ParseXmlSchemaGroupBaseDetails(SchemaGroupBase particle, SchemaGroup parentGroup,
      XmlSchemaGroupBase xmlSchemaGroupBase)
    {
      particle.MinOccurs = GetOccurs(xmlSchemaGroupBase.MinOccurs, xmlSchemaGroupBase.MinOccursString);
      particle.MaxOccurs = GetOccurs(xmlSchemaGroupBase.MaxOccurs, xmlSchemaGroupBase.MaxOccursString);
      if (SaveChanges() > 0)
        Console.WriteLine($"  Updating Sequence particle {particle.Id} settings");
      int ordNum1 = 0;
      foreach (var item in xmlSchemaGroupBase.Items)
      {
        ordNum1++;
        if (item is XmlSchemaParticle xmlSchemaParticle)
          ParseXmlSchemaParticle(parentGroup, particle, xmlSchemaParticle, ordNum1);
        else
        {
          throw new NotImplementedException($"Sequence item type {item.GetType()} not supported");
        }
      }
    }

    internal void ParseXmlSchemaElement(SchemaComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaElement xmlSchemaElement, int? ordNum)
    {
      var parentParticleId = parentParticle?.Id;
      SchemaElement? schemaElement;
      if (xmlSchemaElement.Name != null)
      {
        schemaElement = dbContext.SchemaElements.FirstOrDefault(item =>
          item.ComplexTypeId == parentComplexType.Id && item.ParentParticleId == parentParticleId
          && item.ParticleType == ParticleType.Element && item.OrdNum == ordNum && item.Name == xmlSchemaElement.Name);
        if (schemaElement == null)
        {
          Console.WriteLine($"Adding element {xmlSchemaElement.Name}");
          schemaElement = new SchemaElement
          {
            ComplexTypeId = parentComplexType.Id,
            ParentParticleId = parentParticle?.Id,
            OrdNum = ordNum,
            Name = xmlSchemaElement.Name,
          };
          dbContext.SchemaElements.Add(schemaElement);
          if (SaveChanges() >0)
            SchemaElementsAdded++;
        }
      }
      else
      {
        var ns = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == xmlSchemaElement.RefName.Namespace);
        if (ns == null)
          throw new DataException($"Namespace {xmlSchemaElement.RefName.Namespace} not found");
        int? nsId = ns.Id;
        if (nsId == parentComplexType.ParentNamespace?.Id)
          nsId = null;
        schemaElement = dbContext.SchemaElements.FirstOrDefault(item =>
          item.ComplexTypeId == parentComplexType.Id && item.ParentParticleId == parentParticleId
          && item.ParticleType == ParticleType.Element && item.OrdNum == ordNum && item.Name == xmlSchemaElement.RefName.Name && item.RefNamespaceId == nsId);
        if (schemaElement == null)
        {
          Console.WriteLine($"Adding element reference to {ns.Url} {xmlSchemaElement.RefName.Name}");
          schemaElement = new SchemaElement
          {
            ComplexTypeId = parentComplexType.Id,
            ParentParticleId = parentParticle?.Id,
            OrdNum = ordNum,
            Name = xmlSchemaElement.RefName.Name,
            RefNamespaceId = nsId
          };
          dbContext.SchemaElements.Add(schemaElement);
          if (SaveChanges() > 0)
            SchemaElementsAdded++;
      }
      }
      ParseXmlSchemaElementDetails(schemaElement, xmlSchemaElement);
    }

    internal void ParseXmlSchemaElement(SchemaGroup parentGroup, SchemaParticle? parentParticle, XmlSchemaElement xmlSchemaElement, int? ordNum)
    {
      var parentParticleId = parentParticle?.Id;
      SchemaElement? schemaElement;
      if (xmlSchemaElement.Name != null)
      {
        schemaElement = dbContext.SchemaElements.FirstOrDefault(item =>
          item.GroupId == parentGroup.Id && item.ParentParticleId == parentParticleId
          && item.ParticleType == ParticleType.Element && item.OrdNum == ordNum && item.Name == xmlSchemaElement.Name);
        if (schemaElement == null)
        {
          Console.WriteLine($"Adding element {xmlSchemaElement.Name}");
          schemaElement = new SchemaElement
          {
            GroupId = parentGroup.Id,
            ParentParticleId = parentParticle?.Id,
            OrdNum = ordNum,
            Name = xmlSchemaElement.Name,
          };
          dbContext.SchemaElements.Add(schemaElement);
          if (SaveChanges() > 0)
            SchemaElementsAdded++;
      }
      }
      else
      {
        var ns = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == xmlSchemaElement.RefName.Namespace);
        if (ns == null)
          throw new DataException($"Namespace {xmlSchemaElement.RefName.Namespace} not found");
        int? nsId = ns.Id;
        if (nsId == parentGroup.ParentNamespace?.Id)
          nsId = null;
        schemaElement = dbContext.SchemaElements.FirstOrDefault(item =>
          item.GroupId == parentGroup.Id && item.ParentParticleId == parentParticleId
          && item.ParticleType == ParticleType.Element && item.OrdNum == ordNum && item.Name == xmlSchemaElement.RefName.Name && item.RefNamespaceId == nsId);
        if (schemaElement == null)
        {
          Console.WriteLine($"Adding element reference to {ns.Url} {xmlSchemaElement.RefName.Name}");
          schemaElement = new SchemaElement
          {
            GroupId = parentGroup.Id,
            ParentParticleId = parentParticle?.Id,
            OrdNum = ordNum,
            Name = xmlSchemaElement.RefName.Name,
            RefNamespaceId = nsId
          };
          dbContext.SchemaElements.Add(schemaElement);
          if (SaveChanges() > 0)
            SchemaElementsAdded++;
      }
      }
      ParseXmlSchemaElementDetails(schemaElement, xmlSchemaElement);
    }

    internal void ParseXmlSchemaGlobalElement(SchemaNamespace parentNamespace, XmlSchemaElement xmlSchemaElement)
    {
      var nsId = parentNamespace.Id;
      SchemaElement? schemaElement;
      if (xmlSchemaElement.Name != null)
      {
        schemaElement = dbContext.SchemaElements.FirstOrDefault(item =>
          item.SchemaNamespaceId == nsId && item.ParticleType == ParticleType.Element && item.Name == xmlSchemaElement.Name);
        if (schemaElement == null)
        {
          Console.WriteLine($"Adding global element {xmlSchemaElement.Name}");
          schemaElement = new SchemaElement
          {
            SchemaNamespaceId = nsId,
            Name = xmlSchemaElement.Name,
          };
          dbContext.SchemaElements.Add(schemaElement);
          if (SaveChanges() > 0)
            SchemaElementsAdded++;
      }
      }
      else
      {
        var ns = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == xmlSchemaElement.RefName.Namespace);
        if (ns == null)
          throw new DataException($"Namespace {xmlSchemaElement.RefName.Namespace} not found");
        schemaElement = dbContext.SchemaElements.FirstOrDefault(item =>
          item.SchemaNamespaceId == nsId && item.Name == xmlSchemaElement.RefName.Name && item.RefNamespaceId == ns.Id);
        if (schemaElement == null)
        {
          Console.WriteLine($"Adding element reference to {ns.Url} {xmlSchemaElement.RefName.Name}");
          schemaElement = new SchemaElement
          {
            SchemaNamespaceId = nsId,
            Name = xmlSchemaElement.RefName.Name,
            RefNamespaceId = ns.Id
          };
          dbContext.SchemaElements.Add(schemaElement);
          SaveChanges(); if (SaveChanges() > 0)
            SchemaElementsAdded++;
        }
      }
      ParseXmlSchemaElementDetails(schemaElement, xmlSchemaElement);
    }

    internal void ParseXmlSchemaElementDetails(SchemaElement schemaElement, XmlSchemaElement xmlSchemaElement)
    {
      if (!string.IsNullOrEmpty(xmlSchemaElement.SchemaTypeName.Namespace))
      {
        var ns = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == xmlSchemaElement.SchemaTypeName.Namespace);
        if (ns == null)
          throw new DataException($"Namespace {xmlSchemaElement.SchemaTypeName.Namespace} not found");
        int? nsId = ns.Id; ;
        if (nsId == schemaElement.OwnerNamespace?.Id)
          nsId = null;
        schemaElement.TypeNamespaceId = nsId;
      }
      schemaElement.TypeName = xmlSchemaElement.SchemaTypeName.Name;
      schemaElement.MinOccurs = GetOccurs(xmlSchemaElement.MinOccurs, xmlSchemaElement.MinOccursString);
      schemaElement.MaxOccurs = GetOccurs(xmlSchemaElement.MaxOccurs, xmlSchemaElement.MaxOccursString);
      if (SaveChanges() > 0)
      {
        Console.WriteLine($"  Updating element {schemaElement.Name} settings");
        SchemaElementsUpdates++;
      }
    }

    private int? GetOccurs(decimal? value, string? valString)
    {
      if (valString == "unbounded")
        return Int32.MaxValue;
      if (value == null)
        return null;
      if (value == decimal.Zero)
        return 0;
      if (value == decimal.One)
        return 1;
      if (value == decimal.MinusOne)
        return -1;
      if (value == decimal.MaxValue)
        return int.MaxValue;
      if (value == decimal.MinValue)
        return int.MinValue;
      return (int)value;
    }

    internal void ParseXmlSchemaGroup(SchemaNamespace parentNamespace, XmlSchemaGroup xmlSchemaGroup)
    {
      var nsId = parentNamespace.Id;
      if (xmlSchemaGroup.Name != null)
      {
        var schemaGroup = dbContext.SchemaGroups.FirstOrDefault(item =>
          item.SchemaNamespaceId == nsId && item.GroupName == xmlSchemaGroup.Name);
        if (schemaGroup == null)
        {
          Console.WriteLine($"Adding global group {xmlSchemaGroup.Name}");
          schemaGroup = new SchemaGroup
          {
            SchemaNamespaceId = nsId,
            GroupName = xmlSchemaGroup.Name,
          };
          dbContext.SchemaGroups.Add(schemaGroup);
          if (SaveChanges() > 0)
            SchemaGroupsAdded++;
        }
        if (xmlSchemaGroup.Particle != null)
        {
          ParseXmlSchemaGroupParticle(schemaGroup, null, xmlSchemaGroup.Particle, null);
        }
      }
      else
        throw new InvalidDataException("Global group without name is not supported");
    }

    internal void ParseXmlSchemaGroupParticle(SchemaGroup schemaGroup, SchemaParticle? parentParticle, XmlSchemaParticle xmlSchemaParticle, int? ordNum)
    {
      if (xmlSchemaParticle is XmlSchemaElement xmlSchemaElement)
      {
        ParseXmlSchemaElement(schemaGroup, parentParticle, xmlSchemaElement, ordNum);
      }
      else
      if (xmlSchemaParticle is XmlSchemaSequence xmlSchemaSequence)
      {
        ParseXmlSchemaSequence(schemaGroup, parentParticle, xmlSchemaSequence, ordNum);
      }
      else
      if (xmlSchemaParticle is XmlSchemaAny xmlSchemaAny)
      {
        ParseXmlSchemaAny(schemaGroup, parentParticle, xmlSchemaAny, ordNum);
      }
      else
      if (xmlSchemaParticle is XmlSchemaAll xmlSchemaAll)
      {
        ParseXmlSchemaAll(schemaGroup, parentParticle, xmlSchemaAll, ordNum);
      }
      else
      if (xmlSchemaParticle is XmlSchemaChoice xmlSchemaChoice)
      {
        ParseXmlSchemaChoice(schemaGroup, parentParticle, xmlSchemaChoice, ordNum);
      }
      else

      if (xmlSchemaParticle is XmlSchemaGroupRef xmlSchemaGroupRef)
      {
        ParseXmlSchemaGroupRef(schemaGroup, parentParticle, xmlSchemaGroupRef, ordNum);
      }
      else
      {
        throw new NotImplementedException($"Sequence item type {xmlSchemaParticle.GetType()} not supported");
      }
    }

  }
