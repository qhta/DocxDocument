namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the NsvFilter Class.
/// </summary>
public interface INsvFilter // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// filterId, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? FilterId { get ; set; }
  
  /// <summary>
  /// ref, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? Ref { get ; set; }
  
  /// <summary>
  /// tableId, this property is only available in Office 2021 and later.
  /// </summary>
  public System.UInt32? TableId { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IColumnFilter>? ColumnFilters { get ; set; }
  
  public DocumentModel.Spreadsheet.ISortRules? SortRules { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
