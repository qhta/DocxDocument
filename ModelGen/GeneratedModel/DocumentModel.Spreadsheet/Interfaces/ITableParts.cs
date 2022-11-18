namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TableParts Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITablePart))]
public interface ITableParts // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
