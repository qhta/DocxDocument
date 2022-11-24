namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Defines the LayoutVariablePropertySetType Class.
/// </summary>
public interface ILayoutVariablePropertySetType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Show Organization Chart User Interface.
  /// </summary>
  public IOrganizationChart? OrganizationChart { get ; set; }
  
  /// <summary>
  /// Maximum Children.
  /// </summary>
  public IMaxNumberOfChildren? MaxNumberOfChildren { get ; set; }
  
  /// <summary>
  /// Preferred Number of Children.
  /// </summary>
  public IPreferredNumberOfChildren? PreferredNumberOfChildren { get ; set; }
  
  /// <summary>
  /// Show Insert Bullet.
  /// </summary>
  public IBulletEnabled? BulletEnabled { get ; set; }
  
  /// <summary>
  /// Diagram Direction.
  /// </summary>
  public IDirection? Direction { get ; set; }
  
  /// <summary>
  /// Organization Chart Branch Style.
  /// </summary>
  public IHierarchyBranch? HierarchyBranch { get ; set; }
  
  /// <summary>
  /// One by One Animation String.
  /// </summary>
  public IAnimateOneByOne? AnimateOneByOne { get ; set; }
  
  /// <summary>
  /// Level Animation.
  /// </summary>
  public IAnimationLevel? AnimationLevel { get ; set; }
  
  /// <summary>
  /// Shape Resize Style.
  /// </summary>
  public IResizeHandles? ResizeHandles { get ; set; }
  
}
