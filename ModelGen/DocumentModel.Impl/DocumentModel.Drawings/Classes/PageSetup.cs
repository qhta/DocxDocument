namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PageSetup Class.
/// </summary>
public class PageSetupImpl: ModelElementImpl, PageSetup
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PageSetupImpl(): base() {}
  
  public PageSetupImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// paperSize, this property is only available in Office 2016 and later.
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
  /// firstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? FirstPageNumber
  {
    get => (UInt32?)OpenXmlElement?.FirstPageNumber?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FirstPageNumber = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// orientation, this property is only available in Office 2016 and later.
  /// </summary>
  public PageOrientation? Orientation
  {
    get => (PageOrientation?)OpenXmlElement?.Orientation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Orientation = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation?)value;
    }
  }
  
  /// <summary>
  /// blackAndWhite, this property is only available in Office 2016 and later.
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
  /// draft, this property is only available in Office 2016 and later.
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
  /// useFirstPageNumber, this property is only available in Office 2016 and later.
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
  /// horizontalDpi, this property is only available in Office 2016 and later.
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
  /// verticalDpi, this property is only available in Office 2016 and later.
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
  /// copies, this property is only available in Office 2016 and later.
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
