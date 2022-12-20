namespace DocumentModel.WebExtensions.UI;

/// <summary>
/// Defines the WebExtensionTaskpane Class.
/// </summary>
public partial class WebExtensionTaskpaneImpl: ModelElementImpl, WebExtensionTaskpane
{
  public DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WebExtensionTaskpaneImpl(): base() {}
  
  public WebExtensionTaskpaneImpl(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// dockstate, this property is only available in Office 2013 and later.
  /// </summary>
  public String? DockState
  {
    get => (System.String?)OpenXmlElement?.DockState?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DockState = (System.String?)value;
    }
  }
  
  /// <summary>
  /// visibility, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Visibility
  {
    get => (System.Boolean?)OpenXmlElement?.Visibility?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Visibility = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// width, this property is only available in Office 2013 and later.
  /// </summary>
  public Double? Width
  {
    get => (System.Double?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// row, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Row
  {
    get => (System.UInt32?)OpenXmlElement?.Row?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Row = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// locked, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Locked
  {
    get => (System.Boolean?)OpenXmlElement?.Locked?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Locked = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// WebExtensionPartReference.
  /// </summary>
  public DocumentModel.WebExtensions.UI.WebExtensionPartReference? WebExtensionPartReference
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference>();
        if (item != null)
          return new DocumentModel.WebExtensions.UI.WebExtensionPartReferenceImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.WebExtensions.UI.WebExtensionPartReferenceImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.WebExtensions.UI.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtentionPane.OfficeArtExtensionList>();
        if (item != null)
          return new DocumentModel.WebExtensions.UI.OfficeArtExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtentionPane.OfficeArtExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.WebExtensions.UI.OfficeArtExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
