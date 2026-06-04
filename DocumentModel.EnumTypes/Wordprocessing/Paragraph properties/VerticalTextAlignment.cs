namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the VerticalTextAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues))]
public enum VerticalTextAlignment
{
  /// <summary>
  ///   Align Text at Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues.Top))]
  Top,
  /// <summary>
  ///   Align Text at Center.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Align Text at Baseline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues.Baseline))]
  Baseline,
  /// <summary>
  ///   Align Text at Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues.Bottom))]
  Bottom,
  /// <summary>
  ///   Automatically Determine Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues.Auto))]
  Auto
}