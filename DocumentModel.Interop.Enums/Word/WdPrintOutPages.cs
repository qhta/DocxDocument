namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of pages to print.
/// </summary>
public enum WdPrintOutPages
{
  /// <summary>
  /// All pages.
  /// </summary>
  wdPrintAllPages = unchecked((int)0),
  /// <summary>
  /// Odd-numbered pages only.
  /// </summary>
  wdPrintOddPagesOnly = unchecked((int)1),
  /// <summary>
  /// Even-numbered pages only.
  /// </summary>
  wdPrintEvenPagesOnly = unchecked((int)2)
}
