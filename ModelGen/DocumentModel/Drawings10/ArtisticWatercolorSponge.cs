namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticWatercolorSponge Class.
/// </summary>
public partial class ArtisticWatercolorSponge: ModelElement<DXO10D.ArtisticWatercolorSponge>
{
  public ArtisticWatercolorSponge(): base(){ }
  
  public ArtisticWatercolorSponge(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticWatercolorSponge(DXO10D.ArtisticWatercolorSponge openXmlElement): base(openXmlElement) { }
  
  
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
  ///   brushSize, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? BrushSize
  {
    get
    {
      return _Element?.BrushSize?.Value;
    }
    set
    {
      _ExistingElement.BrushSize = value;
    }
  }
  
}
