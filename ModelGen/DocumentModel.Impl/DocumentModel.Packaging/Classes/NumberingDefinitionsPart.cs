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
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the NumberingDefinitionsPart
  /// </summary>
  public ImagePart? ImageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Numbering? Numbering
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
