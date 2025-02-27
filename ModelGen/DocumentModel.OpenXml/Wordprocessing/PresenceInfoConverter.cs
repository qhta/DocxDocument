namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PresenceInfo Class.
/// </summary>
public static class PresenceInfoConverter
{
  /// <summary>
  /// providerId, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetProviderId(DXO2013W.PresenceInfo openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ProviderId);
  }
  
  private static bool CmpProviderId(DXO2013W.PresenceInfo openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ProviderId, value, diffs, objName, "ProviderId");
  }
  
  private static void SetProviderId(DXO2013W.PresenceInfo openXmlElement, String? value)
  {
    openXmlElement.ProviderId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// userId, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetUserId(DXO2013W.PresenceInfo openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.UserId);
  }
  
  private static bool CmpUserId(DXO2013W.PresenceInfo openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.UserId, value, diffs, objName, "UserId");
  }
  
  private static void SetUserId(DXO2013W.PresenceInfo openXmlElement, String? value)
  {
    openXmlElement.UserId = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Wordprocessing.PresenceInfo? CreateModelElement(DXO2013W.PresenceInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PresenceInfo();
      value.ProviderId = GetProviderId(openXmlElement);
      value.UserId = GetUserId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013W.PresenceInfo? openXmlElement, DMW.PresenceInfo? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpProviderId(openXmlElement, value.ProviderId, diffs, objName))
        ok = false;
      if (!CmpUserId(openXmlElement, value.UserId, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PresenceInfo value)
    where OpenXmlElementType: DXO2013W.PresenceInfo, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013W.PresenceInfo openXmlElement, DMW.PresenceInfo value)
  {
    SetProviderId(openXmlElement, value?.ProviderId);
    SetUserId(openXmlElement, value?.UserId);
  }
}
