namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SortCondition Class.
/// </summary>
public interface ISortCondition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Descending
  /// </summary>
  public System.Boolean? Descending { get ; set; }
  
  /// <summary>
  /// Sort By
  /// </summary>
  public DocumentModel.Spreadsheet.SortByKind? SortBy { get ; set; }
  
  /// <summary>
  /// Reference
  /// </summary>
  public System.String? Reference { get ; set; }
  
  /// <summary>
  /// Custom List
  /// </summary>
  public System.String? CustomList { get ; set; }
  
  /// <summary>
  /// Format Id
  /// </summary>
  public System.UInt32? FormatId { get ; set; }
  
  /// <summary>
  /// Icon Set
  /// </summary>
  public DocumentModel.Spreadsheet.IconSetKind? IconSet { get ; set; }
  
  /// <summary>
  /// Icon Id
  /// </summary>
  public System.UInt32? IconId { get ; set; }
  
}
