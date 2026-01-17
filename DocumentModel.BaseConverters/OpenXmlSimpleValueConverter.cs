namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for simple value types in Open XML elements.
/// </summary>
public static class OpenXmlSimpleValueConverter
{
  /// <summary>
  /// Converts a model object to an Open XML simple type.
  /// </summary>
  /// <param name="value">The model object to convert.</param>
  /// <param name="conversionType">The target Open XML simple type.</param>
  /// <returns>The converted Open XML simple type.</returns>
  public static object ConvertToOpenXml(object value, Type conversionType)
  {
    if (conversionType == typeof(DX.StringValue))
    {
      string text;
      if (value is bool boolValue)
        text = boolValue ? "true" : "false";
      else if (value is Guid guidValue)
        text = guidValue.ToString("B").ToUpperInvariant();
      else
        text = (string?)Convert.ChangeType(value, typeof(string)) ?? string.Empty;
      return new DX.StringValue(text);
    }

    if (conversionType == typeof(DX.Int32Value))
      return new DX.Int32Value(Convert.ToInt32(value));


    throw new InvalidOperationException($"Cannot convert to Open XML simple type: {conversionType.FullName}");
  }
  /// <summary>
  /// Converts an Open XML simple type to a model object.
  /// </summary>
  /// <param name="value">The Open XML simple type to convert.</param>
  /// <param name="conversionType">The target model type.</param>
  /// <returns>The converted model object.</returns>
  public static object? ConvertFromOpenXml(DX.OpenXmlSimpleType value, Type conversionType)
  {
    if (value is DX.StringValue stringValue)
      return stringValue.Value;

    if (value is DX.Int32Value int32Value)
      return int32Value.Value;


    throw new InvalidOperationException($"Cannot convert to Open XML simple type: {conversionType.FullName}");
  }
}