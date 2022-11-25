namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Setup Settings.
/// </summary>
public interface IPageSetup // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Paper Size
  /// </summary>
  public System.UInt32? PaperSize { get ; set; }
  
  /// <summary>
  /// Print Scale
  /// </summary>
  public System.UInt32? Scale { get ; set; }
  
  /// <summary>
  /// First Page Number
  /// </summary>
  public System.UInt32? FirstPageNumber { get ; set; }
  
  /// <summary>
  /// Fit To Width
  /// </summary>
  public System.UInt32? FitToWidth { get ; set; }
  
  /// <summary>
  /// Fit To Height
  /// </summary>
  public System.UInt32? FitToHeight { get ; set; }
  
  /// <summary>
  /// Page Order
  /// </summary>
  public DocumentModel.Spreadsheet.PageOrderKind? PageOrder { get ; set; }
  
  /// <summary>
  /// Orientation
  /// </summary>
  public DocumentModel.Spreadsheet.OrientationKind? Orientation { get ; set; }
  
  /// <summary>
  /// Use Printer Defaults
  /// </summary>
  public System.Boolean? UsePrinterDefaults { get ; set; }
  
  /// <summary>
  /// Black And White
  /// </summary>
  public System.Boolean? BlackAndWhite { get ; set; }
  
  /// <summary>
  /// Draft
  /// </summary>
  public System.Boolean? Draft { get ; set; }
  
  /// <summary>
  /// Print Cell Comments
  /// </summary>
  public DocumentModel.Spreadsheet.CellCommentsKind? CellComments { get ; set; }
  
  /// <summary>
  /// Use First Page Number
  /// </summary>
  public System.Boolean? UseFirstPageNumber { get ; set; }
  
  /// <summary>
  /// Print Error Handling
  /// </summary>
  public DocumentModel.Spreadsheet.PrintErrorKind? Errors { get ; set; }
  
  /// <summary>
  /// Horizontal DPI
  /// </summary>
  public System.UInt32? HorizontalDpi { get ; set; }
  
  /// <summary>
  /// Vertical DPI
  /// </summary>
  public System.UInt32? VerticalDpi { get ; set; }
  
  /// <summary>
  /// Number Of Copies
  /// </summary>
  public System.UInt32? Copies { get ; set; }
  
  /// <summary>
  /// Id
  /// </summary>
  public System.String? Id { get ; set; }
  
}
