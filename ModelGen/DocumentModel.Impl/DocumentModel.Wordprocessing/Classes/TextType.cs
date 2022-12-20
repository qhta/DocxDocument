namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextType Class.
/// </summary>
public partial class TextTypeImpl: ModelElementImpl, TextType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.TextType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TextType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TextTypeImpl(): base() {}
  
  public TextTypeImpl(DocumentFormat.OpenXml.Wordprocessing.TextType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
