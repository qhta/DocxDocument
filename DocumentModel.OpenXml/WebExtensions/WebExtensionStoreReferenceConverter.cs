using DocumentFormat.OpenXml.Office2013.WebExtension;

namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
///   Defines the WebExtensionStoreReference Class.
/// </summary>
public static class WebExtensionStoreReferenceConverter
{
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetId(WebExtensionStoreReference? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(WebExtensionStoreReference? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   version, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetVersion(WebExtensionStoreReference? openXmlElement)
  {
    return openXmlElement?.Version?.Value;
  }

  public static void SetVersion(WebExtensionStoreReference? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Version = new StringValue { Value = value };
      else
        openXmlElement.Version = null;
  }

  /// <summary>
  ///   store, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetStore(WebExtensionStoreReference? openXmlElement)
  {
    return openXmlElement?.Store?.Value;
  }

  public static void SetStore(WebExtensionStoreReference? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Store = new StringValue { Value = value };
      else
        openXmlElement.Store = null;
  }

  /// <summary>
  ///   storeType, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetStoreType(WebExtensionStoreReference? openXmlElement)
  {
    return openXmlElement?.StoreType?.Value;
  }

  public static void SetStoreType(WebExtensionStoreReference? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StoreType = new StringValue { Value = value };
      else
        openXmlElement.StoreType = null;
  }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public static DocumentModel.WebExtensions.OfficeArtExtensionList? GetOfficeArtExtensionList(WebExtensionStoreReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
    if (itemElement != null)
      return OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeArtExtensionList(WebExtensionStoreReference? openXmlElement, DocumentModel.WebExtensions.OfficeArtExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.WebExtensions.WebExtensionStoreReference? CreateModelElement(WebExtensionStoreReference? openXmlElement)
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
    where OpenXmlElementType : WebExtensionStoreReference, new()
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