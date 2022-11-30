namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotHierarchyExtension Class.
/// </summary>
public interface IPivotHierarchyExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2010.Excel.IPivotHierarchy? PivotHierarchy { get ; set; }
  
}
