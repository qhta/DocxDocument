namespace DocumentModel.Drawings;

/// <summary>
/// Layout Definition.
/// </summary>
public class LayoutDefinitionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition>, LayoutDefinition
{
  public CategoryList? CategoryList
  {
    get;
    set;
  }
  
  public SampleData? SampleData
  {
    get;
    set;
  }
  
  public StyleData? StyleData
  {
    get;
    set;
  }
  
  public ColorData? ColorData
  {
    get;
    set;
  }
  
  public LayoutNode? LayoutNode
  {
    get;
    set;
  }
  
  public DiagramDefinitionExtensionList? DiagramDefinitionExtensionList
  {
    get;
    set;
  }
  
}
