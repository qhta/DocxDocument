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
  
  public ObjectEmbedImpl(): base() {}
  
  public ObjectEmbedImpl(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// progId
  /// </summary>
  public String? ProgId
  {
    get => (String?)OpenXmlElement?.ProgId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ProgId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// shapeId
  /// </summary>
  public String? ShapeId
  {
    get => (String?)OpenXmlElement?.ShapeId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShapeId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// fieldCodes
  /// </summary>
  public String? FieldCodes
  {
    get => (String?)OpenXmlElement?.FieldCodes?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FieldCodes = (System.String?)value;
    }
  }
  
}
