using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using BlipFill = DocumentModel.Drawings.BlipFill;
using Boolean = System.Boolean;
using EffectDag = DocumentModel.Drawings.EffectDag;
using EffectList = DocumentModel.Drawings.EffectList;
using GradientFill = DocumentModel.Drawings.GradientFill;
using Highlight = DocumentModel.Drawings.Highlight;
using HyperlinkOnClick = DocumentModel.Drawings.HyperlinkOnClick;
using HyperlinkOnMouseOver = DocumentModel.Drawings.HyperlinkOnMouseOver;
using Outline = DocumentModel.Drawings.Outline;
using PatternFill = DocumentModel.Drawings.PatternFill;
using SolidFill = DocumentModel.Drawings.SolidFill;
using TextCharacterPropertiesType = DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType;
using TextFontType = DocumentModel.Drawings.TextFontType;
using UnderlineFill = DocumentModel.Drawings.UnderlineFill;

namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
///   Defines the TextCharacterPropertiesType Class.
/// </summary>
public static class TextCharacterPropertiesTypeConverter
{
  /// <summary>
  ///   Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public static Boolean? GetSmtClean(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.SmtClean?.Value;
  }

  public static void SetSmtClean(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SmtClean = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.SmtClean = null;
  }

  /// <summary>
  ///   Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public static UInt32? GetSmtId(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.SmtId?.Value;
  }

  public static void SetSmtId(TextCharacterPropertiesType? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SmtId = value;
  }

  /// <summary>
  ///   kumimoji
  /// </summary>
  public static Boolean? GetKumimoji(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Kumimoji?.Value;
  }

  public static void SetKumimoji(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Kumimoji = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Kumimoji = null;
  }

  /// <summary>
  ///   lang
  /// </summary>
  public static String? GetLanguage(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }

  public static void SetLanguage(TextCharacterPropertiesType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Language = new StringValue { Value = value };
      else
        openXmlElement.Language = null;
  }

  /// <summary>
  ///   altLang
  /// </summary>
  public static String? GetAlternativeLanguage(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.AlternativeLanguage?.Value;
  }

  public static void SetAlternativeLanguage(TextCharacterPropertiesType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AlternativeLanguage = new StringValue { Value = value };
      else
        openXmlElement.AlternativeLanguage = null;
  }

  /// <summary>
  ///   sz
  /// </summary>
  public static Int32? GetFontSize(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.FontSize?.Value;
  }

  public static void SetFontSize(TextCharacterPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FontSize = value;
  }

  /// <summary>
  ///   b
  /// </summary>
  public static Boolean? GetBold(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Bold?.Value;
  }

  public static void SetBold(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Bold = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Bold = null;
  }

  /// <summary>
  ///   i
  /// </summary>
  public static Boolean? GetItalic(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Italic?.Value;
  }

  public static void SetItalic(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Italic = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Italic = null;
  }

  /// <summary>
  ///   u
  /// </summary>
  public static TextUnderlineKind? GetUnderline(TextCharacterPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<TextUnderlineValues, TextUnderlineKind>(openXmlElement?.Underline?.Value);
  }

  public static void SetUnderline(TextCharacterPropertiesType? openXmlElement, TextUnderlineKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Underline = EnumValueConverter.CreateEnumValue<TextUnderlineValues, TextUnderlineKind>(value);
  }

  /// <summary>
  ///   strike
  /// </summary>
  public static TextStrikeKind? GetStrike(TextCharacterPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<TextStrikeValues, TextStrikeKind>(openXmlElement?.Strike?.Value);
  }

  public static void SetStrike(TextCharacterPropertiesType? openXmlElement, TextStrikeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Strike = EnumValueConverter.CreateEnumValue<TextStrikeValues, TextStrikeKind>(value);
  }

  /// <summary>
  ///   kern
  /// </summary>
  public static Int32? GetKerning(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Kerning?.Value;
  }

  public static void SetKerning(TextCharacterPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Kerning = value;
  }

  /// <summary>
  ///   cap
  /// </summary>
  public static TextCapsKind? GetCapital(TextCharacterPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<TextCapsValues, TextCapsKind>(openXmlElement?.Capital?.Value);
  }

  public static void SetCapital(TextCharacterPropertiesType? openXmlElement, TextCapsKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Capital = EnumValueConverter.CreateEnumValue<TextCapsValues, TextCapsKind>(value);
  }

  /// <summary>
  ///   spc
  /// </summary>
  public static Int32? GetSpacing(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Spacing?.Value;
  }

  public static void SetSpacing(TextCharacterPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Spacing = value;
  }

  /// <summary>
  ///   normalizeH
  /// </summary>
  public static Boolean? GetNormalizeHeight(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.NormalizeHeight?.Value;
  }

  public static void SetNormalizeHeight(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NormalizeHeight = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NormalizeHeight = null;
  }

  /// <summary>
  ///   baseline
  /// </summary>
  public static Int32? GetBaseline(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Baseline?.Value;
  }

  public static void SetBaseline(TextCharacterPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Baseline = value;
  }

  /// <summary>
  ///   noProof
  /// </summary>
  public static Boolean? GetNoProof(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.NoProof?.Value;
  }

  public static void SetNoProof(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoProof = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoProof = null;
  }

  /// <summary>
  ///   dirty
  /// </summary>
  public static Boolean? GetDirty(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Dirty?.Value;
  }

  public static void SetDirty(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Dirty = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Dirty = null;
  }

  /// <summary>
  ///   err
  /// </summary>
  public static Boolean? GetSpellingError(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.SpellingError?.Value;
  }

  public static void SetSpellingError(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SpellingError = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.SpellingError = null;
  }

  /// <summary>
  ///   smtClean
  /// </summary>
  public static Boolean? GetSmartTagClean(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.SmartTagClean?.Value;
  }

  public static void SetSmartTagClean(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SmartTagClean = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.SmartTagClean = null;
  }

  /// <summary>
  ///   smtId
  /// </summary>
  public static UInt32? GetSmartTagId(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.SmartTagId?.Value;
  }

  public static void SetSmartTagId(TextCharacterPropertiesType? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SmartTagId = value;
  }

  /// <summary>
  ///   bmk
  /// </summary>
  public static String? GetBookmark(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Bookmark?.Value;
  }

  public static void SetBookmark(TextCharacterPropertiesType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Bookmark = new StringValue { Value = value };
      else
        openXmlElement.Bookmark = null;
  }

  /// <summary>
  ///   Outline.
  /// </summary>
  public static Outline? GetOutline(TextCharacterPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
    if (itemElement != null)
      return OutlineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOutline(TextCharacterPropertiesType? openXmlElement, Outline? value)
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

  public static Boolean? GetNoFill(TextCharacterPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoFill>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoFill(TextCharacterPropertiesType? openXmlElement, Boolean? value)
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

  public static SolidFill? GetSolidFill(TextCharacterPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
    if (itemElement != null)
      return SolidFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSolidFill(TextCharacterPropertiesType? openXmlElement, SolidFill? value)
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

  public static GradientFill? GetGradientFill(TextCharacterPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
    if (itemElement != null)
      return GradientFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGradientFill(TextCharacterPropertiesType? openXmlElement, GradientFill? value)
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

  public static BlipFill? GetBlipFill(TextCharacterPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
    if (itemElement != null)
      return BlipFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBlipFill(TextCharacterPropertiesType? openXmlElement, BlipFill? value)
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

  public static PatternFill? GetPatternFill(TextCharacterPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
    if (itemElement != null)
      return PatternFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPatternFill(TextCharacterPropertiesType? openXmlElement, PatternFill? value)
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

  public static Boolean? GetGroupFill(TextCharacterPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<GroupFill>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetGroupFill(TextCharacterPropertiesType? openXmlElement, Boolean? value)
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

  public static EffectList? GetEffectList(TextCharacterPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectList>();
    if (itemElement != null)
      return EffectListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEffectList(TextCharacterPropertiesType? openXmlElement, EffectList? value)
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

  public static EffectDag? GetEffectDag(TextCharacterPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
    if (itemElement != null)
      return EffectDagConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEffectDag(TextCharacterPropertiesType? openXmlElement, EffectDag? value)
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

  public static Highlight? GetHighlight(TextCharacterPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Highlight>();
    if (itemElement != null)
      return HighlightConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHighlight(TextCharacterPropertiesType? openXmlElement, Highlight? value)
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

  public static Boolean? GetUnderlineFollowsText(TextCharacterPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UnderlineFollowsText>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUnderlineFollowsText(TextCharacterPropertiesType? openXmlElement, Boolean? value)
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

  public static Boolean? GetUnderlineFillText(TextCharacterPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UnderlineFillText>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUnderlineFillText(TextCharacterPropertiesType? openXmlElement, Boolean? value)
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

  public static UnderlineFill? GetUnderlineFill(TextCharacterPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.UnderlineFill>();
    if (itemElement != null)
      return UnderlineFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnderlineFill(TextCharacterPropertiesType? openXmlElement, UnderlineFill? value)
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

  public static TextFontType? GetLatinFont(TextCharacterPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LatinFont>();
    if (itemElement != null)
      return TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLatinFont(TextCharacterPropertiesType? openXmlElement, TextFontType? value)
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

  public static TextFontType? GetEastAsianFont(TextCharacterPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EastAsianFont>();
    if (itemElement != null)
      return TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEastAsianFont(TextCharacterPropertiesType? openXmlElement, TextFontType? value)
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

  public static TextFontType? GetComplexScriptFont(TextCharacterPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ComplexScriptFont>();
    if (itemElement != null)
      return TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetComplexScriptFont(TextCharacterPropertiesType? openXmlElement, TextFontType? value)
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

  public static TextFontType? GetSymbolFont(TextCharacterPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SymbolFont>();
    if (itemElement != null)
      return TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSymbolFont(TextCharacterPropertiesType? openXmlElement, TextFontType? value)
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

  public static HyperlinkOnClick? GetHyperlinkOnClick(TextCharacterPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
    if (itemElement != null)
      return HyperlinkOnClickConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHyperlinkOnClick(TextCharacterPropertiesType? openXmlElement, HyperlinkOnClick? value)
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

  public static HyperlinkOnMouseOver? GetHyperlinkOnMouseOver(TextCharacterPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver>();
    if (itemElement != null)
      return HyperlinkOnMouseOverConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHyperlinkOnMouseOver(TextCharacterPropertiesType? openXmlElement, HyperlinkOnMouseOver? value)
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

  public static Boolean? GetRightToLeft(TextCharacterPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RightToLeft>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetRightToLeft(TextCharacterPropertiesType? openXmlElement, Boolean? value)
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

  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(TextCharacterPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(TextCharacterPropertiesType? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
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

  public static DocumentModel.Drawings.ChartsStyle.TextCharacterPropertiesType? CreateModelElement(TextCharacterPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.TextCharacterPropertiesType();
      value.SmtClean = GetSmtClean(openXmlElement);
      value.SmtId = GetSmtId(openXmlElement);
      value.Kumimoji = GetKumimoji(openXmlElement);
      value.Language = GetLanguage(openXmlElement);
      value.AlternativeLanguage = GetAlternativeLanguage(openXmlElement);
      value.FontSize = GetFontSize(openXmlElement);
      value.Bold = GetBold(openXmlElement);
      value.Italic = GetItalic(openXmlElement);
      value.Underline = GetUnderline(openXmlElement);
      value.Strike = GetStrike(openXmlElement);
      value.Kerning = GetKerning(openXmlElement);
      value.Capital = GetCapital(openXmlElement);
      value.Spacing = GetSpacing(openXmlElement);
      value.NormalizeHeight = GetNormalizeHeight(openXmlElement);
      value.Baseline = GetBaseline(openXmlElement);
      value.NoProof = GetNoProof(openXmlElement);
      value.Dirty = GetDirty(openXmlElement);
      value.SpellingError = GetSpellingError(openXmlElement);
      value.SmartTagClean = GetSmartTagClean(openXmlElement);
      value.SmartTagId = GetSmartTagId(openXmlElement);
      value.Bookmark = GetBookmark(openXmlElement);
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartsStyle.TextCharacterPropertiesType? value)
    where OpenXmlElementType : TextCharacterPropertiesType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSmtClean(openXmlElement, value?.SmtClean);
      SetSmtId(openXmlElement, value?.SmtId);
      SetKumimoji(openXmlElement, value?.Kumimoji);
      SetLanguage(openXmlElement, value?.Language);
      SetAlternativeLanguage(openXmlElement, value?.AlternativeLanguage);
      SetFontSize(openXmlElement, value?.FontSize);
      SetBold(openXmlElement, value?.Bold);
      SetItalic(openXmlElement, value?.Italic);
      SetUnderline(openXmlElement, value?.Underline);
      SetStrike(openXmlElement, value?.Strike);
      SetKerning(openXmlElement, value?.Kerning);
      SetCapital(openXmlElement, value?.Capital);
      SetSpacing(openXmlElement, value?.Spacing);
      SetNormalizeHeight(openXmlElement, value?.NormalizeHeight);
      SetBaseline(openXmlElement, value?.Baseline);
      SetNoProof(openXmlElement, value?.NoProof);
      SetDirty(openXmlElement, value?.Dirty);
      SetSpellingError(openXmlElement, value?.SpellingError);
      SetSmartTagClean(openXmlElement, value?.SmartTagClean);
      SetSmartTagId(openXmlElement, value?.SmartTagId);
      SetBookmark(openXmlElement, value?.Bookmark);
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