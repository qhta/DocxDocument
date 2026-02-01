namespace DocumentModel.Vml;
/// <summary>
///   Alignment Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVO.HorizontalRuleAlignmentValues))]
public enum HorizontalRuleAlignmentKind
{
  /// <summary>
  ///   Left Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.HorizontalRuleAlignmentValues.Left))]
  Left,
  /// <summary>
  ///   Right Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.HorizontalRuleAlignmentValues.Right))]
  Right,
  /// <summary>
  ///   Center Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.HorizontalRuleAlignmentValues.Center))]
  Center
}