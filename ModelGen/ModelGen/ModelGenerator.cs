using System.CodeDom.Compiler;

using DocumentFormat.OpenXml;

using Namotion.Reflection;

using Qhta.TypeUtils;


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
    GenerateProjectFile(IntfProjectName, System.IO.Path.Combine(IntfOutputPath, IntfProjectName + ".csproj"));

    if (!Directory.Exists(ImplOutputPath))
      Directory.CreateDirectory(ImplOutputPath);
    ClearProjectFolder(ImplOutputPath);
    GenerateProjectFile(ImplProjectName, System.IO.Path.Combine(ImplOutputPath, ImplProjectName + ".csproj"));
  }

  private void ClearProjectFolder(string projectPath)
  {
    var subfolders = Directory.GetDirectories(projectPath);
    foreach (var subfolder in subfolders)
      try
      {
        if (!subfolder.EndsWith("Extensions"))
          Directory.Delete(subfolder, true);
      }
      catch { }
  }

  private bool GenerateProjectFile(string projectName, string filename)
  {
    AssurePathExists(filename);
    using (var writer = File.CreateText(filename))
    using (var reader = File.OpenText(projectName + ".csproj.xml"))
    {
      writer.Write(reader.ReadToEnd());
    }
    return true;
  }

  public bool GenerateTypeFile(TypeInfo typeInfo)
  {
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

  private bool GenerateClassType(TypeInfo type)
  {
    var typeName = type.Name;
    var aNamespace = type.Namespace;
    var intfOutputPath = Path.Combine(IntfOutputPath, aNamespace);
    var implOutputPath = Path.Combine(ImplOutputPath, aNamespace);
    return GenerateClassOrInterface(type, typeName, Path.Combine(intfOutputPath, "Interfaces", typeName + ".cs"), TypeKind.Interface)
      && GenerateClassOrInterface(type, typeName, Path.Combine(implOutputPath, "Classes", typeName + ".cs"), TypeKind.Class);
  }

  private bool GenerateClassOrInterface(TypeInfo type, string typeName, string filename, TypeKind kind)
  {
    AssurePathExists(filename);
    using (var textWriter = File.CreateText(filename))
    using (var writer = new IndentedTextWriter(textWriter, "  "))
    {
      return GenerateClassOrInterface(type, typeName, writer, kind);
    }
  }

  private bool GenerateClassOrInterface(TypeInfo typeInfo, string typeName, IndentedTextWriter writer, TypeKind kind)
  {
    var aNamespace = typeInfo.Namespace;
    if (aNamespace != null)
    {
      writer.WriteLine($"namespace {aNamespace};");
      writer.WriteLine();
    }

    GenerateDocumentationComments(typeInfo, writer);
    GenerateCustomAttributes(typeInfo.CustomAttributes, writer);

    bool newOpenXmlElementProperty = true;

    if (kind == TypeKind.Interface)
    {
      var str = $"public partial interface {typeName}";
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
        if (typeInfo.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OpenXmlElement)))
          baseTypeNames.Add($"ModelElementImpl");
        else
        if (typeInfo.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPart)))
          baseTypeNames.Add($"ModelPartImpl");
        else
          baseTypeNames.Add($"ModelObjectImpl");
        newOpenXmlElementProperty = false;
      }
      var baseTypeName = typeInfo.GetFullName(false);
      baseTypeName.Namespace = null;
      baseTypeNames.Add(baseTypeName);
      var baseStr = baseTypeNames.Any() ? ": " + String.Join(", ", baseTypeNames) : String.Empty;
      typeName += "Impl";
      var str = $"public partial class {typeName}" + baseStr;
      writer.WriteLine(str);
    }
    else
      throw new NotImplementedException($"GenerateClassOrInterface not implemented for kind {kind}");
    writer.WriteLine("{");
    writer.Indent++;

    var subclasses = new List<string>();

    if (kind == TypeKind.Class)
    {
      if (!GenerateOpenXmlElementProperty(typeInfo.GetFullName(true), newOpenXmlElementProperty, writer))
        return false;
    }
    //if (kind != TypeKind.Interface && typeInfo.ItemsConstraint != null)
    //  if (typeInfo.Name == "Rsids")
    //    GenerateItemsProperties(typeInfo, typeInfo.ItemsConstraint, typeInfo.Name, aNamespace, subclasses, writer, TypeKind.EmbeddedClass);

    if (kind == TypeKind.Class)
    {
      GenerateClassConstructor(typeName, writer);
      GenerateClassConstructor(typeName, typeInfo.GetFullName(true), subclasses, writer);
    }

    var ok = GenerateAcceptedProperties(typeInfo, aNamespace, writer, kind);
    writer.Indent--;
    writer.WriteLine("}");
    if (kind == TypeKind.Interface)
      GeneratedInterfacesCount += 1;
    else if (kind == TypeKind.Class)
      GeneratedClassesCount += 1;
    return ok;
  }

  private bool GenerateOpenXmlElementProperty(string origModelElementTypeName, bool newProperty, IndentedTextWriter writer)
  {
    var newPropertyStr = newProperty ? "new " : String.Empty;
    writer.WriteLine($"[XmlIgnore]");
    writer.WriteLine($"public {newPropertyStr}{origModelElementTypeName}? OpenXmlElement");
    writer.WriteLine($"{{");
    writer.WriteLine($"  get => ({origModelElementTypeName}?)_OpenXmlElement;");
    writer.WriteLine($"  protected set => _OpenXmlElement = value;");
    writer.WriteLine($"}}");
    writer.WriteLine();
    return true;
  }

  private bool GenerateAcceptedProperties(TypeInfo typeInfo, string? inNamespace, IndentedTextWriter writer, TypeKind kind)
  {
    if (typeInfo.AcceptedProperties != null)
      foreach (var prop in typeInfo.AcceptedProperties)
        //if (kind == TypeKind.Interface || !prop.IsConstrained)
        if (!GenerateProperty(prop, inNamespace, writer, kind))
          return false;
    return true;
  }

  private bool GenerateItemsProperties(TypeInfo typeInfo, ItemsConstraint constraint, string fromClassName, string? inNamespace,
    List<string> subclassesTypeNames, IndentedTextWriter writer, TypeKind kind)
  {
    if (constraint is ItemTypeConstraint itemTypeConstraint)
    {
      var prop = itemTypeConstraint.AccessProperty;
      if (prop != null)
        if (!GenerateProperty(prop, inNamespace, writer, kind))
          return false;
    }
    else
    if (constraint is ItemsCompoundConstraint itemsCompoundConstraint)
    {
      var constraintClassName = fromClassName + constraint.ConstraintType.ToString();
      subclassesTypeNames.Add(constraintClassName);
      if (constraint.ConstraintType == ConstraintType.Group && !constraint.IsRequired && !constraint.IsMultiple)
      {
        foreach (var itemConstraint in itemsCompoundConstraint.Items)
        {
          if (!GenerateItemsProperties(typeInfo, itemConstraint, constraintClassName, inNamespace, subclassesTypeNames, writer, TypeKind.EmbeddedClass))
            return false;
        }
      }
      else
      {
        if (!GenerateSubclass(typeInfo, itemsCompoundConstraint, constraintClassName, inNamespace, subclassesTypeNames, writer, TypeKind.EmbeddedClass))
          return false;
      }
    }
    return true;
  }

  private bool GenerateSubclass(TypeInfo typeInfo, ItemsCompoundConstraint constraint, string constraintClassName, string? inNamespace,
    List<string> subclassesTypeNames, IndentedTextWriter writer, TypeKind kind)
  {
    var constraintsStrs = new List<string>();
    if (constraint.IsRequired)
      constraintsStrs.Add("required");
    if (constraint.IsMultiple)
      constraintsStrs.Add("multiple");
    string str = $"public class {constraintClassName}";
    if (constraintsStrs.Count > 0)
      str += " // " + String.Join(", ", constraintsStrs);
    writer.WriteLine(str);
    writer.WriteLine($"{{");
    writer.Indent++;

    if (!GenerateClassHeading(constraintClassName, "DocumentFormat.OpenXml.OpenXmlCompositeElement", null, writer))
      return false;

    foreach (var itemConstraint in constraint.Items)
      if (!GenerateItemsProperties(typeInfo, itemConstraint, constraintClassName, inNamespace, subclassesTypeNames, writer, TypeKind.EmbeddedClass))
        return false;

    writer.Indent--;
    writer.WriteLine($"}} // {constraintClassName}");
    writer.WriteLine();
    if (constraint.IsRequired)
      writer.WriteLine($"private {constraintClassName} _{constraintClassName} = null!;");
    else
      writer.WriteLine($"private {constraintClassName}? _{constraintClassName};");
    writer.WriteLine();
    return true;
  }

  private bool GenerateClassHeading(string className, string openXmlTypeName, List<string>? subclassesTypeNames, IndentedTextWriter writer)
  {
    writer.WriteLine();
    writer.WriteLine($"public {openXmlTypeName} OpenXmlElement {{ get; set; }}");
    writer.WriteLine();
    writer.WriteLine($"public {className}({openXmlTypeName} openXmlElement)");
    writer.WriteLine($"{{");
    writer.Indent++;
    writer.WriteLine($"OpenXmlElement = openXmlElement;");
    writer.Indent--;
    writer.WriteLine($"}}");
    return true;
  }

  private bool GenerateClassConstructor(string className, IndentedTextWriter writer)
  {
    writer.WriteLine($"public {className}(): base() {{}}");
    writer.WriteLine();
    return true;
  }

  private bool GenerateClassConstructor(string className, string openXmlTypeName, List<string>? subclassesTypeNames, IndentedTextWriter writer)
  {
    writer.WriteLine($"public {className}({openXmlTypeName} openXmlElement): base(openXmlElement)");
    writer.WriteLine($"{{");
    writer.Indent++;
    writer.WriteLine($"OpenXmlElement = openXmlElement;");
    if (subclassesTypeNames != null)
      foreach (var subclass in subclassesTypeNames)
        writer.WriteLine($"{subclass} _{subclass} = new {subclass}(openXmlElement);");
    writer.Indent--;
    writer.WriteLine($"}}");
    writer.WriteLine();
    return true;
  }

  private bool GenerateProperty(PropInfo prop, string? inNamespace, IndentedTextWriter writer, TypeKind kind)
  {
    var targetPropType = prop.PropertyType.GetConversionTarget(true);
    FullTypeName targetPropTypeName = prop.PropertyType.GetConvertedName(TypeKind.Type);
    TrimNamespace(targetPropTypeName);
    var propTypeName = targetPropTypeName.ToString();
    string qm = /*(targetPropTypeName.Name.StartsWith("Nullable")) ? "" :*/ "?";
    GenerateDocumentationComments(prop, writer);
    GenerateCustomAttributes(prop.CustomAttributes, writer);
    if (kind == TypeKind.Interface)
    {
      if (prop.IsReadonly)
        writer.WriteLine($"public {propTypeName}{qm} {prop.Name} {{ get; }}");
      else
        writer.WriteLine($"public {propTypeName}{qm} {prop.Name} {{ get; set; }}");
    }
    else
    {
      var str = "public ";
      if (kind != TypeKind.EmbeddedClass)
      {
        if (prop.IsStatic)
          str += "static ";
        if (prop.IsNew)
          str += "new ";
        if (prop.IsOverriden)
          str += "new ";
        if (prop.IsAbstract)
          str += "abstract ";
        if (prop.IsVirtual)
          str += "virtual ";
      }
      str += $"{propTypeName}{qm} {prop.Name}";
      writer.WriteLine(str);

      writer.WriteLine($"{{");
      if (!GeneratePropertyAccessors(prop, targetPropType, out var fieldName, out var propItemType, writer))
        return false;
      writer.WriteLine($"}}");
      if (fieldName != null && propItemType != null)
        GenerateCollectionField(prop, propItemType, writer);
    }
    writer.WriteLine();
    GeneratedPropertiesCount += 1;
    return true;
  }

  private bool GeneratePropertyAccessors(PropInfo prop, TypeInfo targetPropType, out string? fieldName, out TypeInfo? propItemType, IndentedTextWriter writer)
  {
    fieldName = null;
    propItemType = null;
    //if (prop.Name == "DataPart")
    //  Debug.Assert(true);
    if (prop.DeclaringType?.Name=="CoreProperties")
      return GenerateCorePropertiesPropAccessors(prop, targetPropType, writer);
    if (targetPropType.TypeKind == TypeKind.Enum)
      return GenerateValueTypeAccessors(prop, targetPropType, writer);
    if (targetPropType.IsValueOrStringType)
      return GenerateValueTypeAccessors(prop, targetPropType, writer);
    if (targetPropType.Name.StartsWith("ListOf`"))
      return GenerateListValuePropAccessors(prop, targetPropType, writer);

    if (targetPropType.Name.StartsWith("Collection`"))
    {
      propItemType = targetPropType.GetGenericArgTypes()?.FirstOrDefault();
      if (propItemType != null)
      {
        fieldName = "_" + prop.Name;
        return GenerateCollectionTypeAccessors(prop, propItemType, writer);
      }
    }
    if (prop.Name=="Package" || prop.Name == "PartExtensionProvider")
      return GeneratePackagePropAccessors(prop, writer);

    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPart)))
    //  return GeneratePartTypeAccessors(prop, targetPropType, writer);

    return GenerateObjectTypeAccessors(prop, targetPropType, writer);
  }

  private void TrimNamespace(FullTypeName typeName)
  {
    if (typeName.Namespace != null)
    {
      if (typeName.Namespace.StartsWith("System"))
      {
        AddGlobalUsing(typeName.Namespace);
        typeName.Namespace = null;
      }
    }
  }
  private bool GenerateValueTypeAccessors(PropInfo prop, TypeInfo targetPropType, IndentedTextWriter writer)
  {
    if (prop.PropertyInfo != null && prop.PropertyInfo.PropertyType == targetPropType.Type)
      return GenerateDirectPropAccessors(prop, targetPropType, writer);

    if (targetPropType.Name == "Base64Binary" || targetPropType.Name == "HexBinary")
    {
      //if (prop.Name== "DocumentId")
      //  Debug.Assert(true);
      var origPropType = prop.PropertyType.Type;
      if (prop.DeclaringType != null && prop.DeclaringType.Type.HasProperty(prop.Name))
      {
        if (origPropType.HasProperty("Val"))
          return GenerateBinaryValPropAccessors(prop, targetPropType, writer);

        return GenerateBinaryValuePropAccessors(prop, targetPropType, writer);
      }
      return GenerateBinaryValueIncludedPropAccessors(prop, targetPropType, writer);
    }

    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OpenXmlSimpleType)))
      return GenerateSimpleValuePropAccessors(prop, targetPropType, writer);
    if (prop.PropertyInfo?.DeclaringType != null && prop.PropertyInfo.DeclaringType.HasProperty(prop.Name))
    {
      if (targetPropType.Type == typeof(Boolean))
        return GenerateIncludedBooleanPropAccessors(prop, writer);

      return GenerateObjectValuePropAccessors(prop, targetPropType, writer);
    }

    var origPropBaseType = GetTypeWithBaseOf(prop.PropertyType.Type, typeof(DocumentFormat.OpenXml.TypedOpenXmlLeafElement));
    if (origPropBaseType != null && origPropBaseType.HasProperty("Val"))
      return GenerateIncludedValueElementPropAccessors(prop, targetPropType, writer);

    if (targetPropType.Type == typeof(String))
      return GenerateIncludedStringPropAccessors(prop, writer);

    if (targetPropType.Type == typeof(Boolean))
      return GenerateIncludedBooleanPropAccessors(prop, writer);

    //return GenerateIncludedValueElementPropAccessors(prop, targetPropType, writer);
    return false;
  }

  private bool GenerateObjectTypeAccessors(PropInfo prop, TypeInfo targetPropType, IndentedTextWriter writer)
  {
    if (prop.PropertyType.Namespace=="DocumentModel.VariantTypes")
      return GenerateVariantIncludedPropAccessors(prop, targetPropType, writer);

    if (targetPropType.Name.EndsWith("Parts"))
      return GenerateIncludedObjectElementPropAccessors(prop, targetPropType, writer);

    if (prop.DeclaringType != null && prop.DeclaringType.Name.EndsWith("Part"))
      return GenerateObjectComplexPropAccessors(prop, targetPropType, writer);

    if (prop.DeclaringType != null && prop.DeclaringType.Name.EndsWith("Package"))
      return GenerateObjectComplexPropAccessors(prop, targetPropType, writer);

    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPart)))
      return GeneratePartTypePropAccessors(prop, targetPropType, writer);

    if (prop.PropertyType.Type == typeof(DocumentFormat.OpenXml.Packaging.DataPart))
      return GeneratePartTypePropAccessors(prop, targetPropType, writer);

    return GenerateIncludedObjectElementPropAccessors(prop, targetPropType, writer);
  }

  private Type? GetTypeWithBaseOf(Type thisType, Type baseType)
  {
    if (thisType.BaseType?.Name == baseType.Name)
      return thisType;
    if (thisType.BaseType != null)
      return GetTypeWithBaseOf(thisType.BaseType, baseType);
    return null;
  }

  private bool GenerateNotImplementedPropAccessors(PropInfo prop, IndentedTextWriter writer)
  {
    writer.WriteLine($"  get => throw new NotImplementedException(\"Method not implemented\");");
    if (!prop.IsReadonly)
      writer.WriteLine($"  set => throw new NotImplementedException(\"Method not implemented\");");
    return true;
  }

  private bool GenerateAutoPropAccessors(PropInfo prop, IndentedTextWriter writer)
  {
    writer.WriteLine($"  get;set;");
    return true;
  }

  private bool GenerateDirectPropAccessors(PropInfo prop,
    TypeInfo targetPropType,
    IndentedTextWriter writer)
  {
    var propertyInfo = prop.PropertyInfo;
    if (propertyInfo == null)
      return false;
    var origPropName = prop.Name;
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    writer.WriteLine($"  get => ({targetPropTypeName}?)OpenXmlElement?.{origPropName};");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    if (propertyInfo.SetMethod?.IsAssembly != true
        || propertyInfo.SetMethod?.IsFamilyAndAssembly != true
        || propertyInfo.SetMethod?.IsFamilyOrAssembly != true)
      // if method is internal, protected or internal protected
      writer.WriteLine($"      typeof({propertyInfo.DeclaringType?.FullName})" +
                       $".GetProperty(\"{origPropName}\")?.SetValue(OpenXmlElement, ({origTargetTypeName}?)value);");
    else
      writer.WriteLine($"      OpenXmlElement.{origPropName} = ({origTargetTypeName}?)value;");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateSimpleValuePropAccessors(PropInfo prop,
    TypeInfo targetPropType,
    IndentedTextWriter writer)
  {
    var origPropName = prop.Name;
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    writer.WriteLine($"  get => ({targetPropTypeName}?)OpenXmlElement?.{origPropName}?.Value;");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"      OpenXmlElement.{origPropName} = ({origTargetTypeName}?)value;");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateBinaryValuePropAccessors(PropInfo prop,
  TypeInfo targetPropType,
  IndentedTextWriter writer)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement?.{origPropName}?.Value != null)");
    writer.WriteLine($"      return ({targetPropTypeName})OpenXmlElement.{origPropName}.Value;");
    writer.WriteLine($"    return null;");
    writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      if (value != null)");
    writer.WriteLine($"        OpenXmlElement.{origPropName} = new {origPropTypeName}{{ Value = value.ToString() }};");
    writer.WriteLine($"      else");
    writer.WriteLine($"        OpenXmlElement.{origPropName} = null;");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateBinaryValPropAccessors(PropInfo prop,
    TypeInfo targetPropType,
    IndentedTextWriter writer)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement?.{origPropName}?.Val?.Value != null)");
    writer.WriteLine($"      return ({targetPropTypeName})OpenXmlElement.{origPropName}.Val.Value;");
    writer.WriteLine($"    return null;");
    writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      if (value != null)");
    writer.WriteLine($"        OpenXmlElement.{origPropName} = new {origPropTypeName}{{ Val = value.ToString() }};");
    writer.WriteLine($"      else");
    writer.WriteLine($"        OpenXmlElement.{origPropName} = null;");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateBinaryValueDirectPropAccessors(PropInfo prop,
    TypeInfo targetPropType,
    IndentedTextWriter writer)
  {
    var origPropName = prop.Name;
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var item = OpenXmlElement?.{origPropName};");
    writer.WriteLine($"      if (item != null)");
    writer.WriteLine($"        return new {targetPropTypeName}Impl(item);");
    writer.WriteLine($"    }}");
    writer.WriteLine($"    return null;");
    writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"      OpenXmlElement.{origPropName} = value?.Value;");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateBinaryValueIncludedPropAccessors(PropInfo prop,
  TypeInfo targetPropType,
  IndentedTextWriter writer)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    writer.WriteLine($"      if (item?.Val?.Value != null)");
    writer.WriteLine($"        return ({targetPropTypeName})(string)(item.Val.Value);");
    writer.WriteLine($"    }}");
    writer.WriteLine($"    return null;");
    writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    writer.WriteLine($"      if (item != null)");
    writer.WriteLine($"        item.Remove();");
    writer.WriteLine($"      if (value != null)");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        item = new {origPropTypeName} {{ Val = value.ToString() }};");
    writer.WriteLine($"        OpenXmlElement.AddChild(item);");
    writer.WriteLine($"      }}");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateCorePropertiesPropAccessors(PropInfo prop,
  TypeInfo targetPropType,
  IndentedTextWriter writer)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
      writer.WriteLine($"  get => OpenXmlElement?.{origPropName};");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"      OpenXmlElement.{origPropName} = value;");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateObjectValuePropAccessors(PropInfo prop,
    TypeInfo targetPropType,
    IndentedTextWriter writer)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    if (targetPropType.Type == typeof(DocumentModel.HexWord))
      origTargetTypeName = "string";
    if (prop.PropertyType.Type.HasProperty("Val"))
      writer.WriteLine($"  get => ({targetPropTypeName}?)OpenXmlElement?.{origPropName}?.Val?.Value;");
    else if (prop.PropertyType.Type.HasProperty("Text"))
      writer.WriteLine($"  get => ({targetPropTypeName}?)OpenXmlElement?.{origPropName}?.Text;");
    else
      writer.WriteLine($"  get => ({targetPropTypeName}?)OpenXmlElement?.{origPropName}?.InnerText;");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      if (OpenXmlElement.{origPropName} != null)");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value is not null)");
    if (prop.PropertyType.Type.HasProperty("Val"))
      writer.WriteLine($"          OpenXmlElement.{origPropName}.Val = ({origTargetTypeName}?)value;");
    else if (prop.PropertyType.Type.HasProperty("Text"))
      writer.WriteLine($"          OpenXmlElement.{origPropName}.Text = value;");
    else
      writer.WriteLine($"          OpenXmlElement.{origPropName} = new (value);");
    writer.WriteLine($"        else");
    writer.WriteLine($"          OpenXmlElement.{origPropName} = null;");
    writer.WriteLine($"      }}");
    writer.WriteLine($"      else");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value is not null)");
    if (prop.PropertyType.Type.HasProperty("Val"))
      writer.WriteLine($"          OpenXmlElement.{origPropName} = new {origPropTypeName}{{ Val = ({origTargetTypeName}?)value }};");
    else if (prop.PropertyType.Type.HasProperty("Text"))
      writer.WriteLine($"          OpenXmlElement.{origPropName} = new {origPropTypeName}{{ Text = value }};");
    else
      writer.WriteLine($"          OpenXmlElement.{origPropName} = new {origPropTypeName}(value);");
    writer.WriteLine($"      }}");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GeneratePartTypePropAccessors(PropInfo prop,
    TypeInfo targetPropType,
    IndentedTextWriter writer)
  {
    var origPropName = prop.Name;
    //var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    //var origTargetTypeName = targetPropType.GetFullName(true);
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement?.{origPropName} != null)");
    writer.WriteLine($"      return new {targetPropTypeName}Impl(OpenXmlElement.{origPropName});");
    writer.WriteLine($"    return null;");
    writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"      if (value is {targetPropTypeName}Impl valueImpl)");
    writer.WriteLine($"        if (valueImpl.OpenXmlElement != null)");
    if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Packaging.DataPartReferenceRelationship)) == true)
      writer.WriteLine($"            OpenXmlElement.SetDataPart(valueImpl.OpenXmlElement);");
    else
    if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OpenXmlPartRootElement)) == true)
      writer.WriteLine($"            OpenXmlElement.SetPart(valueImpl.OpenXmlElement);");
    else
      writer.WriteLine($"            OpenXmlElement.{origPropName} = valueImpl.OpenXmlElement;");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateObjectComplexPropAccessors(PropInfo prop,
  TypeInfo targetPropType,
  IndentedTextWriter writer)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement?.{origPropName} != null)");
    writer.WriteLine($"      return new {targetPropTypeName}Impl(OpenXmlElement.{origPropName});");
    writer.WriteLine($"    return null;");
    writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    if (value is {targetPropTypeName}Impl valueImpl)");
    writer.WriteLine($"      if (valueImpl.OpenXmlElement != null)");
    writer.WriteLine($"          OpenXmlElement.{origPropName} = valueImpl.OpenXmlElement;");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateListValuePropAccessors(PropInfo prop,
    TypeInfo targetPropType,
    IndentedTextWriter writer)
  {
    var propName = prop.Name;
    var propBaseType = (prop.PropertyType.IsConstructedGenericType)
      ? prop.PropertyType.GetGenericArgTypes().FirstOrDefault()
      : prop.PropertyType.GetGenericParamTypes().FirstOrDefault();
    if (propBaseType == null)
      return false;
    var targetPropBaseType = propBaseType.GetConversionTarget(true);
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropBaseTypeName = propBaseType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    var targetListBaseType = targetPropType.GetGenericArgTypes().First();
    var origTargetListBaseTypeName = targetListBaseType.GetFullName(true);
    string? castBaseTypeName = null;
    var origPropBaseTypeNameName = origPropBaseTypeName.ToString();
    int k = origPropBaseTypeNameName.IndexOf("Values");
    if (k>0)
    {
      var i = origPropBaseTypeNameName.LastIndexOf('<', k);
      var j = origPropBaseTypeNameName.IndexOf('>', k);
      if (i>0 && j>0)
        castBaseTypeName = origPropBaseTypeNameName.Substring(i+1, j-i-1);
    }
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement?.{propName} != null)");
    writer.WriteLine($"      return new {targetPropTypeName}(OpenXmlElement.{propName}.InnerText);");
    writer.WriteLine($"    return null;");
    writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      if (value?.Items.Any() == true)");
    if (castBaseTypeName!=null)
      writer.WriteLine($"        OpenXmlElement.{propName} = new {origPropTypeName}" +
                       $"(value.Items.Select(item => new {origPropBaseTypeName}(({castBaseTypeName})item)));");
    else
      writer.WriteLine($"        OpenXmlElement.{propName} = new {origPropTypeName}" +
                       $"(value.Items.Select(item => new {origPropBaseTypeName}(item)));");
    writer.WriteLine($"  else");
    writer.WriteLine($"    OpenXmlElement.{propName} = null;");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateVariantIncludedPropAccessors(PropInfo prop,
    TypeInfo targetPropType,
    IndentedTextWriter writer)
  {
    var origPropName = prop.Name;
    var origPropTypeName = "DocumentFormat.OpenXml.VariantTypes." + origPropName;
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    writer.WriteLine($"      if (item != null)");
    writer.WriteLine($"        return new {targetPropTypeName}Impl(item);");
    writer.WriteLine($"    }}");
    writer.WriteLine($"    return null;");
    writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    writer.WriteLine($"      if (item != null)");
    writer.WriteLine($"        item.Remove();");
    writer.WriteLine($"      if (value != null)");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        var newItem = (value as {targetPropTypeName}Impl)?.OpenXmlElement;");
    writer.WriteLine($"        if (newItem != null)");
    writer.WriteLine($"          OpenXmlElement.AddChild(newItem);");
    writer.WriteLine($"      }}");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateIncludedValueElementPropAccessors(PropInfo prop,
    TypeInfo targetPropType,
    IndentedTextWriter writer)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    writer.WriteLine($"      return ({targetPropTypeName}?)item?.Val?.Value;");
    writer.WriteLine($"    }}");
    writer.WriteLine($"    return null;");
    writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    writer.WriteLine($"      if (item != null)");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value is not null)");
    writer.WriteLine($"          item.Val = ({origTargetTypeName}?)value;");
    writer.WriteLine($"        else");
    writer.WriteLine($"          item.Remove();");
    writer.WriteLine($"      }}");
    writer.WriteLine($"      else");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value is not null)");
    writer.WriteLine($"        {{");
    writer.WriteLine($"          item = new {origPropTypeName}{{ Val = ({origTargetTypeName}?)value }};");
    writer.WriteLine($"          OpenXmlElement.AddChild(item);");
    writer.WriteLine($"        }}");
    writer.WriteLine($"      }}");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateIncludedObjectElementPropAccessors(PropInfo prop,
    TypeInfo targetPropType,
    IndentedTextWriter writer)
  {
    //var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origTargetTypeName}>();");
    writer.WriteLine($"      if (item != null)");
    writer.WriteLine($"        return new {targetPropTypeName}Impl(item);");
    writer.WriteLine($"    }}");
    writer.WriteLine($"    return null;");
    writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origTargetTypeName}>();");
    writer.WriteLine($"      if (item != null)");
    writer.WriteLine($"        item.Remove();");
    writer.WriteLine($"      if (value is not null)");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        item = (value as {targetPropTypeName}Impl)?.OpenXmlElement;");
    writer.WriteLine($"        if (item != null)");
    writer.WriteLine($"          OpenXmlElement.AddChild(item);");
    writer.WriteLine($"      }}");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateCollectionTypeAccessors(PropInfo prop,
    TypeInfo propItemType,
    IndentedTextWriter writer)
  {
    if (prop.DeclaringType?.Name == "OpenXmlPartContainer")
      return GenerateOpenXmlPartContainerItemsCollectionTypeAccessors(prop, propItemType, writer);
    
    if (propItemType.Name=="DataPart")
      return GeneratePartCollectionTypeAccessors(prop, propItemType, writer);

    if (propItemType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPart)))
        return GeneratePartCollectionTypeAccessors(prop, propItemType, writer);
    
    return GenerateElementCollectionTypeAccessors(prop, propItemType, writer);
  }

  private bool GenerateOpenXmlPartContainerItemsCollectionTypeAccessors(PropInfo prop,
    TypeInfo propItemType,
    IndentedTextWriter writer)
  {
    AddGlobalUsing("System.Linq");

    TypeInfo targetItemType = propItemType.GetConversionTarget(true);
    string propItemTypeName = targetItemType.GetFullName();
    string origItemTypeName = propItemType.GetFullName(true);
    var propName = prop.Name;
    var fieldName = "_" + propName;
    string itemTypeName = TypeReflector.SingularizeName(propName);
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if ({fieldName} == null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      if (OpenXmlElement != null)");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        var items = OpenXmlElement.{propName}");
    writer.WriteLine($"          .Select(item => new {propItemTypeName}Impl(item)).ToList();");
    writer.WriteLine($"        {fieldName} = new ObservableCollection<{propItemTypeName}>(items);");
    writer.WriteLine($"      }}");
    writer.WriteLine($"      else");
    writer.WriteLine($"        {fieldName} = new ObservableCollection<{propItemTypeName}>();");
    writer.WriteLine($"      {fieldName}.CollectionChanged += {fieldName}_CollectionChanged;");
    writer.WriteLine($"    }}");
    writer.WriteLine($"    return {fieldName};");
    writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (value != null && value != {fieldName} && OpenXmlElement!=null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      foreach (var val in value)");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (val is {propItemTypeName}Impl valImpl)");
    writer.WriteLine($"        {{");
    writer.WriteLine($"          var item = valImpl.OpenXmlElement;");
    writer.WriteLine($"          if (item != null)");
    writer.WriteLine($"            if (!OpenXmlElement.{propName}.Contains(item))");
    if (itemTypeName == "Part")
      writer.WriteLine($"              OpenXmlElement.AddPart(item.OpenXmlPart, item.RelationshipId);");
    else
    if (itemTypeName.Contains("Hyperlink"))
      writer.WriteLine($"              OpenXmlElement.Add{itemTypeName}(item.Uri, item.IsExternal, item.Id);");
    else
    if (itemTypeName.Contains("DataPart"))
      writer.WriteLine($"              OpenXmlElement.Add{itemTypeName}(item);");
    else
      writer.WriteLine($"              OpenXmlElement.Add{itemTypeName}(item.RelationshipType, item.Uri, item.Id);");
    writer.WriteLine($"        }};");
    writer.WriteLine($"      }}");
    writer.WriteLine($"    }}");
    writer.WriteLine($"    if (value is ObservableCollection<{propItemTypeName}> observableCollection)");
    writer.WriteLine($"      {fieldName} = observableCollection;");
    writer.WriteLine($"    else if (value != null)");
    writer.WriteLine($"      {fieldName} = new ObservableCollection<{propItemTypeName}>(value);");
    writer.WriteLine($"    else");
    writer.WriteLine($"     {fieldName} = null;");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GeneratePartCollectionTypeAccessors(PropInfo prop,
    TypeInfo propItemType,
    IndentedTextWriter writer)
  {
    AddGlobalUsing("System.Linq");

    TypeInfo targetItemType = propItemType.GetConversionTarget(true);
    string propItemTypeName = targetItemType.GetFullName();
    string origItemTypeName = propItemType.GetFullName(true);
    var propName = prop.Name;
    var fieldName = "_" + propName;
    string itemTypeName = TypeReflector.SingularizeName(propName);
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if ({fieldName} == null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      if (OpenXmlElement != null)");
    writer.WriteLine($"      {{");
    if (itemTypeName == "DataPart")
      writer.WriteLine($"        var items = OpenXmlElement.DataParts");
    else
      writer.WriteLine($"        var items = OpenXmlElement.GetPartsOfType<{origItemTypeName}>()");
    writer.WriteLine($"          .Select(item => new {propItemTypeName}Impl(item)).ToList();");
    writer.WriteLine($"        {fieldName} = new ObservableCollection<{propItemTypeName}>(items);");
    writer.WriteLine($"      }}");
    writer.WriteLine($"      else");
    writer.WriteLine($"        {fieldName} = new ObservableCollection<{propItemTypeName}>();");
    writer.WriteLine($"      {fieldName}.CollectionChanged += {fieldName}_CollectionChanged;");
    writer.WriteLine($"    }}");
    writer.WriteLine($"    return {fieldName};");
    writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (value != null && value != {fieldName} && OpenXmlElement!=null)");
    writer.WriteLine($"    {{");
    if (itemTypeName=="DataPart")
      writer.WriteLine($"      foreach (var item in OpenXmlElement.DataParts.ToArray())");
    else
      writer.WriteLine($"      foreach (var item in OpenXmlElement.GetPartsOfType<{origItemTypeName}>().ToArray())");
    writer.WriteLine($"        OpenXmlElement.DeletePart(item);");
    writer.WriteLine($"      foreach (var val in value)");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (val is {propItemTypeName}Impl valImpl)");
    writer.WriteLine($"        {{");
    writer.WriteLine($"          var item = valImpl.OpenXmlElement;");
    writer.WriteLine($"          if (item != null)");
    if (itemTypeName == "DataPart")
      writer.WriteLine($"            OpenXmlElement.AddDataPartToList(item);");
    else
      writer.WriteLine($"            OpenXmlElement.AddPart(item);");
    writer.WriteLine($"        }};");
    writer.WriteLine($"      }}");
    writer.WriteLine($"    }}");
    writer.WriteLine($"    if (value is ObservableCollection<{propItemTypeName}> observableCollection)");
    writer.WriteLine($"      {fieldName} = observableCollection;");
    writer.WriteLine($"    else if (value != null)");
    writer.WriteLine($"      {fieldName} = new ObservableCollection<{propItemTypeName}>(value);");
    writer.WriteLine($"    else");
    writer.WriteLine($"     {fieldName} = null;");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateElementCollectionTypeAccessors(PropInfo prop,
  TypeInfo propItemType,
  IndentedTextWriter writer)
  {
    AddGlobalUsing("System.Linq");

    TypeInfo targetItemType = propItemType.GetConversionTarget(true);
    string propItemTypeName = targetItemType.GetFullName();
    string origItemTypeName = propItemType.GetFullName(true);
    var propName = prop.Name;
    var fieldName = "_" + propName;
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if ({fieldName} == null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      if (OpenXmlElement != null)");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        var items = OpenXmlElement.Elements<{origItemTypeName}>()");
    if (targetItemType.Type == typeof(DocumentModel.HexWord))
      writer.WriteLine($"          .Select(item => new {propItemTypeName}(item.Val?.Value ?? \"0000\")).ToList();");
    else if (targetItemType.Type == typeof(string))
    {
      if (propItemType.Type.HasProperty("Val"))
        writer.WriteLine($"          .Select(item => item.Val?.Value ?? \"\").ToList();");
      else
        writer.WriteLine($"          .Select(item => item.Text).ToList();");
    }
    else if (targetItemType.Type.IsValueType)
      writer.WriteLine($"          .Select(item => item.Val?.Value ?? default).ToList();");
    else
      writer.WriteLine($"          .Select(item => new {propItemTypeName}Impl(item)).ToList();");
    writer.WriteLine($"        {fieldName} = new ObservableCollection<{propItemTypeName}>(items);");
    writer.WriteLine($"      }}");
    writer.WriteLine($"      else");
    writer.WriteLine($"        {fieldName} = new ObservableCollection<{propItemTypeName}>();");
    writer.WriteLine($"      {fieldName}.CollectionChanged += {fieldName}_CollectionChanged;");
    writer.WriteLine($"    }}");
    writer.WriteLine($"    return {fieldName};");
    writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (value != null && value != {fieldName} && OpenXmlElement!=null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      OpenXmlElement.RemoveAllChildren<{origItemTypeName}>();");
    writer.WriteLine($"      foreach (var val in value)");
    writer.WriteLine($"      {{");
    if (targetItemType.Type == typeof(DocumentModel.HexWord))
    {
      writer.WriteLine($"        var item = new {origItemTypeName}{{ Val = (string?)val }};");
      writer.WriteLine($"        OpenXmlElement.AddChild(item);");
    }
    else if (targetItemType.Type == typeof(string))
    {
      writer.WriteLine($"        if (val is string str)");
      writer.WriteLine($"        {{");
      if (propItemType.Type.HasProperty("Val"))
        writer.WriteLine($"          var item = new {origItemTypeName}{{ Val = str }};");
      else
        writer.WriteLine($"          var item = new {origItemTypeName}{{ Text = str }};");
      writer.WriteLine($"          OpenXmlElement.AddChild(item);");
      writer.WriteLine($"        }};");
    }
    else if (targetItemType.Type.IsValueType)
    {
      writer.WriteLine($"        var item = new {origItemTypeName}{{ Val = val }};");
      writer.WriteLine($"        OpenXmlElement.AddChild(item);");
    }
    else
    {
      writer.WriteLine($"        if (val is {propItemTypeName}Impl valImpl)");
      writer.WriteLine($"        {{");
      writer.WriteLine($"          var item = valImpl.OpenXmlElement;");
      writer.WriteLine($"          if (item != null)");
      writer.WriteLine($"            OpenXmlElement.AddChild(item);");
      writer.WriteLine($"        }};");
    }
    writer.WriteLine($"      }}");
    writer.WriteLine($"    }}");
    writer.WriteLine($"    if (value is ObservableCollection<{propItemTypeName}> observableCollection)");
    writer.WriteLine($"      {fieldName} = observableCollection;");
    writer.WriteLine($"    else if (value != null)");
    writer.WriteLine($"      {fieldName} = new ObservableCollection<{propItemTypeName}>(value);");
    writer.WriteLine($"    else");
    writer.WriteLine($"     {fieldName} = null;");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateCollectionField(PropInfo prop,
    TypeInfo propItemType,
    IndentedTextWriter writer)
  {
    if (prop.DeclaringType?.Name == "OpenXmlPartContainer")
      return GenerateOpenXmlContainerItemsCollectionField(prop, propItemType, writer);

    if (propItemType.Name=="DataPart")
      return GeneratePartCollectionField(prop, propItemType, writer);

    if (propItemType.Type.IsSubclassOf(typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPart)))
      return GeneratePartCollectionField(prop, propItemType, writer);

    return GenerateElementCollectionField(prop, propItemType, writer);
  }

  private bool GenerateOpenXmlContainerItemsCollectionField(PropInfo prop,
    TypeInfo propItemType,
    IndentedTextWriter writer)
  {
    AddGlobalUsing("System.Collections.Specialized");
    
    TypeInfo targetItemType = propItemType.GetConversionTarget(true);
    string propItemTypeName = targetItemType.GetFullName();
    string origItemTypeName = propItemType.GetFullName(true);
    var propName = prop.Name;
    var fieldName = "_" + propName;
    string itemTypeName = TypeReflector.SingularizeName(propName);
    writer.WriteLine($"private ObservableCollection<{propItemTypeName}>? {fieldName};");
    writer.WriteLine();
    writer.WriteLine($"private void {fieldName}_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)");
    writer.WriteLine($"{{");
    writer.WriteLine($"  if (OpenXmlElement != null)");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    switch (args.Action)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      case NotifyCollectionChangedAction.Reset:");
    writer.WriteLine($"        foreach (var item in OpenXmlElement.{propName}.ToArray())");
    if (itemTypeName == "Part")
      writer.WriteLine($"          OpenXmlElement.DeletePart(item.RelationshipId);");
    else
      writer.WriteLine($"          OpenXmlElement.DeleteReferenceRelationship(item);");
    writer.WriteLine($"        break;");
    writer.WriteLine($"      case NotifyCollectionChangedAction.Add:");
    writer.WriteLine($"        if (args.NewItems != null)");
    writer.WriteLine($"        foreach (var val in args.NewItems)");
    writer.WriteLine($"        {{");
    writer.WriteLine($"          if (val is {propItemTypeName}Impl valImpl)");
    writer.WriteLine($"          {{");
    writer.WriteLine($"            var item = valImpl.OpenXmlElement;");
    writer.WriteLine($"            if (item != null)");
    if (itemTypeName == "Part")
      writer.WriteLine($"            OpenXmlElement.AddPart(item.OpenXmlPart, item.RelationshipId);");
    else
    if (itemTypeName.Contains("Hyperlink"))
      writer.WriteLine($"              OpenXmlElement.Add{itemTypeName}(item.Uri, item.IsExternal, item.Id);");
    else
    if (itemTypeName.Contains("DataPart"))
      writer.WriteLine($"              OpenXmlElement.Add{itemTypeName}(item);");
    else
      writer.WriteLine($"              OpenXmlElement.Add{itemTypeName}(item.RelationshipType, item.Uri, item.Id);");
    writer.WriteLine($"          }};");
    writer.WriteLine($"        }}");
    writer.WriteLine($"        break;");
    writer.WriteLine($"      case NotifyCollectionChangedAction.Remove:");
    writer.WriteLine($"        if (args.OldItems != null)");
    writer.WriteLine($"        foreach (var val in args.OldItems)");
    writer.WriteLine($"        {{");
    writer.WriteLine($"          if (val is {propItemTypeName}Impl valImpl)");
    writer.WriteLine($"          {{");
    writer.WriteLine($"              if (valImpl.OpenXmlElement is {origItemTypeName} oldItem)");
    if (itemTypeName == "Part")
      writer.WriteLine($"                OpenXmlElement.DeletePart(oldItem.RelationshipId);");
    else
      writer.WriteLine($"                OpenXmlElement.DeleteReferenceRelationship(oldItem);");
    writer.WriteLine($"          }};");
    writer.WriteLine($"        }}");
    writer.WriteLine($"        break;");
    writer.WriteLine($"      default:");
    writer.WriteLine($"        break;");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
    writer.WriteLine($"}}");
    writer.WriteLine();
    return true;
  }

  private bool GeneratePartCollectionField(PropInfo prop,
    TypeInfo propItemType,
   IndentedTextWriter writer)
  {
    AddGlobalUsing("System.Collections.Specialized");
    
    TypeInfo targetItemType = propItemType.GetConversionTarget(true);
    string propItemTypeName = targetItemType.GetFullName();
    string origItemTypeName = propItemType.GetFullName(true);
    var propName = prop.Name;
    var fieldName = "_" + propName;
    string itemTypeName = TypeReflector.SingularizeName(propName);
    writer.WriteLine($"private ObservableCollection<{propItemTypeName}>? {fieldName};");
    writer.WriteLine();
    writer.WriteLine($"private void {fieldName}_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)");
    writer.WriteLine($"{{");
    writer.WriteLine($"  if (OpenXmlElement != null)");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    switch (args.Action)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      case NotifyCollectionChangedAction.Reset:");
    if (itemTypeName=="DataPart")
      writer.WriteLine($"        foreach (var item in OpenXmlElement.DataParts.ToArray())");
    else
      writer.WriteLine($"        foreach (var item in OpenXmlElement.GetPartsOfType<{origItemTypeName}>().ToArray())");
    writer.WriteLine($"          OpenXmlElement.DeletePart(item);");
    writer.WriteLine($"        break;");
    writer.WriteLine($"      case NotifyCollectionChangedAction.Add:");
    writer.WriteLine($"        if (args.NewItems != null)");
    writer.WriteLine($"        foreach (var val in args.NewItems)");
    writer.WriteLine($"        {{");
    writer.WriteLine($"          if (val is {propItemTypeName}Impl valImpl)");
    writer.WriteLine($"          {{");
    writer.WriteLine($"            var item = valImpl.OpenXmlElement;");
    writer.WriteLine($"            if (item != null)");
    if (itemTypeName=="DataPart")
      writer.WriteLine($"              OpenXmlElement.AddDataPartToList(item);");
    else
      writer.WriteLine($"              OpenXmlElement.AddPart(item);");
    writer.WriteLine($"          }};");
    writer.WriteLine($"        }}");
    writer.WriteLine($"        break;");
    writer.WriteLine($"      case NotifyCollectionChangedAction.Remove:");
    writer.WriteLine($"        if (args.OldItems != null)");
    writer.WriteLine($"        foreach (var val in args.OldItems)");
    writer.WriteLine($"        {{");
    writer.WriteLine($"            if (val is {propItemTypeName}Impl valImpl)");
    writer.WriteLine($"            {{");
    if (itemTypeName=="DataPart")
      writer.WriteLine($"                var oldItem = OpenXmlElement.DataParts");
    else
      writer.WriteLine($"                var oldItem = OpenXmlElement.GetPartsOfType<{origItemTypeName}>()");
    writer.WriteLine($"                              .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);");
    writer.WriteLine($"               if (oldItem != null)");
    writer.WriteLine($"                  OpenXmlElement.DeletePart(oldItem);");
    writer.WriteLine($"           }};");
    writer.WriteLine($"        }}");
    writer.WriteLine($"        break;");
    writer.WriteLine($"      default:");
    writer.WriteLine($"        break;");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
    writer.WriteLine($"}}");
    writer.WriteLine();
    return true;
  }
  private bool GenerateElementCollectionField(PropInfo prop,
    TypeInfo propItemType,
   IndentedTextWriter writer)
  {
    AddGlobalUsing("System.Collections.Specialized");

    TypeInfo targetItemType = propItemType.GetConversionTarget(true);
    string propItemTypeName = targetItemType.GetFullName();
    string origItemTypeName = propItemType.GetFullName(true);
    var propName = prop.Name;
    var fieldName = "_" + propName;
    writer.WriteLine($"private ObservableCollection<{propItemTypeName}>? {fieldName};");
    writer.WriteLine();
    writer.WriteLine($"private void {fieldName}_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)");
    writer.WriteLine($"{{");
    writer.WriteLine($"  if (OpenXmlElement != null)");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    switch (args.Action)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      case NotifyCollectionChangedAction.Reset:");
    writer.WriteLine($"        OpenXmlElement.RemoveAllChildren<{origItemTypeName}>();");
    writer.WriteLine($"        break;");
    writer.WriteLine($"      case NotifyCollectionChangedAction.Add:");
    writer.WriteLine($"        if (args.NewItems != null)");
    writer.WriteLine($"        foreach (var val in args.NewItems)");
    writer.WriteLine($"        {{");
    if (targetItemType.Type == typeof(DocumentModel.HexWord))
    {
      writer.WriteLine($"          var newItem = new {origItemTypeName} {{ Val = (string?)val }};");
      writer.WriteLine($"          OpenXmlElement.AddChild(newItem);");
    }
    else if (targetItemType.Type == typeof(string))
    {
      writer.WriteLine($"        if (val is string str)");
      writer.WriteLine($"        {{");
      if (propItemType.Type.HasProperty("Val"))
        writer.WriteLine($"          var newItem = new {origItemTypeName}{{ Val = str }};");
      else
        writer.WriteLine($"          var newItem = new {origItemTypeName} {{ Text = str }};");
      writer.WriteLine($"          OpenXmlElement.AddChild(newItem);");
      writer.WriteLine($"        }};");
    }
    else if (targetItemType.Type.IsValueType)
    {
      var valProperty = propItemType.Type.GetProperty("Val");
      if (valProperty != null && TryGetSimpleType(valProperty.PropertyType, out var simpleType) && simpleType != null)
        writer.WriteLine($"          var newItem = new {origItemTypeName} {{ Val = ({simpleType.Name})val }};");
      else
        writer.WriteLine($"          var newItem = new {origItemTypeName} {{ Val = val }};");
      writer.WriteLine($"          OpenXmlElement.AddChild(newItem);");
    }
    else
    {
      writer.WriteLine($"          if (val is {propItemTypeName}Impl valImpl)");
      writer.WriteLine($"          {{");
      writer.WriteLine($"            var item = valImpl.OpenXmlElement;");
      writer.WriteLine($"            if (item != null)");
      writer.WriteLine($"              OpenXmlElement.AddChild(item);");
      writer.WriteLine($"          }};");
    }
    writer.WriteLine($"        }}");
    writer.WriteLine($"        break;");
    writer.WriteLine($"      case NotifyCollectionChangedAction.Remove:");
    writer.WriteLine($"        if (args.OldItems != null)");
    writer.WriteLine($"        foreach (var val in args.OldItems)");
    writer.WriteLine($"        {{");
    if (targetItemType.Type == typeof(DocumentModel.HexWord))
    {
      writer.WriteLine($"          var oldItem = OpenXmlElement.Elements<{origItemTypeName}>()");
      writer.WriteLine($"                        .FirstOrDefault(anItem => anItem.Val == (string?)val);");
      writer.WriteLine($"          if (oldItem != null)");
      writer.WriteLine($"            oldItem.Remove();");
    }
    else if (targetItemType.Type == typeof(string))
    {
      writer.WriteLine($"      if (val is string str)");
      writer.WriteLine($"      {{");
      writer.WriteLine($"          var oldItem = OpenXmlElement.Elements<{origItemTypeName}>()");
      if (propItemType.Type.HasProperty("Val"))
        writer.WriteLine($"                        .FirstOrDefault(anItem => anItem.Val == str);");
      else
        writer.WriteLine($"                        .FirstOrDefault(anItem => anItem.Text == str);");
      writer.WriteLine($"          if (oldItem != null)");
      writer.WriteLine($"            oldItem.Remove();");
      writer.WriteLine($"      }};");
    }
    else if (targetItemType.Type.IsValueType)
    {
      writer.WriteLine($"          var oldItem = OpenXmlElement.Elements<{origItemTypeName}>()");
      var valProperty = propItemType.Type.GetProperty("Val");
      if (valProperty != null && TryGetSimpleType(valProperty.PropertyType, out var simpleType) && simpleType != null)
        writer.WriteLine($"                        .FirstOrDefault(anItem => anItem.Val?.Value == ({simpleType.Name})val);");
      else
        writer.WriteLine($"                        .FirstOrDefault(anItem => anItem.Val == val);");
      writer.WriteLine($"          if (oldItem != null)");
      writer.WriteLine($"            oldItem.Remove();");
    }
    else
    {
      writer.WriteLine($"            if (val is {propItemTypeName}Impl valImpl)");
      writer.WriteLine($"            {{");
      writer.WriteLine($"                var oldItem = OpenXmlElement.Elements<{origItemTypeName}>()");
      writer.WriteLine($"                              .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);");
      writer.WriteLine($"               if (oldItem != null)");
      writer.WriteLine($"                  oldItem.Remove();");
      writer.WriteLine($"           }};");
    }
    writer.WriteLine($"        }}");
    writer.WriteLine($"        break;");
    writer.WriteLine($"      default:");
    writer.WriteLine($"        break;");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
    writer.WriteLine($"}}");
    writer.WriteLine();
    return true;
  }

  private bool TryGetSimpleType(Type type, out Type? simpleType)
  {
    var baseType = GetTypeWithBaseOf(type, typeof(OpenXmlComparableSimpleValue<>));
    if (baseType != null)
    {
      baseType = baseType.BaseType;
      if (baseType != null && baseType.IsConstructedGenericType)
      {
        var argType = baseType.GetGenericArguments().FirstOrDefault();
        if (argType != null && (argType.IsValueType || argType == typeof(string)))
        {
          simpleType = argType;
          return true;
        }
      }
    }
    simpleType = null;
    return false;
  }
  private bool GenerateIncludedStringPropAccessors(PropInfo prop, IndentedTextWriter writer)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var openXmlElement = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    writer.WriteLine($"      return openXmlElement?.Text;");
    writer.WriteLine($"    }}");
    writer.WriteLine($"    return null;");
    writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    writer.WriteLine($"      if (item != null)");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value is not null)");
    writer.WriteLine($"          item.Text = value;");
    writer.WriteLine($"        else");
    writer.WriteLine($"          item.Remove();");
    writer.WriteLine($"      }}");
    writer.WriteLine($"      else");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value is not null)");
    writer.WriteLine($"        {{");
    writer.WriteLine($"          item = new {origPropTypeName}{{ Text = value }};");
    writer.WriteLine($"          OpenXmlElement.AddChild(item);");
    writer.WriteLine($"        }}");
    writer.WriteLine($"      }}");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateIncludedBooleanPropAccessors(PropInfo prop, IndentedTextWriter writer)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    writer.WriteLine($"  get");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    writer.WriteLine($"      return item != null;");
    writer.WriteLine($"    }}");
    writer.WriteLine($"    return null;");
    writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    writer.WriteLine($"  set");
    writer.WriteLine($"  {{");
    writer.WriteLine($"    if (OpenXmlElement != null)");
    writer.WriteLine($"    {{");
    writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    writer.WriteLine($"      if (item != null)");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value == false)");
    writer.WriteLine($"          item.Remove();");
    writer.WriteLine($"      }}");
    writer.WriteLine($"      else");
    writer.WriteLine($"      {{");
    writer.WriteLine($"        if (value == true)");
    writer.WriteLine($"        {{");
    writer.WriteLine($"          item = new {origPropTypeName}();");
    writer.WriteLine($"          OpenXmlElement.AddChild(item);");
    writer.WriteLine($"        }}");
    writer.WriteLine($"      }}");
    writer.WriteLine($"    }}");
    writer.WriteLine($"  }}");
    return true;
  }

  private bool GeneratePackagePropAccessors(PropInfo prop, IndentedTextWriter writer)
  {
    writer.WriteLine($"  get => OpenXmlElement?.{prop.Name};");
    return true;
  }


  #endregion

  #region Enum types generation
  private bool GenerateEnumType(TypeInfo type)
  {
    var outputPath = IntfOutputPath;
    var aNamespace = type.Namespace;
    outputPath = Path.Combine(outputPath, aNamespace);
    var typeName = type.Name;
    var fileName = ValidateFilename(typeName);
    if (!GenerateEnumType(type, typeName, Path.Combine(outputPath, "Enums", fileName + ".cs")))
      return false;
    GeneratedEnumTypesCount += 1;
    return true;
  }

  private bool GenerateEnumType(TypeInfo type, string typeName, string filename)
  {
    AssurePathExists(filename);
    using (var textWriter = File.CreateText(filename))
    using (var writer = new IndentedTextWriter(textWriter, "  "))
    {
      return GenerateEnumType(type, typeName, writer);
    }
  }

  private bool GenerateEnumType(TypeInfo type, string typeName, IndentedTextWriter writer)
  {
    var aNamespace = type.GetNamespace();
    if (aNamespace != null)
    {
      writer.WriteLine($"namespace {aNamespace};");
      writer.WriteLine();
    }
    GenerateDocumentationComments(type, writer);
    GenerateCustomAttributes(type.CustomAttributes, writer);
    writer.WriteLine($"public enum {typeName}");
    writer.WriteLine("{");
    writer.Indent++;
    if (type.EnumValues != null)
      foreach (var field in type.EnumValues)
        if (!GenerateEnum(field, writer))
          return false;
    writer.Indent--;
    writer.WriteLine("}");
    return true;
  }

  private bool GenerateEnum(EnumInfo field, IndentedTextWriter writer)
  {
    bool addEmptyLine = GenerateDocumentationComments(field, writer);
    if (field.CustomAttributes != null)
    {
      GenerateCustomAttributes(field.CustomAttributes, writer);
      addEmptyLine = true;
    }
    writer.WriteLine($"{field.Name},");
    if (addEmptyLine)
      writer.WriteLine();
    GeneratedEnumValuesCount += 1;
    return true;
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

  private bool GenerateDocumentationComments(TypeInfo typeInfo, IndentedTextWriter writer)
  {
    var summary = typeInfo.Summary;
    if (summary != null)
    {
      writer.WriteLine("/// <summary>");
      writer.WriteLine($"/// {summary}");
      writer.WriteLine("/// </summary>");
      return true;
    }
    return false;
  }

  private bool GenerateDocumentationComments(EnumInfo aField, IndentedTextWriter writer)
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

  private bool GenerateDocumentationComments(PropInfo aProp, IndentedTextWriter writer)
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

  public bool GenerateGlobalUsings()
  {
    var ok1 = GenerateGlobalUsings(Path.Combine(IntfOutputPath, "GlobalUsings.cs"));
    AddGlobalUsing("DocumentModel.Impl");
    AddGlobalUsing("DocumentModel.VariantTypes");
    AddGlobalUsing("System.Xml.Serialization");
    var ok2 = GenerateGlobalUsings(Path.Combine(ImplOutputPath, "GlobalUsings.cs"));
    return ok1 && ok2;
  }

  private bool GenerateGlobalUsings(string filename)
  {
    AssurePathExists(filename);
    using (var writer = File.CreateText(filename))
    {
      foreach (var item in GlobalUsings)
        writer.WriteLine($"global using {item};");
    }
    return true;
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