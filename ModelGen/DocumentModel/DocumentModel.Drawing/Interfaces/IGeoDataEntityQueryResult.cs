namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoDataEntityQueryResult Class.
/// </summary>
public interface IGeoDataEntityQueryResult // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoDataEntityQuery.
  /// </summary>
  public IGeoDataEntityQuery? GeoDataEntityQuery { get ; set; }
  
  /// <summary>
  /// GeoData.
  /// </summary>
  public IGeoData? GeoData { get ; set; }
  
}
