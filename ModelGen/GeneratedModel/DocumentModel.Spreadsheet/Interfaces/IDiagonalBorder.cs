namespace DocumentModel.Spreadsheet;

public interface IDiagonalBorder // : DocumentFormat.OpenXml.Spreadsheet.BorderPropertiesType
{
  public BorderStyle? Style { get ; set; }

  public DocumentModel.Spreadsheet.IColor? Color { get ; set; }

}
