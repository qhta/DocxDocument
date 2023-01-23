namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Combo Box List Item.
/// </summary>
public static class ListItemConverter
{
  /// <summary>
  /// List Entry Display Text
  /// </summary>
  private static String? GetDisplayText(DXW.ListItem openXmlElement)
  {
    return openXmlElement?.DisplayText?.Value;
  }
  
  private static bool CmpDisplayText(DXW.ListItem openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.DisplayText?.Value == value;
  }
  
  private static void SetDisplayText(DXW.ListItem openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.DisplayText = new StringValue { Value = value };
    else
      openXmlElement.DisplayText = null;
  }
  
  /// <summary>
  /// List Entry Value
  /// </summary>
  private static String? GetValue(DXW.ListItem openXmlElement)
  {
    return openXmlElement?.Value?.Value;
  }
  
  private static bool CmpValue(DXW.ListItem openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Value?.Value == value;
  }
  
  private static void SetValue(DXW.ListItem openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Value = new StringValue { Value = value };
    else
      openXmlElement.Value = null;
  }
  
  public static DMW.ListItem? CreateModelElement(DXW.ListItem? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ListItem();
      value.DisplayText = GetDisplayText(openXmlElement);
      value.Value = GetValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ListItem? openXmlElement, DMW.ListItem? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDisplayText(openXmlElement, value.DisplayText, diffs, objName))
        ok = false;
      if (!CmpValue(openXmlElement, value.Value, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ListItem? value)
    where OpenXmlElementType: DXW.ListItem, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDisplayText(openXmlElement, value?.DisplayText);
      SetValue(openXmlElement, value?.Value);
      return openXmlElement;
    }
    return default;
  }
}
