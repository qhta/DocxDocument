namespace DocumentModel.Drawing;

/// <summary>
/// Presentation Layout Variables.
/// </summary>
public interface IPresentationLayoutVariables // : DocumentModel.Drawing.ILayoutVariablePropertySetType
{
  public Boolean? OrganizationChart { get ; set; }
  
  public Int32? MaxNumberOfChildren { get ; set; }
  
  public Int32? PreferredNumberOfChildren { get ; set; }
  
  public Boolean? BulletEnabled { get ; set; }
  
  public DirectionKind? Direction { get ; set; }
  
  public HierarchyBranchStyleKind? HierarchyBranch { get ; set; }
  
  public AnimateOneByOneKind? AnimateOneByOne { get ; set; }
  
  public AnimationLevelStringKind? AnimationLevel { get ; set; }
  
  public ResizeHandlesStringKind? ResizeHandles { get ; set; }
  
}
