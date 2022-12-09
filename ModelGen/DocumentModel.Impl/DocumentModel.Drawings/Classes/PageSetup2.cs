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
    get => (UInt32?)OpenXmlElement?.PaperSize?.Value;
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
    get => (Int32?)OpenXmlElement?.FirstPageNumber?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FirstPageNumber = (System.Int32?)value;
    }
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
    get => (Boolean?)OpenXmlElement?.BlackAndWhite?.Value;
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
    get => (Boolean?)OpenXmlElement?.Draft?.Value;
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
    get => (Boolean?)OpenXmlElement?.UseFirstPageNumber?.Value;
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
    get => (Int32?)OpenXmlElement?.HorizontalDpi?.Value;
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
    get => (Int32?)OpenXmlElement?.VerticalDpi?.Value;
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
    get => (UInt32?)OpenXmlElement?.Copies?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Copies = (System.UInt32?)value;
    }
  }
  
}
