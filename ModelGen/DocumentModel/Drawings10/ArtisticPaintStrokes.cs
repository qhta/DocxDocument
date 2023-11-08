namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticPaintStrokes Class.
/// </summary>
public partial class ArtisticPaintStrokes: ModelElement<DXO10D.ArtisticPaintStrokes>
{
  public ArtisticPaintStrokes(): base(){ }
  
  public ArtisticPaintStrokes(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticPaintStrokes(DXO10D.ArtisticPaintStrokes openXmlElement): base(openXmlElement) { }
  
  
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
  ///   intensity, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Intensity
  {
    get
    {
      return _Element?.Intensity?.Value;
    }
    set
    {
      _ExistingElement.Intensity = value;
    }
  }
  
}
