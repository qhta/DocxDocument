namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Page Setup.
/// </summary>
public interface IPageSetup // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Page Size
  /// </summary>
  public uint? PaperSize { get ; set; }
  
  /// <summary>
  /// First Page Number
  /// </summary>
  public int? FirstPageNumber { get ; set; }
  
  /// <summary>
  /// Orientation
  /// </summary>
  public PageSetupOrientationValues? Orientation { get ; set; }
  
  /// <summary>
  /// Black and White
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
  public int? HorizontalDpi { get ; set; }
  
  /// <summary>
  /// Vertical DPI
  /// </summary>
  public int? VerticalDpi { get ; set; }
  
  /// <summary>
  /// Copies
  /// </summary>
  public uint? Copies { get ; set; }
  
}
