namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies horizontal alignment options for numbering levels in WordprocessingML documents.
/// This enumeration provides values for left, center, and right alignment, supporting advanced formatting and layout control for numbered lists and outline levels within document content.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LevelJustificationKind
{
  /// <summary>
  /// Align left.
  /// </summary>
  Left,

  /// <summary>
  /// Align center.
  /// </summary>
  Center,

  /// <summary>
  /// Align right.
  /// </summary>
  Right
}