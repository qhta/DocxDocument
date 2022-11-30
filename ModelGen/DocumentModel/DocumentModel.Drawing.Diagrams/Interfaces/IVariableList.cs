namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Variable List.
/// </summary>
public interface IVariableList // : DocumentModel.Drawing.Diagrams.ILayoutVariablePropertySetType
{
  public System.Boolean? OrganizationChart { get ; set; }
  
  public System.Int32? MaxNumberOfChildren { get ; set; }
  
  public System.Int32? PreferredNumberOfChildren { get ; set; }
  
  public System.Boolean? BulletEnabled { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.DirectionKind? Direction { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.HierarchyBranchStyleKind? HierarchyBranch { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.AnimateOneByOneKind? AnimateOneByOne { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.AnimationLevelStringKind? AnimationLevel { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.ResizeHandlesStringKind? ResizeHandles { get ; set; }
  
}
