namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a range to print.
/// </summary>
public enum WdPrintOutRange
{
  /// <summary>
  /// The entire document.
  /// </summary>
  wdPrintAllDocument = unchecked((int)0),
  /// <summary>
  /// The current selection.
  /// </summary>
  wdPrintSelection = unchecked((int)1),
  /// <summary>
  /// The current page.
  /// </summary>
  wdPrintCurrentPage = unchecked((int)2),
  /// <summary>
  /// A specified range.
  /// </summary>
  wdPrintFromTo = unchecked((int)3),
  /// <summary>
  /// A specified range of pages.
  /// </summary>
  wdPrintRangeOfPages = unchecked((int)4)
}
