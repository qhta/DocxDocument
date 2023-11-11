namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public partial class GeoParentEntitiesQueryResult: ModelElement<DXO16DCD.GeoParentEntitiesQueryResult>
{
  public GeoParentEntitiesQueryResult(): base(){ }
  
  public GeoParentEntitiesQueryResult(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoParentEntitiesQueryResult(DXO16DCD.GeoParentEntitiesQueryResult openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoParentEntitiesQuery.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoParentEntitiesQuery? GeoParentEntitiesQuery
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoParentEntitiesQuery,DXO16DCD.GeoParentEntitiesQuery>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoParentEntitiesQuery,DXO16DCD.GeoParentEntitiesQuery>(value);
    }
  }
  
  
  /// <summary>
  ///   GeoEntity.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoEntity? GeoEntity
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoEntity,DXO16DCD.GeoEntity>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoEntity,DXO16DCD.GeoEntity>(value);
    }
  }
  
  
  /// <summary>
  ///   GeoParentEntity.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoParentEntity? GeoParentEntity
  {
    get
    {
      return _Element?.GetObject<DMDCD16.GeoParentEntity,DXO16DCD.GeoParentEntity>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.GeoParentEntity,DXO16DCD.GeoParentEntity>(value);
    }
  }
  
}
