namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Chart Sheet View.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IChartSheetPageSetup))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IHeaderFooter))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPageMargins))]
public interface ICustomChartsheetView // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// GUID
  /// </summary>
  public string? Guid { get ; set; }
  
  /// <summary>
  /// Print Scale
  /// </summary>
  public uint? Scale { get ; set; }
  
  /// <summary>
  /// Visible State
  /// </summary>
  public SheetStateValues? State { get ; set; }
  
  /// <summary>
  /// Zoom To Fit
  /// </summary>
  public bool? ZoomToFit { get ; set; }
  
  /// <summary>
  /// PageMargins.
  /// </summary>
  public DocumentModel.Spreadsheet.IPageMargins? PageMargins { get ; set; }
  
  /// <summary>
  /// Chart Sheet Page Setup.
  /// </summary>
  public IChartSheetPageSetup? ChartSheetPageSetup { get ; set; }
  
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public DocumentModel.Spreadsheet.IHeaderFooter? HeaderFooter { get ; set; }
  
}
