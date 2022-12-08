namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextType Class.
/// </summary>
public class TextTypeImpl: ModelElementImpl, TextType
{
  public DocumentFormat.OpenXml.Wordprocessing.TextType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TextType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
