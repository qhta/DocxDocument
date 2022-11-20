using System.CodeDom.Compiler;
//using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;
using DocumentFormat.OpenXml;
using Namotion.Reflection;

using DocumentFormat.OpenXml.Wordprocessing;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System.Text;

namespace ModelGen;

public class Generator
{
  public Generator(string projectName, string intfOutputPath, string implOutputPath)
  {
    IntfOutputPath = intfOutputPath;
    if (!Directory.Exists(IntfOutputPath))
      Directory.CreateDirectory(IntfOutputPath);
    var intfProjectName = projectName;
    GenProjectFile(intfProjectName, Path.Combine(IntfOutputPath, intfProjectName + ".csproj"));
    ImplOutputPath = implOutputPath;
    if (!Directory.Exists(ImplOutputPath))
      Directory.CreateDirectory(ImplOutputPath);
    var implProjectName = projectName + ".Impl";
    GenProjectFile(implProjectName, Path.Combine(implOutputPath, implProjectName + ".csproj"));
  }

  private Assembly SourceAssembly { get; set; } = null!;

  private string IntfOutputPath { get; set; }
  private string ImplOutputPath { get; set; }

  Dictionary<Type, TypeInfo> AcceptedTypes => TypeManager.KnownTypes;

  Dictionary<string, int> TypeNamesCount = new();

  SortedDictionary<string, List<Type>> SameNameTypes { get; } = new();

  SortedDictionary<string, TypeInfo> SortedTypes { get; } = new();

  SortedSet<string> GlobalUsings { get; } = new();


  String EmptyLine { get; } = new String(' ', Console.BufferWidth);

  public void RunOn(Assembly assembly)
  {
    SourceAssembly = assembly;
    Console.WriteLine("Scanning types");
    var totalTypesCount = 0;
    var acceptedTypesCount = 0;
    foreach (var type in assembly.GetTypes())
    {
      if (type.Namespace == "DocumentFormat.OpenXml")
      {
        Console.Write($"\r{EmptyLine}");
        Console.Write($"\r{type.FullName}");
        totalTypesCount++;
        if (CanGenerateType(type, out var typeInfo))
        {
          acceptedTypesCount++;
          typeInfo.IsAccepted = true;
          var typeName = typeInfo.Name;
          if (!TypeNamesCount.ContainsKey(typeName))
            TypeNamesCount.Add(typeName, 1);
          else
            TypeNamesCount[typeName] += 1;
        }
      }
    }
    Console.WriteLine();
    Console.WriteLine($"Found {totalTypesCount} types, {TypeManager.KnownTypes.Count} registered, {acceptedTypesCount} accepted");

    Console.WriteLine();
    Console.WriteLine($"Found {TypeManager.Namespaces.Count} namespaces:");
    ModelMonitorDisplay.ShowNamespaces();

    Console.WriteLine();
    Console.WriteLine("RenamingEnums");
    var renamedCount = RenameEnumTypes();
    Console.WriteLine($"Renamed {renamedCount} enum types");

    Console.WriteLine();
    ModelMonitorDisplay.ShowNamespaceDetails(ShowOptions.OriginalNames);

    //Console.WriteLine("Checking class types");
    //foreach (var type in AcceptedTypes.Keys)
    //{
    //  if (type.IsClass)
    //    CheckTypeUses(type);
    //}

    //Console.WriteLine("Removing unused types");
    //var UnusedTypes = new List<Type>();
    //foreach (var type in AcceptedTypes)
    //{
    //  if (type.Value.UsageCount == 0)
    //    UnusedTypes.Add(type.Key);
    //}

    //foreach (var type in UnusedTypes)
    //{
    //  AcceptedTypes.Remove(type);
    //}

    //Console.WriteLine("Checking duplicate type names");
    //foreach (var item in AcceptedTypes)
    //{
    //  var typeName = item.Value.Name;
    //  if (TypeNamesCount[typeName] > 1)
    //  {
    //    if (SameNameTypes.TryGetValue(typeName, out var types))
    //      types.Add(item.Key);
    //    else
    //      SameNameTypes.Add(typeName, new List<Type> { item.Key });
    //  }
    //}

    //Console.WriteLine("Sorting type names");
    //foreach (var item in AcceptedTypes)
    //{
    //  var type = item.Key;
    //  SortedTypes.Add(type.FullName ?? "", item.Value);

    //}

    //Console.WriteLine("Generating");
    //foreach (var item in SortedTypes)
    //{
    //  var type = item.Value;
    //  if (type.TypeKind == TypeKind.Class)
    //    GenClassType(type);
    //  else if (type.TypeKind == TypeKind.Enum)
    //    GenEnumType(type);
    //}

    //if (GlobalUsings.Count > 0)
    //{
    //  GenGlobalUsings(Path.Combine(IntfOutputPath, "GlobalUsings.cs"));
    //  GenGlobalUsings(Path.Combine(ImplOutputPath, "GlobalUsings.cs"));
    //}
  }

