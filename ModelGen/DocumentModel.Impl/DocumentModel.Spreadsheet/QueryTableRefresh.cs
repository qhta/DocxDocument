namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the QueryTableRefresh Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IQueryTableDeletedFields))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IQueryTableFields))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ISortState))]
public class QueryTableRefresh: IQueryTableRefresh
{
  /// <summary>
  /// Preserve Sort and Filter Layout
  /// </summary>
  public bool? PreserveSortFilterLayout
  {
    get;
    set;
  }
  
  /// <summary>
  /// Next Field Id Wrapped
  /// </summary>
  public bool? FieldIdWrapped
  {
    get;
    set;
  }
  
  /// <summary>
  /// Headers In Last Refresh
  /// </summary>
  public bool? HeadersInLastRefresh
  {
    get;
    set;
  }
  
  /// <summary>
  /// Minimum Refresh Version
  /// </summary>
  public byte? MinimumVersion
  {
    get;
    set;
  }
  
  /// <summary>
  /// Next field id
  /// </summary>
  public uint? NextId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Columns Left
  /// </summary>
  public uint? UnboundColumnsLeft
  {
    get;
    set;
  }
  
  /// <summary>
  /// Columns Right
  /// </summary>
  public uint? UnboundColumnsRight
  {
    get;
    set;
  }
  
  /// <summary>
  /// Query table fields.
  /// </summary>
  public IQueryTableFields? QueryTableFields
  {
    get;
    set;
  }
  
  /// <summary>
  /// Deleted Fields.
  /// </summary>
  public IQueryTableDeletedFields? QueryTableDeletedFields
  {
    get;
    set;
  }
  
  /// <summary>
  /// Sort State.
  /// </summary>
  public ISortState? SortState
  {
    get;
    set;
  }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
