namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticMosaicBubbles Class.
/// </summary>
public partial class ArtisticMosaicBubbles: ModelElement<DXO10D.ArtisticMosaicBubbles>
{
  public ArtisticMosaicBubbles(): base(){ }
  
  public ArtisticMosaicBubbles(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticMosaicBubbles(DXO10D.ArtisticMosaicBubbles openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Transparancy
  {
    get => _Element?.Transparancy?.Value;
    set => _ExistingElement.Transparancy = value;
  }
  
  
  /// <summary>
  ///   pressure, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Pressure
  {
    get => _Element?.Pressure?.Value;
    set => _ExistingElement.Pressure = value;
  }
  
}
