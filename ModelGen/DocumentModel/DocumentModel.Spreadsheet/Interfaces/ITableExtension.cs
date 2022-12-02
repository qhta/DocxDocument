namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TableExtension Class.
/// </summary>
public interface ITableExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public ITable? Table { get ; set; }
  
}
