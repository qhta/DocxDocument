namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoDataEntityQueryResult Class.
/// </summary>
public interface IGeoDataEntityQueryResult // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoDataEntityQuery.
  /// </summary>
  public DocumentModel.Drawing.IGeoDataEntityQuery? GeoDataEntityQuery { get ; set; }
  
  /// <summary>
  /// GeoData.
  /// </summary>
  public DocumentModel.Drawing.IGeoData? GeoData { get ; set; }
  
}
