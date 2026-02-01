namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies horizontal alignment options for numbering levels in WordprocessingML documents.
/// This enumeration provides values for left, center, and right alignment, supporting advanced formatting and layout control for numbered lists and outline levels within document content.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.LevelJustificationValues))]
public enum LevelJustificationKind
{
  /// <summary>
  /// Align left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.LevelJustificationValues.Left))]
  Left,
  /// <summary>
  /// Align center.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.LevelJustificationValues.Center))]
  Center,
  /// <summary>
  /// Align right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.LevelJustificationValues.Right))]
  Right
}