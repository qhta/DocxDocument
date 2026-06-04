namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ErrorBar enumeration.
/// Used in types such as ChartStyle, ErrorBar, IErrorBars.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues))]
public enum ErrorPlusMinus
{
  /// <summary>
  ///   Both.
  /// </summary>
  [OpenXmlEnumValue("Both")]
  Both,
  /// <summary>
  ///   Minus.
  /// </summary>
  [OpenXmlEnumValue("Minus")]
  Minus,
  /// <summary>
  ///   Plus.
  /// </summary>
  [OpenXmlEnumValue("Plus")]
  Plus
}

