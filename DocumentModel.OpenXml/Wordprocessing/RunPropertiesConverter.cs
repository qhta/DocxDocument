using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using BorderType = DocumentModel.Wordprocessing.BorderType;
using Color = DocumentModel.Wordprocessing.Color;
using EastAsianLayout = DocumentModel.Wordprocessing.EastAsianLayout;
using FillTextEffect = DocumentModel.Wordprocessing.FillTextEffect;
using FitText = DocumentModel.Wordprocessing.FitText;
using Glow = DocumentModel.Wordprocessing.Glow;
using LanguageType = DocumentModel.Wordprocessing.LanguageType;
using NumberingFormat = DocumentFormat.OpenXml.Office2010.Word.NumberingFormat;
using Properties3D = DocumentModel.Wordprocessing.Properties3D;
using Reflection = DocumentModel.Wordprocessing.Reflection;
using RunFonts = DocumentModel.Wordprocessing.RunFonts;
using RunProperties = DocumentFormat.OpenXml.Wordprocessing.RunProperties;
using RunPropertiesChange = DocumentModel.Wordprocessing.RunPropertiesChange;
using Scene3D = DocumentModel.Wordprocessing.Scene3D;
using Shading = DocumentModel.Wordprocessing.Shading;
using Shadow = DocumentFormat.OpenXml.Wordprocessing.Shadow;
using StylisticSets = DocumentModel.Wordprocessing.StylisticSets;
using TextOutlineEffect = DocumentModel.Wordprocessing.TextOutlineEffect;
using Underline = DocumentModel.Wordprocessing.Underline;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Run Properties.
/// </summary>
public static class RunPropertiesConverter
{
  /// <summary>
  ///   RunStyle.
  /// </summary>
  public static String? GetRunStyle(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RunStyle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRunStyle(RunProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RunStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new RunStyle { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   RunFonts.
  /// </summary>
  public static RunFonts? GetRunFonts(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunFonts>();
    if (itemElement != null)
      return RunFontsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunFonts(RunProperties? openXmlElement, RunFonts? value)
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
  public static Boolean? GetBold(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Bold>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBold(RunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetBoldComplexScript(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BoldComplexScript>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBoldComplexScript(RunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetItalic(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Italic>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetItalic(RunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetItalicComplexScript(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ItalicComplexScript>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetItalicComplexScript(RunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetCaps(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Caps>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetCaps(RunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetSmallCaps(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SmallCaps>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSmallCaps(RunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetStrike(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Strike>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetStrike(RunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetDoubleStrike(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoubleStrike>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoubleStrike(RunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetOutline(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Outline>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetOutline(RunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetShadow(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Shadow>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShadow(RunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetEmboss(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Emboss>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetEmboss(RunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetImprint(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Imprint>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetImprint(RunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoProof(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoProof>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoProof(RunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetSnapToGrid(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SnapToGrid>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSnapToGrid(RunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetVanish(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Vanish>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetVanish(RunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetWebHidden(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WebHidden>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetWebHidden(RunProperties? openXmlElement, Boolean? value)
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
  public static Color? GetColor(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Color>();
    if (itemElement != null)
      return ColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColor(RunProperties? openXmlElement, Color? value)
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
  public static Int32? GetSpacing(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Spacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSpacing(RunProperties? openXmlElement, Int32? value)
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
  public static Int64? GetCharacterScale(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CharacterScale>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetCharacterScale(RunProperties? openXmlElement, Int64? value)
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
  public static UInt32? GetKern(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Kern>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetKern(RunProperties? openXmlElement, UInt32? value)
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
  public static String? GetPosition(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Position>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPosition(RunProperties? openXmlElement, String? value)
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
  public static String? GetFontSize(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FontSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetFontSize(RunProperties? openXmlElement, String? value)
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
  public static String? GetFontSizeComplexScript(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FontSizeComplexScript>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetFontSizeComplexScript(RunProperties? openXmlElement, String? value)
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
  ///   Highlight.
  /// </summary>
  public static HighlightColorKind? GetHighlight(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Highlight>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<HighlightColorValues, HighlightColorKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetHighlight(RunProperties? openXmlElement, HighlightColorKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Highlight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Highlight, HighlightColorValues, HighlightColorKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Underline.
  /// </summary>
  public static Underline? GetUnderline(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Underline>();
    if (itemElement != null)
      return UnderlineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnderline(RunProperties? openXmlElement, Underline? value)
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
  public static TextEffectKind? GetTextEffect(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextEffect>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TextEffectValues, TextEffectKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTextEffect(RunProperties? openXmlElement, TextEffectKind? value)
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
  public static BorderType? GetBorder(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Border>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBorder(RunProperties? openXmlElement, BorderType? value)
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
  public static Shading? GetShading(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return ShadingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShading(RunProperties? openXmlElement, Shading? value)
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
  public static FitText? GetFitText(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FitText>();
    if (itemElement != null)
      return FitTextConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFitText(RunProperties? openXmlElement, FitText? value)
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
  public static VerticalPositionKind? GetVerticalTextAlignment(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VerticalTextAlignment>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<VerticalPositionValues, VerticalPositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetVerticalTextAlignment(RunProperties? openXmlElement, VerticalPositionKind? value)
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
  ///   RightToLeftText.
  /// </summary>
  public static Boolean? GetRightToLeftText(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RightToLeftText>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetRightToLeftText(RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<RightToLeftText>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new RightToLeftText();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ComplexScript.
  /// </summary>
  public static Boolean? GetComplexScript(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ComplexScript>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetComplexScript(RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ComplexScript>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ComplexScript();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Emphasis.
  /// </summary>
  public static EmphasisMarkKind? GetEmphasis(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Emphasis>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<EmphasisMarkValues, EmphasisMarkKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetEmphasis(RunProperties? openXmlElement, EmphasisMarkKind? value)
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
  public static LanguageType? GetLanguages(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Languages>();
    if (itemElement != null)
      return LanguageTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLanguages(RunProperties? openXmlElement, LanguageType? value)
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
  public static EastAsianLayout? GetEastAsianLayout(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout>();
    if (itemElement != null)
      return EastAsianLayoutConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEastAsianLayout(RunProperties? openXmlElement, EastAsianLayout? value)
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
  public static Boolean? GetSpecVanish(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SpecVanish>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSpecVanish(RunProperties? openXmlElement, Boolean? value)
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

  /// <summary>
  ///   Glow, this property is only available in Office 2010 and later..
  /// </summary>
  public static Glow? GetGlow(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Glow>();
    if (itemElement != null)
      return GlowConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGlow(RunProperties? openXmlElement, Glow? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Glow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GlowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.Glow>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Shadow14, this property is only available in Office 2010 and later..
  /// </summary>
  public static Shadow2? GetShadow14(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Shadow>();
    if (itemElement != null)
      return Shadow2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShadow14(RunProperties? openXmlElement, Shadow2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Shadow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Shadow2Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.Shadow>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Reflection, this property is only available in Office 2010 and later..
  /// </summary>
  public static Reflection? GetReflection(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Reflection>();
    if (itemElement != null)
      return ReflectionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetReflection(RunProperties? openXmlElement, Reflection? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Reflection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ReflectionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.Reflection>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TextOutlineEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public static TextOutlineEffect? GetTextOutlineEffect(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect>();
    if (itemElement != null)
      return TextOutlineEffectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextOutlineEffect(RunProperties? openXmlElement, TextOutlineEffect? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextOutlineEffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   FillTextEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public static FillTextEffect? GetFillTextEffect(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.FillTextEffect>();
    if (itemElement != null)
      return FillTextEffectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFillTextEffect(RunProperties? openXmlElement, FillTextEffect? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.FillTextEffect>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillTextEffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.FillTextEffect>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Scene3D, this property is only available in Office 2010 and later..
  /// </summary>
  public static Scene3D? GetScene3D(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Scene3D>();
    if (itemElement != null)
      return Scene3DConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetScene3D(RunProperties? openXmlElement, Scene3D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Scene3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Scene3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.Scene3D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Properties3D, this property is only available in Office 2010 and later..
  /// </summary>
  public static Properties3D? GetProperties3D(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Properties3D>();
    if (itemElement != null)
      return Properties3DConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetProperties3D(RunProperties? openXmlElement, Properties3D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Properties3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Properties3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.Properties3D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Ligatures, this property is only available in Office 2010 and later..
  /// </summary>
  public static LigaturesKind? GetLigatures(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Ligatures>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<LigaturesValues, LigaturesKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetLigatures(RunProperties? openXmlElement, LigaturesKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Ligatures>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Ligatures, LigaturesValues, LigaturesKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   NumberingFormat, this property is only available in Office 2010 and later..
  /// </summary>
  public static NumberFormKind? GetNumberingFormat(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberingFormat>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<NumberFormValues, NumberFormKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetNumberingFormat(RunProperties? openXmlElement, NumberFormKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberingFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<NumberingFormat, NumberFormValues, NumberFormKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   NumberSpacing, this property is only available in Office 2010 and later..
  /// </summary>
  public static NumberSpacingKind? GetNumberSpacing(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberSpacing>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<NumberSpacingValues, NumberSpacingKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetNumberSpacing(RunProperties? openXmlElement, NumberSpacingKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<NumberSpacing, NumberSpacingValues, NumberSpacingKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   StylisticSets, this property is only available in Office 2010 and later..
  /// </summary>
  public static StylisticSets? GetStylisticSets(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.StylisticSets>();
    if (itemElement != null)
      return StylisticSetsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStylisticSets(RunProperties? openXmlElement, StylisticSets? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.StylisticSets>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StylisticSetsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.StylisticSets>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ContextualAlternatives, this property is only available in Office 2010 and later..
  /// </summary>
  public static OnOffKind? GetContextualAlternatives(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ContextualAlternatives>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffValues, OnOffKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetContextualAlternatives(RunProperties? openXmlElement, OnOffKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ContextualAlternatives>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<ContextualAlternatives, OnOffValues, OnOffKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   RunPropertiesChange.
  /// </summary>
  public static RunPropertiesChange? GetRunPropertiesChange(RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesChange>();
    if (itemElement != null)
      return RunPropertiesChangeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunPropertiesChange(RunProperties? openXmlElement, RunPropertiesChange? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunPropertiesChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesChange>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.RunProperties? CreateModelElement(RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.RunProperties();
      value.RunStyle = GetRunStyle(openXmlElement);
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
      value.Highlight = GetHighlight(openXmlElement);
      value.Underline = GetUnderline(openXmlElement);
      value.TextEffect = GetTextEffect(openXmlElement);
      value.Border = GetBorder(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.FitText = GetFitText(openXmlElement);
      value.VerticalTextAlignment = GetVerticalTextAlignment(openXmlElement);
      value.RightToLeftText = GetRightToLeftText(openXmlElement);
      value.ComplexScript = GetComplexScript(openXmlElement);
      value.Emphasis = GetEmphasis(openXmlElement);
      value.Languages = GetLanguages(openXmlElement);
      value.EastAsianLayout = GetEastAsianLayout(openXmlElement);
      value.SpecVanish = GetSpecVanish(openXmlElement);
      value.Glow = GetGlow(openXmlElement);
      value.Shadow14 = GetShadow14(openXmlElement);
      value.Reflection = GetReflection(openXmlElement);
      value.TextOutlineEffect = GetTextOutlineEffect(openXmlElement);
      value.FillTextEffect = GetFillTextEffect(openXmlElement);
      value.Scene3D = GetScene3D(openXmlElement);
      value.Properties3D = GetProperties3D(openXmlElement);
      value.Ligatures = GetLigatures(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.NumberSpacing = GetNumberSpacing(openXmlElement);
      value.StylisticSets = GetStylisticSets(openXmlElement);
      value.ContextualAlternatives = GetContextualAlternatives(openXmlElement);
      value.RunPropertiesChange = GetRunPropertiesChange(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.RunProperties? value)
    where OpenXmlElementType : RunProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunStyle(openXmlElement, value?.RunStyle);
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
      SetHighlight(openXmlElement, value?.Highlight);
      SetUnderline(openXmlElement, value?.Underline);
      SetTextEffect(openXmlElement, value?.TextEffect);
      SetBorder(openXmlElement, value?.Border);
      SetShading(openXmlElement, value?.Shading);
      SetFitText(openXmlElement, value?.FitText);
      SetVerticalTextAlignment(openXmlElement, value?.VerticalTextAlignment);
      SetRightToLeftText(openXmlElement, value?.RightToLeftText);
      SetComplexScript(openXmlElement, value?.ComplexScript);
      SetEmphasis(openXmlElement, value?.Emphasis);
      SetLanguages(openXmlElement, value?.Languages);
      SetEastAsianLayout(openXmlElement, value?.EastAsianLayout);
      SetSpecVanish(openXmlElement, value?.SpecVanish);
      SetGlow(openXmlElement, value?.Glow);
      SetShadow14(openXmlElement, value?.Shadow14);
      SetReflection(openXmlElement, value?.Reflection);
      SetTextOutlineEffect(openXmlElement, value?.TextOutlineEffect);
      SetFillTextEffect(openXmlElement, value?.FillTextEffect);
      SetScene3D(openXmlElement, value?.Scene3D);
      SetProperties3D(openXmlElement, value?.Properties3D);
      SetLigatures(openXmlElement, value?.Ligatures);
      SetNumberingFormat(openXmlElement, value?.NumberingFormat);
      SetNumberSpacing(openXmlElement, value?.NumberSpacing);
      SetStylisticSets(openXmlElement, value?.StylisticSets);
      SetContextualAlternatives(openXmlElement, value?.ContextualAlternatives);
      SetRunPropertiesChange(openXmlElement, value?.RunPropertiesChange);
      return openXmlElement;
    }
    return default;
  }
}