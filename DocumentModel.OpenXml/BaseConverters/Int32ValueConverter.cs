using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml;

/// <summary>
/// Converter of Int32 values
/// </summary>
public static class Int32ValueConverter
{

  #region OpenXmlLeafTextElement

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
  /// Compares a value get from text content of LeafTextElement to Int32 value.
  /// </summary>
  /// <param name="element">LeafTextElement to compare.</param>
  /// <param name="value">Int32 value to compare (can be null)</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the values are equal or both are null, <c>false</c> otherwise</returns>
  public static bool CmpValue(OpenXmlLeafTextElement element, Int32? value, DiffList? diffs = null, string? objName = null)
  {
    if (GetValue(element) == value) return true;
    diffs?.Add(objName, element.GetType().ToString(), element.Text, value);
    return false;
  }

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

  /// <summary>
  /// Creates a specific OpenXml element based on Int32 value.
  /// If a specified OpenXmlElement type contains a "Val" property, then it is filled with input value.
  /// Otherwise a string representation of input value is inserted to LeafTextElement content of the result.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">Can be any OpenXmlElement type</typeparam>
  /// <param name="value">value to convert</param>
  /// <returns>Newly created OpenXmlElement (or <c>null</c> if conversion is impossible</returns>
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Int32? value)
    where OpenXmlElementType : OpenXmlElement, new()
  {
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Normal");
    if (valProperty != null)
      valProperty.SetValue(element, value);
    else if (element is OpenXmlLeafTextElement textElement)
      if (value!=null)
        textElement.Text = ((Int32)value).ToString();
    return element;
  }
  #endregion
}