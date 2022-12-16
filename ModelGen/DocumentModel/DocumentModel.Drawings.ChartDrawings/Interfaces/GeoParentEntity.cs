namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoParentEntity Class.
/// </summary>
public interface GeoParentEntity
{
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityId { get ; set; }
  
}
