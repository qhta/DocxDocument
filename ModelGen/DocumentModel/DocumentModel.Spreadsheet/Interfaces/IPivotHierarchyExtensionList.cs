namespace DocumentModel.Spreadsheet;

/// <summary>
/// Future Feature Data Storage Area.
/// </summary>
public interface IPivotHierarchyExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IPivotHierarchyExtension>? PivotHierarchyExtensions { get ; set; }
  
}
