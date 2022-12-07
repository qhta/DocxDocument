namespace DocumentModel.Drawings;

/// <summary>
/// Layout Definition.
/// </summary>
public interface LayoutDefinition
{
  public CategoryList? CategoryList { get ; set; }
  
  public SampleData? SampleData { get ; set; }
  
  public StyleData? StyleData { get ; set; }
  
  public ColorData? ColorData { get ; set; }
  
  public LayoutNode? LayoutNode { get ; set; }
  
  public DiagramDefinitionExtensionList? DiagramDefinitionExtensionList { get ; set; }
  
}
