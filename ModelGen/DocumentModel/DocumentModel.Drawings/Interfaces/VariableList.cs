namespace DocumentModel.Drawings;

/// <summary>
/// Variable List.
/// </summary>
public interface VariableList
{
  public DirectionKind? Direction { get ; set; }
  
  public HierarchyBranchStyleKind? HierarchyBranch { get ; set; }
  
  public AnimateOneByOneKind? AnimateOneByOne { get ; set; }
  
  public AnimationLevelStringKind? AnimationLevel { get ; set; }
  
  public ResizeHandlesStringKind? ResizeHandles { get ; set; }
  
}
