namespace DocumentModel.Drawing;

/// <summary>
/// Presentation Layout Variables.
/// </summary>
public interface IPresentationLayoutVariables // : DocumentModel.Drawing.ILayoutVariablePropertySetType
{
  public System.Boolean? OrganizationChart { get ; set; }
  
  public System.Int32? MaxNumberOfChildren { get ; set; }
  
  public System.Int32? PreferredNumberOfChildren { get ; set; }
  
  public System.Boolean? BulletEnabled { get ; set; }
  
  public DocumentModel.Drawing.DirectionKind? Direction { get ; set; }
  
  public DocumentModel.Drawing.HierarchyBranchStyleKind? HierarchyBranch { get ; set; }
  
  public DocumentModel.Drawing.AnimateOneByOneKind? AnimateOneByOne { get ; set; }
  
  public DocumentModel.Drawing.AnimationLevelStringKind? AnimationLevel { get ; set; }
  
  public DocumentModel.Drawing.ResizeHandlesStringKind? ResizeHandles { get ; set; }
  
}
