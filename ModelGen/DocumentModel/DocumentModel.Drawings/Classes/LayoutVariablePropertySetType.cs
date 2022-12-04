namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LayoutVariablePropertySetType Class.
/// </summary>
public class LayoutVariablePropertySetType
{
  /// <summary>
  /// Diagram Direction.
  /// </summary>
  public virtual DirectionKind? Direction
  {
    get;
    set;
  }
  
  /// <summary>
  /// Organization Chart Branch Style.
  /// </summary>
  public virtual HierarchyBranchStyleKind? HierarchyBranch
  {
    get;
    set;
  }
  
  /// <summary>
  /// One by One Animation String.
  /// </summary>
  public virtual AnimateOneByOneKind? AnimateOneByOne
  {
    get;
    set;
  }
  
  /// <summary>
  /// Level Animation.
  /// </summary>
  public virtual AnimationLevelStringKind? AnimationLevel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Resize Style.
  /// </summary>
  public virtual ResizeHandlesStringKind? ResizeHandles
  {
    get;
    set;
  }
  
}
