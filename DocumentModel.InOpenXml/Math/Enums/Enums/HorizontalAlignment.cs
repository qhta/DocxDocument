namespace DocumentModel.Math;
/// <summary>
///   Defines the HorizontalAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXM.HorizontalAlignmentValues))]
public enum HorizontalAlignment
{
  /// <summary>
  ///   Left Justification.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.HorizontalAlignmentValues.Left))]
  Left,
  /// <summary>
  ///   Center.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.HorizontalAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.HorizontalAlignmentValues.Right))]
  Right
}