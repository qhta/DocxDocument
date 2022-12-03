namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColumnFields Class.
/// </summary>
public interface ColumnFields // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Repeated Items Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<Field>? Fields { get ; set; }
  
}
