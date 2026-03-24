namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the vertical alignment of text in one or more cells of a table.
/// </summary>
public enum WdCellVerticalAlignment
{
  /// <summary>
  /// Text is aligned to the top border of the cell.
  /// </summary>
  Top = unchecked((int)0),
  /// <summary>
  /// Text is aligned to the center of the cell.
  /// </summary>
  Center = unchecked((int)1),
  /// <summary>
  /// Text is aligned to the bottom border of the cell.
  /// </summary>
  Bottom = unchecked((int)3)
}
