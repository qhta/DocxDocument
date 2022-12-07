namespace DocumentModel.Drawings;

/// <summary>
/// Style Definition.
/// </summary>
public class StyleDefinitionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition>, StyleDefinition
{
  public StyleDisplayCategories? StyleDisplayCategories
  {
    get;
    set;
  }
  
  public Scene3D? Scene3D
  {
    get;
    set;
  }
  
  public ExtensionList3? ExtensionList
  {
    get;
    set;
  }
  
}
