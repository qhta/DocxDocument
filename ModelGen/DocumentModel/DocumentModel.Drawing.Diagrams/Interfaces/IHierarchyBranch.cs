namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Organization Chart Branch Style.
/// </summary>
public interface IHierarchyBranch // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Organization Chart Branch Style Value
  /// </summary>
  public HierarchyBranchStyleValues? Val { get ; set; }
  
}
