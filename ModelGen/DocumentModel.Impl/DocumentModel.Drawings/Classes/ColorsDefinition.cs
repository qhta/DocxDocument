namespace DocumentModel.Drawings;

/// <summary>
/// Color Transform Definitions.
/// </summary>
public class ColorsDefinitionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition>, ColorsDefinition
{
  public ColorTransformCategories? ColorTransformCategories
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
