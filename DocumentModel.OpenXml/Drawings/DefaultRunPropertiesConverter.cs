using DocumentFormat.OpenXml.Drawing;
using BlipFill = DocumentModel.Drawings.BlipFill;
using DefaultRunProperties = DocumentFormat.OpenXml.Drawing.DefaultRunProperties;
using EffectDag = DocumentModel.Drawings.EffectDag;
using EffectList = DocumentModel.Drawings.EffectList;
using GradientFill = DocumentModel.Drawings.GradientFill;
using Highlight = DocumentModel.Drawings.Highlight;
using HyperlinkOnClick = DocumentModel.Drawings.HyperlinkOnClick;
using HyperlinkOnMouseOver = DocumentModel.Drawings.HyperlinkOnMouseOver;
using Outline = DocumentModel.Drawings.Outline;
using PatternFill = DocumentModel.Drawings.PatternFill;
using SolidFill = DocumentModel.Drawings.SolidFill;
using TextFontType = DocumentModel.Drawings.TextFontType;
using Underline = DocumentModel.Drawings.Underline;
using UnderlineFill = DocumentModel.Drawings.UnderlineFill;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Default Text Run Properties.
/// </summary>
public static class DefaultRunPropertiesConverter
{
  public static Outline? GetOutline(DefaultRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
    if (itemElement != null)
      return OutlineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOutline(DefaultRunProperties? openXmlElement, Outline? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OutlineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Outline>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetNoFill(DefaultRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoFill>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoFill(DefaultRunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<NoFill>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new NoFill();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SolidFill? GetSolidFill(DefaultRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
    if (itemElement != null)
      return SolidFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSolidFill(DefaultRunProperties? openXmlElement, SolidFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SolidFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SolidFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static GradientFill? GetGradientFill(DefaultRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
    if (itemElement != null)
      return GradientFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGradientFill(DefaultRunProperties? openXmlElement, GradientFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GradientFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.GradientFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BlipFill? GetBlipFill(DefaultRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
    if (itemElement != null)
      return BlipFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBlipFill(DefaultRunProperties? openXmlElement, BlipFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlipFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BlipFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PatternFill? GetPatternFill(DefaultRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
    if (itemElement != null)
      return PatternFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPatternFill(DefaultRunProperties? openXmlElement, PatternFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PatternFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PatternFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetGroupFill(DefaultRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<GroupFill>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetGroupFill(DefaultRunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<GroupFill>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new GroupFill();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static EffectList? GetEffectList(DefaultRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectList>();
    if (itemElement != null)
      return EffectListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEffectList(DefaultRunProperties? openXmlElement, EffectList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static EffectDag? GetEffectDag(DefaultRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
    if (itemElement != null)
      return EffectDagConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEffectDag(DefaultRunProperties? openXmlElement, EffectDag? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectDagConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectDag>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Highlight? GetHighlight(DefaultRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Highlight>();
    if (itemElement != null)
      return HighlightConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHighlight(DefaultRunProperties? openXmlElement, Highlight? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Highlight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HighlightConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Highlight>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetUnderlineFollowsText(DefaultRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UnderlineFollowsText>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUnderlineFollowsText(DefaultRunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<UnderlineFollowsText>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new UnderlineFollowsText();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Underline? GetUnderline(DefaultRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Underline>();
    if (itemElement != null)
      return UnderlineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnderline(DefaultRunProperties? openXmlElement, Underline? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Underline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnderlineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Underline>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetUnderlineFillText(DefaultRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UnderlineFillText>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUnderlineFillText(DefaultRunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<UnderlineFillText>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new UnderlineFillText();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UnderlineFill? GetUnderlineFill(DefaultRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.UnderlineFill>();
    if (itemElement != null)
      return UnderlineFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnderlineFill(DefaultRunProperties? openXmlElement, UnderlineFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.UnderlineFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnderlineFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.UnderlineFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextFontType? GetLatinFont(DefaultRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LatinFont>();
    if (itemElement != null)
      return TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLatinFont(DefaultRunProperties? openXmlElement, TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LatinFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextFontTypeConverter.CreateOpenXmlElement<LatinFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextFontType? GetEastAsianFont(DefaultRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EastAsianFont>();
    if (itemElement != null)
      return TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEastAsianFont(DefaultRunProperties? openXmlElement, TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EastAsianFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextFontTypeConverter.CreateOpenXmlElement<EastAsianFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextFontType? GetComplexScriptFont(DefaultRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ComplexScriptFont>();
    if (itemElement != null)
      return TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetComplexScriptFont(DefaultRunProperties? openXmlElement, TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ComplexScriptFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextFontTypeConverter.CreateOpenXmlElement<ComplexScriptFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextFontType? GetSymbolFont(DefaultRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SymbolFont>();
    if (itemElement != null)
      return TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSymbolFont(DefaultRunProperties? openXmlElement, TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SymbolFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextFontTypeConverter.CreateOpenXmlElement<SymbolFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static HyperlinkOnClick? GetHyperlinkOnClick(DefaultRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
    if (itemElement != null)
      return HyperlinkOnClickConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHyperlinkOnClick(DefaultRunProperties? openXmlElement, HyperlinkOnClick? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HyperlinkOnClickConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static HyperlinkOnMouseOver? GetHyperlinkOnMouseOver(DefaultRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver>();
    if (itemElement != null)
      return HyperlinkOnMouseOverConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHyperlinkOnMouseOver(DefaultRunProperties? openXmlElement, HyperlinkOnMouseOver? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HyperlinkOnMouseOverConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetRightToLeft(DefaultRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RightToLeft>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetRightToLeft(DefaultRunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<RightToLeft>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new RightToLeft();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DefaultRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(DefaultRunProperties? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.DefaultRunProperties? CreateModelElement(DefaultRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.DefaultRunProperties();
      value.Outline = GetOutline(openXmlElement);
      value.NoFill = GetNoFill(openXmlElement);
      value.SolidFill = GetSolidFill(openXmlElement);
      value.GradientFill = GetGradientFill(openXmlElement);
      value.BlipFill = GetBlipFill(openXmlElement);
      value.PatternFill = GetPatternFill(openXmlElement);
      value.GroupFill = GetGroupFill(openXmlElement);
      value.EffectList = GetEffectList(openXmlElement);
      value.EffectDag = GetEffectDag(openXmlElement);
      value.Highlight = GetHighlight(openXmlElement);
      value.UnderlineFollowsText = GetUnderlineFollowsText(openXmlElement);
      value.Underline = GetUnderline(openXmlElement);
      value.UnderlineFillText = GetUnderlineFillText(openXmlElement);
      value.UnderlineFill = GetUnderlineFill(openXmlElement);
      value.LatinFont = GetLatinFont(openXmlElement);
      value.EastAsianFont = GetEastAsianFont(openXmlElement);
      value.ComplexScriptFont = GetComplexScriptFont(openXmlElement);
      value.SymbolFont = GetSymbolFont(openXmlElement);
      value.HyperlinkOnClick = GetHyperlinkOnClick(openXmlElement);
      value.HyperlinkOnMouseOver = GetHyperlinkOnMouseOver(openXmlElement);
      value.RightToLeft = GetRightToLeft(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.DefaultRunProperties? value)
    where OpenXmlElementType : DefaultRunProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOutline(openXmlElement, value?.Outline);
      SetNoFill(openXmlElement, value?.NoFill);
      SetSolidFill(openXmlElement, value?.SolidFill);
      SetGradientFill(openXmlElement, value?.GradientFill);
      SetBlipFill(openXmlElement, value?.BlipFill);
      SetPatternFill(openXmlElement, value?.PatternFill);
      SetGroupFill(openXmlElement, value?.GroupFill);
      SetEffectList(openXmlElement, value?.EffectList);
      SetEffectDag(openXmlElement, value?.EffectDag);
      SetHighlight(openXmlElement, value?.Highlight);
      SetUnderlineFollowsText(openXmlElement, value?.UnderlineFollowsText);
      SetUnderline(openXmlElement, value?.Underline);
      SetUnderlineFillText(openXmlElement, value?.UnderlineFillText);
      SetUnderlineFill(openXmlElement, value?.UnderlineFill);
      SetLatinFont(openXmlElement, value?.LatinFont);
      SetEastAsianFont(openXmlElement, value?.EastAsianFont);
      SetComplexScriptFont(openXmlElement, value?.ComplexScriptFont);
      SetSymbolFont(openXmlElement, value?.SymbolFont);
      SetHyperlinkOnClick(openXmlElement, value?.HyperlinkOnClick);
      SetHyperlinkOnMouseOver(openXmlElement, value?.HyperlinkOnMouseOver);
      SetRightToLeft(openXmlElement, value?.RightToLeft);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}