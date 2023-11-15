namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticFilmGrain Class.
/// </summary>
public partial class ArtisticFilmGrain: ModelElement<DXO10D.ArtisticFilmGrain>
{
  public ArtisticFilmGrain(): base(){ }
  
  public ArtisticFilmGrain(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticFilmGrain(DXO10D.ArtisticFilmGrain openXmlElement): base(openXmlElement) { }
  
  
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
  ///   grainSize, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? GrainSize
  {
    get => _Element?.GrainSize?.Value;
    set => _ExistingElement.GrainSize = value;
  }
  
}
