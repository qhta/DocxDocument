namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the style type to apply.
/// </summary>
public enum WdStyleType
{
  /// <summary>
  /// Paragraph style.
  /// </summary>
  Paragraph = unchecked((int)1),
  /// <summary>
  /// Body character style.
  /// </summary>
  Character = unchecked((int)2),
  /// <summary>
  /// Table style.
  /// </summary>
  Table = unchecked((int)3),
  /// <summary>
  /// List style.
  /// </summary>
  List = unchecked((int)4),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  ParagraphOnly = unchecked((int)5),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  Linked = unchecked((int)6)
}
