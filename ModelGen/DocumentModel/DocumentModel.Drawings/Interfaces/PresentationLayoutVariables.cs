namespace DocumentModel.Drawings;

/// <summary>
/// Presentation Layout Variables.
/// </summary>
public interface PresentationLayoutVariables
{
  public Boolean? OrganizationChart { get ; set; }
  
  public Int32? MaxNumberOfChildren { get ; set; }
  
  public Int32? PreferredNumberOfChildren { get ; set; }
  
  public Boolean? BulletEnabled { get ; set; }
  
  public DocumentModel.Drawings.DirectionKind? Direction { get ; set; }
  
  public DocumentModel.Drawings.HierarchyBranchStyleKind? HierarchyBranch { get ; set; }
  
  public DocumentModel.Drawings.AnimateOneByOneKind? AnimateOneByOne { get ; set; }
  
  public DocumentModel.Drawings.AnimationLevelStringKind? AnimationLevel { get ; set; }
  
  public DocumentModel.Drawings.ResizeHandlesStringKind? ResizeHandles { get ; set; }
  
}
