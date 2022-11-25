namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Defines the LayoutVariablePropertySetType Class.
/// </summary>
public interface ILayoutVariablePropertySetType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Show Organization Chart User Interface.
  /// </summary>
  public System.Boolean? OrganizationChart { get ; set; }
  
  /// <summary>
  /// Maximum Children.
  /// </summary>
  public System.Int32? MaxNumberOfChildren { get ; set; }
  
  /// <summary>
  /// Preferred Number of Children.
  /// </summary>
  public System.Int32? PreferredNumberOfChildren { get ; set; }
  
  /// <summary>
  /// Show Insert Bullet.
  /// </summary>
  public System.Boolean? BulletEnabled { get ; set; }
  
  /// <summary>
  /// Diagram Direction.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.DirectionKind? Direction { get ; set; }
  
  /// <summary>
  /// Organization Chart Branch Style.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.HierarchyBranchStyleKind? HierarchyBranch { get ; set; }
  
  /// <summary>
  /// One by One Animation String.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.AnimateOneByOneKind? AnimateOneByOne { get ; set; }
  
  /// <summary>
  /// Level Animation.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.AnimationLevelStringKind? AnimationLevel { get ; set; }
  
  /// <summary>
  /// Shape Resize Style.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.ResizeHandlesStringKind? ResizeHandles { get ; set; }
  
}
