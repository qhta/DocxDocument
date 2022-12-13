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
  
  public WrapThroughImpl(): base() {}
  
  public WrapThroughImpl(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough openXmlElement): base(openXmlElement)
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
  /// Distance From Text on Left Edge
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
  /// Wrapping Polygon.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.WrapPolygon? WrapPolygon
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
