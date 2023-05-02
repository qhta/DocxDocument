namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GeoChildEntitiesQuery Class.
/// </summary>
public class GeoChildEntitiesQuery: ModelElement
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