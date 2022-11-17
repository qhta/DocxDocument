namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IGeoLocation // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public double? Latitude { get ; set; }

  public double? Longitude { get ; set; }

  public string? EntityName { get ; set; }

  public EntityTypeEnum? EntityType { get ; set; }

  public IAddress? Address { get ; set; }

}
