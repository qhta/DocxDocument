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

  public int GeneratedClassesCount { get; private set; }
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
      GenerateEnumType(typeInfo);
  }

  #region Class type generation

  private void GenerateClassType(TypeInfo type)
  {
    var typeName = type.Name;
    var aNamespace = type.Namespace;
    var intfOutputPath = Path.Combine(IntfOutputPath, aNamespace);
    GenerateClassOrInterface(type, typeName, Path.Combine(intfOutputPath, "Interfaces", typeName + ".cs"), true);
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
    GenerateCustomAttributes(typeInfo.CustomAttributes, writer);
    if (toInterface)
      writer.WriteLine($"public interface {typeName} // : {typeInfo.BaseTypeInfo?.GetConvertedName()}");
    else
      writer.WriteLine($"public class {typeName}: {typeName}");
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
    var propertyType = prop.PropertyType;
    CompoundName propertyTypeName = propertyType.GetConvertedName();
    var namespaces = propertyTypeName.GetNamespaces();
    foreach (var ns in namespaces)
      if (ns.StartsWith("System") || ns == "DocumentModel.BaseTypes")
      {
        AddGlobalUsing(ns);
        propertyTypeName.RemoveNamespace(ns);
      }
      else
      if (ns == InNamespace)
      {
        propertyTypeName.RemoveNamespace(ns);
      }
    var propTypeName = propertyTypeName.ToString();
    GenDocumentationComments(prop, writer);
    GenerateCustomAttributes(prop.CustomAttributes, writer);
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
  private void GenerateEnumType(TypeInfo type)
  {
    var outputPath = IntfOutputPath;
    var aNamespace = type.Namespace;
    outputPath = Path.Combine(outputPath, aNamespace);
    var typeName = type.Name;
    var fileName = ValidateFilename(typeName);
    GenerateEnumType(type, typeName, Path.Combine(outputPath, "Enums", fileName + ".cs"));
    GeneratedEnumTypesCount += 1;
  }

  private void GenerateEnumType(TypeInfo type, string typeName, string filename)
  {
    AssurePathExists(filename);
    using (var textWriter = File.CreateText(filename))
    using (var writer = new IndentedTextWriter(textWriter, "  "))
    {
      GenerateEnumType(type, typeName, writer);
    }
  }

  private void GenerateEnumType(TypeInfo type, string typeName, IndentedTextWriter writer)
  {
    var aNamespace = type.GetNamespace();
    if (aNamespace != null)
    {
      writer.WriteLine($"namespace {aNamespace};");
      writer.WriteLine();
    }
    GenDocumentationComments(type, writer);
    GenerateCustomAttributes(type.CustomAttributes, writer);
    writer.WriteLine($"public enum {typeName}");
    writer.WriteLine("{");
    writer.Indent++;
    if (type.EnumValues != null)
      foreach (var field in type.EnumValues)
        GenerateEnum(field, writer);
    writer.Indent--;
    writer.WriteLine("}");
  }

  private void GenerateEnum(EnumInfo field, IndentedTextWriter writer)
  {
    bool addEmptyLine = GenDocumentationComments(field, writer);
    if (field.CustomAttributes != null)
    {
      GenerateCustomAttributes(field.CustomAttributes, writer);
      addEmptyLine = true;
    }
    writer.WriteLine($"{field.Name},");
    if (addEmptyLine)
      writer.WriteLine();
    GeneratedEnumValuesCount += 1;
  }
  #endregion

  #region CustomAttributes generation

  private bool GenerateCustomAttributes(IEnumerable<CustomAttribData>? attributes, IndentedTextWriter writer)
  {
    if (attributes?.Any() == true)
    {
      bool generated = false;
      foreach (var customAttrib in attributes)
      {
        if (GenerateCustomAttribute(customAttrib, writer))
          generated = true;
      }
      return (generated);
    }
    return false;
  }

  private bool GenerateCustomAttribute(CustomAttribData attrData, IndentedTextWriter writer)
  {
    var attributeType = attrData.AttributeType;
    var attributeTypeName = attributeType.GetConvertedName();
    var attrTypeName = attributeTypeName.Name;
    if (attrTypeName.EndsWith("Attribute"))
      attrTypeName = attrTypeName.Substring(0, attrTypeName.Length - "Attribute".Length);
    if (attrTypeName == string.Empty)
      return false;
    if (ModelData.ExcludedAttributes.Contains(attrTypeName))
      return false;
    var attrString = attrTypeName;
    if (attrData.ConstructorArguments?.Count + attrData.NamedArguments?.Count > 0)
    {
      var strList = new List<string>();
      if (attrData.ConstructorArguments != null)
        foreach (var arg in attrData.ConstructorArguments)
          strList.Add(GenerateTypedValueLiteral(arg));
      if (attrData.NamedArguments != null)
        foreach (var arg in attrData.NamedArguments)
          strList.Add(GenerateTypedValueLiteral(arg));
      attrString += "(" + String.Join(", ", strList) + ")";
    }
    writer.WriteLine($"[{attrString}]");
    if (attributeTypeName.Namespace != null)
      AddGlobalUsing(attributeTypeName.Namespace);
    return true;
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
    Debug.Assert(aNamespace != "DocumentModel.Framework");
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
  private string GenerateTypedValueLiteral(CustomAttribNamedArgument namedArgument)
  {
    return namedArgument.MemberName + "=" + GenerateTypedValueLiteral(namedArgument.TypedValue);
  }

  private string GenerateTypedValueLiteral(CustomAttribTypedArgument typedArgument)
  {
    return GenerateTypedValueLiteral(typedArgument.Value);
  }

  private string GenerateTypedValueLiteral(object? value)
  {
    if (value is string str)
    {
      return $"\"{str}\"";
    }
    else if (value is TypeInfo aType)
    {
      var typeName = aType.GetConvertedName();
      var aTypeName = typeName.Name;
      var aNamespace = typeName.Namespace;
      return ($"typeof({aNamespace}.{aTypeName})");
    }
    else if (value is bool bv)
      return bv.ToString().ToLower();
    else if (value != null)
    {
      var valueType = value.GetType();
      if (valueType.IsEnum)
      {
        var enumName = Enum.GetName(valueType, value);
        enumName = valueType.Name + "." + enumName;
        return enumName;
      }
      return value.ToString() ?? "null";
    }
    return "null";
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