using DocumentModel.Drawings;

namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Shape Extent.
/// </summary>
public static class ExtentConverter
{
  /// <summary>
  /// Extent Length
  /// </summary>
  private static Int64 GetCx(DXDrawChartDraw.Extent openXmlElement)
  {
    return openXmlElement?.Cx?.Value ?? 0;
  }
  
  private static bool CmpCx(DXDrawChartDraw.Extent openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Cx?.Value == value) return true;
    diffs?.Add(objName, "Cx", openXmlElement?.Cx?.Value, value);
    return false;
  }
  
  private static void SetCx(DXDrawChartDraw.Extent openXmlElement, Int64? value)
  {
    openXmlElement.Cx = value;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  private static Int64 GetCy(DXDrawChartDraw.Extent openXmlElement)
  {
    return openXmlElement?.Cy?.Value ?? 0;
  }
  
  private static bool CmpCy(DXDrawChartDraw.Extent openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Cy?.Value == value) return true;
    diffs?.Add(objName, "Cy", openXmlElement?.Cy?.Value, value);
    return false;
  }
  
  private static void SetCy(DXDrawChartDraw.Extent openXmlElement, Int64? value)
  {
    openXmlElement.Cy = value;
  }
  
  public static Extent? CreateModelElement(DXDrawChartDraw.Extent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new Extent();
      value.Cx = GetCx(openXmlElement);
      value.Cy = GetCy(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawChartDraw.Extent? openXmlElement, Extent? value, DiffList? diffs, string? objName)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(Extent value)
    where OpenXmlElementType: DXDrawChartDraw.Extent, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawChartDraw.Extent openXmlElement, Extent value)
  {
    SetCx(openXmlElement, value.Cx);
    SetCy(openXmlElement, value.Cy);
  }
}
