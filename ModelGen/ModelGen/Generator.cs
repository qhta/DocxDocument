using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;

using DocumentFormat.OpenXml.Wordprocessing;

namespace ModelGen;

public class Generator
{
  public Generator(string projectName, string outputPath)
  {
    OutputPath = outputPath;
    if (!Directory.Exists(OutputPath))
      Directory.CreateDirectory(OutputPath);
    GenProjectFile(projectName + ".csproj");
  }

  class TypeData
  {
    public int UsageCount;
    public int PropsCount;
  }

  public string OutputPath { get; private set; }

  Dictionary<Type, TypeData> AcceptedTypes { get; } = new();

  List<Type> DuplicatedTypes { get; } = new();

  SortedSet<string> GlobalUsings { get; } = new ();



  public void GenLibrary(Assembly assembly)
  {
    Dictionary<string, int> TypeNamesCount = new();
    foreach (var type in assembly.GetTypes())
    {
      if (!TypeConversionTable.ContainsKey(type) && !type.IsGenericType)
      {
        if (CanGenerateType(type))
        {
          AcceptedTypes.Add(type, new TypeData());
          if (!TypeNamesCount.ContainsKey(type.Name))
            TypeNamesCount.Add(type.Name, 1);
          else
            TypeNamesCount[type.Name] += 1;
        }
      }
    }

    foreach (var type in AcceptedTypes.Keys)
    {
      if (type.IsClass)
        CheckClassType(type);
    }

    var UnusedTypes = new List<Type>();
    foreach (var type in AcceptedTypes)
    {
      if (type.Value.UsageCount==0)
        UnusedTypes.Add(type.Key);
    }

    foreach (var type in UnusedTypes)
    {
      AcceptedTypes.Remove(type);
    }

    foreach (var type in AcceptedTypes.Keys)
      if (TypeNamesCount[type.Name] > 1)
        DuplicatedTypes.Add(type);

    DuplicatedTypes.Sort((item1, item2) => item1.Name.CompareTo(item2.Name));

    foreach (var type in AcceptedTypes.Keys)
    {
      if (type.IsClass)
        GenClassType(type);
      else if (type.IsEnum)
        GenEnumType(type);
    }

    if (GlobalUsings.Count > 0)
      GenGlobalUsings(Path.Combine(OutputPath, "GlobalUsings.cs"));
  }

  public void GenProjectFile(string filename)
  {
    var filePath = Path.Combine(OutputPath, filename);
    AssurePathExists(filePath);
    using (var writer = File.CreateText(filePath))
    using (var reader = File.OpenText("Csproj.xml"))
    {
      writer.Write(reader.ReadToEnd());
    }
  }

  public bool CanGenerateType(Type type)
  {
    var typeName = type.ToString();
    if (typeName.Contains('<') || typeName.Contains('+'))
      return false;
    if (ExcludedTypes.Contains(typeName))
      return false;
    if (ExcludedNamespaces.Contains(type.Namespace ?? ""))
      return false;
    return true;
  }

  public void CheckClassType(Type type)
  {
    foreach (var prop in type.GetProperties())
    {
      if (!ExcludedProperties.Contains(prop.Name) && !ExcludedTypes.Contains(prop.PropertyType.Namespace ?? ""))
      {
        if (AcceptedTypes.TryGetValue(type, out var typeData))
          typeData.PropsCount += 1;
        var propType = NewPropType(prop.PropertyType);
        if (AcceptedTypes.TryGetValue(propType, out typeData))
          typeData.UsageCount += 1;
      }
    }
  }

  public void GenClassType(Type type)
  {
    var typeName = type.Name;
    var outputPath = OutputPath;
    var aNamespace = NewNamespace(type.Namespace ?? "");
    outputPath = Path.Combine(outputPath, aNamespace);
    GenClassOrInterface(type, typeName, Path.Combine(outputPath, "Interfaces", "I" + typeName + ".cs"), true);
    //GenClassOrInterface(type, typeName, Path.Combine(outputPath, "Classes", typeName + ".cs"), false);
  }

  public void GenClassOrInterface(Type type, string typeName, string filename, bool toInterface)
  {
    AssurePathExists(filename);
    using (var textWriter = File.CreateText(filename))
    using (var writer = new IndentedTextWriter(textWriter,"  "))
    {
      GenClassOrInterface(type, typeName, writer, toInterface);
    }
  }

