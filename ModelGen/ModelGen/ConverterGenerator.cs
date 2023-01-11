using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

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
    if (typeInfo.Name == "AttachedTemplate")
      Debug.Assert(true);
    if (!typeInfo.IsConverted && !typeInfo.IsConvertedTo)
    {
      if (!typeInfo.IsGenericTypeParameter)
      {
        if (typeInfo.Type.IsEnum)
        {
          //Debug.WriteLine($"Skipped {typeInfo.Type}");
          SkippedTypesCount++;
        }
        else
        if (IsOpenXmlLeafEnumValueType(typeInfo.Type))
        {
          //Debug.WriteLine($"Skipped {typeInfo.Type}");
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
    if (type.Name == "StyleSet")
      Debug.Assert(true);
    if (type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OpenXmlLeafElement)))
    {
      var valProperty = type.GetProperty("Val");
      if (valProperty != null && type.GetProperties().Count() == 1)
      {
        var propType = valProperty.PropertyType;
        if (propType.Name.StartsWith("EnumValue"))
        {
          var argType = propType.GenericTypeArguments.FirstOrDefault();
          if (argType != null && argType.IsEnum)
          {
            return true;
          }
        }
      }
    }
    return false;
  }

  public static Type? GetOpenXmlLeafEnumValueType(Type type)
  {
    if (type.Name == "StyleSet")
      Debug.Assert(true);
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

  public static Type? GetOpenXmlEnumValueType(Type type)
  {
    var propType = type;
    if (propType.Name.StartsWith("EnumValue"))
    {
      var argType = propType.GenericTypeArguments.FirstOrDefault();
      if (argType != null && argType.IsEnum)
      {
        return argType;
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
    if (typeName == "AdjustPoint2DType")
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
      aNamespace = aNamespace.Replace("DocumentModel", "DocumentModel.OpenXml");
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
    //if (ok && !typeInfo.Type.IsAbstract)
      ok = GenerateCreateOpenXmlElementMethod(typeInfo);
    return ok;
  }

  private bool GenerateCreateModelElementMethod(TypeInfo typeInfo)
  {
    var origTypeName = typeInfo.GetFullName(true);
    var targetTypeName = typeInfo.GetConversionTarget().GetFullName(false);
    Writer.WriteLine($"public static {targetTypeName}? CreateModelElement({origTypeName}? openXmlElement)");
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

  private bool GenerateCreateOpenXmlElementMethod(TypeInfo typeInfo)
  {
    var origTypeName = typeInfo.GetFullName(true);
    var targetTypeName = typeInfo.GetConversionTarget().GetFullName(false);
    Writer.WriteLine($"");
    //if (typeInfo.GetIncomingRelationships(Semantics.Inheritance).Count() > 0)
    //{
      Writer.WriteLine(
        $"public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>({targetTypeName}? value)");
      Writer.WriteLine($"  where OpenXmlElementType: {origTypeName}, new()");
    //}
    //else
    //  Writer.WriteLine(
    //  $"public static {origTypeName}? CreateOpenXmlElement({targetTypeName}? value)");
    Writer.WriteLine($"{{");
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
    GenerateNotImplementedException(1);
    Writer.WriteLine($"}}");
    return true;
  }
  private bool GenerateAcceptedPropertiesConversion(TypeInfo typeInfo, string? inNamespace)
  {
    if (typeInfo.Name == "GroupingKind")
      Debug.Assert(true);
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
    if (prop.Name.Contains("ItemId"))
      Debug.Assert(true);
    if (targetPropType.Type.IsEnum)
      ok = GenerateEnumPropertyGetCode(prop);
    else
    if (targetPropType.Type == typeof(String))
      ok = GenerateStringPropertyGetCode(prop);
    else
    if (targetPropType.Type == typeof(Boolean))
      ok = GenerateBooleanPropertyGetCode(prop);
    else
    if (targetPropType.Type.IsSimple())
      ok = GenerateSimplePropertyGetCode(prop);
    else
    if (targetPropType.Type.Name.StartsWith("Collection`"))
      ok = GenerateCollectionGetCode(prop);
    else 
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlSimpleType)))
      ok = GenerateSimplePropertyGetCode(prop);
    //else
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafTextElement)))
    //  ok = GenerateTextPropertyGetCode(origPropName);
    //else
    //if (prop.DeclaringType?.Type.HasProperty(origPropName) == true)
    //  ok = GenerateConvertedPropertyGetCode(origPropName);
    else
    if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlCompositeElement)) == true)
      ok = GenerateContentElementPropertyGetCode(prop);
    //else
    //  ok = GenerateSimplePropertyGetCode(origPropName);
    else
      ok = GenerateNotImplementedException(1);
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
    if (prop.Name.Contains("ItemId"))
      Debug.Assert(true); ;
    if (targetPropType.Type.IsEnum)
      ok = GenerateEnumPropertySetCode(prop);
    else
    if (targetPropType.Type == typeof(string))
      ok = GenerateStringPropertySetCode(prop);
    else
    if (targetPropType.Type == typeof(Boolean))
      ok = GenerateBooleanPropertySetCode(prop);
    else
    if (targetPropType.Type.IsSimple())
      ok = GenerateSimplePropertySetCode(prop);
    else
    if (targetPropType.Type.Name.StartsWith("Collection`"))
      ok = GenerateCollectionSetCode(prop);
    //else 
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Wordprocessing.StringType)))
    //  ok = GenerateStringTypePropertySetCode(origPropName, origPropTypeName);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlSimpleType)))
      ok = GenerateSimplePropertySetCode(prop);
    //else
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafTextElement)))
    //  ok = GenerateTextPropertySetCode(origPropName, origPropTypeName);
    //else
    //if (prop.DeclaringType?.Type.HasProperty(origPropName) == true)
    //  ok = GenerateConvertedPropertySetCode(origPropName);
    else
    if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlCompositeElement)) == true)
      ok = GenerateContentElementPropertySetCode(prop);
    //else
    //  ok = GenerateSimplePropertySetCode(origPropName);
    else
      ok = GenerateNotImplementedException(1);
    Writer.Indent--;
    Writer.WriteLine($"}}");
    return ok;
  }
  #endregion

  #region Simple property access code generation


  private bool GenerateSimplePropertyGetCode(string origPropName)
  {
    //if (prop.Name.Contains("Width"))
    //  Debug.Assert(true);
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

  private bool GenerateSimplePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    //var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    //var origPropType = prop.PropertyType;
    var targetPropType = prop.PropertyType.GetConversionTarget();
    var targetPropTypeName = targetPropType.GetFullName(false);
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    if (origPropName.Contains("Border"))
      Debug.Assert(true);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Int16Value))
        || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Int32Value))
        || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Int64Value))
        || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.IntegerValue))
        || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.UInt16Value))
        || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.UInt32Value))
        || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.UInt64Value))
        || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.DateTimeValue))
        || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.SingleValue))
        || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.DoubleValue))
        || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.DecimalValue))
       )
    {
      if (prop.DeclaringType?.Type.HasProperty(origPropName) == true)
        return GenerateSimpleValuePropertyGetCode(origPropName);
      else
        return GenerateNotImplementedException($"type {prop.DeclaringType?.Type} has no property \\\"{origPropName}\\\"");
    }
    else
    {
      return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
    }
  }

  private bool GenerateSimplePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    //var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    //var origPropType = prop.PropertyType;
    var targetPropType = prop.PropertyType.GetConversionTarget();
    var targetPropTypeName = targetPropType.GetFullName(false);
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    if (origPropName.Contains("Border"))
      Debug.Assert(true);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Int16Value))
      || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Int32Value))
      || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Int64Value))
      || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.IntegerValue))
      || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.UInt16Value))
      || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.UInt32Value))
      || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.UInt64Value))
      || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.DateTimeValue))
      || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.SingleValue))
      || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.DoubleValue))
      || prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.DecimalValue))
      )
    {
      if (prop.DeclaringType?.Type.HasProperty(origPropName) == true)
        return GenerateSimpleValuePropertySetCode(origPropName);
      else
        return GenerateNotImplementedException($"type {prop.DeclaringType?.Type} has no property \\\"{origPropName}\\\"");
    }
    else
    {
      return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
    }
  }

  private bool GenerateSimpleValuePropertyGetCode(string origPropName)
  {
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Value;");
    return true;
  }

  private bool GenerateSimpleValuePropertySetCode(string origPropName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = value;");
    return true;
  }
  #endregion

  #region Enum property access code generation

  private bool GenerateEnumPropertyGetCode(PropInfo prop)
  {
    if (prop.PropertyType.Name.StartsWith("EnumValues`"))
      return GenerateEnumTypePropertyGetCode(prop);
    else if (prop.PropertyType.Name.StartsWith("EnumValue`"))
      return GenerateEnumTypePropertyGetCode(prop);
    else if (prop.PropertyType.Name.StartsWith("OpenXmlSimpleValue`"))
      return GenerateEnumTypePropertyGetCode(prop);
    else if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
      return GenerateContentEnumValPropertyGetCode(prop);
    else
      return GenerateNotImplementedException(1);
  }

  private bool GenerateEnumPropertySetCode(PropInfo prop)
  {
    if (prop.PropertyType.Name.StartsWith("EnumValues`"))
      return GenerateEnumTypePropertySetCode(prop);
    else if (prop.PropertyType.Name.StartsWith("EnumValue`"))
      return GenerateEnumTypePropertySetCode(prop);
    else if (prop.PropertyType.Name.StartsWith("OpenXmlSimpleValue`"))
      return GenerateEnumTypePropertySetCode(prop);
    else if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
      return GenerateContentEnumValPropertySetCode(prop);
    else
      return GenerateNotImplementedException(1);
  }

  private bool GenerateEnumTypePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType.Type;
    var origPropValueType = GetOpenXmlEnumValueType(origPropType);
    var targetPropType = prop.PropertyType.GetConversionTarget();
    if (origPropValueType != null && targetPropType != null)
    {
      var origPropValueTypeName = origPropValueType.FullName;
      var targetPropTypeName = targetPropType.GetFullName(false);
      Writer.WriteLine(
        $"return EnumValueConverter.GetValue<{origPropValueTypeName}, {targetPropTypeName}>(openXmlElement?.{origPropName}?.Value);");
      return true;
    }
    return GenerateNotImplementedException(1);
  }

  private bool GenerateEnumTypePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType.Type;
    var origPropValueType = GetOpenXmlEnumValueType(origPropType);
    var targetPropType = prop.PropertyType.GetConversionTarget();
    if (origPropValueType != null && targetPropType != null)
    {
      var origPropValueTypeName = origPropValueType.FullName;
      var targetPropTypeName = targetPropType.GetFullName(false);
      Writer.WriteLine($"if (openXmlElement != null)");
      Writer.WriteLine($"  openXmlElement.{origPropName} = EnumValueConverter.CreateEnumValue<{origPropValueTypeName}, {targetPropTypeName}>(value);");
      return true;
    }
    return GenerateNotImplementedException(1);
  }
  #endregion

  #region String property access code generation

  private bool GenerateStringPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    //var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    //var origPropType = prop.PropertyType;
    var targetPropType = prop.PropertyType.GetConversionTarget();
    var targetPropTypeName = targetPropType.GetFullName(false);
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    if (origPropName.Contains("Border"))
      Debug.Assert(true);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.StringValue)))
    {
      if (prop.DeclaringType?.Type.HasProperty(origPropName) == true)
        return GenerateStringValuePropertyGetCode(origPropName);
      else
        return GenerateNotImplementedException($"type {prop.DeclaringType?.Type} has no property \\\"{origPropName}\\\"");
    }
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Wordprocessing.StringType)))
    {
      if (prop.DeclaringType?.Type.HasProperty(origPropName) == true)
        return GenerateStringTypePropertyGetCode(origPropName);
      else
        return GenerateNotImplementedException($"type {prop.DeclaringType?.Type} has no property \\\"{origPropName}\\\"");
    }
    else
    {
      return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
    }
  }

  private bool GenerateStringPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    //var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    //var origPropType = prop.PropertyType;
    var targetPropType = prop.PropertyType.GetConversionTarget();
    var targetPropTypeName = targetPropType.GetFullName(false);
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    if (origPropName.Contains("Border"))
      Debug.Assert(true);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.StringValue)))
    {
      if (prop.DeclaringType?.Type.HasProperty(origPropName) == true)
        return GenerateStringValuePropertySetCode(origPropName);
      else
        return GenerateNotImplementedException($"type {prop.DeclaringType?.Type} has no property \\\"{origPropName}\\\"");
    }
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Wordprocessing.StringType)))
    {
      if (prop.DeclaringType?.Type.HasProperty(origPropName) == true)
        return GenerateStringTypePropertySetCode(origPropName, origPropTypeName);
      else
        return GenerateNotImplementedException($"type {prop.DeclaringType?.Type} has no property \\\"{origPropName}\\\"");
    }
    else
    {
      return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
    }
  }

  private bool GenerateStringValuePropertyGetCode(string origPropName)
  {
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Value;");
    return true;
  }


  private bool GenerateStringValuePropertySetCode(string origPropName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"    openXmlElement.{origPropName} = new StringValue {{ Value = value }};");
    Writer.WriteLine($"  else");
    Writer.WriteLine($"    openXmlElement.{origPropName} = null;");
    return true;
  }

  private bool GenerateStringTypePropertyGetCode(string origPropName)
  {
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Val?.Value;");
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

  #region Boolean property access code generation

  private bool GenerateBooleanPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    //var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    //var origPropType = prop.PropertyType;
    var targetPropType = prop.PropertyType.GetConversionTarget();
    var targetPropTypeName = targetPropType.GetFullName(false);
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    //if (origPropName.Contains("Border"))
    //  Debug.Assert(true);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.BooleanValue)))
      return GenerateBooleanValuePropertyGetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OnOffValue)))
      return GenerateBooleanOnOffValueGetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.TypedOpenXmlLeafElement)))
      return GenerateBooleanTypedOpenXmlLeafElementPropertyGetCode(prop);
    else
      return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }

  private bool GenerateBooleanPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    //var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    //var origPropType = prop.PropertyType;
    var targetPropType = prop.PropertyType.GetConversionTarget();
    var targetPropTypeName = targetPropType.GetFullName(false);
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    if (origPropName.Contains("Border"))
      Debug.Assert(true);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.BooleanValue)))
      return GenerateBooleanValuePropertySetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OnOffValue)))
      return GenerateBooleanOnOffValueSetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.TypedOpenXmlLeafElement)))
      return GenerateBooleanTypedOpenXmlLeafElementPropertySetCode(prop);
    else
      return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }

  private bool GenerateBooleanValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    //var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    //var origPropType = prop.PropertyType;
    //var targetPropType = prop.PropertyType.GetConversionTarget();
    //var targetPropTypeName = targetPropType.GetFullName(false);
    //var origPropTypeName = prop.PropertyType.GetFullName(true);
    if (prop.DeclaringType?.Type.HasProperty(origPropName) == true)
    {
      Writer.WriteLine($"return openXmlElement?.{origPropName}?.Value;");
      return true;
    }
    else
      return GenerateNotImplementedException($"type {prop.DeclaringType?.Type} has no property \\\"{origPropName}\\\"");
  }
  private bool GenerateBooleanValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"    openXmlElement.{origPropName} = new BooleanValue {{ Value = (Boolean)value }};");
    Writer.WriteLine($"  else");
    Writer.WriteLine($"    openXmlElement.{origPropName} = null;");
    return true;
  }

  private bool GenerateBooleanOnOffValueGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Value;");
    return true;
  }
  private bool GenerateBooleanOnOffValueSetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"    openXmlElement.{origPropName} = new OnOffValue {{ Value = (Boolean)value }};");
    Writer.WriteLine($"  else");
    Writer.WriteLine($"    openXmlElement.{origPropName} = null;");
    return true;
  }
  private bool GenerateBooleanTypedOpenXmlLeafElementPropertyGetCode(PropInfo prop)
  {
    //var origPropName = prop.Name;
    //var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    //var targetPropType = prop.PropertyType.GetConversionTarget();
    //var targetPropTypeName = targetPropType.GetFullName(false);
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"  return itemElement != null;");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateBooleanTypedOpenXmlLeafElementPropertySetCode(PropInfo prop)
  {
    //var origPropName = prop.Name;
    //var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    //var targetPropType = prop.PropertyType.GetConversionTarget();
    //var targetPropTypeName = targetPropType.GetFullName(false);
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  if (value == false)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"    if (itemElement != null)");
    Writer.WriteLine($"      itemElement.Remove();");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"  if (value == true)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    var itemElement = new {origPropTypeName}();");
    Writer.WriteLine($"    openXmlElement.AddChild(itemElement);");
    Writer.WriteLine($"  }}");
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
  private bool GenerateContentElementPropertyGetCode(PropInfo prop)
  {
    var origPropItemTypeName = prop.PropertyType.GetFullName(true);
    var targetPropTypeName = prop.PropertyType.GetConversionTarget().GetFullName();
    Writer.WriteLine($"var itemElement = openXmlElement?.GetFirstChild<{origPropItemTypeName}>();");
    Writer.WriteLine($"if (itemElement != null)");
    Writer.WriteLine($"  return {ConverterGetMethodName(targetPropTypeName)}(itemElement);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateContentElementPropertySetCode(PropInfo prop)
  {
    var origPropItemTypeName = prop.PropertyType.GetFullName(true);
    var targetPropType = prop.PropertyType.GetConversionTarget();
    var targetPropTypeName = targetPropType.GetFullName(false);
    if (targetPropTypeName.Name == "AdjustPoint2DType")
      Debug.Assert(true);
    //var generic = targetPropType.GetIncomingRelationships(Semantics.Inheritance).Count() > 0;
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var itemElement = openXmlElement.GetFirstChild<{origPropItemTypeName}>();");
    Writer.WriteLine($"  if (itemElement != null)");
    Writer.WriteLine($"    itemElement.Remove();");
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    itemElement = {ConverterCreateMethodName(targetPropTypeName, origPropItemTypeName)}(value);");
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
    if (prop.Name.StartsWith("Grouping"))
      Debug.Assert(true);
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
    return GenerateNotImplementedException(1);

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
    return GenerateNotImplementedException(1);
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

  private bool GenerateCollectionGetCode(PropInfo prop)
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
      if (origItemTypeName.Name.EndsWith("Part"))
        return GenerateCollectionOfPartsGetCode(prop, origItemTypeName, targetItemTypeName);
      else
      if (origItemTypeName.Name.EndsWith("IdPartPair"))
        return GenerateCollectionOfPartsGetCode(prop, origItemTypeName, targetItemTypeName);
      else
      if (origItemTypeName.Name.EndsWith("Relationship"))
        return GenerateCollectionOfRelationshipGetCode(prop, origItemTypeName, targetItemTypeName);
      else
        return GenerateCollectionOfElementsGetCode(prop, origItemTypeName, targetItemTypeName);
    }
    else
    {
      return GenerateNotImplementedException(1);
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
      if (origItemTypeName.Name.EndsWith("Part"))
        return GenerateCollectionOfPartsSetCode(prop, origItemTypeName, targetItemTypeName);
      else
      if (origItemTypeName.Name.EndsWith("IdPartPair"))
        return GenerateCollectionOfPartsSetCode(prop, origItemTypeName, targetItemTypeName);
      else
      if (origItemTypeName.Name.EndsWith("Relationship"))
        return GenerateCollectionOfRelationshipSetCode(prop, origItemTypeName, targetItemTypeName);
      else
        return GenerateCollectionOfElementsSetCode(prop, origItemTypeName, targetItemTypeName);
    }
    else
    {
      GenerateNotImplementedException(1);
      return false;
    }
  }

  private bool GenerateCollectionOfElementsGetCode(PropInfo prop, FullTypeName origItemTypeName, FullTypeName targetItemTypeName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var collection = new System.Collections.ObjectModel.Collection<{targetItemTypeName}>();");
    Writer.WriteLine($"  foreach (var item in openXmlElement.Elements<{origItemTypeName}>())");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    var newItem = {ConverterGetMethodName(targetItemTypeName)}(item);");
    Writer.WriteLine($"    if (newItem != null)");
    Writer.WriteLine($"      collection.Add({ConverterTypeCast(targetItemTypeName)}newItem);");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"  return collection;");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateCollectionOfElementsSetCode(PropInfo part, FullTypeName origItemTypeName, FullTypeName targetItemTypeName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  openXmlElement.RemoveAllChildren<{origItemTypeName}>();");
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    foreach (var item in value)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      var newItem = {ConverterCreateMethodName(targetItemTypeName, origItemTypeName)}(item);");
    Writer.WriteLine($"      if (newItem != null)");
    Writer.WriteLine($"        openXmlElement.AddChild(newItem);");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
    return true;
  }

  private bool GenerateCollectionOfPartsGetCode(PropInfo prop, FullTypeName origItemTypeName, FullTypeName targetItemTypeName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var collection = new System.Collections.ObjectModel.Collection<{targetItemTypeName}>();");
    if (origItemTypeName.Name == "IdPartPair")
      Writer.WriteLine($"  foreach (var item in openXmlElement.Parts)");
    else
    if (origItemTypeName.Name == "DataPart")
      Writer.WriteLine($"  foreach (var item in openXmlElement.DataParts)");
    else
      Writer.WriteLine($"  foreach (var item in openXmlElement.GetPartsOfType<{origItemTypeName}>())");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    var newItem = {ConverterGetMethodName(targetItemTypeName)}(item);");
    Writer.WriteLine($"    if (newItem != null)");
    Writer.WriteLine($"      collection.Add({ConverterTypeCast(targetItemTypeName)}newItem);");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"  return collection;");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateCollectionOfPartsSetCode(PropInfo prop, FullTypeName origItemTypeName, FullTypeName targetItemTypeName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  openXmlElement.RemoveAllChildren<{origItemTypeName}>();");
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    foreach (var item in value)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      var newItem = {ConverterCreateMethodName(targetItemTypeName, origItemTypeName)}(item);");
    Writer.WriteLine($"      if (newItem != null)");
    Writer.WriteLine($"        openXmlElement.AddChild({ConverterTypeCast(targetItemTypeName)}newItem);");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
    return true;
  }

  private bool GenerateCollectionOfRelationshipGetCode(PropInfo prop, FullTypeName origItemTypeName, string targetItemTypeName)
  {
    //var converterTypeName = targetItemTypeName.Replace("DocumentModel.", "DocumentModel.OpenXml.") + "Converter";
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var collection = new System.Collections.ObjectModel.Collection<{targetItemTypeName}>();");
    Writer.WriteLine($"  foreach (var item in openXmlElement.{origItemTypeName.Name}s)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    var newItem = {ConverterGetMethodName(targetItemTypeName)}(item);");
    Writer.WriteLine($"    if (newItem != null)");
    Writer.WriteLine($"      collection.Add(newItem);");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"  return collection;");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateCollectionOfRelationshipSetCode(PropInfo prop, FullTypeName origItemTypeName, string targetItemTypeName)
  {
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  openXmlElement.RemoveAllChildren<{origItemTypeName}>();");
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    foreach (var item in value)");
    Writer.WriteLine($"    {{");
    Writer.WriteLine($"      var newItem = {ConverterCreateMethodName(targetItemTypeName, origItemTypeName)}(item);");
    Writer.WriteLine($"      if (newItem != null)");
    Writer.WriteLine($"        openXmlElement.AddChild(newItem);");
    Writer.WriteLine($"    }}");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
    return true;
  }

  #endregion

  #region GenerateNotImplementedException

  private bool GenerateNotImplementedException(int point, [CallerMemberName] string? callerName = null)
  {
    string? message = $"\"Not implemented in {callerName}: {point}\"";
    Writer.WriteLine($"throw new NotImplementedException({message});");
    return true;
  }
  private bool GenerateNotImplementedException(string msg, [CallerMemberName] string? callerName = null)
  {
    string? message = $"\"Not implemented in {callerName}: {msg}\"";
    Writer.WriteLine($"throw new NotImplementedException({message});");
    return true;
  }
  #endregion

  #region ConverterInvokeMethods

  private string ConverterGetMethodName(FullTypeName origPropName)
  {
    if (origPropName.Name == "String")
      return "StringValueConverter.GetValue";
    if (origPropName.Name == "UInt32")
      return "UInt32ValueConverter.GetValue";
    if (origPropName.Name == "HexWord")
      return "HexWordConverter.GetValue";
    if (origPropName.Name == "HexBinary")
      return "HexBinaryConverter.GetValue";
    if (origPropName.Name == "Base64Binary")
      return "Base64BinaryConverter.GetValue";
    var convPropName = new FullTypeName(origPropName.Name + "Converter", origPropName.Namespace?.Replace("DocumentModel", "DocumentModel.OpenXml"));
    return $"{convPropName}.CreateModelElement";
  }

  private string ConverterCreateMethodName(FullTypeName targetPropName, FullTypeName origPropElementName)
  {
    bool generic = true;
    if (targetPropName.Name == "String")
      return $"StringValueConverter.CreateOpenXmlElement<{origPropElementName}>";
    if (targetPropName.Name == "UInt32")
      return $"UInt32ValueConverter.CreateOpenXmlElement<{origPropElementName}>";
    if (targetPropName.Name == "HexWord")
      return $"HexWordConverter.CreateOpenXmlElement<{origPropElementName}>";
    if (targetPropName.Name == "HexBinary")
      return $"HexBinaryConverter.CreateOpenXmlElement<{origPropElementName}>";
    if (targetPropName.Name == "Base64Binary")
      return $"Base64BinaryConverter.CreateOpenXmlElement<{origPropElementName}>";
    var convPropName = new FullTypeName(targetPropName.Name + "Converter", 
      targetPropName.Namespace.Replace("DocumentModel", "DocumentModel.OpenXml"));
    var convCreateMethodName = $"{convPropName}.CreateOpenXmlElement";
    if (generic)
      convCreateMethodName += $"<{origPropElementName}>";
    return convCreateMethodName;
  }

  private string? ConverterTypeCast(FullTypeName origPropName)
  {
    if (origPropName.Name == "String")
      return "(string)";
    if (origPropName.Name == "UInt32")
      return "(UInt32)";
    if (origPropName.Name == "HexWord")
      return "(HexWord)";
    return null;
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