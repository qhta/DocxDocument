namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
/// Tight Wrapping.
/// </summary>
public partial class WrapTightImpl: ModelElementImpl, WrapTight
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public WrapTightImpl(): base() {}
  
  public WrapTightImpl(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.WrapTextKind? WrapText
  {
    get => (DocumentModel.Drawings.Wordprocessing.WrapTextKind?)OpenXmlElement?.WrapText?.Value;
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
  public DocumentModel.Drawings.Wordprocessing.WrapPolygon? WrapPolygon
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.WrapPolygonImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.WrapPolygonImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
