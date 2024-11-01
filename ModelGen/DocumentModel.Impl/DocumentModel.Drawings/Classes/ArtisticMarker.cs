namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticMarker Class.
/// </summary>
public partial class ArtisticMarkerImpl: ModelElementImpl, ArtisticMarker
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ArtisticMarkerImpl(): base() {}
  
  public ArtisticMarkerImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy
  {
    get => (System.Int32?)OpenXmlElement?.Transparancy?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Transparancy = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// size, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Size
  {
    get => (System.Int32?)OpenXmlElement?.Size?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Size = (System.Int32?)value;
    }
  }
  
}
