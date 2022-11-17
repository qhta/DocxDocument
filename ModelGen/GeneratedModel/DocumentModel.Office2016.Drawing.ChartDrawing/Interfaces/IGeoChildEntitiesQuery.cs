namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IGeoChildEntitiesQuery // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? EntityId { get ; set; }
  
  public IGeoChildTypes? GeoChildTypes { get ; set; }
  
}
