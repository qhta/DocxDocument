namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ObjectLink Class.
/// </summary>
public class ObjectLinkImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.ObjectLink>, ObjectLink
{
  /// <summary>
  /// updateMode
  /// </summary>
  public ObjectUpdateMode? UpdateMode
  {
    get => (ObjectUpdateMode?)OpenXmlElement?.UpdateMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UpdateMode = (DocumentFormat.OpenXml.Wordprocessing.ObjectUpdateMode?)value;
    }
  }
  
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
