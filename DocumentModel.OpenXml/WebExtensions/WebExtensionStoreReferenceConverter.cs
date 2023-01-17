namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionStoreReference Class.
/// </summary>
public static class WebExtensionStoreReferenceConverter
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// version, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetVersion(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference openXmlElement)
  {
    return openXmlElement?.Version?.Value;
  }
  
  private static void SetVersion(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Version = new StringValue { Value = value };
    else
      openXmlElement.Version = null;
  }
  
  /// <summary>
  /// store, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetStore(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference openXmlElement)
  {
    return openXmlElement?.Store?.Value;
  }
  
  private static void SetStore(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Store = new StringValue { Value = value };
    else
      openXmlElement.Store = null;
  }
  
  /// <summary>
  /// storeType, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetStoreType(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference openXmlElement)
  {
    return openXmlElement?.StoreType?.Value;
  }
  
  private static void SetStoreType(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StoreType = new StringValue { Value = value };
    else
      openXmlElement.StoreType = null;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DocumentModel.WebExtensions.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.WebExtensions.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference openXmlElement, DocumentModel.WebExtensions.OfficeArtExtensionList? value)
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
  
  public static DocumentModel.WebExtensions.WebExtensionStoreReference? CreateModelElement(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.WebExtensionStoreReference();
      value.Id = GetId(openXmlElement);
      value.Version = GetVersion(openXmlElement);
      value.Store = GetStore(openXmlElement);
      value.StoreType = GetStoreType(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.WebExtensions.WebExtensionStoreReference? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetVersion(openXmlElement, value?.Version);
      SetStore(openXmlElement, value?.Store);
      SetStoreType(openXmlElement, value?.StoreType);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
