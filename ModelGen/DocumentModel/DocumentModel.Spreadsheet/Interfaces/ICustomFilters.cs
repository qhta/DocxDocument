namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Filters.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICustomFilter))]
public interface ICustomFilters // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// And
  /// </summary>
  public bool? And { get ; set; }
  
}
