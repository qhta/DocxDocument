namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColumnFields Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IField))]
public interface IColumnFields // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Repeated Items Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
