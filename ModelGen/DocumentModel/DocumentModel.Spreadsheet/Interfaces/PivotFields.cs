namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFields Class.
/// </summary>
public interface PivotFields // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Field Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<PivotField>? PivotFields { get ; set; }
  
}
