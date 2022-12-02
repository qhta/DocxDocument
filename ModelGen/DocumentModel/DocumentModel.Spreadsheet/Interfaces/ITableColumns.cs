namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Columns.
/// </summary>
public interface ITableColumns // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Column Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<ITableColumn>? TableColumns { get ; set; }
  
}
