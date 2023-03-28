namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect Container converter from/to OpenXml.
///</summary>
public static class EffectDagConverter
{
  private static DMDraws.EffectContainer? GetEffectContainer(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.EffectContainer>();
    if (element != null)
      return DMXDraws.EffectContainerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectContainer(DXDraw.EffectDag openXmlElement, DMDraws.EffectContainer? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectContainerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EffectContainer>(), value, diffs, objName);
  }
  
  private static void SetEffectContainer(DXDraw.EffectDag openXmlElement, DMDraws.EffectContainer? value)
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
  
  private static DMDraws.Effect? GetEffect(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Effect>();
    if (element != null)
      return DMXDraws.EffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffect(DXDraw.EffectDag openXmlElement, DMDraws.Effect? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Effect>(), value, diffs, objName);
  }
  
  private static void SetEffect(DXDraw.EffectDag openXmlElement, DMDraws.Effect? value)
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
  
  private static DMDraws.AlphaBiLevel? GetAlphaBiLevel(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.AlphaBiLevel>();
    if (element != null)
      return DMXDraws.AlphaBiLevelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaBiLevel(DXDraw.EffectDag openXmlElement, DMDraws.AlphaBiLevel? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AlphaBiLevelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.AlphaBiLevel>(), value, diffs, objName);
  }
  
  private static void SetAlphaBiLevel(DXDraw.EffectDag openXmlElement, DMDraws.AlphaBiLevel? value)
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
  
  private static Boolean? GetAlphaCeiling(DXDraw.EffectDag openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.AlphaCeiling>() != null;
  }
  
  private static bool CmpAlphaCeiling(DXDraw.EffectDag openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.AlphaCeiling>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.AlphaCeiling", val, value);
    return false;
  }
  
  private static void SetAlphaCeiling(DXDraw.EffectDag openXmlElement, Boolean? value)
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
  
  private static Boolean? GetAlphaFloor(DXDraw.EffectDag openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.AlphaFloor>() != null;
  }
  
  private static bool CmpAlphaFloor(DXDraw.EffectDag openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.AlphaFloor>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.AlphaFloor", val, value);
    return false;
  }
  
  private static void SetAlphaFloor(DXDraw.EffectDag openXmlElement, Boolean? value)
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
  
  private static DMDraws.AlphaInverse? GetAlphaInverse(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.AlphaInverse>();
    if (element != null)
      return DMXDraws.AlphaInverseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaInverse(DXDraw.EffectDag openXmlElement, DMDraws.AlphaInverse? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AlphaInverseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.AlphaInverse>(), value, diffs, objName);
  }
  
  private static void SetAlphaInverse(DXDraw.EffectDag openXmlElement, DMDraws.AlphaInverse? value)
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
  
  private static DMDraws.AlphaModulationEffect? GetAlphaModulationEffect(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.AlphaModulationEffect>();
    if (element != null)
      return DMXDraws.AlphaModulationEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaModulationEffect(DXDraw.EffectDag openXmlElement, DMDraws.AlphaModulationEffect? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AlphaModulationEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.AlphaModulationEffect>(), value, diffs, objName);
  }
  
  private static void SetAlphaModulationEffect(DXDraw.EffectDag openXmlElement, DMDraws.AlphaModulationEffect? value)
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
  
  private static DMDraws.AlphaModulationFixed? GetAlphaModulationFixed(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.AlphaModulationFixed>();
    if (element != null)
      return DMXDraws.AlphaModulationFixedConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaModulationFixed(DXDraw.EffectDag openXmlElement, DMDraws.AlphaModulationFixed? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AlphaModulationFixedConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.AlphaModulationFixed>(), value, diffs, objName);
  }
  
  private static void SetAlphaModulationFixed(DXDraw.EffectDag openXmlElement, DMDraws.AlphaModulationFixed? value)
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
  
  private static DMDraws.AlphaOutset? GetAlphaOutset(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.AlphaOutset>();
    if (element != null)
      return DMXDraws.AlphaOutsetConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaOutset(DXDraw.EffectDag openXmlElement, DMDraws.AlphaOutset? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AlphaOutsetConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.AlphaOutset>(), value, diffs, objName);
  }
  
  private static void SetAlphaOutset(DXDraw.EffectDag openXmlElement, DMDraws.AlphaOutset? value)
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
  
  private static DMDraws.AlphaReplace? GetAlphaReplace(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.AlphaReplace>();
    if (element != null)
      return DMXDraws.AlphaReplaceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaReplace(DXDraw.EffectDag openXmlElement, DMDraws.AlphaReplace? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AlphaReplaceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.AlphaReplace>(), value, diffs, objName);
  }
  
