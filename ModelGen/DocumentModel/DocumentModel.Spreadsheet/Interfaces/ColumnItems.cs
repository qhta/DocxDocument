namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColumnItems Class.
/// </summary>
public interface ColumnItems // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Column Item Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<RowItem>? RowItems { get ; set; }
  
}
