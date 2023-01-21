namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect Container.
/// </summary>
public static class EffectContainerConverter
{
  private static DMDraws.EffectContainer? GetChildEffectContainer(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.EffectContainer>();
    if (itemElement != null)
      return DMXDraws.EffectContainerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChildEffectContainer(DXDraw.EffectContainer openXmlElement, DMDraws.EffectContainer? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EffectContainer>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EffectContainerConverter.CreateOpenXmlElement<DXDraw.EffectContainer>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Effect? GetEffect(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Effect>();
    if (itemElement != null)
      return DMXDraws.EffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffect(DXDraw.EffectContainer openXmlElement, DMDraws.Effect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Effect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EffectConverter.CreateOpenXmlElement<DXDraw.Effect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.AlphaBiLevel? GetAlphaBiLevel(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaBiLevel>();
    if (itemElement != null)
      return DMXDraws.AlphaBiLevelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaBiLevel(DXDraw.EffectContainer openXmlElement, DMDraws.AlphaBiLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaBiLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AlphaBiLevelConverter.CreateOpenXmlElement<DXDraw.AlphaBiLevel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAlphaCeiling(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaCeiling>();
    return itemElement != null;
  }
  
  private static void SetAlphaCeiling(DXDraw.EffectContainer openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaCeiling>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.AlphaCeiling();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAlphaFloor(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaFloor>();
    return itemElement != null;
  }
  
  private static void SetAlphaFloor(DXDraw.EffectContainer openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaFloor>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.AlphaFloor();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.AlphaInverse? GetAlphaInverse(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaInverse>();
    if (itemElement != null)
      return DMXDraws.AlphaInverseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaInverse(DXDraw.EffectContainer openXmlElement, DMDraws.AlphaInverse? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaInverse>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AlphaInverseConverter.CreateOpenXmlElement<DXDraw.AlphaInverse>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.AlphaModulationEffect? GetAlphaModulationEffect(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaModulationEffect>();
    if (itemElement != null)
      return DMXDraws.AlphaModulationEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaModulationEffect(DXDraw.EffectContainer openXmlElement, DMDraws.AlphaModulationEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaModulationEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AlphaModulationEffectConverter.CreateOpenXmlElement<DXDraw.AlphaModulationEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.AlphaModulationFixed? GetAlphaModulationFixed(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaModulationFixed>();
    if (itemElement != null)
      return DMXDraws.AlphaModulationFixedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaModulationFixed(DXDraw.EffectContainer openXmlElement, DMDraws.AlphaModulationFixed? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaModulationFixed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AlphaModulationFixedConverter.CreateOpenXmlElement<DXDraw.AlphaModulationFixed>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.AlphaOutset? GetAlphaOutset(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaOutset>();
    if (itemElement != null)
      return DMXDraws.AlphaOutsetConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaOutset(DXDraw.EffectContainer openXmlElement, DMDraws.AlphaOutset? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaOutset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AlphaOutsetConverter.CreateOpenXmlElement<DXDraw.AlphaOutset>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.AlphaReplace? GetAlphaReplace(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaReplace>();
    if (itemElement != null)
      return DMXDraws.AlphaReplaceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaReplace(DXDraw.EffectContainer openXmlElement, DMDraws.AlphaReplace? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaReplace>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AlphaReplaceConverter.CreateOpenXmlElement<DXDraw.AlphaReplace>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.BiLevel? GetBiLevel(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BiLevel>();
    if (itemElement != null)
      return DMXDraws.BiLevelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBiLevel(DXDraw.EffectContainer openXmlElement, DMDraws.BiLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BiLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BiLevelConverter.CreateOpenXmlElement<DXDraw.BiLevel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Blend? GetBlend(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Blend>();
    if (itemElement != null)
      return DMXDraws.BlendConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBlend(DXDraw.EffectContainer openXmlElement, DMDraws.Blend? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Blend>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BlendConverter.CreateOpenXmlElement<DXDraw.Blend>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Blur? GetBlur(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Blur>();
    if (itemElement != null)
      return DMXDraws.BlurConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBlur(DXDraw.EffectContainer openXmlElement, DMDraws.Blur? value)
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
  
  private static DMDraws.ColorChange? GetColorChange(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ColorChange>();
    if (itemElement != null)
      return DMXDraws.ColorChangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorChange(DXDraw.EffectContainer openXmlElement, DMDraws.ColorChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ColorChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ColorChangeConverter.CreateOpenXmlElement<DXDraw.ColorChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.ColorReplacement? GetColorReplacement(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ColorReplacement>();
    if (itemElement != null)
      return DMXDraws.ColorReplacementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorReplacement(DXDraw.EffectContainer openXmlElement, DMDraws.ColorReplacement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ColorReplacement>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ColorReplacementConverter.CreateOpenXmlElement<DXDraw.ColorReplacement>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Duotone? GetDuotone(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Duotone>();
    if (itemElement != null)
      return DMXDraws.DuotoneConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDuotone(DXDraw.EffectContainer openXmlElement, DMDraws.Duotone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Duotone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.DuotoneConverter.CreateOpenXmlElement<DXDraw.Duotone>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Fill? GetFill(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Fill>();
    if (itemElement != null)
      return DMXDraws.FillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFill(DXDraw.EffectContainer openXmlElement, DMDraws.Fill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Fill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.FillConverter.CreateOpenXmlElement<DXDraw.Fill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.FillOverlay? GetFillOverlay(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.FillOverlay>();
    if (itemElement != null)
      return DMXDraws.FillOverlayConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFillOverlay(DXDraw.EffectContainer openXmlElement, DMDraws.FillOverlay? value)
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
  
  private static DMDraws.Glow? GetGlow(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Glow>();
    if (itemElement != null)
      return DMXDraws.GlowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGlow(DXDraw.EffectContainer openXmlElement, DMDraws.Glow? value)
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
  
  private static Boolean? GetGrayscale(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Grayscale>();
    return itemElement != null;
  }
  
  private static void SetGrayscale(DXDraw.EffectContainer openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.Grayscale>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.Grayscale();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Hsl? GetHsl(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Hsl>();
    if (itemElement != null)
      return DMXDraws.HslConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHsl(DXDraw.EffectContainer openXmlElement, DMDraws.Hsl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Hsl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HslConverter.CreateOpenXmlElement<DXDraw.Hsl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.InnerShadow? GetInnerShadow(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.InnerShadow>();
    if (itemElement != null)
      return DMXDraws.InnerShadowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetInnerShadow(DXDraw.EffectContainer openXmlElement, DMDraws.InnerShadow? value)
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
  
  private static DMDraws.LuminanceEffect? GetLuminanceEffect(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LuminanceEffect>();
    if (itemElement != null)
      return DMXDraws.LuminanceEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLuminanceEffect(DXDraw.EffectContainer openXmlElement, DMDraws.LuminanceEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LuminanceEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LuminanceEffectConverter.CreateOpenXmlElement<DXDraw.LuminanceEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.OuterShadow? GetOuterShadow(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.OuterShadow>();
    if (itemElement != null)
      return DMXDraws.OuterShadowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOuterShadow(DXDraw.EffectContainer openXmlElement, DMDraws.OuterShadow? value)
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
  
  private static DMDraws.PresetShadow? GetPresetShadow(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.PresetShadow>();
    if (itemElement != null)
      return DMXDraws.PresetShadowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPresetShadow(DXDraw.EffectContainer openXmlElement, DMDraws.PresetShadow? value)
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
  
  private static DMDraws.Reflection? GetReflection(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Reflection>();
    if (itemElement != null)
      return DMXDraws.ReflectionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetReflection(DXDraw.EffectContainer openXmlElement, DMDraws.Reflection? value)
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
  
  private static DMDraws.RelativeOffset? GetRelativeOffset(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RelativeOffset>();
    if (itemElement != null)
      return DMXDraws.RelativeOffsetConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRelativeOffset(DXDraw.EffectContainer openXmlElement, DMDraws.RelativeOffset? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.RelativeOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RelativeOffsetConverter.CreateOpenXmlElement<DXDraw.RelativeOffset>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.SoftEdge? GetSoftEdge(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SoftEdge>();
    if (itemElement != null)
      return DMXDraws.SoftEdgeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSoftEdge(DXDraw.EffectContainer openXmlElement, DMDraws.SoftEdge? value)
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
  
  private static DMDraws.TintEffect? GetTintEffect(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.TintEffect>();
    if (itemElement != null)
      return DMXDraws.TintEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTintEffect(DXDraw.EffectContainer openXmlElement, DMDraws.TintEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.TintEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TintEffectConverter.CreateOpenXmlElement<DXDraw.TintEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.TransformEffect? GetTransformEffect(DXDraw.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.TransformEffect>();
    if (itemElement != null)
      return DMXDraws.TransformEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTransformEffect(DXDraw.EffectContainer openXmlElement, DMDraws.TransformEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.TransformEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TransformEffectConverter.CreateOpenXmlElement<DXDraw.TransformEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.EffectContainer? CreateModelElement(DXDraw.EffectContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.EffectContainer();
      value.ChildEffectContainer = GetChildEffectContainer(openXmlElement);
      value.Effect = GetEffect(openXmlElement);
      value.AlphaBiLevel = GetAlphaBiLevel(openXmlElement);
      value.AlphaCeiling = GetAlphaCeiling(openXmlElement);
      value.AlphaFloor = GetAlphaFloor(openXmlElement);
      value.AlphaInverse = GetAlphaInverse(openXmlElement);
      value.AlphaModulationEffect = GetAlphaModulationEffect(openXmlElement);
      value.AlphaModulationFixed = GetAlphaModulationFixed(openXmlElement);
      value.AlphaOutset = GetAlphaOutset(openXmlElement);
      value.AlphaReplace = GetAlphaReplace(openXmlElement);
      value.BiLevel = GetBiLevel(openXmlElement);
      value.Blend = GetBlend(openXmlElement);
      value.Blur = GetBlur(openXmlElement);
      value.ColorChange = GetColorChange(openXmlElement);
      value.ColorReplacement = GetColorReplacement(openXmlElement);
      value.Duotone = GetDuotone(openXmlElement);
      value.Fill = GetFill(openXmlElement);
      value.FillOverlay = GetFillOverlay(openXmlElement);
      value.Glow = GetGlow(openXmlElement);
      value.Grayscale = GetGrayscale(openXmlElement);
      value.Hsl = GetHsl(openXmlElement);
      value.InnerShadow = GetInnerShadow(openXmlElement);
      value.LuminanceEffect = GetLuminanceEffect(openXmlElement);
      value.OuterShadow = GetOuterShadow(openXmlElement);
      value.PresetShadow = GetPresetShadow(openXmlElement);
      value.Reflection = GetReflection(openXmlElement);
      value.RelativeOffset = GetRelativeOffset(openXmlElement);
      value.SoftEdge = GetSoftEdge(openXmlElement);
      value.TintEffect = GetTintEffect(openXmlElement);
      value.TransformEffect = GetTransformEffect(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.EffectContainer? value)
    where OpenXmlElementType: DXDraw.EffectContainer, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChildEffectContainer(openXmlElement, value?.ChildEffectContainer);
      SetEffect(openXmlElement, value?.Effect);
      SetAlphaBiLevel(openXmlElement, value?.AlphaBiLevel);
      SetAlphaCeiling(openXmlElement, value?.AlphaCeiling);
      SetAlphaFloor(openXmlElement, value?.AlphaFloor);
      SetAlphaInverse(openXmlElement, value?.AlphaInverse);
      SetAlphaModulationEffect(openXmlElement, value?.AlphaModulationEffect);
      SetAlphaModulationFixed(openXmlElement, value?.AlphaModulationFixed);
      SetAlphaOutset(openXmlElement, value?.AlphaOutset);
      SetAlphaReplace(openXmlElement, value?.AlphaReplace);
      SetBiLevel(openXmlElement, value?.BiLevel);
      SetBlend(openXmlElement, value?.Blend);
      SetBlur(openXmlElement, value?.Blur);
      SetColorChange(openXmlElement, value?.ColorChange);
      SetColorReplacement(openXmlElement, value?.ColorReplacement);
      SetDuotone(openXmlElement, value?.Duotone);
      SetFill(openXmlElement, value?.Fill);
      SetFillOverlay(openXmlElement, value?.FillOverlay);
      SetGlow(openXmlElement, value?.Glow);
      SetGrayscale(openXmlElement, value?.Grayscale);
      SetHsl(openXmlElement, value?.Hsl);
      SetInnerShadow(openXmlElement, value?.InnerShadow);
      SetLuminanceEffect(openXmlElement, value?.LuminanceEffect);
      SetOuterShadow(openXmlElement, value?.OuterShadow);
      SetPresetShadow(openXmlElement, value?.PresetShadow);
      SetReflection(openXmlElement, value?.Reflection);
      SetRelativeOffset(openXmlElement, value?.RelativeOffset);
      SetSoftEdge(openXmlElement, value?.SoftEdge);
      SetTintEffect(openXmlElement, value?.TintEffect);
      SetTransformEffect(openXmlElement, value?.TransformEffect);
      return openXmlElement;
    }
    return default;
  }
}
