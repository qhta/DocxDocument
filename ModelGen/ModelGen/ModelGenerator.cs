using System.CodeDom.Compiler;
using System.Diagnostics;

using Namotion.Reflection;

namespace ModelGen;

public class ModelGenerator
{
  public ModelGenerator(string projectName, string outputPath)
  {
    IntfProjectName = projectName;
    IntfOutputPath = outputPath;
    ImplProjectName = projectName + ".Impl";
    ImplOutputPath = outputPath + ".Impl";
  }

  public string IntfProjectName { get; private set; }
  public string IntfOutputPath { get; private set; }

  public string ImplProjectName { get; private set; }
  public string ImplOutputPath { get; private set; }

  public int GeneratedClassesCount { get; private set;}
  public int GeneratedInterfacesCount { get; private set; }
  public int GeneratedStructsCount { get; private set; }
  public int GeneratedEnumTypesCount { get; private set; }
  public int GeneratedPropertiesCount { get; private set; }
  public int GeneratedEnumValuesCount { get; private set; }

  public void PrepareProjects()
  {
    if (!Directory.Exists(IntfOutputPath))
      Directory.CreateDirectory(IntfOutputPath);
    ClearProjectFolder(IntfOutputPath);
    GenerateProjectFile(IntfProjectName, Path.Combine(IntfOutputPath, IntfProjectName + ".csproj"));


    if (!Directory.Exists(ImplOutputPath))
      Directory.CreateDirectory(ImplOutputPath);
    ClearProjectFolder(ImplOutputPath);
    GenerateProjectFile(ImplProjectName, Path.Combine(ImplOutputPath, ImplProjectName + ".csproj"));
  }

  private void ClearProjectFolder(string projectPath)
  {
    var subfolders = Directory.GetDirectories(projectPath);
    foreach (var subfolder in subfolders)
      try
      {
        Directory.Delete(subfolder, true);
      }
      catch { }
  }

  private void GenerateProjectFile(string projectName, string filename)
  {
    AssurePathExists(filename);
    using (var writer = File.CreateText(filename))
    using (var reader = File.OpenText(projectName + ".csproj.xml"))
    {
      writer.Write(reader.ReadToEnd());
    }
  }

  public void GenerateTypeFile(TypeInfo typeInfo)
  {
    if (typeInfo.TypeKind == TypeKind.Class)
      GenerateClassType(typeInfo);
    else if (typeInfo.TypeKind == TypeKind.Enum)
      GenEnumType(typeInfo);
  }

  #region Class type generation

  private void GenerateClassType(TypeInfo type)
  {
    var typeName = type.Name;
    var aNamespace = type.Namespace;
    var intfOutputPath = Path.Combine(IntfOutputPath, aNamespace);
    GenerateClassOrInterface(type, typeName, Path.Combine(intfOutputPath, "Interfaces", "I" + typeName + ".cs"), true);
    //var implOutputPath = Path.Combine(ImplOutputPath, aNamespace);
    //GenClassOrInterface(type, typeName, Path.Combine(implOutputPath, typeName + ".cs"), false);
  }

  private void GenerateClassOrInterface(TypeInfo type, string typeName, string filename, bool toInterface)
  {
    if (typeName.EndsWith('&'))
      Debug.Assert(true);
    AssurePathExists(filename);
    using (var textWriter = File.CreateText(filename))
    using (var writer = new IndentedTextWriter(textWriter, "  "))
    {
      GenerateClassOrInterface(type, typeName, writer, toInterface);
    }
  }