  private void GenProjectFile(string projectName, string filename)
  {
    AssurePathExists(filename);
    using (var writer = File.CreateText(filename))
    using (var reader = File.OpenText(projectName + ".csproj.xml"))
    {
      writer.Write(reader.ReadToEnd());
    }
  }

  #region Check types

  private bool CanGenerateType(Type type, [NotNullWhen(true)] out TypeInfo? typeInfo)
  {
    //if (type.Name == "BooleanFalse")
    //  Debug.Assert(true);
    typeInfo = null;
    var typeName = type.ToString();
    if (typeName.Contains('<') || typeName.Contains('+'))
      return false;
    if (IsExcluded(type))
      return false;
    typeInfo = TypeManager.RegisterType(type);
    typeInfo.Reflect();
    return true;
  }

  private void CheckTypeUsage(Type type)
  {
    //if (type.Name=="BooleanFalse")
    //  Debug.Assert(true);
    TypeInfo? typeInfo;
    if (AcceptedTypes.TryGetValue(type, out typeInfo))
      typeInfo.UsageCount += 1;
    else
    {
      var newType = TransformedType(type);
      if (newType != type)
      {
        if (AcceptedTypes.TryGetValue(type, out typeInfo))
          typeInfo.UsageCount += 1;
      }
    }
  }

  private void CheckTypeUses(Type type)
  {
    TypeInfo? typeData;
    foreach (var prop in type.GetProperties())
    {
      if (!ExcludedProperties.Contains(prop.Name) && !ExcludedTypes.Contains(prop.PropertyType.Namespace ?? ""))
      {
        if (AcceptedTypes.TryGetValue(type, out typeData))
          typeData.PropsCount += 1;
        if (prop.PropertyType == typeof(List))
        {
          Debug.Assert(true);
        }
        var propType = TransformedType(prop.PropertyType);
        if (AcceptedTypes.TryGetValue(propType, out typeData))
          typeData.UsageCount += 1;
        var argument = propType.GenericTypeArguments.FirstOrDefault();
        if (argument != null)
        {
          if (argument == typeof(MediumValues))
            Debug.Assert(true);
          CheckTypeUsage(argument);
        }
      }
    }
    CheckChildItemTypes(type);
  }

  private bool CheckChildItemTypes(Type type)
  {
    var documentation = type.GetXmlDocsElement();
    if (documentation != null)
    {
      var childItemTypes = DocumentationReader.GetChildItemTypes(documentation, this.SourceAssembly);
      if (childItemTypes != null)
      {
        foreach (var childItemType in childItemTypes)
        {
          CheckTypeUsage(childItemType);
        }
      }
      return true;
    }
    return false;
  }
  #endregion

  #region Class type generation

