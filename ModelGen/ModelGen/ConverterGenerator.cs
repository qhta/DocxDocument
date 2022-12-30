using System.Diagnostics;

using DocumentFormat.OpenXml;

using Qhta.TypeUtils;


namespace ModelGen;

public class ConverterGenerator : BaseCodeGenerator
{
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
        GenerateConverterClass(typeInfo);
      }
      return true;
    }
    return false;
  }

  #region Converter class generation

  private bool GenerateConverterClass(TypeInfo type)
  {
    var typeName = type.Name;
    var aNamespace = type.Namespace;
    aNamespace = aNamespace.Replace(".Properties", ".DocumentProperties");
    aNamespace = aNamespace.Replace("DocumentModel.", "");
    //var intfOutputPath = Path.Combine(IntfOutputPath, aNamespace);
    var implOutputPath = Path.Combine(OutputPath, aNamespace);
    return GenerateConverterClass(type, typeName, Path.Combine(implOutputPath, typeName + "Converter" + ".cs"));
  }

  private bool GenerateConverterClass(TypeInfo type, string typeName, string filename)
  {
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
      ok = GenerateValueAccessors(typeInfo);

    Writer.Indent--;
    Writer.WriteLine("}");
    GeneratedClassesCount += 1;
    return ok;
  }

  private bool GenerateValueAccessors(TypeInfo typeInfo)
  {
    var ok = GenerateGetValueMethod(typeInfo);
    if (ok)
      ok = GenerateSetValueMethod(typeInfo);
    if (ok && !typeInfo.Type.IsAbstract)
      ok = GenerateCreateOpenXmlElementMethod(typeInfo);
    return ok;
  }

  private bool GenerateGetValueMethod(TypeInfo typeInfo)
  {
    var origTypeName = typeInfo.GetFullName(true);
    var targetTypeName = typeInfo.GetFullName(false);
    Writer.WriteLine($"public static {targetTypeName}? GetValue({origTypeName}? openXmlElement)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    Writer.WriteLine($"var value = new {targetTypeName}();");
    if (typeInfo.Properties != null)
      foreach (var prop in typeInfo.Properties.Where(item => item.IsAccepted != false))
      {
        var origPropName = prop.Name;
        Writer.WriteLine($"value.{origPropName} = Get{origPropName}(openXmlElement);");
      }
    Writer.WriteLine($"return value;");
    Writer.Indent--;
    Writer.WriteLine($"}}");
    Writer.WriteLine($"return null;");
    Writer.Indent--;
    Writer.WriteLine($"}}");
    return true;
  }
  private bool GenerateSetValueMethod(TypeInfo typeInfo)
  {
    var origTypeName = typeInfo.GetFullName(true);
    var targetTypeName = typeInfo.GetFullName(false);
    Writer.WriteLine($"");
    Writer.WriteLine($"public static void SetValue({origTypeName}? openXmlElement, {targetTypeName}? value)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    if (typeInfo.Properties != null)
      foreach (var prop in typeInfo.Properties.Where(item => item.IsAccepted != false))
      {
        var origPropName = prop.Name;
        Writer.WriteLine($"Set{origPropName}(openXmlElement, value?.{origPropName});");
      }
    Writer.Indent--;
    Writer.WriteLine($"}}");
    Writer.Indent--;
    Writer.WriteLine($"}}");
    return true;
  }

  private bool GenerateCreateOpenXmlElementMethod(TypeInfo typeInfo)
  {
    var origTypeName = typeInfo.GetFullName(true);
    var targetTypeName = typeInfo.GetFullName(false);
    Writer.WriteLine($"");
    Writer.WriteLine(
      $"public static {origTypeName}? CreateOpenXmlElement({targetTypeName}? value)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var openXmlElement = new {origTypeName}();");
    Writer.WriteLine($"  SetValue(openXmlElement, value);");
    Writer.WriteLine($"  return openXmlElement;");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"return null;");
    Writer.Indent--;
    Writer.WriteLine($"}}");
    return true;
  }
  private bool GenerateAcceptedPropertiesConversion(TypeInfo typeInfo, string? inNamespace)
  {
    if (typeInfo.AcceptedProperties != null)
      foreach (var prop in typeInfo.AcceptedProperties)
        //if (kind == TypeKind.Interface || !prop.IsConstrained)
        if (!GeneratePropertyAccessors(prop, inNamespace))
          return false;
    return true;
  }

  private bool GenerateItemsProperties(TypeInfo typeInfo, ItemsConstraint constraint, string fromClassName, string? inNamespace,
    List<string> subclassesTypeNames)
  {
    if (constraint is ItemTypeConstraint itemTypeConstraint)
    {
      var prop = itemTypeConstraint.AccessProperty;
      if (prop != null)
        if (!GeneratePropertyAccessors(prop, inNamespace))
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
          if (!GenerateItemsProperties(typeInfo, itemConstraint, constraintClassName, inNamespace, subclassesTypeNames))
            return false;
        }
      }
    }
    return true;
  }

  private bool GeneratePropertyAccessors(PropInfo prop, string? inNamespace)
  {
    var targetPropType = prop.PropertyType.GetConversionTarget(true);
    FullTypeName targetPropTypeName = prop.PropertyType.GetConvertedName(TypeKind.Type);
    TrimNamespace(targetPropTypeName);
    GenerateDocumentationComments(prop);
    GenerateCustomAttributes(prop.CustomAttributes);
    if (!GeneratePropertyAccessors(prop, targetPropType))
      return false;

    Writer.WriteLine();
    GeneratedPropertiesCount += 1;
    return true;
  }

  private bool GeneratePropertyAccessors(PropInfo prop, TypeInfo targetPropType)
  {
    var ok = GeneratePropertyGetter(prop, targetPropType);
    if (prop.IsReadonly)
      return ok;
    if (ok)
      ok = GeneratePropertySetter(prop, targetPropType);
    return ok;
  }

  private bool GeneratePropertyGetter(PropInfo prop, TypeInfo targetPropType)
  {
    var origPropName = prop.Name;
    //if (origPropName == "EndnotePosition")
    //  Debug.Assert(true);
    var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    var targetPropTypeName = targetPropType.GetFullName(false);
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"public static {targetPropTypeName}? Get{origPropName}({origTypeName}? openXmlElement)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    if (targetPropType.Type.Name.StartsWith("Collection`"))
    {
      var itemType = targetPropType.GetGenericArgTypes().FirstOrDefault();
      if (itemType == null)
        return false;
      var origItemTypeName = itemType.GetFullName(true);
      var targetItemTypeName = itemType.GetFullName(false);
      GenerateCollectionPropertyGetCode(origPropTypeName, origItemTypeName, targetItemTypeName);
    }
    else if (targetPropType.Type.IsEnum)
    {
      if (prop.PropertyType.Name.StartsWith("EnumValues`"))
        GenerateEnumTypePropertyGetCode(origPropName, targetPropTypeName);
      else if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TypedOpenXmlLeafElement)))
        GenerateEnumValPropertyGetCode(origPropName, targetPropTypeName);
      else
        return false;
    }
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Wordprocessing.StringType)))
      GenerateStringTypePropertyGetCode(origPropName);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlSimpleType)))
      GenerateSimpleTypePropertyGetCode(origPropName);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafTextElement)))
      GenerateTextPropertyGetCode(origPropName);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlElement)))
      GenerateConvertedPropertyGetCode(origPropName);
    else
      GenerateSimplePropertyGetCode(origPropName);
    Writer.Indent--;
    Writer.WriteLine($"}}");
    return true;
  }

  private bool GeneratePropertySetter(PropInfo prop, TypeInfo targetPropType)
  {
    var origPropName = prop.Name;
    var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    var targetPropTypeName = targetPropType.GetFullName(false);
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"");
    Writer.WriteLine($"public static void Set{origPropName}({origTypeName}? openXmlElement, {targetPropTypeName}? value)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    if (targetPropType.Type.Name.StartsWith("Collection`"))
    {
      var itemType = targetPropType.GetGenericArgTypes().FirstOrDefault();
      if (itemType == null)
        return false;
      var origItemTypeName = itemType.GetFullName(true);
      var targetItemTypeName = itemType.GetFullName(false);
      GenerateCollectionPropertySetCode(origPropTypeName, origItemTypeName, targetItemTypeName);
    }
    else if (targetPropType.Type.IsEnum)
    {
      if (prop.PropertyType.Name.StartsWith("EnumValues`"))
      {
        var origEnumType = prop.PropertyType.GetGenericArgTypes().FirstOrDefault();
        if (origEnumType != null)
        {
          var origEnumTypeName = origEnumType.GetFullName(true);
          GenerateEnumTypePropertySetCode(origPropName, origEnumTypeName);
        }
      }
      else if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TypedOpenXmlLeafElement)))
      {
        var valProperty = prop.PropertyType.Type.GetProperty("Val");
        if (valProperty != null && valProperty.PropertyType.IsConstructedGenericType)
        {
          var origEnumType = valProperty.PropertyType.GenericTypeArguments.FirstOrDefault();
          if (origEnumType != null)
          {
            var origEnumTypeName = origEnumType.FullName ?? origEnumType.Name;
            GenerateEnumValPropertySetCode(origPropName, origPropTypeName, origEnumTypeName);
          }
          else
            return false;
        }
      }
      else
        return false;
    }
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Wordprocessing.StringType)))
      GenerateStringTypePropertySetCode(origPropName, origPropTypeName);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlSimpleType)))
      GenerateSimpleTypePropertySetCode(origPropName);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafTextElement)))
      GenerateTextPropertySetCode(origPropName, origPropTypeName);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlElement)))
      GenerateConvertedPropertySetCode(origPropName);

    else
      GenerateSimplePropertySetCode(origPropName);
    Writer.Indent--;
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region Simple property access code generation
  private void GenerateSimplePropertyGetCode(string origPropName)
  {
    Writer.WriteLine($"return openXmlElement?.{origPropName};");
  }

  private void GenerateSimplePropertySetCode(string origPropName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = value;");
  }
  #endregion

  #region Simple property access code generation
  private void GenerateSimpleTypePropertyGetCode(string origPropName)
  {
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Value;");
  }

  private void GenerateSimpleTypePropertySetCode(string origPropName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = value;");
  }
  #endregion

  #region Enum property access code generation
  private void GenerateEnumTypePropertyGetCode(string origPropName, string targetPropTypeName)
  {
    Writer.WriteLine($"return ({targetPropTypeName}?)openXmlElement?.{origPropName}?.Value;");
  }

  private void GenerateEnumTypePropertySetCode(string origPropName, string origPropTypeName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = ({origPropTypeName}?)value;");
  }
  #endregion

  #region Enum Val property access code generation
  private void GenerateEnumValPropertyGetCode(string origPropName, string targetPropTypeName)
  {
    Writer.WriteLine($"return ({targetPropTypeName}?)openXmlElement?.{origPropName}?.Val?.Value;");
    /*
         return (DocumentModel.Wordprocessing.EndnotePositionKind?)openXmlElement?.EndnotePosition?.Val?.Value;
     */
  }

  private void GenerateEnumValPropertySetCode(string origPropName, string origPropTypeName, string origPropValTypeName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"    openXmlElement.{origPropName} = new {origPropTypeName} {{ Val = ({origPropValTypeName})value }};");
    Writer.WriteLine($"  else");
    Writer.WriteLine($"    openXmlElement.{origPropName} = null;");
    Writer.WriteLine($"}}");
    /*
    {
      if (value != null)
        openXmlElement.EndnotePosition = new EndnotePosition { Val = (DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues)value };
      else
        openXmlElement.EndnotePosition = null;
    }
     */
  }
  #endregion

  #region String property access code generation
  private void GenerateStringTypePropertyGetCode(string origPropName)
  {
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Value?.Val;");
  }

  private void GenerateStringTypePropertySetCode(string origPropName, string origPropTypeName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"    openXmlElement.{origPropName} = new {origPropTypeName} {{ Val = value }};");
    Writer.WriteLine($"  else");
    Writer.WriteLine($"    openXmlElement.{origPropName} = null;");
    Writer.WriteLine($"}}");
  }
  #endregion

  #region Converted property access code generation
  private void GenerateConvertedPropertyGetCode(string origPropName)
  {
    Writer.WriteLine($"return {origPropName}Converter.GetValue(openXmlElement?.{origPropName});");
  }

  private void GenerateConvertedPropertySetCode(string origPropName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = {origPropName}Converter.CreateOpenXmlElement(value);");
  }
  #endregion

  #region Text property access code generation
  private void GenerateTextPropertyGetCode(string origPropName)
  {
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Text;");
  }

  private void GenerateTextPropertySetCode(string origPropName, string origPropTypeName)
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
  }
  #endregion

  #region Collection property access code generation
  private void GenerateCollectionPropertyGetCode(string origPropTypeName, string origItemTypeName, string targetItemTypeName)
  {
    var converterTypeName = targetItemTypeName.Replace("DocumentModel.", "DocumentModel.OpenXml.") + "Converter";
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var collection = new System.Collections.ObjectModel.Collection<{targetItemTypeName}>();");
    Writer.WriteLine($"  foreach (var item in openXmlElement.Elements<{origItemTypeName}>())");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    var newItem = {converterTypeName}.GetValue(item);");
    Writer.WriteLine($"    if (newItem != null)");
    Writer.WriteLine($"      collection.Add(newItem);");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"  return collection;");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"return null;");
  }

  private void GenerateCollectionPropertySetCode(string origPropTypeName, string origItemTypeName, string targetItemTypeName)
  {
    var converterTypeName = targetItemTypeName.Replace("DocumentModel.", "DocumentModel.OpenXml.") + "Converter";
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  openXmlElement.RemoveAllChildren<{origItemTypeName}>();");
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    foreach (var item in value)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      var newItem = {converterTypeName}.CreateOpenXmlElement(item);");
    Writer.WriteLine($"      if (newItem != null)");
    Writer.WriteLine($"        openXmlElement.AddChild(newItem);");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
  }
  #endregion

}