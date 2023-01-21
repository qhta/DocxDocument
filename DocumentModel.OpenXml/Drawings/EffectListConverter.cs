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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Blur>();
    if (itemElement != null)
      return DMXDraws.BlurConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.FillOverlay>();
    if (itemElement != null)
      return DMXDraws.FillOverlayConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Glow>();
    if (itemElement != null)
      return DMXDraws.GlowConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.InnerShadow>();
    if (itemElement != null)
      return DMXDraws.InnerShadowConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.OuterShadow>();
    if (itemElement != null)
      return DMXDraws.OuterShadowConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.PresetShadow>();
    if (itemElement != null)
      return DMXDraws.PresetShadowConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Reflection>();
    if (itemElement != null)
      return DMXDraws.ReflectionConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SoftEdge>();
    if (itemElement != null)
      return DMXDraws.SoftEdgeConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDraws.EffectList? CreateModelElement(DXDraw.EffectList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.EffectList();
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
