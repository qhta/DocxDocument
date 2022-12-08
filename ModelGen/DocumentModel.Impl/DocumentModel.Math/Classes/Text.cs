namespace DocumentModel.Math;

/// <summary>
/// Text.
/// </summary>
public class TextImpl: ModelElementImpl, Text
{
  public DocumentFormat.OpenXml.Math.Text? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Text?)_OpenXmlElement;
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
