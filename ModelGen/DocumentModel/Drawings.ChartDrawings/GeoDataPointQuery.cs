namespace DocumentModel.Drawings.ChartDrawings;


/// <summary>
///   Defines the GeoDataPointQuery Class.
/// </summary>
public partial class GeoDataPointQuery
{
  
  /// <summary>
  ///   latitude, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Latitude { get; set; }
  
  
  /// <summary>
  ///   longitude, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Longitude { get; set; }
  
}
