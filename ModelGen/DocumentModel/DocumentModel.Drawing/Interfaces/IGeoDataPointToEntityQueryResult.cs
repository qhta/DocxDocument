namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoDataPointToEntityQueryResult Class.
/// </summary>
public interface IGeoDataPointToEntityQueryResult // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoDataPointQuery.
  /// </summary>
  public DocumentModel.Drawing.IGeoDataPointQuery? GeoDataPointQuery { get ; set; }
  
  /// <summary>
  /// GeoDataPointToEntityQuery.
  /// </summary>
  public DocumentModel.Drawing.IGeoDataPointToEntityQuery? GeoDataPointToEntityQuery { get ; set; }
  
}
