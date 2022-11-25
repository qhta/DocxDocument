namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoDataEntityQuery Class.
/// </summary>
public interface IGeoDataEntityQuery // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.EntityTypeEnum? EntityType { get ; set; }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? EntityId { get ; set; }
  
}
