namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticMosaicBubbles Class.
/// </summary>
public partial class ArtisticMosaicBubblesImpl: ModelElementImpl, ArtisticMosaicBubbles
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ArtisticMosaicBubblesImpl(): base() {}
  
  public ArtisticMosaicBubblesImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles openXmlElement): base(openXmlElement)
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
  /// pressure, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Pressure
  {
    get => (System.Int32?)OpenXmlElement?.Pressure?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Pressure = (System.Int32?)value;
    }
  }
  
}
