namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Columns.
/// </summary>
public interface ITableColumns // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Column Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ITableColumn>? TableColumns { get ; set; }
  
}
