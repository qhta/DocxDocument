namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Setup Settings.
/// </summary>
public interface PageSetup // : System.Boolean
{
  /// <summary>
  /// Paper Size
  /// </summary>
  public UInt32? PaperSize { get ; set; }
  
  /// <summary>
  /// Print Scale
  /// </summary>
  public UInt32? Scale { get ; set; }
  
  /// <summary>
  /// First Page Number
  /// </summary>
  public UInt32? FirstPageNumber { get ; set; }
  
  /// <summary>
  /// Fit To Width
  /// </summary>
  public UInt32? FitToWidth { get ; set; }
  
  /// <summary>
  /// Fit To Height
  /// </summary>
  public UInt32? FitToHeight { get ; set; }
  
  /// <summary>
  /// Page Order
  /// </summary>
  public PageOrderKind? PageOrder { get ; set; }
  
  /// <summary>
  /// Orientation
  /// </summary>
  public OrientationKind? Orientation { get ; set; }
  
  /// <summary>
  /// Use Printer Defaults
  /// </summary>
  public Boolean? UsePrinterDefaults { get ; set; }
  
  /// <summary>
  /// Black And White
  /// </summary>
  public Boolean? BlackAndWhite { get ; set; }
  
  /// <summary>
  /// Draft
  /// </summary>
  public Boolean? Draft { get ; set; }
  
  /// <summary>
  /// Print Cell Comments
  /// </summary>
  public CellCommentsKind? CellComments { get ; set; }
  
  /// <summary>
  /// Use First Page Number
  /// </summary>
  public Boolean? UseFirstPageNumber { get ; set; }
  
  /// <summary>
  /// Print Error Handling
  /// </summary>
  public PrintErrorKind? Errors { get ; set; }
  
  /// <summary>
  /// Horizontal DPI
  /// </summary>
  public UInt32? HorizontalDpi { get ; set; }
  
  /// <summary>
  /// Vertical DPI
  /// </summary>
  public UInt32? VerticalDpi { get ; set; }
  
  /// <summary>
  /// Number Of Copies
  /// </summary>
  public UInt32? Copies { get ; set; }
  
  /// <summary>
  /// Id
  /// </summary>
  public String? Id { get ; set; }
  
}
