namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PresenceInfo Class.
/// </summary>
public static class PresenceInfoConverter
{
  /// <summary>
  /// providerId, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetProviderId(DocumentFormat.OpenXml.Office2013.Word.PresenceInfo openXmlElement)
  {
    return openXmlElement?.ProviderId?.Value;
  }
  
  private static void SetProviderId(DocumentFormat.OpenXml.Office2013.Word.PresenceInfo openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ProviderId = new StringValue { Value = value };
    else
      openXmlElement.ProviderId = null;
  }
  
  /// <summary>
  /// userId, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetUserId(DocumentFormat.OpenXml.Office2013.Word.PresenceInfo openXmlElement)
  {
    return openXmlElement?.UserId?.Value;
  }
  
  private static void SetUserId(DocumentFormat.OpenXml.Office2013.Word.PresenceInfo openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.UserId = new StringValue { Value = value };
    else
      openXmlElement.UserId = null;
  }
  
  public static DocumentModel.Wordprocessing.PresenceInfo? CreateModelElement(DocumentFormat.OpenXml.Office2013.Word.PresenceInfo? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PresenceInfo? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Word.PresenceInfo, new()
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
