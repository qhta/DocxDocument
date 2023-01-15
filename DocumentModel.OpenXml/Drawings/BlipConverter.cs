using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using AlphaBiLevel = DocumentModel.Drawings.AlphaBiLevel;
using AlphaInverse = DocumentModel.Drawings.AlphaInverse;
using AlphaModulationEffect = DocumentModel.Drawings.AlphaModulationEffect;
using AlphaModulationFixed = DocumentModel.Drawings.AlphaModulationFixed;
using AlphaReplace = DocumentModel.Drawings.AlphaReplace;
using BiLevel = DocumentModel.Drawings.BiLevel;
using Blip = DocumentFormat.OpenXml.Drawing.Blip;
using BlipExtensionList = DocumentModel.Drawings.BlipExtensionList;
using Blur = DocumentModel.Drawings.Blur;
using ColorChange = DocumentModel.Drawings.ColorChange;
using ColorReplacement = DocumentModel.Drawings.ColorReplacement;
using Duotone = DocumentModel.Drawings.Duotone;
using FillOverlay = DocumentModel.Drawings.FillOverlay;
using Hsl = DocumentModel.Drawings.Hsl;
using LuminanceEffect = DocumentModel.Drawings.LuminanceEffect;
using TintEffect = DocumentModel.Drawings.TintEffect;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the Blip Class.
/// </summary>
public static class BlipConverter
{
  /// <summary>
  ///   Embedded Picture Reference
  /// </summary>
  public static String? GetEmbed(Blip? openXmlElement)
  {
    return openXmlElement?.Embed?.Value;
  }

  public static void SetEmbed(Blip? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Embed = new StringValue { Value = value };
      else
        openXmlElement.Embed = null;
  }

  /// <summary>
  ///   Linked Picture Reference
  /// </summary>
  public static String? GetLink(Blip? openXmlElement)
  {
    return openXmlElement?.Link?.Value;
  }

  public static void SetLink(Blip? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Link = new StringValue { Value = value };
      else
        openXmlElement.Link = null;
  }

  /// <summary>
  ///   Compression state for blips.
  /// </summary>
  public static BlipCompressionKind? GetCompressionState(Blip? openXmlElement)
  {
    return EnumValueConverter.GetValue<BlipCompressionValues, BlipCompressionKind>(openXmlElement?.CompressionState?.Value);
  }

  public static void SetCompressionState(Blip? openXmlElement, BlipCompressionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CompressionState = EnumValueConverter.CreateEnumValue<BlipCompressionValues, BlipCompressionKind>(value);
  }

