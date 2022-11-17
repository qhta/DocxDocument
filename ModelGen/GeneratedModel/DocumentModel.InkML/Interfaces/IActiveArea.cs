namespace DocumentModel.InkML;

public interface IActiveArea // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Size { get ; set; }

  public decimal? Height { get ; set; }

  public decimal? Width { get ; set; }

  public string? Units { get ; set; }

}
