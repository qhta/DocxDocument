namespace DocumentModel.Spreadsheet;

/// <summary>
/// Row.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExternalCell))]
public interface IExternalRow // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Row
  /// </summary>
  public uint? RowIndex { get ; set; }
  
}
