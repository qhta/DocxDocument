namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColumnItems Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRowItem))]
public interface IColumnItems // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Column Item Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
