namespace DocumentModel.Drawing.Diagrams;

public interface IPresentationLayoutVariables // : DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType
{
  public IOrganizationChart? OrganizationChart { get ; set; }

  public IMaxNumberOfChildren? MaxNumberOfChildren { get ; set; }

  public IPreferredNumberOfChildren? PreferredNumberOfChildren { get ; set; }

  public IBulletEnabled? BulletEnabled { get ; set; }

  public IDirection? Direction { get ; set; }

  public IHierarchyBranch? HierarchyBranch { get ; set; }

  public IAnimateOneByOne? AnimateOneByOne { get ; set; }

  public IAnimationLevel? AnimationLevel { get ; set; }

  public IResizeHandles? ResizeHandles { get ; set; }

}
