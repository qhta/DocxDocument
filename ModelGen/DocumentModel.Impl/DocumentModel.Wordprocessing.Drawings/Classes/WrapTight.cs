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
  
  public WrapTightImpl(): base() {}
  
  public WrapTightImpl(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.WrapTextKind? WrapText
  {
    get => (DocumentModel.Wordprocessing.Drawings.WrapTextKind?)OpenXmlElement?.WrapText?.Value;
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
    get => (System.UInt32?)OpenXmlElement?.DistanceFromLeft?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DistanceFromLeft = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public UInt32? DistanceFromRight
  {
    get => (System.UInt32?)OpenXmlElement?.DistanceFromRight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DistanceFromRight = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Tight Wrapping Extents Polygon.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.WrapPolygon? WrapPolygon
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
