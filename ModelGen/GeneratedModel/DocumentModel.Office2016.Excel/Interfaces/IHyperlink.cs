namespace DocumentModel.Office2016.Excel;

public interface IHyperlink // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Reference { get ; set; }
  
  public string? Id { get ; set; }
  
  public string? Location { get ; set; }
  
  public string? Tooltip { get ; set; }
  
  public string? Display { get ; set; }
  
}
