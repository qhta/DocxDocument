namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Transform Effect.
/// </summary>
public static class TransformEffectConverter
{
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  private static Int32? GetHorizontalRatio(DXDraw.TransformEffect openXmlElement)
  {
    return openXmlElement?.HorizontalRatio?.Value;
  }
  
  private static bool CmpHorizontalRatio(DXDraw.TransformEffect openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalRatio?.Value == value) return true;
    diffs?.Add(objName, "HorizontalRatio", openXmlElement?.HorizontalRatio?.Value, value);
    return false;
  }
  
  private static void SetHorizontalRatio(DXDraw.TransformEffect openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalRatio = value;
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  private static Int32? GetVerticalRatio(DXDraw.TransformEffect openXmlElement)
  {
    return openXmlElement?.VerticalRatio?.Value;
  }
  
  private static bool CmpVerticalRatio(DXDraw.TransformEffect openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.VerticalRatio?.Value == value) return true;
    diffs?.Add(objName, "VerticalRatio", openXmlElement?.VerticalRatio?.Value, value);
    return false;
  }
  
  private static void SetVerticalRatio(DXDraw.TransformEffect openXmlElement, Int32? value)
  {
    openXmlElement.VerticalRatio = value;
  }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  private static Int32? GetHorizontalSkew(DXDraw.TransformEffect openXmlElement)
  {
    return openXmlElement?.HorizontalSkew?.Value;
  }
  
  private static bool CmpHorizontalSkew(DXDraw.TransformEffect openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalSkew?.Value == value) return true;
    diffs?.Add(objName, "HorizontalSkew", openXmlElement?.HorizontalSkew?.Value, value);
    return false;
  }
  
  private static void SetHorizontalSkew(DXDraw.TransformEffect openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalSkew = value;
  }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  private static Int32? GetVerticalSkew(DXDraw.TransformEffect openXmlElement)
  {
    return openXmlElement?.VerticalSkew?.Value;
  }
  
  private static bool CmpVerticalSkew(DXDraw.TransformEffect openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.VerticalSkew?.Value == value) return true;
    diffs?.Add(objName, "VerticalSkew", openXmlElement?.VerticalSkew?.Value, value);
    return false;
  }
  
  private static void SetVerticalSkew(DXDraw.TransformEffect openXmlElement, Int32? value)
  {
    openXmlElement.VerticalSkew = value;
  }
  
  /// <summary>
  /// Horizontal Shift
  /// </summary>
  private static Int64? GetHorizontalShift(DXDraw.TransformEffect openXmlElement)
  {
    return openXmlElement?.HorizontalShift?.Value;
  }
  
  private static bool CmpHorizontalShift(DXDraw.TransformEffect openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalShift?.Value == value) return true;
    diffs?.Add(objName, "HorizontalShift", openXmlElement?.HorizontalShift?.Value, value);
    return false;
  }
  
  private static void SetHorizontalShift(DXDraw.TransformEffect openXmlElement, Int64? value)
  {
    openXmlElement.HorizontalShift = value;
  }
  
  /// <summary>
  /// Vertical Shift
  /// </summary>
  private static Int64? GetVerticalShift(DXDraw.TransformEffect openXmlElement)
  {
    return openXmlElement?.VerticalShift?.Value;
  }
  
  private static bool CmpVerticalShift(DXDraw.TransformEffect openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.VerticalShift?.Value == value) return true;
    diffs?.Add(objName, "VerticalShift", openXmlElement?.VerticalShift?.Value, value);
    return false;
  }
  
  private static void SetVerticalShift(DXDraw.TransformEffect openXmlElement, Int64? value)
  {
    openXmlElement.VerticalShift = value;
  }
  
  public static DocumentModel.Drawings.TransformEffect? CreateModelElement(DXDraw.TransformEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TransformEffect();
      value.HorizontalRatio = GetHorizontalRatio(openXmlElement);
      value.VerticalRatio = GetVerticalRatio(openXmlElement);
      value.HorizontalSkew = GetHorizontalSkew(openXmlElement);
      value.VerticalSkew = GetVerticalSkew(openXmlElement);
      value.HorizontalShift = GetHorizontalShift(openXmlElement);
      value.VerticalShift = GetVerticalShift(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.TransformEffect? openXmlElement, DMDraws.TransformEffect? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHorizontalRatio(openXmlElement, value.HorizontalRatio, diffs, objName))
        ok = false;
      if (!CmpVerticalRatio(openXmlElement, value.VerticalRatio, diffs, objName))
        ok = false;
      if (!CmpHorizontalSkew(openXmlElement, value.HorizontalSkew, diffs, objName))
        ok = false;
      if (!CmpVerticalSkew(openXmlElement, value.VerticalSkew, diffs, objName))
        ok = false;
      if (!CmpHorizontalShift(openXmlElement, value.HorizontalShift, diffs, objName))
        ok = false;
      if (!CmpVerticalShift(openXmlElement, value.VerticalShift, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.TransformEffect? value)
    where OpenXmlElementType: DXDraw.TransformEffect, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHorizontalRatio(openXmlElement, value?.HorizontalRatio);
      SetVerticalRatio(openXmlElement, value?.VerticalRatio);
      SetHorizontalSkew(openXmlElement, value?.HorizontalSkew);
      SetVerticalSkew(openXmlElement, value?.VerticalSkew);
      SetHorizontalShift(openXmlElement, value?.HorizontalShift);
      SetVerticalShift(openXmlElement, value?.VerticalShift);
      return openXmlElement;
    }
    return default;
  }
}
