namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoLocationQueryResult Class.
/// </summary>
public partial class GeoLocationQueryResult: ModelElement<DXO16DCD.GeoLocationQueryResult>
{
  public GeoLocationQueryResult(): base(){ }
  
  public GeoLocationQueryResult(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoLocationQueryResult(DXO16DCD.GeoLocationQueryResult openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoLocationQuery.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoLocationQuery? GeoLocationQuery
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoLocationQuery,DXO16DCD.GeoLocationQuery>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoLocationQuery,DXO16DCD.GeoLocationQuery>(value);
    }
  }
  
  
  /// <summary>
  ///   GeoLocations.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoLocations? GeoLocations
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoLocations,DXO16DCD.GeoLocations>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoLocations,DXO16DCD.GeoLocations>(value);
    }
  }
  
}
