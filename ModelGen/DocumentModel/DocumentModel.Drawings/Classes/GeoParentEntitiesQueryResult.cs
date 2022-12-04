namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public class GeoParentEntitiesQueryResult
{
  /// <summary>
  /// GeoParentEntitiesQuery.
  /// </summary>
  public GeoParentEntitiesQuery? GeoParentEntitiesQuery
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoEntity.
  /// </summary>
  public GeoEntity? GeoEntity
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoParentEntity.
  /// </summary>
  public GeoParentEntity? GeoParentEntity
  {
    get;
    set;
  }
  
}
