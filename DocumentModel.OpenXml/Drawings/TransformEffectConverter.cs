namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Transform Effect.
/// </summary>
public static class TransformEffectConverter
{
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  private static Int32? GetHorizontalRatio(DXD.TransformEffect openXmlElement)
  {
    return openXmlElement?.HorizontalRatio?.Value;
  }
  
  private static bool CmpHorizontalRatio(DXD.TransformEffect openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.HorizontalRatio?.Value == value) return true;
    diffs?.Add(objName, "HorizontalRatio", openXmlElement?.HorizontalRatio?.Value, value);
    return false;
  }
  
  private static void SetHorizontalRatio(DXD.TransformEffect openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalRatio = value;
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  private static Int32? GetVerticalRatio(DXD.TransformEffect openXmlElement)
  {
    return openXmlElement?.VerticalRatio?.Value;
  }
  
  private static bool CmpVerticalRatio(DXD.TransformEffect openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.VerticalRatio?.Value == value) return true;
    diffs?.Add(objName, "VerticalRatio", openXmlElement?.VerticalRatio?.Value, value);
    return false;
  }
  
  private static void SetVerticalRatio(DXD.TransformEffect openXmlElement, Int32? value)
  {
    openXmlElement.VerticalRatio = value;
  }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  private static Int32? GetHorizontalSkew(DXD.TransformEffect openXmlElement)
  {
    return openXmlElement?.HorizontalSkew?.Value;
  }
  
  private static bool CmpHorizontalSkew(DXD.TransformEffect openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.HorizontalSkew?.Value == value) return true;
    diffs?.Add(objName, "HorizontalSkew", openXmlElement?.HorizontalSkew?.Value, value);
    return false;
  }
  
  private static void SetHorizontalSkew(DXD.TransformEffect openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalSkew = value;
  }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  private static Int32? GetVerticalSkew(DXD.TransformEffect openXmlElement)
  {
    return openXmlElement?.VerticalSkew?.Value;
  }
  
  private static bool CmpVerticalSkew(DXD.TransformEffect openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.VerticalSkew?.Value == value) return true;
    diffs?.Add(objName, "VerticalSkew", openXmlElement?.VerticalSkew?.Value, value);
    return false;
  }
  
  private static void SetVerticalSkew(DXD.TransformEffect openXmlElement, Int32? value)
  {
    openXmlElement.VerticalSkew = value;
  }
  
  /// <summary>
  /// Horizontal Shift
  /// </summary>
  private static Int64? GetHorizontalShift(DXD.TransformEffect openXmlElement)
  {
    return openXmlElement?.HorizontalShift?.Value;
  }
  
  private static bool CmpHorizontalShift(DXD.TransformEffect openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.HorizontalShift?.Value == value) return true;
    diffs?.Add(objName, "HorizontalShift", openXmlElement?.HorizontalShift?.Value, value);
    return false;
  }
  
  private static void SetHorizontalShift(DXD.TransformEffect openXmlElement, Int64? value)
  {
    openXmlElement.HorizontalShift = value;
  }
  
  /// <summary>
  /// Vertical Shift
  /// </summary>
  private static Int64? GetVerticalShift(DXD.TransformEffect openXmlElement)
  {
    return openXmlElement?.VerticalShift?.Value;
  }
  
  private static bool CmpVerticalShift(DXD.TransformEffect openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.VerticalShift?.Value == value) return true;
    diffs?.Add(objName, "VerticalShift", openXmlElement?.VerticalShift?.Value, value);
    return false;
  }
  
  private static void SetVerticalShift(DXD.TransformEffect openXmlElement, Int64? value)
  {
    openXmlElement.VerticalShift = value;
  }
  
  public static DMD.TransformEffect? CreateModelElement(DXD.TransformEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.TransformEffect();
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
  
  public static bool CompareModelElement(DXD.TransformEffect? openXmlElement, DMD.TransformEffect? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHorizontalRatio(openXmlElement, value.HorizontalRatio, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalRatio(openXmlElement, value.VerticalRatio, diffs, objName, propName))
        ok = false;
      if (!CmpHorizontalSkew(openXmlElement, value.HorizontalSkew, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalSkew(openXmlElement, value.VerticalSkew, diffs, objName, propName))
        ok = false;
      if (!CmpHorizontalShift(openXmlElement, value.HorizontalShift, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalShift(openXmlElement, value.VerticalShift, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.TransformEffect value)
    where OpenXmlElementType: DXD.TransformEffect, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.TransformEffect openXmlElement, DMD.TransformEffect value)
  {
    SetHorizontalRatio(openXmlElement, value?.HorizontalRatio);
    SetVerticalRatio(openXmlElement, value?.VerticalRatio);
    SetHorizontalSkew(openXmlElement, value?.HorizontalSkew);
    SetVerticalSkew(openXmlElement, value?.VerticalSkew);
    SetHorizontalShift(openXmlElement, value?.HorizontalShift);
    SetVerticalShift(openXmlElement, value?.VerticalShift);
  }
}
