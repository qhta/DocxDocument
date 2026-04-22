namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class LayoutVariablePropertySetType<T> 
{
  public bool ShouldSerializeOrganizationChart() => OrganizationChart is not null;
  public bool ShouldSerializeMaxNumberOfChildren() => MaxNumberOfChildren is not null;
  public bool ShouldSerializePreferredNumberOfChildren() => PreferredNumberOfChildren is not null;
  public bool ShouldSerializeBulletEnabled() => BulletEnabled is not null;
  public bool ShouldSerializeDirection() => Direction is not null;
  public bool ShouldSerializeHierarchyBranch() => HierarchyBranch is not null;
  public bool ShouldSerializeAnimateOneByOne() => AnimateOneByOne is not null;
  public bool ShouldSerializeAnimationLevel() => AnimationLevel is not null;
  public bool ShouldSerializeResizeHandles() => ResizeHandles is not null;
}