  private void GenClassType(TypeInfo type)
  {
    var typeName = type.Name;
    var aNamespace = type.Namespace;
    var intfOutputPath = Path.Combine(IntfOutputPath, aNamespace);
    GenClassOrInterface(type, typeName, Path.Combine(intfOutputPath, "Interfaces", "I" + typeName + ".cs"), true);
    var implOutputPath = Path.Combine(ImplOutputPath, aNamespace);
    GenClassOrInterface(type, typeName, Path.Combine(implOutputPath, typeName + ".cs"), false);
  }

  private void GenClassOrInterface(TypeInfo type, string typeName, string filename, bool toInterface)
  {
    AssurePathExists(filename);
    using (var textWriter = File.CreateText(filename))
    using (var writer = new IndentedTextWriter(textWriter, "  "))
    {
      GenClassOrInterface(type, typeName, writer, toInterface);
    }
  }

  private void GenClassOrInterface(TypeInfo type, string typeName, IndentedTextWriter writer, bool toInterface)
  {
    Console.Write($"\r{new string(' ', Console.BufferWidth)}");
    Console.Write($"\r{type.FullName}");

    var aNamespace = type.Namespace;
    if (aNamespace != null)
    {
      aNamespace = NewNamespace(aNamespace);
      writer.WriteLine($"namespace {aNamespace};");
      writer.WriteLine();
    }

    GenDocumentationComments(type, writer);
    GenCustomAttributes(type.CustomAttributes, writer);
    if (toInterface)
      writer.WriteLine($"public interface I{typeName} // : {type.BaseTypeInfo?.FullName}");
    else
      writer.WriteLine($"public class {typeName}: I{typeName}");
    writer.WriteLine("{");
    writer.Indent++;
    if (type.Properties != null)
      foreach (var prop in type.Properties)
        if (!ExcludedProperties.Contains(prop.Name) && !ExcludedTypes.Contains(prop.PropertyTypeInfo.Namespace ?? ""))
          GenProperty(prop, writer, toInterface);
    writer.Indent--;
    writer.WriteLine("}");
  }

  private void GenProperty(PropInfo prop, IndentedTextWriter writer, bool toInterface)
  {
    //if (prop.Name == "Val")
    //  Debug.Assert(true);
    var propType = TransformedType(prop.PropertyType);
    var propertyTypeName = NewPropTypeName(propType, toInterface);
    var aNamespace = propType.Namespace ?? "";
    if (AcceptedTypes.TryGetValue(propType, out var typeInfo))
    {
      if (SameNameTypes.ContainsKey(typeInfo.Name))
        propertyTypeName = NewNamespace(propType.Namespace ?? "") + "." + propertyTypeName;
    }
    GenDocumentationComments(prop, writer);
    GenCustomAttributes(prop.CustomAttributes, writer);
    if (toInterface)
      writer.WriteLine($"public {propertyTypeName}? {prop.Name} {{ get ; set; }}");
    else
    {
      writer.WriteLine($"public {propertyTypeName}? {prop.Name}");
      writer.WriteLine($"{{");
      writer.WriteLine($"  get;");
      writer.WriteLine($"  set;");
      writer.WriteLine($"}}");
    }
    writer.WriteLine();
    AddGlobalUsing(aNamespace ?? "");
  }
  #endregion

  #region Enum types generation
  private void GenEnumType(TypeInfo type)
  {
    var outputPath = IntfOutputPath;
    if (type.Namespace != null)
      outputPath = Path.Combine(outputPath, type.Namespace);
    var typeName = type.Name;
    var fileName = ValidateFilename(typeName);
    GenEnumType(type, typeName, Path.Combine(outputPath, "Enums", fileName + ".cs"));
  }

  private void GenEnumType(TypeInfo type, string typeName, string filename)
  {
    AssurePathExists(filename);
    using (var textWriter = File.CreateText(filename))
    using (var writer = new IndentedTextWriter(textWriter, "  "))
    {
      GenEnumType(type, typeName, writer);
    }
  }

