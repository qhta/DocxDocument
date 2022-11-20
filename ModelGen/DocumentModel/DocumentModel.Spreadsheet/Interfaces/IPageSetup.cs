namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Setup Settings.
/// </summary>
public interface IPageSetup // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Paper Size
  /// </summary>
  public uint? PaperSize { get ; set; }
  
  /// <summary>
  /// Print Scale
  /// </summary>
  public uint? Scale { get ; set; }
  
  /// <summary>
  /// First Page Number
  /// </summary>
  public uint? FirstPageNumber { get ; set; }
  
  /// <summary>
  /// Fit To Width
  /// </summary>
  public uint? FitToWidth { get ; set; }
  
  /// <summary>
  /// Fit To Height
  /// </summary>
  public uint? FitToHeight { get ; set; }
  
  /// <summary>
  /// Page Order
  /// </summary>
  public PageOrderValues? PageOrder { get ; set; }
  
  /// <summary>
  /// Orientation
  /// </summary>
  public DocumentModel.Spreadsheet.OrientationValues? Orientation { get ; set; }
  
  /// <summary>
  /// Use Printer Defaults
  /// </summary>
  public bool? UsePrinterDefaults { get ; set; }
  
  /// <summary>
  /// Black And White
  /// </summary>
  public bool? BlackAndWhite { get ; set; }
  
  /// <summary>
  /// Draft
  /// </summary>
  public bool? Draft { get ; set; }
  
  /// <summary>
  /// Print Cell Comments
  /// </summary>
  public CellCommentsValues? CellComments { get ; set; }
  
  /// <summary>
  /// Use First Page Number
  /// </summary>
  public bool? UseFirstPageNumber { get ; set; }
  
  /// <summary>
  /// Print Error Handling
  /// </summary>
  public PrintErrorValues? Errors { get ; set; }
  
  /// <summary>
  /// Horizontal DPI
  /// </summary>
  public uint? HorizontalDpi { get ; set; }
  
  /// <summary>
  /// Vertical DPI
  /// </summary>
  public uint? VerticalDpi { get ; set; }
  
  /// <summary>
  /// Number Of Copies
  /// </summary>
  public uint? Copies { get ; set; }
  
  /// <summary>
  /// Id
  /// </summary>
  public string? Id { get ; set; }
  
}
