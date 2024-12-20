namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LineJoinMiterProperties Class.
/// </summary>
public static class LineJoinMiterPropertiesConverter
{
  /// <summary>
  /// lim, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetLimit(DXO10W.LineJoinMiterProperties openXmlElement)
  {
    return openXmlElement?.Limit?.Value;
  }
  
  private static bool CmpLimit(DXO10W.LineJoinMiterProperties openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Limit?.Value == value) return true;
    diffs?.Add(objName, "Limit", openXmlElement?.Limit?.Value, value);
    return false;
  }
  
  private static void SetLimit(DXO10W.LineJoinMiterProperties openXmlElement, Int32? value)
  {
    openXmlElement.Limit = value;
  }
  
  public static DMW.LineJoinMiterProperties? CreateModelElement(DXO10W.LineJoinMiterProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.LineJoinMiterProperties();
      value.Limit = GetLimit(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10W.LineJoinMiterProperties? openXmlElement, DMW.LineJoinMiterProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLimit(openXmlElement, value.Limit, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.LineJoinMiterProperties value)
    where OpenXmlElementType: DXO10W.LineJoinMiterProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10W.LineJoinMiterProperties openXmlElement, DMW.LineJoinMiterProperties value)
  {
    SetLimit(openXmlElement, value?.Limit);
  }
}