  private void GenEnumType(TypeInfo type, string typeName, IndentedTextWriter writer)
  {
    Console.Write($"\r{new string(' ', Console.BufferWidth)}");
    Console.Write($"\r{type.FullName}");
    var aNamespace = type.Namespace;
    if (aNamespace != null)
    {
      aNamespace = NewNamespace(aNamespace);
      writer.WriteLine($"namespace {aNamespace};");
      writer.WriteLine();
    }
    GenDocumentationComments(type, writer);
    GenCustomAttributes(type.CustomAttributes, writer);
    writer.WriteLine($"public enum {typeName}");
    writer.WriteLine("{");
    writer.Indent++;
    if (type.EnumValues != null)
      foreach (var field in type.EnumValues)
        GenEnum(field, writer);
    writer.Indent--;
    writer.WriteLine("}");
  }

  private void GenEnum(EnumInfo field, IndentedTextWriter writer)
  {
    bool addEmptyLine = GenDocumentationComments(field, writer);
    if (field.CustomAttributes != null)
    {
      GenCustomAttributes(field.CustomAttributes, writer);
      addEmptyLine = true;
    }
    writer.WriteLine($"{field.Name},");
    if (addEmptyLine)
      writer.WriteLine();
  }
  #endregion

  #region CustomAttributes generation

  private bool GenCustomAttributes(IEnumerable<CustomAttribData>? attributes, IndentedTextWriter writer)
  {
    if (attributes?.Any() == true)
    {
      foreach (var customAttrib in attributes)
        GenCustomAttribute(customAttrib, writer);
      AddGlobalUsing("DocumentModel.Attributes");
      return true;
    }
    return false;
  }


  private void GenCustomAttribute(CustomAttribData attrData, IndentedTextWriter writer)
  {
    var attributeType = attrData.AttributeType;
    if (AttributeConversionTable.TryGetValue(attributeType, out var altAttrType))
      attributeType = altAttrType;
    var attrTypeName = attributeType.Name;
    if (attrTypeName.EndsWith("Attribute"))
      attrTypeName = attrTypeName.Substring(0, attrTypeName.Length - "Attribute".Length);
    if (ExcludedAttributes.Contains(attrTypeName))
      return;
    var attrString = attrTypeName;
    if (attrData.ConstructorArguments?.Count + attrData.NamedArguments?.Count > 0)
    {
      var strList = new List<string>();
      if (attrData.ConstructorArguments != null)
        foreach (var arg in attrData.ConstructorArguments)
          strList.Add(TypedValueLiteral(arg.ArgumentType, arg.Value));
      if (attrData.NamedArguments != null)
        foreach (var arg in attrData.NamedArguments)
          strList.Add($"{arg.MemberName?.ToString() ?? String.Empty} =  {TypedValueLiteral(arg.TypedValue.ArgumentType, arg.TypedValue.Value)}");
      attrString += "(" + String.Join(", ", strList) + ")";
    }
    writer.WriteLine($"[{attrString}]");
    AddGlobalUsing(attributeType.Namespace ?? "");
  }
  #endregion

  #region Documentation comments generation

  private bool GenDocumentationComments(TypeInfo type, IndentedTextWriter writer)
  {
    var documentation = type.Type.GetXmlDocsElement();
    if (documentation != null)
    {
      var summary = DocumentationReader.GetSummaryFirstPara(documentation);
      if (summary != null)
      {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// {summary}");
        writer.WriteLine("/// </summary>");
      }
      var childItemTypes = DocumentationReader.GetChildItemTypes(documentation, this.SourceAssembly);
      if (childItemTypes != null)
      {
        foreach (var childItemType in childItemTypes)
        {
          if (type.CustomAttributes == null)
          {
            var childItemTypeInfo = TypeManager.RegisterType(childItemType, this, Semantics.Include);
            var myCustomAttribute = new CustomAttribData(typeof(DocumentModel.Attributes.ChildElementInfoAttribute));
            myCustomAttribute.ConstructorArguments.Add(new CustomAttribTypedArgument(childItemTypeInfo));
            GenCustomAttribute(myCustomAttribute, writer);
          }
        }
      }
      return true;
    }
    return false;
  }

