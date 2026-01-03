namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoParentEntitiesQuery Class.
/// </summary>
public interface GeoParentEntitiesQuery: IModelElement
{
  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public string? EntityId { get; set; }
}