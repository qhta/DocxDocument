namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the CommentAnchor Class converter from/to OpenXml.
///</summary>
public static class CommentAnchorConverter
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetId(DXO2021DocTasks.CommentAnchor openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO2021DocTasks.CommentAnchor openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXO2021DocTasks.CommentAnchor openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.CommentAnchor? CreateModelElement(DXO2021DocTasks.CommentAnchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.CommentAnchor();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021DocTasks.CommentAnchor? openXmlElement, DM.CommentAnchor? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.CommentAnchor value)
    where OpenXmlElementType: DXO2021DocTasks.CommentAnchor, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2021DocTasks.CommentAnchor openXmlElement, DM.CommentAnchor value)
  {
    SetId(openXmlElement, value?.Id);
  }
}
