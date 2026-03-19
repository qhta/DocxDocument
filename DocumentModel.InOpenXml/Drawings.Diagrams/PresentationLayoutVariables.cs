namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Presentation Layout Variables.
/// </summary>
[OpenXmlType(typeof(DXDD.PresentationLayoutVariables))]
/// <summary>
/// Represents the Presentation Layout Variables.
/// </summary>
public class PresentationLayoutVariables: LayoutVariablePropertySetType
{
  /// <summary>
  /// Organization Chart.
  /// </summary>
  public bool? OrganizationChart { get; set; }
  /// <summary>
  /// Max Number Of Children.
  /// </summary>
  public Int32? MaxNumberOfChildren { get; set; }
  /// <summary>
  /// Preferred Number Of Children.
  /// </summary>
  public Int32? PreferredNumberOfChildren { get; set; }
  /// <summary>
  /// Bullet Enabled.
  /// </summary>
  public bool? BulletEnabled { get; set; }
  /// <summary>
  /// Direction.
  /// </summary>
  public Direction? Direction { get; set; }
  /// <summary>
  /// Hierarchy Branch.
  /// </summary>
  public HierarchyBranchStyle? HierarchyBranch { get; set; }
  /// <summary>
  /// Animate One By One.
  /// </summary>
  public AnimateOneByOne? AnimateOneByOne { get; set; }
  /// <summary>
  /// Animation Level.
  /// </summary>
  public AnimationLevelString? AnimationLevel { get; set; }
  /// <summary>
  /// Resize Handles.
  /// </summary>
  public ResizeHandlesString? ResizeHandles { get; set; }
}

