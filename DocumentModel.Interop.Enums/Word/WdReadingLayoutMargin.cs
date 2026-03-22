namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether margins are visible or hidden when a document is viewed in Full Screen Reading view.
/// </summary>
public enum WdReadingLayoutMargin
{
  /// <summary>
  /// Specifies whether margins are visible or hidden when a document is viewed in Full Screen Reading view.
  /// </summary>
  wdAutomaticMargin = unchecked((int)0),
  /// <summary>
  /// Specifies whether margins are visible or hidden when a document is viewed in Full Screen Reading view.
  /// </summary>
  wdSuppressMargin = unchecked((int)1),
  /// <summary>
  /// Shows the pages with margins.
  /// </summary>
  wdFullMargin = unchecked((int)2)
}
