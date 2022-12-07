namespace DocumentModel.Drawings;

/// <summary>
/// Presentation Layout Variables.
/// </summary>
public interface PresentationLayoutVariables
{
  public DirectionKind? Direction { get ; set; }
  
  public HierarchyBranchStyleKind? HierarchyBranch { get ; set; }
  
  public AnimateOneByOneKind? AnimateOneByOne { get ; set; }
  
  public AnimationLevelStringKind? AnimationLevel { get ; set; }
  
  public ResizeHandlesStringKind? ResizeHandles { get ; set; }
  
}
