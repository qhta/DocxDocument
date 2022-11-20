namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFilters Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotFilter))]
public interface IPivotFilters // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pivot Filter Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
