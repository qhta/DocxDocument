namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageSize Class.
/// </summary>
public class PageSizeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.PageSize>, PageSize
{
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
  
}
