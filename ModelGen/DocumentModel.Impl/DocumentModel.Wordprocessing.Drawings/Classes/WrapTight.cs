namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Tight Wrapping.
/// </summary>
public class WrapTightImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight>, WrapTight
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public WrapTextKind? WrapText
  {
    get => (WrapTextKind?)OpenXmlElement?.WrapText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.WrapText = (DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues?)value;
    }
  }
  
  /// <summary>
  /// Tight Wrapping Extents Polygon.
  /// </summary>
  public WrapPolygon? WrapPolygon
  {
    get;
    set;
  }
  
}
