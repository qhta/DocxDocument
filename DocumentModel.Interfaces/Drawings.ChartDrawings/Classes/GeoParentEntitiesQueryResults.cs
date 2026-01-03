namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoParentEntitiesQueryResults Class.
/// </summary>
public interface GeoParentEntitiesQueryResults: IModelElement
{
  public Collection<GeoParentEntitiesQueryResult>? Items { get; set; }
}