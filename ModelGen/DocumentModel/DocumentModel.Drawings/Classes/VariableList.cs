namespace DocumentModel.Drawings;

/// <summary>
/// Variable List.
/// </summary>
public class VariableList: DocumentModel.Drawings.LayoutVariablePropertySetType
{
  public override DirectionKind? Direction
  {
    get;
    set;
  }
  
  public override HierarchyBranchStyleKind? HierarchyBranch
  {
    get;
    set;
  }
  
  public override AnimateOneByOneKind? AnimateOneByOne
  {
    get;
    set;
  }
  
  public override AnimationLevelStringKind? AnimationLevel
  {
    get;
    set;
  }
  
  public override ResizeHandlesStringKind? ResizeHandles
  {
    get;
    set;
  }
  
}
