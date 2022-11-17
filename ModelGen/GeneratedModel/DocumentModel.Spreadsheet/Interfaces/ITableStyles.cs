namespace DocumentModel.Spreadsheet;

public interface ITableStyles // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public uint? Count { get ; set; }

  public string? DefaultTableStyle { get ; set; }

  public string? DefaultPivotStyle { get ; set; }

}
