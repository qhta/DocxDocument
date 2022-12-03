namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the RowItems Class.
/// </summary>
public interface RowItems // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Items in a Row Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<RowItem>? RowItems { get ; set; }
  
}
