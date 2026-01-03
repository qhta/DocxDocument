namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoParentEntity Class.
/// </summary>
public interface GeoParentEntity: IModelElement
{
  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public string? EntityId { get; set; }
}