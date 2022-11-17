namespace DocumentModel.Spreadsheet;

public interface INumberingFormat // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public uint? NumberFormatId { get ; set; }

  public string? FormatCode { get ; set; }

}
