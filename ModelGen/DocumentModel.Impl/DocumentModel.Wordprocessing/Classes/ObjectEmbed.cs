namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ObjectEmbed Class.
/// </summary>
public class ObjectEmbedImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed>, ObjectEmbed
{
  /// <summary>
  /// drawAspect
  /// </summary>
  public ObjectDrawAspect? drawAspect
  {
    get => (ObjectDrawAspect?)OpenXmlElement?.drawAspect?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.drawAspect = (DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect?)value;
    }
  }
  
}
