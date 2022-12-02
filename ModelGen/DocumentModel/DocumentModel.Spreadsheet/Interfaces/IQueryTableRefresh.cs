namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the QueryTableRefresh Class.
/// </summary>
public interface IQueryTableRefresh // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Preserve Sort and Filter Layout
  /// </summary>
  public Boolean? PreserveSortFilterLayout { get ; set; }
  
  /// <summary>
  /// Next Field Id Wrapped
  /// </summary>
  public Boolean? FieldIdWrapped { get ; set; }
  
  /// <summary>
  /// Headers In Last Refresh
  /// </summary>
  public Boolean? HeadersInLastRefresh { get ; set; }
  
  /// <summary>
  /// Minimum Refresh Version
  /// </summary>
  public Byte? MinimumVersion { get ; set; }
  
  /// <summary>
  /// Next field id
  /// </summary>
  public UInt32? NextId { get ; set; }
  
  /// <summary>
  /// Columns Left
  /// </summary>
  public UInt32? UnboundColumnsLeft { get ; set; }
  
  /// <summary>
  /// Columns Right
  /// </summary>
  public UInt32? UnboundColumnsRight { get ; set; }
  
  /// <summary>
  /// Query table fields.
  /// </summary>
  public IQueryTableFields? QueryTableFields { get ; set; }
  
  /// <summary>
  /// Deleted Fields.
  /// </summary>
  public IQueryTableDeletedFields? QueryTableDeletedFields { get ; set; }
  
  /// <summary>
  /// Sort State.
  /// </summary>
  public ISortState? SortState { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
