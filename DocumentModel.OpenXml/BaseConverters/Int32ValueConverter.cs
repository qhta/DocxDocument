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
  /// Compares a value get from LeafTextElement to Int32 value.
  /// </summary>
  /// <param name="element">LeafTextElement to compare.</param>
  /// <param name="value">Int32 value to compare (can be null)</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the values are equal or both are null, <c>false</c> otherwise</returns>
  public static bool CmpValue(OpenXmlLeafTextElement element, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (GetValue(element) == value) return true;
    diffs?.Add(objName, propName ?? element.GetType().ToString(), element.Text, value);
    return false;
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
  /// Compares a value get from OpenXml HpsMeasureType to Int32 value.
  /// </summary>
  /// <param name="element">LeafTextElement to compare.</param>
  /// <param name="value">Int32 value to compare (can be null)</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the values are equal or both are null, <c>false</c> otherwise</returns>
  public static bool CmpValue(DXW.HpsMeasureType? element, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (GetValue(element) == value) return true;
    diffs?.Add(objName, propName ?? element?.GetType().ToString() ?? "HpsMeasureType", element?.Val, value);
    return false;
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

  /// <summary>
  /// Compares a value get from OpenXml IntegerValue to Int32 value.
  /// </summary>
  /// <param name="element">IntegerValue to compare.</param>
  /// <param name="value">Int32 value to compare (can be null)</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the values are equal or both are null, <c>false</c> otherwise</returns>
  public static bool CmpValue(IntegerValue? element, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (GetValue(element) == value) return true;
    diffs?.Add(objName, propName ?? element?.GetType().ToString(), element?.Value, value);
    return false;
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

  /// <summary>
  /// Compares a value get from OpenXml StringValue to Int32 value.
  /// </summary>
  /// <param name="element">StringValue to compare.</param>
  /// <param name="value">Int32 value to compare (can be null)</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the values are equal or both are null, <c>false</c> otherwise</returns>
  public static bool CmpValue(StringValue? element, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (GetValue(element) == value) return true;
    diffs?.Add(objName, propName ?? element?.GetType().ToString(), element?.Value, value);
    return false;
  }

  public static StringValue? CreateStringValue(Int32? value)
  {
    if (value == null) return null;
    return new StringValue { Value = value.ToString() };
  }
  #endregion

  #region Compare two Int32 values
  /// <summary>
  /// Compares two Int32 values.
  /// </summary>
  /// <param name="origValue">Original value to compare.</param>
  /// <param name="value">Received value to compare (can be null)</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the values are equal or both are null, <c>false</c> otherwise</returns>
  public static bool CmpValue(Int32? origValue, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (origValue == value) return true;
    diffs?.Add(objName, propName, origValue, value);
    return false;
  }
  #endregion

}