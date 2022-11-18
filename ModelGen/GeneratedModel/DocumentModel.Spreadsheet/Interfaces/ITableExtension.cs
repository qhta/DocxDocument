namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TableExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ITable))]
public interface ITableExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
