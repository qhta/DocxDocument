namespace DocumentModel.Spreadsheet;

public interface IBottomBorder // : DocumentFormat.OpenXml.Spreadsheet.BorderPropertiesType
{
  public BorderStyle? Style { get ; set; }
  
  public DocumentModel.Spreadsheet.IColor? Color { get ; set; }
  
}
