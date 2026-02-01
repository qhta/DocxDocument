namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the HorizontalAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXM.HorizontalAlignmentValues))]
public enum HorizontalAlignmentKind
{
  /// <summary>
  ///   Left Aligned Horizontally.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.HorizontalAlignmentValues.Left))]
  Left,
  /// <summary>
  ///   Centered Horizontally.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.HorizontalAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Right Aligned Horizontally.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.HorizontalAlignmentValues.Right))]
  Right,
  /// <summary>
  ///   Inside.
  /// </summary>
  Inside,
  /// <summary>
  ///   Outside.
  /// </summary>
  Outside
}