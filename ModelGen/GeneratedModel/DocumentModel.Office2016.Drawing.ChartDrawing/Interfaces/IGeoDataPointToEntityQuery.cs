namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IGeoDataPointToEntityQuery // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public EntityTypeEnum? EntityType { get ; set; }
  
  public string? EntityId { get ; set; }
  
}
