namespace DocumentModel.Spreadsheet;

/// <summary>
/// Query.
/// </summary>
public interface IQuery // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// MDX Query String
  /// </summary>
  public System.String? Mdx { get ; set; }
  
  /// <summary>
  /// Tuples.
  /// </summary>
  public DocumentModel.Spreadsheet.ITuplesType? Tuples { get ; set; }
  
}
