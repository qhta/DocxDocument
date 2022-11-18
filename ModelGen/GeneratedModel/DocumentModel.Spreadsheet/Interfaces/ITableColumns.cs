namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Columns.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITableColumn))]
public interface ITableColumns // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Column Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
