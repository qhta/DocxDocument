namespace DocumentModel.Packaging;

/// <summary>
/// Defines the NumberingDefinitionsPart
/// </summary>
public class NumberingDefinitionsPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, NumberingDefinitionsPart
{
  /// <summary>
  /// Gets the ImageParts of the NumberingDefinitionsPart
  /// </summary>
  public OpenXmlPartContainer? ImageParts
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
  
}
