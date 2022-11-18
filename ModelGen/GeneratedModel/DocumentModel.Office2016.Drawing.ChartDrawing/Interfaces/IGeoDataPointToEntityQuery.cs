namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoDataPointToEntityQuery Class.
/// </summary>
public interface IGeoDataPointToEntityQuery // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType { get ; set; }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public string? EntityId { get ; set; }
  
}
