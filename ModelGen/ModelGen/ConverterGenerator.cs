using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

using DocumentFormat.OpenXml;

using Qhta.TypeUtils;


namespace ModelGen;

public class ConverterGenerator : BaseCodeGenerator
{
  public int SkippedTypesCount { get; private set; }

  public ConverterGenerator(string projectName, string outputPath)
  {
    ProjectName = projectName + ".OpenXml";
    OutputPath = outputPath + ".OpenXml";
  }

  public bool GenerateConverterFile(TypeInfo typeInfo)
  {
    if (!typeInfo.IsConverted && !typeInfo.IsConvertedTo)
    {
      if (!typeInfo.IsGenericTypeParameter)
      {
        if (typeInfo.Type.IsEnum)
        {
          Debug.WriteLine($"Skipped {typeInfo.Type}");
          SkippedTypesCount++;
        }
        else
        if (IsOpenXmlLeafEnumValueType(typeInfo.Type))
        {
          Debug.WriteLine($"Skipped {typeInfo.Type}");
          SkippedTypesCount++;
        }
        else
          GenerateConverterClass(typeInfo);
      }
      return true;
    }
    return false;
  }

  public static bool IsOpenXmlLeafEnumValueType(Type type)
  {
    return GetOpenXmlLeafEnumValueType(type) != null;
  }

