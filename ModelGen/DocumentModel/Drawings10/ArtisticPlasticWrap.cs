namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticPlasticWrap Class.
/// </summary>
public partial class ArtisticPlasticWrap: ModelElement<DXO10D.ArtisticPlasticWrap>
{
  public ArtisticPlasticWrap(): base(){ }
  
  public ArtisticPlasticWrap(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticPlasticWrap(DXO10D.ArtisticPlasticWrap openXmlElement): base(openXmlElement) { }
  
  
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
  ///   smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Smoothness
  {
    get => _Element?.Smoothness?.Value;
    set => _ExistingElement.Smoothness = value;
  }
  
}
