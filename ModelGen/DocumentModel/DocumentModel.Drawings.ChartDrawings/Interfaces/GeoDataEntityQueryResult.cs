namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataEntityQueryResult Class.
/// </summary>
public interface GeoDataEntityQueryResult
{
  /// <summary>
  /// GeoDataEntityQuery.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoDataEntityQuery? GeoDataEntityQuery { get ; set; }
  
  /// <summary>
  /// GeoData.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoData? GeoData { get ; set; }
  
}
