namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticTexturizer Class.
/// </summary>
public partial class ArtisticTexturizer: ModelElement<DXO10D.ArtisticTexturizer>
{
  public ArtisticTexturizer(): base(){ }
  
  public ArtisticTexturizer(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticTexturizer(DXO10D.ArtisticTexturizer openXmlElement): base(openXmlElement) { }
  
  
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
  ///   scaling, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Scaling
  {
    get => _Element?.Scaling?.Value;
    set => _ExistingElement.Scaling = value;
  }
  
}
