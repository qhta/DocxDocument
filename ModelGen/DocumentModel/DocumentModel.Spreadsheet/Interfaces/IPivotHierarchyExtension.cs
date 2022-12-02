namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotHierarchyExtension Class.
/// </summary>
public interface IPivotHierarchyExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IPivotHierarchy? PivotHierarchy { get ; set; }
  
}
