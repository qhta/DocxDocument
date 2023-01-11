namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect Container.
/// </summary>
public static class EffectDagConverter
{
  public static DocumentModel.Drawings.EffectContainer? GetEffectContainer(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectContainer>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectContainerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffectContainer(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.EffectContainer? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Effect? GetEffect(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Effect>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffect(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.Effect? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.AlphaBiLevel? GetAlphaBiLevel(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaBiLevel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AlphaBiLevelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAlphaBiLevel(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.AlphaBiLevel? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetAlphaCeiling(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaCeiling>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAlphaCeiling(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetAlphaFloor(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaFloor>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAlphaFloor(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.AlphaInverse? GetAlphaInverse(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaInverse>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AlphaInverseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAlphaInverse(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.AlphaInverse? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.AlphaModulationEffect? GetAlphaModulationEffect(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationEffect>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AlphaModulationEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAlphaModulationEffect(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.AlphaModulationEffect? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.AlphaModulationFixed? GetAlphaModulationFixed(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationFixed>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AlphaModulationFixedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAlphaModulationFixed(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.AlphaModulationFixed? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.AlphaOutset? GetAlphaOutset(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaOutset>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AlphaOutsetConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAlphaOutset(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.AlphaOutset? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.AlphaReplace? GetAlphaReplace(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaReplace>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AlphaReplaceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAlphaReplace(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.AlphaReplace? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.BiLevel? GetBiLevel(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BiLevel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BiLevelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBiLevel(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.BiLevel? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Blend? GetBlend(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blend>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BlendConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBlend(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.Blend? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Blur? GetBlur(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blur>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BlurConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBlur(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.Blur? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.ColorChange? GetColorChange(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorChange>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ColorChangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColorChange(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.ColorChange? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.ColorReplacement? GetColorReplacement(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorReplacement>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ColorReplacementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColorReplacement(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.ColorReplacement? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Duotone? GetDuotone(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Duotone>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.DuotoneConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDuotone(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.Duotone? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Fill? GetFill(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Fill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFill(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.Fill? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.FillOverlay? GetFillOverlay(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillOverlay>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FillOverlayConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFillOverlay(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.FillOverlay? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Glow? GetGlow(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Glow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GlowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGlow(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.Glow? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetGrayscale(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Grayscale>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetGrayscale(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Hsl? GetHsl(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Hsl>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HslConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHsl(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.Hsl? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.InnerShadow? GetInnerShadow(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.InnerShadow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.InnerShadowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetInnerShadow(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.InnerShadow? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.LuminanceEffect? GetLuminanceEffect(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LuminanceEffect>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LuminanceEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLuminanceEffect(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.LuminanceEffect? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.OuterShadow? GetOuterShadow(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.OuterShadow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.OuterShadowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOuterShadow(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.OuterShadow? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.PresetShadow? GetPresetShadow(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetShadow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PresetShadowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPresetShadow(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.PresetShadow? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Reflection? GetReflection(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Reflection>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ReflectionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetReflection(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.Reflection? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.RelativeOffset? GetRelativeOffset(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RelativeOffset>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RelativeOffsetConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRelativeOffset(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.RelativeOffset? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.SoftEdge? GetSoftEdge(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SoftEdge>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SoftEdgeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSoftEdge(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.SoftEdge? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.TintEffect? GetTintEffect(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TintEffect>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TintEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTintEffect(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.TintEffect? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.TransformEffect? GetTransformEffect(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TransformEffect>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TransformEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTransformEffect(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement, DocumentModel.Drawings.TransformEffect? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.EffectDag? CreateModelElement(DocumentFormat.OpenXml.Drawing.EffectDag? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.EffectDag? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.EffectDag, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
