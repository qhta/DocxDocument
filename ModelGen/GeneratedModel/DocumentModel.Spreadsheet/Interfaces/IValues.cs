namespace DocumentModel.Spreadsheet;

public interface IValues // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public uint? Rows { get ; set; }
  
  public uint? Columns { get ; set; }
  
}
