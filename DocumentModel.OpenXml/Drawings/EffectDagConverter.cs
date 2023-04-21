namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect Container.
/// </summary>
public static class EffectDagConverter
{
  private static DMD.EffectContainer? GetEffectContainer(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectContainer>();
    if (element != null)
      return DMXD.EffectContainerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectContainer(DXD.EffectDag openXmlElement, DMD.EffectContainer? value, DiffList? diffs, string? objName)
  {
    return DMXD.EffectContainerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectContainer>(), value, diffs, objName);
  }
  
  private static void SetEffectContainer(DXD.EffectDag openXmlElement, DMD.EffectContainer? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectContainer>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EffectContainerConverter.CreateOpenXmlElement<DXD.EffectContainer>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.Effect? GetEffect(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Effect>();
    if (element != null)
      return DMXD.EffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffect(DXD.EffectDag openXmlElement, DMD.Effect? value, DiffList? diffs, string? objName)
  {
    return DMXD.EffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Effect>(), value, diffs, objName);
  }
  
  private static void SetEffect(DXD.EffectDag openXmlElement, DMD.Effect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Effect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EffectConverter.CreateOpenXmlElement<DXD.Effect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.AlphaBiLevel? GetAlphaBiLevel(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AlphaBiLevel>();
    if (element != null)
      return DMXD.AlphaBiLevelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaBiLevel(DXD.EffectDag openXmlElement, DMD.AlphaBiLevel? value, DiffList? diffs, string? objName)
  {
    return DMXD.AlphaBiLevelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AlphaBiLevel>(), value, diffs, objName);
  }
  
  private static void SetAlphaBiLevel(DXD.EffectDag openXmlElement, DMD.AlphaBiLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaBiLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AlphaBiLevelConverter.CreateOpenXmlElement<DXD.AlphaBiLevel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAlphaCeiling(DXD.EffectDag openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.AlphaCeiling>() != null;
  }
  
  private static bool CmpAlphaCeiling(DXD.EffectDag openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.AlphaCeiling>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.AlphaCeiling", val, value);
    return false;
  }
  
  private static void SetAlphaCeiling(DXD.EffectDag openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.AlphaCeiling>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.AlphaCeiling();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAlphaFloor(DXD.EffectDag openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.AlphaFloor>() != null;
  }
  
  private static bool CmpAlphaFloor(DXD.EffectDag openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.AlphaFloor>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.AlphaFloor", val, value);
    return false;
  }
  
  private static void SetAlphaFloor(DXD.EffectDag openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.AlphaFloor>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.AlphaFloor();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.AlphaInverse? GetAlphaInverse(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AlphaInverse>();
    if (element != null)
      return DMXD.AlphaInverseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaInverse(DXD.EffectDag openXmlElement, DMD.AlphaInverse? value, DiffList? diffs, string? objName)
  {
    return DMXD.AlphaInverseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AlphaInverse>(), value, diffs, objName);
  }
  
  private static void SetAlphaInverse(DXD.EffectDag openXmlElement, DMD.AlphaInverse? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaInverse>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AlphaInverseConverter.CreateOpenXmlElement<DXD.AlphaInverse>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.AlphaModulationEffect? GetAlphaModulationEffect(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AlphaModulationEffect>();
    if (element != null)
      return DMXD.AlphaModulationEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaModulationEffect(DXD.EffectDag openXmlElement, DMD.AlphaModulationEffect? value, DiffList? diffs, string? objName)
  {
    return DMXD.AlphaModulationEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AlphaModulationEffect>(), value, diffs, objName);
  }
  
  private static void SetAlphaModulationEffect(DXD.EffectDag openXmlElement, DMD.AlphaModulationEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaModulationEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AlphaModulationEffectConverter.CreateOpenXmlElement<DXD.AlphaModulationEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.AlphaModulationFixed? GetAlphaModulationFixed(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AlphaModulationFixed>();
    if (element != null)
      return DMXD.AlphaModulationFixedConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaModulationFixed(DXD.EffectDag openXmlElement, DMD.AlphaModulationFixed? value, DiffList? diffs, string? objName)
  {
    return DMXD.AlphaModulationFixedConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AlphaModulationFixed>(), value, diffs, objName);
  }
  
  private static void SetAlphaModulationFixed(DXD.EffectDag openXmlElement, DMD.AlphaModulationFixed? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaModulationFixed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AlphaModulationFixedConverter.CreateOpenXmlElement<DXD.AlphaModulationFixed>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.AlphaOutset? GetAlphaOutset(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AlphaOutset>();
    if (element != null)
      return DMXD.AlphaOutsetConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaOutset(DXD.EffectDag openXmlElement, DMD.AlphaOutset? value, DiffList? diffs, string? objName)
  {
    return DMXD.AlphaOutsetConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AlphaOutset>(), value, diffs, objName);
  }
  
  private static void SetAlphaOutset(DXD.EffectDag openXmlElement, DMD.AlphaOutset? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaOutset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AlphaOutsetConverter.CreateOpenXmlElement<DXD.AlphaOutset>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.AlphaReplace? GetAlphaReplace(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AlphaReplace>();
    if (element != null)
      return DMXD.AlphaReplaceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaReplace(DXD.EffectDag openXmlElement, DMD.AlphaReplace? value, DiffList? diffs, string? objName)
  {
    return DMXD.AlphaReplaceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AlphaReplace>(), value, diffs, objName);
  }
  
  private static void SetAlphaReplace(DXD.EffectDag openXmlElement, DMD.AlphaReplace? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaReplace>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AlphaReplaceConverter.CreateOpenXmlElement<DXD.AlphaReplace>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.BiLevel? GetBiLevel(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BiLevel>();
    if (element != null)
      return DMXD.BiLevelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBiLevel(DXD.EffectDag openXmlElement, DMD.BiLevel? value, DiffList? diffs, string? objName)
  {
    return DMXD.BiLevelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BiLevel>(), value, diffs, objName);
  }
  
  private static void SetBiLevel(DXD.EffectDag openXmlElement, DMD.BiLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BiLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BiLevelConverter.CreateOpenXmlElement<DXD.BiLevel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.Blend? GetBlend(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Blend>();
    if (element != null)
      return DMXD.BlendConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlend(DXD.EffectDag openXmlElement, DMD.Blend? value, DiffList? diffs, string? objName)
  {
    return DMXD.BlendConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Blend>(), value, diffs, objName);
  }
  
  private static void SetBlend(DXD.EffectDag openXmlElement, DMD.Blend? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Blend>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BlendConverter.CreateOpenXmlElement<DXD.Blend>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.Blur? GetBlur(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Blur>();
    if (element != null)
      return DMXD.BlurConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlur(DXD.EffectDag openXmlElement, DMD.Blur? value, DiffList? diffs, string? objName)
  {
    return DMXD.BlurConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Blur>(), value, diffs, objName);
  }
  
  private static void SetBlur(DXD.EffectDag openXmlElement, DMD.Blur? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Blur>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BlurConverter.CreateOpenXmlElement<DXD.Blur>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.ColorChange? GetColorChange(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ColorChange>();
    if (element != null)
      return DMXD.ColorChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorChange(DXD.EffectDag openXmlElement, DMD.ColorChange? value, DiffList? diffs, string? objName)
  {
    return DMXD.ColorChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ColorChange>(), value, diffs, objName);
  }
  
  private static void SetColorChange(DXD.EffectDag openXmlElement, DMD.ColorChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ColorChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ColorChangeConverter.CreateOpenXmlElement<DXD.ColorChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.ColorReplacement? GetColorReplacement(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ColorReplacement>();
    if (element != null)
      return DMXD.ColorReplacementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorReplacement(DXD.EffectDag openXmlElement, DMD.ColorReplacement? value, DiffList? diffs, string? objName)
  {
    return DMXD.ColorReplacementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ColorReplacement>(), value, diffs, objName);
  }
  
  private static void SetColorReplacement(DXD.EffectDag openXmlElement, DMD.ColorReplacement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ColorReplacement>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ColorReplacementConverter.CreateOpenXmlElement<DXD.ColorReplacement>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.Duotone? GetDuotone(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Duotone>();
    if (element != null)
      return DMXD.DuotoneConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDuotone(DXD.EffectDag openXmlElement, DMD.Duotone? value, DiffList? diffs, string? objName)
  {
    return DMXD.DuotoneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Duotone>(), value, diffs, objName);
  }
  
  private static void SetDuotone(DXD.EffectDag openXmlElement, DMD.Duotone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Duotone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.DuotoneConverter.CreateOpenXmlElement<DXD.Duotone>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.Fill? GetFill(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Fill>();
    if (element != null)
      return DMXD.FillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFill(DXD.EffectDag openXmlElement, DMD.Fill? value, DiffList? diffs, string? objName)
  {
    return DMXD.FillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Fill>(), value, diffs, objName);
  }
  
  private static void SetFill(DXD.EffectDag openXmlElement, DMD.Fill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Fill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FillConverter.CreateOpenXmlElement<DXD.Fill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.FillOverlay? GetFillOverlay(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FillOverlay>();
    if (element != null)
      return DMXD.FillOverlayConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillOverlay(DXD.EffectDag openXmlElement, DMD.FillOverlay? value, DiffList? diffs, string? objName)
  {
    return DMXD.FillOverlayConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FillOverlay>(), value, diffs, objName);
  }
  
  private static void SetFillOverlay(DXD.EffectDag openXmlElement, DMD.FillOverlay? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FillOverlay>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FillOverlayConverter.CreateOpenXmlElement<DXD.FillOverlay>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.Glow? GetGlow(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Glow>();
    if (element != null)
      return DMXD.GlowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGlow(DXD.EffectDag openXmlElement, DMD.Glow? value, DiffList? diffs, string? objName)
  {
    return DMXD.GlowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Glow>(), value, diffs, objName);
  }
  
  private static void SetGlow(DXD.EffectDag openXmlElement, DMD.Glow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Glow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.GlowConverter.CreateOpenXmlElement<DXD.Glow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean GetGrayscale(DXD.EffectDag openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Grayscale>() != null;
  }
  
  private static bool CmpGrayscale(DXD.EffectDag openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.Grayscale>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Grayscale", val, value);
    return false;
  }
  
  private static void SetGrayscale(DXD.EffectDag openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.Grayscale>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.Grayscale();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.Hsl? GetHsl(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Hsl>();
    if (element != null)
      return DMXD.HslConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHsl(DXD.EffectDag openXmlElement, DMD.Hsl? value, DiffList? diffs, string? objName)
  {
    return DMXD.HslConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Hsl>(), value, diffs, objName);
  }
  
  private static void SetHsl(DXD.EffectDag openXmlElement, DMD.Hsl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Hsl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.HslConverter.CreateOpenXmlElement<DXD.Hsl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.InnerShadow? GetInnerShadow(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.InnerShadow>();
    if (element != null)
      return DMXD.InnerShadowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInnerShadow(DXD.EffectDag openXmlElement, DMD.InnerShadow? value, DiffList? diffs, string? objName)
  {
    return DMXD.InnerShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.InnerShadow>(), value, diffs, objName);
  }
  
  private static void SetInnerShadow(DXD.EffectDag openXmlElement, DMD.InnerShadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.InnerShadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.InnerShadowConverter.CreateOpenXmlElement<DXD.InnerShadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.LuminanceEffect? GetLuminanceEffect(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LuminanceEffect>();
    if (element != null)
      return DMXD.LuminanceEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLuminanceEffect(DXD.EffectDag openXmlElement, DMD.LuminanceEffect? value, DiffList? diffs, string? objName)
  {
    return DMXD.LuminanceEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LuminanceEffect>(), value, diffs, objName);
  }
  
  private static void SetLuminanceEffect(DXD.EffectDag openXmlElement, DMD.LuminanceEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LuminanceEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LuminanceEffectConverter.CreateOpenXmlElement<DXD.LuminanceEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.OuterShadow? GetOuterShadow(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.OuterShadow>();
    if (element != null)
      return DMXD.OuterShadowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOuterShadow(DXD.EffectDag openXmlElement, DMD.OuterShadow? value, DiffList? diffs, string? objName)
  {
    return DMXD.OuterShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.OuterShadow>(), value, diffs, objName);
  }
  
  private static void SetOuterShadow(DXD.EffectDag openXmlElement, DMD.OuterShadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.OuterShadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.OuterShadowConverter.CreateOpenXmlElement<DXD.OuterShadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.PresetShadow? GetPresetShadow(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PresetShadow>();
    if (element != null)
      return DMXD.PresetShadowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetShadow(DXD.EffectDag openXmlElement, DMD.PresetShadow? value, DiffList? diffs, string? objName)
  {
    return DMXD.PresetShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PresetShadow>(), value, diffs, objName);
  }
  
  private static void SetPresetShadow(DXD.EffectDag openXmlElement, DMD.PresetShadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PresetShadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PresetShadowConverter.CreateOpenXmlElement<DXD.PresetShadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.Reflection? GetReflection(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Reflection>();
    if (element != null)
      return DMXD.ReflectionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpReflection(DXD.EffectDag openXmlElement, DMD.Reflection? value, DiffList? diffs, string? objName)
  {
    return DMXD.ReflectionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Reflection>(), value, diffs, objName);
  }
  
  private static void SetReflection(DXD.EffectDag openXmlElement, DMD.Reflection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Reflection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ReflectionConverter.CreateOpenXmlElement<DXD.Reflection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.RelativeOffset? GetRelativeOffset(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.RelativeOffset>();
    if (element != null)
      return DMXD.RelativeOffsetConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRelativeOffset(DXD.EffectDag openXmlElement, DMD.RelativeOffset? value, DiffList? diffs, string? objName)
  {
    return DMXD.RelativeOffsetConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.RelativeOffset>(), value, diffs, objName);
  }
  
  private static void SetRelativeOffset(DXD.EffectDag openXmlElement, DMD.RelativeOffset? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.RelativeOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RelativeOffsetConverter.CreateOpenXmlElement<DXD.RelativeOffset>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.SoftEdge? GetSoftEdge(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SoftEdge>();
    if (element != null)
      return DMXD.SoftEdgeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSoftEdge(DXD.EffectDag openXmlElement, DMD.SoftEdge? value, DiffList? diffs, string? objName)
  {
    return DMXD.SoftEdgeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SoftEdge>(), value, diffs, objName);
  }
  
  private static void SetSoftEdge(DXD.EffectDag openXmlElement, DMD.SoftEdge? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SoftEdge>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SoftEdgeConverter.CreateOpenXmlElement<DXD.SoftEdge>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.TintEffect? GetTintEffect(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.TintEffect>();
    if (element != null)
      return DMXD.TintEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTintEffect(DXD.EffectDag openXmlElement, DMD.TintEffect? value, DiffList? diffs, string? objName)
  {
    return DMXD.TintEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.TintEffect>(), value, diffs, objName);
  }
  
  private static void SetTintEffect(DXD.EffectDag openXmlElement, DMD.TintEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.TintEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.TintEffectConverter.CreateOpenXmlElement<DXD.TintEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.TransformEffect? GetTransformEffect(DXD.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.TransformEffect>();
    if (element != null)
      return DMXD.TransformEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTransformEffect(DXD.EffectDag openXmlElement, DMD.TransformEffect? value, DiffList? diffs, string? objName)
  {
    return DMXD.TransformEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.TransformEffect>(), value, diffs, objName);
  }
  
  private static void SetTransformEffect(DXD.EffectDag openXmlElement, DMD.TransformEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.TransformEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.TransformEffectConverter.CreateOpenXmlElement<DXD.TransformEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.EffectDag? CreateModelElement(DXD.EffectDag? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.EffectDag();
      value.EffectContainer = GetEffectContainer(openXmlElement);
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
  
  public static bool CompareModelElement(DXD.EffectDag? openXmlElement, DMD.EffectDag? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEffectContainer(openXmlElement, value.EffectContainer, diffs, objName))
        ok = false;
      if (!CmpEffect(openXmlElement, value.Effect, diffs, objName))
        ok = false;
      if (!CmpAlphaBiLevel(openXmlElement, value.AlphaBiLevel, diffs, objName))
        ok = false;
      if (!CmpAlphaCeiling(openXmlElement, value.AlphaCeiling, diffs, objName))
        ok = false;
      if (!CmpAlphaFloor(openXmlElement, value.AlphaFloor, diffs, objName))
        ok = false;
      if (!CmpAlphaInverse(openXmlElement, value.AlphaInverse, diffs, objName))
        ok = false;
      if (!CmpAlphaModulationEffect(openXmlElement, value.AlphaModulationEffect, diffs, objName))
        ok = false;
      if (!CmpAlphaModulationFixed(openXmlElement, value.AlphaModulationFixed, diffs, objName))
        ok = false;
      if (!CmpAlphaOutset(openXmlElement, value.AlphaOutset, diffs, objName))
        ok = false;
      if (!CmpAlphaReplace(openXmlElement, value.AlphaReplace, diffs, objName))
        ok = false;
      if (!CmpBiLevel(openXmlElement, value.BiLevel, diffs, objName))
        ok = false;
      if (!CmpBlend(openXmlElement, value.Blend, diffs, objName))
        ok = false;
      if (!CmpBlur(openXmlElement, value.Blur, diffs, objName))
        ok = false;
      if (!CmpColorChange(openXmlElement, value.ColorChange, diffs, objName))
        ok = false;
      if (!CmpColorReplacement(openXmlElement, value.ColorReplacement, diffs, objName))
        ok = false;
      if (!CmpDuotone(openXmlElement, value.Duotone, diffs, objName))
        ok = false;
      if (!CmpFill(openXmlElement, value.Fill, diffs, objName))
        ok = false;
      if (!CmpFillOverlay(openXmlElement, value.FillOverlay, diffs, objName))
        ok = false;
      if (!CmpGlow(openXmlElement, value.Glow, diffs, objName))
        ok = false;
      if (!CmpGrayscale(openXmlElement, value.Grayscale, diffs, objName))
        ok = false;
      if (!CmpHsl(openXmlElement, value.Hsl, diffs, objName))
        ok = false;
      if (!CmpInnerShadow(openXmlElement, value.InnerShadow, diffs, objName))
        ok = false;
      if (!CmpLuminanceEffect(openXmlElement, value.LuminanceEffect, diffs, objName))
        ok = false;
      if (!CmpOuterShadow(openXmlElement, value.OuterShadow, diffs, objName))
        ok = false;
      if (!CmpPresetShadow(openXmlElement, value.PresetShadow, diffs, objName))
        ok = false;
      if (!CmpReflection(openXmlElement, value.Reflection, diffs, objName))
        ok = false;
      if (!CmpRelativeOffset(openXmlElement, value.RelativeOffset, diffs, objName))
        ok = false;
      if (!CmpSoftEdge(openXmlElement, value.SoftEdge, diffs, objName))
        ok = false;
      if (!CmpTintEffect(openXmlElement, value.TintEffect, diffs, objName))
        ok = false;
      if (!CmpTransformEffect(openXmlElement, value.TransformEffect, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.EffectDag value)
    where OpenXmlElementType: DXD.EffectDag, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.EffectDag openXmlElement, DMD.EffectDag value)
  {
    SetEffectContainer(openXmlElement, value?.EffectContainer);
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
  }
}
