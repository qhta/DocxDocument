namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskUndo Class.
/// </summary>
public static class TaskUndoConverter
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetId(DXO21DT.TaskUndo openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO21DT.TaskUndo openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO21DT.TaskUndo openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.TaskUndo? CreateModelElement(DXO21DT.TaskUndo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TaskUndo();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO21DT.TaskUndo? openXmlElement, DM.TaskUndo? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.TaskUndo value)
    where OpenXmlElementType: DXO21DT.TaskUndo, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21DT.TaskUndo openXmlElement, DM.TaskUndo value)
  {
    SetId(openXmlElement, value?.Id);
  }
}
