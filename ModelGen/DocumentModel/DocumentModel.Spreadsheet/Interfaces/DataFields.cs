namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataFields Class.
/// </summary>
public interface DataFields // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Data Items Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<DataField>? DataFields { get ; set; }
  
}
