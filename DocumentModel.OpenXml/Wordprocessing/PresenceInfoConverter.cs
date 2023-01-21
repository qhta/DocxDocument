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
    return openXmlElement?.ProviderId?.Value;
  }
  
  private static void SetProviderId(DXO2013W.PresenceInfo openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ProviderId = new StringValue { Value = value };
    else
      openXmlElement.ProviderId = null;
  }
  
  /// <summary>
  /// userId, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetUserId(DXO2013W.PresenceInfo openXmlElement)
  {
    return openXmlElement?.UserId?.Value;
  }
  
  private static void SetUserId(DXO2013W.PresenceInfo openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.UserId = new StringValue { Value = value };
    else
      openXmlElement.UserId = null;
  }
  
  public static DMW.PresenceInfo? CreateModelElement(DXO2013W.PresenceInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PresenceInfo();
      value.ProviderId = GetProviderId(openXmlElement);
      value.UserId = GetUserId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.PresenceInfo? value)
    where OpenXmlElementType: DXO2013W.PresenceInfo, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetProviderId(openXmlElement, value?.ProviderId);
      SetUserId(openXmlElement, value?.UserId);
      return openXmlElement;
    }
    return default;
  }
}
