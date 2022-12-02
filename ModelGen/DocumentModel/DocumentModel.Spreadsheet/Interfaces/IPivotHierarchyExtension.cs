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
  
  public DocumentModel.Spreadsheet.IPivotHierarchy? PivotHierarchy { get ; set; }
  
}
