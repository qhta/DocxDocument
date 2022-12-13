namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Page Setup.
/// </summary>
public class PageSetupImpl: ModelElementImpl, PageSetup
{
  public DocumentFormat.OpenXml.Drawing.Charts.PageSetup? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PageSetup?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PageSetupImpl(): base() {}
  
  public PageSetupImpl(DocumentFormat.OpenXml.Drawing.Charts.PageSetup openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Page Size
  /// </summary>
  public UInt32? PaperSize
  {
    get => (System.UInt32?)OpenXmlElement?.PaperSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PaperSize = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// First Page Number
  /// </summary>
  public Int32? FirstPageNumber
  {
    get => (System.Int32?)OpenXmlElement?.FirstPageNumber?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FirstPageNumber = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Orientation
  /// </summary>
  public DocumentModel.Drawings.Charts.PageSetupOrientationKind? Orientation
  {
    get => (DocumentModel.Drawings.Charts.PageSetupOrientationKind?)OpenXmlElement?.Orientation?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.BlackAndWhite?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlackAndWhite = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Draft
  /// </summary>
  public Boolean? Draft
  {
    get => (System.Boolean?)OpenXmlElement?.Draft?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Draft = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Use First Page Number
  /// </summary>
  public Boolean? UseFirstPageNumber
  {
    get => (System.Boolean?)OpenXmlElement?.UseFirstPageNumber?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UseFirstPageNumber = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Horizontal DPI
  /// </summary>
  public Int32? HorizontalDpi
  {
    get => (System.Int32?)OpenXmlElement?.HorizontalDpi?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalDpi = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Vertical DPI
  /// </summary>
  public Int32? VerticalDpi
  {
    get => (System.Int32?)OpenXmlElement?.VerticalDpi?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalDpi = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Copies
  /// </summary>
  public UInt32? Copies
  {
    get => (System.UInt32?)OpenXmlElement?.Copies?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Copies = (System.UInt32?)value;
    }
  }
  
}
