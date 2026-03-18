namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Variable List.
/// </summary>
public class VariableList
{
  public bool? OrganizationChart { get; set; }
  public Int32? MaxNumberOfChildren { get; set; }
  public Int32? PreferredNumberOfChildren { get; set; }
  public bool? BulletEnabled { get; set; }
  public Direction? Direction { get; set; }
  public HierarchyBranchStyle? HierarchyBranch { get; set; }
  public AnimateOneByOne? AnimateOneByOne { get; set; }
  public AnimationLevelString? AnimationLevel { get; set; }
  public ResizeHandlesString? ResizeHandles { get; set; }
}