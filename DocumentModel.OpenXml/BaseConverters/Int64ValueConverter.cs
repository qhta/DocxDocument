using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml;

/// <summary>
/// Converter of Int64 values
/// </summary>
public static class Int64ValueConverter
{

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts text content of LeafTextElement to Int64.
  /// </summary>
  /// <param name="element">LeafTextElement to convert.</param>
  /// <returns>Int64 value of element content (or <c>null</c> if element has no content or conversion is impossible).</returns>
  public static Int64? GetValue(OpenXmlLeafTextElement? element)
  {
    if (element?.Text != null)
    {
      if (Int64.TryParse(element.Text, out var value))
        return value;
    }
    return null;
  }

  /// <summary>
  /// Compares a value get from LeafTextElement to Int64 value.
  /// </summary>
  /// <param name="element">LeafTextElement to compare.</param>
  /// <param name="value">Int64 value to compare (can be null)</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the values are equal or both are null, <c>false</c> otherwise</returns>
  public static bool CmpValue(OpenXmlLeafTextElement element, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (GetValue(element) == value) return true;
    diffs?.Add(objName, propName ?? element.GetType().ToString(), element.Text, value);
    return false;
  }

  /// <summary>
  /// Creates a specific OpenXmlLeafText element based on Int64 value.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">Can be any OpenXmlLeadTextElement type</typeparam>
  /// <param name="value">value to convert</param>
  /// <returns>Newly created OpenXmlElement (or <c>null</c> if conversion is impossible</returns>
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Int64? value)
    where OpenXmlElementType : OpenXmlLeafTextElement, new()
  {
    var element = new OpenXmlElementType();
    if (value != null)
      element.Text = ((Int64)value).ToString();
    return element;
  }
  #endregion

  #region StringValue conversion.
  /// <summary>
  /// Converts StringValue to Int64.
  /// </summary>
  /// <param name="stringValue">StringValue to Convert</param>
  /// <returns>Int64 value of element content (or <c>null</c> if element has no content or conversion is impossible).</returns>
  public static Int64? GetValue(StringValue? stringValue)
  {
    if (stringValue?.Value != null)
    {
      if (Int64.TryParse(stringValue.Value, out var value))
        return value;
    }
    return null;
  }

  /// <summary>
  /// Compares a value get from OpenXml StringValue to Int64 value.
  /// </summary>
  /// <param name="element">StringValue to compare.</param>
  /// <param name="value">Int64 value to compare (can be null)</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the values are equal or both are null, <c>false</c> otherwise</returns>
  public static bool CmpValue(StringValue? element, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (GetValue(element) == value) return true;
    diffs?.Add(objName, propName ?? element?.GetType().ToString(), element?.Value, value);
    return false;
  }

    /// <summary>
  /// Sets a specific OpenXml StringValue element based on Int64 value.
  /// </summary>
  /// <param name="value">value to convert</param>
  public static void SetStringValue(DX.StringValue openXmlElement, Int64? value)
  {
    if (value!=null)
      openXmlElement.Value = value.ToString();
    else
      openXmlElement.Value = null;
  }

      /// <summary>
  /// Creates a specific OpenXml StringValue element based on Int64 value.
  /// </summary>
  /// <param name="value">value to convert</param>
  public static StringValue? CreateStringValue(Int64? value)
  {
    if (value!=null)
      return new StringValue(value.ToString());
    else
      return null;
  }
  #endregion

  #region Compare two Int64 values
  /// <summary>
  /// Compares two Int64 values.
  /// </summary>
  /// <param name="origValue">Original value to compare.</param>
  /// <param name="value">Received value to compare (can be null)</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the values are equal or both are null, <c>false</c> otherwise</returns>
  public static bool CmpValue(Int64? origValue, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (origValue == value) return true;
    diffs?.Add(objName, propName, origValue, value);
    return false;
  }
  #endregion

  //#region Common OpenXml element creation
  ///// <summary>
  ///// Creates a specific OpenXml element based on Int64 value.
  ///// If a specified OpenXmlElement type contains a "Val" property, then it is filled with input value.
  ///// Otherwise a string representation of input value is inserted to LeafTextElement content of the result.
  ///// </summary>
  ///// <typeparam name="OpenXmlElementType">Can be any OpenXmlElement type</typeparam>
  ///// <param name="value">value to convert</param>
  ///// <returns>Newly created OpenXmlElement (or <c>null</c> if conversion is impossible</returns>
  //public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Int64? value)
  //  where OpenXmlElementType : OpenXmlElement, new()
  //{
  //  if (typeof(OpenXmlElementType).IsEqualOrSubclassOf(typeof(OpenXmlLeafTextElement)))
  //  {
  //    var method = typeof(Int64ValueConverter).GetMethod(
  //    return CreateOpenXmlLeafTextElement<OpenXmlElementType>(value));
  //  }
  //  return null;
  //}
  //#endregion
}