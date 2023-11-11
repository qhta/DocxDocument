namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoLocations Class.
/// </summary>
public partial class GeoLocations: ModelElement<DXO16DCD.GeoLocations>
{
  public GeoLocations(): base(){ }
  
  public GeoLocations(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoLocations(DXO16DCD.GeoLocations openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoLocation.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoLocation? GeoLocation
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoLocation,DXO16DCD.GeoLocation>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoLocation,DXO16DCD.GeoLocation>(value);
    }
  }
  
}
