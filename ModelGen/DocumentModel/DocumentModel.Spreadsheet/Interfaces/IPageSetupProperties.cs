namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Setup Properties.
/// </summary>
public interface IPageSetupProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Show Auto Page Breaks
  /// </summary>
  public System.Boolean? AutoPageBreaks { get ; set; }
  
  /// <summary>
  /// Fit To Page
  /// </summary>
  public System.Boolean? FitToPage { get ; set; }
  
}
