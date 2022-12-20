namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramStylePart
/// </summary>
public partial class DiagramStylePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DiagramStylePart
{
  public new DocumentFormat.OpenXml.Packaging.DiagramStylePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DiagramStylePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DiagramStylePartImpl(): base() {}
  
  public DiagramStylePartImpl(DocumentFormat.OpenXml.Packaging.DiagramStylePart openXmlElement): base(openXmlElement)
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
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.StyleDefinition? StyleDefinition
  {
    get
    {
      if (OpenXmlElement?.StyleDefinition != null)
        return new DocumentModel.Drawings.Diagrams.StyleDefinitionImpl(OpenXmlElement.StyleDefinition);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Drawings.Diagrams.StyleDefinitionImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.StyleDefinition = valueImpl.OpenXmlElement;
    }
  }
  
}
