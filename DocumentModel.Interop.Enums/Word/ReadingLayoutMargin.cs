namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether margins are visible or hidden when a document is viewed in Full Screen Reading view.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdreadinglayoutmargin?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdReadingLayoutMargin))]
public enum ReadingLayoutMargin
{
  /// <summary>
  /// Shows the pages without margins.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdReadingLayoutMargin.wdAutomaticMargin))]
  AutomaticMargin = 0,
  /// <summary>
  /// Microsoft Office Word determines automatically whether to show or hide the margins based on the available
  /// space.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdReadingLayoutMargin.wdSuppressMargin))]
  SuppressMargin = 1,
  /// <summary>
  /// Shows the pages with margins.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdReadingLayoutMargin.wdFullMargin))]
  FullMargin = 2
}
