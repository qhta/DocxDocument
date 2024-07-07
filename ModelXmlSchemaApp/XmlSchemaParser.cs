using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Xml;
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
  public int SchemaFilesTotal, SchemaFilesAdded, SchemaFilesUpdated;
  public int NamespacesTotal, NamespacesAdded, NamespacesUpdates;
  public int UsedNamespacesTotal, UsedNamespacesAdded;
  public int SimpleTypesTotal, SimpleTypesAdded, SimpleTypesUpdated;
  public int ComplexTypesTotal, ComplexTypesAdded, ComplexTypesUpdated;
  public int AttributeDefsTotal, AttributeDefsAdded, AttributeDefsUpdated;
  public int AttributeRefsTotal, AttributeRefsAdded, AttributeRefsUpdated;
  public int AttributeGroupsTotal, AttributeGroupsAdded;
  public int AttributeGroupRefsTotal, AttributeGroupRefsAdded;
  public int OtherParticlesTotal, OtherParticlesAdded, OtherParticlesUpdated;
  public int EnumValuesTotal, EnumValuesAdded;
  public int PatternsTotal, PatternsAdded;
  public int ListItemsTotal, ListItemsAdded, ListItemsUpdates;
  public int UnionMembersTotal, UnionMembersAdded, UnionMembersUpdates;
  public int ElementGroupsTotal, ElementGroupsAdded;
  public int ElementGroupRefsTotal, ElementGroupRefsAdded, ElementGroupRefsUpdated;
  public int ElementsTotal, ElementsAdded, ElementsUpdated;

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

  private bool isNewLine = true;
  internal void Write(string? message)
  {
    Console.Write(message);
    isNewLine = false;
  }

  internal void WriteLine(string? message)
  {
    if (isNewLine && (message == "added" || message == "updated"))
    {
      Debug.Assert(false);
    }
    Console.WriteLine(message);
    isNewLine = true;
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
    SimpleTypesTotal = dbContext.Types.OfType<SimpleType>().Count();
    ComplexTypesTotal = dbContext.Types.OfType<ComplexType>().Count();
    AttributeDefsTotal = dbContext.Attributes.OfType<AttributeDef>().Count();
    AttributeRefsTotal = dbContext.Attributes.OfType<AttributeRef>().Count();
    AttributeGroupsTotal = dbContext.AttributeGroups.Count();
    AttributeGroupRefsTotal = dbContext.Attributes.OfType<AttributeGroupRef>().Count();
    EnumValuesTotal = dbContext.EnumValues.Count();
    PatternsTotal = dbContext.Patterns.Count();
    ListItemsTotal = dbContext.ListItems.Count();
    UnionMembersTotal = dbContext.UnionMembers.Count();
    ElementGroupsTotal = dbContext.ElementGroups.Count();
    ElementGroupRefsTotal = dbContext.Particles.OfType<ElementGroupRef>().Count();
    ElementsTotal = dbContext.Particles.OfType<Element>().Count();
    OtherParticlesTotal = dbContext.Particles.Count() - ElementGroupRefsTotal - ElementsTotal;
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
        OwnerNamespaceId = nsId,
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
    if (baseTypeName.StartsWith("CT_"))
      typeKind = TypeKind.Complex;
    else if (baseTypeName.StartsWith("ST_"))
      typeKind = TypeKind.Simple;
    if (!dbContext.NamespacesDictionary.TryGetValue(baseTypeNamespace, out var ns))
      throw new NotImplementedException($"Namespace {baseTypeNamespace} not found");
    if (!ns.TypesDictionary.TryGetValue(baseTypeName, out var baseType))
    {
      var addComplexType = (typeKind == TypeKind.Complex);
      if (addComplexType)
        baseType = new ComplexType { OwnerNamespaceId = ns.Id, Name = baseTypeName };
      else
        baseType = new SimpleType { OwnerNamespaceId = ns.Id, Name = baseTypeName };
      dbContext.Types.Add(baseType);
      if (SaveChanges() > 0)
      {
        if (addComplexType)
          ComplexTypesAdded++;
        else
          SimpleTypesAdded++;
      }
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
          EnumValuesAdded++;
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
    simpleType.HasPatterns = true;
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
          PatternsAdded++;
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
          schemaUnionMember = new UnionMember { OwnerTypeId = simpleType.Id, MemberTypeId = memberType.Id, MemberType = memberType};
          dbContext.UnionMembers.Add(schemaUnionMember);
          if (SaveChanges() > 0)
            UnionMembersAdded++;
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
          var baseMemberType = ParseXmlSchemaSimpleType(simpleType.OwnerNamespace, xmlMemberType, $"anon_{++this.AnonSimpleTypes}");
          memberTypeName = baseMemberType.Name;
          memberTypeNamespace = baseMemberType.OwnerNamespace.Url;
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
            UnionMembersAdded++;
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
        ListItemsAdded++;
      added = true;
    }
    return added || updated;
  }

  internal ComplexType ParseXmlSchemaComplexType(Namespace ns, XmlSchemaComplexType xmlSchemaComplexType, string? defaultTypeName = null)
  {
    var added = false;
    var updated = false;
    var nsId = ns.Id;
    string typeName = xmlSchemaComplexType.Name ?? defaultTypeName ?? throw new InvalidDataException("Empty type def name");
    Write($"Checking complex type {ns.Url}/{typeName} ... ");
    ComplexType complexType;
    if (!ns.TypesDictionary.TryGetValue(typeName, out var typeDef))
    {
      complexType = new ComplexType
      {
        OwnerNamespaceId = nsId,
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
      complexType = (ComplexType)typeDef;
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

  internal bool ParseXmlSchemaComplexTypeDetails(ComplexType complexType, XmlSchemaComplexType xmlSchemaComplexType)
  {
    bool updated = false;
    foreach (var attribute in xmlSchemaComplexType.Attributes)
    {
      if (attribute is XmlSchemaAttribute xmlSchemaAttribute)
      {
        ParseXmlSchemaComplexTypeAttribute(complexType, xmlSchemaAttribute);
      }
      else
      if (attribute is XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef)
      {
        ParseXmlSchemaAttributeGroupRef(complexType, xmlSchemaAttributeGroupRef);
      }
      else
      {
        throw new NotImplementedException($"Attribute type {attribute.GetType()} not supported");
      }
      if (xmlSchemaComplexType.Particle != null && complexType.ParticleId == null)
      {
        var particle = ParseXmlSchemaComplexTypeParticle(complexType, xmlSchemaComplexType.Particle);
        complexType.Particle = particle;
        updated = true;
      }
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

    if (xmlSchemaComplexType.Particle != null)
      ParseXmlSchemaComplexTypeParticle(complexType, xmlSchemaComplexType.Particle);
    return updated;
  }

  internal void ParseXmlSchemaComplexTypeAttribute(ComplexType complexType, XmlSchemaAttribute xmlSchemaAttribute)
  {
    var added = false;
    AttributeBase? attributeBase;
    if (xmlSchemaAttribute.Name != null)
    {
      var fullName = AttributeBase.GetFullName(complexType.OwnerNamespace, xmlSchemaAttribute.Name);
      if (!complexType.AttributesDictionary.TryGetValue(fullName, out attributeBase))
      {
        attributeBase = new AttributeDef
        {
          OwnerTypeId = complexType.Id,
          Name = xmlSchemaAttribute.Name,
        };
        complexType.HasAttributes = true; dbContext.Attributes.Add(attributeBase);
        if (SaveChanges() > 0)
        {
          AttributeDefsAdded++;
          added = true;
        }
      }
    }
    else
    {
      var refAttribute = CheckGlobalAttributeDef(xmlSchemaAttribute.RefName);
      if (!complexType.AttributesDictionary.TryGetValue(refAttribute.FullName, out attributeBase))
      {
        attributeBase = new AttributeRef
        {
          OwnerTypeId = complexType.Id,
          Name = refAttribute.FullName,
          RefAttributeId = refAttribute.Id
        };
        complexType.HasAttributes = true;
        complexType.Attributes.Add(attributeBase);
        if (SaveChanges() > 0)
        {
          AttributeRefsAdded++;
          added = true;
        }
      }
    }
    if (ParseXmlSchemaAttributeDetails(attributeBase, xmlSchemaAttribute))
    {
      if (!added)
      {
        if (attributeBase.Type == AttributeType.AttributeDef)
          AttributeDefsUpdated++;
        else
          AttributeRefsUpdated++;
      }
    }
  }

  internal bool ParseXmlSchemaGlobalAttribute(Namespace ns, XmlSchemaAttribute xmlSchemaAttribute)
  {
    bool added = false;
    bool updated = false;
    int nsId = ns.Id;
    AttributeBase? attributeBase;
    if (xmlSchemaAttribute.Name != null)
    {
      Write($"Checking global attribute {ns.Url}/{xmlSchemaAttribute.Name} ... ");
      var fullName = AttributeBase.GetFullName(ns, xmlSchemaAttribute.Name);
      if (!ns.AttributesDictionary.TryGetValue(fullName, out attributeBase))
      {
        attributeBase = new AttributeDef
        {
          OwnerNamespaceId = nsId,
          Name = xmlSchemaAttribute.Name,
        };
        ns.Attributes.Add(attributeBase);
        if (SaveChanges() > 0)
        {
          AttributeDefsAdded++;
          added = true;
          WriteLine("added");
        }
      }
    }
    else
      throw new NotImplementedException("Anonymous global attribute not supported");

    if (ParseXmlSchemaAttributeDetails(attributeBase, xmlSchemaAttribute))
      if (!added)
      {
        updated = true;
        if (attributeBase.Type == AttributeType.AttributeDef)
          AttributeDefsUpdated++;
        else
          AttributeRefsUpdated++;
      }

    if (!added)
    {
      if (updated)
        WriteLine("updated");
      else
        WriteLine("ok");
    }
    return added || updated;
  }


  private AttributeDef CheckGlobalAttributeDef(XmlQualifiedName attributeName)
  {
    var attributeNamespace = attributeName.Namespace;
    if (!dbContext.NamespacesDictionary.TryGetValue(attributeNamespace, out var ns))
      throw new NotImplementedException($"Namespace {attributeNamespace} not found");
    var fullName = AttributeBase.GetFullName(ns, attributeName.Name);
    if (!ns.AttributesDictionary.TryGetValue(fullName, out var attributeBase))
    {
      attributeBase = new AttributeDef { OwnerNamespaceId = ns.Id, Name = attributeName.Name };
      ns.Attributes.Add(attributeBase);
      if (SaveChanges() > 0)
        AttributeDefsAdded++;
    }
    else if (attributeBase is not AttributeDef)
    {
      throw new InvalidDataException("There is already an attribute with this name");
    }
    return (AttributeDef)attributeBase;
  }

  private AttributeGroup CheckGlobalAttributeGroup(XmlQualifiedName groupName)
  {
    var refGroupNamespace = groupName.Namespace;
    if (!dbContext.NamespacesDictionary.TryGetValue(refGroupNamespace, out var ns))
      throw new NotImplementedException($"Namespace {refGroupNamespace} not found");
    var fullName = AttributeGroup.GetFullName(ns, groupName.Name);
    if (!ns.AttributeGroupsDictionary.TryGetValue(fullName, out var attributeGroup))
    {
      attributeGroup = new AttributeGroup { OwnerNamespaceId = ns.Id, Name = groupName.Name };
      ns.AttributeGroups.Add(attributeGroup);
      if (SaveChanges() > 0)
        AttributeGroupsAdded++;
    }
    return attributeGroup;
  }

  internal bool ParseXmlSchemaAttributeDetails(AttributeBase attributeBase, XmlSchemaAttribute xmlSchemaAttribute)
  {
    bool updated = false;
    bool isAttributeDef = attributeBase.Type == AttributeType.AttributeDef;
    if (isAttributeDef)
    {
      var attributeDef = (AttributeDef)attributeBase;
      if (!string.IsNullOrEmpty(xmlSchemaAttribute.SchemaTypeName.Namespace))
      {
        var valueType = CheckTypeDef(xmlSchemaAttribute.SchemaTypeName.Name, xmlSchemaAttribute.SchemaTypeName.Namespace,
          TypeKind.Simple);
        if (attributeDef.ValueTypeId != valueType.Id)
        {
          attributeDef.ValueTypeId = valueType.Id;
          updated = true;
        }
      }
      string? defaultValue = xmlSchemaAttribute.DefaultValue ?? xmlSchemaAttribute.FixedValue;
      if (attributeDef.DefaultValue != defaultValue)
      {
        attributeDef.DefaultValue = defaultValue;
        updated = true;
      }
      bool isFixed = xmlSchemaAttribute.FixedValue != null;
      if (attributeDef.IsFixed != isFixed)
      {
        attributeDef.IsFixed = isFixed;
        updated = true;
      }
    }
    AttributeUse? use = xmlSchemaAttribute.Use switch
    {
      XmlSchemaUse.None => null, //AttributeUse.None,
      XmlSchemaUse.Optional => AttributeUse.Optional,
      XmlSchemaUse.Prohibited => AttributeUse.Prohibited,
      XmlSchemaUse.Required => AttributeUse.Required,
      _ => null
    };
    if (attributeBase.Use != use)
    {
      attributeBase.Use = use;
      updated = true;
    }
    if (updated)
    {
      SaveChanges();
    }
    return updated;
  }

  internal bool ParseXmlSchemaAttributeGroup(Namespace ns, XmlSchemaAttributeGroup xmlSchemaAttributeGroup)
  {
    bool added = false;
    int nsId = ns.Id;
    AttributeGroup? attributeGroup;
    if (xmlSchemaAttributeGroup.Name != null)
    {
      Write($"Checking global attribute {ns.Url}/{xmlSchemaAttributeGroup.Name} ... ");
      var fullName = AttributeGroup.GetFullName(ns, xmlSchemaAttributeGroup.Name);
      if (!ns.AttributeGroupsDictionary.TryGetValue(fullName, out attributeGroup))
      {
        attributeGroup = new AttributeGroup
        {
          OwnerNamespaceId = nsId,
          Name = xmlSchemaAttributeGroup.Name,
        };
        ns.AttributeGroups.Add(attributeGroup);
        if (SaveChanges() > 0)
        {
          AttributeGroupsAdded++;
          added = true;
          WriteLine("added");
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

    foreach (var attribute in xmlSchemaAttributeGroup.Attributes)
    {
      if (attribute is XmlSchemaAttribute xmlSchemaAttribute)
      {
        ParseXmlSchemaGroupAttribute(attributeGroup, xmlSchemaAttribute);
      }
      else
      if (attribute is XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef)
      {
        ParseXmlSchemaAttributeGroupRef(attributeGroup, xmlSchemaAttributeGroupRef);
      }
      else
      {
        throw new NotImplementedException($"Attribute type {attribute.GetType()} not supported");
      }
    }

    if (!added)
      WriteLine("ok");
    return added;
  }


  internal void ParseXmlSchemaGroupAttribute(AttributeGroup attributeGroup, XmlSchemaAttribute xmlSchemaAttribute)
  {
    bool added = false;
    AttributeBase? attributeBase;
    if (xmlSchemaAttribute.Name != null)
    {
      var fullName = AttributeBase.GetFullName(attributeGroup.OwnerNamespace, xmlSchemaAttribute.Name);
      if (!attributeGroup.AttributesDictionary.TryGetValue(fullName, out attributeBase))
      {
        attributeBase = new AttributeDef
        {
          OwnerGroupId = attributeGroup.Id,
          Name = xmlSchemaAttribute.Name,
        };
        attributeGroup.Attributes.Add(attributeBase);
        if (SaveChanges() > 0)
        {
          AttributeDefsAdded++;
          added = true;
        }
      }
      else if (attributeBase is not AttributeDef)
      {
        throw new InvalidDataException("There is already an attribute group with this name");
      }
    }
    else
    {
      var refAttribute = CheckGlobalAttributeDef(xmlSchemaAttribute.RefName);
      if (!attributeGroup.AttributesDictionary.TryGetValue(refAttribute.FullName, out attributeBase))
      {
        attributeBase = new AttributeRef
        {
          OwnerGroupId = attributeGroup.Id,
          Name = refAttribute.FullName,
          RefAttributeId = refAttribute.Id
        };
        attributeGroup.Attributes.Add(attributeBase);
        if (SaveChanges() > 0)
        {
          AttributeRefsAdded++;
          added = true;
        }
      }
    }

    if (ParseXmlSchemaAttributeDetails(attributeBase, xmlSchemaAttribute))
      if (!added)
      {
        if (attributeBase.Type == AttributeType.AttributeDef)
          AttributeDefsUpdated++;
        else
          AttributeRefsUpdated++;
      }
  }

  internal void ParseXmlSchemaAttributeGroupRef(ComplexType complexType, XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef)
  {
    var attributeGroup = CheckGlobalAttributeGroup(xmlSchemaAttributeGroupRef.RefName);
    var fullName = attributeGroup.FullName;
    if (!complexType.AttributesDictionary.TryGetValue(fullName, out var schemaAttributeGroupRef))
    {
      schemaAttributeGroupRef = new AttributeGroupRef
      {
        OwnerTypeId = complexType.Id,
        Name = fullName,
        RefGroupId = attributeGroup.Id
      };
      complexType.Attributes.Add(schemaAttributeGroupRef);
      if (SaveChanges() > 0)
        AttributeGroupRefsAdded++;
    }
  }

  internal void ParseXmlSchemaAttributeGroupRef(AttributeGroup parentGroup, XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef)
  {
    var attributeGroup = CheckGlobalAttributeGroup(xmlSchemaAttributeGroupRef.RefName);
    var attributeGroupName = attributeGroup.FullName;
    if (!parentGroup.AttributesDictionary.TryGetValue(attributeGroupName, out var schemaAttributeGroupRef))
    {
      schemaAttributeGroupRef = new AttributeGroupRef
      {
        OwnerTypeId = parentGroup.Id,
        Name = attributeGroupName,
        RefGroupId = attributeGroup.Id
      };
      parentGroup.Attributes.Add(schemaAttributeGroupRef);
      if (SaveChanges() > 0)
        AttributeGroupRefsAdded++;
    }
  }

  internal Particle ParseXmlSchemaParticle(ParticleGroup parentParticleGroup, XmlSchemaParticle xmlSchemaParticle, int ordNum)
  {
    if (xmlSchemaParticle is XmlSchemaElement xmlSchemaElement)
    {
      return ParseXmlSchemaElement(parentParticleGroup, xmlSchemaElement, ordNum);
    }
    if (xmlSchemaParticle is XmlSchemaSequence xmlSchemaSequence)
    {
      return ParseXmlSchemaSequence(parentParticleGroup, xmlSchemaSequence, ordNum);
    }
    if (xmlSchemaParticle is XmlSchemaAny xmlSchemaAny)
    {
      return ParseXmlSchemaAny(parentParticleGroup, xmlSchemaAny, ordNum);
    }
    if (xmlSchemaParticle is XmlSchemaAll xmlSchemaAll)
    {
      return ParseXmlSchemaAll(parentParticleGroup, xmlSchemaAll, ordNum);
    }
    if (xmlSchemaParticle is XmlSchemaChoice xmlSchemaChoice)
    {
      return ParseXmlSchemaChoice(parentParticleGroup, xmlSchemaChoice, ordNum);
    }
    if (xmlSchemaParticle is XmlSchemaGroupRef xmlSchemaGroupRef)
    {
      return ParseXmlSchemaGroupRef(parentParticleGroup, xmlSchemaGroupRef, ordNum);
    }
    throw new NotImplementedException($"Sequence item type {xmlSchemaParticle.GetType()} not supported");
  }


  internal Any ParseXmlSchemaAny(ParticleGroup particleGroup, XmlSchemaAny xmlSchemaAny, int ordNum)
  {
    var added = false;
    Any any;
    if (!particleGroup.ItemsDictionary.TryGetValue(ordNum, out var particle))
    {
      any = new Any
      {
        OwnerParticleId = particleGroup.Id,
        OrdNum = ordNum,
      };
      particleGroup.Items.Add(any);
      dbContext.Particles.Add(any);
      if (SaveChanges() > 0)
      {
        ElementGroupRefsAdded++;
        added = true;
      }
    }
    else
    {
      if (particle is Any)
      {
        any = (Any)particle;
      }
      else
      {
        throw new InvalidDataException($"{particleGroup.GetType()} item[{ordNum - 1}] item is not an Any particle");
      }
    }
    if (ParseXmlSchemaAnyDetails(any, xmlSchemaAny))
      if (!added)
        ElementGroupRefsUpdated++;
    return any;
  }

  internal bool ParseXmlSchemaAnyDetails(Any anyParticle, XmlSchemaAny xmlSchemaAny)
  {
    var updated = false;
    if (anyParticle.Namespace != xmlSchemaAny.Namespace)
    {
      anyParticle.Namespace = xmlSchemaAny.Namespace;
      updated = true;
    }
    ContentProcessing? processContents = xmlSchemaAny.ProcessContents switch
    {
      XmlSchemaContentProcessing.Lax => ContentProcessing.Lax,
      XmlSchemaContentProcessing.Skip => ContentProcessing.Skip,
      XmlSchemaContentProcessing.Strict => ContentProcessing.Strict,
      _ => null
    };
    if (anyParticle.ProcessContents != processContents)
    {
      anyParticle.ProcessContents = processContents;
      updated = true;
    }
    var minOccurs = GetOccurs(xmlSchemaAny.MinOccurs, xmlSchemaAny.MinOccursString);
    if (anyParticle.MinOccurs != minOccurs)
    {
      anyParticle.MinOccurs = minOccurs;
      updated = true;
    }
    var maxOccurs = GetOccurs(xmlSchemaAny.MaxOccurs, xmlSchemaAny.MaxOccursString);
    if (anyParticle.MaxOccurs != maxOccurs)
    {
      anyParticle.MaxOccurs = maxOccurs;
      updated = true;
    }
    if (updated)
    {
      SaveChanges();
    }
    return updated;
  }

  internal ElementGroupRef ParseXmlSchemaGroupRef(ParticleGroup particleGroup, XmlSchemaGroupRef xmlSchemaGroupRef, int ordNum)
  {
    var added = false;
    ElementGroupRef elementGroupRef;
    if (!particleGroup.ItemsDictionary.TryGetValue(ordNum, out var particle))
    {
      var refGroup = CheckGlobalElementGroup(xmlSchemaGroupRef.RefName);
      elementGroupRef = new ElementGroupRef
      {
        OwnerParticleId = particleGroup.Id,
        OrdNum = ordNum,
        RefGroupId = refGroup.Id
      };
      particleGroup.Items.Add(elementGroupRef);
      dbContext.Particles.Add(elementGroupRef);
      if (SaveChanges() > 0)
      {
        ElementGroupRefsAdded++;
        added = true;
      }
    }
    else
    {
      if (particle is ElementGroupRef)
      {
        elementGroupRef = (ElementGroupRef)particle;
      }
      else
      {
        throw new InvalidDataException($"{particleGroup.GetType()} item[{ordNum - 1}] is not an element group ref");
      }
    }
    if (ParseXmlSchemaGroupRefDetails(elementGroupRef, xmlSchemaGroupRef))
      if (!added)
        ElementGroupRefsUpdated++;
    return elementGroupRef;
  }

  internal ElementGroupRef ParseXmlSchemaGroupRef(ComplexType parentType, XmlSchemaGroupRef xmlSchemaGroupRef)
  {
    var added = false;
    ElementGroupRef elementGroupRef;
    if (parentType.Particle == null)
    {
      var refGroup = CheckGlobalElementGroup(xmlSchemaGroupRef.RefName);
      elementGroupRef = new ElementGroupRef
      {
        OwnerTypeId = parentType.Id,
        RefGroupId = refGroup.Id
      };
      dbContext.Particles.Add(elementGroupRef);
      if (SaveChanges() > 0)
      {
        ElementGroupRefsAdded++;
        added = true;
      }
    }
    else
    {
      var particle = parentType.Particle;
      if (particle is ElementGroupRef)
      {
        elementGroupRef = (ElementGroupRef)particle;
      }
      else
      {
        throw new InvalidDataException($"ComplexType {parentType.FullName} particle is not {(particle == null ? "null" : "not an element group ref")}");
      }
    }
    if (ParseXmlSchemaGroupRefDetails(elementGroupRef, xmlSchemaGroupRef))
      if (!added)
        ElementGroupRefsUpdated++;
    return elementGroupRef;
  }

  private bool ParseXmlSchemaGroupRefDetails(ElementGroupRef groupRef, XmlSchemaGroupRef xmlSchemaGroupRef)
  {
    bool updated = false;
    var group = CheckGlobalElementGroup(xmlSchemaGroupRef.RefName);
    if (groupRef.RefGroupId != group.Id)
    {
      groupRef.RefGroupId = group.Id;
      updated = true;
    }
    var minOccurs = GetOccurs(xmlSchemaGroupRef.MinOccurs, xmlSchemaGroupRef.MinOccursString);
    if (groupRef.MinOccurs != minOccurs)
    {
      groupRef.MinOccurs = minOccurs;
      updated = true;
    }
    var maxOccurs = GetOccurs(xmlSchemaGroupRef.MaxOccurs, xmlSchemaGroupRef.MaxOccursString);
    if (groupRef.MaxOccurs != maxOccurs)
    {
      groupRef.MaxOccurs = maxOccurs;
      updated = true;
    }
    if (updated)
    {
      SaveChanges();
    }
    return updated;
  }

  internal Sequence ParseXmlSchemaSequence(ParticleGroup particleGroup, XmlSchemaSequence xmlSchemaSequence, int ordNum)
  {
    var added = false;
    Sequence sequence;
    if (!particleGroup.ItemsDictionary.TryGetValue(ordNum, out var particle))
    {
      sequence = new Sequence
      {
        OwnerParticleId = particleGroup?.Id,
        OrdNum = ordNum
      };
      particleGroup?.Items.Add(sequence);
      dbContext.Particles.Add(sequence);
      if (SaveChanges() > 0)
      {
        OtherParticlesAdded++;
        added = true;
      }
    }
    else
    {
      if (particle is Sequence)
      {
        sequence = (Sequence)particle;
      }
      else
      {
        throw new InvalidDataException($"{particleGroup.GetType()} item[{ordNum - 1}] is not a sequence");
      }
    }
    if (ParseXmlSchemaGroupBaseDetails(sequence, xmlSchemaSequence))
      if (!added)
        OtherParticlesUpdated++;
    return sequence;
  }

  internal Sequence ParseXmlSchemaSequence(ElementGroup parentGroup, XmlSchemaSequence xmlSchemaSequence)
  {
    var added = false;
    Sequence sequence;
    if (parentGroup.Particle == null)
    {
      sequence = new Sequence
      {
        OwnerGroupId = parentGroup?.Id,
      };
      dbContext.Particles.Add(sequence);
      if (SaveChanges() > 0)
      {
        OtherParticlesAdded++;
        added = true;
      }
    }
    else
    {
      var particle = parentGroup.Particle;
      if (particle is Sequence)
      {
        sequence = (Sequence)particle;
      }
      else
      {
        throw new InvalidDataException($"Group {parentGroup.FullName} particle is {(particle == null ? "null" : "not a sequence")}");
      }
    }
    if (ParseXmlSchemaGroupBaseDetails(sequence, xmlSchemaSequence))
      if (!added)
        OtherParticlesUpdated++;
    return sequence;
  }

  internal Sequence ParseXmlSchemaSequence(ComplexType parentType, XmlSchemaSequence xmlSchemaSequence)
  {
    var added = false;
    Sequence sequence;
    if (parentType.Particle == null)
    {
      sequence = new Sequence
      {
        OwnerTypeId = parentType.Id,
      };
      dbContext.Particles.Add(sequence);
      if (SaveChanges() > 0)
      {
        OtherParticlesAdded++;
        added = true;
      }
    }
    else
    {
      var particle = parentType.Particle;
      if (particle is Sequence)
      {
        sequence = (Sequence)particle;
      }
      else
      {
        throw new InvalidDataException($"ComplexType {parentType.FullName} particle is {(particle == null ? "null" : "not a sequence")}");
      }
    }
    if (ParseXmlSchemaGroupBaseDetails(sequence, xmlSchemaSequence))
      if (!added)
        OtherParticlesUpdated++;
    return sequence;
  }

  internal Choice ParseXmlSchemaChoice(ParticleGroup particleGroup, XmlSchemaChoice xmlSchemaChoice, int ordNum)
  {
    var added = false;
    Choice choice;
    if (!particleGroup.ItemsDictionary.TryGetValue(ordNum, out var particle))
    {
      choice = new Choice
      {
        OwnerParticleId = particleGroup.Id,
        OrdNum = ordNum
      };
      particleGroup?.Items.Add(choice);
      dbContext.Particles.Add(choice);
      if (SaveChanges() > 0)
      {
        OtherParticlesAdded++;
        added = true;
      }
    }
    else
    {
      if (particle is Choice)
      {
        choice = (Choice)particle;
      }
      else
      {
        throw new InvalidDataException($"{particleGroup.GetType()} item[{ordNum - 1}] is not a choice");
      }
    }
    if (ParseXmlSchemaGroupBaseDetails(choice, xmlSchemaChoice))
      if (!added)
        OtherParticlesUpdated++;
    return choice;
  }

  internal Choice ParseXmlSchemaChoice(ElementGroup parentGroup, XmlSchemaChoice xmlSchemaChoice)
  {
    var added = false;
    Choice choice;
    if (parentGroup.Particle == null)
    {
      choice = new Choice
      {
        OwnerGroupId = parentGroup?.Id,
      };
      dbContext.Particles.Add(choice);
      if (SaveChanges() > 0)
      {
        OtherParticlesAdded++;
        added = true;
      }
    }
    else
    {
      var particle = parentGroup.Particle;
      if (particle is Choice)
      {
        choice = (Choice)particle;
      }
      else
      {
        throw new InvalidDataException($"Group {parentGroup.FullName} particle is {(particle == null ? "null" : "not a choice")}");
      }
    }
    if (ParseXmlSchemaGroupBaseDetails(choice, xmlSchemaChoice))
      if (!added)
        OtherParticlesUpdated++;
    return choice;
  }

  internal Choice ParseXmlSchemaChoice(ComplexType parentType, XmlSchemaChoice xmlSchemaChoice)
  {
    var added = false;
    Choice choice;
    if (parentType.Particle == null)
    {
      choice = new Choice
      {
        OwnerTypeId = parentType.Id,
      };
      dbContext.Particles.Add(choice);
      if (SaveChanges() > 0)
      {
        OtherParticlesAdded++;
        added = true;
      }
    }
    else
    {
      var particle = parentType.Particle;
      if (particle is Choice)
      {
        choice = (Choice)particle;
      }
      else
      {
        throw new InvalidDataException($"ComplexType {parentType.FullName} particle is {(particle == null ? "null" : "not a choice")}");
      }
    }
    if (ParseXmlSchemaGroupBaseDetails(choice, xmlSchemaChoice))
      if (!added)
        OtherParticlesUpdated++;
    return choice;
  }

  internal Particle ParseXmlSchemaAll(ParticleGroup particleGroup, XmlSchemaAll xmlSchemaAll, int ordNum)
  {
    var added = false;
    All all;
    if (!particleGroup.ItemsDictionary.TryGetValue(ordNum, out var particle))
    {
      all = new All
      {
        OwnerParticleId = particleGroup?.Id,
        OrdNum = ordNum
      };
      particleGroup?.Items.Add(all);
      dbContext.Particles.Add(all);
      if (SaveChanges() > 0)
      {
        OtherParticlesAdded++;
        added = true;
      }
    }
    else
    {
      if (particle is Choice)
      {
        all = (All)particle;
      }
      else
      {
        throw new InvalidDataException($"{particleGroup.GetType()} item[{ordNum - 1}] is not a choice");
      }
    }
    if (ParseXmlSchemaGroupBaseDetails(all, xmlSchemaAll))
      if (!added)
        OtherParticlesUpdated++;
    return all;
  }

  internal All ParseXmlSchemaAll(ElementGroup parentGroup, XmlSchemaAll xmlSchemaAll)
  {
    var added = false;
    All all;
    if (parentGroup.Particle == null)
    {
      all = new All()
      {
        OwnerGroupId = parentGroup?.Id,
      };
      dbContext.Particles.Add(all);
      if (SaveChanges() > 0)
      {
        OtherParticlesAdded++;
        added = true;
      }
    }
    else
    {
      var particle = parentGroup.Particle;
      if (particle is Choice)
      {
        all = (All)particle;
      }
      else
      {
        throw new InvalidDataException($"Group {parentGroup.FullName} particle is {(particle == null ? "null" : "not All particle")}");
      }
    }
    if (ParseXmlSchemaGroupBaseDetails(all, xmlSchemaAll))
      if (!added)
        OtherParticlesUpdated++;
    return all;
  }

  internal All ParseXmlSchemaAll(ComplexType parentType, XmlSchemaAll xmlSchemaAll)
  {
    var added = false;
    All all;
    if (parentType.Particle == null)
    {
      all = new All()
      {
        OwnerTypeId = parentType.Id,
      };
      dbContext.Particles.Add(all);
      if (SaveChanges() > 0)
      {
        OtherParticlesAdded++;
        added = true;
      }
    }
    else
    {
      var particle = parentType.Particle;
      if (particle is All)
      {
        all = (All)particle;
      }
      else
      {
        throw new InvalidDataException($"ComplexType {parentType.FullName} particle is {(particle == null ? "null" : "not All particle")}");
      }
    }
    if (ParseXmlSchemaGroupBaseDetails(all, xmlSchemaAll))
      if (!added)
        OtherParticlesUpdated++;
    return all;
  }

  private bool ParseXmlSchemaGroupBaseDetails(ParticleGroup particleGroup, XmlSchemaGroupBase xmlSchemaGroupBase)
  {
    bool updated = false;
    var minOccurs = GetOccurs(xmlSchemaGroupBase.MinOccurs, xmlSchemaGroupBase.MinOccursString);
    if (particleGroup.MinOccurs != minOccurs)
    {
      particleGroup.MinOccurs = minOccurs;
      updated = true;
    }
    var maxOccurs = GetOccurs(xmlSchemaGroupBase.MaxOccurs, xmlSchemaGroupBase.MaxOccursString);
    if (particleGroup.MaxOccurs != maxOccurs)
    {
      particleGroup.MaxOccurs = maxOccurs;
      updated = true;
    }
    if (updated)
      SaveChanges();
    int ordNum1 = 0;
    foreach (var item in xmlSchemaGroupBase.Items)
    {
      ordNum1++;
      if (ordNum1 > particleGroup.Items.Count)
      {
        if (item is XmlSchemaParticle xmlSchemaParticle)
          ParseXmlSchemaParticle(particleGroup, xmlSchemaParticle, ordNum1);
        else
        {
          throw new NotImplementedException($"XmlSchemaGroupBase item type {item.GetType()} not supported");
        }
      }
    }
    return updated;
  }

  internal Element ParseXmlSchemaElement(ParticleGroup parentParticle, XmlSchemaElement xmlSchemaElement, int ordNum)
  {
    var added = false;
    Element? element;
    if (xmlSchemaElement.Name != null)
    {
      if (!parentParticle.ItemsDictionary.TryGetValue(ordNum, out var particle))
      {
        element = new Element
        {
          OwnerParticleId = parentParticle.Id,
          OrdNum = ordNum,
          Name = xmlSchemaElement.Name,
        };
        parentParticle.Items.Add(element);
        dbContext.Particles.Add(element);
        if (SaveChanges() > 0)
        {
          ElementsAdded++;
          added = true;
        }
      }
      else
      {
        if (particle is Element)
        {
          element = (Element)particle;
        }
        else
        {
          throw new InvalidDataException($"{parentParticle.GetType()} item[{ordNum - 1}] is not an element");
        }
      }
    }
    else
    {
      var refElement = CheckGlobalElement(xmlSchemaElement.RefName);
      if (!parentParticle.ItemsDictionary.TryGetValue(ordNum, out var particle))
      {
        element = new Element
        {
          OwnerParticleId = parentParticle.Id,
          OrdNum = ordNum,
          Name = refElement.FullName,
          RefElementId = refElement.Id
        };
        parentParticle.Items.Add(element);
        if (SaveChanges() > 0)
        {
          ElementsAdded++;
          added = true;
        }
      }
      else
      {
        if (particle is Element)
        {
          element = (Element)particle;
        }
        else
        {
          throw new InvalidDataException($"{parentParticle.GetType()} item[{ordNum - 1}] is not an element");
        }
      }
    }
    if (ParseXmlSchemaElementDetails(element, xmlSchemaElement))
      if (!added)
        ElementsUpdated++;
    return element;
  }

  internal bool ParseXmlSchemaGlobalElement(Namespace ns, XmlSchemaElement xmlSchemaElement)
  {
    var added = false;
    var updated = false;
    var nsId = ns.Id;
    Element? element;
    if (xmlSchemaElement.Name != null)
    {
      Write($"Checking global element {ns.Url}.{xmlSchemaElement.Name} ... ");
      var fullName = Element.GetFullName(ns, xmlSchemaElement.Name);
      if (!ns.ElementsDictionary.TryGetValue(fullName, out element))
      {
        element = new Element
        {
          OwnerNamespaceId = nsId,
          Name = xmlSchemaElement.Name,
        };
        ns.Elements.Add(element);
        if (SaveChanges() > 0)
        {
          ElementsAdded++;
          added = true;
          WriteLine("added");
        }
      }
    }
    else
      throw new NotImplementedException("Anonymous global attribute not supported");

    if (ParseXmlSchemaElementDetails(element, xmlSchemaElement))
      if (!added)
      {
        updated = true;
        ElementsUpdated++;
      }

    if (!added)
    {
      if (updated)
        WriteLine("updated");
      else
        WriteLine("ok");
    }
    return added || updated;
  }

  private Element CheckGlobalElement(XmlQualifiedName elementQualifiedName)
  {
    var elementNamespace = elementQualifiedName.Namespace;
    if (!dbContext.NamespacesDictionary.TryGetValue(elementNamespace, out var ns))
      throw new NotImplementedException($"Namespace {elementNamespace} not found");
    var fullName = Element.GetFullName(ns, elementQualifiedName.Name);
    if (!ns.ElementsDictionary.TryGetValue(fullName, out var element))
    {
      element = new Element
      {
        OwnerNamespaceId = ns.Id,
        Name = elementQualifiedName.Name,
      };
      dbContext.Particles.Add(element);
      if (SaveChanges() > 0)
      {
        ElementsAdded++;
      }
    }
    return element;
  }

  internal bool ParseXmlSchemaElementDetails(Element schemaElement, XmlSchemaElement xmlSchemaElement)
  {
    var updated = false;
    if (xmlSchemaElement.SchemaTypeName.Name != "")
    {
      var typeDef = CheckTypeDef(xmlSchemaElement.SchemaTypeName.Name, xmlSchemaElement.SchemaTypeName.Namespace, TypeKind.Complex);
      if (schemaElement.RefTypeId != typeDef.Id)
      {
        schemaElement.RefTypeId = typeDef.Id;
        updated = true;
      }
    }
    var minOccurs = GetOccurs(xmlSchemaElement.MinOccurs, xmlSchemaElement.MinOccursString);
    if (schemaElement.MinOccurs != minOccurs)
    {
      schemaElement.MinOccurs = minOccurs;
      updated = true;
    }
    var maxOccurs = GetOccurs(xmlSchemaElement.MaxOccurs, xmlSchemaElement.MaxOccursString);
    if (schemaElement.MaxOccurs != maxOccurs)
    {
      schemaElement.MaxOccurs = maxOccurs;
      updated = true;
    }
    if (updated)
    {
      SaveChanges();
    }
    return updated;
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

  internal void ParseXmlSchemaGroup(Namespace ns, XmlSchemaGroup xmlSchemaGroup)
  {
    var added = false;
    var updated = false;
    if (xmlSchemaGroup.Name != null)
    {
      Write($"Checking global group {ns.Url}/{xmlSchemaGroup.Name} ... ");
      var fullName = ElementGroup.GetFullName(ns, xmlSchemaGroup.Name);
      if (!ns.ElementGroupsDictionary.TryGetValue(fullName, out var elementGroup))
      {

        elementGroup = new ElementGroup
        {
          OwnerNamespaceId = ns.Id,
          Name = xmlSchemaGroup.Name,
        };
        dbContext.ElementGroups.Add(elementGroup);
        if (SaveChanges() > 0)
        {
          WriteLine("added");
          ElementGroupsAdded++;
          added = true;
        }
      }
      if (xmlSchemaGroup.Particle != null && elementGroup.ParticleId == null)
      {
        var particle = ParseXmlSchemaGroupParticle(elementGroup, xmlSchemaGroup.Particle);
        elementGroup.Particle = particle;
        updated = true;
      }
    }
    else
      throw new InvalidDataException("Global group without name is not supported");

    if (!added)
    {
      if (updated)
        WriteLine("updated");
      else
        WriteLine("ok");
    }
  }
  private ElementGroup CheckGlobalElementGroup(XmlQualifiedName groupQualifiedName)
  {
    var groupNamespace = groupQualifiedName.Namespace;
    if (!dbContext.NamespacesDictionary.TryGetValue(groupNamespace, out var ns))
      throw new NotImplementedException($"Namespace {groupNamespace} not found");
    var fullName = ElementGroup.GetFullName(ns, groupQualifiedName.Name);
    if (!ns.ElementGroupsDictionary.TryGetValue(fullName, out var elementGroup))
    {
      elementGroup = new ElementGroup
      {
        OwnerNamespaceId = ns.Id,
        Name = groupQualifiedName.Name,
      };
      dbContext.ElementGroups.Add(elementGroup);
      if (SaveChanges() > 0)
      {
        ElementGroupsAdded++;
      }
    }
    return elementGroup;
  }

  internal ParticleGroup ParseXmlSchemaGroupParticle(ElementGroup schemaGroup, XmlSchemaParticle xmlSchemaParticle)
  {
    if (xmlSchemaParticle is XmlSchemaSequence xmlSchemaSequence)
    {
      return ParseXmlSchemaSequence(schemaGroup, xmlSchemaSequence);
    }

    if (xmlSchemaParticle is XmlSchemaAll xmlSchemaAll)
    {
      ParseXmlSchemaAll(schemaGroup, xmlSchemaAll);
    }

    if (xmlSchemaParticle is XmlSchemaChoice xmlSchemaChoice)
    {
      return ParseXmlSchemaChoice(schemaGroup, xmlSchemaChoice);
    }

    throw new NotImplementedException($"{schemaGroup.GetType()} item type {xmlSchemaParticle.GetType()} not supported");
  }

  internal Particle ParseXmlSchemaComplexTypeParticle(ComplexType parentType, XmlSchemaParticle xmlSchemaParticle)
  {
    if (xmlSchemaParticle is XmlSchemaSequence xmlSchemaSequence)
    {
      return ParseXmlSchemaSequence(parentType, xmlSchemaSequence);
    }

    if (xmlSchemaParticle is XmlSchemaAll xmlSchemaAll)
    {
      return ParseXmlSchemaAll(parentType, xmlSchemaAll);
    }

    if (xmlSchemaParticle is XmlSchemaChoice xmlSchemaChoice)
    {
      return ParseXmlSchemaChoice(parentType, xmlSchemaChoice);
    }

    if (xmlSchemaParticle is XmlSchemaGroupRef xmlGroupRef)
    {
      return ParseXmlSchemaGroupRef(parentType, xmlGroupRef);
    }

    throw new NotImplementedException($"{parentType.GetType()} item type {xmlSchemaParticle.GetType()} not supported");
  }
}
