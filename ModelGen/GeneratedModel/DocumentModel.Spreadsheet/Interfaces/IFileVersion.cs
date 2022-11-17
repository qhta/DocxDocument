namespace DocumentModel.Spreadsheet;

public interface IFileVersion // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? ApplicationName { get ; set; }

  public string? LastEdited { get ; set; }

  public string? LowestEdited { get ; set; }

  public string? BuildVersion { get ; set; }

  public string? CodeName { get ; set; }

}
