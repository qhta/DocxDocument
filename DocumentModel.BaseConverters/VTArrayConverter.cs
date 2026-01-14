namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for VTArray types in Open XML.
/// </summary>
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

  /// <summary>
  /// Retrieves the base type of the array from the VTArray element.
  /// </summary>
  /// <param name="openXmlElement">The VTArray element to query.</param>
  /// <returns>The base VariantType, or null if not set.</returns>
  public static VariantType? GetBaseType(this VTArray openXmlElement)
  {
    if (openXmlElement?.BaseType?.Value != null)
      return ArrayBaseTypeConversion.GetValue2(openXmlElement.BaseType.Value);
    return null;
  }

  /// <summary>
  /// Sets the base type of the VTArray element.
  /// </summary>
  /// <param name="openXmlElement">The VTArray element to modify.</param>
  /// <param name="value">The VariantType to set. Null removes the property.</param>
  public static void SetBaseType(this VTArray openXmlElement, VariantType? value)
  {

    if (value != null)
      openXmlElement.BaseType = ArrayBaseTypeConversion.GetValue1((VariantType)value);
    else
      openXmlElement.BaseType = null;
  }

  /// <summary>
  /// Retrieves the lower bounds of the array from the VTArray element.
  /// </summary>
  /// <param name="openXmlElement">The VTArray element to query.</param>
  /// <returns>The lower bounds integer, or null if not set.</returns>
  public static int? GetLowerBounds(this VTArray openXmlElement)
  {
    return (openXmlElement.LowerBounds != null) ? openXmlElement.LowerBounds.Value : null;
  }

  /// <summary>
  /// Sets the lower bounds of the VTArray element.
  /// </summary>
  /// <param name="openXmlElement">The VTArray element to modify.</param>
  /// <param name="value">The lower bounds value.</param>
  public static void SetLowerBounds(this VTArray openXmlElement, int? value)
  {
    openXmlElement.LowerBounds = value;
  }

  /// <summary>
  /// Retrieves the upper bounds of the array from the VTArray element.
  /// </summary>
  /// <param name="openXmlElement">The VTArray element to query.</param>
  /// <returns>The upper bounds integer, or null if not set.</returns>
  public static int? GetUpperBounds(this VTArray openXmlElement)
  {
    return (openXmlElement.UpperBounds != null) ? openXmlElement.UpperBounds.Value : null;
  }

  /// <summary>
  /// Sets the upper bounds of the VTArray element.
  /// </summary>
  /// <param name="openXmlElement">The VTArray element to modify.</param>
  /// <param name="value">The upper bounds value.</param>
  public static void SetUpperBounds(this VTArray openXmlElement, int? value)
  {
    openXmlElement.UpperBounds = value;
  }

  /// <summary>
  /// Converts a VTArray element to an ArrayVariant object, parsing all contained items.
  /// </summary>
  /// <param name="openXmlElement">The VTArray element to convert.</param>
  /// <returns>An ArrayVariant object populated with the array data.</returns>
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


  /// <summary>
  /// Populates a VTArray element with data from an ArrayVariant object.
  /// </summary>
  /// <param name="openXmlElement">The VTArray element to populate.</param>
  /// <param name="value">The ArrayVariant source data.</param>
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

  /// <summary>
  /// Creates a VTArray element from an ArrayVariant object.
  /// </summary>
  /// <param name="value">The ArrayVariant object to convert.</param>
  /// <returns>A new VTArray element populated with the array data.</returns>
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