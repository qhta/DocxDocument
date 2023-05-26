namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskProgressEventInfo Class.
/// </summary>
public static class TaskProgressEventInfoConverter
{
  /// <summary>
  /// percentComplete, this property is only available in Office 2021 and later.
  /// </summary>
  private static Int32? GetPercentComplete(DXO21DT.TaskProgressEventInfo openXmlElement)
  {
    return openXmlElement?.PercentComplete?.Value;
  }
  
  private static bool CmpPercentComplete(DXO21DT.TaskProgressEventInfo openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.PercentComplete?.Value == value) return true;
    diffs?.Add(objName, "PercentComplete", openXmlElement?.PercentComplete?.Value, value);
    return false;
  }
  
  private static void SetPercentComplete(DXO21DT.TaskProgressEventInfo openXmlElement, Int32? value)
  {
    openXmlElement.PercentComplete = value;
  }
  
  public static DocumentModel.TaskProgressEventInfo? CreateModelElement(DXO21DT.TaskProgressEventInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TaskProgressEventInfo();
      value.PercentComplete = GetPercentComplete(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO21DT.TaskProgressEventInfo? openXmlElement, DM.TaskProgressEventInfo? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPercentComplete(openXmlElement, value.PercentComplete, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.TaskProgressEventInfo value)
    where OpenXmlElementType: DXO21DT.TaskProgressEventInfo, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21DT.TaskProgressEventInfo openXmlElement, DM.TaskProgressEventInfo value)
  {
    SetPercentComplete(openXmlElement, value?.PercentComplete);
  }
}
