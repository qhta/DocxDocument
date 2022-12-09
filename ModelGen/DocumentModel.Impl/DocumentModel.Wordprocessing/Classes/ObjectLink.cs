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
    get => (Boolean?)OpenXmlElement?.LockedField?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LockedField = (System.Boolean?)value;
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
