namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Clear Class.
/// </summary>
public interface IClear // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GeoLocationQueryResults.
  /// </summary>
  public IGeoLocationQueryResults? GeoLocationQueryResults { get ; set; }
  
  /// <summary>
  /// GeoDataEntityQueryResults.
  /// </summary>
  public IGeoDataEntityQueryResults? GeoDataEntityQueryResults { get ; set; }
  
  /// <summary>
  /// GeoDataPointToEntityQueryResults.
  /// </summary>
  public IGeoDataPointToEntityQueryResults? GeoDataPointToEntityQueryResults { get ; set; }
  
  /// <summary>
  /// GeoChildEntitiesQueryResults.
  /// </summary>
  public IGeoChildEntitiesQueryResults? GeoChildEntitiesQueryResults { get ; set; }
  
  /// <summary>
  /// GeoParentEntitiesQueryResults.
  /// </summary>
  public IGeoParentEntitiesQueryResults? GeoParentEntitiesQueryResults { get ; set; }
  
}
