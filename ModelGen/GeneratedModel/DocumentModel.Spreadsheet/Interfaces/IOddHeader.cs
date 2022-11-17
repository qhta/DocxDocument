namespace DocumentModel.Spreadsheet;

public interface IOddHeader // : DocumentFormat.OpenXml.Spreadsheet.XstringType
{
  public SpaceProcessingMode? Space { get ; set; }

  public string? Text { get ; set; }

}
