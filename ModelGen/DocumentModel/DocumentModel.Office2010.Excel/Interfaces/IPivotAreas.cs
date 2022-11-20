namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotAreas Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotArea))]
public interface IPivotAreas // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pivot Area Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
