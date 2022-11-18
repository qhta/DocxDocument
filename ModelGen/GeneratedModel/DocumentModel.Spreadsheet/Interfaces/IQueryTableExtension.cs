namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the QueryTableExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IQueryTable))]
public interface IQueryTableExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
