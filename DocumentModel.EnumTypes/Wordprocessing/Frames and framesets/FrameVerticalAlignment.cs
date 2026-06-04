namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the VerticalAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues))]
public enum FrameVerticalAlignment
{
  /// <summary>
  ///   In line With Text.
  /// </summary>
  Inline,
  /// <summary>
  ///   Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.VerticalAlignmentValues.Top))]
  Top,
  /// <summary>
  ///   Centered Vertically.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.VerticalAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.VerticalAlignmentValues.Bottom))]
  Bottom,
  /// <summary>
  ///   Inside Anchor Extents.
  /// </summary>
  Inside,
  /// <summary>
  ///   Outside Anchor Extents.
  /// </summary>
  Outside
}