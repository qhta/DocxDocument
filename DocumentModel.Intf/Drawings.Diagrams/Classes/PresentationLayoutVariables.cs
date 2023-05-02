namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Presentation Layout Variables.
/// </summary>
public class PresentationLayoutVariables: ModelElement
{
  public bool? OrganizationChart { get; set; }

  public Int32? MaxNumberOfChildren { get; set; }

  public Int32? PreferredNumberOfChildren { get; set; }

  public bool? BulletEnabled { get; set; }

  public DirectionKind? Direction { get; set; }

  public HierarchyBranchStyleKind? HierarchyBranch { get; set; }

  public AnimateOneByOneKind? AnimateOneByOne { get; set; }

  public AnimationLevelStringKind? AnimationLevel { get; set; }

  public ResizeHandlesStringKind? ResizeHandles { get; set; }
}