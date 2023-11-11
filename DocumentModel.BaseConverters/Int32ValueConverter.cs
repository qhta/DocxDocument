namespace DocumentModel.OpenXml;

/// <summary>
/// Converter of Int32 values
/// </summary>
public static class Int32ValueConverter
{

  #region OpenXmlLeafTextElement conversion.
  /// <summary>
  /// Converts text content of LeafTextElement to Int32.
  /// </summary>
  /// <param name="element">LeafTextElement to convert.</param>
  /// <returns>Int32 value of element content (or <c>null</c> if element has no content or conversion is impossible).</returns>
  public static Int32? GetValue(OpenXmlLeafTextElement? element)
  {
    if (element?.Text != null)
    {
      if (Int32.TryParse(element.Text, out var value))
        return value;
    }
    return null;
  }

  /// <summary>
  /// Creates a specific OpenXmlLeafText element based on Int32 value.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">Can be any OpenXmlLeadTextElement type</typeparam>
  /// <param name="value">value to convert</param>
  /// <returns>Newly created OpenXmlElement (or <c>null</c> if conversion is impossible</returns>
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Int32? value)
    where OpenXmlElementType : OpenXmlLeafTextElement, new()
  {
    if (value == null)
      return null;
    var element = new OpenXmlElementType();
    element.Text = ((Int32)value).ToString();
    return element;
  }
  #endregion

  #region HpsMeasureType conversion.
  /// <summary>
  /// Converts HpsMeasureType to Int32.
  /// </summary>
  /// <param name="hpsValue">HpsMeasureType to Convert</param>
  /// <returns>Int32 value of element content (or <c>null</c> if element has no content or conversion is impossible).</returns>
  public static Int32? GetValue(DXW.HpsMeasureType? hpsValue)
  {
    if (hpsValue?.Val != null)
    {
      if (Int32.TryParse(hpsValue.Val, out var value))
        return value;
    }
    return null;
  }

  /// <summary>
  /// Creates a specific OpenXml HpsMeasureType element based on Int32 value.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">Can be any OpenXmlElement type</typeparam>
  /// <param name="value">value to convert</param>
  /// <returns>Newly created OpenXmlElement (or <c>null</c> if conversion is impossible</returns>
  public static void SetHpsMeasureType<OpenXmlElementType>(OpenXmlCompositeElement openXmlElement, Int32? value)
    where OpenXmlElementType : DXW.HpsMeasureType, new()
  {
    var element = openXmlElement.GetFirstChild<OpenXmlElementType>();
    if (element != null && value != null)
    {
      element.Val = ((Int32)value).ToString();
    }
    else if (element == null && value != null)
    {
      element = new OpenXmlElementType();
      element.Val = ((Int32)value).ToString();
      openXmlElement.AppendChild(element);
    }
    else if (element != null && value == null)
    {
      element.Remove();
    }
  }
  #endregion

  #region IntegerValue conversion.
  /// <summary>
  /// Converts IntegerValue to Int32.
  /// </summary>
  /// <param name="integerValue">IntegerValue to convert</param>
  /// <returns>Int32 value of element content (or <c>null</c> if element has no content or conversion is impossible).</returns>
  public static Int32? GetValue(IntegerValue? integerValue)
  {
    if (integerValue?.Value != null)
    {
      return (Int32)integerValue.Value;
    }
    return null;
  }

  public static IntegerValue? CreateIntegerValue(Int32? value)
  {
    if (value == null) return null;
    return new IntegerValue { Value = (Int32)value };
  }
  #endregion

  #region StringValue conversion.
  /// <summary>
  /// Converts StringValue to Int32.
  /// </summary>
  /// <param name="stringValue">StringValue to Convert</param>
  /// <returns>Int32 value of element content (or <c>null</c> if element has no content or conversion is impossible).</returns>
  public static Int32? GetValue(StringValue? stringValue)
  {
    if (stringValue?.Value != null)
    {
      if (Int32.TryParse(stringValue.Value, out var value))
        return value;
    }
    return null;
  }

  public static StringValue? CreateStringValue(Int32? value)
  {
    if (value == null) return null;
    return new StringValue { Value = value.ToString() };
  }

  public static void SetValue<ElementType>(OpenXmlCompositeElement openXmlElement, Int32? value)
    where ElementType : TypedOpenXmlLeafElement, new()
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