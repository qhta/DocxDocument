namespace DocumentModel.OpenXml;

public static class VTVectorConverter
{
  private static readonly BiDiDictionary<VectorBaseValues, VariantType> VectorBaseTypeConversion = new()
  {
    { VectorBaseValues.OneByteSignedInteger, VariantType.Byte },
    { VectorBaseValues.TwoBytesSignedInteger, VariantType.Int16 },
    { VectorBaseValues.FourBytesSignedInteger, VariantType.Int32 },
    { VectorBaseValues.EightBytesSignedInteger, VariantType.Int64 },
    { VectorBaseValues.OneByteUnsignedInteger, VariantType.Byte },
    { VectorBaseValues.TwoBytesUnsignedInteger, VariantType.UInt16 },
    { VectorBaseValues.FourBytesUnsignedInteger, VariantType.UInt32 },
    { VectorBaseValues.EightBytesUnsignedInteger, VariantType.UInt64 },
    { VectorBaseValues.FourBytesReal, VariantType.Single },
    { VectorBaseValues.EightBytesReal, VariantType.Double },
    { VectorBaseValues.Bstr, VariantType.Bstr },
    { VectorBaseValues.Lpstr, VariantType.Lpstr },
    { VectorBaseValues.Lpwstr, VariantType.Lpwstr },
    { VectorBaseValues.Date, VariantType.Date },
    { VectorBaseValues.Filetime, VariantType.DateTime },
    { VectorBaseValues.Bool, VariantType.Boolean },
    { VectorBaseValues.Currency, VariantType.Currency },
    { VectorBaseValues.Error, VariantType.HexInt },
    { VectorBaseValues.ClassId, VariantType.Guid },
    { VectorBaseValues.ClipboardData, VariantType.ClipboardData },
    { VectorBaseValues.Variant, VariantType.Variant }
  };

  public static VariantType? GetBaseType(VTVector openXmlElement)
  {
    if (openXmlElement.BaseType?.Value != null)
      return VectorBaseTypeConversion.GetValue2(openXmlElement.BaseType.Value);
    return null;
  }

  public static void SetBaseType(VTVector openXmlElement, VariantType? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.BaseType = VectorBaseTypeConversion.GetValue1((VariantType)value);
      else
        openXmlElement.BaseType = null;
    }
  }

  public static VectorVariant? CreateModelElement(VTVector? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var baseType = GetBaseType(openXmlElement);
      var itemType = baseType != null ? Variant.ItemTypes[(VariantType)baseType] : null;
      var _value = new VectorVariant();
      _value.BaseType = baseType;
      foreach (var item in openXmlElement.Elements())
      {
        var itemValue = VariantConverter.GetValue(item);
        if (itemType != null)
          itemValue = Convert.ChangeType(itemValue, itemType);
        _value.Add(itemValue);
      }
      return _value;
    }
    return null;
  }

  public static void SetValue(VTVector openXmlElement, VectorVariant? value)
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

  public static StringList? GetStringList(VTVector? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var baseType = GetBaseType(openXmlElement);
      var itemType = typeof(string);
      var _value = new StringList();
      foreach (var item in openXmlElement.Elements())
      {
        var itemValue = VariantConverter.GetValue(item);
        if (itemType != null)
        {
          var str = (string?)Convert.ChangeType(itemValue, itemType);
          if (str == null)
            str = string.Empty;
          _value.Add(str);
        }
      }
      return _value;
    }
    return null;
  }

  public static void SetStringList(VTVector openXmlElement, StringList? value)
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

  public static VTVector CreateOpenXmlElement(VectorVariant? value)
  {
    var openXmlElement = new VTVector();
    if (value != null)
    {
      SetBaseType(openXmlElement, value.BaseType);
      SetValue(openXmlElement, value);
    }
    return openXmlElement;
  }

  public static VTVector CreateOpenXmlElement(StringList? value)
  {
    var openXmlElement = new VTVector();
    if (value != null)
    {
      SetBaseType(openXmlElement, VariantType.Lpwstr);
      SetStringList(openXmlElement, value);
    }
    return openXmlElement;
  }
}