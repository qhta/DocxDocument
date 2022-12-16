namespace DocumentModel.Packaging;

/// <summary>
/// Defines the NumberingDefinitionsPart
/// </summary>
public class NumberingDefinitionsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, NumberingDefinitionsPart
{
  public new DocumentFormat.OpenXml.Packaging.NumberingDefinitionsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.NumberingDefinitionsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumberingDefinitionsPartImpl(): base() {}
  
  public NumberingDefinitionsPartImpl(DocumentFormat.OpenXml.Packaging.NumberingDefinitionsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.NumberingDefinitionsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the NumberingDefinitionsPart
  /// </summary>
  public DocumentModel.Packaging.ImagePart? ImageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Numbering? Numbering
  {
    get
    {
      if (OpenXmlElement?.Numbering != null)
        return new DocumentModel.Wordprocessing.NumberingImpl(OpenXmlElement.Numbering);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.NumberingImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.Numbering = valueImpl.OpenXmlElement;
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.NumberingDefinitionsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
