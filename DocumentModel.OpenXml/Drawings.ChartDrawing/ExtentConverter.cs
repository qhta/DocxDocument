namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Shape Extent.
/// </summary>
public static class ExtentConverter
{
  /// <summary>
  /// Extent Length
  /// </summary>
  private static Int64 GetCx(DXDCD.Extent openXmlElement)
  {
    return openXmlElement?.Cx?.Value ?? 0;
  }
  
  private static bool CmpCx(DXDCD.Extent openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Cx?.Value == value) return true;
    diffs?.Add(objName, "Cx", openXmlElement?.Cx?.Value, value);
    return false;
  }
  
  private static void SetCx(DXDCD.Extent openXmlElement, Int64? value)
  {
    openXmlElement.Cx = value;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  private static Int64 GetCy(DXDCD.Extent openXmlElement)
  {
    return openXmlElement?.Cy?.Value ?? 0;
  }
  
  private static bool CmpCy(DXDCD.Extent openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Cy?.Value == value) return true;
    diffs?.Add(objName, "Cy", openXmlElement?.Cy?.Value, value);
    return false;
  }
  
  private static void SetCy(DXDCD.Extent openXmlElement, Int64? value)
  {
    openXmlElement.Cy = value;
  }
  
  public static DMD.Extent? CreateModelElement(DXDCD.Extent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Extent();
      value.Cx = GetCx(openXmlElement);
      value.Cy = GetCy(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDCD.Extent? openXmlElement, DMD.Extent? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCx(openXmlElement, value.Cx, diffs, objName, propName))
        ok = false;
      if (!CmpCy(openXmlElement, value.Cy, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Extent value)
    where OpenXmlElementType: DXDCD.Extent, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.Extent openXmlElement, DMD.Extent value)
  {
    SetCx(openXmlElement, value.Cx);
    SetCy(openXmlElement, value.Cy);
  }
}
