namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotHierarchies Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotHierarchy))]
public interface IPivotHierarchies // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// OLAP Hierarchy Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
