namespace DocumentModel.Spreadsheet;

/// <summary>
/// Chart Sheet Page Setup.
/// </summary>
public interface IChartSheetPageSetup // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Paper Size
  /// </summary>
  public uint? PaperSize { get ; set; }
  
  /// <summary>
  /// First Page Number
  /// </summary>
  public uint? FirstPageNumber { get ; set; }
  
  /// <summary>
  /// Orientation
  /// </summary>
  public DocumentModel.Spreadsheet.Orientation? Orientation { get ; set; }
  
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
  /// Use First Page Number
  /// </summary>
  public bool? UseFirstPageNumber { get ; set; }
  
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
