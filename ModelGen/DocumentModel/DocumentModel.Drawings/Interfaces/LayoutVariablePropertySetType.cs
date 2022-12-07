namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LayoutVariablePropertySetType Class.
/// </summary>
public interface LayoutVariablePropertySetType
{
  /// <summary>
  /// Diagram Direction.
  /// </summary>
  public DirectionKind? Direction { get ; set; }
  
  /// <summary>
  /// Organization Chart Branch Style.
  /// </summary>
  public HierarchyBranchStyleKind? HierarchyBranch { get ; set; }
  
  /// <summary>
  /// One by One Animation String.
  /// </summary>
  public AnimateOneByOneKind? AnimateOneByOne { get ; set; }
  
  /// <summary>
  /// Level Animation.
  /// </summary>
  public AnimationLevelStringKind? AnimationLevel { get ; set; }
  
  /// <summary>
  /// Shape Resize Style.
  /// </summary>
  public ResizeHandlesStringKind? ResizeHandles { get ; set; }
  
}
