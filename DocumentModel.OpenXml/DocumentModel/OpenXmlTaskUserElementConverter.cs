namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the OpenXmlTaskUserElement Class.
/// </summary>
public static class OpenXmlTaskUserElementConverter
{
  /// <summary>
  /// userId, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetUserId(DXO2021DocTasks.OpenXmlTaskUserElement openXmlElement)
  {
    return openXmlElement?.UserId?.Value;
  }
  
  private static void SetUserId(DXO2021DocTasks.OpenXmlTaskUserElement openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.UserId = new StringValue { Value = value };
    else
      openXmlElement.UserId = null;
  }
  
  /// <summary>
  /// userName, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetUserName(DXO2021DocTasks.OpenXmlTaskUserElement openXmlElement)
  {
    return openXmlElement?.UserName?.Value;
  }
  
  private static void SetUserName(DXO2021DocTasks.OpenXmlTaskUserElement openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.UserName = new StringValue { Value = value };
    else
      openXmlElement.UserName = null;
  }
  
  /// <summary>
  /// userProvider, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetUserProvider(DXO2021DocTasks.OpenXmlTaskUserElement openXmlElement)
  {
    return openXmlElement?.UserProvider?.Value;
  }
  
  private static void SetUserProvider(DXO2021DocTasks.OpenXmlTaskUserElement openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.UserProvider = new StringValue { Value = value };
    else
      openXmlElement.UserProvider = null;
  }
  
  public static DM.OpenXmlTaskUserElement? CreateModelElement(DXO2021DocTasks.OpenXmlTaskUserElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.OpenXmlTaskUserElement();
      value.UserId = GetUserId(openXmlElement);
      value.UserName = GetUserName(openXmlElement);
      value.UserProvider = GetUserProvider(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.OpenXmlTaskUserElement? value)
    where OpenXmlElementType: DXO2021DocTasks.OpenXmlTaskUserElement, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUserId(openXmlElement, value?.UserId);
      SetUserName(openXmlElement, value?.UserName);
      SetUserProvider(openXmlElement, value?.UserProvider);
      return openXmlElement;
    }
    return default;
  }
}
