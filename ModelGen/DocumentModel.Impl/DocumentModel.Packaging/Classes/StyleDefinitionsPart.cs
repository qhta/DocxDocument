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
  
  public StyleDefinitionsPartImpl(): base() {}
  
  public StyleDefinitionsPartImpl(DocumentFormat.OpenXml.Packaging.StyleDefinitionsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.StyleDefinitionsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.StyleDefinitionsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