  public static Type? GetOpenXmlLeafEnumValueType(Type type)
  {
    if (type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OpenXmlLeafElement)))
    {
      var valProperty = type.GetProperty("Val");
      if (valProperty != null)
      {
        var propType = valProperty.PropertyType;
        if (propType.Name.StartsWith("EnumValue"))
        {
          var argType = propType.GenericTypeArguments.FirstOrDefault();
          if (argType != null && argType.IsEnum)
          {
            return argType;
          }
        }
      }
    }
    return null;
  }


  #region Converter class generation
  private bool GenerateConverterClass(TypeInfo type)
  {
    var typeName = type.Name;
    var aNamespace = type.Namespace;
    aNamespace = aNamespace.Replace("DocumentModel.", "");
    var implOutputPath = Path.Combine(OutputPath, aNamespace);
    return GenerateConverterClass(type, typeName, Path.Combine(implOutputPath, typeName + "Converter" + ".cs"));
  }

  private bool GenerateConverterClass(TypeInfo type, string typeName, string filename)
  {
    if (typeName=="CustomProperties")
      Debug.Assert(true);
    if (!AssurePathExists(filename))
      return false;
    using (var textWriter = File.CreateText(filename))
    using (Writer = new IndentedTextWriter(textWriter, "  "))
    {
      return GenerateConverterClass(type, typeName);
    }
  }

  private bool GenerateConverterClass(TypeInfo typeInfo, string typeName)
  {
    var aNamespace = typeInfo.Namespace;
    if (aNamespace != null)
    {
      aNamespace = aNamespace.Replace("DocumentModel.", "DocumentModel.OpenXml.");
      Writer.WriteLine($"namespace {aNamespace};");
      Writer.WriteLine();
    }

    GenerateDocumentationComments(typeInfo);
    GenerateCustomAttributes(typeInfo.CustomAttributes);

    typeName += "Converter";
    var str = $"public static class {typeName}";
    Writer.WriteLine(str);

    Writer.WriteLine("{");
    Writer.Indent++;

    var ok = GenerateAcceptedPropertiesConversion(typeInfo, aNamespace);

    if (ok)
      ok = GenerateConversionMethods(typeInfo);

    Writer.Indent--;
    Writer.WriteLine("}");
    GeneratedClassesCount += 1;
    return ok;
  }

  private bool GenerateConversionMethods(TypeInfo typeInfo)
  {
    var ok = GenerateCreateModelElementMethod(typeInfo);
    if (ok && !typeInfo.Type.IsAbstract)
      ok = GenerateCreateOpenXmlElementMethod(typeInfo);
    return ok;
  }

  private bool GenerateCreateModelElementMethod(TypeInfo typeInfo)
  {
    //var origTypeName = typeInfo.GetFullName(true);
    //var targetTypeName = typeInfo.GetConversionTarget().GetFullName(false);
    //Writer.WriteLine($"public static {targetTypeName}? CreateModelElement({origTypeName}? openXmlElement)");
    //Writer.WriteLine($"{{");
    //Writer.Indent++;
    //Writer.WriteLine($"if (openXmlElement != null)");
    //Writer.WriteLine($"{{");
    //Writer.Indent++;
    //Writer.WriteLine($"var value = new {targetTypeName}();");
    //if (typeInfo.Properties != null)
    //  foreach (var prop in typeInfo.Properties.Where(item => item.IsAccepted != false))
    //  {
    //    var origPropName = prop.Name;
    //    Writer.WriteLine($"value.{origPropName} = Get{origPropName}(openXmlElement);");
    //  }
    //Writer.WriteLine($"return value;");
    //Writer.Indent--;
    //Writer.WriteLine($"}}");
    //Writer.WriteLine($"return null;");
    //Writer.Indent--;
    //Writer.WriteLine($"}}");
    return true;
  }

  private bool GenerateCreateOpenXmlElementMethod(TypeInfo typeInfo)
  {
    //var origTypeName = typeInfo.GetFullName(true);
    //var targetTypeName = typeInfo.GetConversionTarget().GetFullName(false);
    //Writer.WriteLine($"");
    //Writer.WriteLine(
    //  $"public static {origTypeName}? CreateOpenXmlElement({targetTypeName}? value)");
    //Writer.WriteLine($"{{");
    //Writer.Indent++;
    //Writer.WriteLine($"if (value != null)");
    //Writer.WriteLine($"{{");
    //Writer.WriteLine($"  var openXmlElement = new {origTypeName}();");
    //if (typeInfo.Properties != null)
    //  foreach (var prop in typeInfo.Properties.Where(item => item.IsAccepted != false))
    //  {
    //    var origPropName = prop.Name;
    //    Writer.WriteLine($"  Set{origPropName}(openXmlElement, value?.{origPropName});");
    //  }

    ////Writer.WriteLine($"  SetValue(openXmlElement, value);");
    //Writer.WriteLine($"  return openXmlElement;");
    //Writer.WriteLine($"}}");
    //Writer.WriteLine($"return null;");
    //Writer.Indent--;
    //Writer.WriteLine($"}}");
    return true;
  }
  private bool GenerateAcceptedPropertiesConversion(TypeInfo typeInfo, string? inNamespace)
  {
    var ok = true;
    if (typeInfo.AcceptedProperties != null)
      foreach (var prop in typeInfo.AcceptedProperties)
        //if (kind == TypeKind.Interface || !prop.IsConstrained)
        if (!GeneratePropertyAccessors(prop, inNamespace))
          ok = false;
    return ok;
  }

  private bool GenerateItemsProperties(TypeInfo typeInfo, ItemsConstraint constraint, string fromClassName, string? inNamespace,
    List<string> subclassesTypeNames)
  {
    var ok = true;
    if (constraint is ItemTypeConstraint itemTypeConstraint)
    {
      var prop = itemTypeConstraint.AccessProperty;
      if (prop != null)
        if (!GeneratePropertyAccessors(prop, inNamespace))
          ok = false;
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
          if (!GenerateItemsProperties(typeInfo, itemConstraint, constraintClassName, inNamespace, subclassesTypeNames))
            ok = false;
        }
      }
    }
    return ok;
  }

  private bool GeneratePropertyAccessors(PropInfo prop, string? inNamespace)
  {
    if (prop.PropertyType?.Type == null)
      return false;
    if (!IsOpenXmlLeafEnumValueType(prop.PropertyType.Type))
      return true;
    var ok = true;
    var targetPropType = prop.PropertyType.GetConversionTarget(true);
    GenerateDocumentationComments(prop);
    GenerateCustomAttributes(prop.CustomAttributes);
    if (!GeneratePropertyAccessors(prop))
      ok = false;

    Writer.WriteLine();
    GeneratedPropertiesCount += 1;
    return ok;
  }

  private bool GeneratePropertyAccessors(PropInfo prop)
  {
    var ok1 = GeneratePropertyGetter(prop);
    if (prop.IsReadonly)
      return ok1;
    var ok2 = GeneratePropertySetter(prop);
    return ok1 && ok2;
  }

  private bool GeneratePropertyGetter(PropInfo prop)
  {
    var ok = false;
    var origPropName = prop.Name;
    var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    var origPropType = prop.PropertyType;
    var targetPropType = prop.PropertyType.GetConversionTarget();
    var targetPropTypeName = targetPropType.GetFullName(false);
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"public static {targetPropTypeName}? Get{origPropName}({origTypeName}? openXmlElement)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    //if (origPropName == "ConnectionShape")
    //  Debug.Assert(true);
    if (targetPropType.Type.IsEnum)
      ok = GenerateEnumPropertyGetCode(prop);
    //else 
    //if (targetPropType.Type.Name.StartsWith("Collection`"))
    //  ok = GenerateCollectionGetCode(prop, origPropType, targetPropType);
    //else
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Wordprocessing.StringType)))
    //  ok = GenerateStringTypePropertyGetCode(origPropName);
    //else 
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlSimpleType)))
    //  ok = GenerateSimpleTypePropertyGetCode(origPropName);
    //else
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafTextElement)))
    //  ok = GenerateTextPropertyGetCode(origPropName);
    //else
    //if (prop.DeclaringType?.Type.HasProperty(origPropName) == true)
    //  ok = GenerateConvertedPropertyGetCode(origPropName);
    //else
    //if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlCompositeElement)) == true)
    //  ok = GenerateContentElementPropertyGetCode(origPropName);
    //else
    //  ok = GenerateSimplePropertyGetCode(origPropName);
    else
      ok = GenerateThrowNotImplementedException(1);
    Writer.Indent--;
    Writer.WriteLine($"}}");
    return ok;
  }

  private bool GeneratePropertySetter(PropInfo prop)
  {
    bool ok = false;
    var origPropName = prop.Name;
    var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    var origPropType = prop.PropertyType;
    var targetPropType = prop.PropertyType.GetConversionTarget();
    var targetPropTypeName = targetPropType.GetFullName(false);
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"");
    Writer.WriteLine($"public static void Set{origPropName}({origTypeName}? openXmlElement, {targetPropTypeName}? value)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    if (targetPropType.Type.IsEnum)
      ok = GenerateEnumPropertySetCode(prop);
    //else
    //if (targetPropType.Type.Name.StartsWith("Collection`"))
    //  ok = GenerateCollectionSetCode(prop);
    //else 
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Wordprocessing.StringType)))
    //  ok = GenerateStringTypePropertySetCode(origPropName, origPropTypeName);
    //else
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlSimpleType)))
    //  ok = GenerateSimpleTypePropertySetCode(origPropName);
    //else
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafTextElement)))
    //  ok = GenerateTextPropertySetCode(origPropName, origPropTypeName);
    //else
    //if (prop.DeclaringType?.Type.HasProperty(origPropName) == true)
    //  ok = GenerateConvertedPropertySetCode(origPropName);
    //else
    //if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlCompositeElement)) == true)
    //  ok = GenerateContentElementPropertySetCode(origPropName);
    //else
    //  ok = GenerateSimplePropertySetCode(origPropName);
    else
      ok = GenerateThrowNotImplementedException(1);
    Writer.Indent--;
    Writer.WriteLine($"}}");
    return ok;
  }
  #endregion

  #region Simple property access code generation
  private bool GenerateSimplePropertyGetCode(string origPropName)
  {
    Writer.WriteLine($"return openXmlElement?.{origPropName};");
    return true;
  }

  private bool GenerateSimplePropertySetCode(string origPropName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = value;");
    return true;
  }
  #endregion

  #region Simple property access code generation
  private bool GenerateSimpleTypePropertyGetCode(string origPropName)
  {
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Value;");
    return true;
  }

  private bool GenerateSimpleTypePropertySetCode(string origPropName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = value;");
    return true;
  }
  #endregion

  #region Enum property access code generation

  private bool GenerateEnumPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    //var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    //var origPropType = prop.PropertyType;
    var targetPropType = prop.PropertyType.GetConversionTarget();
    var targetPropTypeName = targetPropType.GetFullName(false);
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    if (origPropName.Contains("Border"))
      Debug.Assert(true);
    if (prop.PropertyType.Name.StartsWith("EnumValues`"))
      return GenerateEnumTypePropertyGetCode(origPropName, targetPropTypeName);
    else if (prop.PropertyType.Name.StartsWith("EnumValue`"))
      return GenerateEnumTypePropertyGetCode(origPropName, targetPropTypeName);
    else if (prop.PropertyType.Name.StartsWith("OpenXmlSimpleValue`"))
      return GenerateEnumTypePropertyGetCode(origPropName, targetPropTypeName);
    else if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
      return GenerateContentEnumValPropertyGetCode(prop);
    else
    {
      GenerateThrowNotImplementedException(2);
      return false;
    }
  }

  private bool GenerateEnumPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    //var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    //var origPropType = prop.PropertyType;
    var targetPropType = prop.PropertyType.GetConversionTarget();
    var targetPropTypeName = targetPropType.GetFullName(false);
    //var origPropTypeName = prop.PropertyType.GetFullName(true);

    if (prop.PropertyType.Name.StartsWith("EnumValues`"))
      return GenerateEnumTypePropertySetCode(origPropName, targetPropTypeName);
    else if (prop.PropertyType.Name.StartsWith("EnumValue`"))
      return GenerateEnumTypePropertySetCode(origPropName, targetPropTypeName);
    else if (prop.PropertyType.Name.StartsWith("OpenXmlSimpleValue`"))
      return GenerateEnumTypePropertySetCode(origPropName, targetPropTypeName);
    else if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
      return GenerateContentEnumValPropertySetCode(prop);
    else
    {
      GenerateThrowNotImplementedException(2);
      return false;
    }
  }

  private bool GenerateEnumTypePropertyGetCode(string origPropName, string targetPropTypeName)
  {
    Writer.WriteLine($"return ({targetPropTypeName}?)openXmlElement?.{origPropName}?.Value;");
    return true;
  }

  private bool GenerateEnumTypePropertySetCode(string origPropName, string origPropTypeName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = ({origPropTypeName}?)value;");
    return true;
  }
  #endregion

  #region Enum Val property access code generation
  private bool GenerateEnumValPropertyGetCode(string origPropName, string targetPropTypeName)
  {
    Writer.WriteLine($"return ({targetPropTypeName}?)openXmlElement?.{origPropName}?.Val?.Value;");
    return true;
  }

  private bool GenerateEnumValPropertySetCode(string origPropName, string origPropTypeName, string origPropValTypeName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"    openXmlElement.{origPropName} = new {origPropTypeName} {{ Val = ({origPropValTypeName})value }};");
    Writer.WriteLine($"  else");
    Writer.WriteLine($"    openXmlElement.{origPropName} = null;");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region String property access code generation
  private bool GenerateStringTypePropertyGetCode(string origPropName)
  {
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Value?.Val;");
    return true;
  }

  private bool GenerateStringTypePropertySetCode(string origPropName, string origPropTypeName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"    openXmlElement.{origPropName} = new {origPropTypeName} {{ Val = value }};");
    Writer.WriteLine($"  else");
    Writer.WriteLine($"    openXmlElement.{origPropName} = null;");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region Converted property access code generation
  private bool GenerateConvertedPropertyGetCode(string origPropName)
  {
    Writer.WriteLine($"return {ConverterGetMethodName(origPropName)}(openXmlElement?.{origPropName});");
    return true;
  }

  private bool GenerateConvertedPropertySetCode(string origPropName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = {ConverterGetMethodName(origPropName)}(value);");
    return true;
  }
  #endregion

  #region Content element property access code generation
  private bool GenerateContentElementPropertyGetCode(string origPropName)
  {
    Writer.WriteLine($"return {ConverterGetMethodName(origPropName)}(openXmlElement?.GetFirstChild<{origPropName}>());");
    return true;
  }

  private string ConverterGetMethodName(string origPropName)
  {
    if (origPropName == "String")
      return "StringValueConverter.GetValue";
    return $"{origPropName}Converter.CreateModelElement";
  }

  private bool GenerateContentElementPropertySetCode(string origPropName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var itemElement = openXmlElement.GetFirstChild<{origPropName}>();");
    Writer.WriteLine($"  if (itemElement != null)");
    Writer.WriteLine($"    itemElement.Remove();");
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    itemElement = {origPropName}Converter.CreateOpenXmlElement(value);");
    Writer.WriteLine($"    if (itemElement != null)");
    Writer.WriteLine($"      openXmlElement.AddChild(itemElement);");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region Content enum val property access code generation
  private bool GenerateContentEnumValPropertyGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType.Type;
    var origPropValueType = GetOpenXmlLeafEnumValueType(origPropType);
    var targetPropType = prop.PropertyType.GetConversionTarget();
    if (origPropValueType != null && targetPropType != null)
    {
      var origPropValueTypeName = origPropValueType.FullName;
      var targetPropTypeName = targetPropType.GetFullName(false);
      Writer.WriteLine($"if (openXmlElement != null)");
      Writer.WriteLine($"{{");
      Writer.WriteLine($"  var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
      Writer.WriteLine($"  if (itemElement?.Val?.Value != null)");
      Writer.WriteLine($"  {{");
      Writer.WriteLine(
        $"    return EnumValueConverter.GetValue<{origPropValueTypeName}, {targetPropTypeName}>(itemElement.Val.Value);");
      Writer.WriteLine($"  }}");
      Writer.WriteLine($"}}");
      Writer.WriteLine($"return null;");
      return true;
    }
    return false;
  }

  private bool GenerateContentEnumValPropertySetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType.Type;
    var origPropValueType = GetOpenXmlLeafEnumValueType(origPropType);
    var targetPropType = prop.PropertyType.GetConversionTarget();
    if (origPropValueType != null && targetPropType != null)
    {
      var origPropValueTypeName = origPropValueType.FullName;
      var targetPropTypeName = targetPropType.GetFullName(false);
      Writer.WriteLine($"if (openXmlElement != null)");
      Writer.WriteLine($"{{");
      Writer.WriteLine($"  var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
      Writer.WriteLine($"  if (itemElement != null)");
      Writer.WriteLine($"    itemElement.Remove();");
      Writer.WriteLine($"  if (value != null)");
      Writer.WriteLine($"  {{");
      Writer.WriteLine($"    itemElement = EnumValueConverter.CreateOpenXmlElement<{origPropTypeName}, {origPropValueTypeName}, {targetPropTypeName}>(value);");
      Writer.WriteLine($"    if (itemElement != null)");
      Writer.WriteLine($"      openXmlElement.AddChild(itemElement);");
      Writer.WriteLine($"  }}");
      Writer.WriteLine($"}}");
      return true;
    }
    return false;
    /*
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Gallery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Category, DocumentFormat.OpenXml.Wordprocessing.DocPartGalleryValues, DocumentModel.Wordprocessing.DocPartGalleryKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
     */
  }
  #endregion

  #region Text property access code generation
  private bool GenerateTextPropertyGetCode(string origPropName)
  {
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Text;");
    return true;
  }

  private bool GenerateTextPropertySetCode(string origPropName, string origPropTypeName)
  {
    Writer.WriteLine($"if (openXmlElement?.{origPropName} != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"    openXmlElement.{origPropName}.Text = value;");
    Writer.WriteLine($"  else");
    Writer.WriteLine($"    openXmlElement.{origPropName} = null;");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"else");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"    openXmlElement?.AddChild(new {origPropTypeName}() {{Text = value}});");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region Collection property access code generation

  private bool GenerateCollectionGetCode(PropInfo prop, TypeInfo origPropType, TypeInfo targetPropType)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origItemType = origPropType.GetGenericArgTypes().FirstOrDefault();
    var targetItemType = targetPropType.GetGenericArgTypes().FirstOrDefault();
    if (origItemType != null && targetItemType != null)
    {
      var origItemTypeName = origItemType.GetFullName(true);
      var targetItemTypeName = targetItemType.GetFullName(false);
      return GenerateCollectionPropertyGetCode(origPropTypeName, origItemTypeName, targetItemTypeName);
    }
    else
    {
      GenerateThrowNotImplementedException(1);
      return false;
    }
  }

  private bool GenerateCollectionSetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericArgTypes().FirstOrDefault();
    var targetPropType = prop.PropertyType.GetConversionTarget();
    var targetItemType = targetPropType.GetGenericArgTypes().FirstOrDefault();
    if (origItemType != null && targetItemType != null)
    {
      var origItemTypeName = origItemType.GetFullName(true);
      var targetItemTypeName = targetItemType.GetFullName(false);
      return GenerateCollectionPropertySetCode(origPropTypeName, origItemTypeName, targetItemTypeName);
    }
    else
    {
      GenerateThrowNotImplementedException(1);
      return false;
    }
  }

  private bool GenerateCollectionPropertyGetCode(string origPropTypeName, string origItemTypeName, string targetItemTypeName)
  {
    var converterTypeName = targetItemTypeName.Replace("DocumentModel.", "DocumentModel.OpenXml.") + "Converter";
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var collection = new System.Collections.ObjectModel.Collection<{targetItemTypeName}>();");
    Writer.WriteLine($"  foreach (var item in openXmlElement.Elements<{origItemTypeName}>())");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    var newItem = {converterTypeName}.CreateModelElement(item);");
    Writer.WriteLine($"    if (newItem != null)");
    Writer.WriteLine($"      collection.Add(newItem);");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"  return collection;");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateCollectionPropertySetCode(string origPropTypeName, string origItemTypeName, string targetItemTypeName)
  {
    var converterTypeName = targetItemTypeName.Replace("DocumentModel.", "DocumentModel.OpenXml.") + "Converter";
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  openXmlElement.RemoveAllChildren<{origItemTypeName}>();");
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    foreach (var item in value)");
    Writer.WriteLine($"    {{");
    if (converterTypeName == "StringConverter")
      Writer.WriteLine($"      var newItem = {converterTypeName}.CreateOpenXmlElement<{origItemTypeName}>(item);");
    else
      Writer.WriteLine($"      var newItem = {converterTypeName}.CreateOpenXmlElement(item);");
    Writer.WriteLine($"      if (newItem != null)");
    Writer.WriteLine($"        openXmlElement.AddChild(newItem);");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
    return true;
  }

  private bool GenerateThrowNotImplementedException(int point, [CallerMemberName] string? callerName = null)
  {
    string? message = $"\"Not implemented {point} in {callerName}\"";
    Writer.WriteLine($"throw new NotImplementedException({message});");
    return true;
  }
  #endregion

  protected override bool AssurePathExists(string filename)
  {
    //if (File.Exists(filename))
    //  return false;
    var filePath = Path.GetDirectoryName(filename) ?? string.Empty;
    if (filePath.EndsWith(@"\Properties"))
      return false;
    if (filePath != null)
      if (!Directory.Exists(filePath))
      {
        Directory.CreateDirectory(filePath);
      }
    return true;
  }
}