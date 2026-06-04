namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether margins are visible or hidden when a document is viewed in Full Screen Reading view.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdreadinglayoutmargin?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdReadingLayoutMargin")]
public enum ReadingLayoutMargin
{
  /// <summary>
  /// Shows the pages without margins.
  /// </summary>
  [WordInteropEnumValue("wdAutomaticMargin")]
  AutomaticMargin = 0,
  /// <summary>
  /// Microsoft Office Word determines automatically whether to show or hide the margins based on the available
  /// space.
  /// </summary>
  [WordInteropEnumValue("wdSuppressMargin")]
  SuppressMargin = 1,
  /// <summary>
  /// Shows the pages with margins.
  /// </summary>
  [WordInteropEnumValue("wdFullMargin")]
  FullMargin = 2
}
