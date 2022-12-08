namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ObjectLink Class.
/// </summary>
public class ObjectLinkImpl: ModelElementImpl, ObjectLink
{
  public DocumentFormat.OpenXml.Wordprocessing.ObjectLink? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ObjectLink?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  /// lockedField
  /// </summary>
  public Boolean? LockedField
  {
    get;
    set;
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
