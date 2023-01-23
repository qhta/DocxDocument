namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LineJoinMiterProperties Class.
/// </summary>
public static class LineJoinMiterPropertiesConverter
{
  /// <summary>
  /// lim, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetLimit(DXO2010W.LineJoinMiterProperties openXmlElement)
  {
    return openXmlElement.Limit?.Value;
  }
  
  private static bool CmpLimit(DXO2010W.LineJoinMiterProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Limit?.Value == value;
  }
  
  private static void SetLimit(DXO2010W.LineJoinMiterProperties openXmlElement, Int32? value)
  {
    openXmlElement.Limit = value;
  }
  
  public static DMW.LineJoinMiterProperties? CreateModelElement(DXO2010W.LineJoinMiterProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.LineJoinMiterProperties();
      value.Limit = GetLimit(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010W.LineJoinMiterProperties? openXmlElement, DMW.LineJoinMiterProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLimit(openXmlElement, value.Limit, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.LineJoinMiterProperties? value)
    where OpenXmlElementType: DXO2010W.LineJoinMiterProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLimit(openXmlElement, value?.Limit);
      return openXmlElement;
    }
    return default;
  }
}
