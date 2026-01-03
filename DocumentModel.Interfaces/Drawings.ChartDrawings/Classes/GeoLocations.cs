namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoLocations Class.
/// </summary>
public interface GeoLocations: IModelElement
{
  /// <summary>
  ///   GeoLocation.
  /// </summary>
  public GeoLocation? GeoLocation { get; set; }
}