using System.CodeDom.Compiler;

using DocumentFormat.OpenXml;

using Namotion.Reflection;

using Qhta.TypeUtils;


namespace ModelGen;

public class ModelGenerator : BaseCodeGenerator
{
  public ModelGenerator(string projectName, string outputPath)
  {
    IntfProjectName = projectName;
    IntfOutputPath = outputPath;
    ImplProjectName = projectName + ".Impl";
    ImplOutputPath = outputPath + ".Impl";
  }
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
      Writer.Write(reader.ReadToEnd());
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
    using (Writer = new IndentedTextWriter(textWriter, "  "))
    {
      return GenerateClassOrInterface(type, typeName, kind);
    }
  }

  private bool GenerateClassOrInterface(TypeInfo typeInfo, string typeName, TypeKind kind)
  {
    var aNamespace = typeInfo.Namespace;
    if (aNamespace != null)
    {
      Writer.WriteLine($"namespace {aNamespace};");
      Writer.WriteLine();
    }

    GenerateDocumentationComments(typeInfo);
    GenerateCustomAttributes(typeInfo.CustomAttributes);

    bool newOpenXmlElementProperty = true;

    if (kind == TypeKind.Interface)
    {
      var str = $"public partial interface {typeName}";
      Writer.WriteLine(str);
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
      Writer.WriteLine(str);
    }
    else
      throw new NotImplementedException($"GenerateClassOrInterface not implemented for kind {kind}");
    Writer.WriteLine("{");
    Writer.Indent++;

    var subclasses = new List<string>();

    if (kind == TypeKind.Class)
    {
      if (!GenerateOpenXmlElementProperty(typeInfo.GetFullName(true), newOpenXmlElementProperty))
        return false;
    }
    //if (kind != TypeKind.Interface && typeInfo.ItemsConstraint != null)
    //  if (typeInfo.Name == "Rsids")
    //    GenerateItemsProperties(typeInfo, typeInfo.ItemsConstraint, typeInfo.Name, aNamespace, subclasses, TypeKind.EmbeddedClass);

    if (kind == TypeKind.Class)
    {
      GenerateClassConstructor(typeName);
      GenerateClassConstructor(typeName, typeInfo.GetFullName(true), subclasses);
    }

    var ok = GenerateAcceptedProperties(typeInfo, aNamespace, kind);
    Writer.Indent--;
    Writer.WriteLine("}");
    if (kind == TypeKind.Interface)
      GeneratedInterfacesCount += 1;
    else if (kind == TypeKind.Class)
      GeneratedClassesCount += 1;
    return ok;
  }

  private bool GenerateOpenXmlElementProperty(string origModelElementTypeName, bool newProperty)
  {
    var newPropertyStr = newProperty ? "new " : String.Empty;
    Writer.WriteLine($"[XmlIgnore]");
    Writer.WriteLine($"public {newPropertyStr}{origModelElementTypeName}? OpenXmlElement");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  get => ({origModelElementTypeName}?)_OpenXmlElement;");
    Writer.WriteLine($"  protected set => _OpenXmlElement = value;");
    Writer.WriteLine($"}}");
    Writer.WriteLine();
    return true;
  }

  private bool GenerateAcceptedProperties(TypeInfo typeInfo, string? inNamespace, TypeKind kind)
  {
    if (typeInfo.AcceptedProperties != null)
      foreach (var prop in typeInfo.AcceptedProperties)
        //if (kind == TypeKind.Interface || !prop.IsConstrained)
        if (!GenerateProperty(prop, inNamespace, kind))
          return false;
    return true;
  }

  private bool GenerateItemsProperties(TypeInfo typeInfo, ItemsConstraint constraint, string fromClassName, string? inNamespace,
    List<string> subclassesTypeNames, TypeKind kind)
  {
    if (constraint is ItemTypeConstraint itemTypeConstraint)
    {
      var prop = itemTypeConstraint.AccessProperty;
      if (prop != null)
        if (!GenerateProperty(prop, inNamespace, kind))
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
          if (!GenerateItemsProperties(typeInfo, itemConstraint, constraintClassName, inNamespace, subclassesTypeNames, TypeKind.EmbeddedClass))
            return false;
        }
      }
      else
      {
        if (!GenerateSubclass(typeInfo, itemsCompoundConstraint, constraintClassName, inNamespace, subclassesTypeNames, TypeKind.EmbeddedClass))
          return false;
      }
    }
    return true;
  }

  private bool GenerateSubclass(TypeInfo typeInfo, ItemsCompoundConstraint constraint, string constraintClassName, string? inNamespace,
    List<string> subclassesTypeNames, TypeKind kind)
  {
    var constraintsStrs = new List<string>();
    if (constraint.IsRequired)
      constraintsStrs.Add("required");
    if (constraint.IsMultiple)
      constraintsStrs.Add("multiple");
    string str = $"public class {constraintClassName}";
    if (constraintsStrs.Count > 0)
      str += " // " + String.Join(", ", constraintsStrs);
    Writer.WriteLine(str);
    Writer.WriteLine($"{{");
    Writer.Indent++;

    if (!GenerateClassHeading(constraintClassName, "DocumentFormat.OpenXml.OpenXmlCompositeElement", null))
      return false;

    foreach (var itemConstraint in constraint.Items)
      if (!GenerateItemsProperties(typeInfo, itemConstraint, constraintClassName, inNamespace, subclassesTypeNames, TypeKind.EmbeddedClass))
        return false;

    Writer.Indent--;
    Writer.WriteLine($"}} // {constraintClassName}");
    Writer.WriteLine();
    if (constraint.IsRequired)
      Writer.WriteLine($"private {constraintClassName} _{constraintClassName} = null!;");
    else
      Writer.WriteLine($"private {constraintClassName}? _{constraintClassName};");
    Writer.WriteLine();
    return true;
  }

  private bool GenerateClassHeading(string className, string openXmlTypeName, List<string>? subclassesTypeNames)
  {
    Writer.WriteLine();
    Writer.WriteLine($"public {openXmlTypeName} OpenXmlElement {{ get; set; }}");
    Writer.WriteLine();
    Writer.WriteLine($"public {className}({openXmlTypeName} openXmlElement)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    Writer.WriteLine($"OpenXmlElement = openXmlElement;");
    Writer.Indent--;
    Writer.WriteLine($"}}");
    return true;
  }

  private bool GenerateClassConstructor(string className)
  {
    Writer.WriteLine($"public {className}(): base() {{}}");
    Writer.WriteLine();
    return true;
  }

  private bool GenerateClassConstructor(string className, string openXmlTypeName, List<string>? subclassesTypeNames)
  {
    Writer.WriteLine($"public {className}({openXmlTypeName} openXmlElement): base(openXmlElement)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    Writer.WriteLine($"OpenXmlElement = openXmlElement;");
    if (subclassesTypeNames != null)
      foreach (var subclass in subclassesTypeNames)
        Writer.WriteLine($"{subclass} _{subclass} = new {subclass}(openXmlElement);");
    Writer.Indent--;
    Writer.WriteLine($"}}");
    Writer.WriteLine();
    return true;
  }

  private bool GenerateProperty(PropInfo prop, string? inNamespace, TypeKind kind)
  {
    var targetPropType = prop.PropertyType.GetConversionTarget(true);
    FullTypeName targetPropTypeName = prop.PropertyType.GetConvertedName(TypeKind.Type);
    TrimNamespace(targetPropTypeName);
    var propTypeName = targetPropTypeName.ToString();
    string qm = /*(targetPropTypeName.Name.StartsWith("Nullable")) ? "" :*/ "?";
    GenerateDocumentationComments(prop);
    GenerateCustomAttributes(prop.CustomAttributes);
    if (kind == TypeKind.Interface)
    {
      if (prop.IsReadonly)
        Writer.WriteLine($"public {propTypeName}{qm} {prop.Name} {{ get; }}");
      else
        Writer.WriteLine($"public {propTypeName}{qm} {prop.Name} {{ get; set; }}");
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
      Writer.WriteLine(str);

      Writer.WriteLine($"{{");
      if (!GeneratePropertyAccessors(prop, targetPropType, out var fieldName, out var propItemType))
        return false;
      Writer.WriteLine($"}}");
      if (fieldName != null && propItemType != null)
        GenerateCollectionField(prop, propItemType);
    }
    Writer.WriteLine();
    GeneratedPropertiesCount += 1;
    return true;
  }

  private bool GeneratePropertyAccessors(PropInfo prop, TypeInfo targetPropType, out string? fieldName, out TypeInfo? propItemType)
  {
    fieldName = null;
    propItemType = null;
    //if (prop.Name == "DataPart")
    //  Debug.Assert(true);
    if (prop.DeclaringType?.Name == "CoreProperties")
      return GenerateCorePropertiesPropAccessors(prop, targetPropType);
    if (targetPropType.TypeKind == TypeKind.Enum)
      return GenerateValueTypeAccessors(prop, targetPropType);
    if (targetPropType.IsValueOrStringType)
      return GenerateValueTypeAccessors(prop, targetPropType);
    if (targetPropType.Name.StartsWith("ListOf`"))
      return GenerateListValuePropAccessors(prop, targetPropType);

    if (targetPropType.Name.StartsWith("Collection`"))
    {
      propItemType = targetPropType.GetGenericArgTypes()?.FirstOrDefault();
      if (propItemType != null)
      {
        fieldName = "_" + prop.Name;
        return GenerateCollectionTypeAccessors(prop, propItemType);
      }
    }
    if (prop.Name == "Package" || prop.Name == "PartExtensionProvider")
      return GeneratePackagePropAccessors(prop);

    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPart)))
    //  return GeneratePartTypeAccessors(prop, targetPropType);

    return GenerateObjectTypeAccessors(prop, targetPropType);
  }

  private bool GenerateValueTypeAccessors(PropInfo prop, TypeInfo targetPropType)
  {
    if (prop.PropertyInfo != null && prop.PropertyInfo.PropertyType == targetPropType.Type)
      return GenerateDirectPropAccessors(prop, targetPropType);

    if (targetPropType.Name == "Base64Binary" || targetPropType.Name == "HexBinary")
    {
      //if (prop.Name== "DocumentId")
      //  Debug.Assert(true);
      var origPropType = prop.PropertyType.Type;
      if (prop.DeclaringType != null && prop.DeclaringType.Type.HasProperty(prop.Name))
      {
        if (origPropType.HasProperty("Val"))
          return GenerateBinaryValPropAccessors(prop, targetPropType);

        return GenerateBinaryValuePropAccessors(prop, targetPropType);
      }
      return GenerateBinaryValueIncludedPropAccessors(prop, targetPropType);
    }

    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OpenXmlSimpleType)))
      return GenerateSimpleValuePropAccessors(prop, targetPropType);
    if (prop.PropertyInfo?.DeclaringType != null && prop.PropertyInfo.DeclaringType.HasProperty(prop.Name))
    {
      if (targetPropType.Type == typeof(Boolean))
        return GenerateIncludedBooleanPropAccessors(prop);

      return GenerateObjectValuePropAccessors(prop, targetPropType);
    }

    var origPropBaseType = GetTypeWithBaseOf(prop.PropertyType.Type, typeof(DocumentFormat.OpenXml.TypedOpenXmlLeafElement));
    if (origPropBaseType != null && origPropBaseType.HasProperty("Val"))
      return GenerateIncludedValueElementPropAccessors(prop, targetPropType);

    if (targetPropType.Type == typeof(String))
      return GenerateIncludedStringPropAccessors(prop);

    if (targetPropType.Type == typeof(Boolean))
      return GenerateIncludedBooleanPropAccessors(prop);

    //return GenerateIncludedValueElementPropAccessors(prop, targetPropType);
    return false;
  }

  private bool GenerateObjectTypeAccessors(PropInfo prop, TypeInfo targetPropType)
  {
    if (prop.PropertyType.Namespace == "DocumentModel.VariantTypes")
      return GenerateVariantIncludedPropAccessors(prop, targetPropType);

    if (targetPropType.Name.EndsWith("Parts"))
      return GenerateIncludedObjectElementPropAccessors(prop, targetPropType);

    if (prop.DeclaringType != null && prop.DeclaringType.Name.EndsWith("Part"))
      return GenerateObjectComplexPropAccessors(prop, targetPropType);

    if (prop.DeclaringType != null && prop.DeclaringType.Name.EndsWith("Package"))
      return GenerateObjectComplexPropAccessors(prop, targetPropType);

    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPart)))
      return GeneratePartTypePropAccessors(prop, targetPropType);

    if (prop.PropertyType.Type == typeof(DocumentFormat.OpenXml.Packaging.DataPart))
      return GeneratePartTypePropAccessors(prop, targetPropType);

    return GenerateIncludedObjectElementPropAccessors(prop, targetPropType);
  }

  private Type? GetTypeWithBaseOf(Type thisType, Type baseType)
  {
    if (thisType.BaseType?.Name == baseType.Name)
      return thisType;
    if (thisType.BaseType != null)
      return GetTypeWithBaseOf(thisType.BaseType, baseType);
    return null;
  }

  private bool GenerateNotImplementedPropAccessors(PropInfo prop)
  {
    Writer.WriteLine($"  get => throw new NotImplementedException(\"Method not implemented\");");
    if (!prop.IsReadonly)
      Writer.WriteLine($"  set => throw new NotImplementedException(\"Method not implemented\");");
    return true;
  }

  private bool GenerateAutoPropAccessors(PropInfo prop)
  {
    Writer.WriteLine($"  get;set;");
    return true;
  }

  private bool GenerateDirectPropAccessors(PropInfo prop, TypeInfo targetPropType)
  {
    var propertyInfo = prop.PropertyInfo;
    if (propertyInfo == null)
      return false;
    var origPropName = prop.Name;
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    Writer.WriteLine($"  get => ({targetPropTypeName}?)OpenXmlElement?.{origPropName};");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    if (propertyInfo.SetMethod?.IsAssembly != true
        || propertyInfo.SetMethod?.IsFamilyAndAssembly != true
        || propertyInfo.SetMethod?.IsFamilyOrAssembly != true)
      // if method is internal, protected or internal protected
      Writer.WriteLine($"      typeof({propertyInfo.DeclaringType?.FullName})" +
                       $".GetProperty(\"{origPropName}\")?.SetValue(OpenXmlElement, ({origTargetTypeName}?)value);");
    else
      Writer.WriteLine($"      OpenXmlElement.{origPropName} = ({origTargetTypeName}?)value;");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateSimpleValuePropAccessors(PropInfo prop,
    TypeInfo targetPropType)
  {
    var origPropName = prop.Name;
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    Writer.WriteLine($"  get => ({targetPropTypeName}?)OpenXmlElement?.{origPropName}?.Value;");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"      OpenXmlElement.{origPropName} = ({origTargetTypeName}?)value;");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateBinaryValuePropAccessors(PropInfo prop,
  TypeInfo targetPropType)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    Writer.WriteLine($"  get");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement?.{origPropName}?.Value != null)");
    Writer.WriteLine($"      return ({targetPropTypeName})OpenXmlElement.{origPropName}.Value;");
    Writer.WriteLine($"    return null;");
    Writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      if (value != null)");
    Writer.WriteLine($"        OpenXmlElement.{origPropName} = new {origPropTypeName}{{ Value = value.ToString() }};");
    Writer.WriteLine($"      else");
    Writer.WriteLine($"        OpenXmlElement.{origPropName} = null;");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateBinaryValPropAccessors(PropInfo prop,
    TypeInfo targetPropType)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    Writer.WriteLine($"  get");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement?.{origPropName}?.Val?.Value != null)");
    Writer.WriteLine($"      return ({targetPropTypeName})OpenXmlElement.{origPropName}.Val.Value;");
    Writer.WriteLine($"    return null;");
    Writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      if (value != null)");
    Writer.WriteLine($"        OpenXmlElement.{origPropName} = new {origPropTypeName}{{ Val = value.ToString() }};");
    Writer.WriteLine($"      else");
    Writer.WriteLine($"        OpenXmlElement.{origPropName} = null;");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateBinaryValueDirectPropAccessors(PropInfo prop,
    TypeInfo targetPropType,
    IndentedTextWriter writer)
  {
    var origPropName = prop.Name;
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    Writer.WriteLine($"  get");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      var item = OpenXmlElement?.{origPropName};");
    Writer.WriteLine($"      if (item != null)");
    Writer.WriteLine($"        return new {targetPropTypeName}Impl(item);");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"    return null;");
    Writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"      OpenXmlElement.{origPropName} = value?.Value;");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateBinaryValueIncludedPropAccessors(PropInfo prop,
  TypeInfo targetPropType)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    Writer.WriteLine($"  get");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"      if (item?.Val?.Value != null)");
    Writer.WriteLine($"        return ({targetPropTypeName})(string)(item.Val.Value);");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"    return null;");
    Writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"      if (item != null)");
    Writer.WriteLine($"        item.Remove();");
    Writer.WriteLine($"      if (value != null)");
    Writer.WriteLine($"      {{");
    Writer.WriteLine($"        item = new {origPropTypeName} {{ Val = value.ToString() }};");
    Writer.WriteLine($"        OpenXmlElement.AddChild(item);");
    Writer.WriteLine($"      }}");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateCorePropertiesPropAccessors(PropInfo prop,
  TypeInfo targetPropType)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    Writer.WriteLine($"  get => OpenXmlElement?.{origPropName};");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"      OpenXmlElement.{origPropName} = value;");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateObjectValuePropAccessors(PropInfo prop,
    TypeInfo targetPropType)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    if (targetPropType.Type == typeof(DocumentModel.HexWord))
      origTargetTypeName = "string";
    if (prop.PropertyType.Type.HasProperty("Val"))
      Writer.WriteLine($"  get => ({targetPropTypeName}?)OpenXmlElement?.{origPropName}?.Val?.Value;");
    else if (prop.PropertyType.Type.HasProperty("Text"))
      Writer.WriteLine($"  get => ({targetPropTypeName}?)OpenXmlElement?.{origPropName}?.Text;");
    else
      Writer.WriteLine($"  get => ({targetPropTypeName}?)OpenXmlElement?.{origPropName}?.InnerText;");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      if (OpenXmlElement.{origPropName} != null)");
    Writer.WriteLine($"      {{");
    Writer.WriteLine($"        if (value is not null)");
    if (prop.PropertyType.Type.HasProperty("Val"))
      Writer.WriteLine($"          OpenXmlElement.{origPropName}.Val = ({origTargetTypeName}?)value;");
    else if (prop.PropertyType.Type.HasProperty("Text"))
      Writer.WriteLine($"          OpenXmlElement.{origPropName}.Text = value;");
    else
      Writer.WriteLine($"          OpenXmlElement.{origPropName} = new (value);");
    Writer.WriteLine($"        else");
    Writer.WriteLine($"          OpenXmlElement.{origPropName} = null;");
    Writer.WriteLine($"      }}");
    Writer.WriteLine($"      else");
    Writer.WriteLine($"      {{");
    Writer.WriteLine($"        if (value is not null)");
    if (prop.PropertyType.Type.HasProperty("Val"))
      Writer.WriteLine($"          OpenXmlElement.{origPropName} = new {origPropTypeName}{{ Val = ({origTargetTypeName}?)value }};");
    else if (prop.PropertyType.Type.HasProperty("Text"))
      Writer.WriteLine($"          OpenXmlElement.{origPropName} = new {origPropTypeName}{{ Text = value }};");
    else
      Writer.WriteLine($"          OpenXmlElement.{origPropName} = new {origPropTypeName}(value);");
    Writer.WriteLine($"      }}");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GeneratePartTypePropAccessors(PropInfo prop,
    TypeInfo targetPropType)
  {
    var origPropName = prop.Name;
    //var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    //var origTargetTypeName = targetPropType.GetFullName(true);
    Writer.WriteLine($"  get");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement?.{origPropName} != null)");
    Writer.WriteLine($"      return new {targetPropTypeName}Impl(OpenXmlElement.{origPropName});");
    Writer.WriteLine($"    return null;");
    Writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"      if (value is {targetPropTypeName}Impl valueImpl)");
    Writer.WriteLine($"        if (valueImpl.OpenXmlElement != null)");
    if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Packaging.DataPartReferenceRelationship)) == true)
      Writer.WriteLine($"            OpenXmlElement.SetDataPart(valueImpl.OpenXmlElement);");
    else
    if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OpenXmlPartRootElement)) == true)
      Writer.WriteLine($"            OpenXmlElement.SetPart(valueImpl.OpenXmlElement);");
    else
      Writer.WriteLine($"            OpenXmlElement.{origPropName} = valueImpl.OpenXmlElement;");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateObjectComplexPropAccessors(PropInfo prop,
  TypeInfo targetPropType)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    Writer.WriteLine($"  get");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement?.{origPropName} != null)");
    Writer.WriteLine($"      return new {targetPropTypeName}Impl(OpenXmlElement.{origPropName});");
    Writer.WriteLine($"    return null;");
    Writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    if (value is {targetPropTypeName}Impl valueImpl)");
    Writer.WriteLine($"      if (valueImpl.OpenXmlElement != null)");
    Writer.WriteLine($"          OpenXmlElement.{origPropName} = valueImpl.OpenXmlElement;");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateListValuePropAccessors(PropInfo prop,
    TypeInfo targetPropType)
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
    if (k > 0)
    {
      var i = origPropBaseTypeNameName.LastIndexOf('<', k);
      var j = origPropBaseTypeNameName.IndexOf('>', k);
      if (i > 0 && j > 0)
        castBaseTypeName = origPropBaseTypeNameName.Substring(i + 1, j - i - 1);
    }
    Writer.WriteLine($"  get");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement?.{propName} != null)");
    Writer.WriteLine($"      return new {targetPropTypeName}(OpenXmlElement.{propName}.InnerText);");
    Writer.WriteLine($"    return null;");
    Writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      if (value?.Items.Any() == true)");
    if (castBaseTypeName != null)
      Writer.WriteLine($"        OpenXmlElement.{propName} = new {origPropTypeName}" +
                       $"(value.Items.Select(item => new {origPropBaseTypeName}(({castBaseTypeName})item)));");
    else
      Writer.WriteLine($"        OpenXmlElement.{propName} = new {origPropTypeName}" +
                       $"(value.Items.Select(item => new {origPropBaseTypeName}(item)));");
    Writer.WriteLine($"  else");
    Writer.WriteLine($"    OpenXmlElement.{propName} = null;");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateVariantIncludedPropAccessors(PropInfo prop,
    TypeInfo targetPropType)
  {
    var origPropName = prop.Name;
    var origPropTypeName = "DocumentFormat.OpenXml.VariantTypes." + origPropName;
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    Writer.WriteLine($"  get");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"      if (item != null)");
    Writer.WriteLine($"        return new {targetPropTypeName}Impl(item);");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"    return null;");
    Writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"      if (item != null)");
    Writer.WriteLine($"        item.Remove();");
    Writer.WriteLine($"      if (value != null)");
    Writer.WriteLine($"      {{");
    Writer.WriteLine($"        var newItem = (value as {targetPropTypeName}Impl)?.OpenXmlElement;");
    Writer.WriteLine($"        if (newItem != null)");
    Writer.WriteLine($"          OpenXmlElement.AddChild(newItem);");
    Writer.WriteLine($"      }}");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateIncludedValueElementPropAccessors(PropInfo prop,
    TypeInfo targetPropType)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    Writer.WriteLine($"  get");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"      return ({targetPropTypeName}?)item?.Val?.Value;");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"    return null;");
    Writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"      if (item != null)");
    Writer.WriteLine($"      {{");
    Writer.WriteLine($"        if (value is not null)");
    Writer.WriteLine($"          item.Val = ({origTargetTypeName}?)value;");
    Writer.WriteLine($"        else");
    Writer.WriteLine($"          item.Remove();");
    Writer.WriteLine($"      }}");
    Writer.WriteLine($"      else");
    Writer.WriteLine($"      {{");
    Writer.WriteLine($"        if (value is not null)");
    Writer.WriteLine($"        {{");
    Writer.WriteLine($"          item = new {origPropTypeName}{{ Val = ({origTargetTypeName}?)value }};");
    Writer.WriteLine($"          OpenXmlElement.AddChild(item);");
    Writer.WriteLine($"        }}");
    Writer.WriteLine($"      }}");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateIncludedObjectElementPropAccessors(PropInfo prop,
    TypeInfo targetPropType)
  {
    //var origPropTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = targetPropType.GetFullName();
    var origTargetTypeName = targetPropType.GetFullName(true);
    Writer.WriteLine($"  get");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origTargetTypeName}>();");
    Writer.WriteLine($"      if (item != null)");
    Writer.WriteLine($"        return new {targetPropTypeName}Impl(item);");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"    return null;");
    Writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origTargetTypeName}>();");
    Writer.WriteLine($"      if (item != null)");
    Writer.WriteLine($"        item.Remove();");
    Writer.WriteLine($"      if (value is not null)");
    Writer.WriteLine($"      {{");
    Writer.WriteLine($"        item = (value as {targetPropTypeName}Impl)?.OpenXmlElement;");
    Writer.WriteLine($"        if (item != null)");
    Writer.WriteLine($"          OpenXmlElement.AddChild(item);");
    Writer.WriteLine($"      }}");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateCollectionTypeAccessors(PropInfo prop,
    TypeInfo propItemType)
  {
    if (prop.DeclaringType?.Name == "OpenXmlPartContainer")
      return GenerateOpenXmlPartContainerItemsCollectionTypeAccessors(prop, propItemType);

    if (propItemType.Name == "DataPart")
      return GeneratePartCollectionTypeAccessors(prop, propItemType);

    if (propItemType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPart)))
      return GeneratePartCollectionTypeAccessors(prop, propItemType);

    return GenerateElementCollectionTypeAccessors(prop, propItemType);
  }

  private bool GenerateOpenXmlPartContainerItemsCollectionTypeAccessors(PropInfo prop,
    TypeInfo propItemType)
  {
    AddGlobalUsing("System.Linq");

    TypeInfo targetItemType = propItemType.GetConversionTarget(true);
    string propItemTypeName = targetItemType.GetFullName();
    string origItemTypeName = propItemType.GetFullName(true);
    var propName = prop.Name;
    var fieldName = "_" + propName;
    string itemTypeName = TypeReflector.SingularizeName(propName);
    Writer.WriteLine($"  get");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if ({fieldName} == null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      if (OpenXmlElement != null)");
    Writer.WriteLine($"      {{");
    Writer.WriteLine($"        var items = OpenXmlElement.{propName}");
    Writer.WriteLine($"          .Select(item => new {propItemTypeName}Impl(item)).ToList();");
    Writer.WriteLine($"        {fieldName} = new ObservableCollection<{propItemTypeName}>(items);");
    Writer.WriteLine($"      }}");
    Writer.WriteLine($"      else");
    Writer.WriteLine($"        {fieldName} = new ObservableCollection<{propItemTypeName}>();");
    Writer.WriteLine($"      {fieldName}.CollectionChanged += {fieldName}_CollectionChanged;");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"    return {fieldName};");
    Writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (value != null && value != {fieldName} && OpenXmlElement!=null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      foreach (var val in value)");
    Writer.WriteLine($"      {{");
    Writer.WriteLine($"        if (val is {propItemTypeName}Impl valImpl)");
    Writer.WriteLine($"        {{");
    Writer.WriteLine($"          var item = valImpl.OpenXmlElement;");
    Writer.WriteLine($"          if (item != null)");
    Writer.WriteLine($"            if (!OpenXmlElement.{propName}.Contains(item))");
    if (itemTypeName == "Part")
      Writer.WriteLine($"              OpenXmlElement.AddPart(item.OpenXmlPart, item.RelationshipId);");
    else
    if (itemTypeName.Contains("Hyperlink"))
      Writer.WriteLine($"              OpenXmlElement.Add{itemTypeName}(item.Uri, item.IsExternal, item.Id);");
    else
    if (itemTypeName.Contains("DataPart"))
      Writer.WriteLine($"              OpenXmlElement.Add{itemTypeName}(item);");
    else
      Writer.WriteLine($"              OpenXmlElement.Add{itemTypeName}(item.RelationshipType, item.Uri, item.Id);");
    Writer.WriteLine($"        }};");
    Writer.WriteLine($"      }}");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"    if (value is ObservableCollection<{propItemTypeName}> observableCollection)");
    Writer.WriteLine($"      {fieldName} = observableCollection;");
    Writer.WriteLine($"    else if (value != null)");
    Writer.WriteLine($"      {fieldName} = new ObservableCollection<{propItemTypeName}>(value);");
    Writer.WriteLine($"    else");
    Writer.WriteLine($"     {fieldName} = null;");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GeneratePartCollectionTypeAccessors(PropInfo prop,
    TypeInfo propItemType)
  {
    AddGlobalUsing("System.Linq");

    TypeInfo targetItemType = propItemType.GetConversionTarget(true);
    string propItemTypeName = targetItemType.GetFullName();
    string origItemTypeName = propItemType.GetFullName(true);
    var propName = prop.Name;
    var fieldName = "_" + propName;
    string itemTypeName = TypeReflector.SingularizeName(propName);
    Writer.WriteLine($"  get");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if ({fieldName} == null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      if (OpenXmlElement != null)");
    Writer.WriteLine($"      {{");
    if (itemTypeName == "DataPart")
      Writer.WriteLine($"        var items = OpenXmlElement.DataParts");
    else
      Writer.WriteLine($"        var items = OpenXmlElement.GetPartsOfType<{origItemTypeName}>()");
    Writer.WriteLine($"          .Select(item => new {propItemTypeName}Impl(item)).ToList();");
    Writer.WriteLine($"        {fieldName} = new ObservableCollection<{propItemTypeName}>(items);");
    Writer.WriteLine($"      }}");
    Writer.WriteLine($"      else");
    Writer.WriteLine($"        {fieldName} = new ObservableCollection<{propItemTypeName}>();");
    Writer.WriteLine($"      {fieldName}.CollectionChanged += {fieldName}_CollectionChanged;");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"    return {fieldName};");
    Writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (value != null && value != {fieldName} && OpenXmlElement!=null)");
    Writer.WriteLine($"    {{");
    if (itemTypeName == "DataPart")
      Writer.WriteLine($"      foreach (var item in OpenXmlElement.DataParts.ToArray())");
    else
      Writer.WriteLine($"      foreach (var item in OpenXmlElement.GetPartsOfType<{origItemTypeName}>().ToArray())");
    Writer.WriteLine($"        OpenXmlElement.DeletePart(item);");
    Writer.WriteLine($"      foreach (var val in value)");
    Writer.WriteLine($"      {{");
    Writer.WriteLine($"        if (val is {propItemTypeName}Impl valImpl)");
    Writer.WriteLine($"        {{");
    Writer.WriteLine($"          var item = valImpl.OpenXmlElement;");
    Writer.WriteLine($"          if (item != null)");
    if (itemTypeName == "DataPart")
      Writer.WriteLine($"            OpenXmlElement.AddDataPartToList(item);");
    else
      Writer.WriteLine($"            OpenXmlElement.AddPart(item);");
    Writer.WriteLine($"        }};");
    Writer.WriteLine($"      }}");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"    if (value is ObservableCollection<{propItemTypeName}> observableCollection)");
    Writer.WriteLine($"      {fieldName} = observableCollection;");
    Writer.WriteLine($"    else if (value != null)");
    Writer.WriteLine($"      {fieldName} = new ObservableCollection<{propItemTypeName}>(value);");
    Writer.WriteLine($"    else");
    Writer.WriteLine($"     {fieldName} = null;");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateElementCollectionTypeAccessors(PropInfo prop,
  TypeInfo propItemType)
  {
    AddGlobalUsing("System.Linq");

    TypeInfo targetItemType = propItemType.GetConversionTarget(true);
    string propItemTypeName = targetItemType.GetFullName();
    string origItemTypeName = propItemType.GetFullName(true);
    var propName = prop.Name;
    var fieldName = "_" + propName;
    Writer.WriteLine($"  get");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if ({fieldName} == null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      if (OpenXmlElement != null)");
    Writer.WriteLine($"      {{");
    Writer.WriteLine($"        var items = OpenXmlElement.Elements<{origItemTypeName}>()");
    if (targetItemType.Type == typeof(DocumentModel.HexWord))
      Writer.WriteLine($"          .Select(item => new {propItemTypeName}(item.Val?.Value ?? \"0000\")).ToList();");
    else if (targetItemType.Type == typeof(string))
    {
      if (propItemType.Type.HasProperty("Val"))
        Writer.WriteLine($"          .Select(item => item.Val?.Value ?? \"\").ToList();");
      else
        Writer.WriteLine($"          .Select(item => item.Text).ToList();");
    }
    else if (targetItemType.Type.IsValueType)
      Writer.WriteLine($"          .Select(item => item.Val?.Value ?? default).ToList();");
    else
      Writer.WriteLine($"          .Select(item => new {propItemTypeName}Impl(item)).ToList();");
    Writer.WriteLine($"        {fieldName} = new ObservableCollection<{propItemTypeName}>(items);");
    Writer.WriteLine($"      }}");
    Writer.WriteLine($"      else");
    Writer.WriteLine($"        {fieldName} = new ObservableCollection<{propItemTypeName}>();");
    Writer.WriteLine($"      {fieldName}.CollectionChanged += {fieldName}_CollectionChanged;");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"    return {fieldName};");
    Writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (value != null && value != {fieldName} && OpenXmlElement!=null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      OpenXmlElement.RemoveAllChildren<{origItemTypeName}>();");
    Writer.WriteLine($"      foreach (var val in value)");
    Writer.WriteLine($"      {{");
    if (targetItemType.Type == typeof(DocumentModel.HexWord))
    {
      Writer.WriteLine($"        var item = new {origItemTypeName}{{ Val = (string?)val }};");
      Writer.WriteLine($"        OpenXmlElement.AddChild(item);");
    }
    else if (targetItemType.Type == typeof(string))
    {
      Writer.WriteLine($"        if (val is string str)");
      Writer.WriteLine($"        {{");
      if (propItemType.Type.HasProperty("Val"))
        Writer.WriteLine($"          var item = new {origItemTypeName}{{ Val = str }};");
      else
        Writer.WriteLine($"          var item = new {origItemTypeName}{{ Text = str }};");
      Writer.WriteLine($"          OpenXmlElement.AddChild(item);");
      Writer.WriteLine($"        }};");
    }
    else if (targetItemType.Type.IsValueType)
    {
      Writer.WriteLine($"        var item = new {origItemTypeName}{{ Val = val }};");
      Writer.WriteLine($"        OpenXmlElement.AddChild(item);");
    }
    else
    {
      Writer.WriteLine($"        if (val is {propItemTypeName}Impl valImpl)");
      Writer.WriteLine($"        {{");
      Writer.WriteLine($"          var item = valImpl.OpenXmlElement;");
      Writer.WriteLine($"          if (item != null)");
      Writer.WriteLine($"            OpenXmlElement.AddChild(item);");
      Writer.WriteLine($"        }};");
    }
    Writer.WriteLine($"      }}");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"    if (value is ObservableCollection<{propItemTypeName}> observableCollection)");
    Writer.WriteLine($"      {fieldName} = observableCollection;");
    Writer.WriteLine($"    else if (value != null)");
    Writer.WriteLine($"      {fieldName} = new ObservableCollection<{propItemTypeName}>(value);");
    Writer.WriteLine($"    else");
    Writer.WriteLine($"     {fieldName} = null;");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateCollectionField(PropInfo prop,
    TypeInfo propItemType)
  {
    if (prop.DeclaringType?.Name == "OpenXmlPartContainer")
      return GenerateOpenXmlContainerItemsCollectionField(prop, propItemType);

    if (propItemType.Name == "DataPart")
      return GeneratePartCollectionField(prop, propItemType);

    if (propItemType.Type.IsSubclassOf(typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPart)))
      return GeneratePartCollectionField(prop, propItemType);

    return GenerateElementCollectionField(prop, propItemType);
  }

  private bool GenerateOpenXmlContainerItemsCollectionField(PropInfo prop,
    TypeInfo propItemType)
  {
    AddGlobalUsing("System.Collections.Specialized");

    TypeInfo targetItemType = propItemType.GetConversionTarget(true);
    string propItemTypeName = targetItemType.GetFullName();
    string origItemTypeName = propItemType.GetFullName(true);
    var propName = prop.Name;
    var fieldName = "_" + propName;
    string itemTypeName = TypeReflector.SingularizeName(propName);
    Writer.WriteLine($"private ObservableCollection<{propItemTypeName}>? {fieldName};");
    Writer.WriteLine();
    Writer.WriteLine($"private void {fieldName}_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  if (OpenXmlElement != null)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    switch (args.Action)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      case NotifyCollectionChangedAction.Reset:");
    Writer.WriteLine($"        foreach (var item in OpenXmlElement.{propName}.ToArray())");
    if (itemTypeName == "Part")
      Writer.WriteLine($"          OpenXmlElement.DeletePart(item.RelationshipId);");
    else
      Writer.WriteLine($"          OpenXmlElement.DeleteReferenceRelationship(item);");
    Writer.WriteLine($"        break;");
    Writer.WriteLine($"      case NotifyCollectionChangedAction.Add:");
    Writer.WriteLine($"        if (args.NewItems != null)");
    Writer.WriteLine($"        foreach (var val in args.NewItems)");
    Writer.WriteLine($"        {{");
    Writer.WriteLine($"          if (val is {propItemTypeName}Impl valImpl)");
    Writer.WriteLine($"          {{");
    Writer.WriteLine($"            var item = valImpl.OpenXmlElement;");
    Writer.WriteLine($"            if (item != null)");
    if (itemTypeName == "Part")
      Writer.WriteLine($"            OpenXmlElement.AddPart(item.OpenXmlPart, item.RelationshipId);");
    else
    if (itemTypeName.Contains("Hyperlink"))
      Writer.WriteLine($"              OpenXmlElement.Add{itemTypeName}(item.Uri, item.IsExternal, item.Id);");
    else
    if (itemTypeName.Contains("DataPart"))
      Writer.WriteLine($"              OpenXmlElement.Add{itemTypeName}(item);");
    else
      Writer.WriteLine($"              OpenXmlElement.Add{itemTypeName}(item.RelationshipType, item.Uri, item.Id);");
    Writer.WriteLine($"          }};");
    Writer.WriteLine($"        }}");
    Writer.WriteLine($"        break;");
    Writer.WriteLine($"      case NotifyCollectionChangedAction.Remove:");
    Writer.WriteLine($"        if (args.OldItems != null)");
    Writer.WriteLine($"        foreach (var val in args.OldItems)");
    Writer.WriteLine($"        {{");
    Writer.WriteLine($"          if (val is {propItemTypeName}Impl valImpl)");
    Writer.WriteLine($"          {{");
    Writer.WriteLine($"              if (valImpl.OpenXmlElement is {origItemTypeName} oldItem)");
    if (itemTypeName == "Part")
      Writer.WriteLine($"                OpenXmlElement.DeletePart(oldItem.RelationshipId);");
    else
      Writer.WriteLine($"                OpenXmlElement.DeleteReferenceRelationship(oldItem);");
    Writer.WriteLine($"          }};");
    Writer.WriteLine($"        }}");
    Writer.WriteLine($"        break;");
    Writer.WriteLine($"      default:");
    Writer.WriteLine($"        break;");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
    Writer.WriteLine();
    return true;
  }

  private bool GeneratePartCollectionField(PropInfo prop,
    TypeInfo propItemType)
  {
    AddGlobalUsing("System.Collections.Specialized");

    TypeInfo targetItemType = propItemType.GetConversionTarget(true);
    string propItemTypeName = targetItemType.GetFullName();
    string origItemTypeName = propItemType.GetFullName(true);
    var propName = prop.Name;
    var fieldName = "_" + propName;
    string itemTypeName = TypeReflector.SingularizeName(propName);
    Writer.WriteLine($"private ObservableCollection<{propItemTypeName}>? {fieldName};");
    Writer.WriteLine();
    Writer.WriteLine($"private void {fieldName}_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  if (OpenXmlElement != null)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    switch (args.Action)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      case NotifyCollectionChangedAction.Reset:");
    if (itemTypeName == "DataPart")
      Writer.WriteLine($"        foreach (var item in OpenXmlElement.DataParts.ToArray())");
    else
      Writer.WriteLine($"        foreach (var item in OpenXmlElement.GetPartsOfType<{origItemTypeName}>().ToArray())");
    Writer.WriteLine($"          OpenXmlElement.DeletePart(item);");
    Writer.WriteLine($"        break;");
    Writer.WriteLine($"      case NotifyCollectionChangedAction.Add:");
    Writer.WriteLine($"        if (args.NewItems != null)");
    Writer.WriteLine($"        foreach (var val in args.NewItems)");
    Writer.WriteLine($"        {{");
    Writer.WriteLine($"          if (val is {propItemTypeName}Impl valImpl)");
    Writer.WriteLine($"          {{");
    Writer.WriteLine($"            var item = valImpl.OpenXmlElement;");
    Writer.WriteLine($"            if (item != null)");
    if (itemTypeName == "DataPart")
      Writer.WriteLine($"              OpenXmlElement.AddDataPartToList(item);");
    else
      Writer.WriteLine($"              OpenXmlElement.AddPart(item);");
    Writer.WriteLine($"          }};");
    Writer.WriteLine($"        }}");
    Writer.WriteLine($"        break;");
    Writer.WriteLine($"      case NotifyCollectionChangedAction.Remove:");
    Writer.WriteLine($"        if (args.OldItems != null)");
    Writer.WriteLine($"        foreach (var val in args.OldItems)");
    Writer.WriteLine($"        {{");
    Writer.WriteLine($"            if (val is {propItemTypeName}Impl valImpl)");
    Writer.WriteLine($"            {{");
    if (itemTypeName == "DataPart")
      Writer.WriteLine($"                var oldItem = OpenXmlElement.DataParts");
    else
      Writer.WriteLine($"                var oldItem = OpenXmlElement.GetPartsOfType<{origItemTypeName}>()");
    Writer.WriteLine($"                              .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);");
    Writer.WriteLine($"               if (oldItem != null)");
    Writer.WriteLine($"                  OpenXmlElement.DeletePart(oldItem);");
    Writer.WriteLine($"           }};");
    Writer.WriteLine($"        }}");
    Writer.WriteLine($"        break;");
    Writer.WriteLine($"      default:");
    Writer.WriteLine($"        break;");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
    Writer.WriteLine();
    return true;
  }
  private bool GenerateElementCollectionField(PropInfo prop,
    TypeInfo propItemType)
  {
    AddGlobalUsing("System.Collections.Specialized");

    TypeInfo targetItemType = propItemType.GetConversionTarget(true);
    string propItemTypeName = targetItemType.GetFullName();
    string origItemTypeName = propItemType.GetFullName(true);
    var propName = prop.Name;
    var fieldName = "_" + propName;
    Writer.WriteLine($"private ObservableCollection<{propItemTypeName}>? {fieldName};");
    Writer.WriteLine();
    Writer.WriteLine($"private void {fieldName}_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  if (OpenXmlElement != null)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    switch (args.Action)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      case NotifyCollectionChangedAction.Reset:");
    Writer.WriteLine($"        OpenXmlElement.RemoveAllChildren<{origItemTypeName}>();");
    Writer.WriteLine($"        break;");
    Writer.WriteLine($"      case NotifyCollectionChangedAction.Add:");
    Writer.WriteLine($"        if (args.NewItems != null)");
    Writer.WriteLine($"        foreach (var val in args.NewItems)");
    Writer.WriteLine($"        {{");
    if (targetItemType.Type == typeof(DocumentModel.HexWord))
    {
      Writer.WriteLine($"          var newItem = new {origItemTypeName} {{ Val = (string?)val }};");
      Writer.WriteLine($"          OpenXmlElement.AddChild(newItem);");
    }
    else if (targetItemType.Type == typeof(string))
    {
      Writer.WriteLine($"        if (val is string str)");
      Writer.WriteLine($"        {{");
      if (propItemType.Type.HasProperty("Val"))
        Writer.WriteLine($"          var newItem = new {origItemTypeName}{{ Val = str }};");
      else
        Writer.WriteLine($"          var newItem = new {origItemTypeName} {{ Text = str }};");
      Writer.WriteLine($"          OpenXmlElement.AddChild(newItem);");
      Writer.WriteLine($"        }};");
    }
    else if (targetItemType.Type.IsValueType)
    {
      var valProperty = propItemType.Type.GetProperty("Val");
      if (valProperty != null && TryGetSimpleType(valProperty.PropertyType, out var simpleType) && simpleType != null)
        Writer.WriteLine($"          var newItem = new {origItemTypeName} {{ Val = ({simpleType.Name})val }};");
      else
        Writer.WriteLine($"          var newItem = new {origItemTypeName} {{ Val = val }};");
      Writer.WriteLine($"          OpenXmlElement.AddChild(newItem);");
    }
    else
    {
      Writer.WriteLine($"          if (val is {propItemTypeName}Impl valImpl)");
      Writer.WriteLine($"          {{");
      Writer.WriteLine($"            var item = valImpl.OpenXmlElement;");
      Writer.WriteLine($"            if (item != null)");
      Writer.WriteLine($"              OpenXmlElement.AddChild(item);");
      Writer.WriteLine($"          }};");
    }
    Writer.WriteLine($"        }}");
    Writer.WriteLine($"        break;");
    Writer.WriteLine($"      case NotifyCollectionChangedAction.Remove:");
    Writer.WriteLine($"        if (args.OldItems != null)");
    Writer.WriteLine($"        foreach (var val in args.OldItems)");
    Writer.WriteLine($"        {{");
    if (targetItemType.Type == typeof(DocumentModel.HexWord))
    {
      Writer.WriteLine($"          var oldItem = OpenXmlElement.Elements<{origItemTypeName}>()");
      Writer.WriteLine($"                        .FirstOrDefault(anItem => anItem.Val == (string?)val);");
      Writer.WriteLine($"          if (oldItem != null)");
      Writer.WriteLine($"            oldItem.Remove();");
    }
    else if (targetItemType.Type == typeof(string))
    {
      Writer.WriteLine($"      if (val is string str)");
      Writer.WriteLine($"      {{");
      Writer.WriteLine($"          var oldItem = OpenXmlElement.Elements<{origItemTypeName}>()");
      if (propItemType.Type.HasProperty("Val"))
        Writer.WriteLine($"                        .FirstOrDefault(anItem => anItem.Val == str);");
      else
        Writer.WriteLine($"                        .FirstOrDefault(anItem => anItem.Text == str);");
      Writer.WriteLine($"          if (oldItem != null)");
      Writer.WriteLine($"            oldItem.Remove();");
      Writer.WriteLine($"      }};");
    }
    else if (targetItemType.Type.IsValueType)
    {
      Writer.WriteLine($"          var oldItem = OpenXmlElement.Elements<{origItemTypeName}>()");
      var valProperty = propItemType.Type.GetProperty("Val");
      if (valProperty != null && TryGetSimpleType(valProperty.PropertyType, out var simpleType) && simpleType != null)
        Writer.WriteLine($"                        .FirstOrDefault(anItem => anItem.Val?.Value == ({simpleType.Name})val);");
      else
        Writer.WriteLine($"                        .FirstOrDefault(anItem => anItem.Val == val);");
      Writer.WriteLine($"          if (oldItem != null)");
      Writer.WriteLine($"            oldItem.Remove();");
    }
    else
    {
      Writer.WriteLine($"            if (val is {propItemTypeName}Impl valImpl)");
      Writer.WriteLine($"            {{");
      Writer.WriteLine($"                var oldItem = OpenXmlElement.Elements<{origItemTypeName}>()");
      Writer.WriteLine($"                              .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);");
      Writer.WriteLine($"               if (oldItem != null)");
      Writer.WriteLine($"                  oldItem.Remove();");
      Writer.WriteLine($"           }};");
    }
    Writer.WriteLine($"        }}");
    Writer.WriteLine($"        break;");
    Writer.WriteLine($"      default:");
    Writer.WriteLine($"        break;");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
    Writer.WriteLine();
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
  private bool GenerateIncludedStringPropAccessors(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"  get");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      var openXmlElement = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"      return openXmlElement?.Text;");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"    return null;");
    Writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"      if (item != null)");
    Writer.WriteLine($"      {{");
    Writer.WriteLine($"        if (value is not null)");
    Writer.WriteLine($"          item.Text = value;");
    Writer.WriteLine($"        else");
    Writer.WriteLine($"          item.Remove();");
    Writer.WriteLine($"      }}");
    Writer.WriteLine($"      else");
    Writer.WriteLine($"      {{");
    Writer.WriteLine($"        if (value is not null)");
    Writer.WriteLine($"        {{");
    Writer.WriteLine($"          item = new {origPropTypeName}{{ Text = value }};");
    Writer.WriteLine($"          OpenXmlElement.AddChild(item);");
    Writer.WriteLine($"        }}");
    Writer.WriteLine($"      }}");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GenerateIncludedBooleanPropAccessors(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"  get");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"      return item != null;");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"    return null;");
    Writer.WriteLine($"  }}");
    if (prop.IsReadonly)
      return true;

    Writer.WriteLine($"  set");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    if (OpenXmlElement != null)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      var item = OpenXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"      if (item != null)");
    Writer.WriteLine($"      {{");
    Writer.WriteLine($"        if (value == false)");
    Writer.WriteLine($"          item.Remove();");
    Writer.WriteLine($"      }}");
    Writer.WriteLine($"      else");
    Writer.WriteLine($"      {{");
    Writer.WriteLine($"        if (value == true)");
    Writer.WriteLine($"        {{");
    Writer.WriteLine($"          item = new {origPropTypeName}();");
    Writer.WriteLine($"          OpenXmlElement.AddChild(item);");
    Writer.WriteLine($"        }}");
    Writer.WriteLine($"      }}");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    return true;
  }

  private bool GeneratePackagePropAccessors(PropInfo prop)
  {
    Writer.WriteLine($"  get => OpenXmlElement?.{prop.Name};");
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
      return GenerateEnumType(type, typeName);
    }
  }

  private bool GenerateEnumType(TypeInfo type, string typeName)
  {
    var aNamespace = type.GetNamespace();
    if (aNamespace != null)
    {
      Writer.WriteLine($"namespace {aNamespace};");
      Writer.WriteLine();
    }
    GenerateDocumentationComments(type);
    GenerateCustomAttributes(type.CustomAttributes);
    Writer.WriteLine($"public enum {typeName}");
    Writer.WriteLine("{");
    Writer.Indent++;
    if (type.EnumValues != null)
      foreach (var field in type.EnumValues)
        if (!GenerateEnum(field))
          return false;
    Writer.Indent--;
    Writer.WriteLine("}");
    return true;
  }

  private bool GenerateEnum(EnumInfo field)
  {
    bool addEmptyLine = GenerateDocumentationComments(field);
    if (field.CustomAttributes != null)
    {
      GenerateCustomAttributes(field.CustomAttributes);
      addEmptyLine = true;
    }
    Writer.WriteLine($"{field.Name},");
    if (addEmptyLine)
      Writer.WriteLine();
    GeneratedEnumValuesCount += 1;
    return true;
  }
  #endregion

  #region CustomAttributes generation

  private bool GenerateCustomAttributes(IEnumerable<CustomAttribData>? attributes)
  {
    if (attributes?.Any() == true)
    {
      bool generated = false;
      foreach (var customAttrib in attributes)
      {
        if (customAttrib.IsAccepted is true)
          if (GenerateCustomAttribute(customAttrib))
            generated = true;
      }
      return (generated);
    }
    return false;
  }

  private bool GenerateCustomAttribute(CustomAttribData attrData)
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
    Writer.WriteLine($"[{attrString}]");
    if (attributeTypeName.Namespace != null)
      AddGlobalUsing(attributeTypeName.Namespace);
    return true;
  }
  #endregion


}

