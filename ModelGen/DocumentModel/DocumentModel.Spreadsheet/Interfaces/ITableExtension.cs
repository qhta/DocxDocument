namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TableExtension Class.
/// </summary>
public interface ITableExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2010.Excel.ITable? Table { get ; set; }
  
}
