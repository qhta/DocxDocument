namespace DocumentModel.Spreadsheet;

/// <summary>
/// Query.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITuples))]
public interface IQuery // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// MDX Query String
  /// </summary>
  public string? Mdx { get ; set; }
  
  /// <summary>
  /// Tuples.
  /// </summary>
  public ITuples? Tuples { get ; set; }
  
}
