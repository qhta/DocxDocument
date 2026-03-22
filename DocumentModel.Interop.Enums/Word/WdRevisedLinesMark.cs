namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where revisions are displayed when change tracking is enabled.
/// </summary>
public enum WdRevisedLinesMark
{
  /// <summary>
  /// Not displayed.
  /// </summary>
  wdRevisedLinesMarkNone = unchecked((int)0),
  /// <summary>
  /// In the left border.
  /// </summary>
  wdRevisedLinesMarkLeftBorder = unchecked((int)1),
  /// <summary>
  /// In the right border.
  /// </summary>
  wdRevisedLinesMarkRightBorder = unchecked((int)2),
  /// <summary>
  /// Outside the border.
  /// </summary>
  wdRevisedLinesMarkOutsideBorder = unchecked((int)3)
}
