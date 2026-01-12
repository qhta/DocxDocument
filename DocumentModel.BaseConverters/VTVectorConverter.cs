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

  public static UInt32? GetSize(this VTVector openXmlElement)
  {
    if (openXmlElement.Size?.Value != null)
      return openXmlElement.Size?.Value;
    return null;
  }

  public static void SetSize(this VTVector openXmlElement, UInt32? value)
  {
    openXmlElement.Size = value;
  }

  public static VariantType? GetBaseType(this VTVector openXmlElement)
  {
    if (openXmlElement.BaseType?.Value != null)
      return VectorBaseTypeConversion.GetValue2(openXmlElement.BaseType.Value);
    return null;
  }

  public static void SetBaseType(this VTVector openXmlElement, VariantType? value)
  {
    if (value != null)
      openXmlElement.BaseType = VectorBaseTypeConversion.GetValue1((VariantType)value);
    else
      openXmlElement.BaseType = null;
  }

  public static VectorVariant? CreateModelElement(this VTVector openXmlElement)
  {
    var baseType = openXmlElement.GetBaseType();
    var itemType = baseType != null ? Variant.ItemTypes[(VariantType)baseType] : null;
    var _value = new VectorVariant
    {
      BaseType = baseType
    };
    foreach (var item in openXmlElement.Elements())
    {
      var itemValue = VariantConverter.GetValue(item);
      if (itemType != null)
        itemValue = Convert.ChangeType(itemValue, itemType);
      _value.Add(itemValue);
    }
    return _value;
  }

  public static void SetValue(this VTVector openXmlElement, VectorVariant? value)
  {
    openXmlElement.RemoveAllChildren();
    if (value != null)
      foreach (var itemValue in value)
      {
        var itemVariant = VariantConverter.CreateOpenXmlElement(itemValue);
        openXmlElement.AppendChild(itemVariant);
      }
  }

  public static StringList? GetStringList(this VTVector openXmlElement)
  {
    var baseType = openXmlElement.GetBaseType();
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

  public static void SetStringList(this VTVector openXmlElement, StringList? value)
  {
    openXmlElement.RemoveAllChildren();
    if (value != null)
      foreach (var itemValue in value)
      {
        var itemVariant = VariantConverter.CreateOpenXmlElement(itemValue);
        openXmlElement.AppendChild(itemVariant);
      }
  }

  public static VTVector CreateOpenXmlElement(this VectorVariant value)
  {
    var openXmlElement = new VTVector();
    openXmlElement.SetSize((uint)value.Count);
    openXmlElement.SetBaseType(value.BaseType);
    foreach (var item in value)
      openXmlElement.AppendChild(VariantConverter.CreateOpenXmlElement(item));
    return openXmlElement;
  }

  public static VTVector CreateOpenXmlElement(this StringList value)
  {
    var openXmlElement = new VTVector();
    openXmlElement.SetSize((uint)value.Count);
    openXmlElement.SetBaseType(VariantType.Lpwstr);
    openXmlElement.SetStringList(value);
    return openXmlElement;
  }
}