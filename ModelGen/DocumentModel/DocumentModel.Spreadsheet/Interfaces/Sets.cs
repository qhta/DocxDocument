namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sets.
/// </summary>
public interface Sets // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Tuple Set Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<TupleSet>? TupleSets { get ; set; }
  
}
