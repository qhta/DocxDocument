namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Page Setup.
/// </summary>
public interface IPageSetup // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Page Size
  /// </summary>
  public System.UInt32? PaperSize { get ; set; }
  
  /// <summary>
  /// First Page Number
  /// </summary>
  public System.Int32? FirstPageNumber { get ; set; }
  
  /// <summary>
  /// Orientation
  /// </summary>
  public DocumentModel.Drawing.Charts.PageSetupOrientationKind? Orientation { get ; set; }
  
  /// <summary>
  /// Black and White
  /// </summary>
  public System.Boolean? BlackAndWhite { get ; set; }
  
  /// <summary>
  /// Draft
  /// </summary>
  public System.Boolean? Draft { get ; set; }
  
  /// <summary>
  /// Use First Page Number
  /// </summary>
  public System.Boolean? UseFirstPageNumber { get ; set; }
  
  /// <summary>
  /// Horizontal DPI
  /// </summary>
  public System.Int32? HorizontalDpi { get ; set; }
  
  /// <summary>
  /// Vertical DPI
  /// </summary>
  public System.Int32? VerticalDpi { get ; set; }
  
  /// <summary>
  /// Copies
  /// </summary>
  public System.UInt32? Copies { get ; set; }
  
}
