namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
public partial class GeoChildEntitiesQueryResult: ModelElement<DXO16DCD.GeoChildEntitiesQueryResult>
{
  public GeoChildEntitiesQueryResult(): base(){ }
  
  public GeoChildEntitiesQueryResult(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoChildEntitiesQueryResult(DXO16DCD.GeoChildEntitiesQueryResult openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoChildEntitiesQuery.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoChildEntitiesQuery? GeoChildEntitiesQuery
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoChildEntitiesQuery,DXO16DCD.GeoChildEntitiesQuery>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoChildEntitiesQuery,DXO16DCD.GeoChildEntitiesQuery>(value);
    }
  }
  
  
  /// <summary>
  ///   GeoChildEntities.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoChildEntities? GeoChildEntities
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoChildEntities,DXO16DCD.GeoChildEntities>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoChildEntities,DXO16DCD.GeoChildEntities>(value);
    }
  }
  
}
