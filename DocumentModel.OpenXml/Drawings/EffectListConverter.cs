namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect Container.
/// </summary>
public static class EffectListConverter
{
  /// <summary>
  /// Blur Effect.
  /// </summary>
  private static DMDraws.Blur? GetBlur(DXDraw.EffectList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Blur>();
    if (element != null)
      return DMXDraws.BlurConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlur(DXDraw.EffectList openXmlElement, DMDraws.Blur? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BlurConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Blur>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBlur(DXDraw.EffectList openXmlElement, DMDraws.Blur? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Blur>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BlurConverter.CreateOpenXmlElement<DXDraw.Blur>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FillOverlay.
  /// </summary>
  private static DMDraws.FillOverlay? GetFillOverlay(DXDraw.EffectList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.FillOverlay>();
    if (element != null)
      return DMXDraws.FillOverlayConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillOverlay(DXDraw.EffectList openXmlElement, DMDraws.FillOverlay? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.FillOverlayConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.FillOverlay>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFillOverlay(DXDraw.EffectList openXmlElement, DMDraws.FillOverlay? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FillOverlay>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.FillOverlayConverter.CreateOpenXmlElement<DXDraw.FillOverlay>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Glow.
  /// </summary>
  private static DMDraws.Glow? GetGlow(DXDraw.EffectList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Glow>();
    if (element != null)
      return DMXDraws.GlowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGlow(DXDraw.EffectList openXmlElement, DMDraws.Glow? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GlowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Glow>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGlow(DXDraw.EffectList openXmlElement, DMDraws.Glow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Glow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.GlowConverter.CreateOpenXmlElement<DXDraw.Glow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// InnerShadow.
  /// </summary>
  private static DMDraws.InnerShadow? GetInnerShadow(DXDraw.EffectList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.InnerShadow>();
    if (element != null)
      return DMXDraws.InnerShadowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInnerShadow(DXDraw.EffectList openXmlElement, DMDraws.InnerShadow? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.InnerShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.InnerShadow>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetInnerShadow(DXDraw.EffectList openXmlElement, DMDraws.InnerShadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.InnerShadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.InnerShadowConverter.CreateOpenXmlElement<DXDraw.InnerShadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OuterShadow.
  /// </summary>
  private static DMDraws.OuterShadow? GetOuterShadow(DXDraw.EffectList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.OuterShadow>();
    if (element != null)
      return DMXDraws.OuterShadowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOuterShadow(DXDraw.EffectList openXmlElement, DMDraws.OuterShadow? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.OuterShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.OuterShadow>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOuterShadow(DXDraw.EffectList openXmlElement, DMDraws.OuterShadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.OuterShadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.OuterShadowConverter.CreateOpenXmlElement<DXDraw.OuterShadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PresetShadow.
  /// </summary>
  private static DMDraws.PresetShadow? GetPresetShadow(DXDraw.EffectList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.PresetShadow>();
    if (element != null)
      return DMXDraws.PresetShadowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetShadow(DXDraw.EffectList openXmlElement, DMDraws.PresetShadow? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PresetShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.PresetShadow>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresetShadow(DXDraw.EffectList openXmlElement, DMDraws.PresetShadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PresetShadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PresetShadowConverter.CreateOpenXmlElement<DXDraw.PresetShadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Reflection.
  /// </summary>
  private static DMDraws.Reflection? GetReflection(DXDraw.EffectList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Reflection>();
    if (element != null)
      return DMXDraws.ReflectionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpReflection(DXDraw.EffectList openXmlElement, DMDraws.Reflection? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ReflectionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Reflection>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetReflection(DXDraw.EffectList openXmlElement, DMDraws.Reflection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Reflection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ReflectionConverter.CreateOpenXmlElement<DXDraw.Reflection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SoftEdge.
  /// </summary>
  private static DMDraws.SoftEdge? GetSoftEdge(DXDraw.EffectList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.SoftEdge>();
    if (element != null)
      return DMXDraws.SoftEdgeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSoftEdge(DXDraw.EffectList openXmlElement, DMDraws.SoftEdge? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SoftEdgeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.SoftEdge>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSoftEdge(DXDraw.EffectList openXmlElement, DMDraws.SoftEdge? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SoftEdge>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SoftEdgeConverter.CreateOpenXmlElement<DXDraw.SoftEdge>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.EffectList? CreateModelElement(DXDraw.EffectList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.EffectList();
      value.Blur = GetBlur(openXmlElement);
      value.FillOverlay = GetFillOverlay(openXmlElement);
      value.Glow = GetGlow(openXmlElement);
      value.InnerShadow = GetInnerShadow(openXmlElement);
      value.OuterShadow = GetOuterShadow(openXmlElement);
      value.PresetShadow = GetPresetShadow(openXmlElement);
      value.Reflection = GetReflection(openXmlElement);
      value.SoftEdge = GetSoftEdge(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.EffectList? openXmlElement, DMDraws.EffectList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBlur(openXmlElement, value.Blur, diffs, objName))
        ok = false;
      if (!CmpFillOverlay(openXmlElement, value.FillOverlay, diffs, objName))
        ok = false;
      if (!CmpGlow(openXmlElement, value.Glow, diffs, objName))
        ok = false;
      if (!CmpInnerShadow(openXmlElement, value.InnerShadow, diffs, objName))
        ok = false;
      if (!CmpOuterShadow(openXmlElement, value.OuterShadow, diffs, objName))
        ok = false;
      if (!CmpPresetShadow(openXmlElement, value.PresetShadow, diffs, objName))
        ok = false;
      if (!CmpReflection(openXmlElement, value.Reflection, diffs, objName))
        ok = false;
      if (!CmpSoftEdge(openXmlElement, value.SoftEdge, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.EffectList? value)
    where OpenXmlElementType: DXDraw.EffectList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlur(openXmlElement, value?.Blur);
      SetFillOverlay(openXmlElement, value?.FillOverlay);
      SetGlow(openXmlElement, value?.Glow);
      SetInnerShadow(openXmlElement, value?.InnerShadow);
      SetOuterShadow(openXmlElement, value?.OuterShadow);
      SetPresetShadow(openXmlElement, value?.PresetShadow);
      SetReflection(openXmlElement, value?.Reflection);
      SetSoftEdge(openXmlElement, value?.SoftEdge);
      return openXmlElement;
    }
    return default;
  }
}
