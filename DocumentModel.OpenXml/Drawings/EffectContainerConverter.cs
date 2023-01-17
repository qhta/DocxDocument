namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect Container.
/// </summary>
public static class EffectContainerConverter
{
  private static DocumentModel.Drawings.EffectContainer? GetChildEffectContainer(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectContainer>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectContainerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChildEffectContainer(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.EffectContainer? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectContainer>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.EffectContainerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectContainer>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Effect? GetEffect(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Effect>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffect(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.Effect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Effect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.EffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Effect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.AlphaBiLevel? GetAlphaBiLevel(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaBiLevel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AlphaBiLevelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaBiLevel(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.AlphaBiLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaBiLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.AlphaBiLevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AlphaBiLevel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAlphaCeiling(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaCeiling>();
    return itemElement != null;
  }
  
  private static void SetAlphaCeiling(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaCeiling>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.AlphaCeiling();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAlphaFloor(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaFloor>();
    return itemElement != null;
  }
  
  private static void SetAlphaFloor(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaFloor>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.AlphaFloor();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.AlphaInverse? GetAlphaInverse(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaInverse>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AlphaInverseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaInverse(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.AlphaInverse? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaInverse>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.AlphaInverseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AlphaInverse>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.AlphaModulationEffect? GetAlphaModulationEffect(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationEffect>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AlphaModulationEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaModulationEffect(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.AlphaModulationEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.AlphaModulationEffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AlphaModulationEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.AlphaModulationFixed? GetAlphaModulationFixed(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationFixed>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AlphaModulationFixedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaModulationFixed(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.AlphaModulationFixed? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationFixed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.AlphaModulationFixedConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AlphaModulationFixed>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.AlphaOutset? GetAlphaOutset(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaOutset>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AlphaOutsetConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaOutset(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.AlphaOutset? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaOutset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.AlphaOutsetConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AlphaOutset>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.AlphaReplace? GetAlphaReplace(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaReplace>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AlphaReplaceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaReplace(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.AlphaReplace? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaReplace>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.AlphaReplaceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AlphaReplace>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.BiLevel? GetBiLevel(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BiLevel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BiLevelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBiLevel(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.BiLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BiLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.BiLevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BiLevel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Blend? GetBlend(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blend>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BlendConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBlend(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.Blend? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blend>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.BlendConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Blend>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Blur? GetBlur(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blur>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BlurConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBlur(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.Blur? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blur>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.BlurConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Blur>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.ColorChange? GetColorChange(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorChange>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ColorChangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorChange(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.ColorChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ColorChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ColorChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.ColorReplacement? GetColorReplacement(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorReplacement>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ColorReplacementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorReplacement(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.ColorReplacement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorReplacement>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ColorReplacementConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ColorReplacement>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Duotone? GetDuotone(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Duotone>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.DuotoneConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDuotone(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.Duotone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Duotone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.DuotoneConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Duotone>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Fill? GetFill(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Fill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFill(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.Fill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Fill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.FillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Fill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.FillOverlay? GetFillOverlay(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillOverlay>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FillOverlayConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFillOverlay(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.FillOverlay? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillOverlay>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.FillOverlayConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FillOverlay>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Glow? GetGlow(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Glow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GlowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGlow(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.Glow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Glow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.GlowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Glow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetGrayscale(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Grayscale>();
    return itemElement != null;
  }
  
  private static void SetGrayscale(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Grayscale>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Grayscale();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Hsl? GetHsl(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Hsl>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HslConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHsl(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.Hsl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Hsl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.HslConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Hsl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.InnerShadow? GetInnerShadow(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.InnerShadow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.InnerShadowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetInnerShadow(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.InnerShadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.InnerShadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.InnerShadowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.InnerShadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.LuminanceEffect? GetLuminanceEffect(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LuminanceEffect>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LuminanceEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLuminanceEffect(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.LuminanceEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LuminanceEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.LuminanceEffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LuminanceEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.OuterShadow? GetOuterShadow(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.OuterShadow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.OuterShadowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOuterShadow(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.OuterShadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.OuterShadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.OuterShadowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.OuterShadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.PresetShadow? GetPresetShadow(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetShadow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PresetShadowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPresetShadow(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.PresetShadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetShadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.PresetShadowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetShadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Reflection? GetReflection(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Reflection>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ReflectionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetReflection(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.Reflection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Reflection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ReflectionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Reflection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.RelativeOffset? GetRelativeOffset(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RelativeOffset>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RelativeOffsetConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRelativeOffset(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.RelativeOffset? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RelativeOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.RelativeOffsetConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.RelativeOffset>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.SoftEdge? GetSoftEdge(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SoftEdge>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SoftEdgeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSoftEdge(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.SoftEdge? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SoftEdge>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.SoftEdgeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SoftEdge>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.TintEffect? GetTintEffect(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TintEffect>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TintEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTintEffect(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.TintEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TintEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.TintEffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.TintEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.TransformEffect? GetTransformEffect(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TransformEffect>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TransformEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTransformEffect(DocumentFormat.OpenXml.Drawing.EffectContainer openXmlElement, DocumentModel.Drawings.TransformEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TransformEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.TransformEffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.TransformEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.EffectContainer? CreateModelElement(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.EffectContainer();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.EffectContainer? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.EffectContainer, new()
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
