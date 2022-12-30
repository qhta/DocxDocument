namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the LayoutVariablePropertySetType Class.
/// </summary>
public partial class LayoutVariablePropertySetType
{
  /// <summary>
  /// Show Organization Chart User Interface.
  /// </summary>
  public Boolean? OrganizationChart { get; set; }
  
  /// <summary>
  /// Maximum Children.
  /// </summary>
  public Int32? MaxNumberOfChildren { get; set; }
  
  /// <summary>
  /// Preferred Number of Children.
  /// </summary>
  public Int32? PreferredNumberOfChildren { get; set; }
  
  /// <summary>
  /// Show Insert Bullet.
  /// </summary>
  public Boolean? BulletEnabled { get; set; }
  
  /// <summary>
  /// Diagram Direction.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.DirectionKind? Direction { get; set; }
  
  /// <summary>
  /// Organization Chart Branch Style.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.HierarchyBranchStyleKind? HierarchyBranch { get; set; }
  
  /// <summary>
  /// One by One Animation String.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.AnimateOneByOneKind? AnimateOneByOne { get; set; }
  
  /// <summary>
  /// Level Animation.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.AnimationLevelStringKind? AnimationLevel { get; set; }
  
  /// <summary>
  /// Shape Resize Style.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ResizeHandlesStringKind? ResizeHandles { get; set; }
  
}