  private bool GenDocumentationComments(EnumInfo aField, IndentedTextWriter writer)
  {
    var summary = aField.Summary;
    if (summary != null)
    {
      writer.WriteLine("/// <summary>");
      writer.WriteLine($"/// {summary}");
      writer.WriteLine("/// </summary>");
      return true;
    }
    return false;
  }

  private bool GenDocumentationComments(PropInfo aProp, IndentedTextWriter writer)
  {
    var summary = aProp.Summary;
    if (summary != null)
    {
      writer.WriteLine("/// <summary>");
      writer.WriteLine($"/// {summary}");
      writer.WriteLine("/// </summary>");
      return true;
    }
    return false;
  }
  #endregion

  #region Global usings generation
  private void AddGlobalUsing(string aNamespace)
  {
    aNamespace = NewNamespace(aNamespace);
    if (aNamespace == "System.IO.Packaging")
      return;
    if (aNamespace != String.Empty)
      if (!GlobalUsings.Contains(aNamespace))
        GlobalUsings.Add(aNamespace);

  }

  private void GenGlobalUsings(string filename)
  {
    AssurePathExists(filename);
    using (var writer = File.CreateText(filename))
    {
      foreach (var item in GlobalUsings)
        writer.WriteLine($"global using {item};");
    }
  }
  #endregion

  #region Literals generation
  private string TypedValueLiteral(Type type, object? value)
  {
    if (type == typeof(string))
    {
      if (value is string str)
        return $"\"{str}\"";
      return "\"\"";
    }
    else if (value is Type aType)
    {
      var aTypeName = "I" + aType.Name;
      var aNamespace = NewNamespace(aType.Namespace ?? "");
      return ($"typeof({aNamespace}.{aTypeName})");

    }
    else if (value is bool bv)
      return bv.ToString().ToLower();
    else if (value != null)
    {
      if (type.IsEnum)
      {
        var enumName = Enum.GetName(type, value);
        enumName = type.Name + "." + enumName;
        return enumName;
      }
      else
      {
        return value.ToString() ?? "";
      }
    }
    return "";
  }
  #endregion

  #region Name/Type translation

  private string NewNamespace(string aNamespace)
  {
    return aNamespace.Replace("DocumentFormat.OpenXml", "DocumentModel");
  }

  private Type TransformedType(Type type)
  {
    if (TypeConversionTable.TryGetValue(type, out var targetType))
      return targetType;
    var typeName = type.Name;
    if (typeName == "EnumValue`1")
    {
      var genericArgument = type.GetGenericArguments().FirstOrDefault();
      if (genericArgument != null)
      {
        return TransformedType(genericArgument);
      }
    }
    else if (typeName == "Nullable`1")
    {
      var genericArgument = type.GetGenericArguments().FirstOrDefault();
      if (genericArgument != null)
      {
        return TransformedType(genericArgument);
      }
    }
    else if (typeName == "ListValue`1")
    {
      var genericArgument = type.GetGenericArguments().FirstOrDefault();
      if (genericArgument != null)
      {
        type = TransformedType(genericArgument);
        type = typeof(List<>).MakeGenericType(type);
        AddGlobalUsing("System.Collections.Generic");
      }
    }
    return type;
  }


  private string NewTypeName(Type type)
  {
    if (type.IsEnum)
      return NewEnumTypeName(type);
    return type.Name;
  }

