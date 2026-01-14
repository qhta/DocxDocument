namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for VTVector types in Open XML.
/// </summary>
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

  /// <summary>
  /// Retrieves the size property from the VTVector element.
  /// </summary>
  /// <param name="openXmlElement">The VTVector element.</param>
  /// <returns>The size as a UInt32, or null if not set.</returns>
  public static UInt32? GetSize(this VTVector openXmlElement)
  {
    if (openXmlElement.Size?.Value != null)
      return openXmlElement.Size?.Value;
    return null;
  }

  /// <summary>
  /// Sets the size property of the VTVector element.
  /// </summary>
  /// <param name="openXmlElement">The VTVector element.</param>
  /// <param name="value">The size value to set.</param>
  public static void SetSize(this VTVector openXmlElement, UInt32? value)
  {
    openXmlElement.Size = value;
  }

  /// <summary>
  /// Retrieves the base type of the vector from the VTVector element.
  /// </summary>
  /// <param name="openXmlElement">The VTVector element.</param>
  /// <returns>The VariantType representing the base type, or null if not set.</returns>
  public static VariantType? GetBaseType(this VTVector openXmlElement)
  {
    if (openXmlElement.BaseType?.Value != null)
      return VectorBaseTypeConversion.GetValue2(openXmlElement.BaseType.Value);
    return null;
  }

  /// <summary>
  /// Sets the base type of the VTVector element.
  /// </summary>
  /// <param name="openXmlElement">The VTVector element.</param>
  /// <param name="value">The VariantType to set. Null removes the property.</param>
  public static void SetBaseType(this VTVector openXmlElement, VariantType? value)
  {
    if (value != null)
      openXmlElement.BaseType = VectorBaseTypeConversion.GetValue1((VariantType)value);
    else
      openXmlElement.BaseType = null;
  }

  /// <summary>
  /// Converts a VTVector element to a VectorVariant model.
  /// </summary>
  /// <param name="openXmlElement">The VTVector element to convert.</param>
  /// <returns>A VectorVariant object containing the vector data.</returns>
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

  /// <summary>
  /// Populates a VTVector element with data from a VectorVariant model.
  /// </summary>
  /// <param name="openXmlElement">The VTVector element to populate.</param>
  /// <param name="value">The VectorVariant source data.</param>
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

  /// <summary>
  /// Retrieves the vector contents as a list of strings.
  /// </summary>
  /// <param name="openXmlElement">The VTVector element.</param>
  /// <returns>A StringList containing the string representation of vector items.</returns>
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

  /// <summary>
  /// Populates a VTVector element with data from a StringList.
  /// </summary>
  /// <param name="openXmlElement">The VTVector element to populate.</param>
  /// <param name="value">The StringList source data.</param>
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

  /// <summary>
  /// Creates a VTVector element from a VectorVariant model.
  /// </summary>
  /// <param name="value">The VectorVariant data.</param>
  /// <returns>A new VTVector element.</returns>
  public static VTVector CreateOpenXmlElement(this VectorVariant value)
  {
    var openXmlElement = new VTVector();
    openXmlElement.SetSize((uint)value.Count);
    openXmlElement.SetBaseType(value.BaseType);
    foreach (var item in value)
      openXmlElement.AppendChild(VariantConverter.CreateOpenXmlElement(item));
    return openXmlElement;
  }

  /// <summary>
  /// Creates a VTVector element from a StringList.
  /// </summary>
  /// <param name="value">The StringList data.</param>
  /// <returns>A new VTVector element of base type Lpstr.</returns>
  public static VTVector CreateOpenXmlElement(this StringList value)
  {
    var openXmlElement = new VTVector();
    openXmlElement.SetSize((uint)value.Count);
    openXmlElement.SetBaseType(VariantType.Lpwstr);
    openXmlElement.SetStringList(value);
    return openXmlElement;
  }
}