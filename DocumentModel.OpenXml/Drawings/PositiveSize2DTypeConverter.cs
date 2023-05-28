namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the PositiveSize2DType Class.
/// </summary>
public static class PositiveSize2DTypeConverter
{
  /// <summary>
  /// Extent Length
  /// </summary>
  private static Int64? GetCx(DXD.PositiveSize2DType openXmlElement)
  {
    return openXmlElement?.Cx?.Value;
  }
  
  private static bool CmpCx(DXD.PositiveSize2DType openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Cx?.Value == value) return true;
    diffs?.Add(objName, "Cx", openXmlElement?.Cx?.Value, value);
    return false;
  }
  
  private static void SetCx(DXD.PositiveSize2DType openXmlElement, Int64? value)
  {
    openXmlElement.Cx = value;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  private static Int64? GetCy(DXD.PositiveSize2DType openXmlElement)
  {
    return openXmlElement?.Cy?.Value;
  }
  
  private static bool CmpCy(DXD.PositiveSize2DType openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Cy?.Value == value) return true;
    diffs?.Add(objName, "Cy", openXmlElement?.Cy?.Value, value);
    return false;
  }
  
  private static void SetCy(DXD.PositiveSize2DType openXmlElement, Int64? value)
  {
    openXmlElement.Cy = value;
  }
  
  public static DMD.PositiveSize2DType? CreateModelElement(DXD.PositiveSize2DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.PositiveSize2DType();
      value.Cx = GetCx(openXmlElement);
      value.Cy = GetCy(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.PositiveSize2DType? openXmlElement, DMD.PositiveSize2DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.PositiveSize2DType value)
    where OpenXmlElementType: DXD.PositiveSize2DType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.PositiveSize2DType openXmlElement, DMD.PositiveSize2DType value)
  {
    SetCx(openXmlElement, value?.Cx);
    SetCy(openXmlElement, value?.Cy);
  }
}