  public void GenClassOrInterface(Type type, string typeName, IndentedTextWriter writer, bool toInterface)
  {
    var aNamespace = type.Namespace;
    if (aNamespace != null)
    {
      aNamespace = NewNamespace(aNamespace);
      writer.WriteLine($"namespace {aNamespace};");
      writer.WriteLine();
    }
    GenCustomAttributes(type.CustomAttributes, writer);
    if (toInterface)
      writer.WriteLine($"public interface I{typeName} // : {type.BaseType?.FullName}");
    else
      writer.WriteLine($"public class {typeName}: I{typeName}");
    writer.WriteLine("{");
    writer.Indent++;
    foreach (var prop in type.GetProperties())
      if (!ExcludedProperties.Contains(prop.Name) && !ExcludedTypes.Contains(prop.PropertyType.Namespace ?? ""))
        GenProperty(prop, writer, toInterface);
    writer.Indent--;
    writer.WriteLine("}");
  }

  public void GenProperty(PropertyInfo prop, IndentedTextWriter writer, bool toInterface)
  {
    if (prop.Name == "TargetSite")
      Debug.Assert(true);
    var propType = NewPropType(prop.PropertyType);
    var aNamespace = propType.Namespace ?? "";
    var propertyTypeName = NewPropTypeName(propType, toInterface);
    aNamespace = propType.Namespace ?? "";
    if (DuplicatedTypes.Contains(propType))
      propertyTypeName = NewNamespace(propType.Namespace ?? "") + "." + propertyTypeName;
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

  public void GenEnumType(Type type)
  {
    var outputPath = OutputPath;
    if (type.Namespace != null)
      outputPath = Path.Combine(outputPath, NewNamespace(type.Namespace));
    var typeName = NewEnumTypeName(type.Name);
    var fileName = ValidateFilename(typeName);
    GenEnumType(type, typeName, Path.Combine(outputPath, "Enums", fileName + ".cs"));
  }

  public void GenEnumType(Type type, string typeName, string filename)
  {
    AssurePathExists(filename);
    using (var textWriter = File.CreateText(filename))
    using (var writer = new IndentedTextWriter(textWriter, "  "))
    {
      GenEnumType(type, typeName, writer);
    }
  }

  public void GenEnumType(Type type, string typeName, IndentedTextWriter writer)
  {
    var aNamespace = type.Namespace;
    if (aNamespace != null)
    {
      aNamespace = NewNamespace(aNamespace);
      writer.WriteLine($"namespace {aNamespace};");
      writer.WriteLine();
    }
    GenCustomAttributes(type.CustomAttributes, writer);
    writer.WriteLine($"public enum {typeName}");
    writer.WriteLine("{");
    writer.Indent++;
    foreach (var field in type.GetFields(BindingFlags.Static | BindingFlags.Public))
      GenEnum(field, writer);
    writer.Indent--;
    writer.WriteLine("}");
  }

  public void GenEnum(FieldInfo field, IndentedTextWriter writer)
  {
    if (field.CustomAttributes.Any())
    {
      writer.WriteLine();
      GenCustomAttributes(field.CustomAttributes, writer);
    }
    writer.WriteLine($"{field.Name},");
  }

  public void GenCustomAttributes(IEnumerable<CustomAttributeData> attributes, IndentedTextWriter writer)
  {
    foreach (var customAttrib in attributes)
      GenCustomAttribute(customAttrib, writer);
    AddGlobalUsing("DocumentModel.Attributes");
  }

  public void GenCustomAttribute(CustomAttributeData attrData, IndentedTextWriter writer)
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
    if (attrData.ConstructorArguments.Count + attrData.NamedArguments.Count > 0)
    {
      var strList = new List<string>();
      foreach (CustomAttributeTypedArgument arg in attrData.ConstructorArguments)
        strList.Add(TypedValueStr(arg.ArgumentType, arg.Value));
      foreach (CustomAttributeNamedArgument arg in attrData.NamedArguments)
        strList.Add($"{arg.MemberName?.ToString() ?? String.Empty} =  {TypedValueStr(arg.TypedValue.ArgumentType, arg.TypedValue.Value)}");
      attrString += "(" + String.Join(", ", strList) + ")";
    }
    writer.WriteLine($"[{attrString}]");
    AddGlobalUsing(attributeType.Namespace ?? "");
  }

  public void AddGlobalUsing(string aNamespace)
  {
    aNamespace = NewNamespace(aNamespace);
    if (aNamespace == "System.IO.Packaging")
      return;
    if (aNamespace != String.Empty)
      if (!GlobalUsings.Contains(aNamespace))
        GlobalUsings.Add(aNamespace);

  }

  public void GenGlobalUsings(string filename)
  {
    AssurePathExists(filename);
    using (var writer = File.CreateText(filename))
    {
      foreach (var item in GlobalUsings)
        writer.WriteLine($"global using {item};");
    }
  }

