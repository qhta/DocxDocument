namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocation Class.
/// </summary>
public partial class GeoLocation
{
  /// <summary>
  /// latitude, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Latitude { get; set; }
  
  /// <summary>
  /// longitude, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Longitude { get; set; }
  
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityName { get; set; }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? EntityType { get; set; }
  
  /// <summary>
  /// Address.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.Address? Address { get; set; }
  
}
