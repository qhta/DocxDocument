namespace DocumentModel.Spreadsheet;

public interface ISortState // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? ColumnSort { get ; set; }
  
  public bool? CaseSensitive { get ; set; }
  
  public SortMethod? SortMethod { get ; set; }
  
  public string? Reference { get ; set; }
  
}
