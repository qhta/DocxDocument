namespace DocumentModel.Spreadsheet;

/// <summary>
/// Query.
/// </summary>
public interface Query // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// MDX Query String
  /// </summary>
  public String? Mdx { get ; set; }
  
  /// <summary>
  /// Tuples.
  /// </summary>
  public Tuples? Tuples { get ; set; }
  
}
