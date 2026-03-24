namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where revisions are displayed when change tracking is enabled.
/// </summary>
public enum WdRevisedLinesMark
{
  /// <summary>
  /// Not displayed.
  /// </summary>
  None = unchecked((int)0),
  /// <summary>
  /// In the left border.
  /// </summary>
  LeftBorder = unchecked((int)1),
  /// <summary>
  /// In the right border.
  /// </summary>
  RightBorder = unchecked((int)2),
  /// <summary>
  /// Outside the border.
  /// </summary>
  OutsideBorder = unchecked((int)3)
}
