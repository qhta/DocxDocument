namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public interface IPrintSettings // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IHeaderFooter? HeaderFooter { get ; set; }
  
  /// <summary>
  /// PageMargins.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IPageMargins? PageMargins { get ; set; }
  
  /// <summary>
  /// PageSetup.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IPageSetup? PageSetup { get ; set; }
  
}
