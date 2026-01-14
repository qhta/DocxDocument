
namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for Int64 values in Open XML.
/// </summary>
public static class Int64ValueConverter
{

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts the text content of an OpenXmlLeafTextElement to an Int64 value.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement to convert.</param>
  /// <returns>The Int64 value of the element content, or null if conversion fails.</returns>
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
  /// Creates a specific OpenXmlLeafTextElement based on an Int64 value.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXmlLeafTextElement to create.</typeparam>
  /// <param name="value">The Int64 value to set.</param>
  /// <returns>A new instance of the element with the text set to the Int64 value, or null if value is null.</returns>
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
  /// Converts a StringValue to an Int64 value.
  /// </summary>
  /// <param name="stringValue">The StringValue object to convert.</param>
  /// <returns>The Int64 value, or null if the value is null or conversion fails.</returns>
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
  /// Sets the value of a StringValue element based on an Int64 value.
  /// </summary>
  /// <param name="openXmlElement">The StringValue element to update.</param>
  /// <param name="value">The Int64 value to set.</param>
  public static void SetStringValue(DX.StringValue openXmlElement, Int64? value)
  {
    if (value!=null)
      openXmlElement.Value = value.ToString();
    else
      openXmlElement.Value = null;
  }

      /// <summary>
  /// Creates a new StringValue element based on an Int64 value.
  /// </summary>
  /// <param name="value">The Int64 value.</param>
  /// <returns>A new StringValue element, or null if the input value is null.</returns>
  public static StringValue? CreateStringValue(Int64? value)
  {
    if (value!=null)
      return new StringValue(value.ToString());
    else
      return null;
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