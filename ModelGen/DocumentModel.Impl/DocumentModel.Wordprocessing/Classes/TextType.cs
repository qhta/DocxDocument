namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextType Class.
/// </summary>
public class TextTypeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.TextType>, TextType
{
  /// <summary>
  /// space
  /// </summary>
  public DocumentModel.SpaceProcessingMode? Space
  {
    get => (DocumentModel.SpaceProcessingMode?)OpenXmlElement?.Space?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Space = (DocumentFormat.OpenXml.SpaceProcessingModeValues?)value;
    }
  }
  
}
