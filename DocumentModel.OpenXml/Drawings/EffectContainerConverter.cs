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
public static class EffectContainerConverter
{
  public static EffectContainer? GetChildEffectContainer(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectContainer>();
    if (itemElement != null)
      return CreateModelElement(itemElement);
    return null;
  }

  public static void SetChildEffectContainer(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, EffectContainer? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectContainer>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectContainer>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Effect? GetEffect(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Effect>();
    if (itemElement != null)
      return EffectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEffect(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, Effect? value)
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

  public static AlphaBiLevel? GetAlphaBiLevel(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaBiLevel>();
    if (itemElement != null)
      return AlphaBiLevelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlphaBiLevel(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, AlphaBiLevel? value)
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

  public static Boolean? GetAlphaCeiling(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AlphaCeiling>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAlphaCeiling(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, Boolean? value)
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

  public static Boolean? GetAlphaFloor(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AlphaFloor>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAlphaFloor(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, Boolean? value)
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

  public static AlphaInverse? GetAlphaInverse(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaInverse>();
    if (itemElement != null)
      return AlphaInverseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlphaInverse(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, AlphaInverse? value)
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

  public static AlphaModulationEffect? GetAlphaModulationEffect(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationEffect>();
    if (itemElement != null)
      return AlphaModulationEffectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlphaModulationEffect(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, AlphaModulationEffect? value)
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

  public static AlphaModulationFixed? GetAlphaModulationFixed(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationFixed>();
    if (itemElement != null)
      return AlphaModulationFixedConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlphaModulationFixed(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, AlphaModulationFixed? value)
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

  public static AlphaOutset? GetAlphaOutset(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaOutset>();
    if (itemElement != null)
      return AlphaOutsetConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlphaOutset(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, AlphaOutset? value)
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

  public static AlphaReplace? GetAlphaReplace(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaReplace>();
    if (itemElement != null)
      return AlphaReplaceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlphaReplace(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, AlphaReplace? value)
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

  public static BiLevel? GetBiLevel(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BiLevel>();
    if (itemElement != null)
      return BiLevelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBiLevel(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, BiLevel? value)
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

  public static Blend? GetBlend(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blend>();
    if (itemElement != null)
      return BlendConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBlend(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, Blend? value)
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

  public static Blur? GetBlur(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blur>();
    if (itemElement != null)
      return BlurConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBlur(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, Blur? value)
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

  public static ColorChange? GetColorChange(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorChange>();
    if (itemElement != null)
      return ColorChangeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorChange(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, ColorChange? value)
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

  public static ColorReplacement? GetColorReplacement(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorReplacement>();
    if (itemElement != null)
      return ColorReplacementConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorReplacement(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, ColorReplacement? value)
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

  public static Duotone? GetDuotone(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Duotone>();
    if (itemElement != null)
      return DuotoneConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDuotone(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, Duotone? value)
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

  public static Fill? GetFill(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Fill>();
    if (itemElement != null)
      return FillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFill(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, Fill? value)
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

  public static FillOverlay? GetFillOverlay(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillOverlay>();
    if (itemElement != null)
      return FillOverlayConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFillOverlay(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, FillOverlay? value)
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

  public static Glow? GetGlow(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Glow>();
    if (itemElement != null)
      return GlowConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGlow(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, Glow? value)
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

  public static Boolean? GetGrayscale(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Grayscale>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetGrayscale(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, Boolean? value)
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

  public static Hsl? GetHsl(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Hsl>();
    if (itemElement != null)
      return HslConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHsl(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, Hsl? value)
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

  public static InnerShadow? GetInnerShadow(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.InnerShadow>();
    if (itemElement != null)
      return InnerShadowConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetInnerShadow(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, InnerShadow? value)
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

  public static LuminanceEffect? GetLuminanceEffect(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LuminanceEffect>();
    if (itemElement != null)
      return LuminanceEffectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLuminanceEffect(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, LuminanceEffect? value)
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

  public static OuterShadow? GetOuterShadow(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.OuterShadow>();
    if (itemElement != null)
      return OuterShadowConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOuterShadow(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, OuterShadow? value)
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

  public static PresetShadow? GetPresetShadow(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetShadow>();
    if (itemElement != null)
      return PresetShadowConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPresetShadow(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, PresetShadow? value)
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

  public static Reflection? GetReflection(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Reflection>();
    if (itemElement != null)
      return ReflectionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetReflection(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, Reflection? value)
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

  public static RelativeOffset? GetRelativeOffset(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RelativeOffset>();
    if (itemElement != null)
      return RelativeOffsetConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRelativeOffset(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, RelativeOffset? value)
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

  public static SoftEdge? GetSoftEdge(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SoftEdge>();
    if (itemElement != null)
      return SoftEdgeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSoftEdge(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, SoftEdge? value)
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

  public static TintEffect? GetTintEffect(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TintEffect>();
    if (itemElement != null)
      return TintEffectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTintEffect(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, TintEffect? value)
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

  public static TransformEffect? GetTransformEffect(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TransformEffect>();
    if (itemElement != null)
      return TransformEffectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTransformEffect(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement, TransformEffect? value)
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

  public static EffectContainer? CreateModelElement(DocumentFormat.OpenXml.Drawing.EffectContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new EffectContainer();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(EffectContainer? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Drawing.EffectContainer, new()
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