using System.Diagnostics;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text.Json.Serialization;

using DocumentFormat.OpenXml;

using Namotion.Reflection;

using Qhta.Collections;
using DocumentFormat.OpenXml.Spreadsheet;
using System.CodeDom.Compiler;

namespace ModelGen;

public static class ModelGenerator
{

  public static void ClearProjectFolder(string projectPath)
  {
    var subfolders = Directory.GetDirectories(projectPath);
    foreach (var subfolder in subfolders)
      Directory.Delete(subfolder, true);
  }

  public static void GenProjectFile(string projectName, string filename)
  {
    AssurePathExists(filename);
    using (var writer = File.CreateText(filename))
    using (var reader = File.OpenText(projectName + ".csproj.xml"))
    {
      writer.Write(reader.ReadToEnd());
    }
  }

  public static void GenerateTypeFile(TypeInfo typeInfo, string IntfOutputPath, string ImplOutputPath)
  {
    if (typeInfo.TypeKind == TypeKind.Class)
      GenClassType(typeInfo, IntfOutputPath, ImplOutputPath);
    else if (typeInfo.TypeKind == TypeKind.Enum)
      GenEnumType(typeInfo, IntfOutputPath);
  }

  #region Class type generation

  public static void GenClassType(TypeInfo type, string IntfOutputPath, string ImplOutputPath)
  {
    var typeName = type.Name;
    var aNamespace = type.Namespace;
    var intfOutputPath = Path.Combine(IntfOutputPath, aNamespace);
    GenClassOrInterface(type, typeName, Path.Combine(intfOutputPath, "Interfaces", "I" + typeName + ".cs"), true);
    //var implOutputPath = Path.Combine(ImplOutputPath, aNamespace);
    //GenClassOrInterface(type, typeName, Path.Combine(implOutputPath, typeName + ".cs"), false);
  }

  public static void GenClassOrInterface(TypeInfo type, string typeName, string filename, bool toInterface)
  {
    AssurePathExists(filename);
    using (var textWriter = File.CreateText(filename))
    using (var writer = new IndentedTextWriter(textWriter, "  "))
    {
      GenClassOrInterface(type, typeName, writer, toInterface);
    }
  }

  public static void GenClassOrInterface(TypeInfo type, string typeName, IndentedTextWriter writer, bool toInterface)
  {
    var aNamespace = type.Namespace;
    if (aNamespace != null)
    {
      writer.WriteLine($"namespace {aNamespace};");
      writer.WriteLine();
    }

    GenDocumentationComments(type, writer);
    GenCustomAttributes(type.CustomAttributes, writer);
    if (toInterface)
      writer.WriteLine($"public interface I{typeName} // : {type.BaseTypeInfo?.GetFullName(false, true)}");
    else
      writer.WriteLine($"public class {typeName}: I{typeName}");
    writer.WriteLine("{");
    writer.Indent++;
    //if (type.Name == "AreaChartSeries")
    //  Debug.Assert(true);
    if (type.AcceptedProperties != null)
      foreach (var prop in type.AcceptedProperties)
        //if (!(ModelFilter.ExcludedProperties.Contains(prop.Name)) && !(ModelFilter.ExcludedTypes.Contains(prop.PropertyType.Namespace ?? "")))
        GenProperty(prop, writer, toInterface);
    writer.Indent--;
    writer.WriteLine("}");
  }

  public static void GenProperty(PropInfo prop, IndentedTextWriter writer, bool toInterface)
  {
    //if (prop.Name == "Index")
    //  Debug.Assert(true);
    var propertyType = prop.PropertyType;
    if (propertyType.ToString() == "DocumentModel.Drawing.Charts.Index")
      Debug.Assert(true);
    string propertyTypeName = propertyType.GetConvertedName(true, true);
    //string aNamespace = propertyType.GetNamespace(false);
    //if (propertyType.HasDuplicatesInName())
    //{
    //  propertyTypeName = propertyType.GetConvertedName(true, false);
    //}
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
    //AddGlobalUsing(aNamespace ?? "");
  }


  #endregion

  #region Enum types generation
  public static void GenEnumType(TypeInfo type, string IntfOutputPath)
  {
    var outputPath = IntfOutputPath;
    var aNamespace = type.Namespace;
    outputPath = Path.Combine(outputPath, aNamespace);
    var typeName = type.Name;
    var fileName = ValidateFilename(typeName);
    GenEnumType(type, typeName, Path.Combine(outputPath, "Enums", fileName + ".cs"));
  }

