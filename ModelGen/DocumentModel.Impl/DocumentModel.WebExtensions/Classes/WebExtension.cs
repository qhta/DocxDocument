namespace DocumentModel.WebExtensions;

/// <summary>
/// Defines the WebExtension Class.
/// </summary>
public partial class WebExtensionImpl: ModelElementImpl, WebExtension
{
  public DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WebExtensionImpl(): base() {}
  
  public WebExtensionImpl(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public Boolean? Fronzen
  {
    get => (System.Boolean?)OpenXmlElement?.Fronzen?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Fronzen = (System.Boolean?)value;
    }
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
  /// frozen, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Frozen
  {
    get => (System.Boolean?)OpenXmlElement?.Frozen?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Frozen = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// WebExtensionStoreReference.
  /// </summary>
  public DocumentModel.WebExtensions.WebExtensionStoreReference? WebExtensionStoreReference
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>();
        if (item != null)
          return new DocumentModel.WebExtensions.WebExtensionStoreReferenceImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.WebExtensions.WebExtensionStoreReferenceImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// WebExtensionReferenceList.
  /// </summary>
  public DocumentModel.WebExtensions.WebExtensionReferenceList? WebExtensionReferenceList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList>();
        if (item != null)
          return new DocumentModel.WebExtensions.WebExtensionReferenceListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.WebExtensions.WebExtensionReferenceListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// WebExtensionPropertyBag.
  /// </summary>
  public DocumentModel.WebExtensions.WebExtensionPropertyBag? WebExtensionPropertyBag
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag>();
        if (item != null)
          return new DocumentModel.WebExtensions.WebExtensionPropertyBagImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.WebExtensions.WebExtensionPropertyBagImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// WebExtensionBindingList.
  /// </summary>
  public DocumentModel.WebExtensions.WebExtensionBindingList? WebExtensionBindingList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList>();
        if (item != null)
          return new DocumentModel.WebExtensions.WebExtensionBindingListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.WebExtensions.WebExtensionBindingListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Snapshot.
  /// </summary>
  public DocumentModel.WebExtensions.Snapshot? Snapshot
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot>();
        if (item != null)
          return new DocumentModel.WebExtensions.SnapshotImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.WebExtensions.SnapshotImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
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
  
  /// <summary>
  /// Gets the WebExtensionPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.WebExtensionPart? WebExtensionPart
  {
    get
    {
      if (OpenXmlElement?.WebExtensionPart != null)
        return new DocumentModel.Packaging.WebExtensionPartImpl(OpenXmlElement.WebExtensionPart);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
        if (value is DocumentModel.Packaging.WebExtensionPartImpl valueImpl)
          if (valueImpl.OpenXmlElement != null)
              OpenXmlElement.SetPart(valueImpl.OpenXmlElement);
    }
  }
  
}
