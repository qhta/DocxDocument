namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticBlur Class.
/// </summary>
public partial class ArtisticBlur: ModelElement<DXO10D.ArtisticBlur>
{
  public ArtisticBlur(): base(){ }
  
  public ArtisticBlur(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticBlur(DXO10D.ArtisticBlur openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   radius, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Radius
  {
    get
    {
      return _Element?.Radius?.Value;
    }
    set
    {
      _ExistingElement.Radius = value;
    }
  }
  
}
