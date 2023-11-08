namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticLightScreen Class.
/// </summary>
public partial class ArtisticLightScreen: ModelElement<DXO10D.ArtisticLightScreen>
{
  public ArtisticLightScreen(): base(){ }
  
  public ArtisticLightScreen(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticLightScreen(DXO10D.ArtisticLightScreen openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Transparancy
  {
    get
    {
      return _Element?.Transparancy?.Value;
    }
    set
    {
      _ExistingElement.Transparancy = value;
    }
  }
  
  
  /// <summary>
  ///   gridSize, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? GridSize
  {
    get
    {
      return _Element?.GridSize?.Value;
    }
    set
    {
      _ExistingElement.GridSize = value;
    }
  }
  
}
