namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ObjectProperties Class.
/// </summary>
public partial class ObjectPropertiesImpl: ModelElementImpl, ObjectProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ObjectPropertiesImpl(): base() {}
  
  public ObjectPropertiesImpl(DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// objectId, this property is only available in Office 2013 and later.
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
  /// isActiveX, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? IsActiveX
  {
    get => (System.Boolean?)OpenXmlElement?.IsActiveX?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IsActiveX = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// linkType, this property is only available in Office 2013 and later.
  /// </summary>
  public String? LinkType
  {
    get => (System.String?)OpenXmlElement?.LinkType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LinkType = (System.String?)value;
    }
  }
  
}
