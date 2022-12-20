namespace DocumentModel.WebExtensions;

/// <summary>
/// Defines the WebExtensionBinding Class.
/// </summary>
public partial class WebExtensionBindingImpl: ModelElementImpl, WebExtensionBinding
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public WebExtensionBindingImpl(): base() {}
  
  public WebExtensionBindingImpl(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
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
  /// type, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Type
  {
    get => (System.String?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (System.String?)value;
    }
  }
  
  /// <summary>
  /// appref, this property is only available in Office 2013 and later.
  /// </summary>
  public String? AppReference
  {
    get => (System.String?)OpenXmlElement?.AppReference?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AppReference = (System.String?)value;
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.WebExtensions.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
        if (item != null)
          return new DocumentModel.WebExtensions.OfficeArtExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.WebExtensions.OfficeArtExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
