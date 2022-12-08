namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ObjectEmbed Class.
/// </summary>
public class ObjectEmbedImpl: ModelElementImpl, ObjectEmbed
{
  public DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
  
  /// <summary>
  /// id
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// progId
  /// </summary>
  public String? ProgId
  {
    get;
    set;
  }
  
  /// <summary>
  /// shapeId
  /// </summary>
  public String? ShapeId
  {
    get;
    set;
  }
  
  /// <summary>
  /// fieldCodes
  /// </summary>
  public String? FieldCodes
  {
    get;
    set;
  }
  
}
