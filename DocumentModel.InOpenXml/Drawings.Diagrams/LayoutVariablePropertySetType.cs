namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the LayoutVariablePropertySetType Class.
/// </summary>
[OpenXmlType(typeof(DXDD.LayoutVariablePropertySetType))]
/// <summary>
/// Represents the Layout Variable Property Set Type.
/// </summary>
public class LayoutVariablePropertySetType: ModelElement<DXDD.LayoutVariablePropertySetType>
{
  /// <summary>
  ///   Show Organization Chart User class.
  /// </summary>
  public bool? OrganizationChart { get; set; }
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
  public bool? BulletEnabled { get; set; }
  /// <summary>
  ///   Diagram Direction.
  /// </summary>
  public Direction? Direction { get; set; }
  /// <summary>
  ///   Organization Chart Branch Style.
  /// </summary>
  public HierarchyBranchStyle? HierarchyBranch { get; set; }
  /// <summary>
  ///   One by One Animation String.
  /// </summary>
  public AnimateOneByOne? AnimateOneByOne { get; set; }
  /// <summary>
  ///   Level Animation.
  /// </summary>
  public AnimationLevelString? AnimationLevel { get; set; }
  /// <summary>
  ///   Shape Resize Style.
  /// </summary>
  public ResizeHandlesString? ResizeHandles { get; set; }
}
