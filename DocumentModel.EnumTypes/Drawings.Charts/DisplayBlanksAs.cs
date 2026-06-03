namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DisplayBlanksAs enumeration.
/// Used in types such as IChart, ChartConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.DisplayBlanksAsValues))]
public enum DisplayBlanksAs
{
  /// <summary>
  ///   Span.
  /// </summary>
  [OpenXmlEnumValue("Span")]
  Span,
  /// <summary>
  ///   Gap.
  /// </summary>
  [OpenXmlEnumValue("Gap")]
  Gap,
  /// <summary>
  ///   Zero.
  /// </summary>
  [OpenXmlEnumValue("Zero")]
  Zero
}

