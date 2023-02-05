namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionBinding Class.
/// </summary>
public static class WebExtensionBindingConverter
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetId(DXO2013WebExt.WebExtensionBinding openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2013WebExt.WebExtensionBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXO2013WebExt.WebExtensionBinding openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// type, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetType(DXO2013WebExt.WebExtensionBinding openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }
  
  private static bool CmpType(DXO2013WebExt.WebExtensionBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Type?.Value == value) return true;
    diffs?.Add(objName, "Type", openXmlElement?.Type?.Value, value);
    return false;
  }
  
  private static void SetType(DXO2013WebExt.WebExtensionBinding openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Type = new StringValue { Value = value };
    else
      openXmlElement.Type = null;
  }
  
  /// <summary>
  /// appref, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetAppReference(DXO2013WebExt.WebExtensionBinding openXmlElement)
  {
    return openXmlElement?.AppReference?.Value;
  }
  
  private static bool CmpAppReference(DXO2013WebExt.WebExtensionBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AppReference?.Value == value) return true;
    diffs?.Add(objName, "AppReference", openXmlElement?.AppReference?.Value, value);
    return false;
  }
  
  private static void SetAppReference(DXO2013WebExt.WebExtensionBinding openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AppReference = new StringValue { Value = value };
    else
      openXmlElement.AppReference = null;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMWebExt.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2013WebExt.WebExtensionBinding openXmlElement)
  {
    return DMXWebExt.OfficeArtExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013WebExt.OfficeArtExtensionList>());
  }
  
  private static bool CmpOfficeArtExtensionList(DXO2013WebExt.WebExtensionBinding openXmlElement, DMWebExt.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXWebExt.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013WebExt.OfficeArtExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOfficeArtExtensionList(DXO2013WebExt.WebExtensionBinding openXmlElement, DMWebExt.OfficeArtExtensionList? value)
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
  
  public static DMWebExt.WebExtensionBinding? CreateModelElement(DXO2013WebExt.WebExtensionBinding? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMWebExt.WebExtensionBinding();
      value.Id = GetId(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.AppReference = GetAppReference(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013WebExt.WebExtensionBinding? openXmlElement, DMWebExt.WebExtensionBinding? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpAppReference(openXmlElement, value.AppReference, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMWebExt.WebExtensionBinding? value)
    where OpenXmlElementType: DXO2013WebExt.WebExtensionBinding, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetType(openXmlElement, value?.Type);
      SetAppReference(openXmlElement, value?.AppReference);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
