namespace DocumentModel.Spreadsheet;

public interface IColorFilter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public uint? FormatId { get ; set; }
  
  public bool? CellColor { get ; set; }
  
}
