namespace DocumentModel.Spreadsheet;

/// <summary>
/// Range Sets.
/// </summary>
public interface RangeSets // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Reference and Page Item Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<RangeSet>? RangeSets { get ; set; }
  
}
