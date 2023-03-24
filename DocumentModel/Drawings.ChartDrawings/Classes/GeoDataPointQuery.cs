namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GeoDataPointQuery Class.
/// </summary>
public class GeoDataPointQuery: ModelElement
{
  /// <summary>
  ///   entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType { get; set; }

  /// <summary>
  ///   latitude, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Latitude { get; set; }

  /// <summary>
  ///   longitude, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Longitude { get; set; }
}