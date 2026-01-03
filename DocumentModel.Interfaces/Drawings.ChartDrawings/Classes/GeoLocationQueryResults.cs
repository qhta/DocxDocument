namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoLocationQueryResults Class.
/// </summary>
public interface GeoLocationQueryResults: IModelElement
{
  public Collection<GeoLocationQueryResult>? Items { get; set; }
}