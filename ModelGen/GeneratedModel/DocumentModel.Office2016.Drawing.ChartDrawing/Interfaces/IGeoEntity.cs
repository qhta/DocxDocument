namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IGeoEntity // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? EntityName { get ; set; }

  public EntityTypeEnum? EntityType { get ; set; }

}
