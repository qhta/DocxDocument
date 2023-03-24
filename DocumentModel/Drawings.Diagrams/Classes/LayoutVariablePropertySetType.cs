namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LayoutVariablePropertySetType Class.
/// </summary>
public class LayoutVariablePropertySetType: ModelElement
{
  /// <summary>
  ///   Show Organization Chart User Interface.
  /// </summary>
  public Boolean? OrganizationChart { get; set; }

  /// <summary>
  ///   Maximum Children.
  /// </summary>
  public Int32? MaxNumberOfChildren { get; set; }

  /// <summary>
  ///   Preferred Number of Children.
  /// </summary>
  public Int32? PreferredNumberOfChildren { get; set; }

  /// <summary>
  ///   Show Insert Bullet.
  /// </summary>
  public Boolean? BulletEnabled { get; set; }

  /// <summary>
  ///   Diagram Direction.
  /// </summary>
  public DirectionKind? Direction { get; set; }

  /// <summary>
  ///   Organization Chart Branch Style.
  /// </summary>
  public HierarchyBranchStyleKind? HierarchyBranch { get; set; }

  /// <summary>
  ///   One by One Animation String.
  /// </summary>
  public AnimateOneByOneKind? AnimateOneByOne { get; set; }

  /// <summary>
  ///   Level Animation.
  /// </summary>
  public AnimationLevelStringKind? AnimationLevel { get; set; }

  /// <summary>
  ///   Shape Resize Style.
  /// </summary>
  public ResizeHandlesStringKind? ResizeHandles { get; set; }
}