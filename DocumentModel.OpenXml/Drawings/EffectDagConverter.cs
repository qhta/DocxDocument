using DocumentFormat.OpenXml.Drawing;
using AlphaBiLevel = DocumentModel.Drawings.AlphaBiLevel;
using AlphaInverse = DocumentModel.Drawings.AlphaInverse;
using AlphaModulationEffect = DocumentModel.Drawings.AlphaModulationEffect;
using AlphaModulationFixed = DocumentModel.Drawings.AlphaModulationFixed;
using AlphaOutset = DocumentModel.Drawings.AlphaOutset;
using AlphaReplace = DocumentModel.Drawings.AlphaReplace;
using BiLevel = DocumentModel.Drawings.BiLevel;
using Blend = DocumentModel.Drawings.Blend;
using Blur = DocumentModel.Drawings.Blur;
using ColorChange = DocumentModel.Drawings.ColorChange;
using ColorReplacement = DocumentModel.Drawings.ColorReplacement;
using Duotone = DocumentModel.Drawings.Duotone;
using Effect = DocumentModel.Drawings.Effect;
using EffectContainer = DocumentModel.Drawings.EffectContainer;
using EffectDag = DocumentFormat.OpenXml.Drawing.EffectDag;
using Fill = DocumentModel.Drawings.Fill;
using FillOverlay = DocumentModel.Drawings.FillOverlay;
using Glow = DocumentModel.Drawings.Glow;
using Hsl = DocumentModel.Drawings.Hsl;
using InnerShadow = DocumentModel.Drawings.InnerShadow;
using LuminanceEffect = DocumentModel.Drawings.LuminanceEffect;
using OuterShadow = DocumentModel.Drawings.OuterShadow;
using PresetShadow = DocumentModel.Drawings.PresetShadow;
using Reflection = DocumentModel.Drawings.Reflection;
using RelativeOffset = DocumentModel.Drawings.RelativeOffset;
using SoftEdge = DocumentModel.Drawings.SoftEdge;
using TintEffect = DocumentModel.Drawings.TintEffect;
using TransformEffect = DocumentModel.Drawings.TransformEffect;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Effect Container.
/// </summary>
public static class EffectDagConverter
{
  public static EffectContainer? GetEffectContainer(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectContainer>();
    if (itemElement != null)
      return EffectContainerConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEffectContainer(EffectDag? openXmlElement, EffectContainer? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectContainer>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectContainerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectContainer>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Effect? GetEffect(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Effect>();
    if (itemElement != null)
      return EffectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEffect(EffectDag? openXmlElement, Effect? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Effect>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Effect>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static AlphaBiLevel? GetAlphaBiLevel(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaBiLevel>();
    if (itemElement != null)
      return AlphaBiLevelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlphaBiLevel(EffectDag? openXmlElement, AlphaBiLevel? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaBiLevel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AlphaBiLevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AlphaBiLevel>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetAlphaCeiling(EffectDag? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AlphaCeiling>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAlphaCeiling(EffectDag? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AlphaCeiling>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AlphaCeiling();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetAlphaFloor(EffectDag? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AlphaFloor>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAlphaFloor(EffectDag? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AlphaFloor>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AlphaFloor();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static AlphaInverse? GetAlphaInverse(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaInverse>();
    if (itemElement != null)
      return AlphaInverseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlphaInverse(EffectDag? openXmlElement, AlphaInverse? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaInverse>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AlphaInverseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AlphaInverse>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static AlphaModulationEffect? GetAlphaModulationEffect(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationEffect>();
    if (itemElement != null)
      return AlphaModulationEffectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlphaModulationEffect(EffectDag? openXmlElement, AlphaModulationEffect? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationEffect>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AlphaModulationEffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AlphaModulationEffect>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static AlphaModulationFixed? GetAlphaModulationFixed(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationFixed>();
    if (itemElement != null)
      return AlphaModulationFixedConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlphaModulationFixed(EffectDag? openXmlElement, AlphaModulationFixed? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationFixed>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AlphaModulationFixedConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AlphaModulationFixed>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static AlphaOutset? GetAlphaOutset(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaOutset>();
    if (itemElement != null)
      return AlphaOutsetConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlphaOutset(EffectDag? openXmlElement, AlphaOutset? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaOutset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AlphaOutsetConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AlphaOutset>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static AlphaReplace? GetAlphaReplace(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaReplace>();
    if (itemElement != null)
      return AlphaReplaceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlphaReplace(EffectDag? openXmlElement, AlphaReplace? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaReplace>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AlphaReplaceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AlphaReplace>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BiLevel? GetBiLevel(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BiLevel>();
    if (itemElement != null)
      return BiLevelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBiLevel(EffectDag? openXmlElement, BiLevel? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BiLevel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BiLevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BiLevel>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Blend? GetBlend(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blend>();
    if (itemElement != null)
      return BlendConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBlend(EffectDag? openXmlElement, Blend? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blend>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlendConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Blend>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Blur? GetBlur(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blur>();
    if (itemElement != null)
      return BlurConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBlur(EffectDag? openXmlElement, Blur? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blur>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlurConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Blur>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ColorChange? GetColorChange(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorChange>();
    if (itemElement != null)
      return ColorChangeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorChange(EffectDag? openXmlElement, ColorChange? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ColorChange>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ColorReplacement? GetColorReplacement(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorReplacement>();
    if (itemElement != null)
      return ColorReplacementConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorReplacement(EffectDag? openXmlElement, ColorReplacement? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorReplacement>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorReplacementConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ColorReplacement>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Duotone? GetDuotone(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Duotone>();
    if (itemElement != null)
      return DuotoneConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDuotone(EffectDag? openXmlElement, Duotone? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Duotone>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DuotoneConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Duotone>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Fill? GetFill(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Fill>();
    if (itemElement != null)
      return FillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFill(EffectDag? openXmlElement, Fill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Fill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Fill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static FillOverlay? GetFillOverlay(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillOverlay>();
    if (itemElement != null)
      return FillOverlayConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFillOverlay(EffectDag? openXmlElement, FillOverlay? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillOverlay>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillOverlayConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FillOverlay>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Glow? GetGlow(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Glow>();
    if (itemElement != null)
      return GlowConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGlow(EffectDag? openXmlElement, Glow? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Glow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GlowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Glow>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetGrayscale(EffectDag? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Grayscale>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetGrayscale(EffectDag? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Grayscale>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Grayscale();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Hsl? GetHsl(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Hsl>();
    if (itemElement != null)
      return HslConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHsl(EffectDag? openXmlElement, Hsl? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Hsl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HslConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Hsl>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static InnerShadow? GetInnerShadow(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.InnerShadow>();
    if (itemElement != null)
      return InnerShadowConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetInnerShadow(EffectDag? openXmlElement, InnerShadow? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.InnerShadow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InnerShadowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.InnerShadow>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LuminanceEffect? GetLuminanceEffect(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LuminanceEffect>();
    if (itemElement != null)
      return LuminanceEffectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLuminanceEffect(EffectDag? openXmlElement, LuminanceEffect? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LuminanceEffect>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LuminanceEffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LuminanceEffect>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static OuterShadow? GetOuterShadow(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.OuterShadow>();
    if (itemElement != null)
      return OuterShadowConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOuterShadow(EffectDag? openXmlElement, OuterShadow? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.OuterShadow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OuterShadowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.OuterShadow>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PresetShadow? GetPresetShadow(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetShadow>();
    if (itemElement != null)
      return PresetShadowConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPresetShadow(EffectDag? openXmlElement, PresetShadow? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetShadow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PresetShadowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetShadow>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Reflection? GetReflection(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Reflection>();
    if (itemElement != null)
      return ReflectionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetReflection(EffectDag? openXmlElement, Reflection? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Reflection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ReflectionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Reflection>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RelativeOffset? GetRelativeOffset(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RelativeOffset>();
    if (itemElement != null)
      return RelativeOffsetConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRelativeOffset(EffectDag? openXmlElement, RelativeOffset? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RelativeOffset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelativeOffsetConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.RelativeOffset>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SoftEdge? GetSoftEdge(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SoftEdge>();
    if (itemElement != null)
      return SoftEdgeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSoftEdge(EffectDag? openXmlElement, SoftEdge? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SoftEdge>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SoftEdgeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SoftEdge>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TintEffect? GetTintEffect(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TintEffect>();
    if (itemElement != null)
      return TintEffectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTintEffect(EffectDag? openXmlElement, TintEffect? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TintEffect>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TintEffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.TintEffect>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TransformEffect? GetTransformEffect(EffectDag? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TransformEffect>();
    if (itemElement != null)
      return TransformEffectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTransformEffect(EffectDag? openXmlElement, TransformEffect? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TransformEffect>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TransformEffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.TransformEffect>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.EffectDag? CreateModelElement(EffectDag? openXmlElement)
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
    where OpenXmlElementType : EffectDag, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}