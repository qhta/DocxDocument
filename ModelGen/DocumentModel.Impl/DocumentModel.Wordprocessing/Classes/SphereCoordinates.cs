namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SphereCoordinates Class.
/// </summary>
public class SphereCoordinatesImpl: ModelElementImpl, SphereCoordinates
{
  public DocumentFormat.OpenXml.Office2010.Word.SphereCoordinates? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.SphereCoordinates?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// lat, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Lattitude
  {
    get;
    set;
  }
  
  /// <summary>
  /// lon, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Longitude
  {
    get;
    set;
  }
  
  /// <summary>
  /// rev, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Revolution
  {
    get;
    set;
  }
  
}
