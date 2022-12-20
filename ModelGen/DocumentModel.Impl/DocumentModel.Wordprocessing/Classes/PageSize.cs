namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageSize Class.
/// </summary>
public partial class PageSizeImpl: ModelElementImpl, PageSize
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.PageSize? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PageSize?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public PageSizeImpl(): base() {}
  
  public PageSizeImpl(DocumentFormat.OpenXml.Wordprocessing.PageSize openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Page Width
  /// </summary>
  public UInt32? Width
  {
    get => (System.UInt32?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Page Height
  /// </summary>
  public UInt32? Height
  {
    get => (System.UInt32?)OpenXmlElement?.Height?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Height = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Page Orientation
  /// </summary>
  public DocumentModel.Wordprocessing.PageOrientationKind? Orient
  {
    get => (DocumentModel.Wordprocessing.PageOrientationKind?)OpenXmlElement?.Orient?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Orient = (DocumentFormat.OpenXml.Wordprocessing.PageOrientationValues?)value;
    }
  }
  
  /// <summary>
  /// Printer Paper Code
  /// </summary>
  public UInt16? Code
  {
    get => (System.UInt16?)OpenXmlElement?.Code?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Code = (System.UInt16?)value;
    }
  }
  
}
