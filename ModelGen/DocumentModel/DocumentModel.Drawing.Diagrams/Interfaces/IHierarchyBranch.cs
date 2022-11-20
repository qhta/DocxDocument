namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Organization Chart Branch Style.
/// </summary>
public interface IHierarchyBranch // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Organization Chart Branch Style Value
  /// </summary>
  public HierarchyBranchStyleValues? Val { get ; set; }
  
}
