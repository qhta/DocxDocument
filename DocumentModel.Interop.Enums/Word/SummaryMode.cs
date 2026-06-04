namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the way the summary is displayed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsummarymode?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSummaryMode")]
public enum SummaryMode
{
  /// <summary>
  /// Highlights the key points in the specified document and displays the AutoSummarize toolbar.
  /// </summary>
  [InteropEnumValue("wdSummaryModeHighlight")]
  Highlight = 0,
  /// <summary>
  /// Hides everything except the specified summary and displays the AutoSummarize toolbar.
  /// </summary>
  [InteropEnumValue("wdSummaryModeHideAllButSummary")]
  HideAllButSummary = 1,
  /// <summary>
  /// Inserts a summary at the beginning of the specified document.
  /// </summary>
  [InteropEnumValue("wdSummaryModeInsert")]
  Insert = 2,
  /// <summary>
  /// Creates a new document and inserts the specified summary.
  /// </summary>
  [InteropEnumValue("wdSummaryModeCreateNew")]
  CreateNew = 3
}
