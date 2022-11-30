namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoChildEntitiesQuery Class.
/// </summary>
public interface IGeoChildEntitiesQuery // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? EntityId { get ; set; }
  
  /// <summary>
  /// GeoChildTypes.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoChildTypes? GeoChildTypes { get ; set; }
  
}
