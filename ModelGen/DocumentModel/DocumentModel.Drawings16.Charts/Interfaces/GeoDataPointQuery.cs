namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoDataPointQuery Class.
/// </summary>
public interface GeoDataPointQuery
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.EntityTypeEnum? EntityType { get ; set; }
  
  /// <summary>
  /// latitude, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Latitude { get ; set; }
  
  /// <summary>
  /// longitude, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Longitude { get ; set; }
  
}
