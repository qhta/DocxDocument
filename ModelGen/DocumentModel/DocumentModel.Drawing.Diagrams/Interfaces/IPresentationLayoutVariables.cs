namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Presentation Layout Variables.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IAnimationLevel))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IAnimateOneByOne))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IBulletEnabled))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IMaxNumberOfChildren))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IPreferredNumberOfChildren))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IDirection))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IHierarchyBranch))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IOrganizationChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IResizeHandles))]
public interface IPresentationLayoutVariables // : DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType
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
