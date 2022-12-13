namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LayoutVariablePropertySetType Class.
/// </summary>
public interface LayoutVariablePropertySetType
{
  /// <summary>
  /// Show Organization Chart User Interface.
  /// </summary>
  public Boolean? OrganizationChart { get ; set; }
  
  /// <summary>
  /// Maximum Children.
  /// </summary>
  public Int32? MaxNumberOfChildren { get ; set; }
  
  /// <summary>
  /// Preferred Number of Children.
  /// </summary>
  public Int32? PreferredNumberOfChildren { get ; set; }
  
  /// <summary>
  /// Show Insert Bullet.
  /// </summary>
  public Boolean? BulletEnabled { get ; set; }
  
  /// <summary>
  /// Diagram Direction.
  /// </summary>
  public DocumentModel.Drawings.DirectionKind? Direction { get ; set; }
  
  /// <summary>
  /// Organization Chart Branch Style.
  /// </summary>
  public DocumentModel.Drawings.HierarchyBranchStyleKind? HierarchyBranch { get ; set; }
  
  /// <summary>
  /// One by One Animation String.
  /// </summary>
  public DocumentModel.Drawings.AnimateOneByOneKind? AnimateOneByOne { get ; set; }
  
  /// <summary>
  /// Level Animation.
  /// </summary>
  public DocumentModel.Drawings.AnimationLevelStringKind? AnimationLevel { get ; set; }
  
  /// <summary>
  /// Shape Resize Style.
  /// </summary>
  public DocumentModel.Drawings.ResizeHandlesStringKind? ResizeHandles { get ; set; }
  
}
