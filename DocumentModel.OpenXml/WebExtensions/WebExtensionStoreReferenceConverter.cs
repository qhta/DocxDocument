namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionStoreReference Class.
/// </summary>
public static class WebExtensionStoreReferenceConverter
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetId(DXO2013WebExt.WebExtensionStoreReference openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXO2013WebExt.WebExtensionStoreReference openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// version, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetVersion(DXO2013WebExt.WebExtensionStoreReference openXmlElement)
  {
    return openXmlElement?.Version?.Value;
  }
  
  private static void SetVersion(DXO2013WebExt.WebExtensionStoreReference openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Version = new StringValue { Value = value };
    else
      openXmlElement.Version = null;
  }
  
  /// <summary>
  /// store, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetStore(DXO2013WebExt.WebExtensionStoreReference openXmlElement)
  {
    return openXmlElement?.Store?.Value;
  }
  
  private static void SetStore(DXO2013WebExt.WebExtensionStoreReference openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Store = new StringValue { Value = value };
    else
      openXmlElement.Store = null;
  }
  
  /// <summary>
  /// storeType, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetStoreType(DXO2013WebExt.WebExtensionStoreReference openXmlElement)
  {
    return openXmlElement?.StoreType?.Value;
  }
  
  private static void SetStoreType(DXO2013WebExt.WebExtensionStoreReference openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StoreType = new StringValue { Value = value };
    else
      openXmlElement.StoreType = null;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMWebExt.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2013WebExt.WebExtensionStoreReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013WebExt.OfficeArtExtensionList>();
    if (itemElement != null)
      return DMXWebExt.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DXO2013WebExt.WebExtensionStoreReference openXmlElement, DMWebExt.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013WebExt.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWebExt.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO2013WebExt.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMWebExt.WebExtensionStoreReference? CreateModelElement(DXO2013WebExt.WebExtensionStoreReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMWebExt.WebExtensionStoreReference();
      value.Id = GetId(openXmlElement);
      value.Version = GetVersion(openXmlElement);
      value.Store = GetStore(openXmlElement);
      value.StoreType = GetStoreType(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMWebExt.WebExtensionStoreReference? value)
    where OpenXmlElementType: DXO2013WebExt.WebExtensionStoreReference, new()
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
