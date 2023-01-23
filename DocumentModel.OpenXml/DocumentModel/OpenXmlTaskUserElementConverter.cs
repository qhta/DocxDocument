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
  
  private static bool CmpUserId(DXO2021DocTasks.OpenXmlTaskUserElement openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.UserId?.Value == value;
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
  
  private static bool CmpUserName(DXO2021DocTasks.OpenXmlTaskUserElement openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.UserName?.Value == value;
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
  
  private static bool CmpUserProvider(DXO2021DocTasks.OpenXmlTaskUserElement openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.UserProvider?.Value == value;
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
  
  public static bool CompareModelElement(DXO2021DocTasks.OpenXmlTaskUserElement? openXmlElement, DM.OpenXmlTaskUserElement? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUserId(openXmlElement, value.UserId, diffs, objName))
        ok = false;
      if (!CmpUserName(openXmlElement, value.UserName, diffs, objName))
        ok = false;
      if (!CmpUserProvider(openXmlElement, value.UserProvider, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