  public string TypedValueStr(Type type, object? value)
  {
    if (type == typeof(string))
    {
      if (value is string str)
        return $"\"{str}\"";
      return "\"\"";
    }
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


  public string NewNamespace(string aNamespace)
  {
    return aNamespace.Replace("DocumentFormat.OpenXml", "DocumentModel");
  }

  public string NewEnumTypeName(string typeName)
  {
    if (typeName.EndsWith("Values"))
    {
      typeName = typeName.Substring(0, typeName.Length - "Values".Length);
    }
    return typeName;
  }

  public Type NewPropType(Type propType)
  {
    if (TypeConversionTable.TryGetValue(propType, out var targetType))
      return targetType;
    var propTypeName = propType.Name;
    if (propTypeName == "EnumValue`1")
    {
      var genericArgument = propType.GetGenericArguments().FirstOrDefault();
      if (genericArgument != null)
      {
        propType = NewPropType(genericArgument);
      }
    }
    else if (propTypeName == "Nullable`1")
    {
      var genericArgument = propType.GetGenericArguments().FirstOrDefault();
      if (genericArgument != null)
      {
        propType = NewPropType(genericArgument);
      }
    }
    return propType;
  }

  public string NewPropTypeName(Type propType, bool inInterface)
  {
    var propTypeName = propType.Name;
    if (propType.IsEnum)
      return NewEnumTypeName(propTypeName);
    else if (propTypeName == "IEnumerable`1")
    {
      var genericArgument = propType.GetGenericArguments().FirstOrDefault();
      if (genericArgument != null)
      {
        propType = NewPropType(genericArgument);
        propTypeName = $"IEnumerable<{NewPropTypeName(propType, inInterface)}>";
        AddGlobalUsing("System.Collections.Generic");
      }
    }
    else if (propTypeName == "ListValue`1")
    {
      var genericArgument = propType.GetGenericArguments().FirstOrDefault();
      if (genericArgument != null)
      {
        propType = NewPropType(genericArgument);
        propTypeName = $"List<{NewPropTypeName(propType, inInterface)}>";
        AddGlobalUsing("System.Collections.Generic");
      }
    }
    else if (propTypeName == "List`1")
    {
      var genericArgument = propType.GetGenericArguments().FirstOrDefault();
      if (genericArgument != null)
      {
        propType = NewPropType(genericArgument);
        propTypeName = $"List<{NewPropTypeName(propType, inInterface)}>";
        AddGlobalUsing("System.Collections.Generic");
      }
    }
    else if (propTypeName == "IList`1")
    {
      var genericArgument = propType.GetGenericArguments().FirstOrDefault();
      if (genericArgument != null)
      {
        propType = NewPropType(genericArgument);
        propTypeName = $"IList<{NewPropTypeName(propType, inInterface)}>";
        AddGlobalUsing("System.Collections.Generic");
      }
    }
    else if (propTypeName == "ReadOnlyCollection`1")
    {
      var genericArgument = propType.GetGenericArguments().FirstOrDefault();
      if (genericArgument != null)
      {
        propType = NewPropType(genericArgument);
        propTypeName = $"ICollection<{NewPropTypeName(propType, inInterface)}>";
        AddGlobalUsing("System.Collections.Generic");
      }
    }
    else if (propTypeName == "ReadOnlyArray`1")
    {
      var genericArgument = propType.GetGenericArguments().FirstOrDefault();
      if (genericArgument != null)
      {
        propType = NewPropType(genericArgument);
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

  public string ValidateFilename(string filename)
  {
    foreach (var ch in Path.GetInvalidFileNameChars())
      filename = filename.Replace(new string(ch, 1), "");
    return filename;
  }

  public void AssurePathExists(string filename)
  {
    var filePath = Path.GetDirectoryName(filename);
    if (filePath != null)
      if (!Directory.Exists(filePath))
        Directory.CreateDirectory(filePath);
  }

  public SortedStrings ExcludedProperties { get; } = new SortedStrings
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

  public SortedStrings ExcludedNamespaces { get; } = new SortedStrings
  {
    "*Metadata", "*Features", "*Framework", "*Framework.Schema", "*Validation", "*Validation.Schema", "*Packaging"
  };

  public SortedStrings ExcludedTypes { get; } = new SortedStrings
  {
    "SR", "*Reader", "*Attribute", "*Attributes", "*Extensions","*Helper", "*Provider", "*Methods", "FileFormatVersions",
  };

  public SortedStrings ExcludedAttributes { get; } = new SortedStrings
  {
    "OfficeAvailability", "NullableContext", "SchemaAttr", "Nullable", "DebuggerDisplay"
  };

  public Dictionary<Type, Type> AttributeConversionTable { get; } = new Dictionary<Type, Type>
  {
    { typeof(DocumentFormat.OpenXml.EnumStringAttribute), typeof(System.Xml.Serialization.XmlEnumAttribute) },
  };


  public Dictionary<Type, Type> TypeConversionTable { get; } = new Dictionary<Type, Type>
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

  public Dictionary<Type, string> BuiltInTypeNames { get; } = new Dictionary<Type, string>
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

}