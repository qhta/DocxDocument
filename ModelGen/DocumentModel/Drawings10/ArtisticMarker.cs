namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ArtisticMarker Class.
/// </summary>
public partial class ArtisticMarker: ModelElement<DXO10D.ArtisticMarker>
{
  public ArtisticMarker(): base(){ }
  
  public ArtisticMarker(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ArtisticMarker(DXO10D.ArtisticMarker openXmlElement): base(openXmlElement) { }
  
  
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
  ///   size, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Size
  {
    get
    {
      return _Element?.Size?.Value;
    }
    set
    {
      _ExistingElement.Size = value;
    }
  }
  
}
