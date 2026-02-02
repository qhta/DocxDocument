namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the AbsolutePositionTabAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.AbsolutePositionTabAlignmentValues))]
public enum AbsolutePositionTabAlignment
{
  /// <summary>
  ///   Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.AbsolutePositionTabAlignmentValues.Left))]
  Left,
  /// <summary>
  ///   Center.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.AbsolutePositionTabAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.AbsolutePositionTabAlignmentValues.Right))]
  Right
}