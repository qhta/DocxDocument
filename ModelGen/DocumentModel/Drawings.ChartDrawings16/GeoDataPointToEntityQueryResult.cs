namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoDataPointToEntityQueryResult Class.
/// </summary>
public partial class GeoDataPointToEntityQueryResult: ModelElement<DXO16DCD.GeoDataPointToEntityQueryResult>
{
  public GeoDataPointToEntityQueryResult(): base(){ }
  
  public GeoDataPointToEntityQueryResult(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoDataPointToEntityQueryResult(DXO16DCD.GeoDataPointToEntityQueryResult openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoDataPointQuery.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoDataPointQuery? GeoDataPointQuery
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoDataPointQuery,DXO16DCD.GeoDataPointQuery>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoDataPointQuery,DXO16DCD.GeoDataPointQuery>(value);
    }
  }
  
  
  /// <summary>
  ///   GeoDataPointToEntityQuery.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoDataPointToEntityQuery? GeoDataPointToEntityQuery
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoDataPointToEntityQuery,DXO16DCD.GeoDataPointToEntityQuery>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoDataPointToEntityQuery,DXO16DCD.GeoDataPointToEntityQuery>(value);
    }
  }
  
}
