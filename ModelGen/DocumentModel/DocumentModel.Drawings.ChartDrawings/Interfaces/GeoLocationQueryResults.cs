namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocationQueryResults Class.
/// </summary>
public partial interface GeoLocationQueryResults
{
  public Collection<DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResult>? Items { get; set; }
  
}
