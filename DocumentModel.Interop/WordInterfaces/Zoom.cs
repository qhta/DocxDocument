namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains magnification options (for example, the zoom percentage) for a window or pane.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.zoom?view=word-pia"/>
public interface Zoom : InteropObject
{
  /// <summary>
  /// The percentage.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.zoom.percentage?view=word-pia"/>
  public int Percentage { get; set; }
  /// <summary>
  /// The page fit.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.zoom.pagefit?view=word-pia"/>
  public WdPageFit PageFit { get; set; }
  /// <summary>
  /// The page rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.zoom.pagerows?view=word-pia"/>
  public int PageRows { get; set; }
  /// <summary>
  /// The page columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.zoom.pagecolumns?view=word-pia"/>
  public int PageColumns { get; set; }

}
