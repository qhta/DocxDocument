namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the QueryTableRefresh Class.
/// </summary>
public interface IQueryTableRefresh // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Preserve Sort and Filter Layout
  /// </summary>
  public System.Boolean? PreserveSortFilterLayout { get ; set; }
  
  /// <summary>
  /// Next Field Id Wrapped
  /// </summary>
  public System.Boolean? FieldIdWrapped { get ; set; }
  
  /// <summary>
  /// Headers In Last Refresh
  /// </summary>
  public System.Boolean? HeadersInLastRefresh { get ; set; }
  
  /// <summary>
  /// Minimum Refresh Version
  /// </summary>
  public System.Byte? MinimumVersion { get ; set; }
  
  /// <summary>
  /// Next field id
  /// </summary>
  public System.UInt32? NextId { get ; set; }
  
  /// <summary>
  /// Columns Left
  /// </summary>
  public System.UInt32? UnboundColumnsLeft { get ; set; }
  
  /// <summary>
  /// Columns Right
  /// </summary>
  public System.UInt32? UnboundColumnsRight { get ; set; }
  
  /// <summary>
  /// Query table fields.
  /// </summary>
  public DocumentModel.Spreadsheet.IQueryTableFields? QueryTableFields { get ; set; }
  
  /// <summary>
  /// Deleted Fields.
  /// </summary>
  public DocumentModel.Spreadsheet.IQueryTableDeletedFields? QueryTableDeletedFields { get ; set; }
  
  /// <summary>
  /// Sort State.
  /// </summary>
  public DocumentModel.Spreadsheet.ISortState? SortState { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
