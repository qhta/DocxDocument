namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for byte percent values (used in colors, etc.) in Open XML.
/// </summary>
public static class BytePercentValueConverter
{
  /// <summary>
  /// Retrieves a Percent value from a StringValue element containing a hex percentage string.
  /// </summary>
  /// <param name="element">The StringValue element to convert.</param>
  /// <returns>A Percent object, or null if the element or value is null.</returns>
  public static Percent? GetValue(DX.StringValue? element)
  {
    if (element?.Value != null)
      return Percent.FromHexString(element.Value);
    return null;
  }

  /// <summary>
  /// Creates a StringValue containing the hex string representation of a Percent value.
  /// </summary>
  /// <param name="value">The Percent value to convert.</param>
  /// <returns>A new StringValue, or null if the input value is null.</returns>
  public static DX.StringValue? CreateStringValue(Percent? value)
  {
    if (value is not null) return new DX.StringValue(((Percent)value).ToHexString());
    return null;
  }

  /// <summary>
  /// Creates a generic OpenXml element and sets its "Value" property to the hex string representation of a Percent value.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXml element to create.</typeparam>
  /// <param name="value">The Percent value to set.</param>
  /// <returns>A new instance of the element type with the value set, or null if the input value is null.</returns>
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Percent? value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    if (value is not null)
    {
      var newValue = new DX.StringValue(((Percent)value).ToHexString());
      var element = new OpenXmlElementType();
      var valProperty = typeof(OpenXmlElementType).GetProperty("Value");
      if (valProperty != null)
        valProperty.SetValue(element, newValue);
      return element;
    }
    return null;
  }
}