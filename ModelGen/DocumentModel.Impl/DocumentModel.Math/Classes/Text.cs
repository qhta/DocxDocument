namespace DocumentModel.Math;

/// <summary>
/// Text.
/// </summary>
public class TextImpl: ModelElement<DocumentFormat.OpenXml.Math.Text>, Text
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
