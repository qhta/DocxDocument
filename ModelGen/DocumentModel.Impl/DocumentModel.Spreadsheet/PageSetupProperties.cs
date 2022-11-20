namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Setup Properties.
/// </summary>
public class PageSetupProperties: IPageSetupProperties
{
  /// <summary>
  /// Show Auto Page Breaks
  /// </summary>
  public bool? AutoPageBreaks
  {
    get;
    set;
  }
  
  /// <summary>
  /// Fit To Page
  /// </summary>
  public bool? FitToPage
  {
    get;
    set;
  }
  
}