  private int RenameEnumTypes()
  {
    int changeCount = 0;
    foreach (var nspace in TypeManager.Namespaces)
    {
      var nspaceTypes = TypeManager.KnownTypes.Where(item => item.Value.Namespace == nspace).Select(item => item.Value).ToList();
      foreach (var typeInfo in nspaceTypes.Where(item => item.TypeKind == TypeKind.Enum))
      {
        var newName = NewEnumTypeName(typeInfo.Type);
        if (!nspaceTypes.Any(item => item != typeInfo && item.Name == newName))
        {
          typeInfo.Name = newName;
          changeCount++;
        }
      }
    }
    return changeCount;
  }

  private string NewEnumTypeName(Type type)
  {
    var typeName = type.Name;
    if (typeName.EndsWith("Values"))
    {
      typeName = typeName.Substring(0, typeName.Length - "Values".Length);
      if (!typeName.EndsWith("Type") && !typeName.EndsWith("Mode"))
      {
        typeName = typeName + "Type";
      }
    }
    return typeName;
  }

  private string NewPropTypeName(Type propType, bool inInterface)
  {
    var propTypeName = propType.Name;
    if (propType.IsEnum)
      return NewEnumTypeName(propType);
    else
    if (propTypeName == "IEnumerable`1")
    {
      var genericArgument = propType.GetGenericArguments().FirstOrDefault();
      if (genericArgument != null)
      {
        var newInfo = TransformedType(genericArgument);
        propTypeName = $"IEnumerable<{NewPropTypeName(propType, inInterface)}>";
        AddGlobalUsing("System.Collections.Generic");
      }
    }
    //else if (propTypeName == "ListValue`1")
    //{
    //  var genericArgument = propType.GetGenericArguments().FirstOrDefault();
    //  if (genericArgument != null)
    //  {
    //    propType = TransformedType(genericArgument);
    //    propTypeName = $"List<{NewPropTypeName(propType, inInterface)}>";
    //    AddGlobalUsing("System.Collections.Generic");
    //  }
    //}
    else if (propTypeName == "List`1")
    {
      var genericArgument = propType.GetGenericArguments().FirstOrDefault();
      if (genericArgument != null)
      {
        propType = TransformedType(genericArgument);
        propTypeName = $"List<{NewPropTypeName(propType, inInterface)}>";
        AddGlobalUsing("System.Collections.Generic");
      }
    }
    else if (propTypeName == "IList`1")
    {
      var genericArgument = propType.GetGenericArguments().FirstOrDefault();
      if (genericArgument != null)
      {
        propType = TransformedType(genericArgument);
        propTypeName = $"IList<{NewPropTypeName(propType, inInterface)}>";
        AddGlobalUsing("System.Collections.Generic");
      }
    }
    else if (propTypeName == "ReadOnlyCollection`1")
    {
      var genericArgument = propType.GetGenericArguments().FirstOrDefault();
      if (genericArgument != null)
      {
        propType = TransformedType(genericArgument);
        propTypeName = $"ICollection<{NewPropTypeName(propType, inInterface)}>";
        AddGlobalUsing("System.Collections.Generic");
      }
    }
    else if (propTypeName == "ReadOnlyArray`1")
    {
      var genericArgument = propType.GetGenericArguments().FirstOrDefault();
      if (genericArgument != null)
      {
        propType = TransformedType(genericArgument);
        propTypeName = $"{NewPropTypeName(propType, inInterface)}[]";
        AddGlobalUsing("System.Collections.Generic");
      }
    }
    else if (BuiltInTypeNames.TryGetValue(propType, out var builtInName))
      propTypeName = builtInName;
    else
    if ((propType.Namespace ?? "").StartsWith("DocumentFormat"))
      propTypeName = "I" + propTypeName;
    return propTypeName;
  }
  #endregion

  #region Filename/Path methods
  private string ValidateFilename(string filename)
  {
    foreach (var ch in Path.GetInvalidFileNameChars())
      filename = filename.Replace(new string(ch, 1), "");
    return filename;
  }

