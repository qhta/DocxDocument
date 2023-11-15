namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticGlowEdges Class.
/// </summary>
public partial class ArtisticGlowEdges: ModelElement<DXO10D.ArtisticGlowEdges>
{
  public ArtisticGlowEdges(): base(){ }
  
  public ArtisticGlowEdges(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticGlowEdges(DXO10D.ArtisticGlowEdges openXmlElement): base(openXmlElement) { }
  
  
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
