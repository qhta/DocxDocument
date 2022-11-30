namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sort State for Auto Filter.
/// </summary>
public interface ISortState // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Sort by Columns
  /// </summary>
  public System.Boolean? ColumnSort { get ; set; }
  
  /// <summary>
  /// Case Sensitive
  /// </summary>
  public System.Boolean? CaseSensitive { get ; set; }
  
  /// <summary>
  /// Sort Method
  /// </summary>
  public DocumentModel.Spreadsheet.SortMethodKind? SortMethod { get ; set; }
  
  /// <summary>
  /// Sort Range
  /// </summary>
  public System.String? Reference { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Excel.ISortCondition>? SortConditions { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