  private void AssurePathExists(string filename)
  {
    var filePath = Path.GetDirectoryName(filename);
    if (filePath != null)
      if (!Directory.Exists(filePath))
        Directory.CreateDirectory(filePath);
  }
  #endregion

  #region Exclusion/translation

  private SortedStrings ExcludedProperties { get; } = new SortedStrings
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

  private bool IsExcluded(Type type)
  {
    if (ExcludedNamespaces.Contains(type.Namespace ?? ""))
      return true;
    if (IncludedTypes.Contains(type.Name))
      return false;
    if (ExcludedTypes.Contains(type.Name))
      return false;
    return false;
  }

  private SortedStrings ExcludedNamespaces { get; } = new SortedStrings
  {
    "*Metadata", "*Features", "*Framework", "*Framework.Schema", "*Validation", "*Validation.Schema", "*Packaging"
  };

  private SortedStrings ExcludedTypes { get; } = new SortedStrings
  {
    "SR", "*Reader", "*Attribute", "*Attributes", "*Extensions","*Helper", "*Provider", "*Methods", "FileFormatVersions",
  };

  private SortedStrings IncludedTypes { get; } = new SortedStrings
  {
    "CustomXmlAttribute", "BooleanFalse"
  };

  private SortedStrings ExcludedAttributes { get; } = new SortedStrings
  {
    "OfficeAvailability", "NullableContext", "SchemaAttr", "Nullable", "Serializable", "DebuggerDisplay", "DebuggerNonUserCode", "CLSCompliant"
  };

  private Dictionary<Type, Type> AttributeConversionTable { get; } = new Dictionary<Type, Type>
  {
    { typeof(DocumentFormat.OpenXml.EnumStringAttribute), typeof(System.Xml.Serialization.XmlEnumAttribute) },
  };


  private Dictionary<Type, Type> TypeConversionTable { get; } = new Dictionary<Type, Type>
  {
    { typeof(String), typeof(string)},
    { typeof(DocumentFormat.OpenXml.StringValue), typeof(string)},
    { typeof(Boolean), typeof(bool)},
    { typeof(DocumentFormat.OpenXml.BooleanValue), typeof(bool)},
    { typeof(DocumentFormat.OpenXml.OnOffValue), typeof(bool)},
    { typeof(DocumentFormat.OpenXml.Office2019.Drawing.Chart.BooleanFalse), typeof(bool) },
    { typeof(DocumentFormat.OpenXml.Office2010.ExcelAc.List), typeof(string) },
    { typeof(DocumentFormat.OpenXml.IntegerValue), typeof(int)},
    { typeof(DocumentFormat.OpenXml.Int32Value), typeof(int)},
    { typeof(DocumentFormat.OpenXml.UInt32Value), typeof(uint)},
    { typeof(DocumentFormat.OpenXml.Int16Value), typeof(short)},
    { typeof(DocumentFormat.OpenXml.UInt16Value), typeof(ushort)},
    { typeof(DocumentFormat.OpenXml.Int64Value), typeof(long)},
    { typeof(DocumentFormat.OpenXml.UInt64Value), typeof(ulong)},
    { typeof(DocumentFormat.OpenXml.ByteValue), typeof(byte)},
    { typeof(DocumentFormat.OpenXml.SByteValue), typeof(sbyte)},
    { typeof(DocumentFormat.OpenXml.SingleValue), typeof(float)},
    { typeof(DocumentFormat.OpenXml.DoubleValue), typeof(double)},
    { typeof(DocumentFormat.OpenXml.DecimalValue), typeof(decimal)},
    { typeof(DocumentFormat.OpenXml.DateTimeValue), typeof(System.DateTime)},
    { typeof(Uri), typeof(System.Uri)},
    { typeof(DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType), typeof(DocumentModel.HexWord)}
  };

  private Dictionary<Type, string> BuiltInTypeNames { get; } = new Dictionary<Type, string>
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