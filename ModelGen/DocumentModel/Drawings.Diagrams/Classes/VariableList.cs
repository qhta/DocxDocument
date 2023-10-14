namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Variable List.
/// </summary>
public partial class VariableList
{
  public Boolean? OrganizationChart { get; set; }
  
  public Int32? MaxNumberOfChildren { get; set; }
  
  public Int32? PreferredNumberOfChildren { get; set; }
  
  public Boolean? BulletEnabled { get; set; }
  
  public DocumentModel.Drawings.Diagrams.DirectionKind? Direction { get; set; }
  
  public DocumentModel.Drawings.Diagrams.HierarchyBranchStyleKind? HierarchyBranch { get; set; }
  
  public DocumentModel.Drawings.Diagrams.AnimateOneByOneKind? AnimateOneByOne { get; set; }
  
  public DocumentModel.Drawings.Diagrams.AnimationLevelStringKind? AnimationLevel { get; set; }
  
  public DocumentModel.Drawings.Diagrams.ResizeHandlesStringKind? ResizeHandles { get; set; }
  
}
