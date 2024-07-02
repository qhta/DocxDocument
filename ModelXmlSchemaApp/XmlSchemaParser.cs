using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Xml;
using System.Xml.Schema;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Office.Interop.Access.Dao;

using ModelXmlSchema;

using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

using Model = ModelXmlSchema;
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
  public int SimpleTypesTotal, SimpleTypesAdded, SimpleTypesUpdated;
  public int ComplexTypesTotal, ComplexTypesAdded, ComplexTypesUpdated;
  public int AttributesTotal, AttributesAdded, AttributesUpdated;
  public int AttributeGroupsTotal, AttributeGroupsAdded, AttributeGroupsUpdated;
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
    bool added = false;
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
            SchemaFilesAdded++;

        }
        if (schema.TargetNamespace != null)
        {
          var Namespace = CheckSchemaNamespace(schema.TargetNamespace);
          if (schemaFile.TargetNamespaceId != Namespace.Id)
          {
            schemaFile.TargetNamespaceId = Namespace.Id;
            SaveChanges();
            if (!added)
            {
              SchemaFilesUpdated++;
            }
          }
          var namespaces = schema.Namespaces.ToArray();
          for (int i = 0; i < namespaces.Count(); i++)
          {
            var nsName = namespaces[i].Namespace;
            var prefix = namespaces[i].Name;
            if (nsName != schema.TargetNamespace && nsName != "#all")
            {
              Namespace = CheckSchemaNamespace(nsName);
              var schemaUsedNamespace = dbContext.UsedNamespaces.FirstOrDefault(item =>
                item.FileId == schemaFile.Id && item.NamespaceId == Namespace.Id && item.Prefix == prefix);
              if (schemaUsedNamespace == null)
              {
                schemaUsedNamespace = new UsedNamespace
                { FileId = schemaFile.Id, NamespaceId = Namespace.Id, Prefix = prefix };
                dbContext.UsedNamespaces.Add(schemaUsedNamespace);
                if (SaveChanges() > 0)
                  UsedNamespacesAdded++;
              }
            }
          }
        }
      }
    }

    SchemaFilesTotal = dbContext.SchemaFiles.Count();
    NamespacesTotal = dbContext.Namespaces.Count();
    UsedNamespacesTotal = dbContext.UsedNamespaces.Count();
  }

  private Namespace CheckSchemaNamespace(string url)
  {
    if (!dbContext.NamespacesDictionary.TryGetValue(url, out var Namespace))
    {
      Namespace = new Namespace { Url = url };
      dbContext.Namespaces.Add(Namespace);
      if (SaveChanges() > 0)
      {
        NamespacesAdded++;
      }
    }
    return Namespace;
  }

  internal void SetNamespacePrefixes()
  {
    var prefixesInFile = new Dictionary<string, string>();
    using (var textReader = File.OpenText(Path.Combine(SourceXsdPath, "Prefixes.csv")))
    {
      int lineNo = 0;
      while (!textReader.EndOfStream)
      {
        var line = textReader.ReadLine();
        if (line == null) break;
        if (++lineNo == 1) continue;
        var parts = line.Split(new char[] { ',', ';', '\t' });
        if (parts.Length == 2)
        {
          prefixesInFile[parts[1]] = parts[0];
        }
      }
    }
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
        if (Namespace.Prefix != NamespacePrefix.Prefix)
        {
          Namespace.Prefix = NamespacePrefix.Prefix;
          if (SaveChanges() > 0)
          {
            NamespacesUpdates++;
          }
        }
      }
    }

    foreach (var Namespace in dbContext.Namespaces.Where(item => item.Prefix == null).ToList())
    {
      if (prefixesInFile.TryGetValue(Namespace.Url, out var prefix))
      {
        if (Namespace.Prefix != prefix)
        {
          Namespace.Prefix = prefix;
          if (SaveChanges() > 0)
          {
            NamespacesUpdates++;
          }
        }
      }
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
    ComplexTypesTotal = dbContext.Types.Count(item => item.IsComplex);
    AttributesTotal = dbContext.Attributes.Count();
    AttributeGroupsTotal = dbContext.AttributeGroups.Count();
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
        else
        if (item is XmlSchemaComplexType xmlSchemaComplexType)
        {
          ParseXmlSchemaComplexType(ns, xmlSchemaComplexType);
        }
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
        //else
        //{
        //  throw new NotImplementedException($"Schema type {item.GetType()} not supported");
        //}
      }
    }
  }

  internal SimpleType ParseXmlSchemaSimpleType(Namespace ns, XmlSchemaSimpleType xmlSchemaSimpleType, string? defaultTypeName = null)
  {
    var added = false;
    var updated = false;
    var nsId = ns.Id;
    string typeName = xmlSchemaSimpleType.Name ?? defaultTypeName ?? throw new InvalidDataException("Empty type def name");
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

    var baseSchemaType = xmlSchemaSimpleType.BaseXmlSchemaType;
    if (baseSchemaType != null)
    {
      var baseTypeName = baseSchemaType.Name ?? baseSchemaType.QualifiedName.Name;
      var baseTypeNamespace = baseSchemaType.QualifiedName.Namespace;
      var baseType = CheckTypeDef(baseTypeName, baseTypeNamespace, TypeKind.Simple);
      if (simpleType.BaseTypeId != baseType.Id)
      {
        simpleType.BaseTypeId = baseType.Id;
        if (SaveChanges() > 0)
          updated = true;
      }
      if (updated)
        SaveChanges();
    }

    if (ParseXmlSchemaSimpleTypeDetails(simpleType, xmlSchemaSimpleType))
      updated = true;

    if (!added)
      if (updated)
      {
        WriteLine("updated");
        SimpleTypesUpdated++;
      }
      else
        WriteLine("ok");

    return simpleType;
  }

  internal bool ParseXmlSchemaSimpleTypeDetails(SimpleType simpleType, XmlSchemaSimpleType XmlSchemaSimpleType)
  {
    bool added = false;
    bool updated = false;
    if (XmlSchemaSimpleType.Content is XmlSchemaSimpleTypeRestriction restriction)
    {
      if (restriction.Facets.Count > 0)
      {
        var facet = restriction.Facets[0];
        if (facet is XmlSchemaEnumerationFacet enumerationFacet)
        {
          return ParseXmlSchemaSimpleTypeEnumRestriction(simpleType, restriction);
        }
        else if (facet is XmlSchemaPatternFacet patternFacet)
        {
          return ParseXmlSchemaSimpleTypePatternRestriction(simpleType, restriction);
        }
        else
        {
          return ParseXmlSchemaSimpleTypeOtherRestriction(simpleType, restriction);
        }
      }
      else
      {
        var baseTypeName = restriction.BaseTypeName.Name;
        var baseTypeNamespace = restriction.BaseTypeName.Namespace;
        if (baseTypeNamespace == null)
          throw new NotImplementedException($"Base type namespace in {simpleType.Name} is null");
        var baseType = CheckTypeDef(baseTypeName, baseTypeNamespace, TypeKind.Simple);
        if (simpleType.BaseTypeId != baseType.Id)
        {
          simpleType.BaseTypeId = baseType.Id;
          if (SaveChanges() > 0)
          {
            if (!added)
              updated = true;
          }
        }
      }
    }
    else
    if (XmlSchemaSimpleType.Content is XmlSchemaSimpleTypeUnion union)
    {
      return ParseXmlSchemaSimpleTypeUnion(simpleType, union);
    }
    else
    if (XmlSchemaSimpleType.Content is XmlSchemaSimpleTypeList list)
    {
      return ParseXmlSchemaSimpleTypeList(simpleType, list);
    }
    else
      throw new NotImplementedException($"Simple type content {XmlSchemaSimpleType.Content} not supported");
    return added || updated;
  }

  private TypeDef CheckTypeDef(string baseTypeName, string baseTypeNamespace, TypeKind typeKind)
  {
    if (!dbContext.NamespacesDictionary.TryGetValue(baseTypeNamespace, out var ns))
      throw new NotImplementedException($"Namespace {baseTypeNamespace} not found");
    if (!ns.TypesDictionary.TryGetValue(baseTypeName, out var baseType))
    {
      if (typeKind == TypeKind.Complex || baseTypeName.StartsWith("CT_"))
        baseType = new Model.ComplexType { NamespaceId = ns.Id, Name = baseTypeName };
      else
        baseType = new SimpleType { NamespaceId = ns.Id, Name = baseTypeName };
      dbContext.Types.Add(baseType);
      if (SaveChanges() > 0)
        SimpleTypesAdded++;
    }
    return baseType;
  }

  internal bool ParseXmlSchemaSimpleTypeEnumRestriction(SimpleType simpleType, XmlSchemaSimpleTypeRestriction restriction)
  {
    bool added = false;
    bool updated = false;
    int n = 0;
    simpleType.IsEnum = true;
    foreach (var facet in restriction.Facets)
    {
      var enumerationFacet = (XmlSchemaEnumerationFacet)facet;
      var stringValue = enumerationFacet.Value;
      if (stringValue == null)
        throw new NotImplementedException("Enumeration facet is null");

      if (!simpleType.EnumValuesDictionary.TryGetValue(stringValue, out var enumValue))
      {
        enumValue = new EnumValue { OwnerTypeId = simpleType.Id, Name = stringValue };
        dbContext.EnumValues.Add(enumValue);
        enumValue.Value = n++;
        if (SaveChanges() > 0)
          SchemaEnumValuesAdded++;
        added = true;
      }
    }
    var baseTypeName = restriction.BaseTypeName.Name;
    var baseTypeNamespace = restriction.BaseTypeName.Namespace;
    var baseType = CheckTypeDef(baseTypeName, baseTypeNamespace, TypeKind.Simple);
    if (simpleType.BaseTypeId != baseType.Id)
    {
      simpleType.BaseTypeId = baseType.Id;
      if (SaveChanges() > 0)
      {
        updated = true;
      }
    }
    return added || updated;
  }

  internal bool ParseXmlSchemaSimpleTypePatternRestriction(SimpleType simpleType, XmlSchemaSimpleTypeRestriction restriction)
  {
    bool added = false;
    simpleType.HasPattern = true;
    foreach (var facet in restriction.Facets)
    {
      var patternFacet = (XmlSchemaPatternFacet)facet;
      var patternValue = patternFacet.Value;
      if (patternValue == null)
        throw new NotImplementedException("Pattern facet is null");
      if (!simpleType.PatternsDictionary.TryGetValue(patternValue, out var schemaPattern))
      {
        schemaPattern = new Pattern { OwnerTypeId = simpleType.Id, Value = patternValue };
        dbContext.Patterns.Add(schemaPattern);
        if (SaveChanges() > 0)
          SchemaPatternsAdded++;
        added = true;
      }
    }
    return added;
  }

  internal bool ParseXmlSchemaSimpleTypeOtherRestriction(SimpleType simpleType, XmlSchemaSimpleTypeRestriction restriction)
  {
    bool updated = false;
    var baseTypeName = restriction.BaseTypeName.Name;
    var baseTypeNamespace = restriction.BaseTypeName.Namespace;
    var baseType = CheckTypeDef(baseTypeName, baseTypeNamespace, TypeKind.Simple);
    if (simpleType.BaseTypeId != baseType.Id)
    {
      simpleType.BaseTypeId = baseType.Id;
      updated = true;
    }
    foreach (var facet in restriction.Facets)
    {
      if (facet is XmlSchemaMinExclusiveFacet minExclusiveFacet)
      {
        if (simpleType.MinExclusive != minExclusiveFacet.Value)
        {
          simpleType.MinExclusive = minExclusiveFacet.Value;
          updated = true;
        }
      }
      else
      if (facet is XmlSchemaMinInclusiveFacet minInclusiveFacet)
      {
        if (simpleType.MinInclusive != minInclusiveFacet.Value)
        {
          simpleType.MinInclusive = minInclusiveFacet.Value;
          updated = true;
        }
      }
      else
      if (facet is XmlSchemaMaxInclusiveFacet maxInclusiveFacet)
      {
        if (simpleType.MaxInclusive != maxInclusiveFacet.Value)
        {
          simpleType.MaxInclusive = maxInclusiveFacet.Value;
          updated = true;
        }
      }
      else
      if (facet is XmlSchemaMaxExclusiveFacet maxExclusiveFacet)
      {
        if (simpleType.MaxExclusive != maxExclusiveFacet.Value)
        {
          simpleType.MaxExclusive = maxExclusiveFacet.Value;
          updated = true;
        }
      }
      else
      if (facet is XmlSchemaMinLengthFacet minLengthFacet)
      {
        var minLengthValue = GetIntegerValue(minLengthFacet.Value);
        if (simpleType.MinLength != minLengthValue)
        {
          simpleType.MinLength = minLengthValue;
          updated = true;
        }
      }
      else
      if (facet is XmlSchemaLengthFacet lengthFacet)
      {
        var lengthValue = GetIntegerValue(lengthFacet.Value);
        if (simpleType.Length != lengthValue)
        {
          simpleType.Length = lengthValue;
          updated = true;
        }
      }
      else
      if (facet is XmlSchemaMaxLengthFacet maxLengthFacet)
      {
        var maxLengthValue = GetIntegerValue(maxLengthFacet.Value);
        if (simpleType.MaxLength != maxLengthValue)
        {
          simpleType.MaxLength = maxLengthValue;
          updated = true;
        }
      }
      else
        throw new NotImplementedException($"Restriction type {facet.GetType()} not supported");
    }
    if (updated)
      SaveChanges();
    return updated;
  }

  internal int GetIntegerValue(string? value)
  {
    if (int.TryParse(value, CultureInfo.InvariantCulture, out var val))
      return val;
    throw new NotImplementedException($"Value {value} should be int number");
  }

  internal bool ParseXmlSchemaSimpleTypeUnion(SimpleType simpleType, XmlSchemaSimpleTypeUnion union)
  {
    bool added = false;
    bool updated = false;
    if (union.MemberTypes != null)
    {
      if (!simpleType.IsUnion)
      {
        simpleType.IsUnion = true;
        if (SaveChanges() > 0)
          updated = true;
      }
      foreach (var xmlMemberType in union.MemberTypes)
      {
        var type = xmlMemberType;
        var memberTypeName = type.Name;
        var memberTypeNamespace = xmlMemberType.Namespace;
        if (!dbContext.NamespacesDictionary.TryGetValue(memberTypeNamespace, out var memberNamespace))
          throw new NotImplementedException($"Namespace {memberTypeNamespace} in type {simpleType.Name} not found");

        if (!simpleType.UnionMembersDictionary.TryGetValue(TypeDef.GetFullName(memberNamespace, memberTypeName), out var schemaUnionMember))
        {
          var memberType = CheckTypeDef(memberTypeName, memberNamespace.Url, TypeKind.Simple);
          if (memberType == null)
            throw new NotImplementedException($"Member type {memberNamespace.Url}/{memberTypeName} not found");
          schemaUnionMember = new UnionMember { OwnerTypeId = simpleType.Id, MemberTypeId = memberType.Id };
          dbContext.UnionMembers.Add(schemaUnionMember);
          if (SaveChanges() > 0)
            SchemaUnionMembersAdded++;
          added = true;
        }
      }
    }
    else
    if (union.BaseMemberTypes != null)
    {
      simpleType.IsUnion = true;
      foreach (var xmlMemberType in union.BaseMemberTypes)
      {
        var memberTypeName = xmlMemberType.Name;
        var memberTypeNamespace = xmlMemberType.QualifiedName.Namespace;
        if (memberTypeName == null)
        {
          var baseMemberType = ParseXmlSchemaSimpleType(simpleType.Namespace, xmlMemberType, $"anon_{++this.AnonSimpleTypes}");
          memberTypeName = baseMemberType.Name;
          memberTypeNamespace = baseMemberType.Namespace.Url;
        }

        if (!dbContext.NamespacesDictionary.TryGetValue(memberTypeNamespace, out var memberNamespace))
          throw new NotImplementedException($"Namespace {memberTypeNamespace} in type {simpleType.Name} not found");

        if (!simpleType.UnionMembersDictionary.TryGetValue(TypeDef.GetFullName(memberNamespace, memberTypeName), out var schemaUnionMember))
        {
          var memberType = CheckTypeDef(memberTypeName, memberNamespace.Url, TypeKind.Simple);
          if (memberType == null)
            throw new NotImplementedException($"Member type {memberNamespace.Url}/{memberTypeName} not found");
          schemaUnionMember = new UnionMember { OwnerTypeId = simpleType.Id, MemberTypeId = memberType.Id };
          dbContext.UnionMembers.Add(schemaUnionMember);
          if (SaveChanges() > 0)
            SchemaUnionMembersAdded++;
          added = true;
        }
      }
    }
    else
    {
      throw new NotImplementedException("Union type must have member types o base member types declared");
    }
    return added || updated;
  }

  internal bool ParseXmlSchemaSimpleTypeList(SimpleType simpleType, XmlSchemaSimpleTypeList list)
  {
    bool added = false;
    bool updated = false;
    if (!simpleType.IsList)
    {
      simpleType.IsList = true;
      if (SaveChanges() > 0)
        updated = true;
    }
    var memberTypeName = list.ItemTypeName.Name;
    var memberTypeNamespace = list.ItemTypeName.Namespace;
    if (!dbContext.NamespacesDictionary.TryGetValue(memberTypeNamespace, out var memberNamespace))
      throw new NotImplementedException($"Namespace {memberTypeNamespace} in type {simpleType.Name} not found");

    if (!simpleType.ListItemsDictionary.TryGetValue(TypeDef.GetFullName(memberNamespace, memberTypeName), out var schemaListItem))
    {
      var memberType = CheckTypeDef(memberTypeName, memberNamespace.Url, TypeKind.Simple);
      if (memberType == null)
        throw new NotImplementedException($"Member type {memberNamespace.Url}/{memberTypeName} not found");
      schemaListItem = new ListItem { OwnerTypeId = simpleType.Id, MemberTypeId = memberType.Id };
      dbContext.ListItems.Add(schemaListItem);
      if (SaveChanges() > 0)
        SchemaListItemsAdded++;
      added = true;
    }
    return added || updated;
  }

  internal Model.ComplexType ParseXmlSchemaComplexType(Namespace ns, XmlSchemaComplexType xmlSchemaComplexType, string? defaultTypeName = null)
  {
    var added = false;
    var updated = false;
    var nsId = ns.Id;
    string typeName = xmlSchemaComplexType.Name ?? defaultTypeName ?? throw new InvalidDataException("Empty type def name");
    Write($"Checking complex type {ns.Url}/{typeName} ... ");
    Model.ComplexType complexType;
    if (!ns.TypesDictionary.TryGetValue(typeName, out var typeDef))
    {

      complexType = new Model.ComplexType
      {
        NamespaceId = nsId,
        Name = typeName
      };
      dbContext.Types.Add(complexType);
      if (SaveChanges() > 0)
        ComplexTypesAdded++;
      WriteLine("added");
      added = true;
    }
    else
    {
      complexType = (Model.ComplexType)typeDef;
    }

    var baseSchemaType = xmlSchemaComplexType.BaseXmlSchemaType;
    if (baseSchemaType != null)
    {
      var baseTypeName = baseSchemaType.Name ?? baseSchemaType.QualifiedName.Name;
      var baseTypeNamespace = baseSchemaType.QualifiedName.Namespace;
      var baseType = CheckTypeDef(baseTypeName, baseTypeNamespace, TypeKind.Complex);
      if (complexType.BaseTypeId != baseType.Id)
      {
        complexType.BaseTypeId = baseType.Id;
        if (SaveChanges() > 0)
          updated = true;
      }
      if (updated)
        SaveChanges();
    }

    if (ParseXmlSchemaComplexTypeDetails(complexType, xmlSchemaComplexType))
      updated = true;

    if (!added)
      if (updated)
      {
        WriteLine("updated");
        ComplexTypesUpdated++;
      }
      else
        WriteLine("ok");
    return complexType;
  }

  internal bool ParseXmlSchemaComplexTypeDetails(Model.ComplexType complexType, XmlSchemaComplexType xmlSchemaComplexType)
  {
    bool updated = false;
    foreach (var attribute in xmlSchemaComplexType.Attributes)
    {
      if (attribute is XmlSchemaAttribute xmlSchemaAttribute)
      {
        updated = ParseXmlSchemaComplexTypeAttribute(complexType, xmlSchemaAttribute);
      }
      //else
      //if (attribute is XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef)
      //{
      //  ParseXmlSchemaAttributeGroupRef(schemaComplexType, xmlSchemaAttributeGroupRef);
      //}
      //else
      //{
      //  throw new NotImplementedException($"Attribute type {attribute.GetType()} not supported");
      //}
    }

    var contentType = xmlSchemaComplexType.ContentType switch
    {
      XmlSchemaContentType.Empty => ContentType.Empty,
      XmlSchemaContentType.TextOnly => ContentType.TextOnly,
      XmlSchemaContentType.ElementOnly => ContentType.ElementOnly,
      XmlSchemaContentType.Mixed => ContentType.Mixed,
      _ => throw new NotImplementedException($"Content type {xmlSchemaComplexType.ContentType} not supported")
    };
    if (complexType.ContentType != contentType)
    {
      complexType.ContentType = contentType;
      if (SaveChanges() > 0)
      {
        updated = true;
      }
    }

    //if (xmlSchemaComplexType.Particle != null)
    //  ParseXmlSchemaParticle(schemaComplexType, null, xmlSchemaComplexType.Particle, null);
    return updated;
  }

  internal bool ParseXmlSchemaComplexTypeAttribute(Model.ComplexType complexType, XmlSchemaAttribute xmlSchemaAttribute)
  {
    bool updated = false;
    AttributeDef? attributeDef;
    if (xmlSchemaAttribute.Name != null)
    {
      if (!complexType.AttributesDictionary.TryGetValue(xmlSchemaAttribute.Name, out attributeDef))
      {
        attributeDef = new AttributeDef
        {
          OwnerTypeId = complexType.Id,
          Name = xmlSchemaAttribute.Name,
        };
        dbContext.Attributes.Add(attributeDef);
        if (SaveChanges() > 0)
          AttributesAdded++;
      }
    }
    else
    {
      var refAttribute = CheckGlobalAttributeDef(xmlSchemaAttribute.RefName);
      if (!complexType.AttributesDictionary.TryGetValue(refAttribute.FullName, out attributeDef))
      {
        attributeDef = new AttributeDef
        {
          OwnerTypeId = complexType.Id,
          Name = refAttribute.FullName,
          RefAttributeId = refAttribute.Id
        };
        complexType.Attributes ??= new List<AttributeDef>();
        complexType.Attributes.Add(attributeDef);
        if (SaveChanges() > 0)
          updated = true;
      }
    }
    //ParseXmlSchemaAttributeDetails(schemaAttribute, xmlSchemaAttribute);

    return updated;
  }

  internal bool ParseXmlSchemaGlobalAttribute(Namespace ns, XmlSchemaAttribute xmlSchemaAttribute)
  {
    bool added = false;
    bool updated = false;
    int nsId = ns.Id;
    AttributeDef? attributeDef;
    if (xmlSchemaAttribute.Name != null)
    {
      Write($"Checking global attribute {ns.Url}/{xmlSchemaAttribute.Name} ... ");
      var attrName = xmlSchemaAttribute.Name;
      if (!ns.AttributesDictionary.TryGetValue(attrName, out attributeDef))
      {
        attributeDef = new AttributeDef
        {
          OwnerNamespaceId = nsId,
          Name = attrName,
        };
        ns.GlobalAttributes.Add(attributeDef);
        if (SaveChanges() > 0)
          AttributesAdded++;
        added = true;
        WriteLine("added");
      }
    }
    else
      throw new NotImplementedException("Anonymous global attribute not supported");

    //ParseXmlSchemaAttributeDetails(attributeDef, xmlSchemaAttribute);

    if (!added)
      if (updated)
      {
        WriteLine("updated");
        ComplexTypesUpdated++;
      }
      else
        WriteLine("ok");
    return added || updated;
  }


  private AttributeDef CheckGlobalAttributeDef(XmlQualifiedName attributeName)
  {
    var refAttributeName = attributeName.Name;
    var refAttributeNamespace = attributeName.Namespace;
    if (!dbContext.NamespacesDictionary.TryGetValue(refAttributeNamespace, out var ns))
      throw new NotImplementedException($"Namespace {refAttributeNamespace} not found");
    if (!ns.AttributesDictionary.TryGetValue(refAttributeName, out var attributeDef))
    {
      attributeDef = new AttributeDef { OwnerNamespaceId = ns.Id, Name = refAttributeName };
      ns.GlobalAttributes.Add(attributeDef);
      if (SaveChanges() > 0)
        AttributesAdded++;
    }
    return attributeDef;
  }

  internal void ParseXmlSchemaAttributeDetails(AttributeDef schemaAttribute, XmlSchemaAttribute xmlSchemaAttribute)
  {
    if (!string.IsNullOrEmpty(xmlSchemaAttribute.SchemaTypeName.Namespace))
    {
      var ns = dbContext.Namespaces.FirstOrDefault(item => item.Url == xmlSchemaAttribute.SchemaTypeName.Namespace);
      if (ns == null)
        throw new DataException($"Namespace {xmlSchemaAttribute.SchemaTypeName.Namespace} not found");
      schemaAttribute.TypeNamespaceId = ns.Id;
    }
    else
      schemaAttribute.TypeNamespaceId = null;
    schemaAttribute.Name = xmlSchemaAttribute.SchemaTypeName.Name;
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
      WriteLine($"  Updating attribute {schemaAttribute.Name} settings");
      AttributesUpdated++;
    }
  }


  internal bool ParseXmlSchemaAttributeGroup(Namespace ns, XmlSchemaAttributeGroup xmlSchemaAttributeGroup)
  {
    bool added = false;
    bool updated = false;
    int nsId = ns.Id;
    AttributeGroup? attributeGroup;
    if (xmlSchemaAttributeGroup.Name != null)
    {
      Write($"Checking global attribute {ns.Url}/{xmlSchemaAttributeGroup.Name} ... ");
      var attrName = xmlSchemaAttributeGroup.Name;
      if (!ns.AttributeGroupsDictionary.TryGetValue(attrName, out attributeGroup))
      {
        attributeGroup = new AttributeGroup
        {
          OwnerNamespaceId = nsId,
          Name = attrName,
        };
        ns.GlobalAttributeGroups.Add(attributeGroup);
        if (SaveChanges() > 0)
          AttributeGroupsAdded++;
        added = true;
        WriteLine("added");
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
    foreach (var attribute in xmlSchemaAttributeGroup.Attributes)
    {
      if (attribute is XmlSchemaAttribute xmlSchemaAttribute)
      {
        ParseXmlSchemaGroupAttribute(attributeGroup, xmlSchemaAttribute);
      }
      //  else
      //  if (attribute is XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef)
      //  {
      //    ParseXmlSchemaAttributeGroupRef(schemaAttributeGroup, xmlSchemaAttributeGroupRef);
      //  }
      //  else
      //  {
      //    throw new NotImplementedException($"Attribute type {attribute.GetType()} not supported");
      //  }
    }

    if (!added)
      if (updated)
      {
        WriteLine("updated");
        AttributeGroupsUpdated++;
      }
      else
        WriteLine("ok");
    return added || updated;
  }


  internal bool ParseXmlSchemaGroupAttribute(AttributeGroup attributeGroup, XmlSchemaAttribute xmlSchemaAttribute)
  {
    bool added = false;
    bool updated = false;
    AttributeDef? attributeDef;
    if (xmlSchemaAttribute.Name != null)
    {
      //attributeDef = dbContext.Attributes.FirstOrDefault(item =>
      //  item.AttributeGroupId == attributeGroup.Id && item.AttributeName == xmlSchemaAttribute.Name);
      //if (attributeDef == null)
      if (!attributeGroup.AttributesDictionary.TryGetValue(xmlSchemaAttribute.Name, out attributeDef))
      {
        attributeDef = new AttributeDef
        {
          OwnerGroupId = attributeGroup.Id,
          Name = xmlSchemaAttribute.Name,
        };
        attributeGroup.Attributes.Add(attributeDef);
        if (SaveChanges() > 0)
          AttributesAdded++;
        added = true;
      }
    }
    //else
    //{
    //  var ns = dbContext.Namespaces.FirstOrDefault(item => item.Url == xmlSchemaAttribute.RefName.Namespace);
    //  if (ns == null)
    //    throw new DataException($"Namespace {xmlSchemaAttribute.RefName.Namespace} not found");
    //  attributeDef = dbContext.Attributes.FirstOrDefault(item =>
    //    item.AttributeGroupId == attributeGroup.Id && item.AttributeName == xmlSchemaAttribute.RefName.Name && item.RefNamespaceId == ns.Id);
    //  if (attributeDef == null)
    //  {
    //    WriteLine($"Adding group attribute reference to {ns.Url} {xmlSchemaAttribute.RefName.Name}");
    //    attributeDef = new SchemaAttribute
    //    {
    //      AttributeGroupId = attributeGroup.Id,
    //      AttributeName = xmlSchemaAttribute.RefName.Name,
    //      RefNamespaceId = ns.Id
    //    };
    //    dbContext.Attributes.Add(attributeDef);
    //    if (SaveChanges() > 0)
    //      SchemaAttributeGroupsAdded++;
    //  }
    //}
    //ParseXmlSchemaAttributeDetails(attributeDef, xmlSchemaAttribute);
    if (!added)
      if (updated)
      {
        AttributesUpdated++;
      }
    return added || updated;
  }

  //internal void ParseXmlSchemaAttributeGroupRef(ComplexType parentComplexType, XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef)
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

  //internal void ParseXmlSchemaParticle(ComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaParticle xmlSchemaParticle, int? ordNum)
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
  //internal void ParseXmlSchemaAny(ComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaAny xmlSchemaAny, int? ordNum)
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

  //internal void ParseXmlSchemaGroupRef(ComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaGroupRef xmlSchemaGroupRef, int? ordNum)
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

  //internal void ParseXmlSchemaSequence(ComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaSequence xmlSchemaSequence, int? ordNum)
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

  //internal void ParseXmlSchemaChoice(ComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaChoice xmlSchemaChoice, int? ordNum)
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

  //internal void ParseXmlSchemaAll(ComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaAll xmlSchemaAll, int? ordNum)
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

  //  private void ParseXmlSchemaGroupBaseDetails(SchemaGroupBase particle, ComplexType parentComplexType,
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

  //  internal void ParseXmlSchemaElement(ComplexType parentComplexType, SchemaParticle? parentParticle, XmlSchemaElement xmlSchemaElement, int? ordNum)
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
