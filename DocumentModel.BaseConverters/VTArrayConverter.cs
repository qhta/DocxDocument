namespace DocumentModel.OpenXml;

public static class VTArrayConverter
{
  private static readonly BiDiDictionary<ArrayBaseValues, VariantType> ArrayBaseTypeConversion = new()
  {
    { ArrayBaseValues.Variant, VariantType.Variant },
    { ArrayBaseValues.OneByteSignedInteger, VariantType.SByte },
    { ArrayBaseValues.TwoBytesSignedInteger, VariantType.Int16 },
    { ArrayBaseValues.FourBytesSignedInteger, VariantType.Int32 },
    { ArrayBaseValues.Integer, VariantType.Integer },
    { ArrayBaseValues.OneByteUnsignedInteger, VariantType.Byte },
    { ArrayBaseValues.TwoBytesUnsignedInteger, VariantType.UInt16 },
    { ArrayBaseValues.FourBytesUnsignedInteger, VariantType.UInt32 },
    { ArrayBaseValues.UnsignedInteger, VariantType.UnsignedInteger },
    { ArrayBaseValues.FourBytesReal, VariantType.Single },
    { ArrayBaseValues.EightBytesReal, VariantType.Double },
    { ArrayBaseValues.Decimal, VariantType.Decimal },
    { ArrayBaseValues.Bstr, VariantType.Bstr },
    { ArrayBaseValues.Date, VariantType.Date },
    { ArrayBaseValues.Bool, VariantType.Boolean },
    { ArrayBaseValues.Currency, VariantType.Currency },
    { ArrayBaseValues.Error, VariantType.HexInt }
  };

  public static VariantType? GetBaseType(this VTArray openXmlElement)
  {
    if (openXmlElement?.BaseType?.Value != null)
      return ArrayBaseTypeConversion.GetValue2(openXmlElement.BaseType.Value);
    return null;
  }

  public static void SetBaseType(this VTArray openXmlElement, VariantType? value)
  {

    if (value != null)
      openXmlElement.BaseType = ArrayBaseTypeConversion.GetValue1((VariantType)value);
    else
      openXmlElement.BaseType = null;
  }

  public static int? GetLowerBounds(this VTArray openXmlElement)
  {
    return (openXmlElement.LowerBounds != null) ? openXmlElement.LowerBounds.Value : null;
  }

  public static void SetLowerBounds(this VTArray openXmlElement, int? value)
  {
    openXmlElement.LowerBounds = value;
  }

  public static int? GetUpperBounds(this VTArray openXmlElement)
  {
    return (openXmlElement.UpperBounds != null) ? openXmlElement.UpperBounds.Value : null;
  }

  public static void SetUpperBounds(this VTArray openXmlElement, int? value)
  {
    openXmlElement.UpperBounds = value;
  }

  public static ArrayVariant? GetValue(this VTArray openXmlElement)
  {
    var baseType = openXmlElement.GetBaseType();
    var lowerBounds = openXmlElement.GetLowerBounds();
    var upperBounds = openXmlElement.GetUpperBounds();
    var itemType = baseType != null ? Variant.ItemTypes[(VariantType)baseType] : null;
    var _value = new ArrayVariant(baseType ?? VariantType.Variant, lowerBounds ?? 0, upperBounds ?? openXmlElement.Elements().Count() + 1);
    var i = _value.LowerBounds;
    foreach (var item in openXmlElement.Elements())
    {
      var itemVariant = VariantConverter.GetVariant(item);
      var itemValue = itemType != null ? Convert.ChangeType(itemVariant, itemType) : itemVariant.Value;
      _value[i] = itemValue;
    }
    return _value;
  }


  public static void SetValue(this VTArray openXmlElement, ArrayVariant? value)
  {
    openXmlElement.RemoveAllChildren();
    if (value != null)
      foreach (var itemValue in value)
      {
        var itemVariant = VariantConverter.CreateOpenXmlElement(itemValue);
        openXmlElement.AppendChild(itemVariant);
      }
  }

  public static VTArray CreateOpenXmlElement(this ArrayVariant value)
  {
    var openXmlElement = new VTArray();
    openXmlElement.SetBaseType(value.BaseType);
    openXmlElement.SetLowerBounds(value.LowerBounds);
    openXmlElement.SetUpperBounds(value.UpperBounds);
    openXmlElement.SetValue(value);
    return openXmlElement;
  }
}