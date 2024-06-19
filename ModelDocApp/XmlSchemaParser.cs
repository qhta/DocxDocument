using System.Data;
using System.Globalization;
using System.Xml.Schema;

using ModelDoc;

using SchemaType = ModelDoc.SchemaType;

namespace ModelDocApp;

internal class XmlSchemaParser
{
  internal int AnonSimpleTypes = 0;
  internal ModelsDbContext dbContext = null!;

  public void ParseSchemaFiles()
  {
    var schemaSet = LoadSchemaFiles();
    using (dbContext = new ModelsDbContext())
    {
      ParseSchemaFilesAndNamespaces(schemaSet);
      ParseXmlSchemaSet(schemaSet);
    }
  }

  internal XmlSchemaSet LoadSchemaFiles()
  {
    var files = Directory.GetFiles(@$"D:\VS\Docs\OpenXml\Schemas", "*.xsd");
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
          schemaFile = new SchemaFile { FileName = id };
          dbContext.SchemaFiles.Add(schemaFile);
        }
        if (schema.TargetNamespace != null)
        {
          var schemaNamespace = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == schema.TargetNamespace);
          if (schemaNamespace == null)
          {
            schemaNamespace = new SchemaNamespace { Url = schema.TargetNamespace };
            dbContext.SchemaNamespaces.Add(schemaNamespace);
            dbContext.SaveChanges();
          }
          schemaFile.TargetNamespaceId = schemaNamespace.Id;
        }
        dbContext.SaveChanges();
        Console.WriteLine($"  Checking {schema.Namespaces.Count} namespaces");
        var namespaces = schema.Namespaces.ToArray();
        for (int i = 0; i < namespaces.Count(); i++)
        {
          var ns = namespaces[i];
          if (ns.Namespace != schema.TargetNamespace && ns.Namespace != "#all")
          {
            var schemaNamespace = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == ns.Namespace);
            if (schemaNamespace == null)
            {
              Console.WriteLine($"  adding namespace {ns.Name}\t{ns.Namespace}");
              schemaNamespace = new SchemaNamespace { Url = ns.Namespace };
              dbContext.SchemaNamespaces.Add(schemaNamespace);
              dbContext.SaveChanges();
            }
            var schemaUsedNamespace = dbContext.SchemaUsedNamespaces.FirstOrDefault(item =>
                      item.SchemaFileId == schemaFile.Id && item.SchemaNamespaceId == schemaNamespace.Id && item.Prefix == ns.Name);
            if (schemaUsedNamespace == null)
            {
              Console.WriteLine($"  adding used namespace {ns.Name}\t{schemaNamespace.Id}");
              schemaUsedNamespace = new SchemaUsedNamespace { SchemaFileId = schemaFile.Id, SchemaNamespaceId = schemaNamespace.Id, Prefix = ns.Name };
              dbContext.SchemaUsedNamespaces.Add(schemaUsedNamespace);
              dbContext.SaveChanges();
            }
          }
        }
      }
    }

    SetNamespacePrefixes();
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
    if (dbContext.SaveChanges() > 0)
      Console.WriteLine("Setting namespace prefixes");
  }

  internal void ParseXmlSchemaSet(XmlSchemaSet schemaSet)
  {
    foreach (XmlSchema schema in schemaSet.Schemas())
    {
      Console.WriteLine($"Checking {schema.Id} types");
      if (schema.Id != null)
      {
        string id = schema.Id;
        var schemaFile = dbContext.SchemaFiles.FirstOrDefault(item => item.FileName == id);
        if (schemaFile == null)
        {
          throw new Exception($"Schema filename {id} must be created first");
        }

        foreach (var item in schema.Items)
        {
          if (item is XmlSchemaSimpleType xmlSchemaSimpleType)
          {
            ParseXmlSchemaSimpleType(schemaFile, xmlSchemaSimpleType);
          }
          else
          if (item is XmlSchemaComplexType xmlSchemaComplexType)
          {
            ParseXmlSchemaComplexType(schemaFile, xmlSchemaComplexType);
          }
          else
          if (item is XmlSchemaGroup xmlSchemaGroup)
          {

          }
          else
          if (item is XmlSchemaElement xmlSchemaElement)
          {

          }
          else
          if (item is XmlSchemaAttributeGroup xmlSchemaAttributeGroup)
          {
            ParseXmlSchemaAttributeGroup(schemaFile, xmlSchemaAttributeGroup);
          }
          else
          if (item is XmlSchemaAttribute xmlSchemaAttribute)
          {
            ParseXmlSchemaGlobalAttribute(schemaFile, xmlSchemaAttribute);
          }
          else
          {
            throw new NotImplementedException($"Schema type {item.GetType()} not supported");
          }
        }
      }
    }
  }

  internal SchemaType ParseXmlSchemaSimpleType(SchemaFile schemaFile, XmlSchemaSimpleType xmlSchemaSimpleType, string? defaultTypeName = null)
  {
    var typeName = xmlSchemaSimpleType.Name ?? defaultTypeName;
    var schemaSimpleType = dbContext.SchemaSimpleTypes.FirstOrDefault(item =>
        item.SchemaFileId == schemaFile.Id && item.TypeName == typeName);
    if (schemaSimpleType == null)
    {
      Console.WriteLine($"Adding simple type {typeName}");
      schemaSimpleType = new SchemaSimpleType
      {
        SchemaFileId = schemaFile.Id,
        TypeName = typeName
      };
      dbContext.SchemaTypes.Add(schemaSimpleType);
      dbContext.SaveChanges();
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
        if (dbContext.SaveChanges() > 0)
          Console.WriteLine("  Setting other simple type");
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

  internal void ParseXmlSimpleTypeEnumRestriction(SchemaType schemaSimpleType, XmlSchemaSimpleTypeRestriction restriction)
  {
    int n = 0;
    schemaSimpleType.BaseTypeName = "enum";
    foreach (var facet in restriction.Facets)
    {
      var enumerationFacet = (XmlSchemaEnumerationFacet)facet;
      var schemaEnumValue = dbContext.SchemaEnumValues.FirstOrDefault(item =>
        item.SimpleTypeId == schemaSimpleType.Id && item.EnumValueName == enumerationFacet.Value);
      if (schemaEnumValue == null)
      {
        Console.WriteLine($"  Adding enum value {enumerationFacet.Value}");
        schemaEnumValue = new SchemaEnumValue { SimpleTypeId = schemaSimpleType.Id, EnumValueName = enumerationFacet.Value };
        dbContext.SchemaEnumValues.Add(schemaEnumValue);
      }
      schemaEnumValue.EnumValueNum = n++;
    }
    schemaSimpleType.BaseTypeName = restriction.BaseTypeName.Name;
    dbContext.SaveChanges();
  }

  internal void ParseXmlSimpleTypePatternRestriction(SchemaType schemaSimpleType, XmlSchemaSimpleTypeRestriction restriction)
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
        dbContext.SaveChanges();
      }
    }
  }

  internal void ParseXmlSimpleTypeOtherRestriction(SchemaSimpleType schemaSimpleType, XmlSchemaSimpleTypeRestriction restriction)
  {
    schemaSimpleType.BaseTypeName = restriction.BaseTypeName.Name;
    foreach (var facet in restriction.Facets)
    {
      if (facet is XmlSchemaMinExclusiveFacet minExclusiveFacet)
        schemaSimpleType.MinExclusive = GetDecimalValue(minExclusiveFacet.Value);
      else
      if (facet is XmlSchemaMinInclusiveFacet minInclusiveFacet)
        schemaSimpleType.MinInclusive = GetDecimalValue(minInclusiveFacet.Value);
      else
      if (facet is XmlSchemaMaxInclusiveFacet maxInclusiveFacet)
        schemaSimpleType.MaxInclusive = GetDecimalValue(maxInclusiveFacet.Value);
      else
      if (facet is XmlSchemaMaxExclusiveFacet maxExclusiveFacet)
        schemaSimpleType.MaxExclusive = GetDecimalValue(maxExclusiveFacet.Value);
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
    if (dbContext.SaveChanges() > 0)
      Console.WriteLine("  Adding other simple type restrictions");
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

  internal void ParseXmlSimpleTypeUnion(SchemaType schemaSimpleType, XmlSchemaSimpleTypeUnion union)
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
        dbContext.SaveChanges();
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
            schemaUnionMember = new SchemaUnionMember { SimpleTypeId = schemaSimpleType.Id, MemberTypeName = memberType.Name };
            dbContext.SchemaUnionMembers.Add(schemaUnionMember);
          }
          var memberNamespace = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == memberType.Namespace);
          if (memberNamespace == null)
            throw new NotImplementedException($"Namespace {memberType.Namespace} in type {schemaSimpleType.TypeName} not found");
          schemaUnionMember.MemberNamespaceId = memberNamespace.Id;

          if (dbContext.SaveChanges() > 0)
            Console.WriteLine($"  Setting type unit item {memberType.Name}");
        }
      }
    }
    else
    if (union.BaseMemberTypes != null)
    {
      schemaSimpleType.BaseTypeName = "union";
      foreach (var memberType in union.BaseMemberTypes)
      {
        var memberSimpleType = ParseXmlSchemaSimpleType(schemaSimpleType.SchemaFile!, memberType, $"_anon_{(++AnonSimpleTypes)}");
        var schemaUnionMember = dbContext.SchemaUnionMembers.FirstOrDefault(item =>
          item.SimpleTypeId == schemaSimpleType.Id && item.MemberTypeName == memberSimpleType.TypeName);
        if (schemaUnionMember == null)
        {
          schemaUnionMember = new SchemaUnionMember { SimpleTypeId = schemaSimpleType.Id, MemberTypeName = memberSimpleType.TypeName };
          dbContext.SchemaUnionMembers.Add(schemaUnionMember);
        }
        var url = memberSimpleType.SchemaFile!.TargetNamespace!.Url;
        var memberNamespace = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == url);
        if (memberNamespace == null)
          throw new NotImplementedException($"Namespace {url} in type {schemaSimpleType.TypeName} not found");
        schemaUnionMember.MemberNamespaceId = memberNamespace.Id;

        if (dbContext.SaveChanges() > 0)
          Console.WriteLine($"  Setting type unit item {memberType.Name}");
      }
    }
  }

  internal void ParseXmlSimpleTypeList(SchemaType schemaSimpleType, XmlSchemaSimpleTypeList list)
  {
    schemaSimpleType.BaseTypeName = "list";
    var itemType = list.ItemTypeName;
    var schemaListItem = dbContext.SchemaListItems.FirstOrDefault(item =>
      item.SimpleTypeId == schemaSimpleType.Id && item.ItemTypeName == itemType.Name);
    if (schemaListItem == null)
    {
      schemaListItem = new SchemaListItem { SimpleTypeId = schemaSimpleType.Id, ItemTypeName = itemType.Name };
      dbContext.SchemaListItems.Add(schemaListItem);
    }

    var itemNamespace = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == itemType.Namespace);
    if (itemNamespace == null)
      throw new NotImplementedException(
        $"Namespace {itemType.Namespace} in type {schemaSimpleType.TypeName} not found");
    schemaListItem.ItemNamespaceId = itemNamespace.Id;
    if (dbContext.SaveChanges() > 0)
      Console.WriteLine($"  Setting type list item {itemType.Name}");
  }

  internal SchemaType ParseXmlSchemaComplexType(SchemaFile schemaFile, XmlSchemaComplexType xmlSchemaComplexType, string? defaultTypeName = null)
  {
    var typeName = xmlSchemaComplexType.Name ?? defaultTypeName;
    var schemaComplexType = dbContext.SchemaComplexTypes.FirstOrDefault(item =>
      item.SchemaFileId == schemaFile.Id && item.TypeName == typeName);
    if (schemaComplexType == null)
    {
      Console.WriteLine($"Adding complex type {typeName}");
      schemaComplexType = new SchemaComplexType
      {
        SchemaFileId = schemaFile.Id,
        TypeName = typeName
      };
      dbContext.SchemaTypes.Add(schemaComplexType);
      dbContext.SaveChanges();
    }
    if (xmlSchemaComplexType.BaseXmlSchemaType != null)
    {
      if (xmlSchemaComplexType.BaseXmlSchemaType.Name != null)
        schemaComplexType.BaseTypeName = xmlSchemaComplexType.BaseXmlSchemaType.Name;
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
    if (dbContext.SaveChanges() > 0)
      Console.WriteLine("  Setting complex type content type");
    if (xmlSchemaComplexType.Particle != null)
    {
      ParseXmlSchemaParticle(schemaComplexType, null, xmlSchemaComplexType.Particle, null);
    }
  }

  internal void ParseXmlSchemaComplexTypeAttribute(SchemaType schemaComplexType, XmlSchemaAttribute xmlSchemaAttribute)
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
        dbContext.SaveChanges();
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
        dbContext.SaveChanges();
      }
    }
    ParseXmlSchemaAttributeDetails(schemaAttribute, xmlSchemaAttribute);
  }

  internal void ParseXmlSchemaGlobalAttribute(SchemaFile schemaFile, XmlSchemaAttribute xmlSchemaAttribute)
  {
    SchemaAttribute? schemaAttribute;
    if (xmlSchemaAttribute.Name != null)
    {
      schemaAttribute = dbContext.SchemaAttributes.FirstOrDefault(item =>
        item.SchemaFileId == schemaFile.Id && item.AttributeName == xmlSchemaAttribute.Name);
      if (schemaAttribute == null)
      {
        Console.WriteLine($"Adding global attribute {xmlSchemaAttribute.Name}");
        schemaAttribute = new SchemaAttribute
        {
          SchemaFileId = schemaFile.Id,
          AttributeName = xmlSchemaAttribute.Name,
        };
        dbContext.SchemaAttributes.Add(schemaAttribute);
        dbContext.SaveChanges();
      }
    }
    else
    {
      var ns = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == xmlSchemaAttribute.RefName.Namespace);
      if (ns == null)
        throw new DataException($"Namespace {xmlSchemaAttribute.RefName.Namespace} not found");
      schemaAttribute = dbContext.SchemaAttributes.FirstOrDefault(item =>
        item.SchemaFileId == schemaFile.Id && item.AttributeName == xmlSchemaAttribute.RefName.Name && item.RefNamespaceId == ns.Id);
      if (schemaAttribute == null)
      {
        Console.WriteLine($"Adding global attribute reference to {ns.Url} {xmlSchemaAttribute.RefName.Name}");
        schemaAttribute = new SchemaAttribute
        {
          SchemaFileId = schemaFile.Id,
          AttributeName = xmlSchemaAttribute.RefName.Name,
          RefNamespaceId = ns.Id
        };
        dbContext.SchemaAttributes.Add(schemaAttribute);
        dbContext.SaveChanges();
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
    if (dbContext.SaveChanges() > 0)
      Console.WriteLine($"  Changing attribute {schemaAttribute.AttributeName} settings");
  }


  internal void ParseXmlSchemaAttributeGroup(SchemaFile schemaFile, XmlSchemaAttributeGroup xmlSchemaAttributeGroup)
  {
    if (xmlSchemaAttributeGroup.Name != null)
    {
      var schemaAttributeGroup = dbContext.SchemaAttributeGroups.FirstOrDefault(item =>
        item.SchemaFileId == schemaFile.Id && item.GroupName == xmlSchemaAttributeGroup.Name);
      if (schemaAttributeGroup == null)
      {
        Console.WriteLine($"Adding attribute group {xmlSchemaAttributeGroup.Name}");
        schemaAttributeGroup = new SchemaAttributeGroup
        {
          SchemaFileId = schemaFile.Id,
          GroupName = xmlSchemaAttributeGroup.Name,
        };
        dbContext.SchemaAttributeGroups.Add(schemaAttributeGroup);
        dbContext.SaveChanges();
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
        dbContext.SaveChanges();
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
        dbContext.SaveChanges();
      }
    }
    ParseXmlSchemaAttributeDetails(schemaAttribute, xmlSchemaAttribute);
  }

  internal void ParseXmlSchemaAttributeGroupRef(SchemaAttributeGroup schemaAttributeGroup, XmlSchemaAttributeGroupRef xmlSchemaAttributeGroupRef)
  {
    var ns = dbContext.SchemaNamespaces.First(item => item.Url == xmlSchemaAttributeGroupRef.RefName.Namespace);
    var schemaAttributeGroupRef = dbContext.SchemaAttributeGroupRefs.FirstOrDefault(item =>
      item.AttributeGroupId == schemaAttributeGroup.Id && item.GroupName == xmlSchemaAttributeGroupRef.RefName.Name
      && item.RefNamespaceId == ns.Id);
    if (schemaAttributeGroupRef == null)
    {
      Console.WriteLine($"Adding attribute group ref {xmlSchemaAttributeGroupRef.RefName.Name}");
      schemaAttributeGroupRef = new SchemaAttributeGroupRef
      {
        AttributeGroupId = schemaAttributeGroup.Id,
        GroupName = xmlSchemaAttributeGroupRef.RefName.Name,
        RefNamespaceId = ns.Id
      };
      dbContext.SchemaAttributeGroupRefs.Add(schemaAttributeGroupRef);
      dbContext.SaveChanges();
    }
  }

  internal void ParseXmlSchemaParticle(SchemaComplexType schemaComplexType, SchemaParticle? parentParticle, XmlSchemaParticle xmlSchemaParticle, int? ordNum)
  {
    if (xmlSchemaParticle is XmlSchemaElement xmlSchemaElement)
    {
      ParseXmlSchemaElement(schemaComplexType, parentParticle, xmlSchemaElement, ordNum);
    }
    else
    if (xmlSchemaParticle is XmlSchemaSequence xmlSchemaSequence)
    {
      ParseXmlSchemaSequence(schemaComplexType, parentParticle, xmlSchemaSequence, ordNum);
    }
    else
    if (xmlSchemaParticle is XmlSchemaAny xmlSchemaAny)
    {
      ParseXmlSchemaAny(schemaComplexType, parentParticle, xmlSchemaAny, ordNum);
    }
    else
    if (xmlSchemaParticle is XmlSchemaAll xmlSchemaAll)
    {
      ParseXmlSchemaAll(schemaComplexType, parentParticle, xmlSchemaAll, ordNum);
    }
    else
    if (xmlSchemaParticle is XmlSchemaChoice xmlSchemaChoice)
    {
      ParseXmlSchemaChoice(schemaComplexType, parentParticle, xmlSchemaChoice, ordNum);
    }
    else

    if (xmlSchemaParticle is XmlSchemaGroupRef xmlSchemaGroupRef)
    {
      ParseXmlSchemaGroupRef(schemaComplexType, parentParticle, xmlSchemaGroupRef, ordNum);
    }
    else
    {
      throw new NotImplementedException($"Sequence item type {xmlSchemaParticle.GetType()} not supported");
    }
  }

  internal void ParseXmlSchemaAny (SchemaComplexType schemaComplexType, SchemaParticle? parentParticle, XmlSchemaAny xmlSchemaAny, int? ordNum)
  {
    var schemaParticle = (SchemaAny?)dbContext.SchemaParticles.FirstOrDefault(item =>
      item.ComplexTypeId == schemaComplexType.Id && item.OrdNum == ordNum && item.ParticleType == ParticleType.Any);
    if (schemaParticle == null)
    {
      schemaParticle = new SchemaAny
      {
        ComplexTypeId = schemaComplexType.Id,
        ParentParticleId = parentParticle?.Id,
        OrdNum = ordNum
      };
      dbContext.SchemaParticles.Add(schemaParticle);
      dbContext.SaveChanges();
      Console.WriteLine($"Adding Any particle {schemaParticle.Id}");
    }
    schemaParticle.Namespace = xmlSchemaAny.Namespace;
    schemaParticle.ProcessContents = xmlSchemaAny.ProcessContents switch
    {
      XmlSchemaContentProcessing.Lax => ContentProcessing.Lax,
      XmlSchemaContentProcessing.Skip => ContentProcessing.Skip,
      XmlSchemaContentProcessing.Strict => ContentProcessing.Strict,
      _ => null
    };
    schemaParticle.MinOccurs = GetOccurs(xmlSchemaAny.MinOccurs, xmlSchemaAny.MinOccursString);
    schemaParticle.MaxOccurs = GetOccurs(xmlSchemaAny.MaxOccurs, xmlSchemaAny.MaxOccursString);
    if (dbContext.SaveChanges() > 0)
      Console.WriteLine($"  Changing Any particle {schemaParticle.Id} settings");
  }

  internal void ParseXmlSchemaGroupRef(SchemaComplexType schemaComplexType, SchemaParticle? parentParticle, XmlSchemaGroupRef xmlSchemaGroupRef, int? ordNum)
  {
    var schemaParticle = (SchemaGroupRef?)dbContext.SchemaParticles.FirstOrDefault(item =>
      item.ComplexTypeId == schemaComplexType.Id && item.OrdNum == ordNum && item.ParticleType == ParticleType.GroupRef);
    if (schemaParticle == null)
    {
      schemaParticle = new SchemaGroupRef
      {
        ComplexTypeId = schemaComplexType.Id,
        ParentParticleId = parentParticle?.Id,
        OrdNum = ordNum
      };
      dbContext.SchemaParticles.Add(schemaParticle);
      dbContext.SaveChanges();
      Console.WriteLine($"Adding GroupRef particle {schemaParticle.Id}");
    }
    schemaParticle.Name = xmlSchemaGroupRef.RefName.Name;
    var ns = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == xmlSchemaGroupRef.RefName.Namespace);
    if (ns == null)
      throw new DataException($"Namespace {xmlSchemaGroupRef.RefName.Namespace} not found");
    schemaParticle.RefNamespaceId = ns.Id;
    schemaParticle.MinOccurs = GetOccurs(xmlSchemaGroupRef.MinOccurs, xmlSchemaGroupRef.MinOccursString);
    schemaParticle.MaxOccurs = GetOccurs(xmlSchemaGroupRef.MaxOccurs, xmlSchemaGroupRef.MaxOccursString);
    if (dbContext.SaveChanges() > 0)
      Console.WriteLine($"  Changing GroupRef {schemaParticle.Id} settings");
  }

  internal void ParseXmlSchemaSequence(SchemaComplexType schemaComplexType, SchemaParticle? parentParticle, XmlSchemaSequence xmlSchemaSequence, int? ordNum)
  {
    var schemaGroup = (SchemaSequence?)dbContext.SchemaParticles.FirstOrDefault(item =>
      item.ComplexTypeId == schemaComplexType.Id && item.OrdNum == ordNum && item.ParticleType == ParticleType.Sequence);
    if (schemaGroup == null)
    {
      schemaGroup = new SchemaSequence
      {
        ComplexTypeId = schemaComplexType.Id,
        ParentParticleId = parentParticle?.Id,
        OrdNum = ordNum
      };
      dbContext.SchemaParticles.Add(schemaGroup);
      dbContext.SaveChanges();
      Console.WriteLine($"Adding Sequence particle {schemaGroup.Id}");
    }
    schemaGroup.MinOccurs = GetOccurs(xmlSchemaSequence.MinOccurs, xmlSchemaSequence.MinOccursString);
    schemaGroup.MaxOccurs = GetOccurs(xmlSchemaSequence.MaxOccurs, xmlSchemaSequence.MaxOccursString);
    if (dbContext.SaveChanges() > 0)
      Console.WriteLine($"  Changing Sequence particle {schemaGroup.Id} settings");
    int ordNum1 = 0;
    foreach (var item in xmlSchemaSequence.Items)
    {
      ordNum1++;
      if (item is XmlSchemaParticle xmlSchemaParticle) 
        ParseXmlSchemaParticle(schemaComplexType, schemaGroup, xmlSchemaParticle, ordNum1);
      else
      {
        throw new NotImplementedException($"Sequence item type {item.GetType()} not supported");
      }
    }
  }

  internal void ParseXmlSchemaChoice(SchemaComplexType schemaComplexType, SchemaParticle? parentParticle, XmlSchemaChoice xmlSchemaChoice, int? ordNum)
  {
    var schemaGroup = (SchemaChoice?)dbContext.SchemaParticles.FirstOrDefault(item =>
      item.ComplexTypeId == schemaComplexType.Id && item.OrdNum == ordNum && item.ParticleType == ParticleType.Choice);
    if (schemaGroup == null)
    {
      schemaGroup = new SchemaChoice
      {
        ComplexTypeId = schemaComplexType.Id,
        ParentParticleId = parentParticle?.Id,
        OrdNum = ordNum
      };
      dbContext.SchemaParticles.Add(schemaGroup);
      dbContext.SaveChanges();
      Console.WriteLine($"Adding Choice particle {schemaGroup.Id}");
    }
    schemaGroup.MinOccurs = GetOccurs(xmlSchemaChoice.MinOccurs, xmlSchemaChoice.MinOccursString);
    schemaGroup.MaxOccurs = GetOccurs(xmlSchemaChoice.MaxOccurs, xmlSchemaChoice.MaxOccursString);
    if (dbContext.SaveChanges() > 0)
      Console.WriteLine($"  Changing Choice particle {schemaGroup.Id} settings");
    int ordNum1 = 0;
    foreach (var item in xmlSchemaChoice.Items)
    {
      ordNum1++;
      if (item is XmlSchemaParticle xmlSchemaParticle)
        ParseXmlSchemaParticle(schemaComplexType, schemaGroup, xmlSchemaParticle, ordNum1);
      else
      {
        throw new NotImplementedException($"Choice item type {item.GetType()} not supported");
      }
    }
  }

  internal void ParseXmlSchemaAll(SchemaComplexType schemaComplexType, SchemaParticle? parentParticle, XmlSchemaAll xmlSchemaAll, int? ordNum)
  {
    var schemaGroup = (SchemaAll?)dbContext.SchemaParticles.FirstOrDefault(item =>
      item.ComplexTypeId == schemaComplexType.Id && item.OrdNum == ordNum && item.ParticleType == ParticleType.All);
    if (schemaGroup == null)
    {
      schemaGroup = new SchemaAll
      {
        ComplexTypeId = schemaComplexType.Id,
        ParentParticleId = parentParticle?.Id,
        OrdNum = ordNum
      };
      dbContext.SchemaParticles.Add(schemaGroup);
      dbContext.SaveChanges();
      Console.WriteLine($"Adding All particle {schemaGroup.Id}");
    }
    schemaGroup.MinOccurs = GetOccurs(xmlSchemaAll.MinOccurs, xmlSchemaAll.MinOccursString);
    schemaGroup.MaxOccurs = GetOccurs(xmlSchemaAll.MaxOccurs, xmlSchemaAll.MaxOccursString);
    if (dbContext.SaveChanges() > 0)
      Console.WriteLine($"  Changing All particle {schemaGroup.Id} settings");
    int ordNum1 = 0;
    foreach (var item in xmlSchemaAll.Items)
    {
      ordNum1++;
      if (item is XmlSchemaParticle xmlSchemaParticle)
        ParseXmlSchemaParticle(schemaComplexType, schemaGroup, xmlSchemaParticle, ordNum1);
      else
      {
        throw new NotImplementedException($"All item type {item.GetType()} not supported");
      }
    }
  }

  internal void ParseXmlSchemaElement(SchemaComplexType schemaComplexType, SchemaParticle? parentParticle, XmlSchemaElement xmlSchemaElement, int? ordNum)
  {
    SchemaElement? schemaElement;
    if (xmlSchemaElement.Name != null)
    {
      schemaElement = dbContext.SchemaElements.FirstOrDefault(item =>
        item.ComplexTypeId == schemaComplexType.Id
        && item.ParticleType == ParticleType.Element && item.Name == xmlSchemaElement.Name);
      if (schemaElement == null)
      {
        Console.WriteLine($"Adding element {xmlSchemaElement.Name}");
        schemaElement = new SchemaElement
        {
          ComplexTypeId = schemaComplexType.Id,
          ParentParticleId = parentParticle?.Id,
          OrdNum = ordNum,
          Name = xmlSchemaElement.Name,
        };
        dbContext.SchemaElements.Add(schemaElement);
        dbContext.SaveChanges();
      }
    }
    else
    {
      var ns = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == xmlSchemaElement.RefName.Namespace);
      if (ns == null)
        throw new DataException($"Namespace {xmlSchemaElement.RefName.Namespace} not found");
      schemaElement = dbContext.SchemaElements.FirstOrDefault(item =>
        item.ComplexTypeId == schemaComplexType.Id && item.Name == xmlSchemaElement.RefName.Name && item.RefNamespaceId == ns.Id);
      if (schemaElement == null)
      {
        Console.WriteLine($"Adding element reference to {ns.Url} {xmlSchemaElement.RefName.Name}");
        schemaElement = new SchemaElement
        {
          ComplexTypeId = schemaComplexType.Id,
          ParentParticleId = parentParticle?.Id,
          OrdNum = ordNum,
          Name = xmlSchemaElement.RefName.Name,
          RefNamespaceId = ns.Id
        };
        dbContext.SchemaElements.Add(schemaElement);
        dbContext.SaveChanges();
      }
    }
    ParseXmlSchemaElementDetails(schemaElement, parentParticle, xmlSchemaElement, ordNum);
  }

  internal void ParseXmlSchemaElementDetails(SchemaElement schemaElement, SchemaParticle? parentParticle, XmlSchemaElement xmlSchemaElement, int? ordNum)
  {
    schemaElement.OrdNum = ordNum;
    schemaElement.ParentParticleId = parentParticle?.Id;
    if (!string.IsNullOrEmpty(xmlSchemaElement.SchemaTypeName.Namespace))
    {
      var ns = dbContext.SchemaNamespaces.FirstOrDefault(item => item.Url == xmlSchemaElement.SchemaTypeName.Namespace);
      if (ns == null)
        throw new DataException($"Namespace {xmlSchemaElement.SchemaTypeName.Namespace} not found");
      schemaElement.TypeNamespaceId = ns.Id;
    }
    schemaElement.TypeName = xmlSchemaElement.SchemaTypeName.Name;
    schemaElement.MinOccurs = GetOccurs(xmlSchemaElement.MinOccurs, xmlSchemaElement.MinOccursString);
    schemaElement.MaxOccurs = GetOccurs(xmlSchemaElement.MaxOccurs, xmlSchemaElement.MaxOccursString);
    if (dbContext.SaveChanges() > 0)
      Console.WriteLine($"  Changing element {schemaElement.Name} settings");
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
}
