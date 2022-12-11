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
  
  public TextTypeImpl(): base() {}
  
  public TextTypeImpl(DocumentFormat.OpenXml.Wordprocessing.TextType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// space
  /// </summary>
  public SpaceProcessingMode? Space
  {
    get => (SpaceProcessingMode?)OpenXmlElement?.Space?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Space = (DocumentFormat.OpenXml.SpaceProcessingModeValues?)value;
    }
  }
  
}
