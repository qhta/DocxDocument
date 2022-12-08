namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticMarker Class.
/// </summary>
public class ArtisticMarkerImpl: ModelElementImpl, ArtisticMarker
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy
  {
    get;
    set;
  }
  
  /// <summary>
  /// size, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Size
  {
    get;
    set;
  }
  
}
