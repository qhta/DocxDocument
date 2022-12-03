namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the MergeCells Class.
/// </summary>
public interface MergeCells // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<MergeCell>? MergeCells { get ; set; }
  
}
