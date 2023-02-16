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
  
  private static bool CmpId(DXO2013WebExt.WebExtensionStoreReference openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
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
  
  private static bool CmpVersion(DXO2013WebExt.WebExtensionStoreReference openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Version?.Value == value) return true;
    diffs?.Add(objName, "Version", openXmlElement?.Version?.Value, value);
    return false;
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
  
  private static bool CmpStore(DXO2013WebExt.WebExtensionStoreReference openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Store?.Value == value) return true;
    diffs?.Add(objName, "Store", openXmlElement?.Store?.Value, value);
    return false;
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
  
  private static bool CmpStoreType(DXO2013WebExt.WebExtensionStoreReference openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.StoreType?.Value == value) return true;
    diffs?.Add(objName, "StoreType", openXmlElement?.StoreType?.Value, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXO2013WebExt.OfficeArtExtensionList>();
    if (element != null)
      return DMXWebExt.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO2013WebExt.WebExtensionStoreReference openXmlElement, DMWebExt.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXWebExt.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013WebExt.OfficeArtExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.WebExtensions.WebExtensionStoreReference? CreateModelElement(DXO2013WebExt.WebExtensionStoreReference? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2013WebExt.WebExtensionStoreReference? openXmlElement, DMWebExt.WebExtensionStoreReference? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpVersion(openXmlElement, value.Version, diffs, objName))
        ok = false;
      if (!CmpStore(openXmlElement, value.Store, diffs, objName))
        ok = false;
      if (!CmpStoreType(openXmlElement, value.StoreType, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
