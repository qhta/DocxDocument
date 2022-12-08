namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageSize Class.
/// </summary>
public class PageSizeImpl: ModelElementImpl, PageSize
{
  public DocumentFormat.OpenXml.Wordprocessing.PageSize? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PageSize?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Page Width
  /// </summary>
  public UInt32? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// Page Height
  /// </summary>
  public UInt32? Height
  {
    get;
    set;
  }
  
  /// <summary>
  /// Page Orientation
  /// </summary>
  public PageOrientationKind? Orient
  {
    get => (PageOrientationKind?)OpenXmlElement?.Orient?.Value;
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
    get;
    set;
  }
  
}
