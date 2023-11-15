namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticGlowDiffused Class.
/// </summary>
public partial class ArtisticGlowDiffused: ModelElement<DXO10D.ArtisticGlowDiffused>
{
  public ArtisticGlowDiffused(): base(){ }
  
  public ArtisticGlowDiffused(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticGlowDiffused(DXO10D.ArtisticGlowDiffused openXmlElement): base(openXmlElement) { }
  
  
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
  ///   intensity, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Intensity
  {
    get => _Element?.Intensity?.Value;
    set => _ExistingElement.Intensity = value;
  }
  
}
