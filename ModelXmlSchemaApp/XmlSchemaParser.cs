using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Schema;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

using ModelXmlSchema;

namespace ModelXmlSchemaApp;


/// <summary>
/// Parser that reads XML schema files and stores the schema in a database.
/// </summary>
public class XmlSchemaParser
{
  public string SourceXsdPath { get; set; } = null!;
  public int SchemaFilesTotal, SchemaFilesAdded, SchemaFilesUpdated;
  public int NamespacesTotal, NamespacesAdded, NamespacesUpdates;
  public int UsedNamespacesTotal, UsedNamespacesAdded;
  public int SimpleTypesTotal, SimpleTypesAdded, SimpleTypesUpdates;
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

  internal void Write(string? message)
  {
    Console.Write(message);
  }

  internal void WriteLine(string? message)
  {
    Console.WriteLine(message);
  }

  internal void ParseSchemaFilesAndNamespaces(XmlSchemaSet schemaSet)
  {
    dbContext.LoadFiles();
    foreach (XmlSchema schema in schemaSet.Schemas())
    {
      if (schema.Id != null)
      {
        string filename = schema.Id;
        if (!dbContext.FilesDictionary.TryGetValue(filename, out var schemaFile))
        {
          schemaFile = new SchemaFile { FileName = filename };
          dbContext.SchemaFiles.Add(schemaFile);
          if (SaveChanges() > 0)
          {
            SchemaFilesAdded++;
          }
        }
        if (schema.TargetNamespace != null)
        {
          var ns = schema.TargetNamespace;
          Write($"Checking schema namespace {schema.TargetNamespace} ... ");
          if (!dbContext.NamespaceDictionary.TryGetValue(ns, out var Namespace))
          {
            Namespace = new Namespace { Url = ns };
            dbContext.Namespaces.Add(Namespace);
            if (SaveChanges() > 0)
            {
              NamespacesAdded++;
              WriteLine("added");
            }
          }
          else
          {
            WriteLine("found");
          }
          if (schemaFile.TargetNamespaceId != Namespace.Id)
          {
            schemaFile.TargetNamespaceId = Namespace.Id;
            SaveChanges();
            SchemaFilesUpdated++;
          }
        }
        var namespaces = schema.Namespaces.ToArray();
        for (int i = 0; i < namespaces.Count(); i++)
        {
          var ns = namespaces[i];
          if (ns.Namespace != schema.TargetNamespace && ns.Namespace != "#all")
          {
            var Namespace = dbContext.Namespaces.FirstOrDefault(item => item.Url == ns.Namespace);
            if (Namespace == null)
            {
              WriteLine($"  adding namespace {ns.Namespace}");
              Namespace = new Namespace { Url = ns.Namespace };
              dbContext.Namespaces.Add(Namespace);
              if (SaveChanges() > 0)
                NamespacesAdded++;
            }
            var schemaUsedNamespace = dbContext.UsedNamespaces.FirstOrDefault(item =>
                      item.FileId == schemaFile.Id && item.NamespaceId == Namespace.Id && item.Prefix == ns.Name);
            if (schemaUsedNamespace == null)
            {
              WriteLine($"  adding used namespace {schemaFile.Id} -> {Namespace.Id}");
              schemaUsedNamespace = new UsedNamespace { FileId = schemaFile.Id, NamespaceId = Namespace.Id, Prefix = ns.Name };
              dbContext.UsedNamespaces.Add(schemaUsedNamespace);
              if (SaveChanges() > 0)
                UsedNamespacesAdded++;
            }
          }
        }
      }
    }

    SchemaFilesTotal = dbContext.SchemaFiles.Count();
    NamespacesTotal = dbContext.Namespaces.Count();
    UsedNamespacesTotal = dbContext.UsedNamespaces.Count();
  }

  internal void SetNamespacePrefixes()
  {
    var NamespacePrefixes = dbContext.UsedNamespaces
      .GroupBy(item => new { item.NamespaceId, item.Prefix })
      .Select(group => new NamespacePrefix()
      {
        NamespaceId = group.Key.NamespaceId,
        Prefix = group.Key.Prefix,
        Count = group.Count()
      });
    foreach (var NamespacePrefix in NamespacePrefixes)
    {
      var Namespace = dbContext.Namespaces.FirstOrDefault(item => item.Id == NamespacePrefix.NamespaceId);
      if (Namespace != null)
      {
        Namespace.Prefix = NamespacePrefix.Prefix;
      }
    }

    if (SaveChanges() > 0)
    {
      WriteLine("Setting namespace prefix");
      NamespacesUpdates++;
    }
  }

  internal void ParseXmlSchemaSet(XmlSchemaSet schemaSet)
  {
    dbContext.LoadNamespaces();
    foreach (XmlSchema schema in schemaSet.Schemas())
    {
      ParseXmlSchema(schema);
    }
    SimpleTypesTotal = dbContext.Types.Count(item => !item.IsComplex);
    SchemaComplexTypesTotal = dbContext.Types.Count(item => item.IsComplex);
    SchemaAttributesTotal = dbContext.Attributes.Count();
    SchemaAttributeGroupsTotal = dbContext.AttributeGroups.Count();
    SchemaAttributeGroupRefsTotal = dbContext.AttributeGroupRefs.Count();
    SchemaParticlesTotal = dbContext.Particles.Count();
    SchemaEnumValuesTotal = dbContext.EnumValues.Count();
    SchemaPatternsTotal = dbContext.Patterns.Count();
    SchemaListItemsTotal = dbContext.ListItems.Count();
    SchemaUnionMembersTotal = dbContext.UnionMembers.Count();
    SchemaGroupsTotal = dbContext.Groups.Count();
    SchemaGroupRefsTotal = dbContext.SchemaGroupRefs.Count();
    SchemaElementsTotal = dbContext.Elements.Count();
  }

