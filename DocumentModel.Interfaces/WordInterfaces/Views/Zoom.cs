namespace DocumentModel.Wordprocessing;

/// <summary>
/// Contains magnification options (for example, the zoom percentage) for a window or pane.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.zoom?view=word-pia"/>
public interface Zoom : InteropObject
{
  /// <summary>
  /// Returns or sets the magnification for a window as a percentage.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.zoom.percentage?view=word-pia"/>
  public int Percentage { get; set; }
  /// <summary>
  /// Returns or sets the view magnification of a window so that either the entire page is visible or the entire
  /// width of the page is visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.zoom.pagefit?view=word-pia"/>
  public PageFit PageFit { get; set; }
  /// <summary>
  /// Returns or sets the number of pages to be displayed one above the other on-screen at the same time in print
  /// layout view or print preview.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.zoom.pagerows?view=word-pia"/>
  public int PageRows { get; set; }
  /// <summary>
  /// Returns or sets the number of pages to be displayed side by side on-screen at the same time in print layout
  /// view or print preview.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.zoom.pagecolumns?view=word-pia"/>
  public int PageColumns { get; set; }

}
