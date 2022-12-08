namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Tight Wrapping.
/// </summary>
public class WrapTightImpl: ModelElementImpl, WrapTight
{
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight?)_OpenXmlElement;
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
  /// Distance From Test on Left Edge
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
  /// Tight Wrapping Extents Polygon.
  /// </summary>
  public WrapPolygon? WrapPolygon
  {
    get;
    set;
  }
  
}