  internal void ParseXmlSchema(XmlSchema schema)
  {
    WriteLine($"Checking {schema.Id} items");
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
        if (item is XmlSchemaSimpleType XmlSchemaSimpleType)
        {
          ParseXmlSchemaSimpleType(ns, XmlSchemaSimpleType);
        }
        //else
        //if (item is XmlSchemaComplexType xmlSchemaComplexType)
        //{
        //  ParseXmlSchemaComplexType(ns, xmlSchemaComplexType);
        //}
        //else
        //if (item is XmlSchemaGroup xmlSchemaGroup)
        //{
        //  ParseXmlSchemaGroup(ns, xmlSchemaGroup);
        //}
        //else
        //if (item is XmlSchemaElement xmlSchemaElement)
        //{
        //  ParseXmlSchemaGlobalElement(ns, xmlSchemaElement);
        //}
        //else
        //if (item is XmlSchemaAttributeGroup xmlSchemaAttributeGroup)
        //{
        //  ParseXmlSchemaAttributeGroup(ns, xmlSchemaAttributeGroup);
        //}
        //else
        //if (item is XmlSchemaAttribute xmlSchemaAttribute)
        //{
        //  ParseXmlSchemaGlobalAttribute(ns, xmlSchemaAttribute);
        //}
        //else
        //{
        //  throw new NotImplementedException($"Schema type {item.GetType()} not supported");
        //}
      }
    }
  }

  internal bool ParseXmlSchemaSimpleType(Namespace ns, XmlSchemaSimpleType XmlSchemaSimpleType, string? defaultTypeName = null)
  {
    var added = false;
    var updated = false;
    var nsId = ns.Id;
    string typeName = XmlSchemaSimpleType.Name ?? defaultTypeName ?? throw new InvalidDataException("Empty type def name");
    Write($"Checking simple type {ns.Url}/{typeName} ... ");
    SimpleType simpleType;
    if (!ns.TypesDictionary.TryGetValue(typeName, out var typeDef))
    {
      simpleType = new SimpleType
      {
        NamespaceId = nsId,
        Name = typeName
      };
      dbContext.Types.Add(simpleType);
      if (SaveChanges() > 0)
        SimpleTypesAdded++;
      WriteLine("added");
      added = true;
    }
    else
    {
      simpleType = (SimpleType)typeDef;
    }
    var baseSchemaType = XmlSchemaSimpleType.BaseXmlSchemaType;
    if (baseSchemaType != null)
    {
      if (baseSchemaType.Name != null)
      {
        simpleType.BaseTypeName = baseSchemaType.Name;
        updated = true;
      }
      if (baseSchemaType.QualifiedName.Namespace != ns.Url)
      {
        if (!dbContext.NamespaceDictionary.TryGetValue(baseSchemaType.QualifiedName.Namespace, out var baseTypeNamespace))
          throw new NotImplementedException($"Namespace {baseSchemaType.QualifiedName.Namespace} in type {simpleType.Name} not found");
        simpleType.BaseNamespaceId = baseTypeNamespace.Id;
        updated = true;
      }
      if (updated)
        SaveChanges();
      if (ParseXmlSchemaSimpleTypeDetails(simpleType, XmlSchemaSimpleType))
        updated = true;
      if (!added)
        if (updated)
        {
          WriteLine("updated");
          SimpleTypesUpdates++;
        }
        else
          WriteLine("ok");
    }
    return added || updated;
  }

  internal bool ParseXmlSchemaSimpleTypeDetails(SimpleType SimpleType, XmlSchemaSimpleType XmlSchemaSimpleType)
  {
    if (XmlSchemaSimpleType.Content is XmlSchemaSimpleTypeRestriction restriction)
    {
      if (restriction.Facets.Count > 0)
      {
        var facet = restriction.Facets[0];
        if (facet is XmlSchemaEnumerationFacet enumerationFacet)
        {
          return ParseXmlSchemaSimpleTypeEnumRestriction(SimpleType, restriction);
        }
        //else if (facet is XmlSchemaPatternFacet patternFacet)
        //{
        //  ParseXmlSchemaSimpleTypePatternRestriction(SimpleType, restriction);
        //}
        //else
        //{
        //  ParseXmlSchemaSimpleTypeOtherRestriction(SimpleType, restriction);
        //}
      }
      else
      {
        SimpleType.BaseTypeName = restriction.BaseTypeName.Name;
        if (SaveChanges() > 0)
        {
          WriteLine($"  Updating simple type {SimpleType.Name} settings");
          SimpleTypesUpdates++;
        }
      }
    }
    //else
    //if (XmlSchemaSimpleType.Content is XmlSchemaSimpleTypeUnion union)
    //{
    //  ParseXmlSchemaSimpleTypeUnion(SimpleType, union);
    //}
    //else
    //if (XmlSchemaSimpleType.Content is XmlSchemaSimpleTypeList list)
    //{
    //  ParseXmlSchemaSimpleTypeList(SimpleType, list);
    //}
    //else
    //  throw new NotImplementedException($"Simple type content {XmlSchemaSimpleType.Content} not supported");
    return false;
  }

  internal bool ParseXmlSchemaSimpleTypeEnumRestriction(SimpleType SimpleType, XmlSchemaSimpleTypeRestriction restriction)
  {
    bool added = false;
    bool updated = false;
    int n = 0;
    SimpleType.BaseTypeName = "enum";
    foreach (var facet in restriction.Facets)
    {
      var enumerationFacet = (XmlSchemaEnumerationFacet)facet;
      var stringValue = enumerationFacet.Value;
      if (stringValue == null)
        throw new NotImplementedException("Enumeration facet is null");

      if (!SimpleType.EnumValuesDictionary.TryGetValue(stringValue, out var enumValue))
      {
        enumValue = new EnumValue { OwnerTypeId = SimpleType.Id, Name = stringValue };
        dbContext.EnumValues.Add(enumValue);
        enumValue.Value = n++;
        if (SaveChanges() > 0)
          SchemaEnumValuesAdded++;
        added = true;
      }
    }
    if (SimpleType.BaseTypeName != restriction.BaseTypeName.Name)
    {
      SimpleType.BaseTypeName = restriction.BaseTypeName.Name;
      if (SaveChanges() > 0)
      {
        SimpleTypesUpdates++;
        updated = true;
      }
    }
    return added || updated;
  }

  //internal void ParseXmlSchemaSimpleTypePatternRestriction(SimpleType SimpleType, XmlSchemaSimpleTypeRestriction restriction)
  //{
  //  SimpleType.BaseTypeName = "string";
  //  foreach (var facet in restriction.Facets)
  //  {
  //    var patternFacet = (XmlSchemaPatternFacet)facet;
  //    var schemaPattern = dbContext.Patterns.FirstOrDefault(item =>
  //      item.OwnerTypeId == SimpleType.Id && item.Pattern == patternFacet.Value);
  //    if (schemaPattern == null)
  //    {
  //      WriteLine($"  Adding pattern value {patternFacet.Value}");
  //      schemaPattern = new SchemaPattern { OwnerTypeId = SimpleType.Id, Pattern = patternFacet.Value };
  //      dbContext.Patterns.Add(schemaPattern);
  //      if (SaveChanges() > 0)
  //        SchemaPatternsAdded++;
  //    }
  //  }
  //}

  //internal void ParseXmlSchemaSimpleTypeOtherRestriction(SimpleType SimpleType, XmlSchemaSimpleTypeRestriction restriction)
  //{
  //  SimpleType.BaseTypeName = restriction.BaseTypeName.Name;
  //  foreach (var facet in restriction.Facets)
  //  {
  //    if (facet is XmlSchemaMinExclusiveFacet minExclusiveFacet)
  //      SimpleType.MinExclusive = minExclusiveFacet.Value;
  //    else
  //    if (facet is XmlSchemaMinInclusiveFacet minInclusiveFacet)
  //      SimpleType.MinInclusive = minInclusiveFacet.Value;
  //    else
  //    if (facet is XmlSchemaMaxInclusiveFacet maxInclusiveFacet)
  //      SimpleType.MaxInclusive = maxInclusiveFacet.Value;
  //    else
  //    if (facet is XmlSchemaMaxExclusiveFacet maxExclusiveFacet)
  //      SimpleType.MaxExclusive = maxExclusiveFacet.Value;
  //    else
  //    if (facet is XmlSchemaMinLengthFacet minLengthFacet)
  //      SimpleType.MinLength = GetIntegerValue(minLengthFacet.Value);
  //    else
  //    if (facet is XmlSchemaLengthFacet lengthFacet)
  //      SimpleType.Length = GetIntegerValue(lengthFacet.Value);
  //    else
  //    if (facet is XmlSchemaMaxLengthFacet maxLengthFacet)
  //      SimpleType.MaxLength = GetIntegerValue(maxLengthFacet.Value);
  //    else
  //      throw new NotImplementedException($"Restriction type {facet.GetType()} not supported");
  //  }
  //}

  //internal int GetIntegerValue(string? value)
  //{
  //  if (int.TryParse(value, CultureInfo.InvariantCulture, out var val))
  //    return val;
  //  throw new NotImplementedException($"Value {value} should be int number");
  //}

  //internal decimal GetDecimalValue(string? value)
  //{
  //  if (decimal.TryParse(value, CultureInfo.InvariantCulture, out var val))
  //    return val;
  //  throw new NotImplementedException($"Value {value} should be decimal number");
  //}

  //internal void ParseXmlSchemaSimpleTypeUnion(SimpleType SimpleType, XmlSchemaSimpleTypeUnion union)
  //{
  //  if (union.MemberTypes != null)
  //  {
  //    if (union.MemberTypes.Length == 1)
  //    {
  //      var memberType = union.MemberTypes[0];
  //      SimpleType.BaseTypeName = memberType.Name;
  //      var memberNamespace = dbContext.Namespaces.FirstOrDefault(item => item.Url == memberType.Namespace);
  //      if (memberNamespace == null)
  //        throw new NotImplementedException($"Namespace {memberType.Namespace} in type {SimpleType.Name} not found");
  //      SimpleType.BaseNamespaceId = memberNamespace.Id;
  //      if (SaveChanges() > 0)
  //      {
  //        WriteLine($"  Updating simple type {SimpleType.Name} settings");
  //        SimpleTypesUpdates++;
  //      }
  //    }
  //    else
  //    {
  //      SimpleType.BaseTypeName = "union";
  //      foreach (var memberType in union.MemberTypes)
  //      {
  //        var type = memberType;
  //        var schemaUnionMember = dbContext.UnionMembers.FirstOrDefault(item =>
  //          item.OwnerTypeId == SimpleType.Id && item.MemberTypeName == type.Name);
  //        if (schemaUnionMember == null)
  //        {
  //          WriteLine($"  Adding member value {memberType.Name}");
  //          schemaUnionMember = new SchemaUnionMember { OwnerTypeId = SimpleType.Id, MemberTypeName = memberType.Name };
  //          dbContext.UnionMembers.Add(schemaUnionMember);
  //          if (SaveChanges() > 0)
  //            SchemaUnionMembersAdded++;
  //        }
  //        var memberNamespace = dbContext.Namespaces.FirstOrDefault(item => item.Url == memberType.Namespace);
  //        if (memberNamespace == null)
  //          throw new NotImplementedException($"Namespace {memberType.Namespace} in type {SimpleType.Name} not found");
  //        schemaUnionMember.MemberNamespaceId = memberNamespace.Id;
  //        if (SaveChanges() > 0)
  //        {
  //          WriteLine($"  Updating union member {schemaUnionMember.MemberTypeName} settings");
  //          SchemaUnionMembersUpdates++;
  //        }
  //      }
  //    }
  //  }
  //  else
  //  if (union.BaseMemberTypes != null)
  //  {
  //    SimpleType.BaseTypeName = "union";
  //    foreach (var memberType in union.BaseMemberTypes)
  //    {
  //      var memberSimpleType = ParseXmlSchemaSimpleType(SimpleType.Namespace!, memberType, $"_anon_{(++AnonSimpleTypes)}");
  //      var schemaUnionMember = dbContext.UnionMembers.FirstOrDefault(item =>
  //        item.OwnerTypeId == SimpleType.Id && item.MemberTypeName == memberSimpleType.Name);
  //      if (schemaUnionMember == null)
  //      {
  //        WriteLine($"  Adding member value {memberSimpleType.Name}");
  //        schemaUnionMember = new SchemaUnionMember { OwnerTypeId = SimpleType.Id, MemberTypeName = memberSimpleType.Name };
  //        dbContext.UnionMembers.Add(schemaUnionMember);
  //        if (SaveChanges() > 0)
  //          SchemaUnionMembersAdded++;
  //      }
  //      var url = memberSimpleType.Namespace!.Url;
  //      var memberNamespace = dbContext.Namespaces.FirstOrDefault(item => item.Url == url);
  //      if (memberNamespace == null)
  //        throw new NotImplementedException($"Namespace {url} in type {SimpleType.Name} not found");
  //      schemaUnionMember.MemberNamespaceId = memberNamespace.Id;
  //      if (SaveChanges() > 0)
  //      {
  //        WriteLine($"  Updating union member {schemaUnionMember.MemberTypeName} settings");
  //        SchemaUnionMembersUpdates++;
  //      }
  //    }
  //  }
  //}

  //internal void ParseXmlSchemaSimpleTypeList(SimpleType SimpleType, XmlSchemaSimpleTypeList list)
  //{
  //  SimpleType.BaseTypeName = "list";
  //  var itemType = list.ItemTypeName;
  //  var schemaListItem = dbContext.ListItems.FirstOrDefault(item =>
  //    item.OwnerTypeId == SimpleType.Id && item.ItemTypeName == itemType.Name);
  //  if (schemaListItem == null)
  //  {
  //    WriteLine($"  Adding listItem {itemType.Name}");
  //    schemaListItem = new SchemaListItem { OwnerTypeId = SimpleType.Id, ItemTypeName = itemType.Name };
  //    dbContext.ListItems.Add(schemaListItem);
  //    if (SaveChanges() > 0)
  //      SchemaListItemsAdded++;
  //  }

  //  var itemNamespace = dbContext.Namespaces.FirstOrDefault(item => item.Url == itemType.Namespace);
  //  if (itemNamespace == null)
  //    throw new NotImplementedException(
  //      $"Namespace {itemType.Namespace} in type {SimpleType.Name} not found");
  //  schemaListItem.ItemNamespaceId = itemNamespace.Id;
  //  if (SaveChanges() > 0)
  //  {
  //    WriteLine($"  Updating type list item {itemType.Name} settings");
  //    SchemaListItemsUpdates++;
  //  }
  //}

  //internal SchemaComplexType ParseXmlSchemaComplexType(Namespace parentNamespace, XmlSchemaComplexType xmlSchemaComplexType, string? defaultTypeName = null)
  //{
  //  var nsId = parentNamespace.Id;
  //  var typeName = xmlSchemaComplexType.Name ?? defaultTypeName;
  //  var schemaComplexType = dbContext.ComplexTypes.FirstOrDefault(item =>
  //    item.NamespaceId == nsId && item.Name == typeName);
  //  if (schemaComplexType == null)
  //  {
  //    WriteLine($"Adding complex type {typeName}");
  //    schemaComplexType = new SchemaComplexType { NamespaceId = nsId, Name = typeName };
  //    dbContext.ComplexTypes.Add(schemaComplexType);
  //    if (SaveChanges() > 0)
  //      SchemaComplexTypesAdded++;
  //  }
  //  if (xmlSchemaComplexType.BaseXmlSchemaType is { Name: not null })
  //  {
  //    schemaComplexType.BaseTypeName = xmlSchemaComplexType.BaseXmlSchemaType.Name;
  //    var ns = dbContext.Namespaces.FirstOrDefault(item => item.Url == xmlSchemaComplexType.BaseXmlSchemaType.QualifiedName.Namespace);
  //    if (ns != null && ns.Id != nsId)
  //      schemaComplexType.BaseNamespaceId = ns.Id;
  //  }
  //  ParseXmlSchemaComplexTypeDetails(schemaComplexType, xmlSchemaComplexType);
  //  return schemaComplexType;
  //}

  //internal void ParseXmlSchemaComplexTypeDetails(SchemaComplexType schemaComplexType, XmlSchemaComplexType xmlSchemaComplexType)
  //{
  //  foreach (var attribute in xmlSchemaComplexType.Attributes)
  //  {
  //    if (attribute is XmlSchemaAttribute xmlSchemaAttribute)
  //    {
  //      ParseXmlSchemaComplexTypeAttribute(schemaComplexType, xmlSchemaAttribute);
  //    }
  //    else
  //    if (attribute is XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef)
  //    {
  //      ParseXmlSchemaAttributeGroupRef(schemaComplexType, xmlSchemaAttributeGroupRef);
  //    }
  //    else
  //    {
  //      throw new NotImplementedException($"Attribute type {attribute.GetType()} not supported");
  //    }
  //  }

  //  schemaComplexType.ContentType = xmlSchemaComplexType.ContentType switch
  //  {
  //    XmlSchemaContentType.Empty => ContentType.Empty,
  //    XmlSchemaContentType.TextOnly => ContentType.TextOnly,
  //    XmlSchemaContentType.ElementOnly => ContentType.ElementOnly,
  //    XmlSchemaContentType.Mixed => ContentType.Mixed,
  //    _ => throw new NotImplementedException($"Content type {xmlSchemaComplexType.ContentType} not supported")
  //  };
  //  if (xmlSchemaComplexType.Particle != null)
  //    ParseXmlSchemaParticle(schemaComplexType, null, xmlSchemaComplexType.Particle, null);
  //}

  //internal void ParseXmlSchemaComplexTypeAttribute(SchemaComplexType schemaComplexType, XmlSchemaAttribute xmlSchemaAttribute)
  //{
  //  SchemaAttribute? schemaAttribute;
  //  if (xmlSchemaAttribute.Name != null)
  //  {
  //    schemaAttribute = dbContext.Attributes.FirstOrDefault(item =>
  //      item.ComplexTypeId == schemaComplexType.Id && item.AttributeName == xmlSchemaAttribute.Name);
  //    if (schemaAttribute == null)
  //    {
  //      WriteLine($"Adding attribute {xmlSchemaAttribute.Name}");
  //      schemaAttribute = new SchemaAttribute
  //      {
  //        ComplexTypeId = schemaComplexType.Id,
  //        AttributeName = xmlSchemaAttribute.Name,
  //      };
  //      dbContext.Attributes.Add(schemaAttribute);
  //      if (SaveChanges() > 0)
  //        SchemaAttributesAdded++;
  //    }
  //  }
  //  else
  //  {
  //    var ns = dbContext.Namespaces.FirstOrDefault(item => item.Url == xmlSchemaAttribute.RefName.Namespace);
  //    if (ns == null)
  //      throw new DataException($"Namespace {xmlSchemaAttribute.RefName.Namespace} not found");
  //    schemaAttribute = dbContext.Attributes.FirstOrDefault(item =>
  //      item.ComplexTypeId == schemaComplexType.Id && item.AttributeName == xmlSchemaAttribute.RefName.Name && item.RefNamespaceId == ns.Id);
  //    if (schemaAttribute == null)
  //    {
  //      WriteLine($"Adding attribute reference to {ns.Url} {xmlSchemaAttribute.RefName.Name}");
  //      schemaAttribute = new SchemaAttribute
  //      {
  //        ComplexTypeId = schemaComplexType.Id,
  //        AttributeName = xmlSchemaAttribute.RefName.Name,
  //        RefNamespaceId = ns.Id
  //      };
  //      dbContext.Attributes.Add(schemaAttribute);
  //      if (SaveChanges() > 0)
  //        SchemaAttributesAdded++;
  //    }
  //  }
  //  ParseXmlSchemaAttributeDetails(schemaAttribute, xmlSchemaAttribute);
  //}

  //internal void ParseXmlSchemaGlobalAttribute(Namespace parentNamespace, XmlSchemaAttribute xmlSchemaAttribute)
  //{
  //  int nsId = parentNamespace.Id;
  //  SchemaAttribute? schemaAttribute;
  //  if (xmlSchemaAttribute.Name != null)
  //  {
  //    schemaAttribute = dbContext.Attributes.FirstOrDefault(item =>
  //      item.NamespaceId == nsId && item.AttributeName == xmlSchemaAttribute.Name);
  //    if (schemaAttribute == null)
  //    {
  //      WriteLine($"Adding global attribute {xmlSchemaAttribute.Name}");
  //      schemaAttribute = new SchemaAttribute
  //      {
  //        NamespaceId = nsId,
  //        AttributeName = xmlSchemaAttribute.Name,
  //      };
  //      dbContext.Attributes.Add(schemaAttribute);
  //      if (SaveChanges() > 0)
  //        SchemaAttributesAdded++;
  //    }
  //  }
  //  else
  //  {
  //    var ns = dbContext.Namespaces.FirstOrDefault(item => item.Url == xmlSchemaAttribute.RefName.Namespace);
  //    if (ns == null)
  //      throw new DataException($"Namespace {xmlSchemaAttribute.RefName.Namespace} not found");
  //    schemaAttribute = dbContext.Attributes.FirstOrDefault(item =>
  //      item.NamespaceId == nsId && item.AttributeName == xmlSchemaAttribute.RefName.Name && item.RefNamespaceId == ns.Id);
  //    if (schemaAttribute == null)
  //    {
  //      WriteLine($"Adding global attribute reference to {ns.Url} {xmlSchemaAttribute.RefName.Name}");
  //      schemaAttribute = new SchemaAttribute
  //      {
  //        NamespaceId = nsId,
  //        AttributeName = xmlSchemaAttribute.RefName.Name,
  //        RefNamespaceId = ns.Id
  //      };
  //      dbContext.Attributes.Add(schemaAttribute);
  //      if (SaveChanges() > 0)
  //        SchemaAttributesAdded++;
  //    }
  //  }
  //  ParseXmlSchemaAttributeDetails(schemaAttribute, xmlSchemaAttribute);
  //}

  //internal void ParseXmlSchemaAttributeDetails(SchemaAttribute schemaAttribute, XmlSchemaAttribute xmlSchemaAttribute)
  //{
  //  if (!string.IsNullOrEmpty(xmlSchemaAttribute.SchemaTypeName.Namespace))
  //  {
  //    var ns = dbContext.Namespaces.FirstOrDefault(item => item.Url == xmlSchemaAttribute.SchemaTypeName.Namespace);
  //    if (ns == null)
  //      throw new DataException($"Namespace {xmlSchemaAttribute.SchemaTypeName.Namespace} not found");
  //    schemaAttribute.TypeNamespaceId = ns.Id;
  //  }
  //  else
  //    schemaAttribute.TypeNamespaceId = null;
  //  schemaAttribute.Name = xmlSchemaAttribute.SchemaTypeName.Name;
  //  schemaAttribute.Use = xmlSchemaAttribute.Use switch
  //  {
  //    XmlSchemaUse.None => null, //AttributeUse.None,
  //    XmlSchemaUse.Optional => AttributeUse.Optional,
  //    XmlSchemaUse.Prohibited => AttributeUse.Prohibited,
  //    XmlSchemaUse.Required => AttributeUse.Required,
  //    _ => null
  //  };
  //  schemaAttribute.DefaultValue = xmlSchemaAttribute.DefaultValue ?? xmlSchemaAttribute.FixedValue;
  //  schemaAttribute.IsFixed = xmlSchemaAttribute.FixedValue != null;
  //  if (SaveChanges() > 0)
  //  {
  //    WriteLine($"  Updating attribute {schemaAttribute.AttributeName} settings");
  //    SchemaAttributesUpdates++;
  //  }
  //}


  //internal void ParseXmlSchemaAttributeGroup(Namespace parentNamespace, XmlSchemaAttributeGroup xmlSchemaAttributeGroup)
  //{
  //  int nsId = parentNamespace.Id;
  //  if (xmlSchemaAttributeGroup.Name != null)
  //  {
  //    var schemaAttributeGroup = dbContext.AttributeGroups.FirstOrDefault(item =>
  //      item.NamespaceId == nsId && item.GroupName == xmlSchemaAttributeGroup.Name);
  //    if (schemaAttributeGroup == null)
  //    {
  //      WriteLine($"Adding attribute group {xmlSchemaAttributeGroup.Name}");
  //      schemaAttributeGroup = new SchemaAttributeGroup
  //      {
  //        NamespaceId = nsId,
  //        GroupName = xmlSchemaAttributeGroup.Name,
  //      };
  //      dbContext.AttributeGroups.Add(schemaAttributeGroup);
  //      if (SaveChanges() > 0)
  //        SchemaAttributeGroupsAdded++;
  //    }
  //    foreach (var attribute in xmlSchemaAttributeGroup.Attributes)
  //    {
  //      if (attribute is XmlSchemaAttribute xmlSchemaAttribute)
  //      {
  //        ParseXmlSchemaGroupAttribute(schemaAttributeGroup, xmlSchemaAttribute);
  //      }
  //      else
  //      if (attribute is XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef)
  //      {
  //        ParseXmlSchemaAttributeGroupRef(schemaAttributeGroup, xmlSchemaAttributeGroupRef);
  //      }
  //      else
  //      {
  //        throw new NotImplementedException($"Attribute type {attribute.GetType()} not supported");
  //      }
  //    }
  //  }
  //  else
  //  {
  //    throw new NotImplementedException("Anonymous attribute group not supported");
  //  }
  //  if (xmlSchemaAttributeGroup.AnyAttribute != null)
  //  {
  //    throw new NotImplementedException("Any attribute not supported");
  //  }
  //  if (xmlSchemaAttributeGroup.RedefinedAttributeGroup != null)
  //  {
  //    throw new NotImplementedException("Redefined attribute group not supported");
  //  }
  //}

  //internal void ParseXmlSchemaGroupAttribute(SchemaAttributeGroup schemaAttributeGroup, XmlSchemaAttribute xmlSchemaAttribute)
  //{
  //  SchemaAttribute? schemaAttribute;
  //  if (xmlSchemaAttribute.Name != null)
  //  {
  //    schemaAttribute = dbContext.Attributes.FirstOrDefault(item =>
  //      item.AttributeGroupId == schemaAttributeGroup.Id && item.AttributeName == xmlSchemaAttribute.Name);
  //    if (schemaAttribute == null)
  //    {
  //      WriteLine($"Adding group attribute {xmlSchemaAttribute.Name}");
  //      schemaAttribute = new SchemaAttribute
  //      {
  //        AttributeGroupId = schemaAttributeGroup.Id,
  //        AttributeName = xmlSchemaAttribute.Name,
  //      };
  //      dbContext.Attributes.Add(schemaAttribute);
  //      if (SaveChanges() > 0)
  //        SchemaAttributeGroupsAdded++;
  //    }
  //  }
  //  else
  //  {
  //    var ns = dbContext.Namespaces.FirstOrDefault(item => item.Url == xmlSchemaAttribute.RefName.Namespace);
  //    if (ns == null)
  //      throw new DataException($"Namespace {xmlSchemaAttribute.RefName.Namespace} not found");
  //    schemaAttribute = dbContext.Attributes.FirstOrDefault(item =>
  //      item.AttributeGroupId == schemaAttributeGroup.Id && item.AttributeName == xmlSchemaAttribute.RefName.Name && item.RefNamespaceId == ns.Id);
  //    if (schemaAttribute == null)
  //    {
  //      WriteLine($"Adding group attribute reference to {ns.Url} {xmlSchemaAttribute.RefName.Name}");
  //      schemaAttribute = new SchemaAttribute
  //      {
  //        AttributeGroupId = schemaAttributeGroup.Id,
  //        AttributeName = xmlSchemaAttribute.RefName.Name,
  //        RefNamespaceId = ns.Id
  //      };
  //      dbContext.Attributes.Add(schemaAttribute);
  //      if (SaveChanges() > 0)
  //        SchemaAttributeGroupsAdded++;
  //    }
  //  }
  //  ParseXmlSchemaAttributeDetails(schemaAttribute, xmlSchemaAttribute);
  //}

  //internal void ParseXmlSchemaAttributeGroupRef(SchemaComplexType parentComplexType, XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef)
  //{
  //  var ns = dbContext.Namespaces.First(item => item.Url == xmlSchemaAttributeGroupRef.RefName.Namespace);
  //  int? nsId = parentComplexType.NamespaceId;
  //  if (ns.Id == nsId)
  //    nsId = null;
  //  var schemaAttributeGroupRef = dbContext.AttributeGroupRefs.FirstOrDefault(item =>
  //    item.ComplexTypeId == parentComplexType.Id && item.RefName == xmlSchemaAttributeGroupRef.RefName.Name && item.RefNamespaceId == nsId);
  //  if (schemaAttributeGroupRef == null)
  //  {
  //    WriteLine($"Adding attribute group ref {xmlSchemaAttributeGroupRef.RefName.Name}");
  //    schemaAttributeGroupRef = new SchemaAttributeGroupRef
  //    {
  //      ComplexTypeId = parentComplexType.Id,
  //      RefName = xmlSchemaAttributeGroupRef.RefName.Name,
  //      RefNamespaceId = nsId
  //    };
  //    dbContext.AttributeGroupRefs.Add(schemaAttributeGroupRef);
  //    if (SaveChanges() > 0)
  //      SchemaAttributeGroupRefsAdded++;
  //  }
  //}

  //internal void ParseXmlSchemaAttributeGroupRef(SchemaAttributeGroup parentAttributeGroup, XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef)
  //{
  //  var ns = dbContext.Namespaces.First(item => item.Url == xmlSchemaAttributeGroupRef.RefName.Namespace);
  //  int? nsId = parentAttributeGroup.NamespaceId;
  //  if (ns.Id == nsId)
  //    nsId = null;
  //  var schemaAttributeGroupRef = dbContext.AttributeGroupRefs.FirstOrDefault(item =>
  //    item.AttributeGroupId == parentAttributeGroup.Id && item.RefName == xmlSchemaAttributeGroupRef.RefName.Name && item.RefNamespaceId == nsId);
  //  if (schemaAttributeGroupRef == null)
  //  {
  //    WriteLine($"Adding attribute group ref {xmlSchemaAttributeGroupRef.RefName.Name}");
  //    schemaAttributeGroupRef = new SchemaAttributeGroupRef
  //    {
  //      AttributeGroupId = parentAttributeGroup.Id,
  //      RefName = xmlSchemaAttributeGroupRef.RefName.Name,
  //      RefNamespaceId = nsId
  //    };
  //    dbContext.AttributeGroupRefs.Add(schemaAttributeGroupRef);
  //    if (SaveChanges() > 0)
  //      SchemaAttributeGroupRefsAdded++;
  //  }
  //}

  //internal void ParseXmlSchemaParticle(SchemaComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaParticle xmlSchemaParticle, int? ordNum)
  //{
  //  if (xmlSchemaParticle is XmlSchemaElement xmlSchemaElement)
  //  {
  //    ParseXmlSchemaElement(parentComplexType, parentParticle, xmlSchemaElement, ordNum);
  //  }
  //  else
  //  if (xmlSchemaParticle is XmlSchemaSequence xmlSchemaSequence)
  //  {
  //    ParseXmlSchemaSequence(parentComplexType, parentParticle, xmlSchemaSequence, ordNum);
  //  }
  //  else
  //  if (xmlSchemaParticle is XmlSchemaAny xmlSchemaAny)
  //  {
  //    ParseXmlSchemaAny(parentComplexType, parentParticle, xmlSchemaAny, ordNum);
  //  }
  //  else
  //  if (xmlSchemaParticle is XmlSchemaAll xmlSchemaAll)
  //  {
  //    ParseXmlSchemaAll(parentComplexType, parentParticle, xmlSchemaAll, ordNum);
  //  }
  //  else
  //  if (xmlSchemaParticle is XmlSchemaChoice xmlSchemaChoice)
  //  {
  //    ParseXmlSchemaChoice(parentComplexType, parentParticle, xmlSchemaChoice, ordNum);
  //  }
  //  else

  //  if (xmlSchemaParticle is XmlSchemaGroupRef xmlSchemaGroupRef)
  //  {
  //    ParseXmlSchemaGroupRef(parentComplexType, parentParticle, xmlSchemaGroupRef, ordNum);
  //  }
  //  else
  //  {
  //    throw new NotImplementedException($"Sequence item type {xmlSchemaParticle.GetType()} not supported");
  //  }
  //}

  //internal void ParseXmlSchemaParticle(SchemaGroup parentGroup, SchemaParticle? parentParticle, XmlSchemaParticle xmlSchemaParticle, int? ordNum)
  //{
  //  if (xmlSchemaParticle is XmlSchemaElement xmlSchemaElement)
  //  {
  //    ParseXmlSchemaElement(parentGroup, parentParticle, xmlSchemaElement, ordNum);
  //  }
  //  else
  //  if (xmlSchemaParticle is XmlSchemaSequence xmlSchemaSequence)
  //  {
  //    ParseXmlSchemaSequence(parentGroup, parentParticle, xmlSchemaSequence, ordNum);
  //  }
  //  else
  //  if (xmlSchemaParticle is XmlSchemaAny xmlSchemaAny)
  //  {
  //    ParseXmlSchemaAny(parentGroup, parentParticle, xmlSchemaAny, ordNum);
  //  }
  //  else
  //  if (xmlSchemaParticle is XmlSchemaAll xmlSchemaAll)
  //  {
  //    ParseXmlSchemaAll(parentGroup, parentParticle, xmlSchemaAll, ordNum);
  //  }
  //  else
  //  if (xmlSchemaParticle is XmlSchemaChoice xmlSchemaChoice)
  //  {
  //    ParseXmlSchemaChoice(parentGroup, parentParticle, xmlSchemaChoice, ordNum);
  //  }
  //  else

  //  if (xmlSchemaParticle is XmlSchemaGroupRef xmlSchemaGroupRef)
  //  {
  //    ParseXmlSchemaGroupRef(parentGroup, parentParticle, xmlSchemaGroupRef, ordNum);
  //  }
  //  else
  //  {
  //    throw new NotImplementedException($"Sequence item type {xmlSchemaParticle.GetType()} not supported");
  //  }
  //}
  //internal void ParseXmlSchemaAny(SchemaComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaAny xmlSchemaAny, int? ordNum)
  //{
  //  var schemaAny = (SchemaAny?)dbContext.Particles.FirstOrDefault(item =>
  //    item.ComplexTypeId == parentComplexType.Id && item.OrdNum == ordNum && item.ParticleType == ParticleType.Any);
  //  if (schemaAny == null)
  //  {
  //    schemaAny = new SchemaAny
  //    {
  //      ComplexTypeId = parentComplexType.Id,
  //      ParentParticleId = parentParticle?.Id,
  //      OrdNum = ordNum
  //    };
  //    dbContext.Particles.Add(schemaAny);
  //    if (SaveChanges() > 0)
  //    {
  //      WriteLine($"Adding Any particle {schemaAny.Id}");
  //      SchemaParticlesAdded++;
  //    }
  //  }
  //  ParseXmlSchemaAnyDetails(schemaAny, xmlSchemaAny);
  //}

  //internal void ParseXmlSchemaAny(SchemaGroup parentGroup, SchemaParticle? parentParticle, XmlSchemaAny xmlSchemaAny, int? ordNum)
  //{
  //  var schemaAny = (SchemaAny?)dbContext.Particles.FirstOrDefault(item =>
  //    item.GroupId == parentGroup.Id && item.OrdNum == ordNum && item.ParticleType == ParticleType.Any);
  //  if (schemaAny == null)
  //  {
  //    schemaAny = new SchemaAny
  //    {
  //      GroupId = parentGroup.Id,
  //      ParentParticleId = parentParticle?.Id,
  //      OrdNum = ordNum
  //    };
  //    dbContext.Particles.Add(schemaAny);
  //    if (SaveChanges() > 0)
  //    {
  //      WriteLine($"Adding Any particle {schemaAny.Id}");
  //      SchemaParticlesAdded++;
  //    }
  //  }
  //  ParseXmlSchemaAnyDetails(schemaAny, xmlSchemaAny);
  //}

  //internal void ParseXmlSchemaAnyDetails(SchemaAny schemaAny, XmlSchemaAny xmlSchemaAny)
  //{
  //  schemaAny.Namespace = xmlSchemaAny.Namespace;
  //  schemaAny.ProcessContents = xmlSchemaAny.ProcessContents switch
  //  {
  //    XmlSchemaContentProcessing.Lax => ContentProcessing.Lax,
  //    XmlSchemaContentProcessing.Skip => ContentProcessing.Skip,
  //    XmlSchemaContentProcessing.Strict => ContentProcessing.Strict,
  //    _ => null
  //  };
  //  schemaAny.MinOccurs = GetOccurs(xmlSchemaAny.MinOccurs, xmlSchemaAny.MinOccursString);
  //  schemaAny.MaxOccurs = GetOccurs(xmlSchemaAny.MaxOccurs, xmlSchemaAny.MaxOccursString);
  //  if (SaveChanges() > 0)
  //  {
  //    WriteLine($"  Updating Any particle {schemaAny.Id} settings");
  //    SchemaParticlesUpdates++;
  //  }
  //}

  //internal void ParseXmlSchemaGroupRef(SchemaComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaGroupRef xmlSchemaGroupRef, int? ordNum)
  //{
  //  var parentParticleId = parentParticle?.Id; var schemaGroupRef = (SchemaGroupRef?)dbContext.Particles.FirstOrDefault(item =>
  //    item.ComplexTypeId == parentComplexType.Id && item.ParentParticleId == parentParticleId && item.OrdNum == ordNum && item.ParticleType == ParticleType.GroupRef);
  //  if (schemaGroupRef == null)
  //  {
  //    schemaGroupRef = new SchemaGroupRef
  //    {
  //      ComplexTypeId = parentComplexType.Id,
  //      ParentParticleId = parentParticle?.Id,
  //      OrdNum = ordNum
  //    };
  //    dbContext.Particles.Add(schemaGroupRef);
  //    if (SaveChanges() > 0)
  //    {
  //      WriteLine($"Adding GroupRef particle {schemaGroupRef.Id}");
  //      SchemaGroupRefsAdded++;
  //    }
  //  }
  //  ParseXmlSchemaGroupRefDetails(schemaGroupRef, xmlSchemaGroupRef);
  //}
  //internal void ParseXmlSchemaGroupRef(SchemaGroup parentGroup, SchemaParticle? parentParticle, XmlSchemaGroupRef xmlSchemaGroupRef, int? ordNum)
  //{
  //  var parentParticleId = parentParticle?.Id;
  //  var schemaGroupRef = (SchemaGroupRef?)dbContext.Particles.FirstOrDefault(item =>
  //    item.GroupId == parentGroup.Id && item.ParentParticleId == parentParticleId && item.OrdNum == ordNum && item.ParticleType == ParticleType.GroupRef);
  //  if (schemaGroupRef == null)
  //  {
  //    schemaGroupRef = new SchemaGroupRef
  //    {
  //      GroupId = parentGroup.Id,
  //      ParentParticleId = parentParticle?.Id,
  //      OrdNum = ordNum
  //    };
  //    dbContext.Particles.Add(schemaGroupRef);
  //    if (SaveChanges() > 0)
  //    {
  //      WriteLine($"Adding GroupRef particle {schemaGroupRef.Id}");
  //      SchemaGroupRefsAdded++;
  //    }
  //  }
  //  ParseXmlSchemaGroupRefDetails(schemaGroupRef, xmlSchemaGroupRef);
  //}

  //private void ParseXmlSchemaGroupRefDetails(SchemaGroupRef schemaGroupRef, XmlSchemaGroupRef xmlSchemaGroupRef)
  //{
  //  schemaGroupRef.RefName = xmlSchemaGroupRef.RefName.Name;
  //  var ns = dbContext.Namespaces.FirstOrDefault(item => item.Url == xmlSchemaGroupRef.RefName.Namespace);
  //  if (ns == null)
  //    throw new DataException($"Namespace {xmlSchemaGroupRef.RefName.Namespace} not found");
  //  int? nsId = ns.Id;
  //  if (nsId == schemaGroupRef.Namespace?.Id)
  //    nsId = null;

  //  schemaGroupRef.RefNamespaceId = nsId;
  //  schemaGroupRef.MinOccurs = GetOccurs(xmlSchemaGroupRef.MinOccurs, xmlSchemaGroupRef.MinOccursString);
  //  schemaGroupRef.MaxOccurs = GetOccurs(xmlSchemaGroupRef.MaxOccurs, xmlSchemaGroupRef.MaxOccursString);
  //  if (SaveChanges() > 0)
  //  {
  //    WriteLine($"  Updating GroupRef {schemaGroupRef.Id} settings");
  //    SchemaGroupRefsUpdates++;
  //  }
  //}

  //internal void ParseXmlSchemaSequence(SchemaComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaSequence xmlSchemaSequence, int? ordNum)
  //{
  //  var parentParticleId = parentParticle?.Id;
  //  var particle = (SchemaSequence?)dbContext.Particles.FirstOrDefault(item =>
  //    item.ComplexTypeId == parentComplexType.Id && item.ParentParticleId == parentParticleId && item.OrdNum == ordNum && item.ParticleType == ParticleType.Sequence);
  //  if (particle == null)
  //  {
  //    particle = new SchemaSequence
  //    {
  //      ComplexTypeId = parentComplexType.Id,
  //      ParentParticleId = parentParticle?.Id,
  //      OrdNum = ordNum
  //    };
  //    dbContext.Particles.Add(particle);
  //    if (SaveChanges() > 0)
  //    {
  //      WriteLine($"Adding Sequence particle {particle.Id}");
  //      SchemaParticlesAdded++;
  //    }
  //  }
  //  ParseXmlSchemaGroupBaseDetails(particle, parentComplexType, xmlSchemaSequence);
  //}

  //internal void ParseXmlSchemaSequence(SchemaGroup parentGroup, SchemaParticle? parentParticle, XmlSchemaSequence xmlSchemaSequence, int? ordNum)
  //{
  //  var parentParticleId = parentParticle?.Id;
  //  var particle = (SchemaSequence?)dbContext.Particles.FirstOrDefault(item =>
  //    item.GroupId == parentGroup.Id && item.ParentParticleId == parentParticleId && item.OrdNum == ordNum && item.ParticleType == ParticleType.Sequence);
  //  if (particle == null)
  //  {
  //    particle = new SchemaSequence
  //    {
  //      GroupId = parentGroup.Id,
  //      ParentParticleId = parentParticle?.Id,
  //      OrdNum = ordNum
  //    };
  //    dbContext.Particles.Add(particle);
  //    if (SaveChanges() > 0)
  //    {
  //      WriteLine($"Adding Sequence particle {particle.Id}");
  //      SchemaParticlesAdded++;
  //    }
  //  }
  //  ParseXmlSchemaGroupBaseDetails(particle, parentGroup, xmlSchemaSequence);
  //}

  //internal void ParseXmlSchemaChoice(SchemaComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaChoice xmlSchemaChoice, int? ordNum)
  //{
  //  var parentParticleId = parentParticle?.Id;
  //  var particle = (SchemaChoice?)dbContext.Particles.FirstOrDefault(item =>
  //    item.ComplexTypeId == parentComplexType.Id && item.ParentParticleId == parentParticleId && item.OrdNum == ordNum && item.ParticleType == ParticleType.Choice);
  //  if (particle == null)
  //  {
  //    particle = new SchemaChoice
  //    {
  //      ComplexTypeId = parentComplexType.Id,
  //      ParentParticleId = parentParticle?.Id,
  //      OrdNum = ordNum
  //    };
  //    dbContext.Particles.Add(particle);
  //    if (SaveChanges() > 0)
  //    {
  //      WriteLine($"Adding Choice particle {particle.Id}");
  //      SchemaParticlesAdded++;
  //    }
  //  }
  //  ParseXmlSchemaGroupBaseDetails(particle, parentComplexType, xmlSchemaChoice);
  //}

  //internal void ParseXmlSchemaChoice(SchemaGroup parentGroup, SchemaParticle? parentParticle, XmlSchemaChoice xmlSchemaChoice, int? ordNum)
  //{
  //  var parentParticleId = parentParticle?.Id;
  //  var particle = (SchemaChoice?)dbContext.Particles.FirstOrDefault(item =>
  //    item.GroupId == parentGroup.Id && item.ParentParticleId == parentParticleId && item.OrdNum == ordNum && item.ParticleType == ParticleType.Choice);
  //  if (particle == null)
  //  {
  //    particle = new SchemaChoice
  //    {
  //      GroupId = parentGroup.Id,
  //      ParentParticleId = parentParticle?.Id,
  //      OrdNum = ordNum
  //    };
  //    dbContext.Particles.Add(particle);
  //    if (SaveChanges() > 0)
  //    {
  //      WriteLine($"Adding Choice particle {particle.Id}");
  //      SchemaParticlesAdded++;
  //    }
  //  }
  //  ParseXmlSchemaGroupBaseDetails(particle, parentGroup, xmlSchemaChoice);
  //}

  //internal void ParseXmlSchemaAll(SchemaComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaAll xmlSchemaAll, int? ordNum)
  //{
  //  var parentParticleId = parentParticle?.Id;
  //  var particle = (SchemaAll?)dbContext.Particles.FirstOrDefault(item =>
  //    item.ComplexTypeId == parentComplexType.Id && item.ParentParticleId == parentParticleId && item.OrdNum == ordNum && item.ParticleType == ParticleType.All);
  //  if (particle == null)
  //  {
  //    particle = new SchemaAll
  //    {
  //      ComplexTypeId = parentComplexType.Id,
  //      ParentParticleId = parentParticle?.Id,
  //      OrdNum = ordNum
  //    };
  //    dbContext.Particles.Add(particle);
  //    if (SaveChanges() > 0)
  //    {
  //      WriteLine($"Adding All particle {particle.Id}");
  //      SchemaParticlesAdded++;
  //    }
  //  }
  //  ParseXmlSchemaGroupBaseDetails(particle, parentComplexType, xmlSchemaAll);
  //}

  //internal void ParseXmlSchemaAll(SchemaGroup parentGroup, SchemaParticle? parentParticle, XmlSchemaAll xmlSchemaAll, int? ordNum)
  //{
  //  var parentParticleId = parentParticle?.Id;
  //  var particle = (SchemaAll?)dbContext.Particles.FirstOrDefault(item =>
  //    item.GroupId == parentGroup.Id && item.ParentParticleId == parentParticleId && item.OrdNum == ordNum && item.ParticleType == ParticleType.All);
  //  if (particle == null)
  //  {
  //    particle = new SchemaAll
  //    {
  //      GroupId = parentGroup.Id,
  //      ParentParticleId = parentParticle?.Id,
  //      OrdNum = ordNum
  //    };
  //    dbContext.Particles.Add(particle);
  //    if (SaveChanges() > 0)
  //    {
  //      WriteLine($"Adding All particle {particle.Id}");
  //      SchemaParticlesAdded++;
  //    }
  //  }
  //  ParseXmlSchemaGroupBaseDetails(particle, parentGroup, xmlSchemaAll);
  //  }

  //  private void ParseXmlSchemaGroupBaseDetails(SchemaGroupBase particle, SchemaComplexType parentComplexType,
  //    XmlSchemaGroupBase xmlSchemaGroupBase)
  //  {
  //    particle.MinOccurs = GetOccurs(xmlSchemaGroupBase.MinOccurs, xmlSchemaGroupBase.MinOccursString);
  //    particle.MaxOccurs = GetOccurs(xmlSchemaGroupBase.MaxOccurs, xmlSchemaGroupBase.MaxOccursString);
  //    if (SaveChanges() > 0)
  //      WriteLine($"  Updating Sequence particle {particle.Id} settings");
  //    int ordNum1 = 0;
  //    foreach (var item in xmlSchemaGroupBase.Items)
  //    {
  //      ordNum1++;
  //      if (item is XmlSchemaParticle xmlSchemaParticle)
  //        ParseXmlSchemaParticle(parentComplexType, particle, xmlSchemaParticle, ordNum1);
  //      else
  //      {
  //        throw new NotImplementedException($"Sequence item type {item.GetType()} not supported");
  //      }
  //    }
  //  }

  //  private void ParseXmlSchemaGroupBaseDetails(SchemaGroupBase particle, SchemaGroup parentGroup,
  //    XmlSchemaGroupBase xmlSchemaGroupBase)
  //  {
  //    particle.MinOccurs = GetOccurs(xmlSchemaGroupBase.MinOccurs, xmlSchemaGroupBase.MinOccursString);
  //    particle.MaxOccurs = GetOccurs(xmlSchemaGroupBase.MaxOccurs, xmlSchemaGroupBase.MaxOccursString);
  //    if (SaveChanges() > 0)
  //      WriteLine($"  Updating Sequence particle {particle.Id} settings");
  //    int ordNum1 = 0;
  //    foreach (var item in xmlSchemaGroupBase.Items)
  //    {
  //      ordNum1++;
  //      if (item is XmlSchemaParticle xmlSchemaParticle)
  //        ParseXmlSchemaParticle(parentGroup, particle, xmlSchemaParticle, ordNum1);
  //      else
  //      {
  //        throw new NotImplementedException($"Sequence item type {item.GetType()} not supported");
  //      }
  //    }
  //  }

  //  internal void ParseXmlSchemaElement(SchemaComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaElement xmlSchemaElement, int? ordNum)
  //  {
  //    var parentParticleId = parentParticle?.Id;
  //    SchemaElement? schemaElement;
  //    if (xmlSchemaElement.Name != null)
  //    {
  //      schemaElement = dbContext.Elements.FirstOrDefault(item =>
  //        item.ComplexTypeId == parentComplexType.Id && item.ParentParticleId == parentParticleId
  //        && item.ParticleType == ParticleType.Element && item.OrdNum == ordNum && item.Name == xmlSchemaElement.Name);
  //      if (schemaElement == null)
  //      {
  //        WriteLine($"Adding element {xmlSchemaElement.Name}");
  //        schemaElement = new SchemaElement
  //        {
  //          ComplexTypeId = parentComplexType.Id,
  //          ParentParticleId = parentParticle?.Id,
  //          OrdNum = ordNum,
  //          Name = xmlSchemaElement.Name,
  //        };
  //        dbContext.Elements.Add(schemaElement);
  //        if (SaveChanges() >0)
  //          SchemaElementsAdded++;
  //      }
  //    }
  //    else
  //    {
  //      var ns = dbContext.Namespaces.FirstOrDefault(item => item.Url == xmlSchemaElement.RefName.Namespace);
  //      if (ns == null)
  //        throw new DataException($"Namespace {xmlSchemaElement.RefName.Namespace} not found");
  //      int? nsId = ns.Id;
  //      if (nsId == parentComplexType.ParentNamespace?.Id)
  //        nsId = null;
  //      schemaElement = dbContext.Elements.FirstOrDefault(item =>
  //        item.ComplexTypeId == parentComplexType.Id && item.ParentParticleId == parentParticleId
  //        && item.ParticleType == ParticleType.Element && item.OrdNum == ordNum && item.Name == xmlSchemaElement.RefName.Name && item.RefNamespaceId == nsId);
  //      if (schemaElement == null)
  //      {
  //        WriteLine($"Adding element reference to {ns.Url} {xmlSchemaElement.RefName.Name}");
  //        schemaElement = new SchemaElement
  //        {
  //          ComplexTypeId = parentComplexType.Id,
  //          ParentParticleId = parentParticle?.Id,
  //          OrdNum = ordNum,
  //          Name = xmlSchemaElement.RefName.Name,
  //          RefNamespaceId = nsId
  //        };
  //        dbContext.Elements.Add(schemaElement);
  //        if (SaveChanges() > 0)
  //          SchemaElementsAdded++;
  //    }
  //    }
  //    ParseXmlSchemaElementDetails(schemaElement, xmlSchemaElement);
  //  }

  //  internal void ParseXmlSchemaElement(SchemaGroup parentGroup, SchemaParticle? parentParticle, XmlSchemaElement xmlSchemaElement, int? ordNum)
  //  {
  //    var parentParticleId = parentParticle?.Id;
  //    SchemaElement? schemaElement;
  //    if (xmlSchemaElement.Name != null)
  //    {
  //      schemaElement = dbContext.Elements.FirstOrDefault(item =>
  //        item.GroupId == parentGroup.Id && item.ParentParticleId == parentParticleId
  //        && item.ParticleType == ParticleType.Element && item.OrdNum == ordNum && item.Name == xmlSchemaElement.Name);
  //      if (schemaElement == null)
  //      {
  //        WriteLine($"Adding element {xmlSchemaElement.Name}");
  //        schemaElement = new SchemaElement
  //        {
  //          GroupId = parentGroup.Id,
  //          ParentParticleId = parentParticle?.Id,
  //          OrdNum = ordNum,
  //          Name = xmlSchemaElement.Name,
  //        };
  //        dbContext.Elements.Add(schemaElement);
  //        if (SaveChanges() > 0)
  //          SchemaElementsAdded++;
  //    }
  //    }
  //    else
  //    {
  //      var ns = dbContext.Namespaces.FirstOrDefault(item => item.Url == xmlSchemaElement.RefName.Namespace);
  //      if (ns == null)
  //        throw new DataException($"Namespace {xmlSchemaElement.RefName.Namespace} not found");
  //      int? nsId = ns.Id;
  //      if (nsId == parentGroup.ParentNamespace?.Id)
  //        nsId = null;
  //      schemaElement = dbContext.Elements.FirstOrDefault(item =>
  //        item.GroupId == parentGroup.Id && item.ParentParticleId == parentParticleId
  //        && item.ParticleType == ParticleType.Element && item.OrdNum == ordNum && item.Name == xmlSchemaElement.RefName.Name && item.RefNamespaceId == nsId);
  //      if (schemaElement == null)
  //      {
  //        WriteLine($"Adding element reference to {ns.Url} {xmlSchemaElement.RefName.Name}");
  //        schemaElement = new SchemaElement
  //        {
  //          GroupId = parentGroup.Id,
  //          ParentParticleId = parentParticle?.Id,
  //          OrdNum = ordNum,
  //          Name = xmlSchemaElement.RefName.Name,
  //          RefNamespaceId = nsId
  //        };
  //        dbContext.Elements.Add(schemaElement);
  //        if (SaveChanges() > 0)
  //          SchemaElementsAdded++;
  //    }
  //    }
  //    ParseXmlSchemaElementDetails(schemaElement, xmlSchemaElement);
  //  }

  //  internal void ParseXmlSchemaGlobalElement(Namespace parentNamespace, XmlSchemaElement xmlSchemaElement)
  //  {
  //    var nsId = parentNamespace.Id;
  //    SchemaElement? schemaElement;
  //    if (xmlSchemaElement.Name != null)
  //    {
  //      schemaElement = dbContext.Elements.FirstOrDefault(item =>
  //        item.NamespaceId == nsId && item.ParticleType == ParticleType.Element && item.Name == xmlSchemaElement.Name);
  //      if (schemaElement == null)
  //      {
  //        WriteLine($"Adding global element {xmlSchemaElement.Name}");
  //        schemaElement = new SchemaElement
  //        {
  //          NamespaceId = nsId,
  //          Name = xmlSchemaElement.Name,
  //        };
  //        dbContext.Elements.Add(schemaElement);
  //        if (SaveChanges() > 0)
  //          SchemaElementsAdded++;
  //    }
  //    }
  //    else
  //    {
  //      var ns = dbContext.Namespaces.FirstOrDefault(item => item.Url == xmlSchemaElement.RefName.Namespace);
  //      if (ns == null)
  //        throw new DataException($"Namespace {xmlSchemaElement.RefName.Namespace} not found");
  //      schemaElement = dbContext.Elements.FirstOrDefault(item =>
  //        item.NamespaceId == nsId && item.Name == xmlSchemaElement.RefName.Name && item.RefNamespaceId == ns.Id);
  //      if (schemaElement == null)
  //      {
  //        WriteLine($"Adding element reference to {ns.Url} {xmlSchemaElement.RefName.Name}");
  //        schemaElement = new SchemaElement
  //        {
  //          NamespaceId = nsId,
  //          Name = xmlSchemaElement.RefName.Name,
  //          RefNamespaceId = ns.Id
  //        };
  //        dbContext.Elements.Add(schemaElement);
  //        SaveChanges(); if (SaveChanges() > 0)
  //          SchemaElementsAdded++;
  //      }
  //    }
  //    ParseXmlSchemaElementDetails(schemaElement, xmlSchemaElement);
  //  }

  //  internal void ParseXmlSchemaElementDetails(SchemaElement schemaElement, XmlSchemaElement xmlSchemaElement)
  //  {
  //    if (!string.IsNullOrEmpty(xmlSchemaElement.SchemaTypeName.Namespace))
  //    {
  //      var ns = dbContext.Namespaces.FirstOrDefault(item => item.Url == xmlSchemaElement.SchemaTypeName.Namespace);
  //      if (ns == null)
  //        throw new DataException($"Namespace {xmlSchemaElement.SchemaTypeName.Namespace} not found");
  //      int? nsId = ns.Id; ;
  //      if (nsId == schemaElement.Namespace?.Id)
  //        nsId = null;
  //      schemaElement.TypeNamespaceId = nsId;
  //    }
  //    schemaElement.Name = xmlSchemaElement.SchemaTypeName.Name;
  //    schemaElement.MinOccurs = GetOccurs(xmlSchemaElement.MinOccurs, xmlSchemaElement.MinOccursString);
  //    schemaElement.MaxOccurs = GetOccurs(xmlSchemaElement.MaxOccurs, xmlSchemaElement.MaxOccursString);
  //    if (SaveChanges() > 0)
  //    {
  //      WriteLine($"  Updating element {schemaElement.Name} settings");
  //      SchemaElementsUpdates++;
  //    }
  //  }

  //  private int? GetOccurs(decimal? value, string? valString)
  //  {
  //    if (valString == "unbounded")
  //      return Int32.MaxValue;
  //    if (value == null)
  //      return null;
  //    if (value == decimal.Zero)
  //      return 0;
  //    if (value == decimal.One)
  //      return 1;
  //    if (value == decimal.MinusOne)
  //      return -1;
  //    if (value == decimal.MaxValue)
  //      return int.MaxValue;
  //    if (value == decimal.MinValue)
  //      return int.MinValue;
  //    return (int)value;
  //  }

  //  internal void ParseXmlSchemaGroup(Namespace parentNamespace, XmlSchemaGroup xmlSchemaGroup)
  //  {
  //    var nsId = parentNamespace.Id;
  //    if (xmlSchemaGroup.Name != null)
  //    {
  //      var schemaGroup = dbContext.Groups.FirstOrDefault(item =>
  //        item.NamespaceId == nsId && item.GroupName == xmlSchemaGroup.Name);
  //      if (schemaGroup == null)
  //      {
  //        WriteLine($"Adding global group {xmlSchemaGroup.Name}");
  //        schemaGroup = new SchemaGroup
  //        {
  //          NamespaceId = nsId,
  //          GroupName = xmlSchemaGroup.Name,
  //        };
  //        dbContext.Groups.Add(schemaGroup);
  //        if (SaveChanges() > 0)
  //          SchemaGroupsAdded++;
  //      }
  //      if (xmlSchemaGroup.Particle != null)
  //      {
  //        ParseXmlSchemaGroupParticle(schemaGroup, null, xmlSchemaGroup.Particle, null);
  //      }
  //    }
  //    else
  //      throw new InvalidDataException("Global group without name is not supported");
  //  }

  //  internal void ParseXmlSchemaGroupParticle(SchemaGroup schemaGroup, SchemaParticle? parentParticle, XmlSchemaParticle xmlSchemaParticle, int? ordNum)
  //  {
  //    if (xmlSchemaParticle is XmlSchemaElement xmlSchemaElement)
  //    {
  //      ParseXmlSchemaElement(schemaGroup, parentParticle, xmlSchemaElement, ordNum);
  //    }
  //    else
  //    if (xmlSchemaParticle is XmlSchemaSequence xmlSchemaSequence)
  //    {
  //      ParseXmlSchemaSequence(schemaGroup, parentParticle, xmlSchemaSequence, ordNum);
  //    }
  //    else
  //    if (xmlSchemaParticle is XmlSchemaAny xmlSchemaAny)
  //    {
  //      ParseXmlSchemaAny(schemaGroup, parentParticle, xmlSchemaAny, ordNum);
  //    }
  //    else
  //    if (xmlSchemaParticle is XmlSchemaAll xmlSchemaAll)
  //    {
  //      ParseXmlSchemaAll(schemaGroup, parentParticle, xmlSchemaAll, ordNum);
  //    }
  //    else
  //    if (xmlSchemaParticle is XmlSchemaChoice xmlSchemaChoice)
  //    {
  //      ParseXmlSchemaChoice(schemaGroup, parentParticle, xmlSchemaChoice, ordNum);
  //    }
  //    else

  //    if (xmlSchemaParticle is XmlSchemaGroupRef xmlSchemaGroupRef)
  //    {
  //      ParseXmlSchemaGroupRef(schemaGroup, parentParticle, xmlSchemaGroupRef, ordNum);
  //    }
  //    else
  //    {
  //      throw new NotImplementedException($"Sequence item type {xmlSchemaParticle.GetType()} not supported");
  //    }
  //  }

}
