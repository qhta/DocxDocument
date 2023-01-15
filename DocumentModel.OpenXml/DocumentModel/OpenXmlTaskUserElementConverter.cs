namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the OpenXmlTaskUserElement Class.
/// </summary>
public static class OpenXmlTaskUserElementConverter
{
  /// <summary>
  ///   userId, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetUserId(DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement? openXmlElement)
  {
    return openXmlElement?.UserId?.Value;
  }

  public static void SetUserId(DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UserId = new StringValue { Value = value };
      else
        openXmlElement.UserId = null;
  }

  /// <summary>
  ///   userName, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetUserName(DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement? openXmlElement)
  {
    return openXmlElement?.UserName?.Value;
  }

  public static void SetUserName(DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UserName = new StringValue { Value = value };
      else
        openXmlElement.UserName = null;
  }

  /// <summary>
  ///   userProvider, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetUserProvider(DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement? openXmlElement)
  {
    return openXmlElement?.UserProvider?.Value;
  }

  public static void SetUserProvider(DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UserProvider = new StringValue { Value = value };
      else
        openXmlElement.UserProvider = null;
  }

  public static OpenXmlTaskUserElement? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new OpenXmlTaskUserElement();
      value.UserId = GetUserId(openXmlElement);
      value.UserName = GetUserName(openXmlElement);
      value.UserProvider = GetUserProvider(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(OpenXmlTaskUserElement? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement, new()
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