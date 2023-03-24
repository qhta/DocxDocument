namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public class GeoParentEntitiesQueryResult: ModelElement
{
  /// <summary>
  ///   GeoParentEntitiesQuery.
  /// </summary>
  public GeoParentEntitiesQuery? GeoParentEntitiesQuery { get; set; }

  /// <summary>
  ///   GeoEntity.
  /// </summary>
  public GeoEntity? GeoEntity { get; set; }

  /// <summary>
  ///   GeoParentEntity.
  /// </summary>
  public GeoParentEntity? GeoParentEntity { get; set; }
}