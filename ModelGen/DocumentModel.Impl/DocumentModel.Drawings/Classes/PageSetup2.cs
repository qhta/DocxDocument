namespace DocumentModel.Drawings;

/// <summary>
/// Page Setup.
/// </summary>
public class PageSetup2Impl: ModelElementImpl, PageSetup2
{
  public DocumentFormat.OpenXml.Drawing.Charts.PageSetup? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PageSetup?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Page Size
  /// </summary>
  public UInt32? PaperSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// First Page Number
  /// </summary>
  public Int32? FirstPageNumber
  {
    get;
    set;
  }
  
  /// <summary>
  /// Orientation
  /// </summary>
  public PageSetupOrientationKind? Orientation
  {
    get => (PageSetupOrientationKind?)OpenXmlElement?.Orientation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Orientation = (DocumentFormat.OpenXml.Drawing.Charts.PageSetupOrientationValues?)value;
    }
  }
  
  /// <summary>
  /// Black and White
  /// </summary>
  public Boolean? BlackAndWhite
  {
    get;
    set;
  }
  
  /// <summary>
  /// Draft
  /// </summary>
  public Boolean? Draft
  {
    get;
    set;
  }
  
  /// <summary>
  /// Use First Page Number
  /// </summary>
  public Boolean? UseFirstPageNumber
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal DPI
  /// </summary>
  public Int32? HorizontalDpi
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vertical DPI
  /// </summary>
  public Int32? VerticalDpi
  {
    get;
    set;
  }
  
  /// <summary>
  /// Copies
  /// </summary>
  public UInt32? Copies
  {
    get;
    set;
  }
  
}
