namespace DocumentModel.Spreadsheet;

public interface IWorksheetSource // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Reference { get ; set; }

  public string? Name { get ; set; }

  public string? Sheet { get ; set; }

  public string? Id { get ; set; }

}
