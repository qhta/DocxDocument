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
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.NumberingDefinitionsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the NumberingDefinitionsPart
  /// </summary>
  public ImagePart? ImageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Numbering? Numbering
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.NumberingDefinitionsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
