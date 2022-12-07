namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PageSetup Class.
/// </summary>
public class PageSetup2Impl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup>, PageSetup2
{
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
  
}