  public static AlphaBiLevel? GetAlphaBiLevel(Blip? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaBiLevel>();
    if (itemElement != null)
      return AlphaBiLevelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlphaBiLevel(Blip? openXmlElement, AlphaBiLevel? value)
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

  public static Boolean? GetAlphaCeiling(Blip? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AlphaCeiling>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAlphaCeiling(Blip? openXmlElement, Boolean? value)
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

  public static Boolean? GetAlphaFloor(Blip? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AlphaFloor>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAlphaFloor(Blip? openXmlElement, Boolean? value)
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

  public static AlphaInverse? GetAlphaInverse(Blip? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaInverse>();
    if (itemElement != null)
      return AlphaInverseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlphaInverse(Blip? openXmlElement, AlphaInverse? value)
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

  public static AlphaModulationEffect? GetAlphaModulationEffect(Blip? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationEffect>();
    if (itemElement != null)
      return AlphaModulationEffectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlphaModulationEffect(Blip? openXmlElement, AlphaModulationEffect? value)
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

  public static AlphaModulationFixed? GetAlphaModulationFixed(Blip? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationFixed>();
    if (itemElement != null)
      return AlphaModulationFixedConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlphaModulationFixed(Blip? openXmlElement, AlphaModulationFixed? value)
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

  public static AlphaReplace? GetAlphaReplace(Blip? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaReplace>();
    if (itemElement != null)
      return AlphaReplaceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlphaReplace(Blip? openXmlElement, AlphaReplace? value)
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

  public static BiLevel? GetBiLevel(Blip? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BiLevel>();
    if (itemElement != null)
      return BiLevelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBiLevel(Blip? openXmlElement, BiLevel? value)
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

  public static Blur? GetBlur(Blip? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blur>();
    if (itemElement != null)
      return BlurConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBlur(Blip? openXmlElement, Blur? value)
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

  public static ColorChange? GetColorChange(Blip? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorChange>();
    if (itemElement != null)
      return ColorChangeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorChange(Blip? openXmlElement, ColorChange? value)
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

  public static ColorReplacement? GetColorReplacement(Blip? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorReplacement>();
    if (itemElement != null)
      return ColorReplacementConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorReplacement(Blip? openXmlElement, ColorReplacement? value)
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

  public static Duotone? GetDuotone(Blip? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Duotone>();
    if (itemElement != null)
      return DuotoneConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDuotone(Blip? openXmlElement, Duotone? value)
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

  public static FillOverlay? GetFillOverlay(Blip? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillOverlay>();
    if (itemElement != null)
      return FillOverlayConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFillOverlay(Blip? openXmlElement, FillOverlay? value)
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

  public static Boolean? GetGrayscale(Blip? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Grayscale>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetGrayscale(Blip? openXmlElement, Boolean? value)
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

  public static Hsl? GetHsl(Blip? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Hsl>();
    if (itemElement != null)
      return HslConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHsl(Blip? openXmlElement, Hsl? value)
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

  public static LuminanceEffect? GetLuminanceEffect(Blip? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LuminanceEffect>();
    if (itemElement != null)
      return LuminanceEffectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLuminanceEffect(Blip? openXmlElement, LuminanceEffect? value)
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

  public static TintEffect? GetTintEffect(Blip? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TintEffect>();
    if (itemElement != null)
      return TintEffectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTintEffect(Blip? openXmlElement, TintEffect? value)
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

  public static BlipExtensionList? GetBlipExtensionList(Blip? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipExtensionList>();
    if (itemElement != null)
      return BlipExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBlipExtensionList(Blip? openXmlElement, BlipExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlipExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BlipExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Blip? CreateModelElement(Blip? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Blip();
      value.Embed = GetEmbed(openXmlElement);
      value.Link = GetLink(openXmlElement);
      value.CompressionState = GetCompressionState(openXmlElement);
      value.AlphaBiLevel = GetAlphaBiLevel(openXmlElement);
      value.AlphaCeiling = GetAlphaCeiling(openXmlElement);
      value.AlphaFloor = GetAlphaFloor(openXmlElement);
      value.AlphaInverse = GetAlphaInverse(openXmlElement);
      value.AlphaModulationEffect = GetAlphaModulationEffect(openXmlElement);
      value.AlphaModulationFixed = GetAlphaModulationFixed(openXmlElement);
      value.AlphaReplace = GetAlphaReplace(openXmlElement);
      value.BiLevel = GetBiLevel(openXmlElement);
      value.Blur = GetBlur(openXmlElement);
      value.ColorChange = GetColorChange(openXmlElement);
      value.ColorReplacement = GetColorReplacement(openXmlElement);
      value.Duotone = GetDuotone(openXmlElement);
      value.FillOverlay = GetFillOverlay(openXmlElement);
      value.Grayscale = GetGrayscale(openXmlElement);
      value.Hsl = GetHsl(openXmlElement);
      value.LuminanceEffect = GetLuminanceEffect(openXmlElement);
      value.TintEffect = GetTintEffect(openXmlElement);
      value.BlipExtensionList = GetBlipExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Blip? value)
    where OpenXmlElementType : Blip, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEmbed(openXmlElement, value?.Embed);
      SetLink(openXmlElement, value?.Link);
      SetCompressionState(openXmlElement, value?.CompressionState);
      SetAlphaBiLevel(openXmlElement, value?.AlphaBiLevel);
      SetAlphaCeiling(openXmlElement, value?.AlphaCeiling);
      SetAlphaFloor(openXmlElement, value?.AlphaFloor);
      SetAlphaInverse(openXmlElement, value?.AlphaInverse);
      SetAlphaModulationEffect(openXmlElement, value?.AlphaModulationEffect);
      SetAlphaModulationFixed(openXmlElement, value?.AlphaModulationFixed);
      SetAlphaReplace(openXmlElement, value?.AlphaReplace);
      SetBiLevel(openXmlElement, value?.BiLevel);
      SetBlur(openXmlElement, value?.Blur);
      SetColorChange(openXmlElement, value?.ColorChange);
      SetColorReplacement(openXmlElement, value?.ColorReplacement);
      SetDuotone(openXmlElement, value?.Duotone);
      SetFillOverlay(openXmlElement, value?.FillOverlay);
      SetGrayscale(openXmlElement, value?.Grayscale);
      SetHsl(openXmlElement, value?.Hsl);
      SetLuminanceEffect(openXmlElement, value?.LuminanceEffect);
      SetTintEffect(openXmlElement, value?.TintEffect);
      SetBlipExtensionList(openXmlElement, value?.BlipExtensionList);
      return openXmlElement;
    }
    return default;
  }
}