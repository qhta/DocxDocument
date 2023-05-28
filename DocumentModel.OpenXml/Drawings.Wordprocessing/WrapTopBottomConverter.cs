namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Top and Bottom Wrapping.
/// </summary>
public static class WrapTopBottomConverter
{
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  private static UInt32? GetDistanceFromTop(DXDW.WrapTopBottom openXmlElement)
  {
    return openXmlElement?.DistanceFromTop?.Value;
  }
  
  private static bool CmpDistanceFromTop(DXDW.WrapTopBottom openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DistanceFromTop?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromTop", openXmlElement?.DistanceFromTop?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromTop(DXDW.WrapTopBottom openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromTop = value;
  }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  private static UInt32? GetDistanceFromBottom(DXDW.WrapTopBottom openXmlElement)
  {
    return openXmlElement?.DistanceFromBottom?.Value;
  }
  
  private static bool CmpDistanceFromBottom(DXDW.WrapTopBottom openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DistanceFromBottom?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromBottom", openXmlElement?.DistanceFromBottom?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromBottom(DXDW.WrapTopBottom openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromBottom = value;
  }
  
  /// <summary>
  /// Wrapping Boundaries.
  /// </summary>
  private static DMDW.EffectExtent? GetEffectExtent(DXDW.WrapTopBottom openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.EffectExtent>();
    if (element != null)
      return DMXDW.EffectExtentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectExtent(DXDW.WrapTopBottom openXmlElement, DMDW.EffectExtent? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.EffectExtentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.EffectExtent>(), value, diffs, objName, propName);
  }
  
  private static void SetEffectExtent(DXDW.WrapTopBottom openXmlElement, DMDW.EffectExtent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.EffectExtent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.EffectExtentConverter.CreateOpenXmlElement<DXDW.EffectExtent>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Wordprocessing.WrapTopBottom? CreateModelElement(DXDW.WrapTopBottom? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Wordprocessing.WrapTopBottom();
      value.DistanceFromTop = GetDistanceFromTop(openXmlElement);
      value.DistanceFromBottom = GetDistanceFromBottom(openXmlElement);
      value.EffectExtent = GetEffectExtent(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDW.WrapTopBottom? openXmlElement, DMDW.WrapTopBottom? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDistanceFromTop(openXmlElement, value.DistanceFromTop, diffs, objName, propName))
        ok = false;
      if (!CmpDistanceFromBottom(openXmlElement, value.DistanceFromBottom, diffs, objName, propName))
        ok = false;
      if (!CmpEffectExtent(openXmlElement, value.EffectExtent, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDW.WrapTopBottom value)
    where OpenXmlElementType: DXDW.WrapTopBottom, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDW.WrapTopBottom openXmlElement, DMDW.WrapTopBottom value)
  {
    SetDistanceFromTop(openXmlElement, value?.DistanceFromTop);
    SetDistanceFromBottom(openXmlElement, value?.DistanceFromBottom);
    SetEffectExtent(openXmlElement, value?.EffectExtent);
  }
}
