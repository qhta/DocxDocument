namespace DocumentModel.Spreadsheet;

/// <summary>
/// Range Sets.
/// </summary>
public interface IRangeSets // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference and Page Item Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IRangeSet>? RangeSets { get ; set; }
  
}