  public static void GenEnumType(TypeInfo type, string typeName, string filename)
  {
    AssurePathExists(filename);
    using (var textWriter = File.CreateText(filename))
    using (var writer = new IndentedTextWriter(textWriter, "  "))
    {
      GenEnumType(type, typeName, writer);
    }
  }

  public static void GenEnumType(TypeInfo type, string typeName, IndentedTextWriter writer)
  {
    var aNamespace = type.GetNamespace();
    if (aNamespace != null)
    {
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

  public static void GenEnum(EnumInfo field, IndentedTextWriter writer)
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

  public static bool GenCustomAttributes(IEnumerable<CustomAttribData>? attributes, IndentedTextWriter writer)
  {
    //if (attributes?.Any() == true)
    //{
    //  foreach (var customAttrib in attributes)
    //    GenCustomAttribute(customAttrib, writer);
    //  AddGlobalUsing("DocumentModel.Attributes");
    //  return true;
    //}
    return false;
  }

  public static void GenCustomAttribute(CustomAttribData attrData, IndentedTextWriter writer)
  {
    var attributeType = attrData.AttributeType;
    //if (ModelFilter.AttributeConversionTable.TryGetValue(attributeType, out var altAttrType))
    //  attributeType = altAttrType;
    var attrTypeName = attributeType.Name;
    if (attrTypeName.EndsWith("Attribute"))
      attrTypeName = attrTypeName.Substring(0, attrTypeName.Length - "Attribute".Length);
    if (ModelData.ExcludedAttributes.Contains(attrTypeName))
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
    AddGlobalUsing(attributeType.Namespace);
  }
  #endregion

  #region Documentation comments generation

  public static bool GenDocumentationComments(TypeInfo typeInfo, IndentedTextWriter writer)
  {
    var documentation = typeInfo.Type.GetXmlDocsElement();
    if (documentation != null)
    {
      var summary = DocumentationReader.GetSummaryFirstPara(documentation);
      if (summary != null)
      {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// {summary}");
        writer.WriteLine("/// </summary>");
      }
      //var childItemTypes = DocumentationReader.GetChildItemTypes(documentation, typeInfo.Type.Assembly);
      //if (childItemTypes != null)
      //{
      //  foreach (var childItemType in childItemTypes)
      //  {
      //    if (typeInfo.CustomAttributes == null)
      //    {
      //      var childItemTypeInfo = TypeManager.RegisterType(childItemType, this, Semantics.Include);
      //      var myCustomAttribute = new CustomAttribData(typeof(DocumentModel.Attributes.ChildElementInfoAttribute));
      //      myCustomAttribute.ConstructorArguments.Add(new CustomAttribTypedArgument(childItemTypeInfo));
      //      GenCustomAttribute(myCustomAttribute, writer);
      //    }
      //  }
      //}
      return true;
    }
    return false;
  }

  public static bool GenDocumentationComments(EnumInfo aField, IndentedTextWriter writer)
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

  public static bool GenDocumentationComments(PropInfo aProp, IndentedTextWriter writer)
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


  static SortedSet<string> GlobalUsings { get; } = new();

  public static void AddGlobalUsing(string aNamespace)
  {
    if (aNamespace == "System.IO.Packaging")
      return;
    if (aNamespace.StartsWith("DocumentFormat.OpenXml"))
      return;
    if (aNamespace != String.Empty)
      if (!GlobalUsings.Contains(aNamespace))
        GlobalUsings.Add(aNamespace);

  }

  public static void GenGlobalUsings(string filename)
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
  public static string TypedValueLiteral(Type type, object? value)
  {
    if (type == typeof(string))
    {
      if (value is string str)
        return $"\"{str}\"";
      return "\"\"";
    }
    else if (value is TypeInfo aType)
    {
      var aTypeName = "I" + aType.Name;
      var aNamespace = aType.Namespace;
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

  #region Filename/Path methods
  public static string ValidateFilename(string filename)
  {
    foreach (var ch in Path.GetInvalidFileNameChars())
      filename = filename.Replace(new string(ch, 1), "");
    return filename;
  }

  public static void AssurePathExists(string filename)
  {
    var filePath = Path.GetDirectoryName(filename);
    if (filePath != null)
      if (!Directory.Exists(filePath))
        Directory.CreateDirectory(filePath);
  }
  #endregion
}