  private static void SetAlphaReplace(DXDraw.EffectDag openXmlElement, DMDraws.AlphaReplace? value)
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
  
  private static DMDraws.BiLevel? GetBiLevel(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.BiLevel>();
    if (element != null)
      return DMXDraws.BiLevelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBiLevel(DXDraw.EffectDag openXmlElement, DMDraws.BiLevel? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BiLevelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BiLevel>(), value, diffs, objName);
  }
  
  private static void SetBiLevel(DXDraw.EffectDag openXmlElement, DMDraws.BiLevel? value)
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
  
  private static DMDraws.Blend? GetBlend(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Blend>();
    if (element != null)
      return DMXDraws.BlendConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlend(DXDraw.EffectDag openXmlElement, DMDraws.Blend? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BlendConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Blend>(), value, diffs, objName);
  }
  
  private static void SetBlend(DXDraw.EffectDag openXmlElement, DMDraws.Blend? value)
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
  
  private static DMDraws.Blur? GetBlur(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Blur>();
    if (element != null)
      return DMXDraws.BlurConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlur(DXDraw.EffectDag openXmlElement, DMDraws.Blur? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BlurConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Blur>(), value, diffs, objName);
  }
  
  private static void SetBlur(DXDraw.EffectDag openXmlElement, DMDraws.Blur? value)
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
  
  private static DMDraws.ColorChange? GetColorChange(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ColorChange>();
    if (element != null)
      return DMXDraws.ColorChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorChange(DXDraw.EffectDag openXmlElement, DMDraws.ColorChange? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ColorChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ColorChange>(), value, diffs, objName);
  }
  
  private static void SetColorChange(DXDraw.EffectDag openXmlElement, DMDraws.ColorChange? value)
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
  
  private static DMDraws.ColorReplacement? GetColorReplacement(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ColorReplacement>();
    if (element != null)
      return DMXDraws.ColorReplacementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorReplacement(DXDraw.EffectDag openXmlElement, DMDraws.ColorReplacement? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ColorReplacementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ColorReplacement>(), value, diffs, objName);
  }
  
  private static void SetColorReplacement(DXDraw.EffectDag openXmlElement, DMDraws.ColorReplacement? value)
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
  
  private static DMDraws.Duotone? GetDuotone(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Duotone>();
    if (element != null)
      return DMXDraws.DuotoneConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDuotone(DXDraw.EffectDag openXmlElement, DMDraws.Duotone? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.DuotoneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Duotone>(), value, diffs, objName);
  }
  
  private static void SetDuotone(DXDraw.EffectDag openXmlElement, DMDraws.Duotone? value)
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
  
  private static DMDraws.Fill? GetFill(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Fill>();
    if (element != null)
      return DMXDraws.FillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFill(DXDraw.EffectDag openXmlElement, DMDraws.Fill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.FillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Fill>(), value, diffs, objName);
  }
  
  private static void SetFill(DXDraw.EffectDag openXmlElement, DMDraws.Fill? value)
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
  
  private static DMDraws.FillOverlay? GetFillOverlay(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.FillOverlay>();
    if (element != null)
      return DMXDraws.FillOverlayConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillOverlay(DXDraw.EffectDag openXmlElement, DMDraws.FillOverlay? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.FillOverlayConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.FillOverlay>(), value, diffs, objName);
  }
  
  private static void SetFillOverlay(DXDraw.EffectDag openXmlElement, DMDraws.FillOverlay? value)
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
  
  private static DMDraws.Glow? GetGlow(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Glow>();
    if (element != null)
      return DMXDraws.GlowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGlow(DXDraw.EffectDag openXmlElement, DMDraws.Glow? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GlowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Glow>(), value, diffs, objName);
  }
  
  private static void SetGlow(DXDraw.EffectDag openXmlElement, DMDraws.Glow? value)
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
  
  private static Boolean GetGrayscale(DXDraw.EffectDag openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Grayscale>() != null;
  }
  
  private static bool CmpGrayscale(DXDraw.EffectDag openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.Grayscale>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.Grayscale", val, value);
    return false;
  }
  
  private static void SetGrayscale(DXDraw.EffectDag openXmlElement, Boolean? value)
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
  
  private static DMDraws.Hsl? GetHsl(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Hsl>();
    if (element != null)
      return DMXDraws.HslConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHsl(DXDraw.EffectDag openXmlElement, DMDraws.Hsl? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HslConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Hsl>(), value, diffs, objName);
  }
  
