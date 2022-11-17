namespace DocumentModel.Spreadsheet;

public interface ILocation // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Reference { get ; set; }
  
  public uint? FirstHeaderRow { get ; set; }
  
  public uint? FirstDataRow { get ; set; }
  
  public uint? FirstDataColumn { get ; set; }
  
  public uint? RowPageCount { get ; set; }
  
  public uint? ColumnsPerPage { get ; set; }
  
}
