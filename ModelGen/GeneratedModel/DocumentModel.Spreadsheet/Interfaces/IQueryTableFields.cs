namespace DocumentModel.Spreadsheet;

/// <summary>
/// Query table fields.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IQueryTableField))]
public interface IQueryTableFields // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Column Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