  private static void SetHsl(DXDraw.EffectDag openXmlElement, DMDraws.Hsl? value)
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
  
  private static DMDraws.InnerShadow? GetInnerShadow(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.InnerShadow>();
    if (element != null)
      return DMXDraws.InnerShadowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInnerShadow(DXDraw.EffectDag openXmlElement, DMDraws.InnerShadow? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.InnerShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.InnerShadow>(), value, diffs, objName);
  }
  
  private static void SetInnerShadow(DXDraw.EffectDag openXmlElement, DMDraws.InnerShadow? value)
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
  
  private static DMDraws.LuminanceEffect? GetLuminanceEffect(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.LuminanceEffect>();
    if (element != null)
      return DMXDraws.LuminanceEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLuminanceEffect(DXDraw.EffectDag openXmlElement, DMDraws.LuminanceEffect? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LuminanceEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.LuminanceEffect>(), value, diffs, objName);
  }
  
  private static void SetLuminanceEffect(DXDraw.EffectDag openXmlElement, DMDraws.LuminanceEffect? value)
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
  
  private static DMDraws.OuterShadow? GetOuterShadow(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.OuterShadow>();
    if (element != null)
      return DMXDraws.OuterShadowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOuterShadow(DXDraw.EffectDag openXmlElement, DMDraws.OuterShadow? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.OuterShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.OuterShadow>(), value, diffs, objName);
  }
  
  private static void SetOuterShadow(DXDraw.EffectDag openXmlElement, DMDraws.OuterShadow? value)
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
  
  private static DMDraws.PresetShadow? GetPresetShadow(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.PresetShadow>();
    if (element != null)
      return DMXDraws.PresetShadowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetShadow(DXDraw.EffectDag openXmlElement, DMDraws.PresetShadow? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PresetShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.PresetShadow>(), value, diffs, objName);
  }
  
  private static void SetPresetShadow(DXDraw.EffectDag openXmlElement, DMDraws.PresetShadow? value)
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
  
  private static DMDraws.Reflection? GetReflection(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Reflection>();
    if (element != null)
      return DMXDraws.ReflectionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpReflection(DXDraw.EffectDag openXmlElement, DMDraws.Reflection? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ReflectionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Reflection>(), value, diffs, objName);
  }
  
  private static void SetReflection(DXDraw.EffectDag openXmlElement, DMDraws.Reflection? value)
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
  
  private static DMDraws.RelativeOffset? GetRelativeOffset(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.RelativeOffset>();
    if (element != null)
      return DMXDraws.RelativeOffsetConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRelativeOffset(DXDraw.EffectDag openXmlElement, DMDraws.RelativeOffset? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RelativeOffsetConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.RelativeOffset>(), value, diffs, objName);
  }
  
  private static void SetRelativeOffset(DXDraw.EffectDag openXmlElement, DMDraws.RelativeOffset? value)
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
  
  private static DMDraws.SoftEdge? GetSoftEdge(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.SoftEdge>();
    if (element != null)
      return DMXDraws.SoftEdgeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSoftEdge(DXDraw.EffectDag openXmlElement, DMDraws.SoftEdge? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SoftEdgeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.SoftEdge>(), value, diffs, objName);
  }
  
  private static void SetSoftEdge(DXDraw.EffectDag openXmlElement, DMDraws.SoftEdge? value)
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
  
  private static DMDraws.TintEffect? GetTintEffect(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.TintEffect>();
    if (element != null)
      return DMXDraws.TintEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTintEffect(DXDraw.EffectDag openXmlElement, DMDraws.TintEffect? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.TintEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.TintEffect>(), value, diffs, objName);
  }
  
  private static void SetTintEffect(DXDraw.EffectDag openXmlElement, DMDraws.TintEffect? value)
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
  
  private static DMDraws.TransformEffect? GetTransformEffect(DXDraw.EffectDag openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.TransformEffect>();
    if (element != null)
      return DMXDraws.TransformEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTransformEffect(DXDraw.EffectDag openXmlElement, DMDraws.TransformEffect? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.TransformEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.TransformEffect>(), value, diffs, objName);
  }
  
  private static void SetTransformEffect(DXDraw.EffectDag openXmlElement, DMDraws.TransformEffect? value)
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
  
  public static DocumentModel.Drawings.EffectDag? CreateModelElement(DXDraw.EffectDag? openXmlElement)
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
  
  public static bool CompareModelElement(DXDraw.EffectDag? openXmlElement, DMDraws.EffectDag? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.EffectDag value)
    where OpenXmlElementType: DXDraw.EffectDag, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.EffectDag openXmlElement, DMDraws.EffectDag value)
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
