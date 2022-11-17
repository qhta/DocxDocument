namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IGeoDataPointQuery // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public EntityTypeEnum? EntityType { get ; set; }
  
  public double? Latitude { get ; set; }
  
  public double? Longitude { get ; set; }
  
}
