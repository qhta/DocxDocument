namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a range to print.
/// </summary>
public enum WdPrintOutRange
{
  /// <summary>
  /// The entire document.
  /// </summary>
  AllDocument = 0,
  /// <summary>
  /// The current selection.
  /// </summary>
  Selection = 1,
  /// <summary>
  /// The current page.
  /// </summary>
  CurrentPage = 2,
  /// <summary>
  /// A specified range.
  /// </summary>
  FromTo = 3,
  /// <summary>
  /// A specified range of pages.
  /// </summary>
  RangeOfPages = 4
}
