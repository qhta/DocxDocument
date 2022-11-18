namespace DocumentModel.Spreadsheet;

/// <summary>
/// Pivot Areas.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotArea))]
public interface IPivotAreas // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pivot Area Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
