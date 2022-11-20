namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoChildEntitiesQuery Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoChildTypes))]
public interface IGeoChildEntitiesQuery // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public string? EntityId { get ; set; }
  
  /// <summary>
  /// GeoChildTypes.
  /// </summary>
  public IGeoChildTypes? GeoChildTypes { get ; set; }
  
}
