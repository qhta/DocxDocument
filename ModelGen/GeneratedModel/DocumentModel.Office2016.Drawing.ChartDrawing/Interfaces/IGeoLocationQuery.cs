namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IGeoLocationQuery // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? CountryRegion { get ; set; }
  
  public string? AdminDistrict1 { get ; set; }
  
  public string? AdminDistrict2 { get ; set; }
  
  public string? PostalCode { get ; set; }
  
  public EntityTypeEnum? EntityType { get ; set; }
  
}
