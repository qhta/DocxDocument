namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Grid Column Definition.
/// </summary>
public static class GridColumnConverter
{
  /// <summary>
  /// Grid Column Width
  /// </summary>
  private static String? GetWidth(DXW.GridColumn openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXW.GridColumn openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Width?.Value == value;
  }
  
  private static void SetWidth(DXW.GridColumn openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Width = new StringValue { Value = value };
    else
      openXmlElement.Width = null;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.GridColumn? value)
    where OpenXmlElementType: DXW.GridColumn, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      return openXmlElement;
    }
    return default;
  }
}
