namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Object Extents Including Effects converter from/to OpenXml.
///</summary>
public static class EffectExtentConverter
{
  /// <summary>
  /// Additional Extent on Left Edge
  /// </summary>
  private static Int64 GetLeftEdge(DXDrawW.EffectExtent openXmlElement)
  {
    return openXmlElement?.LeftEdge?.Value ?? 0;
  }
  
  private static bool CmpLeftEdge(DXDrawW.EffectExtent openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LeftEdge?.Value == value) return true;
    diffs?.Add(objName, "LeftEdge", openXmlElement?.LeftEdge?.Value, value);
    return false;
  }
  
  private static void SetLeftEdge(DXDrawW.EffectExtent openXmlElement, Int64? value)
  {
    openXmlElement.LeftEdge = value;
  }
  
  /// <summary>
  /// Additional Extent on Top Edge
  /// </summary>
  private static Int64 GetTopEdge(DXDrawW.EffectExtent openXmlElement)
  {
    return openXmlElement?.TopEdge?.Value ?? 0;
  }
  
  private static bool CmpTopEdge(DXDrawW.EffectExtent openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.TopEdge?.Value == value) return true;
    diffs?.Add(objName, "TopEdge", openXmlElement?.TopEdge?.Value, value);
    return false;
  }
  
  private static void SetTopEdge(DXDrawW.EffectExtent openXmlElement, Int64? value)
  {
    openXmlElement.TopEdge = value;
  }
  
  /// <summary>
  /// Additional Extent on Right Edge
  /// </summary>
  private static Int64 GetRightEdge(DXDrawW.EffectExtent openXmlElement)
  {
    return openXmlElement?.RightEdge?.Value ?? 0;
  }
  
  private static bool CmpRightEdge(DXDrawW.EffectExtent openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RightEdge?.Value == value) return true;
    diffs?.Add(objName, "RightEdge", openXmlElement?.RightEdge?.Value, value);
    return false;
  }
  
  private static void SetRightEdge(DXDrawW.EffectExtent openXmlElement, Int64? value)
  {
    openXmlElement.RightEdge = value;
  }
  
  /// <summary>
  /// Additional Extent on Bottom Edge
  /// </summary>
  private static Int64 GetBottomEdge(DXDrawW.EffectExtent openXmlElement)
  {
    return openXmlElement?.BottomEdge?.Value ?? 0;
  }
  
  private static bool CmpBottomEdge(DXDrawW.EffectExtent openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BottomEdge?.Value == value) return true;
    diffs?.Add(objName, "BottomEdge", openXmlElement?.BottomEdge?.Value, value);
    return false;
  }
  
  private static void SetBottomEdge(DXDrawW.EffectExtent openXmlElement, Int64? value)
  {
    openXmlElement.BottomEdge = value;
  }
  
  public static DocumentModel.Drawings.Wordprocessing.EffectExtent? CreateModelElement(DXDrawW.EffectExtent? openXmlElement)
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
  
  public static bool CompareModelElement(DXDrawW.EffectExtent? openXmlElement, DMDrawsW.EffectExtent? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.EffectExtent value)
    where OpenXmlElementType: DXDrawW.EffectExtent, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawW.EffectExtent openXmlElement, DMDrawsW.EffectExtent value)
  {
    SetLeftEdge(openXmlElement, value?.LeftEdge);
    SetTopEdge(openXmlElement, value?.TopEdge);
    SetRightEdge(openXmlElement, value?.RightEdge);
    SetBottomEdge(openXmlElement, value?.BottomEdge);
  }
}
