namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect Container.
/// </summary>
public static class EffectListConverter
{
  /// <summary>
  /// Blur Effect.
  /// </summary>
  private static DMD.Blur? GetBlur(DXD.EffectList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Blur>();
    if (element != null)
      return DMXD.BlurConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlur(DXD.EffectList openXmlElement, DMD.Blur? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.BlurConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Blur>(), value, diffs, objName, propName);
  }
  
  private static void SetBlur(DXD.EffectList openXmlElement, DMD.Blur? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Blur>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BlurConverter.CreateOpenXmlElement<DXD.Blur>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// FillOverlay.
  /// </summary>
  private static DMD.FillOverlay? GetFillOverlay(DXD.EffectList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FillOverlay>();
    if (element != null)
      return DMXD.FillOverlayConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillOverlay(DXD.EffectList openXmlElement, DMD.FillOverlay? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.FillOverlayConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FillOverlay>(), value, diffs, objName, propName);
  }
  
  private static void SetFillOverlay(DXD.EffectList openXmlElement, DMD.FillOverlay? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FillOverlay>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FillOverlayConverter.CreateOpenXmlElement<DXD.FillOverlay>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Glow.
  /// </summary>
  private static DMD.Glow? GetGlow(DXD.EffectList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Glow>();
    if (element != null)
      return DMXD.GlowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGlow(DXD.EffectList openXmlElement, DMD.Glow? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.GlowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Glow>(), value, diffs, objName, propName);
  }
  
  private static void SetGlow(DXD.EffectList openXmlElement, DMD.Glow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Glow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.GlowConverter.CreateOpenXmlElement<DXD.Glow>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// InnerShadow.
  /// </summary>
  private static DMD.InnerShadow? GetInnerShadow(DXD.EffectList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.InnerShadow>();
    if (element != null)
      return DMXD.InnerShadowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInnerShadow(DXD.EffectList openXmlElement, DMD.InnerShadow? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.InnerShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.InnerShadow>(), value, diffs, objName, propName);
  }
  
  private static void SetInnerShadow(DXD.EffectList openXmlElement, DMD.InnerShadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.InnerShadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.InnerShadowConverter.CreateOpenXmlElement<DXD.InnerShadow>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// OuterShadow.
  /// </summary>
  private static DMD.OuterShadow? GetOuterShadow(DXD.EffectList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.OuterShadow>();
    if (element != null)
      return DMXD.OuterShadowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOuterShadow(DXD.EffectList openXmlElement, DMD.OuterShadow? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.OuterShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.OuterShadow>(), value, diffs, objName, propName);
  }
  
  private static void SetOuterShadow(DXD.EffectList openXmlElement, DMD.OuterShadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.OuterShadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.OuterShadowConverter.CreateOpenXmlElement<DXD.OuterShadow>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// PresetShadow.
  /// </summary>
  private static DMD.PresetShadow? GetPresetShadow(DXD.EffectList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PresetShadow>();
    if (element != null)
      return DMXD.PresetShadowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetShadow(DXD.EffectList openXmlElement, DMD.PresetShadow? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.PresetShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PresetShadow>(), value, diffs, objName, propName);
  }
  
  private static void SetPresetShadow(DXD.EffectList openXmlElement, DMD.PresetShadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PresetShadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PresetShadowConverter.CreateOpenXmlElement<DXD.PresetShadow>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Reflection.
  /// </summary>
  private static DMD.Reflection? GetReflection(DXD.EffectList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Reflection>();
    if (element != null)
      return DMXD.ReflectionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpReflection(DXD.EffectList openXmlElement, DMD.Reflection? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ReflectionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Reflection>(), value, diffs, objName, propName);
  }
  
  private static void SetReflection(DXD.EffectList openXmlElement, DMD.Reflection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Reflection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ReflectionConverter.CreateOpenXmlElement<DXD.Reflection>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// SoftEdge.
  /// </summary>
  private static DMD.SoftEdge? GetSoftEdge(DXD.EffectList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SoftEdge>();
    if (element != null)
      return DMXD.SoftEdgeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSoftEdge(DXD.EffectList openXmlElement, DMD.SoftEdge? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.SoftEdgeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SoftEdge>(), value, diffs, objName, propName);
  }
  
  private static void SetSoftEdge(DXD.EffectList openXmlElement, DMD.SoftEdge? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SoftEdge>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SoftEdgeConverter.CreateOpenXmlElement<DXD.SoftEdge>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.EffectList? CreateModelElement(DXD.EffectList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.EffectList();
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
  
  public static bool CompareModelElement(DXD.EffectList? openXmlElement, DMD.EffectList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBlur(openXmlElement, value.Blur, diffs, objName, propName))
        ok = false;
      if (!CmpFillOverlay(openXmlElement, value.FillOverlay, diffs, objName, propName))
        ok = false;
      if (!CmpGlow(openXmlElement, value.Glow, diffs, objName, propName))
        ok = false;
      if (!CmpInnerShadow(openXmlElement, value.InnerShadow, diffs, objName, propName))
        ok = false;
      if (!CmpOuterShadow(openXmlElement, value.OuterShadow, diffs, objName, propName))
        ok = false;
      if (!CmpPresetShadow(openXmlElement, value.PresetShadow, diffs, objName, propName))
        ok = false;
      if (!CmpReflection(openXmlElement, value.Reflection, diffs, objName, propName))
        ok = false;
      if (!CmpSoftEdge(openXmlElement, value.SoftEdge, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.EffectList value)
    where OpenXmlElementType: DXD.EffectList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.EffectList openXmlElement, DMD.EffectList value)
  {
    SetBlur(openXmlElement, value?.Blur);
    SetFillOverlay(openXmlElement, value?.FillOverlay);
    SetGlow(openXmlElement, value?.Glow);
    SetInnerShadow(openXmlElement, value?.InnerShadow);
    SetOuterShadow(openXmlElement, value?.OuterShadow);
    SetPresetShadow(openXmlElement, value?.PresetShadow);
    SetReflection(openXmlElement, value?.Reflection);
    SetSoftEdge(openXmlElement, value?.SoftEdge);
  }
}
