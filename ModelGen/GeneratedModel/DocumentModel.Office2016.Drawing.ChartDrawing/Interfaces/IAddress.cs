namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IAddress // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Address1 { get ; set; }

  public string? CountryRegion { get ; set; }

  public string? AdminDistrict1 { get ; set; }

  public string? AdminDistrict2 { get ; set; }

  public string? PostalCode { get ; set; }

  public string? Locality { get ; set; }

  public string? IsoCountryCode { get ; set; }

}
