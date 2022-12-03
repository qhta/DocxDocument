namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the RowFields Class.
/// </summary>
public interface RowFields // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Repeated Items Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<Field>? Fields { get ; set; }
  
}
