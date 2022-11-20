namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the RowFields Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IField))]
public interface IRowFields // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Repeated Items Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
