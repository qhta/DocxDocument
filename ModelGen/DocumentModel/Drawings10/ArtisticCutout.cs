namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticCutout Class.
/// </summary>
public partial class ArtisticCutout: ModelElement<DXO10D.ArtisticCutout>
{
  public ArtisticCutout(): base(){ }
  
  public ArtisticCutout(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticCutout(DXO10D.ArtisticCutout openXmlElement): base(openXmlElement) { }
  
  
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
  ///   numberOfShades, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? NumberOfShades
  {
    get => _Element?.NumberOfShades?.Value;
    set => _ExistingElement.NumberOfShades = value;
  }
  
}
