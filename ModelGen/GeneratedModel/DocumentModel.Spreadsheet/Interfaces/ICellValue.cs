namespace DocumentModel.Spreadsheet;

public interface ICellValue // : DocumentFormat.OpenXml.Spreadsheet.XstringType
{
  public SpaceProcessingMode? Space { get ; set; }
  
  public string? Text { get ; set; }
  
}
