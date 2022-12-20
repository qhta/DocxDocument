namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ObjectLink Class.
/// </summary>
public partial class ObjectLinkImpl: ModelElementImpl, ObjectLink
{
  public DocumentFormat.OpenXml.Wordprocessing.ObjectLink? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ObjectLink?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ObjectLinkImpl(): base() {}
  
  public ObjectLinkImpl(DocumentFormat.OpenXml.Wordprocessing.ObjectLink openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// updateMode
  /// </summary>
  public DocumentModel.Wordprocessing.ObjectUpdateMode? UpdateMode
  {
    get => (DocumentModel.Wordprocessing.ObjectUpdateMode?)OpenXmlElement?.UpdateMode?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.LockedField?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LockedField = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// drawAspect
  /// </summary>
  public DocumentModel.Wordprocessing.ObjectDrawAspect? drawAspect
  {
    get => (DocumentModel.Wordprocessing.ObjectDrawAspect?)OpenXmlElement?.drawAspect?.Value;
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
    get => (System.String?)OpenXmlElement?.Id?.Value;
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
    get => (System.String?)OpenXmlElement?.ProgId?.Value;
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
    get => (System.String?)OpenXmlElement?.ShapeId?.Value;
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
    get => (System.String?)OpenXmlElement?.FieldCodes?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FieldCodes = (System.String?)value;
    }
  }
  
}
