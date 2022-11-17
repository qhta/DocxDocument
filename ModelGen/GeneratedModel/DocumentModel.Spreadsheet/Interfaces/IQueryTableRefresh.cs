namespace DocumentModel.Spreadsheet;

public interface IQueryTableRefresh // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? PreserveSortFilterLayout { get ; set; }
  
  public bool? FieldIdWrapped { get ; set; }
  
  public bool? HeadersInLastRefresh { get ; set; }
  
  public byte? MinimumVersion { get ; set; }
  
  public uint? NextId { get ; set; }
  
  public uint? UnboundColumnsLeft { get ; set; }
  
  public uint? UnboundColumnsRight { get ; set; }
  
  public IQueryTableFields? QueryTableFields { get ; set; }
  
  public IQueryTableDeletedFields? QueryTableDeletedFields { get ; set; }
  
  public ISortState? SortState { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
