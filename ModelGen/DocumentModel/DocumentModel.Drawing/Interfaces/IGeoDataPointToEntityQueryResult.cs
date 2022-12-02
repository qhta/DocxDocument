namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoDataPointToEntityQueryResult Class.
/// </summary>
public interface IGeoDataPointToEntityQueryResult // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoDataPointQuery.
  /// </summary>
  public IGeoDataPointQuery? GeoDataPointQuery { get ; set; }
  
  /// <summary>
  /// GeoDataPointToEntityQuery.
  /// </summary>
  public IGeoDataPointToEntityQuery? GeoDataPointToEntityQuery { get ; set; }
  
}
