namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for unsigned integer values in Open XML.
/// </summary>
public static class UIntValueConverter
{
  /// <summary>
  /// Retrieves a UInt32 value from a DC UnsignedIntegerType element.
  /// </summary>
  /// <param name="element">The UnsignedIntegerType element to convert.</param>
  /// <returns>The UInt32 value, or null if element or value is null.</returns>
  public static UInt32? GetValue(DXDC.UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  /// <summary>
  /// Retrieves a UInt32 value from an Office 2016 DC UnsignedIntegerType element.
  /// </summary>
  /// <param name="element">The UnsignedIntegerType element to convert.</param>
  /// <returns>The UInt32 value, or null if element or value is null.</returns>
  public static UInt32? GetValue(DXO16DC.UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  /// <summary>
  /// Retrieves a UInt32 value from an Office 2016 DCD UnsignedIntegerType element.
  /// </summary>
  /// <param name="element">The UnsignedIntegerType element to convert.</param>
  /// <returns>The UInt32 value, or null if element or value is null.</returns>
  public static UInt32? GetValue(DXO16DCD.UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  /// <summary>
  /// Retrieves a UInt32 value from a LongHexNumberType element by parsing the hex string.
  /// </summary>
  /// <param name="element">The LongHexNumberType element to convert.</param>
  /// <returns>The UInt32 value, or null if element or value is null.</returns>
  public static UInt32? GetValue(DXW.LongHexNumberType element)
  {
    if (element.Val?.Value != null)
      return UInt32.Parse(element.Val.Value, NumberStyles.HexNumber);
    return null;
  }

  /// <summary>
  /// Creates a specific OpenXml element based on a UInt32 value.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXml element to create.</typeparam>
  /// <param name="value">The UInt32 value to set.</param>
  /// <returns>A new instance of the element type with the value set.</returns>
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(UInt32 value)
    where OpenXmlElementType : OpenXmlElement, new()
  {
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Value");
    if (valProperty != null)
      valProperty.SetValue(element, value);
    return element;
  }


  #region StringValue conversion.
  /// <summary>
  /// Converts a StringValue to UInt32.
  /// </summary>
  /// <param name="stringValue">The StringValue to convert.</param>
  /// <returns>The UInt32 value, or null if element has no content or conversion fails.</returns>
  public static UInt32? GetValue(StringValue? stringValue)
  {
    if (stringValue?.Value != null)
    {
      if (UInt32.TryParse(stringValue.Value, out var value))
        return value;
    }
    return null;
  }


  /// <summary>
  /// Creates a StringValue from a UInt32 value.
  /// </summary>
  /// <param name="value">The UInt32 value to convert.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  public static StringValue? CreateStringValue(UInt32? value)
  {
    if (value == null) return null;
    return new StringValue { Value = value.ToString() };
  }

  /// <summary>
  /// Sets a UInt32 value on a specific child element of a composite element.
  /// Adds the child element if needed, or removes it if the value is null.
  /// </summary>
  /// <typeparam name="ElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <param name="value">The UInt32 value to set.</param>
  public static void SetValue<ElementType>(OpenXmlCompositeElement openXmlElement, UInt32? value)
    where ElementType : OpenXmlLeafElement, new()
  {
    var valProperty = typeof(ElementType).GetProperty("Val") ?? typeof(ElementType).GetProperty("Value");
    Debug.Assert(valProperty != null);
    var itemElement = openXmlElement.GetFirstChild<ElementType>();
    if (itemElement != null)
    {
      if (value != null)
        valProperty.SetValue(itemElement, value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
    {
      itemElement = new ElementType();
      valProperty.SetValue(itemElement, new StringValue(value.ToString()));
      openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion
}