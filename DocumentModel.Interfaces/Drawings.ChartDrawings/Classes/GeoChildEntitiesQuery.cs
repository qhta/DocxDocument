namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoChildEntitiesQuery Class.
/// </summary>
public interface GeoChildEntitiesQuery: IModelElement
{
  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public string? EntityId { get; set; }
  /// <summary>
  ///   GeoChildTypes.
  /// </summary>
  public GeoChildTypes? GeoChildTypes { get; set; }
}