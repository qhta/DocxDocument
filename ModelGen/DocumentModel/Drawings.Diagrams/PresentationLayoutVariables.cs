namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Presentation Layout Variables.
/// </summary>
public partial class PresentationLayoutVariables
{
  public Boolean? OrganizationChart { get; set; }
  
  public Int32? MaxNumberOfChildren { get; set; }
  
  public Int32? PreferredNumberOfChildren { get; set; }
  
  public Boolean? BulletEnabled { get; set; }
  
  public DMDD.DirectionKind? Direction { get; set; }
  
  public DMDD.HierarchyBranchStyleKind? HierarchyBranch { get; set; }
  
  public DMDD.AnimateOneByOneKind? AnimateOneByOne { get; set; }
  
  public DMDD.AnimationLevelStringKind? AnimationLevel { get; set; }
  
  public DMDD.ResizeHandlesStringKind? ResizeHandles { get; set; }
  
}
