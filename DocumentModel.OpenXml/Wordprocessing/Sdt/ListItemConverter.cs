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
    return StringValueConverter.GetValue(openXmlElement?.DisplayText);
  }
  
  private static bool CmpDisplayText(DXW.ListItem openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.DisplayText, value, diffs, objName, "DisplayText");
  }
  
  private static void SetDisplayText(DXW.ListItem openXmlElement, String? value)
  {
    openXmlElement.DisplayText = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// List Entry Value
  /// </summary>
  private static String? GetValue(DXW.ListItem openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Value);
  }
  
  private static bool CmpValue(DXW.ListItem openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Value, value, diffs, objName, "Type");
  }
  
  private static void SetValue(DXW.ListItem openXmlElement, String? value)
  {
    openXmlElement.Value = StringValueConverter.CreateStringValue(value);
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
  
  public static bool CompareModelElement(DXW.ListItem? openXmlElement, DMW.ListItem? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDisplayText(openXmlElement, value.DisplayText, diffs, objName, propName))
        ok = false;
      if (!CmpValue(openXmlElement, value.Value, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ListItem value)
    where OpenXmlElementType: DXW.ListItem, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.ListItem openXmlElement, DMW.ListItem value)
  {
    SetDisplayText(openXmlElement, value?.DisplayText);
    SetValue(openXmlElement, value?.Value);
  }
}
