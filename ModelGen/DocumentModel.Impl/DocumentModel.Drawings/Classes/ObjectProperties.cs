namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ObjectProperties Class.
/// </summary>
public class ObjectPropertiesImpl: ModelElementImpl, ObjectProperties
{
  public DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// objectId, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// isActiveX, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? IsActiveX
  {
    get;
    set;
  }
  
  /// <summary>
  /// linkType, this property is only available in Office 2013 and later.
  /// </summary>
  public String? LinkType
  {
    get;
    set;
  }
  
}
