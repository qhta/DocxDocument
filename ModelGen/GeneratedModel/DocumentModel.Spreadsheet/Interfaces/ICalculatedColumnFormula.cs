namespace DocumentModel.Spreadsheet;

public interface ICalculatedColumnFormula // : DocumentFormat.OpenXml.Spreadsheet.TableFormulaType
{
  public bool? Array { get ; set; }
  
  public SpaceProcessingMode? Space { get ; set; }
  
  public string? Text { get ; set; }
  
}
