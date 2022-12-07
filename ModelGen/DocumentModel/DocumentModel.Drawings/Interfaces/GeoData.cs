namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoData Class.
/// </summary>
public interface GeoData
{
  /// <summary>
  /// GeoPolygons.
  /// </summary>
  public GeoPolygons? GeoPolygons { get ; set; }
  
  /// <summary>
  /// Copyrights.
  /// </summary>
  public Copyrights? Copyrights { get ; set; }
  
}
