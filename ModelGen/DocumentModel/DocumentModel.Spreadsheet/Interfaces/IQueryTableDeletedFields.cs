namespace DocumentModel.Spreadsheet;

/// <summary>
/// Deleted Fields.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDeletedField))]
public interface IQueryTableDeletedFields // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Deleted Fields Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
