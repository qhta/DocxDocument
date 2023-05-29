namespace DocumentModel.OpenXml.WebExtensions.UI;

/// <summary>
/// Defines the WebExtensionPartReference Class.
/// </summary>
public static class WebExtensionPartReferenceConverter
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetId(DXO2013WebExtPane.WebExtensionPartReference openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO2013WebExtPane.WebExtensionPartReference openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXO2013WebExtPane.WebExtensionPartReference openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.WebExtensions.UI.WebExtensionPartReference? CreateModelElement(DXO2013WebExtPane.WebExtensionPartReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.UI.WebExtensionPartReference();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013WebExtPane.WebExtensionPartReference? openXmlElement, DMWebExtUI.WebExtensionPartReference? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWebExtUI.WebExtensionPartReference value)
    where OpenXmlElementType: DXO2013WebExtPane.WebExtensionPartReference, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013WebExtPane.WebExtensionPartReference openXmlElement, DMWebExtUI.WebExtensionPartReference value)
  {
    SetId(openXmlElement, value?.Id);
  }
}
