namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Columns.
/// </summary>
public interface TableColumns // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Column Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<TableColumn>? TableColumns { get ; set; }
  
}
