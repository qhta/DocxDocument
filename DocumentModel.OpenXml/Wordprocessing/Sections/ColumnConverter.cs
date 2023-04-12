namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Single Column Definition.
/// </summary>
public static class ColumnConverter
{
  /// <summary>
  /// Column Width
  /// </summary>
  private static String? GetWidth(DXW.Column openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Width);
  }
  
  private static bool CmpWidth(DXW.Column openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Width, value, diffs, objName, "Value");
  }
  
  private static void SetWidth(DXW.Column openXmlElement, String? value)
  {
    openXmlElement.Width = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Space Before Following Column
  /// </summary>
  private static String? GetSpace(DXW.Column openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Space);
  }
  
  private static bool CmpSpace(DXW.Column openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Space, value, diffs, objName, "Space");
  }
  
  private static void SetSpace(DXW.Column openXmlElement, String? value)
  {
    openXmlElement.Space = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.Column? CreateModelElement(DXW.Column? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Column();
      value.Width = GetWidth(openXmlElement);
      value.Space = GetSpace(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Column? openXmlElement, DMW.Column? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName))
        ok = false;
      if (!CmpSpace(openXmlElement, value.Space, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Column value)
    where OpenXmlElementType: DXW.Column, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Column openXmlElement, DMW.Column value)
  {
    SetWidth(openXmlElement, value?.Width);
    SetSpace(openXmlElement, value?.Space);
  }
}
