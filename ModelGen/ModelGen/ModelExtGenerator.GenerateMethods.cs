using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

using InvalidOperationException = System.InvalidOperationException;

namespace ModelGen;

public partial class ModelExtGenerator
{

  public int SkippedTypesCount { [DebuggerStepThrough] get; private set; }

  #region helper starting methods

  protected static bool IsOpenXmlLeafEnumValueType(Type type)
  {
    //if (type.Name == "StyleSet")
    //  Debug.Assert(true);
    if (type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
    {
      var valProperty = type.GetProperty("Val");
      if (valProperty != null && type.GetProperties().Count() == 1)
      {
        var propType = valProperty.PropertyType;
        if (propType.Name.StartsWith("EnumValue"))
        {
          var argType = propType.GenericTypeArguments.FirstOrDefault();
          if (argType != null && argType.IsEnum) return true;
        }
      }
    }
    return false;
  }

  protected static Type? GetOpenXmlLeafEnumValueType(Type type)
  {
    //if (type.Name == "Settings")
    //  Debug.Assert(true);
    if (type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
    {
      var valProperty = type.GetProperty("Val");
      if (valProperty != null)
      {
        var propType = valProperty.PropertyType;
        if (propType.Name.StartsWith("EnumValue"))
        {
          var argType = propType.GenericTypeArguments.FirstOrDefault();
          if (argType != null && argType.IsEnum) return argType;
        }
      }
    }
    return null;
  }

  protected static Type? GetOpenXmlEnumValueType(Type type)
  {
    var propType = type;
    if (propType.Name.StartsWith("EnumValue"))
    {
      var argType = propType.GenericTypeArguments.FirstOrDefault();
      if (argType != null && argType.IsEnum) return argType;
    }
    return null;
  }

  #endregion

  #region Main generate property getter/setter methods
  private bool GeneratePropertyGetter(PropInfo prop)
  {
    //var ok = false;
    //var origPropName = prop.Name;
    //var origTypeName = prop.DeclaringType?.GetFullName(false, true, true) ?? "";
    var origPropType = prop.PropertyType;
    //var targetPropName = prop.GetTargetName();
    var targetPropType = prop.GetTargetType();
    //var targetPropTypeName = targetPropType.GetFullName(true, true, true);
    //var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);

    if (targetPropType.Type.IsEnum)
      return GenerateEnumPropertyGetCode(prop);
    else if (targetPropType.Type == typeof(string))
      return GenerateStringPropertyGetCode(prop);
    else if (targetPropType.Type == typeof(bool))
      return GenerateBooleanPropertyGetCode(prop);
    else if (targetPropType.Type.IsNumeral())
      return GenerateNumericValuePropertyGetCode(prop);
    else if (targetPropType.Type == typeof(Base64Binary))
      return GenerateBase64BinaryPropertyGetCode(prop);
    else if (targetPropType.Type == typeof(HexInt))
      return GenerateHexIntPropertyGetCode(prop);
    //else if (targetPropType.IsSimple())
    //  return GenerateSimplePropertyGetCode(prop);
    //else if (targetPropType.Type.Implements(typeof(ICollection)))
    //  return GenerateCollectionGetCode(prop);
    //else if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlSimpleType)))
    //  return GenerateSimplePropertyGetCode(prop);
    //else if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlCompositeElement)) == true)
    //  return GenerateContentElementPropertyGetCode(prop);
    //else if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlPart)) == true && prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlPartRootElement)))
    //  return GeneratePartRootElementPropertyGetCode(prop);
    //else if (origPropType.Type.IsClass)
    //  return GenerateSimplePropertyGetCode(prop);
    //else if ((prop.Owner as TypeInfo)?.BaseTypeInfo?.Type.IsEqualOrSubclassOf(typeof(DX.OpenXmlCompositeElement))==true
    //  && origPropType.Type.IsEqualOrSubclassOf(typeof(DX.OpenXmlElement)))
    //  return GenerateCompositeElementPropertyGetCode(prop);
    else
      return GenerateGetNotImplementedException($"targetPropType baseType is {targetPropType.Type.BaseType}");

  }

  private bool GeneratePropertySetter(PropInfo prop)
  {
    //var ok = false;
    //var origPropName = prop.Name;
    //var origTypeName = prop.DeclaringType?.GetFullName(false, true, true) ?? "";
    //var origPropType = prop.PropertyType;
    //var targetPropName = prop.GetTargetName();
    var targetPropType = prop.GetTargetType();
    //var targetPropTypeName = targetPropType.GetFullName(true, true, true);
    //var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);

    if (targetPropType.Type.IsEnum)
      return GenerateEnumPropertySetCode(prop);
    else if (targetPropType.Type == typeof(string))
      return GenerateStringPropertySetCode(prop);
    else if (targetPropType.Type == typeof(bool))
      return GenerateBooleanPropertySetCode(prop);
    else if (targetPropType.Type.IsNumeral())
      return GenerateNumericValuePropertySetCode(prop);
    else if (targetPropType.Type == typeof(Base64Binary))
      return GenerateBase64BinaryPropertySetCode(prop);
    //else if (targetPropType.IsSimple())
    //  return GenerateSimplePropertySetCode(prop);
    //else if (targetPropType.Type.Implements(typeof(ICollection)))
    //  return GenerateCollectionSetCode(prop);
    //else if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlSimpleType)))
    //  return GenerateSimplePropertySetCode(prop);
    //else if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlCompositeElement)) == true)
    //  return GenerateContentElementPropertySetCode(prop);
    //else if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlPart)) == true && prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlPartRootElement)))
    //  return GeneratePartRootElementPropertySetCode(prop);
    else
      return GenerateSetNotImplementedException($"targetPropType baseType is {targetPropType.Type.BaseType}");
  }
  #endregion

  #region Simple property access code generation

  #region GenerateSimpleProperty code
  private bool GenerateSimplePropertyGetCode(PropInfo prop)
  {
    //if (prop.Name == "Panose1Number")
    //  Debug.Assert(true);
    var origPropType = prop.PropertyType.Type;
    var targetPropType = prop.GetTargetType();
    if (origPropType.IsEqualOrSubclassOf(typeof(Int16Value))
        || origPropType.IsEqualOrSubclassOf(typeof(Int32Value))
        || origPropType.IsEqualOrSubclassOf(typeof(Int64Value))
        || origPropType.IsEqualOrSubclassOf(typeof(IntegerValue))
        || origPropType.IsEqualOrSubclassOf(typeof(ByteValue))
        || origPropType.IsEqualOrSubclassOf(typeof(SByteValue))
        || origPropType.IsEqualOrSubclassOf(typeof(UInt16Value))
        || origPropType.IsEqualOrSubclassOf(typeof(UInt32Value))
        || origPropType.IsEqualOrSubclassOf(typeof(UInt64Value))
        || origPropType.IsEqualOrSubclassOf(typeof(DateTimeValue))
        || origPropType.IsEqualOrSubclassOf(typeof(SingleValue))
        || origPropType.IsEqualOrSubclassOf(typeof(DoubleValue))
        || origPropType.IsEqualOrSubclassOf(typeof(DecimalValue))
       )
      return GenerateSimpleValuePropertyGetCode(prop);
    if (targetPropType.Type == typeof(Byte) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryBytePropertyGetCode(prop);
    if (targetPropType.Type == typeof(UInt16) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryUInt16PropertyGetCode(prop);
    if (targetPropType.Type == typeof(RGB) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryRGBPropertyGetCode(prop);
    if (targetPropType.Type == typeof(UInt32) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryUInt32PropertyGetCode(prop);
    if (targetPropType.Type == typeof(UInt32) && origPropType.IsEqualOrSubclassOf(typeof(LongHexNumberType)))
      return GenerateValUInt32PropertyGetCode(prop);
    if (targetPropType.Type == typeof(UInt64) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryUInt64PropertyGetCode(prop);
    if (targetPropType.Type == typeof(HexInt))
      return GenerateHexIntPropertyGetCode(prop);
    if (targetPropType.Type == typeof(RGB))
      return GenerateHexRGBPropertyGetCode(prop);
    if (targetPropType.Type == typeof(HexChar))
      return GenerateHexCharPropertyGetCode(prop);
    if (targetPropType.Type == typeof(Guid))
      return GenerateGuidPropertyGetCode(prop);
    if (origPropType.IsEqualOrSubclassOf(typeof(HexBinaryValue)))
      return GenerateHexBinaryPropertyGetCode(prop);
    if (origPropType.IsEqualOrSubclassOf(typeof(Base64BinaryValue)))
      return GenerateBase64BinaryPropertyGetCode(prop);
    if (origPropType.Name.StartsWith("ListValue`"))
      return GenerateListValuePropertyGetCode(prop);
    return GenerateSimpleValPropertyGetCode(prop);
  }

  private bool GenerateSimplePropertySetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType.Type;
    var targetPropType = prop.GetTargetType();
    if (origPropType.IsEqualOrSubclassOf(typeof(Int16Value))
        || origPropType.IsEqualOrSubclassOf(typeof(Int32Value))
        || origPropType.IsEqualOrSubclassOf(typeof(Int64Value))
        || origPropType.IsEqualOrSubclassOf(typeof(IntegerValue))
        || origPropType.IsEqualOrSubclassOf(typeof(ByteValue))
        || origPropType.IsEqualOrSubclassOf(typeof(SByteValue))
        || origPropType.IsEqualOrSubclassOf(typeof(UInt16Value))
        || origPropType.IsEqualOrSubclassOf(typeof(UInt32Value))
        || origPropType.IsEqualOrSubclassOf(typeof(UInt64Value))
        || origPropType.IsEqualOrSubclassOf(typeof(DateTimeValue))
        || origPropType.IsEqualOrSubclassOf(typeof(SingleValue))
        || origPropType.IsEqualOrSubclassOf(typeof(DoubleValue))
        || origPropType.IsEqualOrSubclassOf(typeof(DecimalValue))
       )
      return GenerateSimpleValuePropertySetCode(prop);
    if (targetPropType.Type == typeof(Byte) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryBytePropertySetCode(prop);
    if (targetPropType.Type == typeof(UInt16) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryUInt16PropertySetCode(prop);
    if (targetPropType.Type == typeof(RGB) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryRGBPropertySetCode(prop);
    if (targetPropType.Type == typeof(UInt32) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryUInt32PropertySetCode(prop);
    if (targetPropType.Type == typeof(UInt32) && origPropType.IsEqualOrSubclassOf(typeof(LongHexNumberType)))
      return GenerateValUInt32PropertySetCode(prop);
    if (targetPropType.Type == typeof(UInt64) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryUInt64PropertySetCode(prop);
    if (targetPropType.Type == typeof(HexInt))
      return GenerateHexIntPropertySetCode(prop);
    if (targetPropType.Type == typeof(RGB))
      return GenerateHexRGBPropertySetCode(prop);
    if (targetPropType.Type == typeof(HexChar))
      return GenerateHexCharPropertySetCode(prop);
    if (targetPropType.Type == typeof(Guid))
      return GenerateGuidPropertySetCode(prop);
    if (origPropType.IsEqualOrSubclassOf(typeof(HexBinaryValue)))
      return GenerateHexBinaryPropertySetCode(prop);
    if (origPropType.IsEqualOrSubclassOf(typeof(Base64BinaryValue)))
      return GenerateBase64BinaryPropertySetCode(prop);
    if (origPropType.Name.StartsWith("ListValue`"))
      return GenerateListValuePropertySetCode(prop);
    return GenerateSimpleValPropertySetCode(prop);
  }
  #endregion

  #region GenerateSimpleProperty code
  private bool GenerateSimpleValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return _Element?.{origPropName}?.Value;");
    return true;
  }

  private bool GenerateSimpleValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"_ExistingElement.{origPropName} = value;");
    return true;
  }
  #endregion

  #region GenerateSimpleValProperty code

  private bool GenerateSimpleValPropertyGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    Writer.WriteLine($"return SimpleValueConverter.GetValue(_Element?.GetFirstChild<{origPropTypeName}>()?.Val);");
    return true;
  }

  private bool GenerateSimpleValPropertySetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    var propTargetType = prop.PropertyType.GetConversionTargetOrSelf();
    Writer.WriteLine($"SimpleValueConverter.SetValue<{origPropTypeName},{propTargetType}>(_ExistingElement, value);");
    return true;
  }
  #endregion

  #region GenerateGuidProperty code
  private bool GenerateGuidPropertyGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    Writer.WriteLine($"var itemElement = _Element?.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"if (itemElement?.Val?.Value != null)");
    Writer.WriteLine($"  return Guid.Parse(itemElement.Val.Value);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateGuidPropertySetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    Writer.WriteLine($"var itemElement = _ExistingElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"if (itemElement != null)");
    Writer.WriteLine($"  itemElement.Remove();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  itemElement = new {origPropTypeName}{{ Val = ((Guid)value).ToString(\"B\") }};");
    Writer.WriteLine($"  _ExistingElement.AddChild(itemElement);");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #endregion

  #region HexBinary converted property access code generation

  #region GenerateHexBinaryByteProperty code
  private bool GenerateHexBinaryBytePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (_Element?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return Byte.Parse(_ExistingElement.{origPropName}.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateHexBinaryBytePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = ((UInt16)value).ToString(\"X2\");");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateHexBinaryUInt16Property
  private bool GenerateHexBinaryUInt16PropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (_Element?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return UInt16.Parse(_ExistingElement.{origPropName}.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateHexBinaryUInt16PropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = ((UInt16)value).ToString(\"X4\");");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateHexBinaryRGBProperty
  private bool GenerateHexBinaryRGBPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (_Element?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return (DocumentModel.RGB)UInt32.Parse(_ExistingElement.{origPropName}.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateHexBinaryRGBPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = ((UInt32)value).ToString(\"X6\");");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateHexBinaryUInt32Property code
  private bool GenerateHexBinaryUInt32PropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (_Element?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return UInt32.Parse(_ExistingElement.{origPropName}.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateHexBinaryUInt32PropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = ((UInt32)value).ToString(\"X8\");");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateHexBinaryUInt64Property code
  private bool GenerateHexBinaryUInt64PropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (_Element?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return UInt64.Parse(_ExistingElement.{origPropName}.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateHexBinaryUInt64PropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = ((UInt364)value).ToString(\"X16\");");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = null;");
    return true;
  }

  #endregion

  #region GenerateValUInt32Property code
  private bool GenerateValUInt32PropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (_Element?.{origPropName}?.Val?.Value != null)");
    Writer.WriteLine($"  return UInt32.Parse(_ExistingElement.{origPropName}.Val.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateValUInt32PropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = new {origPropTypeName} {{ Val = ((UInt32)value).ToString(\"X8\") }};");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #endregion

  #region GenerateHexIntProperty code
  private bool GenerateHexIntPropertyGetCode(PropInfo prop)
  {
    var origPropOwnerType = (prop.Owner as TypeInfo)?.Type;
    var origPropType = prop.PropertyType;
    if (origPropOwnerType != null && origPropOwnerType.IsEqualOrSubclassOf(typeof(DX.OpenXmlCompositeElement))
      && origPropType.Type.IsEqualOrSubclassOf(typeof(DX.OpenXmlElement)))
    {
      var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
      Writer.WriteLine($"get => _Element?.GetHexIntVal<{origPropTypeName}>();");
    }
    else
    {
      var origPropName = prop.Name;
      Writer.WriteLine($"get => HexIntConverter.GetValue(_Element?.{origPropName});");
    }
    return true;
  }

  private bool GenerateHexIntPropertySetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type == typeof(DX.HexBinaryValue))
    {
      var origPropName = prop.Name;
      Writer.WriteLine($"if (value != null)");
      Writer.WriteLine($"  _ExistingElement.{origPropName} = value.ToString();");
      Writer.WriteLine($"else");
      Writer.WriteLine($"  _ExistingElement.{origPropName} = null;");
    }
    else
    {
      var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
      Writer.WriteLine($"HexIntConverter.SetValue<{origPropTypeName}>(_ExistingElement, value);");
    }
    return true;
  }
  #endregion

  #region GenerateHexCharProperty code
  private bool GenerateHexCharPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"  return HexCharConverter.GetValue(_Element?.{origPropName}?.Value);");
    return true;
  }

  private bool GenerateHexCharPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = value.ToString();");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateHexRGBProperty code
  private bool GenerateHexRGBPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return HexRGBConverter.GetValue(_Element?.{origPropName}.Value);");
    return true;
  }

  private bool GenerateHexRGBPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = value.ToString();");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateHexBinaryProperty code
  private bool GenerateHexBinaryPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return Convert.FromHexString(_Element?.{origPropName}.Value);");
    return true;
  }

  private bool GenerateHexBinaryPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"_ExistingElement.{origPropName} = Convert.ToHexString(value);");
    return true;
  }
  #endregion

  #region GenerateComplexElementProperty code
  private bool GenerateCompositeElementPropertyGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    var targetPropTypeName = prop.PropertyType.GetFullName(true, true, true);
    Writer.WriteLine($"get => _Element?.GetObject<{targetPropTypeName}, {origPropTypeName}>();");
    return true;
  }

  private bool GenerateCompositeElementPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"_ExistingElement.{origPropName} = Convert.ToHexString(value);");
    return true;
  }
  #endregion

  //#region GenerateBase64BinaryProperty code
  //private bool GenerateBase64BinaryPropertyGetCode(PropInfo prop)
  //{
  //  var origPropName = prop.Name;
  //  Writer.WriteLine($"return Convert.FromBase64String(_Element.{origPropName}.Value);");
  //  return true;
  //}

  //private bool GenerateBase64BinaryPropertySetCode(PropInfo prop)
  //{
  //  var origPropName = prop.Name;
  //  Writer.WriteLine($"if (value != null)");
  //  Writer.WriteLine($"  _ExistingElement.{origPropName} = Convert.ToBase64String(value);");
  //  Writer.WriteLine($"else");
  //  Writer.WriteLine($"  _ExistingElement.{origPropName} = null;");
  //  return true;
  //}
  //#endregion

  #region ListValue property access code generation
  private bool GenerateListValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropItemType = prop.PropertyType.GetGenericArguments().FirstOrDefault();
    if (origPropItemType != null)
    {
      var origPropItemTypeName = origPropItemType.GetFullName(false, true, true);
      var isEnum = origPropItemType.IsEnumValue(out var enumType);
      if (isEnum && enumType != null)
        Writer.WriteLine($"return ListValueConverter.GetValue<{enumType.GetFullName(false, true, true)}, " +
                         $"{enumType.GetFullName(true, true, true)}>(_Element?.{origPropName});");
      else
        Writer.WriteLine($"return ListValueConverter.GetValue(_Element?.{origPropName});");
      return true;
    }
    throw new InvalidOperationException("ListValue has no generic argument in GenerateListValuePropertyGetCode method");
  }

  private bool GenerateListValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropItemType = prop.PropertyType.GetGenericArguments().FirstOrDefault();
    if (origPropItemType != null)
    {
      var origPropItemTypeName = origPropItemType.GetFullName(false, true, true);
      var isEnum = origPropItemType.IsEnumValue(out var enumType);
      Writer.WriteLine($"if (value != null)");
      if (isEnum && enumType != null)
        Writer.WriteLine($"  _ExistingElement.{origPropName} = ListValueConverter.CreateListValue<{enumType.GetFullName(false, true, true)}, " +
                         $"{enumType.GetFullName(true, true, true)}>(value);");
      else
        Writer.WriteLine($"  _ExistingElement.{origPropName} = ListValueConverter.CreateListValue<{origPropItemTypeName}>(value);");
      Writer.WriteLine($"else");
      Writer.WriteLine($"  _ExistingElement.{origPropName} = null;");
      return true;
    }
    throw new InvalidOperationException("ListValue has no generic argument in GenerateListValuePropertySetCode method");
  }

  #endregion

  #region Enum property access code generation

  #region GenerateEnumProperty code
  private bool GenerateEnumPropertyGetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type.IsEnum)
      return GenerateSimpleEnumTypePropertyGetCode(prop);
    else
      return GenerateEnumTypePropertyGetCode(prop);
  }

  private bool GenerateEnumPropertySetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type.IsEnum)
      return GenerateSimpleEnumTypePropertySetCode(prop);
    else
      return GenerateEnumTypePropertySetCode(prop);
  }
  #endregion

  #region GenerateSimpleEnumTypeProperty code
  private bool GenerateSimpleEnumTypePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(false, true, true);
    var targetPropType = prop.GetTargetType();
    var targetPropTypeName = targetPropType.GetFullName(true, true, true);
    GlobalUsings.Add(origPropType.OriginalNamespace);
    Writer.WriteLine($"get => _Element?.{origPropName}?.GetEnumValue<{targetPropTypeName}, {origPropTypeName}>();");
    return true;
  }

  private bool GenerateSimpleEnumTypePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(false, true, true);
    var targetPropType = prop.GetTargetType();
    var targetPropTypeName = targetPropType.GetFullName(true, true, true);
    GlobalUsings.Add(origPropType.OriginalNamespace);
    Writer.WriteLine($"set => _ExistingElement.{origPropName} = EnumValueUtils.SetEnumValue<{targetPropTypeName}, {origPropTypeName}>(value);");
    return true;
  }
  #endregion

  #region GenerateEnumTypeProperty code
  private bool GenerateEnumTypePropertyGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    var origPropType = prop.PropertyType;
    var origPropValueType = GetOpenXmlEnumValueType(origPropType.Type);
    var targetPropType = prop.GetTargetType();
    if (origPropValueType != null && targetPropType != null)
    {
      var targetPropTypeName = targetPropType.GetFullName(true, true, true);
      GlobalUsings.Add(origPropType.OriginalNamespace);
      Writer.WriteLine($"get => _Element?.GetEnumVal<{targetPropTypeName}, {origPropTypeName}>();");
      return true;
    }
    return GenerateGetNotImplementedException($"enum propertyType baseType is {prop.PropertyType.Type.BaseType}");
  }

  private bool GenerateEnumTypePropertySetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    var origPropType = prop.PropertyType;
    var origPropValueType = GetOpenXmlEnumValueType(origPropType.Type);
    var targetPropType = prop.GetTargetType();
    if (origPropValueType != null && targetPropType != null)
    {
      var targetPropTypeName = targetPropType.GetFullName(true, true, true);
      GlobalUsings.Add(origPropType.OriginalNamespace);
      Writer.WriteLine($"set => _ExistingElement.SetEnumVal<{targetPropTypeName}, {origPropTypeName}>(value);");
      return true;
    }
    return GenerateSetNotImplementedException($"enum propertyType baseType is {prop.PropertyType.Type.BaseType}");
  }
  #endregion

  #endregion

  #region String property access code generation

  #region GenerateStringProperty code
  private bool GenerateStringPropertyGetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(StringValue)))
      return GenerateStringValuePropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
      return GenerateStringOpenXmlLeafElementPropertyGetCode(prop);
    return GenerateGetNotImplementedException($"string propertyType baseType is {prop.PropertyType.Type.BaseType}");
  }

  private bool GenerateStringPropertySetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(StringValue)))
      return GenerateStringValuePropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
      return GenerateStringOpenXmlLeafElementPropertySetCode(prop);
    return GenerateSetNotImplementedException($"string propertyType baseType is {prop.PropertyType.Type.BaseType}");
  }
  #endregion

  #region GenerateStringValueProperty code
  private bool GenerateStringValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"get => _Element?.{origPropName};");
    return true;
  }

  private bool GenerateStringValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"set => _ExistingElement.{origPropName} = value;");
    return true;
  }
  #endregion

  #region GenerateStringOpenXmlLeafElementProperty code
  private bool GenerateStringOpenXmlLeafElementPropertyGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    Writer.WriteLine($"get => _Element?.GetStringVal<{origPropTypeName}>();");
    return true;
  }

  private bool GenerateStringOpenXmlLeafElementPropertySetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    Writer.WriteLine($"set => _ExistingElement.SetStringVal<{origPropTypeName}>(value);");
    return true;
  }
  #endregion

  #region GenerateNumericValueProperty code
  private bool GenerateNumericValuePropertyGetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TypedOpenXmlLeafElement)))
      return GenerateIntegerTypedOpenXmlLeafElementPropertyGetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(IntegerValue)))
      return GenerateIntValuePropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(Int32Value)))
      return GenerateIntValuePropertyGetCode(prop);
    return GenerateGetNotImplementedException($"numeric propertyType baseType is {prop.PropertyType.Type.BaseType}");
  }

  private bool GenerateNumericValuePropertySetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TypedOpenXmlLeafElement)))
      return GenerateIntegerTypedOpenXmlLeafElementPropertySetCode(prop);
    else
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(IntegerValue)))
      return GenerateIntValuePropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(Int32Value)))
      return GenerateIntValuePropertySetCode(prop);
    return GenerateSetNotImplementedException($"numeric propertyType baseclass is {prop.PropertyType.Type.BaseType}");
  }
  #endregion

  #region GenerateIntValueProperty code
  private bool GenerateIntValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"get => _Element?.{origPropName}?.Value;");
    return true;
  }

  private bool GenerateIntValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"set => _ExistingElement.{origPropName} = value;");
    return true;
  }
  #endregion

  #region GenerateIntegerTypedOpenXmlLeafElementProperty code
  private bool GenerateIntegerTypedOpenXmlLeafElementPropertyGetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(false, true, true);
    var targetPropTypeName = prop.PropertyType.GetTargetName();
    GlobalUsings.Add(origPropType.OriginalNamespace);
    Writer.WriteLine($"get => _Element?.GetIntVal<{targetPropTypeName}, {origPropTypeName}>();");
    return true;
  }

  private bool GenerateIntegerTypedOpenXmlLeafElementPropertySetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(false, true, true);
    var targetPropTypeName = prop.PropertyType.GetTargetName();
    GlobalUsings.Add(origPropType.OriginalNamespace);
    Writer.WriteLine($"set => _ExistingElement.SetIntVal<{targetPropTypeName}, {origPropTypeName}>(value);");
    return true;
  }
  #endregion

  #region GenerateBase64Binary code
  private bool GenerateBase64BinaryPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"get => Base64BinaryConverter.GetValue(_Element?.{origPropName});");
    return true;
  }

  private bool GenerateBase64BinaryPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    if (prop.PropertyType.Type == typeof(DX.Base64BinaryValue))
      Writer.WriteLine($"set => _ExistingElement.{origPropName} = Base64BinaryConverter.CreateBase64BinaryValue(value);");
    else
    {
      var origPropType = prop.PropertyType;
      var origPropTypeName = origPropType.GetFullName(false, true, true);
      GlobalUsings.Add(origPropType.OriginalNamespace);
      Writer.WriteLine($"set => _ExistingElement.{origPropName} = Base64BinaryConverter.CreateOpenXmlElement<{origPropTypeName}>(value);");
    }
    return true;
  }
  #endregion
  #endregion

  #region Boolean property access code generation

  #region GenerateBooleanProperty code
  private bool GenerateBooleanPropertyGetCode(PropInfo prop)
  {
    //if (prop.PropertyType.Type == typeof(Boolean))
    //  return GenerateSameTypePropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(BooleanValue)))
      return GenerateBooleanValuePropertyGetCode(prop);
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffValue)))
    //  return GenerateBooleanOnOffValuePropertyGetCode(prop);
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffOnlyValues)))
    //  return GenerateBooleanOnOffOnlyValuePropertyGetCode(prop);
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TrueFalseValue)))
    //  return GenerateBooleanTrueFalseValuePropertyGetCode(prop);
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TrueFalseBlankValue)))
    //  return GenerateBooleanTrueFalseBlankValuePropertyGetCode(prop);
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffType)))
    //  return GenerateBooleanOnOffTypePropertyGetCode(prop);
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffOnlyType)))
    //  return GenerateBooleanOnOffOnlyTypePropertyGetCode(prop);
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(EmptyType)))
    //  return GenerateBooleanEmptyTypeElementPropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TypedOpenXmlLeafElement)))
      return GenerateBooleanTypedOpenXmlLeafElementPropertyGetCode(prop);
    return GenerateGetNotImplementedException($"boolean propertyType is {prop.PropertyType.Type}");
  }

  private bool GenerateBooleanPropertySetCode(PropInfo prop)
  {
    //if (prop.PropertyType.Type == typeof(Boolean))
    //  return GenerateSameTypePropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(BooleanValue)))
      return GenerateBooleanValuePropertySetCode(prop);
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffValue)))
    //  return GenerateBooleanOnOffValuePropertySetCode(prop);
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffOnlyValues)))
    //  return GenerateBooleanOnOffOnlyValuePropertySetCode(prop);
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TrueFalseValue)))
    //  return GenerateBooleanTrueFalseValuePropertySetCode(prop);
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TrueFalseBlankValue)))
    //  return GenerateBooleanTrueFalseBlankValuePropertySetCode(prop);
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffType)))
    //  return GenerateBooleanOnOffTypePropertySetCode(prop);
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffOnlyType)))
    //  return GenerateBooleanOnOffOnlyTypePropertySetCode(prop);
    //if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(EmptyType)))
    //  return GenerateBooleanEmptyTypeElementPropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TypedOpenXmlLeafElement)))
      return GenerateBooleanTypedOpenXmlLeafElementPropertySetCode(prop);
    return GenerateSetNotImplementedException($"boolean propertyType is {prop.PropertyType.Type}");
  }
  #endregion

  #region GenerateBooleanValueProperty code
  private bool GenerateBooleanValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"get => _Element?.{origPropName}?.Value;");
    return true;
  }

  private bool GenerateBooleanValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"set => _ExistingElement.{origPropName} = value;");
    return true;
  }
  #endregion

  #region GenerateBooleanOnOffValue code
  private bool GenerateBooleanOnOffValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return BooleanValueConverter.GetValue(_Element?.{origPropName});");
    return true;
  }

  private bool GenerateBooleanOnOffValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"_ExistingElement.{origPropName} = BooleanValueConverter.CreateOnOffValue(value);");
    return true;
  }
  #endregion

  #region GenerateBooleanOnOffOnlyValue code
  private bool GenerateBooleanOnOffOnlyValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return BooleanValueConverter.GetValue(_Element?.{origPropName});");
    return true;
  }

  private bool GenerateBooleanOnOffOnlyValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"_ExistingElement.{origPropName} = BooleanValueConverter.CreateOnOffOnlyValue(value);");
    return true;
  }
  #endregion

  #region GenerateBooleanTrueFalseValueProperty code
  private bool GenerateBooleanTrueFalseValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return _Element?.{origPropName}?.Value;");
    return true;
  }

  private bool GenerateBooleanTrueFalseValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = value;");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateBooleanTrueFalseBlankValueProperty code
  private bool GenerateBooleanTrueFalseBlankValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return _Element?.{origPropName}?.Value;");
    return true;
  }

  private bool GenerateBooleanTrueFalseBlankValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = value;");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  _ExistingElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateBooleanOnOffTypeProperty code
  private bool GenerateBooleanOnOffTypePropertyGetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(false, true, true);
    Writer.WriteLine($"return BooleanValueConverter.GetValue(_Element?.GetFirstChild<{origPropTypeName}>());");
    return true;
  }

  private bool GenerateBooleanOnOffTypePropertySetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(false, true, true);
    Writer.WriteLine($"BooleanValueConverter.SetOnOffType<{origPropTypeName}>(_ExistingElement, value);");
    return true;
  }
  #endregion

  #region GenerateBooleanOnOffOnlyTypeProperty code
  private bool GenerateBooleanOnOffOnlyTypePropertyGetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(false, true, true);
    Writer.WriteLine($"return BooleanValueConverter.GetValue(_Element?.GetFirstChild<{origPropTypeName}>());");
    return true;
  }

  private bool GenerateBooleanOnOffOnlyTypePropertySetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(false, true, true);
    Writer.WriteLine($"BooleanValueConverter.SetOnOffOnlyType<{origPropTypeName}>(_ExistingElement, value);");
    return true;
  }
  #endregion

  #region GenerateBooleanEmptyTypeElementProperty code
  private bool GenerateBooleanEmptyTypeElementPropertyGetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(false, true, true);
    Writer.WriteLine($"var element = _ExistingElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"return (element != null) ? true : null;");
    return true;
  }

  private bool GenerateBooleanEmptyTypeElementPropertySetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(false, true, true);
    Writer.WriteLine($"if (value == false)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var itemElement = _ExistingElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"  if (itemElement != null)");
    Writer.WriteLine($"    itemElement.Remove();");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"if (value == true)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var itemElement = new {origPropTypeName}();");
    Writer.WriteLine($"  _ExistingElement.AddChild(itemElement);");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region GenerateBooleanTypedOpenXmlLeafElementProperty code
  private bool GenerateBooleanTypedOpenXmlLeafElementPropertyGetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(false, true, true);
    GlobalUsings.Add(origPropType.OriginalNamespace);
    Writer.WriteLine($"get => _Element?.GetBoolVal<{origPropTypeName}>();");
    return true;
  }

  private bool GenerateBooleanTypedOpenXmlLeafElementPropertySetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(false, true, true);
    GlobalUsings.Add(origPropType.OriginalNamespace);
    Writer.WriteLine($"set => _ExistingElement.SetBoolVal<{origPropTypeName}>(value);");
    return true;
  }
  #endregion

  #endregion

  #region Unconverted property access code generation

  #region GenerateSameTypeProperty code
  private bool GenerateSameTypePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return _Element?.{origPropName};");
    return true;
  }

  private bool GenerateSameTypePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"_ExistingElement.{origPropName} = value;");
    return true;
  }
  #endregion

  #endregion

  #region Content element property access code generation

  #region GenerateContentElementProperty code
  private bool GenerateContentElementPropertyGetCode(PropInfo prop)
  {
    var targetPropTypeName = prop.GetTargetType().GetFullName(true, true, true);
    var origPropElementTypeName = prop.PropertyType.GetFullName(false, true, true);
    //Writer.WriteLine($"var element = _Element?.GetFirstChild<{origPropElementTypeName}>();");
    //Writer.WriteLine($"if (element != null)");
    //Writer.WriteLine($"  return {ConverterGetMethodName(prop)}(element);");
    //Writer.WriteLine($"return null;");
    Writer.WriteLine($"return _Element?.GetObject<{targetPropTypeName},{origPropElementTypeName}>();");
    return true;
  }

  private bool GenerateContentElementPropertySetCode(PropInfo prop)
  {
    var origPropElementTypeName = prop.PropertyType.GetFullName(false, true, true);
    var targetPropType = prop.GetTargetType();
    var targetPropTypeName = targetPropType.GetFullName(true, true, true);
    //if (targetPropTypeName.Name == "AdjustPoint2DType")
    //  Debug.Assert(true);
    //var generic = targetPropType.GetIncomingRelationships(Semantics.Inheritance).Count() > 0;
    //Writer.WriteLine($"var itemElement = _ExistingElement.GetFirstChild<{origPropElementTypeName}>();");
    //Writer.WriteLine($"if (itemElement != null)");
    //Writer.WriteLine($"  itemElement.Remove();");
    //Writer.WriteLine($"if (value != null)");
    //Writer.WriteLine($"{{");
    //Writer.WriteLine($"  itemElement = {ConverterCreateMethodName(prop)}(value);");
    //Writer.WriteLine($"  if (itemElement != null)");
    //Writer.WriteLine($"    _ExistingElement.AddChild(itemElement);"); // nocast
    //Writer.WriteLine($"}}");
    Writer.WriteLine($"_ExistingElement.SetObject<{targetPropTypeName},{origPropElementTypeName}>(value);");
    return true;
  }
  #endregion

  #region GenerateContentEnumValProperty code
  private bool GenerateContentEnumValPropertyGetCode(PropInfo prop)
  {
    //if (prop.Name.StartsWith("Grouping"))
    //  Debug.Assert(true);
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    var origPropType = prop.PropertyType.Type;
    var origPropValueType = GetOpenXmlLeafEnumValueType(origPropType);
    var targetPropType = prop.GetTargetType();
    if (origPropValueType != null && targetPropType != null)
    {
      var origPropValueTypeName = origPropValueType.FullName;
      var targetPropTypeName = targetPropType.GetFullName(true, true, true);
      Writer.WriteLine($"return EnumValueConverter.GetValue<{origPropValueTypeName}, {targetPropTypeName}>(_ExistingElement.GetFirstChild<{origPropTypeName}>()?.Val?.Value);");
      return true;
    }
    throw new InvalidOperationException($"Not supported propertyType {prop.PropertyType.Type} in GenerateContentEnumValPropertyGetCode");
  }

  private bool GenerateContentEnumValPropertySetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    var origPropType = prop.PropertyType.Type;
    var origPropValueType = GetOpenXmlLeafEnumValueType(origPropType);
    var targetPropType = prop.GetTargetType();
    if (origPropValueType != null && targetPropType != null)
    {
      var origPropValueTypeName = origPropValueType.FullName;
      var targetPropTypeName = targetPropType.GetFullName(true, true, true);
      Writer.WriteLine($"var itemElement = _ExistingElement.GetFirstChild<{origPropTypeName}>();");
      Writer.WriteLine($"if (itemElement != null)");
      Writer.WriteLine($"{{");
      Writer.WriteLine($"  if (value != null)");
      Writer.WriteLine($"    EnumValueConverter" +
        $".UpdateOpenXmlElement<{origPropValueTypeName}, {targetPropTypeName}>(itemElement, ({targetPropTypeName})value);");
      Writer.WriteLine($"  else");
      Writer.WriteLine($"    itemElement.Remove();");
      Writer.WriteLine($"}}");
      Writer.WriteLine($"else");
      Writer.WriteLine($"if (value != null)");
      Writer.WriteLine($"  _ExistingElement.AddChild(EnumValueConverter" +
        $".CreateOpenXmlElement<{origPropTypeName}, {origPropValueTypeName}, {targetPropTypeName}>(({targetPropTypeName})value));");
      return true;
    }
    throw new InvalidOperationException($"Not supported propertyType {prop.PropertyType.Type} in GenerateContentEnumValPropertySetCode");
  }
  #endregion

  #endregion

  #region Collection property access code generation

  #region GenerateCollection code
  private bool GenerateCollectionGetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    if (origPropType.Name == "PartExtensionProvider")
      Debug.Assert(true);
    var args = origPropType.GetGenericArguments();
    if (args.Length == 1)
    {
      var origItemType = args[0];
      var origItemTypeName = origItemType.GetFullName(false, true, true);
      if (origItemTypeName.Name.EndsWith("Part"))
        return GenerateCollectionOfPartsGetCode(prop);
      if (origItemTypeName.Name.EndsWith("IdPartPair"))
        return GenerateCollectionOfPartsGetCode(prop);
      if (origItemTypeName.Name.EndsWith("Relationship"))
        return GenerateCollectionOfRelationshipGetCode(prop);
      return GenerateCollectionOfElementsGetCode(prop);
    }
    else if (args.Length == 2)
      return false;
    throw new InvalidOperationException($"Not supported propertyType {prop.PropertyType.Type} in GenerateCollectionGetCode");
  }

  private bool GenerateCollectionSetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var args = origPropType.GetGenericArguments();
    if (args.Length == 1)
    {
      var origItemType = args[0];
      var origItemTypeName = origItemType.GetFullName(false, true, true);
      if (origItemTypeName.Name.EndsWith("Part"))
        return GenerateCollectionOfPartsSetCode(prop);
      if (origItemTypeName.Name.EndsWith("IdPartPair"))
        return GenerateCollectionOfPartsSetCode(prop);
      if (origItemTypeName.Name.EndsWith("Relationship"))
        return GenerateCollectionOfRelationshipSetCode(prop);
      return GenerateCollectionOfElementsSetCode(prop);
    }
    else if (args.Length == 2)
      return false;
    throw new InvalidOperationException($"Not supported propertyType {prop.PropertyType?.Type} in GenerateCollectionSetCode");
  }

  #endregion

  #region GenerateCollectionOfElements code
  private bool GenerateCollectionOfElementsGetCode(PropInfo prop)
  {
    //if (prop.Name == "Items" && prop.PropertyType.Type.FullName?.Contains("Behavior") == true)
    //  Debug.WriteLine(prop.PropertyType.Type.FullName);
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericArguments().FirstOrDefault();
    Debug.Assert(origItemType != null);
    var origItemTypeName = origItemType?.GetFullName(false, true, true);
    var targetPropType = prop.GetTargetType();
    Writer.WriteLine($"if (_Element==null)");
    Writer.WriteLine($"  return null;");
    if (targetPropType.IsConstructedGenericType)
    {
      var targetItemType = targetPropType.GetGenericArguments().FirstOrDefault();
      var targetItemTypeName = targetItemType?.GetFullName(true, true, true);
      Writer.WriteLine($"var collection = new ElementCollection<{targetItemTypeName}>();");
    }
    else
    {
      var targetTypeName = targetPropType.GetFullName(true, true, true);
      Writer.WriteLine($"var collection = new {targetTypeName}();");
    }

    Writer.WriteLine($"foreach (var item in _ExistingElement.Elements<{origItemTypeName}>())");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var newItem = {ConverterGetMethodName(prop)}(item);");
    Writer.WriteLine($"  if (newItem is not null)");
    Writer.WriteLine($"    collection.Add({ConverterTypeCast(prop)}newItem);");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"if (collection.Count>0)");
    Writer.WriteLine($"  return collection;");
    Writer.WriteLine($"return null;");
    return true;
  }
  private bool GenerateCollectionOfElementsSetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericArguments().FirstOrDefault();
    var targetPropType = prop.GetTargetType();
    var targetItemType = targetPropType.GetGenericArguments().FirstOrDefault();
    var origItemTypeName = origItemType?.GetFullName(false, true, true);
    //var targetItemTypeName = targetItemType?.GetFullName(true, true, true);
    //var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    //var origPropType = prop.PropertyType;
    //var origItemType = origPropType.GetGenericTypeArguments().FirstOrDefault();
    //origItemType = origItemType?.GetOriginType();
    //var origItemTypeName = origItemType?.GetFullName(false, true, true);
    //var targetPropType = prop.GetTargetType();
    //if (targetPropType.IsConstructedGenericType)
    //{
    //  var targetItemType = targetPropType.GetGenericTypeArguments().FirstOrDefault();
    //  var targetItemTypeName = targetItemType?.GetFullName(true, true, true);
    //  Writer.WriteLine($"var collection = new Collection<{targetItemTypeName}>();");
    //}
    //else
    //{
    //  var targetTypeName = targetPropType.GetFullName(true, true, true);
    //  Writer.WriteLine($"var collection = new {targetTypeName}();");
    //}
    Writer.WriteLine($"_ExistingElement.RemoveAllChildren<{origItemTypeName}>();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  foreach (var item in value)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    var newItem = {ConverterCreateMethodName(prop)}(item);");
    Writer.WriteLine($"    if (newItem != null)");
    Writer.WriteLine($"      _ExistingElement.AddChild(newItem);");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region GenerateCollectionOfParts code
  private bool GenerateCollectionOfPartsGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericArguments().FirstOrDefault();
    var targetPropType = prop.GetTargetType();
    var targetItemType = targetPropType.GetGenericArguments().FirstOrDefault();
    var origItemTypeName = origItemType?.GetFullName(false, true, true);
    var targetItemTypeName = targetItemType?.GetFullName(true, true, true);
    Writer.WriteLine($"var collection = new Collection<{targetItemTypeName}>();");
    if (origItemTypeName?.Name == "IdPartPair")
      Writer.WriteLine($"foreach (var item in _ExistingElement.Parts)");
    else if (origItemTypeName?.Name == "DataPart")
      Writer.WriteLine($"foreach (var item in _ExistingElement.DataParts)");
    else if (origItemTypeName != null)
      Writer.WriteLine($"foreach (var item in _ExistingElement.GetPartsOfType<{origItemTypeName}>())");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var newItem = {ConverterGetMethodName(prop)}(item);");
    Writer.WriteLine($"  if (newItem is not null)");
    Writer.WriteLine($"    collection.Add({ConverterTypeCast(prop)}newItem);");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"return collection;");
    return true;
  }

  private bool GenerateCollectionOfPartsSetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericArguments().FirstOrDefault();
    var targetPropType = prop.GetTargetType();
    var targetItemType = targetPropType.GetGenericArguments().FirstOrDefault();
    var origItemTypeName = origItemType?.GetFullName(false, true, true);
    var targetItemTypeName = targetItemType?.GetFullName(true, true, true);
    Writer.WriteLine($"_ExistingElement.RemoveAllChildren<{origItemTypeName}>();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  foreach (var item in value)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    var newItem = {ConverterCreateMethodName(prop)}(item);");
    Writer.WriteLine($"    if (newItem is not null)");
    Writer.WriteLine($"      _ExistingElement.AddChild({ConverterTypeCast(prop)}newItem);");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region GenerateCollectionOfRelationship code
  private bool GenerateCollectionOfRelationshipGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericArguments().FirstOrDefault();
    var targetPropType = prop.GetTargetType();
    var targetItemType = targetPropType.GetGenericArguments().FirstOrDefault();
    var origItemTypeName = origItemType?.GetFullName(false, true, true);
    var targetItemTypeName = targetItemType?.GetFullName(true, true, true);
    Writer.WriteLine($"var collection = new Collection<{targetItemTypeName}>();");
    Writer.WriteLine($"foreach (var item in _ExistingElement.{origItemTypeName?.Name}s)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var newItem = {ConverterGetMethodName(prop)}(item);");
    Writer.WriteLine($"  if (newItem is not null)");
    Writer.WriteLine($"    collection.Add(newItem);");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"return collection;");
    return true;
  }

  private bool GenerateCollectionOfRelationshipSetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericArguments().FirstOrDefault();
    var targetPropType = prop.GetTargetType();
    var targetItemType = targetPropType.GetGenericArguments().FirstOrDefault();
    var origItemTypeName = origItemType?.GetFullName(false, true, true);
    var targetItemTypeName = targetItemType?.GetFullName(true, true, true);
    Writer.WriteLine($"_ExistingElement.RemoveAllChildren<{origItemTypeName}>();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  foreach (var item in value)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    var newItem = {ConverterCreateMethodName(prop)}(item);");
    Writer.WriteLine($"    if (newItem is not null)");
    Writer.WriteLine($"      _ExistingElement.AddChild(newItem);");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region Generate Part properties access code

  private bool GeneratePartRootElementPropertyGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    Writer.WriteLine($"  return {ConverterGetMethodName(prop)}(_Element?.RootElement as {origPropTypeName});");
    return true;
  }

  private bool GeneratePartRootElementPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(false, true, true);
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"   var rootElement = {ConverterCreateMethodName(prop)}(value);");
    Writer.WriteLine($"   if (rootElement != null)");
    Writer.WriteLine($"     _ExistingElement.{origPropName} = rootElement;");
    Writer.WriteLine($"}}");
    return true;
  }

  #endregion

  #endregion

  #region Converter method names

  private string ConverterGetMethodName(PropInfo prop)
  {
    //if (prop.Name == "Items" && prop.PropertyType.Type.FullName?.Contains("Behavior") == true)
    //  Debug.Assert(true);
    var targetPropType = prop.PropertyType.GetConversionTargetOrSelf();
    var origPropType = prop.PropertyType;
    return ConverterGetMethodName(targetPropType, origPropType);
  }

  private string ConverterGetMethodName(TypeInfo targetPropType, TypeInfo origPropType)
  {
    if (targetPropType.IsSimple())
      return SimpleTypeConverterGetMethodName(targetPropType, origPropType);
    FullTypeName convPropName;
    var origItemType = origPropType.GetGenericArguments().FirstOrDefault();
    var targetItemType = origItemType?.GetConversionTarget();
    if (origItemType != null && targetItemType != null)
    {
      if (origItemType != null && targetItemType.IsSimple())
        return SimpleTypeConverterGetMethodName(targetItemType, origItemType);
      convPropName = new FullTypeName(GetStandardConverterName(targetItemType),
        TypeInfo.NamespaceShortcut(targetItemType.GetTargetNamespace().ReplaceStart("DocumentModel", "DocumentModel.OpenXml")));
    }
    else if (targetPropType.Type == typeof(byte[]) || targetPropType.Type == typeof(HexBinary))
    {
      convPropName = new FullTypeName("HexBinaryConverter", "DMX");
      return $"{convPropName}.GetValue";
    }
    else
    {
      convPropName = new FullTypeName(GetStandardConverterName(targetPropType),
        TypeInfo.NamespaceShortcut((targetPropType?.GetTargetNamespace() ?? "").ReplaceStart("DocumentModel", "DocumentModel.OpenXml")));
    }
    return $"{convPropName}.CreateModelElement";
  }

  private string GetStandardConverterName(TypeInfo typeInfo)
  {
    var converterTypeName = typeInfo.Name;
    if (converterTypeName.StartsWith("Enum"))
      converterTypeName = "EnumValueConverter";
    else
      converterTypeName = converterTypeName + "Converter";
    return converterTypeName;
  }

  private string SimpleTypeConverterGetMethodName(TypeInfo targetPropType, TypeInfo origPropType)
  {
    var targetPropTypeName = targetPropType.GetFullName(true, true, true);
    var origPropTypeName = origPropType.GetFullName(false, true, true);
    if (targetPropTypeName.Name == "String")
      return "StringValueConverter.GetValue";
    if (targetPropTypeName.Name == "UInt32")
      return "UInt32ValueConverter.GetValue";
    if (targetPropTypeName.Name == "HexInt")
      return "HexIntConverter.GetValue";
    if (targetPropTypeName.Name == "NumId")
      return "NumIdConverter.GetValue";
    if (targetPropTypeName.Name == "HexBinary")
      return "HexBinaryConverter.GetValue";
    if (targetPropTypeName.Name == "Base64Binary")
      return "Base64BinaryConverter.GetValue";
    if (targetPropTypeName.Name == "NumericValue")
      return "NumericValueConverter.GetValue";
    if (targetPropTypeName.Name == "Byte[]")
    {
      if (origPropTypeName.Name == "HexBinaryValue")
        return "HexBinaryConverter.GetValue";
      if (origPropTypeName.Name == "Base64BinaryValue")
        return "Base64BinaryConverter.GetValue";
      return "ByteArrayConverter.GetValue";
    }
    var targetConversionType = targetPropType.GetConversionTarget();
    if (targetConversionType != null && targetConversionType.Type.IsEnum)
      return $"EnumValueConverter.GetValue<{origPropTypeName},{targetPropTypeName}>";
    return string.Empty;
  }

  private string EnumValueConverterGetMethodName(TypeInfo typeInfo)
  {
    var targetInfo = typeInfo.GetConversionTarget();
    return string.Empty;
  }

  private string ConverterCreateMethodName(PropInfo prop)
  {
    if (prop.Name == "Items" && prop.PropertyType.Name.StartsWith("ElementCollection") && prop.PropertyType.GetGenericArguments().FirstOrDefault()?.Name == "NumericValue")
      Debug.Assert(true);
    var targetPropType = prop.GetTargetType();
    var origPropType = prop.PropertyType;
    var targetPropTypeName = targetPropType.GetFullName(true, true, true);
    var origPropTypeName = origPropType.GetFullName(false, true, true);
    var generic = true;
    if (targetPropType.IsSimple())
      return SimpleTypeConverterCreateMethodName(targetPropTypeName, origPropTypeName);
    FullTypeName convPropName;
    var origItemType = origPropType.GetGenericArguments().FirstOrDefault();
    var targetItemType = origItemType?.GetConversionTarget();
    if (origItemType != null && targetItemType != null)
    {
      if (targetItemType.IsSimple())
        return SimpleTypeConverterCreateMethodName(targetItemType.GetFullName(true, true, true), origItemType.GetFullName(false, true, true));

      convPropName = new FullTypeName(targetItemType.Name + "Converter",
        TypeInfo.NamespaceShortcut((targetItemType?.GetTargetNamespace() ?? "").ReplaceStart("DocumentModel", "DocumentModel.OpenXml")));
      origPropTypeName = origItemType.GetFullName(false, true, true);
    }
    else if (targetPropTypeName.Name == "Byte[]")
      convPropName = new FullTypeName("HexBinaryConverter", "DMX");
    else
      convPropName = new FullTypeName(GetStandardConverterName(targetPropType),
        TypeInfo.NamespaceShortcut((targetPropType.GetTargetNamespace() ?? "").ReplaceStart("DocumentModel", "DocumentModel.OpenXml")));
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
    if (targetPropTypeName.Name == "HexInt")
      return $"HexIntConverter.CreateOpenXmlElement<{origPropTypeName}>";
    if (targetPropTypeName.Name == "NumId")
      return $"NumIdConverter.CreateOpenXmlElement<{origPropTypeName}>";
    if (targetPropTypeName.Name == "NumericValue")
      return $"NumericValueConverter.CreateOpenXmlElement<{origPropTypeName}>";
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
    return ConverterTypeCast(targetPropType, origPropType);
  }

  private string? ConverterTypeCast(TypeInfo targetPropType, TypeInfo origPropType)
  {
    var targetPropTypeName = targetPropType.GetFullName(true, true, true);
    if (targetPropType.IsSimple())
      return SimpleTypeConverterTypeCast(targetPropTypeName);
    var origItemType = origPropType.GetGenericArguments().First();
    var targetItemType = origItemType?.GetConversionTarget();
    if (origItemType != null && targetItemType != null)
    {
      if (targetItemType.IsSimple())
        return SimpleTypeConverterTypeCast(targetItemType.GetFullName(true, true, true));
    }
    return null;
  }

  private string? SimpleTypeConverterTypeCast(FullTypeName targetPropTypeName)
  {
    if (targetPropTypeName.Name == "String")
      return "(string)";
    if (targetPropTypeName.Name == "UInt32")
      return "(UInt32)";
    if (targetPropTypeName.Name == "HexInt")
      return "(HexInt)";
    if (targetPropTypeName.Name == "NumId")
      return "(NumId)";
    if (targetPropTypeName.Name == "NumericValue")
      return "(NumericValue)";
    return null;
  }

  #endregion

  #region GenerateNotImplementedException
  private bool GenerateGetNotImplementedException(string msg, [CallerMemberName] string? callerName = null)
  {
    var message = $"\"Not implemented in {callerName}: {msg}\"";
    Writer.WriteLine($"get => throw new NotImplementedException({message});");
    return true;
  }

  private bool GenerateSetNotImplementedException(string msg, [CallerMemberName] string? callerName = null)
  {
    var message = $"\"Not implemented in {callerName}: {msg}\"";
    Writer.WriteLine($"set => throw new NotImplementedException({message});");
    return true;
  }
  #endregion

}