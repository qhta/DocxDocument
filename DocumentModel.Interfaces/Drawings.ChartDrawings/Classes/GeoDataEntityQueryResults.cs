namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoDataEntityQueryResults Class.
/// </summary>
public interface GeoDataEntityQueryResults: IModelElement
{
  public Collection<GeoDataEntityQueryResult>? Items { get; set; }
}