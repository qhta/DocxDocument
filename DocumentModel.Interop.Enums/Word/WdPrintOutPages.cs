namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of pages to print.
/// </summary>
public enum WdPrintOutPages
{
  /// <summary>
  /// All pages.
  /// </summary>
  AllPages = unchecked((int)0),
  /// <summary>
  /// Odd-numbered pages only.
  /// </summary>
  OddPagesOnly = unchecked((int)1),
  /// <summary>
  /// Even-numbered pages only.
  /// </summary>
  EvenPagesOnly = unchecked((int)2)
}
