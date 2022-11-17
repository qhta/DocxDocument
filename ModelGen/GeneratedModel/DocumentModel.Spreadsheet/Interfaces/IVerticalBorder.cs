namespace DocumentModel.Spreadsheet;

public interface IVerticalBorder // : DocumentFormat.OpenXml.Spreadsheet.BorderPropertiesType
{
  public BorderStyle? Style { get ; set; }

  public DocumentModel.Spreadsheet.IColor? Color { get ; set; }

}
