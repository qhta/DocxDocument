namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Through Wrapping.
/// </summary>
public class WrapThroughImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough>, WrapThrough
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
  /// Wrapping Polygon.
  /// </summary>
  public WrapPolygon? WrapPolygon
  {
    get;
    set;
  }
  
}
