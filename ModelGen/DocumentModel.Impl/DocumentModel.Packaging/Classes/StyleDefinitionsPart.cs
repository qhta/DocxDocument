namespace DocumentModel.Packaging;

/// <summary>
/// Defines the StyleDefinitionsPart
/// </summary>
public class StyleDefinitionsPartImpl: DocumentModel.Packaging.StylesPartImpl, StyleDefinitionsPart
{
  public new DocumentFormat.OpenXml.Packaging.StyleDefinitionsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.StyleDefinitionsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
