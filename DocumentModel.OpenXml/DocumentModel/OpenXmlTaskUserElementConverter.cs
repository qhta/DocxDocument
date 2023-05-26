namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the OpenXmlTaskUserElement Class.
/// </summary>
public static class OpenXmlTaskUserElementConverter
{
  /// <summary>
  /// userId, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetUserId(DXO21DT.OpenXmlTaskUserElement openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.UserId);
  }
  
  private static bool CmpUserId(DXO21DT.OpenXmlTaskUserElement openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.UserId, value, diffs, objName, "UserId");
  }
  
  private static void SetUserId(DXO21DT.OpenXmlTaskUserElement openXmlElement, String? value)
  {
    openXmlElement.UserId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// userName, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetUserName(DXO21DT.OpenXmlTaskUserElement openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.UserName);
  }
  
  private static bool CmpUserName(DXO21DT.OpenXmlTaskUserElement openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.UserName, value, diffs, objName, "UserName");
  }
  
  private static void SetUserName(DXO21DT.OpenXmlTaskUserElement openXmlElement, String? value)
  {
    openXmlElement.UserName = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// userProvider, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetUserProvider(DXO21DT.OpenXmlTaskUserElement openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.UserProvider);
  }
  
  private static bool CmpUserProvider(DXO21DT.OpenXmlTaskUserElement openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.UserProvider, value, diffs, objName, "UserProvider");
  }
  
  private static void SetUserProvider(DXO21DT.OpenXmlTaskUserElement openXmlElement, String? value)
  {
    openXmlElement.UserProvider = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.OpenXmlTaskUserElement? CreateModelElement(DXO21DT.OpenXmlTaskUserElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.OpenXmlTaskUserElement();
      value.UserId = GetUserId(openXmlElement);
      value.UserName = GetUserName(openXmlElement);
      value.UserProvider = GetUserProvider(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO21DT.OpenXmlTaskUserElement? openXmlElement, DM.OpenXmlTaskUserElement? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUserId(openXmlElement, value.UserId, diffs, objName, propName))
        ok = false;
      if (!CmpUserName(openXmlElement, value.UserName, diffs, objName, propName))
        ok = false;
      if (!CmpUserProvider(openXmlElement, value.UserProvider, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.OpenXmlTaskUserElement value)
    where OpenXmlElementType: DXO21DT.OpenXmlTaskUserElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21DT.OpenXmlTaskUserElement openXmlElement, DM.OpenXmlTaskUserElement value)
  {
    SetUserId(openXmlElement, value?.UserId);
    SetUserName(openXmlElement, value?.UserName);
    SetUserProvider(openXmlElement, value?.UserProvider);
  }
}
