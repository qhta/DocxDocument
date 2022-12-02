namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the QueryTableExtension Class.
/// </summary>
public interface IQueryTableExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IQueryTable? QueryTable { get ; set; }
  
}
