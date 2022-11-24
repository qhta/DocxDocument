namespace ModelGen;

public static class ModelData
{

  #region Exclusion/translation

  public static SortedStrings ExcludedProperties { get; } = new SortedStrings
  {
    "FirstChild", "LastChild", "HasChildren", "InnerText", "InnerXml", "Features",
    "OpenXmlElementContext", "HasAttributes", "ExtendedAttributes", "ChildElements",
    "Parent", "NamespaceUri", "LocalName", "Prefix", "NamespaceDeclarations",
    "XmlQualifiedName", "XName", "OuterXml", "MCAttributes",
    "RootElement", "IsRootElementLoaded",
    "RelationshipErrorHandlerFactory",
    "AddError",
    "*Part",
    "HasValue",
  };

  public static bool IsExcluded(Type type)
  {
    if (ExcludedNamespaces.Contains(type.Namespace ?? ""))
      return true;
    if (IncludedTypes.Contains(type.Name))
      return false;
    if (ExcludedTypes.Contains(type.Name))
      return false;
    return false;
  }

  public static SortedStrings ExcludedNamespaces { get; } = new SortedStrings
  {
    "*Metadata", "*Features", "*Framework", "*Framework.Schema", "*Validation", "*Validation.Schema", "System*"
  };

  public static SortedStrings IncludedNamespaces { get; } = new SortedStrings
  {
    "DocumentFormat.OpenXml", /*"DocumentFormat.OpenXml.Packaging", */"DocumentFormat.OpenXml.Wordprocessing"
  };

  public static SortedStrings ExcludedTypes { get; } = new SortedStrings
  {
    "SR", "OpenXml*", "*Reader", "*Attribute", "*Attributes", "*Extensions", "*Helper", "*Provider", "*Methods", "FileFormatVersions",
    "XmlConvertingReader*", "*.Part",
  };

  public static SortedStrings IncludedTypes { get; } = new SortedStrings
  {
    "CustomXmlAttribute", "BooleanFalse", "Wordprocessing*",
  };

  public static SortedStrings ExcludedAttributes { get; } = new SortedStrings
  {
    "OfficeAvailability", "NullableContext", "SchemaAttr", "Nullable", "Serializable", "DebuggerDisplay", "DebuggerNonUserCode", "CLSCompliant"
  };

  public static Dictionary<Type, Type> AttributeConversionTable { get; } = new Dictionary<Type, Type>
  {
    { typeof(DocumentFormat.OpenXml.EnumStringAttribute), typeof(System.Xml.Serialization.XmlEnumAttribute) },
  };

  public static Dictionary<string, string> NamespaceRedirectionTable { get; } = new Dictionary<string, string>()
  {
    { "DocumentFormat.OpenXml", "DocumentModel" }
  };


  public static Dictionary<Type, Type> TypeConversionTable { get; } = new Dictionary<Type, Type>
  {
    { typeof(DocumentFormat.OpenXml.StringValue), typeof(System.String)},
    { typeof(DocumentFormat.OpenXml.BooleanValue), typeof(System.Boolean)},
    { typeof(DocumentFormat.OpenXml.OnOffValue), typeof(System.Boolean)},
    { typeof(DocumentFormat.OpenXml.Office2019.Drawing.Chart.BooleanFalse), typeof(System.Boolean) },
    { typeof(DocumentFormat.OpenXml.Office2010.ExcelAc.List), typeof(System.String) },
    { typeof(DocumentFormat.OpenXml.IntegerValue), typeof(System.Int32)},
    { typeof(DocumentFormat.OpenXml.Int32Value), typeof(System.Int32)},
    { typeof(DocumentFormat.OpenXml.UInt32Value), typeof(System.UInt32)},
    { typeof(DocumentFormat.OpenXml.Int16Value), typeof(System.Int16)},
    { typeof(DocumentFormat.OpenXml.UInt16Value), typeof(System.UInt16)},
    { typeof(DocumentFormat.OpenXml.Int64Value), typeof(System.Int64)},
    { typeof(DocumentFormat.OpenXml.UInt64Value), typeof(System.UInt16)},
    { typeof(DocumentFormat.OpenXml.ByteValue), typeof(System.Byte)},
    { typeof(DocumentFormat.OpenXml.SByteValue), typeof(System.SByte)},
    { typeof(DocumentFormat.OpenXml.SingleValue), typeof(System.Single)},
    { typeof(DocumentFormat.OpenXml.DoubleValue), typeof(System.Double)},
    { typeof(DocumentFormat.OpenXml.DecimalValue), typeof(System.Decimal)},
    { typeof(DocumentFormat.OpenXml.DateTimeValue), typeof(System.DateTime)},
    { typeof(DocumentFormat.OpenXml.EnumValue<>), typeof(System.Enum)},
    { typeof(DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType), typeof(DocumentModel.HexWord)}
  };

  public static Dictionary<Type, string> BuiltInTypeNames { get; } = new Dictionary<Type, string>
  {
    { typeof(System.Object), "object" },
    { typeof(System.String), "string" },
    { typeof(System.Boolean), "bool" },
    { typeof(System.Int32), "int"},
    { typeof(System.UInt32), "uint"},
    { typeof(System.Int16), "short" },
    { typeof(System.UInt16), "ushort" },
    { typeof(System.Int64), "long" },
    { typeof(System.UInt64), "ulong" },
    { typeof(System.Byte), "byte" },
    { typeof(System.SByte), "sbyte" },
    { typeof(System.Single), "float" },
    { typeof(System.Double), "double" },
    { typeof(System.Decimal), "decimal" },
  };
  #endregion  
}