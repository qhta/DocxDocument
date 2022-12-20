namespace DocumentModel.Math;

/// <summary>
/// Text.
/// </summary>
public partial class TextImpl: ModelElementImpl, Text
{
  public DocumentFormat.OpenXml.Math.Text? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Text?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextImpl(): base() {}
  
  public TextImpl(DocumentFormat.OpenXml.Math.Text openXmlElement): base(openXmlElement)
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
