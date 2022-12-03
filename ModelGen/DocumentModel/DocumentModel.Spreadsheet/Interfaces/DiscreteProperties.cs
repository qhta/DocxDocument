namespace DocumentModel.Spreadsheet;

/// <summary>
/// Discrete Grouping Properties.
/// </summary>
public interface DiscreteProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Mapping Index Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<UInt32>? FieldItems { get ; set; }
  
}
