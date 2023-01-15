using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using BorderType = DocumentModel.Wordprocessing.BorderType;
using Color = DocumentModel.Wordprocessing.Color;
using EastAsianLayout = DocumentModel.Wordprocessing.EastAsianLayout;
using FitText = DocumentModel.Wordprocessing.FitText;
using LanguageType = DocumentModel.Wordprocessing.LanguageType;
using RunFonts = DocumentModel.Wordprocessing.RunFonts;
using RunPropertiesBaseStyle = DocumentFormat.OpenXml.Wordprocessing.RunPropertiesBaseStyle;
using Shading = DocumentModel.Wordprocessing.Shading;
using Underline = DocumentModel.Wordprocessing.Underline;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Run Properties.
/// </summary>
public static class RunPropertiesBaseStyleConverter
{
  /// <summary>
  ///   RunFonts.
  /// </summary>
  public static RunFonts? GetRunFonts(RunPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunFonts>();
    if (itemElement != null)
      return RunFontsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunFonts(RunPropertiesBaseStyle? openXmlElement, RunFonts? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunFonts>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunFontsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunFonts>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Bold.
  /// </summary>
  public static Boolean? GetBold(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Bold>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBold(RunPropertiesBaseStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Bold>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Bold();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   BoldComplexScript.
  /// </summary>
  public static Boolean? GetBoldComplexScript(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BoldComplexScript>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBoldComplexScript(RunPropertiesBaseStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<BoldComplexScript>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new BoldComplexScript();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Italic.
  /// </summary>
  public static Boolean? GetItalic(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Italic>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetItalic(RunPropertiesBaseStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Italic>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Italic();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ItalicComplexScript.
  /// </summary>
  public static Boolean? GetItalicComplexScript(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ItalicComplexScript>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetItalicComplexScript(RunPropertiesBaseStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ItalicComplexScript>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ItalicComplexScript();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Caps.
  /// </summary>
  public static Boolean? GetCaps(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Caps>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetCaps(RunPropertiesBaseStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Caps>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Caps();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   SmallCaps.
  /// </summary>
  public static Boolean? GetSmallCaps(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SmallCaps>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSmallCaps(RunPropertiesBaseStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SmallCaps>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SmallCaps();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Strike.
  /// </summary>
  public static Boolean? GetStrike(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Strike>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetStrike(RunPropertiesBaseStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Strike>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Strike();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DoubleStrike.
  /// </summary>
  public static Boolean? GetDoubleStrike(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoubleStrike>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoubleStrike(RunPropertiesBaseStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoubleStrike>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoubleStrike();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Outline.
  /// </summary>
  public static Boolean? GetOutline(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Outline>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetOutline(RunPropertiesBaseStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Outline>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Outline();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Shadow.
  /// </summary>
  public static Boolean? GetShadow(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Shadow>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShadow(RunPropertiesBaseStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Shadow>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Shadow();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Emboss.
  /// </summary>
  public static Boolean? GetEmboss(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Emboss>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetEmboss(RunPropertiesBaseStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Emboss>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Emboss();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Imprint.
  /// </summary>
  public static Boolean? GetImprint(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Imprint>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetImprint(RunPropertiesBaseStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Imprint>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Imprint();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   NoProof.
  /// </summary>
  public static Boolean? GetNoProof(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoProof>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoProof(RunPropertiesBaseStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<NoProof>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new NoProof();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   SnapToGrid.
  /// </summary>
  public static Boolean? GetSnapToGrid(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SnapToGrid>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSnapToGrid(RunPropertiesBaseStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SnapToGrid>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SnapToGrid();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Vanish.
  /// </summary>
  public static Boolean? GetVanish(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Vanish>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetVanish(RunPropertiesBaseStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Vanish>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Vanish();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   WebHidden.
  /// </summary>
  public static Boolean? GetWebHidden(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WebHidden>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetWebHidden(RunPropertiesBaseStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<WebHidden>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new WebHidden();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Color.
  /// </summary>
  public static Color? GetColor(RunPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Color>();
    if (itemElement != null)
      return ColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColor(RunPropertiesBaseStyle? openXmlElement, Color? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Color>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Spacing.
  /// </summary>
  public static Int32? GetSpacing(RunPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Spacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSpacing(RunPropertiesBaseStyle? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Spacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Spacing { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   CharacterScale.
  /// </summary>
  public static Int64? GetCharacterScale(RunPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CharacterScale>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetCharacterScale(RunPropertiesBaseStyle? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CharacterScale>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new CharacterScale { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Kern.
  /// </summary>
  public static UInt32? GetKern(RunPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Kern>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetKern(RunPropertiesBaseStyle? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Kern>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Kern { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Position.
  /// </summary>
  public static String? GetPosition(RunPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Position>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPosition(RunPropertiesBaseStyle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Position>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Position { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   FontSize.
  /// </summary>
  public static String? GetFontSize(RunPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FontSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetFontSize(RunPropertiesBaseStyle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FontSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new FontSize { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   FontSizeComplexScript.
  /// </summary>
  public static String? GetFontSizeComplexScript(RunPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FontSizeComplexScript>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetFontSizeComplexScript(RunPropertiesBaseStyle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FontSizeComplexScript>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new FontSizeComplexScript { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Underline.
  /// </summary>
  public static Underline? GetUnderline(RunPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Underline>();
    if (itemElement != null)
      return UnderlineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnderline(RunPropertiesBaseStyle? openXmlElement, Underline? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Underline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnderlineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Underline>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TextEffect.
  /// </summary>
  public static TextEffectKind? GetTextEffect(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextEffect>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TextEffectValues, TextEffectKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTextEffect(RunPropertiesBaseStyle? openXmlElement, TextEffectKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextEffect>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<TextEffect, TextEffectValues, TextEffectKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Border.
  /// </summary>
  public static BorderType? GetBorder(RunPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Border>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBorder(RunPropertiesBaseStyle? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Border>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<Border>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Shading.
  /// </summary>
  public static Shading? GetShading(RunPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return ShadingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShading(RunPropertiesBaseStyle? openXmlElement, Shading? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShadingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Shading>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   FitText.
  /// </summary>
  public static FitText? GetFitText(RunPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FitText>();
    if (itemElement != null)
      return FitTextConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFitText(RunPropertiesBaseStyle? openXmlElement, FitText? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FitText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FitTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FitText>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   VerticalTextAlignment.
  /// </summary>
  public static VerticalPositionKind? GetVerticalTextAlignment(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VerticalTextAlignment>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<VerticalPositionValues, VerticalPositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetVerticalTextAlignment(RunPropertiesBaseStyle? openXmlElement, VerticalPositionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VerticalTextAlignment>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<VerticalTextAlignment, VerticalPositionValues, VerticalPositionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Emphasis.
  /// </summary>
  public static EmphasisMarkKind? GetEmphasis(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Emphasis>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<EmphasisMarkValues, EmphasisMarkKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetEmphasis(RunPropertiesBaseStyle? openXmlElement, EmphasisMarkKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Emphasis>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Emphasis, EmphasisMarkValues, EmphasisMarkKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Languages.
  /// </summary>
  public static LanguageType? GetLanguages(RunPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Languages>();
    if (itemElement != null)
      return LanguageTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLanguages(RunPropertiesBaseStyle? openXmlElement, LanguageType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Languages>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LanguageTypeConverter.CreateOpenXmlElement<Languages>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EastAsianLayout.
  /// </summary>
  public static EastAsianLayout? GetEastAsianLayout(RunPropertiesBaseStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout>();
    if (itemElement != null)
      return EastAsianLayoutConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEastAsianLayout(RunPropertiesBaseStyle? openXmlElement, EastAsianLayout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EastAsianLayoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   SpecVanish.
  /// </summary>
  public static Boolean? GetSpecVanish(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SpecVanish>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSpecVanish(RunPropertiesBaseStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SpecVanish>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SpecVanish();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.RunPropertiesBaseStyle? CreateModelElement(RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.RunPropertiesBaseStyle();
      value.RunFonts = GetRunFonts(openXmlElement);
      value.Bold = GetBold(openXmlElement);
      value.BoldComplexScript = GetBoldComplexScript(openXmlElement);
      value.Italic = GetItalic(openXmlElement);
      value.ItalicComplexScript = GetItalicComplexScript(openXmlElement);
      value.Caps = GetCaps(openXmlElement);
      value.SmallCaps = GetSmallCaps(openXmlElement);
      value.Strike = GetStrike(openXmlElement);
      value.DoubleStrike = GetDoubleStrike(openXmlElement);
      value.Outline = GetOutline(openXmlElement);
      value.Shadow = GetShadow(openXmlElement);
      value.Emboss = GetEmboss(openXmlElement);
      value.Imprint = GetImprint(openXmlElement);
      value.NoProof = GetNoProof(openXmlElement);
      value.SnapToGrid = GetSnapToGrid(openXmlElement);
      value.Vanish = GetVanish(openXmlElement);
      value.WebHidden = GetWebHidden(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.Spacing = GetSpacing(openXmlElement);
      value.CharacterScale = GetCharacterScale(openXmlElement);
      value.Kern = GetKern(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      value.FontSize = GetFontSize(openXmlElement);
      value.FontSizeComplexScript = GetFontSizeComplexScript(openXmlElement);
      value.Underline = GetUnderline(openXmlElement);
      value.TextEffect = GetTextEffect(openXmlElement);
      value.Border = GetBorder(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.FitText = GetFitText(openXmlElement);
      value.VerticalTextAlignment = GetVerticalTextAlignment(openXmlElement);
      value.Emphasis = GetEmphasis(openXmlElement);
      value.Languages = GetLanguages(openXmlElement);
      value.EastAsianLayout = GetEastAsianLayout(openXmlElement);
      value.SpecVanish = GetSpecVanish(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.RunPropertiesBaseStyle? value)
    where OpenXmlElementType : RunPropertiesBaseStyle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunFonts(openXmlElement, value?.RunFonts);
      SetBold(openXmlElement, value?.Bold);
      SetBoldComplexScript(openXmlElement, value?.BoldComplexScript);
      SetItalic(openXmlElement, value?.Italic);
      SetItalicComplexScript(openXmlElement, value?.ItalicComplexScript);
      SetCaps(openXmlElement, value?.Caps);
      SetSmallCaps(openXmlElement, value?.SmallCaps);
      SetStrike(openXmlElement, value?.Strike);
      SetDoubleStrike(openXmlElement, value?.DoubleStrike);
      SetOutline(openXmlElement, value?.Outline);
      SetShadow(openXmlElement, value?.Shadow);
      SetEmboss(openXmlElement, value?.Emboss);
      SetImprint(openXmlElement, value?.Imprint);
      SetNoProof(openXmlElement, value?.NoProof);
      SetSnapToGrid(openXmlElement, value?.SnapToGrid);
      SetVanish(openXmlElement, value?.Vanish);
      SetWebHidden(openXmlElement, value?.WebHidden);
      SetColor(openXmlElement, value?.Color);
      SetSpacing(openXmlElement, value?.Spacing);
      SetCharacterScale(openXmlElement, value?.CharacterScale);
      SetKern(openXmlElement, value?.Kern);
      SetPosition(openXmlElement, value?.Position);
      SetFontSize(openXmlElement, value?.FontSize);
      SetFontSizeComplexScript(openXmlElement, value?.FontSizeComplexScript);
      SetUnderline(openXmlElement, value?.Underline);
      SetTextEffect(openXmlElement, value?.TextEffect);
      SetBorder(openXmlElement, value?.Border);
      SetShading(openXmlElement, value?.Shading);
      SetFitText(openXmlElement, value?.FitText);
      SetVerticalTextAlignment(openXmlElement, value?.VerticalTextAlignment);
      SetEmphasis(openXmlElement, value?.Emphasis);
      SetLanguages(openXmlElement, value?.Languages);
      SetEastAsianLayout(openXmlElement, value?.EastAsianLayout);
      SetSpecVanish(openXmlElement, value?.SpecVanish);
      return openXmlElement;
    }
    return default;
  }
}