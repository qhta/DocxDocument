namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ErrorBar enumeration.
/// Used in types such as ChartStyle, ErrorBar, ErrorBars.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.ErrorBarValues))]
public enum ErrorBarType
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
