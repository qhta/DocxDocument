namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtension Class.
/// </summary>
public static class WebExtensionConverter
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public static Boolean? GetFronzen(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement)
  {
    return openXmlElement?.Fronzen?.Value;
  }
  
  public static void SetFronzen(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Fronzen = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Fronzen = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// frozen, this property is only available in Office 2013 and later.
  /// </summary>
  public static Boolean? GetFrozen(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement)
  {
    return openXmlElement?.Frozen?.Value;
  }
  
  public static void SetFrozen(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Frozen = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Frozen = null;
  }
  
  /// <summary>
  /// WebExtensionStoreReference.
  /// </summary>
  public static DocumentModel.WebExtensions.WebExtensionStoreReference? GetWebExtensionStoreReference(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.WebExtensions.WebExtensionStoreReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetWebExtensionStoreReference(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement, DocumentModel.WebExtensions.WebExtensionStoreReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.WebExtensions.WebExtensionStoreReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// WebExtensionReferenceList.
  /// </summary>
  public static DocumentModel.WebExtensions.WebExtensionReferenceList? GetWebExtensionReferenceList(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.WebExtensions.WebExtensionReferenceListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetWebExtensionReferenceList(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement, DocumentModel.WebExtensions.WebExtensionReferenceList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.WebExtensions.WebExtensionReferenceListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// WebExtensionPropertyBag.
  /// </summary>
  public static DocumentModel.WebExtensions.WebExtensionPropertyBag? GetWebExtensionPropertyBag(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag>();
    if (itemElement != null)
      return DocumentModel.OpenXml.WebExtensions.WebExtensionPropertyBagConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetWebExtensionPropertyBag(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement, DocumentModel.WebExtensions.WebExtensionPropertyBag? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.WebExtensions.WebExtensionPropertyBagConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// WebExtensionBindingList.
  /// </summary>
  public static DocumentModel.WebExtensions.WebExtensionBindingList? GetWebExtensionBindingList(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.WebExtensions.WebExtensionBindingListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetWebExtensionBindingList(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement, DocumentModel.WebExtensions.WebExtensionBindingList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.WebExtensions.WebExtensionBindingListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Snapshot.
  /// </summary>
  public static DocumentModel.WebExtensions.Snapshot? GetSnapshot(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot>();
    if (itemElement != null)
      return DocumentModel.OpenXml.WebExtensions.SnapshotConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSnapshot(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement, DocumentModel.WebExtensions.Snapshot? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.WebExtensions.SnapshotConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public static DocumentModel.WebExtensions.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.WebExtensions.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement, DocumentModel.WebExtensions.OfficeArtExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.WebExtensions.OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.WebExtensions.WebExtension? CreateModelElement(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.WebExtension();
      value.Fronzen = GetFronzen(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.Frozen = GetFrozen(openXmlElement);
      value.WebExtensionStoreReference = GetWebExtensionStoreReference(openXmlElement);
      value.WebExtensionReferenceList = GetWebExtensionReferenceList(openXmlElement);
      value.WebExtensionPropertyBag = GetWebExtensionPropertyBag(openXmlElement);
      value.WebExtensionBindingList = GetWebExtensionBindingList(openXmlElement);
      value.Snapshot = GetSnapshot(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.WebExtensions.WebExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
