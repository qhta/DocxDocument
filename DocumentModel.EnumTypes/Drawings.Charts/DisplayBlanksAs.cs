namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DisplayBlanksAs enumeration.
/// Used in types such as IChart, ChartConverter.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues))]
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

