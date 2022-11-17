namespace DocumentModel.Wordprocessing;

public interface INumberingChange // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Original { get ; set; }
  
  public string? Author { get ; set; }
  
  public DateTime? Date { get ; set; }
  
  public string? Id { get ; set; }
  
}
