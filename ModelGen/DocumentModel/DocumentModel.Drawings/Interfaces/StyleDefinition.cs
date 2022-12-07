namespace DocumentModel.Drawings;

/// <summary>
/// Style Definition.
/// </summary>
public interface StyleDefinition
{
  public StyleDisplayCategories? StyleDisplayCategories { get ; set; }
  
  public Scene3D? Scene3D { get ; set; }
  
  public ExtensionList3? ExtensionList { get ; set; }
  
}
