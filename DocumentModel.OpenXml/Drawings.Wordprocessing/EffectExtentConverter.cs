namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Object Extents Including Effects.
/// </summary>
public static class EffectExtentConverter
{
  /// <summary>
  /// Additional Extent on Left Edge
  /// </summary>
  private static Int64? GetLeftEdge(DXDrawW.EffectExtent openXmlElement)
  {
    return openXmlElement.LeftEdge?.Value;
  }
  
  private static bool CmpLeftEdge(DXDrawW.EffectExtent openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.LeftEdge?.Value == value;
  }
  
  private static void SetLeftEdge(DXDrawW.EffectExtent openXmlElement, Int64? value)
  {
    openXmlElement.LeftEdge = value;
  }
  
  /// <summary>
  /// Additional Extent on Top Edge
  /// </summary>
  private static Int64? GetTopEdge(DXDrawW.EffectExtent openXmlElement)
  {
    return openXmlElement.TopEdge?.Value;
  }
  
  private static bool CmpTopEdge(DXDrawW.EffectExtent openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.TopEdge?.Value == value;
  }
  
  private static void SetTopEdge(DXDrawW.EffectExtent openXmlElement, Int64? value)
  {
    openXmlElement.TopEdge = value;
  }
  
  /// <summary>
  /// Additional Extent on Right Edge
  /// </summary>
  private static Int64? GetRightEdge(DXDrawW.EffectExtent openXmlElement)
  {
    return openXmlElement.RightEdge?.Value;
  }
  
  private static bool CmpRightEdge(DXDrawW.EffectExtent openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.RightEdge?.Value == value;
  }
  
  private static void SetRightEdge(DXDrawW.EffectExtent openXmlElement, Int64? value)
  {
    openXmlElement.RightEdge = value;
  }
  
  /// <summary>
  /// Additional Extent on Bottom Edge
  /// </summary>
  private static Int64? GetBottomEdge(DXDrawW.EffectExtent openXmlElement)
  {
    return openXmlElement.BottomEdge?.Value;
  }
  
  private static bool CmpBottomEdge(DXDrawW.EffectExtent openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.BottomEdge?.Value == value;
  }
  
  private static void SetBottomEdge(DXDrawW.EffectExtent openXmlElement, Int64? value)
  {
    openXmlElement.BottomEdge = value;
  }
  
  public static DMDrawsW.EffectExtent? CreateModelElement(DXDrawW.EffectExtent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsW.EffectExtent();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.EffectExtent? value)
    where OpenXmlElementType: DXDrawW.EffectExtent, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLeftEdge(openXmlElement, value?.LeftEdge);
      SetTopEdge(openXmlElement, value?.TopEdge);
      SetRightEdge(openXmlElement, value?.RightEdge);
      SetBottomEdge(openXmlElement, value?.BottomEdge);
      return openXmlElement;
    }
    return default;
  }
}
