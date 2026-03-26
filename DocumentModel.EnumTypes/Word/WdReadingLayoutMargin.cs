namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether margins are visible or hidden when a document is viewed in Full Screen Reading view.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdreadinglayoutmargin?view=office-pia` for Office interop details.
/// </remarks>
public enum ReadingLayoutMargin
{
  /// <summary>
  /// Shows the pages without margins.
  /// </summary>
  AutomaticMargin = 0,
  /// <summary>
  /// Microsoft Office Word determines automatically whether to show or hide the margins based on the available
  /// space.
  /// </summary>
  SuppressMargin = 1,
  /// <summary>
  /// Shows the pages with margins.
  /// </summary>
  FullMargin = 2
}
