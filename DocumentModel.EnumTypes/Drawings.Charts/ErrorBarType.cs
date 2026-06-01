namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ErrorBar enumeration.
/// Used Iin types such as ChartStyle, ErrorBar, IErrorBars.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.ErrorBarValues))]
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

