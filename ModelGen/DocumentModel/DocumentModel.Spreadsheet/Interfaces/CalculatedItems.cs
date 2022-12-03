namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedItems Class.
/// </summary>
public interface CalculatedItems // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Calculated Item Formula Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<CalculatedItem>? CalculatedItems { get ; set; }
  
}
