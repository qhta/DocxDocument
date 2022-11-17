namespace DocumentModel.Spreadsheet;

public interface IDatabaseProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Connection { get ; set; }
  
  public string? Command { get ; set; }
  
  public string? ServerCommand { get ; set; }
  
  public uint? CommandType { get ; set; }
  
}
