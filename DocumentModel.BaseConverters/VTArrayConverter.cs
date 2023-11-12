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

  public static VariantType? GetBaseType(VTArray openXmlElement)
  {
    if (openXmlElement?.BaseType?.Value != null)
      return ArrayBaseTypeConversion.GetValue2(openXmlElement.BaseType.Value);
    return null;
  }

  public static void SetBaseType(VTArray openXmlElement, VariantType? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.BaseType = ArrayBaseTypeConversion.GetValue1((VariantType)value);
      else
        openXmlElement.BaseType = null;
    }
  }

  public static int? GetLowerBounds(VTArray openXmlElement)
  {
    return openXmlElement?.LowerBounds?.Value != null ? openXmlElement.LowerBounds.Value : null;
  }

  public static void SetLowerBounds(VTArray openXmlElement, int? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.LowerBounds = value;
      else
        openXmlElement.LowerBounds = null;
    }
    ;
  }

  public static int? GetUpperBounds(VTArray openXmlElement)
  {
    return openXmlElement?.UpperBounds?.Value != null ? openXmlElement.UpperBounds.Value : null;
  }

  public static void SetUpperBounds(VTArray openXmlElement, int? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.UpperBounds = value;
      else
        openXmlElement.UpperBounds = null;
    }
    ;
  }

  public static VariantArray? GetValue(VTArray openXmlElement)
  {
    if (openXmlElement != null)
    {
      var baseType = GetBaseType(openXmlElement);
      var lowerBounds = GetLowerBounds(openXmlElement);
      var upperBounds = GetUpperBounds(openXmlElement);
      var itemType = baseType != null ? Variant.ItemTypes[(VariantType)baseType] : null;
      var _value = new VariantArray(baseType ?? VariantType.Variant, lowerBounds ?? 0, upperBounds ?? openXmlElement.Elements().Count() + 1);
      var i = _value.LowerBounds;
      foreach (var item in openXmlElement.Elements())
      {
        var itemVariant = VariantConverter.GetVariant(item);
        var itemValue = itemType != null ? Convert.ChangeType(itemVariant, itemType) : itemVariant.Value;
        _value[i] = itemValue;
      }
      return _value;
    }
    return null;
  }

  public static void SetValue(VTArray openXmlElement, VariantArray? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren();
      if (value != null)
        foreach (var itemValue in value)
        {
          var itemVariant = VariantConverter.CreateOpenXmlElement(itemValue);
          openXmlElement.AppendChild(itemVariant);
        }
    }
  }

  public static VTArray CreateOpenXmlElement(VariantArray? value)
  {
    var openXmlElement = new VTArray();
    if (value != null)
    {
      SetBaseType(openXmlElement, value.BaseType);
      SetLowerBounds(openXmlElement, value.LowerBounds);
      SetUpperBounds(openXmlElement, value.UpperBounds);
      SetValue(openXmlElement, value);
    }
    return openXmlElement;
  }
}