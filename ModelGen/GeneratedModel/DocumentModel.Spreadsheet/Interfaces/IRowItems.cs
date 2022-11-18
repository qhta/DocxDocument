namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the RowItems Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRowItem))]
public interface IRowItems // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Items in a Row Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
