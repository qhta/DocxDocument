namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoDataPointToEntityQueryResults Class.
/// </summary>
public interface GeoDataPointToEntityQueryResults: IModelElement
{
  public Collection<GeoDataPointToEntityQueryResult>? Items { get; set; }
}