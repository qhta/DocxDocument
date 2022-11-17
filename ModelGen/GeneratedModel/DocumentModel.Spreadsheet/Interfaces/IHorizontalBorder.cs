namespace DocumentModel.Spreadsheet;

public interface IHorizontalBorder // : DocumentFormat.OpenXml.Spreadsheet.BorderPropertiesType
{
  public BorderStyle? Style { get ; set; }

  public DocumentModel.Spreadsheet.IColor? Color { get ; set; }

}
