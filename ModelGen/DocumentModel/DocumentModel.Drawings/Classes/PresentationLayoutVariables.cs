namespace DocumentModel.Drawings;

/// <summary>
/// Presentation Layout Variables.
/// </summary>
public class PresentationLayoutVariables: DocumentModel.Drawings.LayoutVariablePropertySetType
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
