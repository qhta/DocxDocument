namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoChildEntitiesQueryResults Class.
/// </summary>
public interface GeoChildEntitiesQueryResults: IModelElement
{
  public Collection<GeoChildEntitiesQueryResult>? Items { get; set; }
}