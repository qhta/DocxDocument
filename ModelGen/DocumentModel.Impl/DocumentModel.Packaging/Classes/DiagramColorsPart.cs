namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramColorsPart
/// </summary>
public class DiagramColorsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DiagramColorsPart
{
  public new DocumentFormat.OpenXml.Packaging.DiagramColorsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DiagramColorsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DiagramColorsPartImpl(): base() {}
  
  public DiagramColorsPartImpl(DocumentFormat.OpenXml.Packaging.DiagramColorsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ColorsDefinition? ColorsDefinition
  {
    get
    {
      if (OpenXmlElement?.ColorsDefinition != null)
        return new DocumentModel.Drawings.Diagrams.ColorsDefinitionImpl(OpenXmlElement.ColorsDefinition);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Drawings.Diagrams.ColorsDefinitionImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.ColorsDefinition = valueImpl.OpenXmlElement;
    }
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.DiagramColorsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.DiagramColorsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
