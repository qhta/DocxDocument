namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Object Extents Including Effects.
/// </summary>
public static class EffectExtentConverter
{
  /// <summary>
  /// Additional Extent on Left Edge
  /// </summary>
  private static Int64 GetLeftEdge(DXDW.EffectExtent openXmlElement)
  {
    return openXmlElement?.LeftEdge?.Value ?? 0;
  }
  
  private static bool CmpLeftEdge(DXDW.EffectExtent openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LeftEdge?.Value == value) return true;
    diffs?.Add(objName, "LeftEdge", openXmlElement?.LeftEdge?.Value, value);
    return false;
  }
  
  private static void SetLeftEdge(DXDW.EffectExtent openXmlElement, Int64? value)
  {
    openXmlElement.LeftEdge = value;
  }
  
  /// <summary>
  /// Additional Extent on Top Edge
  /// </summary>
  private static Int64 GetTopEdge(DXDW.EffectExtent openXmlElement)
  {
    return openXmlElement?.TopEdge?.Value ?? 0;
  }
  
  private static bool CmpTopEdge(DXDW.EffectExtent openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.TopEdge?.Value == value) return true;
    diffs?.Add(objName, "TopEdge", openXmlElement?.TopEdge?.Value, value);
    return false;
  }
  
  private static void SetTopEdge(DXDW.EffectExtent openXmlElement, Int64? value)
  {
    openXmlElement.TopEdge = value;
  }
  
  /// <summary>
  /// Additional Extent on Right Edge
  /// </summary>
  private static Int64 GetRightEdge(DXDW.EffectExtent openXmlElement)
  {
    return openXmlElement?.RightEdge?.Value ?? 0;
  }
  
  private static bool CmpRightEdge(DXDW.EffectExtent openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RightEdge?.Value == value) return true;
    diffs?.Add(objName, "RightEdge", openXmlElement?.RightEdge?.Value, value);
    return false;
  }
  
  private static void SetRightEdge(DXDW.EffectExtent openXmlElement, Int64? value)
  {
    openXmlElement.RightEdge = value;
  }
  
  /// <summary>
  /// Additional Extent on Bottom Edge
  /// </summary>
  private static Int64 GetBottomEdge(DXDW.EffectExtent openXmlElement)
  {
    return openXmlElement?.BottomEdge?.Value ?? 0;
  }
  
  private static bool CmpBottomEdge(DXDW.EffectExtent openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BottomEdge?.Value == value) return true;
    diffs?.Add(objName, "BottomEdge", openXmlElement?.BottomEdge?.Value, value);
    return false;
  }
  
  private static void SetBottomEdge(DXDW.EffectExtent openXmlElement, Int64? value)
  {
    openXmlElement.BottomEdge = value;
  }
  
  public static DocumentModel.Drawings.Wordprocessing.EffectExtent? CreateModelElement(DXDW.EffectExtent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.EffectExtent();
      value.LeftEdge = GetLeftEdge(openXmlElement);
      value.TopEdge = GetTopEdge(openXmlElement);
      value.RightEdge = GetRightEdge(openXmlElement);
      value.BottomEdge = GetBottomEdge(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDW.EffectExtent? openXmlElement, DMDW.EffectExtent? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLeftEdge(openXmlElement, value.LeftEdge, diffs, objName))
        ok = false;
      if (!CmpTopEdge(openXmlElement, value.TopEdge, diffs, objName))
        ok = false;
      if (!CmpRightEdge(openXmlElement, value.RightEdge, diffs, objName))
        ok = false;
      if (!CmpBottomEdge(openXmlElement, value.BottomEdge, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDW.EffectExtent value)
    where OpenXmlElementType: DXDW.EffectExtent, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDW.EffectExtent openXmlElement, DMDW.EffectExtent value)
  {
    SetLeftEdge(openXmlElement, value?.LeftEdge);
    SetTopEdge(openXmlElement, value?.TopEdge);
    SetRightEdge(openXmlElement, value?.RightEdge);
    SetBottomEdge(openXmlElement, value?.BottomEdge);
  }
}
