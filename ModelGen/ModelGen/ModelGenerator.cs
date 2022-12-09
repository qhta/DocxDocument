using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;

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

  public bool GenerateTypeFile(TypeInfo typeInfo)
  {
    //if (typeInfo.Name == "Rsids")
    //  Debug.Assert(true);
    if (!typeInfo.IsConverted && !typeInfo.IsConvertedTo)
    {
      if (typeInfo.TypeKind == TypeKind.Enum)
        GenerateEnumType(typeInfo);
      else if (!typeInfo.IsGenericTypeParameter)
        GenerateClassType(typeInfo);
      return true;
    }
    return false;
  }

  #region Class type generation

  private void GenerateClassType(TypeInfo type)
  {
    var typeName = type.Name;
    var aNamespace = type.Namespace;
    var intfOutputPath = Path.Combine(IntfOutputPath, aNamespace);
    GenerateClassOrInterface(type, typeName, Path.Combine(intfOutputPath, "Interfaces", typeName + ".cs"), TypeKind.Interface);
    var implOutputPath = Path.Combine(ImplOutputPath, aNamespace);
    GenerateClassOrInterface(type, typeName, Path.Combine(implOutputPath, "Classes", typeName + ".cs"), TypeKind.Class);
  }

  private void GenerateClassOrInterface(TypeInfo type, string typeName, string filename, TypeKind kind)
  {
    AssurePathExists(filename);
    using (var textWriter = File.CreateText(filename))
    using (var writer = new IndentedTextWriter(textWriter, "  "))
    {
      GenerateClassOrInterface(type, typeName, writer, kind);
    }
  }

  private void GenerateClassOrInterface(TypeInfo typeInfo, string typeName, IndentedTextWriter writer, TypeKind kind)
  {
    var aNamespace = typeInfo.Namespace;
    if (aNamespace != null)
    {
      writer.WriteLine($"namespace {aNamespace};");
      writer.WriteLine();
    }

    GenDocumentationComments(typeInfo, writer);
    GenerateCustomAttributes(typeInfo.CustomAttributes, writer);

    bool newOpenXmlElementProperty = true;

    if (kind == TypeKind.Interface)
    {
      var str = $"public interface {typeName}";
      writer.WriteLine(str);
    }
    else if (kind == TypeKind.Class)
    {
      List<string> baseTypeNames = new();
      if (typeInfo.BaseTypeInfo != null)
      {
        var baseTypeInfo = typeInfo.BaseTypeInfo.GetConversionTarget(true);
        if (baseTypeInfo.IsInterface)
        {
          var baseInterfaceName = typeInfo.BaseTypeInfo.GetConvertedName(kind);
          baseTypeNames.Add(baseInterfaceName.ToString());
        }
      }
      if (baseTypeNames.Count == 0)
      {
        if (typeInfo.Type.IsSubclassOf(typeof(DocumentFormat.OpenXml.OpenXmlElement)))
          baseTypeNames.Add($"ModelElementImpl");
        else
        if (typeInfo.Type.IsSubclassOf(typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPart)))
          baseTypeNames.Add($"ModelPartImpl");
        else
          baseTypeNames.Add($"ModelObjectImpl");
        newOpenXmlElementProperty = false;
      }
      baseTypeNames.Add(typeInfo.GetFullName(false, true, false));
      var baseStr = baseTypeNames.Any() ? ": " + String.Join(", ", baseTypeNames) : String.Empty;
      typeName += "Impl";
      var str = $"public class {typeName}" + baseStr;
      writer.WriteLine(str);
    }
    else
      throw new NotImplementedException($"GenerateClassOrInterface not implemented for kind {kind}");
    writer.WriteLine("{");
    writer.Indent++;
    if (kind == TypeKind.Class)
    {
      GenerateOpenXmlElementProperty(typeInfo.GetFullName(true), newOpenXmlElementProperty, writer);
    }
    if (typeInfo.AcceptedProperties != null)
      foreach (var prop in typeInfo.AcceptedProperties)
        GenerateProperty(prop, aNamespace, writer, kind);
    writer.Indent--;
    writer.WriteLine("}");
    if (kind == TypeKind.Interface)
      GeneratedInterfacesCount += 1;
    else if (kind == TypeKind.Class)
      GeneratedClassesCount += 1;
  }

  private void GenerateOpenXmlElementProperty(string origModelElementTypeName, bool newProperty, IndentedTextWriter writer)
  {
    var newPropertyStr = newProperty ? "new " : String.Empty;
    writer.WriteLine($"public {newPropertyStr}{origModelElementTypeName}? OpenXmlElement");
    writer.WriteLine($"{{");
    writer.WriteLine($"  get => ({origModelElementTypeName}?)_OpenXmlElement;");
    writer.WriteLine($"  set => _OpenXmlElement = value;");
    writer.WriteLine($"}}");
    writer.WriteLine();
  }

  private void GenerateProperty(PropInfo prop, string? InNamespace, IndentedTextWriter writer, TypeKind kind)
  {
    //if (prop.Name == "MultiLevelStringReference" && prop.Owner is TypeInfo typeInfo && typeInfo.Name == "AxisDataSourceType")
    //  Debug.Assert(true);
    var targetPropType = prop.PropertyType.GetConversionTarget(true);
    CompoundName propertyTypeName = prop.PropertyType.GetConvertedName(TypeKind.Type);
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
    if (kind == TypeKind.Interface)
      writer.WriteLine($"public {propTypeName}? {prop.Name} {{ get ; set; }}");
    else
    {
      var str = "public ";
      if (prop.IsStatic)
        str += "static ";
      if (prop.IsNew)
        str += "new ";
      if (prop.IsOverriden)
        str += "override ";
      if (prop.IsAbstract)
        str += "abstract ";
      if (prop.IsVirtual)
        str += "virtual ";
      str += $"{propTypeName}? {prop.Name}";
      writer.WriteLine(str);
      writer.WriteLine($"{{");
      if (targetPropType.TypeKind == TypeKind.Enum)
        GenerateValueTypeAccessors(prop, targetPropType, propTypeName, writer);
      else
      {
        if (targetPropType != null && targetPropType.IsValueType 
            //                       &&
            //(targetPropType.Type == typeof(String)
            // || targetPropType.Type == typeof(Boolean)
            // || targetPropType.Type == typeof(Int32))
            )
          GenerateValueTypeAccessors(prop, targetPropType, propTypeName, writer);
        else
          GeneratePropAccessorsNotImplemented(writer);
      }
      writer.WriteLine($"}}");
    }
    writer.WriteLine();
    GeneratedPropertiesCount += 1;
  }

  private void GenerateValueTypeAccessors(PropInfo prop, TypeInfo targetPropType, string genPropTypeName, IndentedTextWriter writer)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropName = prop.Name;
    var origTargetTypeName = targetPropType.GetFullName(true);
    //if (prop.Name == "Xsddouble")
    //  Debug.Assert(true);
    if (prop.PropertyInfo != null && prop.PropertyInfo.PropertyType == targetPropType.Type)
      GenerateDirectPropAccessors(prop.PropertyInfo, genPropTypeName, origPropName, origTargetTypeName, writer);

    else if (prop.PropertyType.Type.IsSubclassOf(typeof(DocumentFormat.OpenXml.OpenXmlSimpleType)))
      GenerateSimpleValuePropAccessors(genPropTypeName, origPropName, origTargetTypeName, writer);
    else
    {
      if (prop.PropertyInfo != null && prop.PropertyInfo.DeclaringType.HasProperty(prop.Name))
      {
        GenerateObjectPropAccessors(genPropTypeName, origPropName, origTargetTypeName, origPropTypeName, writer);
      }
      else
      {
        if (origTargetTypeName == "DocumentModel.HexWord")
          origTargetTypeName = "string";
        var origPropBaseType = GetTypeWithBaseOf(prop.PropertyType.Type, typeof(DocumentFormat.OpenXml.TypedOpenXmlLeafElement));
        if (origPropBaseType != null && origPropBaseType.HasProperty1("Val"))
          GenerateIncludedElementPropAccessors(genPropTypeName, origPropTypeName, origTargetTypeName, writer);
        else
        {
          if (targetPropType.Type == typeof(String))
            GenerateIncludedStringPropAccessors(origPropTypeName, writer);
          else
          if (targetPropType.Type == typeof(Boolean))
            GenerateIncludedBooleanPropAccessors(origPropTypeName, writer);
          else
            GenerateIncludedElementPropAccessors(genPropTypeName, origPropTypeName, origTargetTypeName, writer);
        }
      }
    }
  }

  private Type? GetTypeWithBaseOf(Type thisType, Type baseType)
  {
    if (thisType.BaseType == baseType)
      return thisType;
    if (thisType.BaseType != null)
      return GetTypeWithBaseOf(thisType.BaseType, baseType);
    return null;
  }

  //private void GenerateEnumPropAccessors(PropInfo prop, TypeInfo targetPropType, string genPropTypeName, IndentedTextWriter writer)
  //{
  //  var origPropTypeName = prop.PropertyType.GetFullName(true);
  //  var origPropName = prop.Name;
  //  var origTargetTypeName = targetPropType.GetFullName(true);

  //  if (prop.PropertyInfo != null && prop.PropertyInfo.PropertyType == targetPropType.Type)
  //    GenerateDirectPropAccessors(prop.PropertyInfo, genPropTypeName, origPropName, origTargetTypeName, writer);

  //  else
  //  if (prop.PropertyType.Type.Name.StartsWith("EnumValue`"))
  //    GenerateSimpleValuePropAccessors(genPropTypeName, origPropName, origTargetTypeName, writer);

  //  else if (prop.PropertyType.Type.BaseType == typeof(DocumentFormat.OpenXml.TypedOpenXmlLeafElement)
  //           || prop.PropertyType.Type.BaseType?.BaseType == typeof(DocumentFormat.OpenXml.TypedOpenXmlLeafElement))
  //  {
  //    if (prop.PropertyInfo != null && prop.PropertyInfo.DeclaringType.HasProperty(prop.Name))
  //      GenerateObjectPropAccessors(genPropTypeName, origPropName, origTargetTypeName, origPropTypeName, writer);
  //    else
  //      GenerateIncludedElementPropAccessors(genPropTypeName, origPropTypeName, origTargetTypeName, writer);
  //  }

  //  else
  //    GeneratePropAccessorsNotImplemented(writer);
  //}

  private void GeneratePropAccessorsNotImplemented(IndentedTextWriter writer)
  {
    writer.WriteLine($"  get => throw new NotImplementedException(\"Method not implemented\");");
    writer.WriteLine($"  set => throw new NotImplementedException(\"Method not implemented\");");
  }

  private void GenerateDirectPropAccessors(PropertyInfo propertyInfo,
    string genPropTypeName, string origPropName, string origTargetTypeName,
    IndentedTextWriter writer)
  {
    writer.WriteLine($"  get => ({genPropTypeName}?)OpenXmlElement?.{origPropName};");
    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    if (propertyInfo.SetMethod?.IsAssembly != true
        || propertyInfo.SetMethod?.IsFamilyAndAssembly != true
        || propertyInfo.SetMethod?.IsFamilyOrAssembly != true)
      // if method is internal, protected or internal protected
      writer.WriteLine($"      typeof({propertyInfo.DeclaringType?.FullName})" +
                       $".GetProperty(\"{origPropName}\").SetValue(OpenXmlElement, ({origTargetTypeName}?)value);");
    else
      writer.WriteLine($"      OpenXmlElement.{origPropName} = ({origTargetTypeName}?)value;");
    writer.WriteLine($"  }}");
  }

  private void GenerateSimpleValuePropAccessors(string genPropTypeName, string origPropName, string origTargetTypeName,
    IndentedTextWriter writer)
  {
    writer.WriteLine($"  get => ({genPropTypeName}?)OpenXmlElement?.{origPropName}?.Value;");
    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"      OpenXmlElement.{origPropName} = ({origTargetTypeName}?)value;");
    writer.WriteLine($"  }}");
  }

  private void GenerateObjectPropAccessors(string genPropTypeName, string origPropName, string origTargetTypeName,
    string origPropTypeName, IndentedTextWriter writer)
  {
    writer.WriteLine($"  get => ({genPropTypeName}?)OpenXmlElement?.{origPropName}?.Val?.Value;");
    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      if (OpenXmlElement.{origPropName} != null)");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value is not null)");
    writer.WriteLine($"          OpenXmlElement.{origPropName}.Val = ({origTargetTypeName}?)value;");
    writer.WriteLine($"        else");
    writer.WriteLine($"          OpenXmlElement.{origPropName} = null;");
    writer.WriteLine($"      }}");
    writer.WriteLine($"      else");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value is not null)");
    writer.WriteLine(
      $"          OpenXmlElement.{origPropName} = new {origPropTypeName}{{ Val = ({origTargetTypeName}?)value }};");
    writer.WriteLine($"      }}");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
  }

  private void GenerateObjectNoValPropAccessors(string genPropTypeName, string origPropName, string origTargetTypeName,
    string origPropTypeName, IndentedTextWriter writer)
  {
    writer.WriteLine($"  get => ({genPropTypeName}?)OpenXmlElement?.{origPropName}?.Val?.Value;");
    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      if (OpenXmlElement.{origPropName} != null)");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value is not null)");
    writer.WriteLine($"          OpenXmlElement.{origPropName}.Val = ({origTargetTypeName}?)value;");
    writer.WriteLine($"        else");
    writer.WriteLine($"          OpenXmlElement.{origPropName} = null;");
    writer.WriteLine($"      }}");
    writer.WriteLine($"      else");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value is not null)");
    writer.WriteLine(
      $"          OpenXmlElement.{origPropName} = new {origPropTypeName}{{ Val = ({origTargetTypeName}?)value }};");
    writer.WriteLine($"      }}");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
  }

  private void GenerateIncludedElementPropAccessors(string genPropTypeName, string origPropTypeName, string origTargetTypeName,
    IndentedTextWriter writer)
  {
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var openXmlElement = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    writer.WriteLine($"      return ({genPropTypeName}?)openXmlElement?.Val?.Value;");
    writer.WriteLine($"    }}");
    writer.WriteLine($"    return null;");
    writer.WriteLine($"  }}");
    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var openXmlElement = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    writer.WriteLine($"      if (openXmlElement != null)");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value is not null)");
    writer.WriteLine($"          openXmlElement.Val = ({origTargetTypeName}?)value;");
    writer.WriteLine($"        else");
    writer.WriteLine($"          openXmlElement.Remove();");
    writer.WriteLine($"      }}");
    writer.WriteLine($"      else");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value is not null)");
    writer.WriteLine($"        {{");
    writer.WriteLine($"          openXmlElement = new {origPropTypeName}{{ Val = ({origTargetTypeName}?)value }};");
    writer.WriteLine($"          OpenXmlElement.AddChild(openXmlElement);");
    writer.WriteLine($"        }}");
    writer.WriteLine($"      }}");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
  }

  private void GenerateIncludedStringPropAccessors(string origPropTypeName, IndentedTextWriter writer)
  {
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var openXmlElement = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    writer.WriteLine($"      return openXmlElement?.Text;");
    writer.WriteLine($"    }}");
    writer.WriteLine($"    return null;");
    writer.WriteLine($"  }}");
    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var openXmlElement = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    writer.WriteLine($"      if (openXmlElement != null)");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value is not null)");
    writer.WriteLine($"          openXmlElement.Text = value;");
    writer.WriteLine($"        else");
    writer.WriteLine($"          openXmlElement.Remove();");
    writer.WriteLine($"      }}");
    writer.WriteLine($"      else");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value is not null)");
    writer.WriteLine($"        {{");
    writer.WriteLine($"          openXmlElement = new {origPropTypeName}{{ Text = value }};");
    writer.WriteLine($"          OpenXmlElement.AddChild(openXmlElement);");
    writer.WriteLine($"        }}");
    writer.WriteLine($"      }}");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
  }

  private void GenerateIncludedBooleanPropAccessors(string origPropTypeName, IndentedTextWriter writer)
  {
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var openXmlElement = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    writer.WriteLine($"      return openXmlElement != null;");
    writer.WriteLine($"    }}");
    writer.WriteLine($"    return null;");
    writer.WriteLine($"  }}");
    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var openXmlElement = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    writer.WriteLine($"      if (openXmlElement != null)");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value == false)");
    writer.WriteLine($"          openXmlElement.Remove();");
    writer.WriteLine($"      }}");
    writer.WriteLine($"      else");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value == true)");
    writer.WriteLine($"        {{");
    writer.WriteLine($"          openXmlElement = new {origPropTypeName}();");
    writer.WriteLine($"          OpenXmlElement.AddChild(openXmlElement);");
    writer.WriteLine($"        }}");
    writer.WriteLine($"      }}");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
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
        if (customAttrib.IsAccepted is true)
          if (GenerateCustomAttribute(customAttrib, writer))
            generated = true;
      }
      return (generated);
    }
    return false;
  }

  private bool GenerateCustomAttribute(CustomAttribData attrData, IndentedTextWriter writer)
  {
    var kind = TypeKind.Type;
    var attributeType = attrData.AttributeType;
    var attributeTypeName = attributeType.GetConvertedName(kind);
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
          strList.Add(GenerateTypedValueLiteral(arg, kind));
      if (attrData.NamedArguments != null)
        foreach (var arg in attrData.NamedArguments)
          strList.Add(CreateTypedValueLiteral(arg, kind));
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
    AddGlobalUsing("DocumentModel.Impl");
    GenerateGlobalUsings(Path.Combine(ImplOutputPath, "GlobalUsings.cs"));
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
  private string CreateTypedValueLiteral(CustomAttribNamedArgument namedArgument, TypeKind kind)
  {
    return namedArgument.MemberName + "=" + GenerateTypedValueLiteral(namedArgument.TypedValue, kind);
  }

  private string GenerateTypedValueLiteral(CustomAttribTypedArgument typedArgument, TypeKind kind)
  {
    return CreateTypedValueLiteral(typedArgument.Value, kind);
  }

  private string CreateTypedValueLiteral(object? value, TypeKind kind)
  {
    if (value is string str)
    {
      return $"\"{str}\"";
    }
    else if (value is TypeInfo aType)
    {
      var typeName = aType.GetConvertedName(kind);
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