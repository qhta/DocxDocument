namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the way the summary is displayed.
/// </summary>
public enum WdSummaryMode
{
  /// <summary>
  /// Highlights the key points in the specified document and displays the AutoSummarize toolbar.
  /// wdSummaryModeHideAllButSummary1 Hides everything except the specified summary and displays the AutoSummarize
  /// toolbar.
  /// </summary>
  wdSummaryModeHighlight = unchecked((int)0),
  /// <summary>
  /// Specifies the way the summary is displayed.
  /// </summary>
  wdSummaryModeHideAllButSummary = unchecked((int)1),
  /// <summary>
  /// Inserts a summary at the beginning of the specified document.
  /// </summary>
  wdSummaryModeInsert = unchecked((int)2),
  /// <summary>
  /// Creates a new document and inserts the specified summary.
  /// </summary>
  wdSummaryModeCreateNew = unchecked((int)3)
}
