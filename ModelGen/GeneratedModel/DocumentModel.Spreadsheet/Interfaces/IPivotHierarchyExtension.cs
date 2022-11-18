namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotHierarchyExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IPivotHierarchy))]
public interface IPivotHierarchyExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
