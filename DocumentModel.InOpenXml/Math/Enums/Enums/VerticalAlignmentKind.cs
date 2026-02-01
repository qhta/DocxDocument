namespace DocumentModel.Math;
/// <summary>
///   Defines the VerticalAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXM.VerticalAlignmentValues))]
public enum VerticalAlignmentKind
{
  /// <summary>
  ///   Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.VerticalAlignmentValues.Top))]
  Top,
  /// <summary>
  ///   Center (Function).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.VerticalAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.VerticalAlignmentValues.Bottom))]
  Bottom,
  /// <summary>
  ///   Bottom Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.VerticalAlignmentValues.Bot))]
  Bot
}