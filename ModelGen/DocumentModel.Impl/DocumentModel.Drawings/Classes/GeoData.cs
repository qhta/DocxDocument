namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoData Class.
/// </summary>
public class GeoDataImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData>, GeoData
{
  /// <summary>
  /// GeoPolygons.
  /// </summary>
  public GeoPolygons? GeoPolygons
  {
    get;
    set;
  }
  
  /// <summary>
  /// Copyrights.
  /// </summary>
  public Copyrights? Copyrights
  {
    get;
    set;
  }
  
}
