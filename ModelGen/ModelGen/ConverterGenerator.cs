using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using DocumentModel.OpenXml;

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
    Writer.Indent++;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var openXmlElement = new OpenXmlElementType();");
    if (typeInfo.Properties != null)
      foreach (var prop in typeInfo.Properties.Where(item => item.IsAccepted != false))
      {
        var origPropName = prop.Name;
        if (prop.IsReadonly)
          Writer.WriteLine($"  //Set{origPropName}(openXmlElement, value?.{origPropName});");
        else
          Writer.WriteLine($"  Set{origPropName}(openXmlElement, value?.{origPropName});");
      }
    Writer.WriteLine($"  return openXmlElement;");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"return default;");
    Writer.Indent--;
    Writer.WriteLine($"}}");
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
    var ok = true;
    var targetPropType = prop.GetTargetType();
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
    if (prop.Name == "AdjustRightIndent")
      Debug.Assert(true);
    var ok = false;
    var origPropName = prop.Name;
    var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    var origPropType = prop.PropertyType;
    var targetPropType = prop.GetTargetType();
    var targetPropTypeName = targetPropType.GetFullName(false);
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var qm = "?";
    if (targetPropType.Type.Name.StartsWith("Collection`"))
      qm = "";
    Writer.WriteLine($"private static {targetPropTypeName}{qm} Get{origPropName}({origTypeName} openXmlElement)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    if (targetPropType.Type.IsEnum)
      ok = GenerateEnumPropertyGetCode(prop);
    else
    if (targetPropType.Type == typeof(String))
      ok = GenerateStringPropertyGetCode(prop);
    else
    if (targetPropType.Type == typeof(Boolean))
      ok = GenerateBooleanPropertyGetCode(prop);
    else
    if (targetPropType.Type == typeof(Uri))
      ok = GenerateSameTypePropertyGetCode(prop);
    else
    if (targetPropType.IsSimple())
      ok = GenerateSimplePropertyGetCode(prop);
    else
    if (targetPropType.Type.Name.StartsWith("Collection`"))
      ok = GenerateCollectionGetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlSimpleType)))
      ok = GenerateSimplePropertyGetCode(prop);
    else
    if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlCompositeElement)) == true)
      ok = GenerateContentElementPropertyGetCode(prop);
    else
    if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlPart)) == true && prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlPartRootElement)))
      ok = GeneratePartRootElementPropertyGetCode(prop);
    else
      ok = GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
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
    var targetPropType = prop.GetTargetType();
    var targetPropTypeName = targetPropType.GetFullName(false);
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"");
    Writer.WriteLine($"private static void Set{origPropName}({origTypeName} openXmlElement, {targetPropTypeName}? value)");
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
    if (targetPropType.IsSimple())
      ok = GenerateSimplePropertySetCode(prop);
    else
    if (targetPropType.Type.Name.StartsWith("Collection`"))
      ok = GenerateCollectionSetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlSimpleType)))
      ok = GenerateSimplePropertySetCode(prop);
    else
    if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlCompositeElement)) == true)
      ok = GenerateContentElementPropertySetCode(prop);
    else
    if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlPart)) == true && prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlPartRootElement)))
      ok = GeneratePartRootElementPropertySetCode(prop);
    else
      ok = GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
    Writer.Indent--;
    Writer.WriteLine($"}}");
    return ok;
  }
  #endregion

  #region Simple property access code generation

  private bool GenerateSimplePropertyGetCode(PropInfo prop)
  {
    if (prop.Name == "Panose1Number")
      Debug.Assert(true);
    var origPropType = prop.PropertyType.Type;
    var targetPropType = prop.GetTargetType();
    if (origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Int16Value))
        || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Int32Value))
        || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Int64Value))
        || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.IntegerValue))
        || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.ByteValue))
        || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.SByteValue))
        || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.UInt16Value))
        || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.UInt32Value))
        || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.UInt64Value))
        || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.DateTimeValue))
        || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.SingleValue))
        || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.DoubleValue))
        || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.DecimalValue))
       )
      return GenerateSimpleValuePropertyGetCode(prop);
    else
    if (targetPropType.Type == typeof(Byte) && origPropType == typeof(DocumentFormat.OpenXml.HexBinaryValue))
        return GenerateHexBinaryBytePropertyGetCode(prop);
    else
    if (targetPropType.Type == typeof(UInt16) && origPropType == typeof(DocumentFormat.OpenXml.HexBinaryValue))
        return GenerateHexBinaryUInt16PropertyGetCode(prop);
    else
    if (targetPropType.Type == typeof(DocumentModel.RGB) && origPropType == typeof(DocumentFormat.OpenXml.HexBinaryValue))
      return GenerateHexBinaryRGBPropertyGetCode(prop);
    else
    if (targetPropType.Type == typeof(UInt32) && origPropType == typeof(DocumentFormat.OpenXml.HexBinaryValue))
        return GenerateHexBinaryUInt32PropertyGetCode(prop);
    else
    if (targetPropType.Type == typeof(UInt32) && origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType)))
        return GenerateValUInt32PropertyGetCode(prop);
    else
    if (targetPropType.Type == typeof(UInt64) && origPropType == typeof(DocumentFormat.OpenXml.HexBinaryValue))
        return GenerateHexBinaryUInt64PropertyGetCode(prop);
    else
    if (origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.HexBinaryValue)))
      return GenerateHexBinaryPropertyGetCode(prop);
    else
    if (origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Base64BinaryValue)))
      return GenerateBase64BinaryPropertyGetCode(prop);
    else
    if (origPropType.Name.StartsWith("ListValue`"))
      return GenerateListValuePropertyGetCode(prop);
    else
      return GenerateSimpleValPropertyGetCode(prop);
  }

  private bool GenerateSimplePropertySetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType.Type;
    var targetPropType = prop.GetTargetType();
    if (origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Int16Value))
      || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Int32Value))
      || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Int64Value))
      || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.IntegerValue))
      || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.ByteValue))
      || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.SByteValue))
      || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.UInt16Value))
      || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.UInt32Value))
      || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.UInt64Value))
      || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.DateTimeValue))
      || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.SingleValue))
      || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.DoubleValue))
      || origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.DecimalValue))
      )
      return GenerateSimpleValuePropertySetCode(prop);
    else
    if (targetPropType.Type == typeof(Byte) && origPropType == typeof(DocumentFormat.OpenXml.HexBinaryValue))
      return GenerateHexBinaryBytePropertySetCode(prop);
    else
    if (targetPropType.Type == typeof(UInt16) && origPropType == typeof(DocumentFormat.OpenXml.HexBinaryValue))
      return GenerateHexBinaryUInt16PropertySetCode(prop);
    else
    if (targetPropType.Type == typeof(DocumentModel.RGB) && origPropType == typeof(DocumentFormat.OpenXml.HexBinaryValue))
      return GenerateHexBinaryRGBPropertySetCode(prop);
    else
    if (targetPropType.Type == typeof(UInt32) && origPropType == typeof(DocumentFormat.OpenXml.HexBinaryValue))
      return GenerateHexBinaryUInt32PropertySetCode(prop);
    else
    if (targetPropType.Type == typeof(UInt32) && origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType)))
      return GenerateValUInt32PropertySetCode(prop);
    else
    if (targetPropType.Type == typeof(UInt64) && origPropType == typeof(DocumentFormat.OpenXml.HexBinaryValue))
      return GenerateHexBinaryUInt64PropertySetCode(prop);
    else
    if (origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.HexBinaryValue)))
      return GenerateHexBinaryPropertySetCode(prop);
    else
    if (origPropType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Base64BinaryValue)))
      return GenerateBase64BinaryPropertySetCode(prop);
    else
    if (origPropType.Name.StartsWith("ListValue`"))
      return GenerateListValuePropertySetCode(prop);
    else
      return GenerateSimpleValPropertySetCode(prop);
  }

  private bool GenerateSimpleValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return openXmlElement.{origPropName}?.Value;");
    return true;
  }
  private bool GenerateSimpleValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"openXmlElement.{origPropName} = value;");
    return true;
  }

  private bool GenerateSimpleValPropertyGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement?.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"if (itemElement != null)");
    Writer.WriteLine($"  return itemElement.Val?.Value;");
    Writer.WriteLine($"return null;");
    return true;
  }
  private bool GenerateSimpleValPropertySetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"if (itemElement != null)");
    Writer.WriteLine($"  itemElement.Remove();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  itemElement = new {origPropTypeName}{{ Val = value }};");
    Writer.WriteLine($"  openXmlElement.AddChild(itemElement);");
    Writer.WriteLine($"}}");
    return true;
  }

  #endregion

  #region HexBinary converters

  private bool GenerateHexBinaryBytePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return Byte.Parse(openXmlElement.{origPropName}.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }
  private bool GenerateHexBinaryBytePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"    openXmlElement.{origPropName} = ((UInt16)value).ToString(\"X2\");");
    Writer.WriteLine($"  else");
    Writer.WriteLine($"    openXmlElement.{origPropName} = null;");
    return true;
  }

  private bool GenerateHexBinaryUInt16PropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return UInt16.Parse(openXmlElement.{origPropName}.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }
  private bool GenerateHexBinaryUInt16PropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"    openXmlElement.{origPropName} = ((UInt16)value).ToString(\"X4\");");
    Writer.WriteLine($"  else");
    Writer.WriteLine($"    openXmlElement.{origPropName} = null;");
    return true;
  }

  private bool GenerateHexBinaryRGBPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return (DocumentModel.RGB)UInt32.Parse(openXmlElement.{origPropName}.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }
  private bool GenerateHexBinaryRGBPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"    openXmlElement.{origPropName} = ((UInt32)value).ToString(\"X6\");");
    Writer.WriteLine($"  else");
    Writer.WriteLine($"    openXmlElement.{origPropName} = null;");
    return true;
  }

  private bool GenerateHexBinaryUInt32PropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return UInt32.Parse(openXmlElement.{origPropName}.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }
  private bool GenerateHexBinaryUInt32PropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"    openXmlElement.{origPropName} = ((UInt32)value).ToString(\"X8\");");
    Writer.WriteLine($"  else");
    Writer.WriteLine($"    openXmlElement.{origPropName} = null;");
    return true;
  }

  private bool GenerateHexBinaryUInt64PropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return UInt64.Parse(openXmlElement.{origPropName}.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }
  private bool GenerateHexBinaryUInt64PropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"    openXmlElement.{origPropName} = ((UInt364)value).ToString(\"X16\");");
    Writer.WriteLine($"  else");
    Writer.WriteLine($"    openXmlElement.{origPropName} = null;");
    return true;
  }

  private bool GenerateValUInt32PropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement.{origPropName}?.Val?.Value != null)");
    Writer.WriteLine($"  return UInt32.Parse(openXmlElement.{origPropName}.Val.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }
  private bool GenerateValUInt32PropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"  if (value != null)");
    Writer.WriteLine($"    openXmlElement.{origPropName} = new {origPropTypeName} {{ Val = ((UInt32)value).ToString(\"X8\") }};");
    Writer.WriteLine($"  else");
    Writer.WriteLine($"    openXmlElement.{origPropName} = null;");
    return true;
  }
  private bool GenerateHexBinaryPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return Convert.FromHexString(openXmlElement.{origPropName}.Value);");
    Writer.WriteLine($"return null;");
    return true;
  }
  private bool GenerateHexBinaryPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = Convert.ToHexString(value);");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }

  private bool GenerateBase64BinaryPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return Convert.FromBase64String(openXmlElement.{origPropName}.Value);");
    Writer.WriteLine($"return null;");
    return true;
  }
  private bool GenerateBase64BinaryPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = Convert.ToBase64String(value);");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }

  private bool GenerateListValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropItemType = prop.PropertyType.GetGenericTypeArguments().FirstOrDefault();
    if (origPropItemType != null)
    {
      var origPropItemTypeName = origPropItemType.GetFullName(true);
      bool isEnum = (origPropItemType.IsEnumValue(out var enumType));
      if (isEnum && enumType != null)
        Writer.WriteLine($"return ListValueConverter.GetValue<{enumType.GetFullName(true)}, {enumType.GetFullName()}>(openXmlElement?.{origPropName});");
      else
        Writer.WriteLine($"return ListValueConverter.GetValue(openXmlElement?.{origPropName});");
      return true;
    }
    throw new InvalidOperationException($"ListValue has no generic argument in GenerateListValuePropertyGetCode method");
  }
  private bool GenerateListValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropItemType = prop.PropertyType.GetGenericTypeArguments().FirstOrDefault();
    if (origPropItemType != null)
    {
      var origPropItemTypeName = origPropItemType.GetFullName(true);
      bool isEnum = (origPropItemType.IsEnumValue(out var enumType));
      Writer.WriteLine($"if (value != null)");
      if (isEnum && enumType != null)
        Writer.WriteLine($"  openXmlElement.{origPropName} = ListValueConverter.CreateListValue<{enumType.GetFullName(true)}, {enumType.GetFullName()}>(value);");
      else
        Writer.WriteLine($"  openXmlElement.{origPropName} = ListValueConverter.CreateListValue<{origPropItemTypeName}>(value);");
      Writer.WriteLine($"else");
      Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
      return true;
    }
    throw new InvalidOperationException($"ListValue has no generic argument in GenerateListValuePropertySetCode method");
  }
  #endregion

  #region Enum property access code generation

  private bool GenerateEnumPropertyGetCode(PropInfo prop)
  {
    if (prop.Name == "ProcessMode")
      Debug.Assert(true);
    if (prop.PropertyType.Type.IsEnum)
      return GenerateSimpleEnumTypePropertyGetCode(prop);
    else if (prop.PropertyType.Name.StartsWith("EnumValues`"))
      return GenerateEnumTypePropertyGetCode(prop);
    else if (prop.PropertyType.Name.StartsWith("EnumValue`"))
      return GenerateEnumTypePropertyGetCode(prop);
    else if (prop.PropertyType.Name.StartsWith("OpenXmlSimpleValue`"))
      return GenerateEnumTypePropertyGetCode(prop);
    else if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
      return GenerateContentEnumValPropertyGetCode(prop);
    else
      return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }
  private bool GenerateEnumPropertySetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type.IsEnum)
      return GenerateSimpleEnumTypePropertySetCode(prop);
    else if (prop.PropertyType.Name.StartsWith("EnumValues`"))
      return GenerateEnumTypePropertySetCode(prop);
    else if (prop.PropertyType.Name.StartsWith("EnumValue`"))
      return GenerateEnumTypePropertySetCode(prop);
    else if (prop.PropertyType.Name.StartsWith("OpenXmlSimpleValue`"))
      return GenerateEnumTypePropertySetCode(prop);
    else if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
      return GenerateContentEnumValPropertySetCode(prop);
    else
      return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }

  private bool GenerateSimpleEnumTypePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    var targetPropType = prop.GetTargetType();
    var targetPropTypeName = targetPropType.GetFullName(false);
    Writer.WriteLine($"if (openXmlElement?.{origPropName} != null)");
    Writer.WriteLine($"  return EnumValueConverter.GetValue<{origPropTypeName}, {targetPropTypeName}>(openXmlElement.{origPropName});");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateSimpleEnumTypePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    var targetPropType = prop.GetTargetType();
    var targetPropTypeName = targetPropType.GetFullName(false);
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = EnumValueConverter.GetValue<{targetPropTypeName}, {origPropTypeName}>(value);");
    return true;
  }

  private bool GenerateEnumTypePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType.Type;
    var origPropValueType = GetOpenXmlEnumValueType(origPropType);
    var targetPropType = prop.GetTargetType();
    if (origPropValueType != null && targetPropType != null)
    {
      var origPropValueTypeName = origPropValueType.FullName;
      var targetPropTypeName = targetPropType.GetFullName(false);
      Writer.WriteLine(
        $"return EnumValueConverter.GetValue<{origPropValueTypeName}, {targetPropTypeName}>(openXmlElement?.{origPropName}?.Value);");
      return true;
    }
    return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }

  private bool GenerateEnumTypePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType.Type;
    var origPropValueType = GetOpenXmlEnumValueType(origPropType);
    var targetPropType = prop.GetTargetType();
    if (origPropValueType != null && targetPropType != null)
    {
      var origPropValueTypeName = origPropValueType.FullName;
      var targetPropTypeName = targetPropType.GetFullName(false);
      Writer.WriteLine($"openXmlElement.{origPropName} = EnumValueConverter.CreateEnumValue<{origPropValueTypeName}, {targetPropTypeName}>(value);");
      return true;
    }
    return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }
  #endregion

  #region String property access code generation

  private bool GenerateStringPropertyGetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type == typeof(string))
      return GenerateSimpleStringPropertyGetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.StringValue)))
      return GenerateStringValuePropertyGetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Wordprocessing.StringType)))
      return GenerateStringTypePropertyGetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Drawing.Text)))
      return GenerateTextPropertyGetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OpenXmlLeafTextElement)))
      return GenerateStringLeafTextTypePropertyGetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OpenXmlLeafElement)))
      return GenerateStringLeafValTypePropertyGetCode(prop);
    else
      return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }

  private bool GenerateStringPropertySetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type == typeof(string))
      return GenerateSimpleStringPropertySetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.StringValue)))
      return GenerateStringValuePropertySetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Wordprocessing.StringType)))
      return GenerateStringTypePropertySetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Drawing.Text)))
      return GenerateTextPropertySetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OpenXmlLeafTextElement)))
      return GenerateStringLeafTextTypePropertySetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OpenXmlLeafElement)))
      return GenerateStringLeafValTypePropertySetCode(prop);
    else
      return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }

  private bool GenerateSimpleStringPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return openXmlElement?.{origPropName};");
    return true;
  }
  private bool GenerateSimpleStringPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"openXmlElement.{origPropName} = value;");
    return true;
  }

  private bool GenerateStringValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Value;");
    return true;
  }
  private bool GenerateStringValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = new StringValue {{ Value = value }};");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }

  private bool GenerateStringTypePropertyGetCode(PropInfo prop)
  {
    var origElementTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origElementTypeName}>();");
    Writer.WriteLine($"if (itemElement != null)");
    Writer.WriteLine($"  return itemElement.Val?.Value;");
    Writer.WriteLine($"return null;");
    return true;
  }
  private bool GenerateStringTypePropertySetCode(PropInfo prop)
  {
    var origElementTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origElementTypeName}>();");
    Writer.WriteLine($"if (itemElement != null)");
    Writer.WriteLine($"  itemElement.Remove();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  itemElement = new {origElementTypeName} {{ Val = value }};");
    Writer.WriteLine($"  openXmlElement.AddChild(itemElement);");
    Writer.WriteLine($"}}");
    return true;
  }

  private bool GenerateTextPropertyGetCode(PropInfo prop)
  {
    string origPropName = prop.Name;
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Text;");
    return true;
  }
  private bool GenerateTextPropertySetCode(PropInfo prop)
  {
    string origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = new {origPropTypeName}(value);");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }

  private bool GenerateStringLeafTextTypePropertyGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement?.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"if (itemElement != null)");
    Writer.WriteLine($"  return itemElement.Text;");
    Writer.WriteLine($"return null;");
    return true;
  }
  private bool GenerateStringLeafTextTypePropertySetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"if (itemElement != null)");
    Writer.WriteLine($"  itemElement.Remove();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  itemElement = new {origPropTypeName} {{ Text = value }};");
    Writer.WriteLine($"  openXmlElement.AddChild(itemElement);");
    Writer.WriteLine($"}}");
    return true;
  }

  private bool GenerateStringLeafValTypePropertyGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement?.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"if (itemElement != null)");
    Writer.WriteLine($"  return itemElement.Val?.Value;");
    Writer.WriteLine($"return null;");
    return true;
  }
  private bool GenerateStringLeafValTypePropertySetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"if (itemElement != null)");
    Writer.WriteLine($"  itemElement.Remove();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  itemElement = new {origPropTypeName} {{ Val = value }};");
    Writer.WriteLine($"  openXmlElement.AddChild(itemElement);");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region Boolean property access code generation

  private bool GenerateBooleanPropertyGetCode(PropInfo prop)
  {

    if (prop.PropertyType.Type == typeof(Boolean))
      return GenerateSameTypePropertyGetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.BooleanValue)))
      return GenerateBooleanValuePropertyGetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OnOffValue)))
      return GenerateBooleanOnOffValueGetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.TrueFalseValue)))
      return GenerateBooleanTrueFalseValuePropertyGetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.TrueFalseBlankValue)))
      return GenerateBooleanTrueFalseBlankValuePropertyGetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Wordprocessing.OnOffType)))
      return GenerateBooleanOnOffTypePropertyGetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType)))
      return GenerateBooleanOnOffOnlyTypePropertyGetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.TypedOpenXmlLeafElement)))
      return GenerateBooleanTypedOpenXmlLeafElementPropertyGetCode(prop);

    else
      return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }

  private bool GenerateBooleanPropertySetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type == typeof(Boolean))
      return GenerateSameTypePropertySetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.BooleanValue)))
      return GenerateBooleanValuePropertySetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OnOffValue)))
      return GenerateBooleanOnOffValueSetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.TrueFalseValue)))
      return GenerateBooleanTrueFalseValuePropertySetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.TrueFalseBlankValue)))
      return GenerateBooleanTrueFalseBlankValuePropertySetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Wordprocessing.OnOffType)))
      return GenerateBooleanOnOffTypePropertySetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType)))
      return GenerateBooleanOnOffOnlyTypePropertySetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.TypedOpenXmlLeafElement)))
      return GenerateBooleanTypedOpenXmlLeafElementPropertySetCode(prop);
    else
      return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }

  private bool GenerateBooleanValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Value;");
    return true;
  }
  private bool GenerateBooleanValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = new BooleanValue {{ Value = (Boolean)value }};");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
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
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = new OnOffValue {{ Value = (Boolean)value }};");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }

  private bool GenerateBooleanTrueFalseValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Value;");
    return true;
  }
  private bool GenerateBooleanTrueFalseValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = value;");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }

  private bool GenerateBooleanTrueFalseBlankValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Value;");
    return true;
  }
  private bool GenerateBooleanTrueFalseBlankValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = value;");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }

  private bool GenerateBooleanOnOffTypePropertyGetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"if (itemElement?.Val?.Value != null)");
    Writer.WriteLine($"  return itemElement.Val.Value;");
    Writer.WriteLine($"return null;");
    return true;
  }
  private bool GenerateBooleanOnOffTypePropertySetCode(PropInfo prop)
  {
    //var origPropName = prop.Name;
    //var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    //var targetPropType = prop.PropertyType.GetConversionTarget();
    //var targetPropTypeName = targetPropType.GetFullName(false);
    Writer.WriteLine($"if (value == false)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"  if (itemElement != null)");
    Writer.WriteLine($"    itemElement.Remove();");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"if (value == true)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var itemElement = new {origPropTypeName}();");
    Writer.WriteLine($"  openXmlElement.AddChild(itemElement);");
    Writer.WriteLine($"}}");
    return true;
  }

  private bool GenerateBooleanOnOffOnlyTypePropertyGetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"if (itemElement?.Val?.Value != null)");
    Writer.WriteLine($"  return itemElement.Val.Value;");
    Writer.WriteLine($"return null;");
    return true;
  }
  private bool GenerateBooleanOnOffOnlyTypePropertySetCode(PropInfo prop)
  {
    //var origPropName = prop.Name;
    //var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    //var targetPropType = prop.PropertyType.GetConversionTarget();
    //var targetPropTypeName = targetPropType.GetFullName(false);
    Writer.WriteLine($"if (value == false)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"  if (itemElement != null)");
    Writer.WriteLine($"    itemElement.Remove();");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"if (value == true)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var itemElement = new {origPropTypeName}();");
    Writer.WriteLine($"  openXmlElement.AddChild(itemElement);");
    Writer.WriteLine($"}}");
    return true;
  }

  private bool GenerateBooleanTypedOpenXmlLeafElementPropertyGetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"return itemElement != null;");
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
    Writer.WriteLine($"if (value == false)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"  if (itemElement != null)");
    Writer.WriteLine($"    itemElement.Remove();");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"if (value == true)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var itemElement = new {origPropTypeName}();");
    Writer.WriteLine($"  openXmlElement.AddChild(itemElement);");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region Unconverted property access code generation
  private bool GenerateSameTypePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return openXmlElement?.{origPropName};");
    return true;
  }

  private bool GenerateSameTypePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"openXmlElement.{origPropName} = value;");
    return true;
  }
  #endregion

  #region Content element property access code generation
  private bool GenerateContentElementPropertyGetCode(PropInfo prop)
  {
    var targetPropTypeName = prop.GetTargetType().GetFullName();
    var origPropElementTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement?.GetFirstChild<{origPropElementTypeName}>();");
    Writer.WriteLine($"if (itemElement != null)");
    Writer.WriteLine($"  return {ConverterGetMethodName(prop)}(itemElement);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateContentElementPropertySetCode(PropInfo prop)
  {
    var origPropElementTypeName = prop.PropertyType.GetFullName(true);
    var targetPropType = prop.GetTargetType();
    var targetPropTypeName = targetPropType.GetFullName(false);
    if (targetPropTypeName.Name == "AdjustPoint2DType")
      Debug.Assert(true);
    //var generic = targetPropType.GetIncomingRelationships(Semantics.Inheritance).Count() > 0;
    Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origPropElementTypeName}>();");
    Writer.WriteLine($"if (itemElement != null)");
    Writer.WriteLine($"  itemElement.Remove();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  itemElement = {ConverterCreateMethodName(prop)}(value);");
    Writer.WriteLine($"  if (itemElement != null)");
    Writer.WriteLine($"    openXmlElement.AddChild(itemElement);"); // nocast
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
    var targetPropType = prop.GetTargetType();
    if (origPropValueType != null && targetPropType != null)
    {
      var origPropValueTypeName = origPropValueType.FullName;
      var targetPropTypeName = targetPropType.GetFullName(false);
      Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
      Writer.WriteLine($"if (itemElement?.Val?.Value != null)");
      Writer.WriteLine($"  return EnumValueConverter.GetValue<{origPropValueTypeName}, {targetPropTypeName}>(itemElement.Val.Value);");
      Writer.WriteLine($"return null;");
      return true;
    }
    throw new InvalidOperationException($"Not supported propertyType {prop.PropertyType.Type} in GenerateContentEnumValPropertyGetCode");

  }

  private bool GenerateContentEnumValPropertySetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType.Type;
    var origPropValueType = GetOpenXmlLeafEnumValueType(origPropType);
    var targetPropType = prop.GetTargetType();
    if (origPropValueType != null && targetPropType != null)
    {
      var origPropValueTypeName = origPropValueType.FullName;
      var targetPropTypeName = targetPropType.GetFullName(false);
      Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
      Writer.WriteLine($"if (itemElement != null)");
      Writer.WriteLine($"  itemElement.Remove();");
      Writer.WriteLine($"if (value != null)");
      Writer.WriteLine($"{{");
      Writer.WriteLine($"  itemElement = EnumValueConverter.CreateOpenXmlElement<{origPropTypeName}, {origPropValueTypeName}, {targetPropTypeName}>(value);");
      Writer.WriteLine($"  if (itemElement != null)");
      Writer.WriteLine($"    openXmlElement.AddChild(itemElement);");
      Writer.WriteLine($"}}");
      return true;
    }
    throw new InvalidOperationException($"Not supported propertyType {prop.PropertyType.Type} in GenerateContentEnumValPropertySetCode");
  }
  #endregion

  #region Collection property access code generation

  private bool GenerateCollectionGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericTypeArguments().FirstOrDefault();
    var targetPropType = prop.GetTargetType();
    var targetItemType = targetPropType.GetGenericTypeArguments().FirstOrDefault();
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
    throw new InvalidOperationException($"Not supported propertyType {prop.PropertyType.Type} in GenerateCollectionGetCode");
  }

  private bool GenerateCollectionSetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericTypeArguments().FirstOrDefault();
    var targetPropType = prop.GetTargetType();
    var targetItemType = targetPropType.GetGenericTypeArguments().FirstOrDefault();
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
    throw new InvalidOperationException($"Not supported propertyType {prop.PropertyType.Type} in GenerateCollectionSetCode");
  }

  private bool GenerateCollectionOfElementsGetCode(PropInfo prop, FullTypeName origItemTypeName, FullTypeName targetItemTypeName)
  {
    Writer.WriteLine($"var collection = new System.Collections.ObjectModel.Collection<{targetItemTypeName}>();");
    Writer.WriteLine($"foreach (var item in openXmlElement.Elements<{origItemTypeName}>())");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var newItem = {ConverterGetMethodName(prop)}(item);");
    Writer.WriteLine($"  if (newItem != null)");
    Writer.WriteLine($"    collection.Add({ConverterTypeCast(prop)}newItem);");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"return collection;");
    return true;
  }

  private bool GenerateCollectionOfElementsSetCode(PropInfo prop, FullTypeName origItemTypeName, FullTypeName targetItemTypeName)
  {
    Writer.WriteLine($"openXmlElement.RemoveAllChildren<{origItemTypeName}>();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  foreach (var item in value)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    var newItem = {ConverterCreateMethodName(prop)}(item);");
    Writer.WriteLine($"    if (newItem != null)");
    Writer.WriteLine($"      openXmlElement.AddChild(newItem);");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
    return true;
  }

  private bool GenerateCollectionOfPartsGetCode(PropInfo prop, FullTypeName origItemTypeName, FullTypeName targetItemTypeName)
  {
    Writer.WriteLine($"var collection = new System.Collections.ObjectModel.Collection<{targetItemTypeName}>();");
    if (origItemTypeName.Name == "IdPartPair")
      Writer.WriteLine($"foreach (var item in openXmlElement.Parts)");
    else
    if (origItemTypeName.Name == "DataPart")
      Writer.WriteLine($"foreach (var item in openXmlElement.DataParts)");
    else
      Writer.WriteLine($"foreach (var item in openXmlElement.GetPartsOfType<{origItemTypeName}>())");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var newItem = {ConverterGetMethodName(prop)}(item);");
    Writer.WriteLine($"  if (newItem != null)");
    Writer.WriteLine($"    collection.Add({ConverterTypeCast(prop)}newItem);");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"return collection;");
    return true;
  }

  private bool GenerateCollectionOfPartsSetCode(PropInfo prop, FullTypeName origItemTypeName, FullTypeName targetItemTypeName)
  {
    Writer.WriteLine($"openXmlElement.RemoveAllChildren<{origItemTypeName}>();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  foreach (var item in value)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    var newItem = {ConverterCreateMethodName(prop)}(item);");
    Writer.WriteLine($"    if (newItem != null)");
    Writer.WriteLine($"      openXmlElement.AddChild({ConverterTypeCast(prop)}newItem);");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
    return true;
  }

  private bool GenerateCollectionOfRelationshipGetCode(PropInfo prop, FullTypeName origItemTypeName, string targetItemTypeName)
  {
    Writer.WriteLine($"var collection = new System.Collections.ObjectModel.Collection<{targetItemTypeName}>();");
    Writer.WriteLine($"foreach (var item in openXmlElement.{origItemTypeName.Name}s)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var newItem = {ConverterGetMethodName(prop)}(item);");
    Writer.WriteLine($"  if (newItem != null)");
    Writer.WriteLine($"    collection.Add(newItem);");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"return collection;");
    return true;
  }

  private bool GenerateCollectionOfRelationshipSetCode(PropInfo prop, FullTypeName origItemTypeName, string targetItemTypeName)
  {
    Writer.WriteLine($"openXmlElement.RemoveAllChildren<{origItemTypeName}>();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  foreach (var item in value)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    var newItem = {ConverterCreateMethodName(prop)}(item);");
    Writer.WriteLine($"    if (newItem != null)");
    Writer.WriteLine($"      openXmlElement.AddChild(newItem);");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
    return true;
  }

  #endregion

  #region Generate Part properties

  private bool GeneratePartRootElementPropertyGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"if (openXmlElement?.RootElement is {origPropTypeName} rootElement)");
    Writer.WriteLine($"  return {ConverterGetMethodName(prop)}(rootElement);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GeneratePartRootElementPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"   var rootElement = {ConverterCreateMethodName(prop)}(value);");
    Writer.WriteLine($"   if (rootElement != null)");
    Writer.WriteLine($"     openXmlElement.{origPropName} = rootElement;");
    Writer.WriteLine($"}}");
    return true;
  }

  #endregion


  #region GenerateNotImplementedException

  private bool GenerateNotImplementedException(string msg, [CallerMemberName] string? callerName = null)
  {
    string? message = $"\"Not implemented in {callerName}: {msg}\"";
    Writer.WriteLine($"throw new NotImplementedException({message});");
    return true;
  }
  #endregion

  #region ConverterInvokeMethods

  private string ConverterGetMethodName(PropInfo prop)
  {
    var targetPropType = prop.PropertyType.GetConversionTarget();
    var origPropType = prop.PropertyType;
    var targetPropTypeName = targetPropType.GetFullName();
    var origPropTypeName = origPropType.GetFullName(true);
    if (targetPropType.IsSimple())
      return SimpleTypeConverterGetMethodName(targetPropTypeName, origPropTypeName);
    FullTypeName convPropName;
    if (targetPropTypeName.Name == "Collection")
    {
      var origItemType = origPropType.GetGenericTypeArguments().First();
      var targetItemType = targetPropType.GetGenericTypeArguments().First();
      if (targetItemType.IsSimple())
        return SimpleTypeConverterGetMethodName(targetItemType.GetFullName(), origItemType.GetFullName());

      convPropName = new FullTypeName(targetItemType.Name + "Converter",
        targetItemType.Namespace?.Replace("DocumentModel", "DocumentModel.OpenXml"));
    }
    else
    if (targetPropTypeName.Name == "Byte[]")
    {
      convPropName = new FullTypeName("HexBinaryConverter", "DocumentModel.OpenXml");
      return $"{convPropName}.GetValue";
    }
    else
    {
      convPropName = new FullTypeName(targetPropTypeName.Name + "Converter",
        targetPropTypeName.Namespace?.Replace("DocumentModel", "DocumentModel.OpenXml"));
    }
    return $"{convPropName}.CreateModelElement";
  }

  private string SimpleTypeConverterGetMethodName(FullTypeName targetPropTypeName, FullTypeName origPropTypeName)
  {
    if (targetPropTypeName.Name == "String")
      return "StringValueConverter.GetValue";
    if (targetPropTypeName.Name == "UInt32")
      return "UInt32ValueConverter.GetValue";
    if (targetPropTypeName.Name == "NumId")
      return "NumIdConverter.GetValue";
    if (targetPropTypeName.Name == "HexBinary")
      return "HexBinaryConverter.GetValue";
    if (targetPropTypeName.Name == "Base64Binary")
      return "Base64BinaryConverter.GetValue";
    if (targetPropTypeName.Name == "Byte[]")
    {
      if (origPropTypeName.Name == "HexBinaryValue")
        return "HexBinaryConverter.GetValue";
      if (origPropTypeName.Name == "Base64BinaryValue")
        return "Base64BinaryConverter.GetValue";
      return "ByteArrayConverter.GetValue";
    }
    return string.Empty;
  }

  private string ConverterCreateMethodName(PropInfo prop)
  {
    var targetPropType = prop.GetTargetType();
    var origPropType = prop.PropertyType;
    var targetPropTypeName = targetPropType.GetFullName();
    var origPropTypeName = origPropType.GetFullName(true);
    bool generic = true;
    if (targetPropType.IsSimple())
      return SimpleTypeConverterCreateMethodName(targetPropTypeName, origPropTypeName);
    FullTypeName convPropName;
    if (targetPropTypeName.Name == "Collection")
    {
      var origItemType = origPropType.GetGenericTypeArguments().First();
      var targetItemType = targetPropType.GetGenericTypeArguments().First();
      if (targetItemType.IsSimple())
        return SimpleTypeConverterCreateMethodName(targetItemType.GetFullName(), origItemType.GetFullName(true));

      convPropName = new FullTypeName(targetItemType.Name + "Converter",
        targetItemType.Namespace?.Replace("DocumentModel", "DocumentModel.OpenXml"));
      origPropTypeName = origItemType.GetFullName(true);
    }
    else
    if (targetPropTypeName.Name == "Byte[]")
    {
      convPropName = new FullTypeName("HexBinaryConverter", "DocumentModel.OpenXml");
    }
    else
    {
      convPropName = new FullTypeName(targetPropTypeName.Name + "Converter",
        (targetPropTypeName.Namespace ?? "").Replace("DocumentModel", "DocumentModel.OpenXml"));
    }
    var convCreateMethodName = $"{convPropName}.CreateOpenXmlElement";
    if (generic)
      convCreateMethodName += $"<{origPropTypeName}>";
    return convCreateMethodName;
  }

  private string SimpleTypeConverterCreateMethodName(FullTypeName targetPropTypeName, FullTypeName origPropTypeName)
  {
    if (targetPropTypeName.Name == "String")
      return $"StringValueConverter.CreateOpenXmlElement<{origPropTypeName}>";
    if (targetPropTypeName.Name == "UInt32")
      return $"UInt32ValueConverter.CreateOpenXmlElement<{origPropTypeName}>";
    if (targetPropTypeName.Name == "NumId")
      return $"NumIdConverter.CreateOpenXmlElement<{origPropTypeName}>";
    if (targetPropTypeName.Name == "Byte[]")
    {
      if (origPropTypeName.Name == "HexBinaryValue")
        return $"HexBinaryConverter.CreateOpenXmlElement<{origPropTypeName}>";
      if (origPropTypeName.Name == "Base64Binary")
        return $"Base64BinaryConverter.CreateOpenXmlElement<{origPropTypeName}>";
      return $"ByteArrayConverter.CreateOpenXmlElement<{origPropTypeName}>";
    }
    return string.Empty;
  }

  private string? ConverterTypeCast(PropInfo prop)
  {
    var targetPropType = prop.GetTargetType();
    var origPropType = prop.PropertyType;
    var targetPropTypeName = targetPropType.GetFullName();
    if (targetPropType.IsSimple())
      return SimpleTypeConverterTypeCast(targetPropTypeName);
    if (targetPropTypeName.Name == "Collection")
    {
      var origItemType = origPropType.GetGenericTypeArguments().First();
      var targetItemType = targetPropType.GetGenericTypeArguments().First();
      if (targetItemType.IsSimple())
        return SimpleTypeConverterTypeCast(targetItemType.GetFullName());
    }
    return null;
  }

  private string? SimpleTypeConverterTypeCast(FullTypeName targetPropTypeName)
  {
    if (targetPropTypeName.Name == "String")
      return "(string)";
    if (targetPropTypeName.Name == "UInt32")
      return "(UInt32)";
    if (targetPropTypeName.Name == "NumId")
      return "(NumId)";
    return null;
  }
  #endregion

  protected override bool AssurePathExists(string filename)
  {
    string path = Path.GetDirectoryName(filename) ?? "";
    while (!path.EndsWith("OpenXml"))
      path = Path.GetDirectoryName(path) ?? "";
    var baseConverterPath = Path.Combine(path, "BaseConverters", Path.GetFileName(filename));
    if (File.Exists(baseConverterPath))
      return false;
    var filePath = Path.GetDirectoryName(filename) ?? string.Empty;
    if (filePath.EndsWith(@"\Properties"))
      return false;
    var newFilename = Path.ChangeExtension(filename, ".new.cs");
    if (File.Exists(newFilename))
      return false;
    var extFilename = Path.ChangeExtension(filename, ".ext.cs");
    if (File.Exists(extFilename))
      return false;
    //if (!filename.Contains(@"\Wordprocessing"))
    //  return false;
    if (filePath != null)
      if (!Directory.Exists(filePath))
      {
        Directory.CreateDirectory(filePath);
      }
    return true;
  }
}