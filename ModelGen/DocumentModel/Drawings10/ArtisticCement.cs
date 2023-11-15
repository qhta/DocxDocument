namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticCement Class.
/// </summary>
public partial class ArtisticCement: ModelElement<DXO10D.ArtisticCement>
{
  public ArtisticCement(): base(){ }
  
  public ArtisticCement(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticCement(DXO10D.ArtisticCement openXmlElement): base(openXmlElement) { }
  
  
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
  ///   crackSpacing, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? CrackSpacing
  {
    get => _Element?.CrackSpacing?.Value;
    set => _ExistingElement.CrackSpacing = value;
  }
  
}
