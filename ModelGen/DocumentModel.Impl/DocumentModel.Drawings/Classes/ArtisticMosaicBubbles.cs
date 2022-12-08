namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticMosaicBubbles Class.
/// </summary>
public class ArtisticMosaicBubblesImpl: ModelElementImpl, ArtisticMosaicBubbles
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles?)_OpenXmlElement;
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
  /// pressure, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Pressure
  {
    get;
    set;
  }
  
}
