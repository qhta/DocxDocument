namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SphereCoordinates Class.
/// </summary>
public partial class SphereCoordinatesImpl: ModelElementImpl, SphereCoordinates
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.SphereCoordinates? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.SphereCoordinates?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public SphereCoordinatesImpl(): base() {}
  
  public SphereCoordinatesImpl(DocumentFormat.OpenXml.Office2010.Word.SphereCoordinates openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// lat, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Lattitude
  {
    get => (System.Int32?)OpenXmlElement?.Lattitude?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Lattitude = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// lon, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Longitude
  {
    get => (System.Int32?)OpenXmlElement?.Longitude?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Longitude = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// rev, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Revolution
  {
    get => (System.Int32?)OpenXmlElement?.Revolution?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Revolution = (System.Int32?)value;
    }
  }
  
}
