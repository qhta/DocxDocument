namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sets.
/// </summary>
public interface ISets // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Tuple Set Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<ITupleSet>? TupleSets { get ; set; }
  
}
