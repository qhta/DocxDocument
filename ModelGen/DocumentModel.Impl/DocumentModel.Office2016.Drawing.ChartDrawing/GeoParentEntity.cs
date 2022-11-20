namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoParentEntity Class.
/// </summary>
public class GeoParentEntity: IGeoParentEntity
{
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public string? EntityId
  {
    get;
    set;
  }
  
}
