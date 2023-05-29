namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the PositiveSize2DType Class.
/// </summary>
public static class PositiveSize2DTypeConverter
{
  /// <summary>
  /// Extent Length
  /// </summary>
  private static Int64? GetCx(DXDraw.PositiveSize2DType openXmlElement)
  {
    return openXmlElement?.Cx?.Value;
  }
  
  private static bool CmpCx(DXDraw.PositiveSize2DType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Cx?.Value == value) return true;
    diffs?.Add(objName, "Cx", openXmlElement?.Cx?.Value, value);
    return false;
  }
  
  private static void SetCx(DXDraw.PositiveSize2DType openXmlElement, Int64? value)
  {
    openXmlElement.Cx = value;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  private static Int64? GetCy(DXDraw.PositiveSize2DType openXmlElement)
  {
    return openXmlElement?.Cy?.Value;
  }
  
  private static bool CmpCy(DXDraw.PositiveSize2DType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Cy?.Value == value) return true;
    diffs?.Add(objName, "Cy", openXmlElement?.Cy?.Value, value);
    return false;
  }
  
  private static void SetCy(DXDraw.PositiveSize2DType openXmlElement, Int64? value)
  {
    openXmlElement.Cy = value;
  }
  
  public static DocumentModel.Drawings.PositiveSize2DType? CreateModelElement(DXDraw.PositiveSize2DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PositiveSize2DType();
      value.Cx = GetCx(openXmlElement);
      value.Cy = GetCy(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.PositiveSize2DType? openXmlElement, DMDraws.PositiveSize2DType? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.PositiveSize2DType value)
    where OpenXmlElementType: DXDraw.PositiveSize2DType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.PositiveSize2DType openXmlElement, DMDraws.PositiveSize2DType value)
  {
    SetCx(openXmlElement, value?.Cx);
    SetCy(openXmlElement, value?.Cy);
  }
}
