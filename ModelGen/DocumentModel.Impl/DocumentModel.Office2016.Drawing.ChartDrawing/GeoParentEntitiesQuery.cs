namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoParentEntitiesQuery Class.
/// </summary>
public class GeoParentEntitiesQuery: IGeoParentEntitiesQuery
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
