namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Dimensions Class.
/// </summary>
public interface Dimensions // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// OLAP Dimensions Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<Dimension>? Dimensions { get ; set; }
  
}
