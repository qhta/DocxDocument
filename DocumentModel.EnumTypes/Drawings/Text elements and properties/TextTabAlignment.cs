namespace DocumentModel.Drawings;
/// <summary>
///   Text Tab Alignment Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.TextTabAlignmentValues))]
public enum TextTabAlignment
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  Mixed = -2,
  /// <summary>
  ///   Text Tab Alignment Enum ( Left).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextTabAlignmentValues.Left))]
  Left = 1,

  /// <summary>
  ///   Text Tab Alignment Enum ( Center ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextTabAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Text Tab Alignment Enum ( Right ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextTabAlignmentValues.Right))]
  Right,
  /// <summary>
  ///   Text Tab Alignment Enum ( Decimal ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextTabAlignmentValues.Decimal))]
  Decimal
}