  private void GenerateClassOrInterface(TypeInfo typeInfo, string typeName, IndentedTextWriter writer, bool toInterface)
  {
    var aNamespace = typeInfo.Namespace;
    if (aNamespace != null)
    {
      writer.WriteLine($"namespace {aNamespace};");
      writer.WriteLine();
    }

    GenDocumentationComments(typeInfo, writer);
    GenCustomAttributes(typeInfo.CustomAttributes, writer);
    if (toInterface)
      writer.WriteLine($"public interface I{typeName} // : {typeInfo.BaseTypeInfo?.GetFullName(false, true)}");
    else
      writer.WriteLine($"public class {typeName}: I{typeName}");
    writer.WriteLine("{");
    writer.Indent++;
    //if (type.Name == "AreaChartSeries")
    //  Debug.Assert(true);
    if (typeInfo.AcceptedProperties != null)
      foreach (var prop in typeInfo.AcceptedProperties)
        //if (!(ModelFilter.ExcludedProperties.Contains(prop.Name)) && !(ModelFilter.ExcludedTypes.Contains(prop.PropertyType.Namespace ?? "")))
        GenerateProperty(prop, aNamespace, writer, toInterface);
    writer.Indent--;
    writer.WriteLine("}");
    if (toInterface)
      GeneratedInterfacesCount += 1;
    else if (typeInfo.TypeKind == TypeKind.Struct)
      GeneratedStructsCount += 1;
    else
      GeneratedClassesCount += 1;
  }

  private void GenerateProperty(PropInfo prop, string? InNamespace, IndentedTextWriter writer, bool toInterface)
  {
    //if (prop.Name == "Index")
    //  Debug.Assert(true);
    var propertyType = prop.PropertyType;
    //if (propertyType.ToString() == "DocumentModel.Drawing.Charts.Index")
    //  Debug.Assert(true);
    CompoundName propertyTypeName = propertyType.GetConvertedName(true, true);
    var namespaces = propertyTypeName.GetNamespaces();
    foreach (var ns in namespaces)
      if (ns.StartsWith("System") || ns=="DocumentModel.BaseTypes")
      {
        AddGlobalUsing(ns);
        propertyTypeName.RemoveNamespace(ns);
      }
      else
      if (ns==InNamespace)
      {
        propertyTypeName.RemoveNamespace(ns);
      }
    var propTypeName = propertyTypeName.ToString();
    GenDocumentationComments(prop, writer);
    GenCustomAttributes(prop.CustomAttributes, writer);
    if (toInterface)
      writer.WriteLine($"public {propTypeName}? {prop.Name} {{ get ; set; }}");
    else
    {
      writer.WriteLine($"public {propTypeName}? {prop.Name}");
      writer.WriteLine($"{{");
      writer.WriteLine($"  get;");
      writer.WriteLine($"  set;");
      writer.WriteLine($"}}");
    }
    writer.WriteLine();
    GeneratedPropertiesCount += 1;
  }


  #endregion

  #region Enum types generation
  private void GenEnumType(TypeInfo type)
  {
    var outputPath = IntfOutputPath;
    var aNamespace = type.Namespace;
    outputPath = Path.Combine(outputPath, aNamespace);
    var typeName = type.Name;
    var fileName = ValidateFilename(typeName);
    GenEnumType(type, typeName, Path.Combine(outputPath, "Enums", fileName + ".cs"));
    GeneratedEnumTypesCount += 1;
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
    GeneratedEnumValuesCount += 1;
  }
  #endregion

  #region CustomAttributes generation

  private bool GenCustomAttributes(IEnumerable<CustomAttribData>? attributes, IndentedTextWriter writer)
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

  private void GenCustomAttribute(CustomAttribData attrData, IndentedTextWriter writer)
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

  private bool GenDocumentationComments(TypeInfo typeInfo, IndentedTextWriter writer)
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


  SortedSet<string> GlobalUsings { get; } = new();

  private void AddGlobalUsing(string aNamespace)
  {
    if (aNamespace != String.Empty)
      if (!GlobalUsings.Contains(aNamespace))
        GlobalUsings.Add(aNamespace);

  }

  public void GenerateGlobalUsings()
  {
    GenerateGlobalUsings(Path.Combine(IntfOutputPath, "GlobalUsings.cs"));
  }

  private void GenerateGlobalUsings(string filename)
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
}