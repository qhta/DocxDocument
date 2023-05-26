namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the CommentAnchor Class.
/// </summary>
public static class CommentAnchorConverter
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetId(DXO21DT.CommentAnchor openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO21DT.CommentAnchor openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO21DT.CommentAnchor openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.CommentAnchor? CreateModelElement(DXO21DT.CommentAnchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.CommentAnchor();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO21DT.CommentAnchor? openXmlElement, DM.CommentAnchor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.CommentAnchor value)
    where OpenXmlElementType: DXO21DT.CommentAnchor, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21DT.CommentAnchor openXmlElement, DM.CommentAnchor value)
  {
    SetId(openXmlElement, value?.Id);
  }
}
