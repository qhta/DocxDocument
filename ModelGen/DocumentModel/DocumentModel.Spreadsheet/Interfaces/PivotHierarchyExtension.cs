namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotHierarchyExtension Class.
/// </summary>
public interface PivotHierarchyExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public PivotHierarchy? PivotHierarchy { get ; set; }
  
}
