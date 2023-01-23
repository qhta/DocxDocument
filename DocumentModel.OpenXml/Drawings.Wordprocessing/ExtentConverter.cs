namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Inline Drawing Object Extents.
/// </summary>
public static class ExtentConverter
{
  /// <summary>
  /// Extent Length
  /// </summary>
  private static Int64? GetCx(DXDrawW.Extent openXmlElement)
  {
    return openXmlElement.Cx?.Value;
  }
  
  private static bool CmpCx(DXDrawW.Extent openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Cx?.Value == value;
  }
  
  private static void SetCx(DXDrawW.Extent openXmlElement, Int64? value)
  {
    openXmlElement.Cx = value;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  private static Int64? GetCy(DXDrawW.Extent openXmlElement)
  {
    return openXmlElement.Cy?.Value;
  }
  
  private static bool CmpCy(DXDrawW.Extent openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Cy?.Value == value;
  }
  
  private static void SetCy(DXDrawW.Extent openXmlElement, Int64? value)
  {
    openXmlElement.Cy = value;
  }
  
  public static DMDrawsW.Extent? CreateModelElement(DXDrawW.Extent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsW.Extent();
      value.Cx = GetCx(openXmlElement);
      value.Cy = GetCy(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawW.Extent? openXmlElement, DMDrawsW.Extent? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCx(openXmlElement, value.Cx, diffs, objName))
        ok = false;
      if (!CmpCy(openXmlElement, value.Cy, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.Extent? value)
    where OpenXmlElementType: DXDrawW.Extent, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCx(openXmlElement, value?.Cx);
      SetCy(openXmlElement, value?.Cy);
      return openXmlElement;
    }
    return default;
  }
}
