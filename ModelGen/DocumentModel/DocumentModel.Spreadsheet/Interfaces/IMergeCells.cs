namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the MergeCells Class.
/// </summary>
public interface IMergeCells // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IMergeCell>? MergeCells { get ; set; }
  
}
