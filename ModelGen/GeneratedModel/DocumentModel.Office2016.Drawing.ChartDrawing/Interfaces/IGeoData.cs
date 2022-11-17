namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IGeoData // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? EntityName { get ; set; }

  public string? EntityId { get ; set; }

  public double? East { get ; set; }

  public double? West { get ; set; }

  public double? North { get ; set; }

  public double? South { get ; set; }

  public IGeoPolygons? GeoPolygons { get ; set; }

  public ICopyrights? Copyrights { get ; set; }

}
