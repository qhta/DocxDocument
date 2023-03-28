namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Grid Column Definition converter from/to OpenXml.
///</summary>
public static class GridColumnConverter
{
  /// <summary>
  /// Grid Column Width
  /// </summary>
  private static String? GetWidth(DXW.GridColumn openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Width);
  }
  
  private static bool CmpWidth(DXW.GridColumn openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Width, value, diffs, objName, "Width");
  }
  
  private static void SetWidth(DXW.GridColumn openXmlElement, String? value)
  {
    openXmlElement.Width = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.GridColumn? CreateModelElement(DXW.GridColumn? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.GridColumn();
      value.Width = GetWidth(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.GridColumn? openXmlElement, DMW.GridColumn? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.GridColumn value)
    where OpenXmlElementType: DXW.GridColumn, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.GridColumn openXmlElement, DMW.GridColumn value)
  {
    SetWidth(openXmlElement, value?.Width);
  }
}
