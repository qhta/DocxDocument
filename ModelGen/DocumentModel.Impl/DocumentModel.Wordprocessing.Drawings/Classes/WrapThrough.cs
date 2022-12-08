namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Through Wrapping.
/// </summary>
public class WrapThroughImpl: ModelElementImpl, WrapThrough
{
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  /// Distance From Text on Left Edge
  /// </summary>
  public UInt32? DistanceFromLeft
  {
    get;
    set;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public UInt32? DistanceFromRight
  {
    get;
    set;
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
