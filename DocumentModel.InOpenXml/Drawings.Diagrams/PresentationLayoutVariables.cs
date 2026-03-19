namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Presentation Layout Variables.
/// </summary>
[OpenXmlType(typeof(DXDD.PresentationLayoutVariables))]
public class PresentationLayoutVariables: LayoutVariablePropertySetType
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