namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains magnification options (for example, the zoom percentage) for a window or pane.
/// </summary>
public interface Zoom : InteropObject
{
  /// <summary>
  /// The percentage.
  /// </summary>
  public int Percentage { get; set; }
  /// <summary>
  /// The page fit.
  /// </summary>
  public WdPageFit PageFit { get; set; }
  /// <summary>
  /// The page rows.
  /// </summary>
  public int PageRows { get; set; }
  /// <summary>
  /// The page columns.
  /// </summary>
  public int PageColumns { get; set; }

}
