namespace DocumentModel.Packaging;

/// <summary>
/// Defines the StyleDefinitionsPart
/// </summary>
public partial class StyleDefinitionsPartImpl: DocumentModel.Packaging.StylesPartImpl, StyleDefinitionsPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.StyleDefinitionsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.StyleDefinitionsPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public StyleDefinitionsPartImpl(): base() {}
  
  public StyleDefinitionsPartImpl(DocumentFormat.OpenXml.Packaging.StyleDefinitionsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
