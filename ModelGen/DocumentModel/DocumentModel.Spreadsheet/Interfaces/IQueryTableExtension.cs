namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the QueryTableExtension Class.
/// </summary>
public interface IQueryTableExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Excel.IQueryTable? QueryTable { get ; set; }
  
}
