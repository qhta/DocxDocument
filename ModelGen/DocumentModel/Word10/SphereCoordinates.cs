namespace DocumentModel.Word10;


/// <summary>
///   This element specifies sphere coordinates using a latitude coordinate, a longitude coordinate, and a revolution around the central axis.
/// </summary>
public partial class SphereCoordinates: ModelElement<DXO10W.SphereCoordinates>
{
  public SphereCoordinates(): base(){ }
  
  public SphereCoordinates(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SphereCoordinates(DXO10W.SphereCoordinates openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   lat, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Lattitude
  {
    get => _Element?.Lattitude?.Value;
    set => _ExistingElement.Lattitude = value;
  }
  
  
  /// <summary>
  ///   lon, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Longitude
  {
    get => _Element?.Longitude?.Value;
    set => _ExistingElement.Longitude = value;
  }
  
  
  /// <summary>
  ///   rev, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Revolution
  {
    get => _Element?.Revolution?.Value;
    set => _ExistingElement.Revolution = value;
  }
  
}
