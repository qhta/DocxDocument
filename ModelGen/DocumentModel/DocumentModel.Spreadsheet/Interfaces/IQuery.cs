namespace DocumentModel.Spreadsheet;

/// <summary>
/// Query.
/// </summary>
public interface IQuery // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// MDX Query String
  /// </summary>
  public String? Mdx { get ; set; }
  
  /// <summary>
  /// Tuples.
  /// </summary>
  public ITuples? Tuples { get ; set; }
  
}
