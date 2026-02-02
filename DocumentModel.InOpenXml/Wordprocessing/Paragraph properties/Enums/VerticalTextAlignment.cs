namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the VerticalTextAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.VerticalTextAlignmentValues))]
public enum VerticalTextAlignment
{
  /// <summary>
  ///   Align Text at Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Top))]
  Top,
  /// <summary>
  ///   Align Text at Center.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Align Text at Baseline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Baseline))]
  Baseline,
  /// <summary>
  ///   Align Text at Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Bottom))]
  Bottom,
  /// <summary>
  ///   Automatically Determine Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Auto))]
  Auto
}