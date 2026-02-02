namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the VerticalAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXM.VerticalAlignmentValues))]
public enum VerticalAlignment
{
  /// <summary>
  ///   In line With Text.
  /// </summary>
  Inline,
  /// <summary>
  ///   Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.VerticalAlignmentValues.Top))]
  Top,
  /// <summary>
  ///   Centered Vertically.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.VerticalAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.VerticalAlignmentValues.Bottom))]
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