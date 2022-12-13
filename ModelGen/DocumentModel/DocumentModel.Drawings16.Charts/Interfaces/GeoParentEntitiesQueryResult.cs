namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public interface GeoParentEntitiesQueryResult
{
  /// <summary>
  /// GeoParentEntitiesQuery.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoParentEntitiesQuery? GeoParentEntitiesQuery { get ; set; }
  
  /// <summary>
  /// GeoEntity.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoEntity? GeoEntity { get ; set; }
  
  /// <summary>
  /// GeoParentEntity.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoParentEntity? GeoParentEntity { get ; set; }
  
}
