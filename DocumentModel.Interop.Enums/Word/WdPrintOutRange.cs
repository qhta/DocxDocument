namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a range to print.
/// </summary>
public enum WdPrintOutRange
{
  /// <summary>
  /// The entire document.
  /// </summary>
  AllDocument = unchecked((int)0),
  /// <summary>
  /// The current selection.
  /// </summary>
  Selection = unchecked((int)1),
  /// <summary>
  /// The current page.
  /// </summary>
  CurrentPage = unchecked((int)2),
  /// <summary>
  /// A specified range.
  /// </summary>
  FromTo = unchecked((int)3),
  /// <summary>
  /// A specified range of pages.
  /// </summary>
  RangeOfPages = unchecked((int)4)
}
