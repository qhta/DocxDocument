namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether margins are visible or hidden when a document is viewed in Full Screen Reading view.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdreadinglayoutmargin?view=office-pia` for Office interop details.
/// </remarks>
public enum WdReadingLayoutMargin
{
  /// <summary>
  /// Specifies whether margins are visible or hidden when a document is viewed in Full Screen Reading view.
  /// </summary>
  AutomaticMargin = 0,
  /// <summary>
  /// Specifies whether margins are visible or hidden when a document is viewed in Full Screen Reading view.
  /// </summary>
  SuppressMargin = 1,
  /// <summary>
  /// Specifies whether margins are visible or hidden when a document is viewed in Full Screen Reading view.
  /// </summary>
  FullMargin = 2
}
