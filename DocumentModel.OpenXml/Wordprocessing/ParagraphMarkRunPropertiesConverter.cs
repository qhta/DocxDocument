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
using ParagraphMarkRunProperties = DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties;
using ParagraphMarkRunPropertiesChange = DocumentModel.Wordprocessing.ParagraphMarkRunPropertiesChange;
using Properties3D = DocumentModel.Wordprocessing.Properties3D;
using Reflection = DocumentModel.Wordprocessing.Reflection;
using RunFonts = DocumentModel.Wordprocessing.RunFonts;
using Scene3D = DocumentModel.Wordprocessing.Scene3D;
using Shading = DocumentModel.Wordprocessing.Shading;
using Shadow = DocumentFormat.OpenXml.Wordprocessing.Shadow;
using StylisticSets = DocumentModel.Wordprocessing.StylisticSets;
using TextOutlineEffect = DocumentModel.Wordprocessing.TextOutlineEffect;
using TrackChangeType = DocumentModel.Wordprocessing.TrackChangeType;
using Underline = DocumentModel.Wordprocessing.Underline;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Run Properties for the Paragraph Mark.
/// </summary>
public static class ParagraphMarkRunPropertiesConverter
{
  /// <summary>
  ///   Inserted Paragraph.
  /// </summary>
  public static TrackChangeType? GetInserted(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Inserted>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetInserted(ParagraphMarkRunProperties? openXmlElement, TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Inserted>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeTypeConverter.CreateOpenXmlElement<Inserted>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Deleted Paragraph.
  /// </summary>
  public static TrackChangeType? GetDeleted(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Deleted>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDeleted(ParagraphMarkRunProperties? openXmlElement, TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Deleted>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeTypeConverter.CreateOpenXmlElement<Deleted>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Move Source Paragraph.
  /// </summary>
  public static TrackChangeType? GetMoveFrom(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveFrom>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveFrom(ParagraphMarkRunProperties? openXmlElement, TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MoveFrom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeTypeConverter.CreateOpenXmlElement<MoveFrom>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Move Destination Paragraph.
  /// </summary>
  public static TrackChangeType? GetMoveTo(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveTo>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveTo(ParagraphMarkRunProperties? openXmlElement, TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MoveTo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeTypeConverter.CreateOpenXmlElement<MoveTo>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType2? GetConflictInsertion(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ConflictInsertion>();
    if (itemElement != null)
      return TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetConflictInsertion(ParagraphMarkRunProperties? openXmlElement, TrackChangeType2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ConflictInsertion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeType2Converter.CreateOpenXmlElement<ConflictInsertion>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType2? GetConflictDeletion(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ConflictDeletion>();
    if (itemElement != null)
      return TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetConflictDeletion(ParagraphMarkRunProperties? openXmlElement, TrackChangeType2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ConflictDeletion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeType2Converter.CreateOpenXmlElement<ConflictDeletion>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetRunStyle(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RunStyle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRunStyle(ParagraphMarkRunProperties? openXmlElement, String? value)
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

  public static RunFonts? GetRunFonts(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunFonts>();
    if (itemElement != null)
      return RunFontsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunFonts(ParagraphMarkRunProperties? openXmlElement, RunFonts? value)
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

  public static Boolean? GetBold(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Bold>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBold(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Boolean? GetBoldComplexScript(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BoldComplexScript>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBoldComplexScript(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Boolean? GetItalic(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Italic>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetItalic(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Boolean? GetItalicComplexScript(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ItalicComplexScript>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetItalicComplexScript(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Boolean? GetCaps(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Caps>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetCaps(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Boolean? GetSmallCaps(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SmallCaps>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSmallCaps(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Boolean? GetStrike(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Strike>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetStrike(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Boolean? GetDoubleStrike(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoubleStrike>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoubleStrike(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Boolean? GetOutline(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Outline>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetOutline(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Boolean? GetShadow(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Shadow>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShadow(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Boolean? GetEmboss(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Emboss>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetEmboss(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Boolean? GetImprint(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Imprint>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetImprint(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Boolean? GetNoProof(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoProof>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoProof(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Boolean? GetSnapToGrid(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SnapToGrid>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSnapToGrid(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Boolean? GetVanish(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Vanish>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetVanish(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Boolean? GetWebHidden(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WebHidden>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetWebHidden(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Color? GetColor(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Color>();
    if (itemElement != null)
      return ColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColor(ParagraphMarkRunProperties? openXmlElement, Color? value)
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

  public static Int32? GetSpacing(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Spacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSpacing(ParagraphMarkRunProperties? openXmlElement, Int32? value)
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

  public static Int64? GetCharacterScale(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CharacterScale>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetCharacterScale(ParagraphMarkRunProperties? openXmlElement, Int64? value)
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

  public static UInt32? GetKern(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Kern>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetKern(ParagraphMarkRunProperties? openXmlElement, UInt32? value)
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

  public static String? GetPosition(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Position>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPosition(ParagraphMarkRunProperties? openXmlElement, String? value)
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

  public static String? GetFontSize(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FontSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetFontSize(ParagraphMarkRunProperties? openXmlElement, String? value)
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

  public static String? GetFontSizeComplexScript(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FontSizeComplexScript>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetFontSizeComplexScript(ParagraphMarkRunProperties? openXmlElement, String? value)
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

  public static HighlightColorKind? GetHighlight(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Highlight>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<HighlightColorValues, HighlightColorKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetHighlight(ParagraphMarkRunProperties? openXmlElement, HighlightColorKind? value)
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

  public static Underline? GetUnderline(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Underline>();
    if (itemElement != null)
      return UnderlineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnderline(ParagraphMarkRunProperties? openXmlElement, Underline? value)
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

  public static TextEffectKind? GetTextEffect(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextEffect>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TextEffectValues, TextEffectKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTextEffect(ParagraphMarkRunProperties? openXmlElement, TextEffectKind? value)
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

  public static BorderType? GetBorder(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Border>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBorder(ParagraphMarkRunProperties? openXmlElement, BorderType? value)
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

  public static Shading? GetShading(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return ShadingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShading(ParagraphMarkRunProperties? openXmlElement, Shading? value)
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

  public static FitText? GetFitText(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FitText>();
    if (itemElement != null)
      return FitTextConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFitText(ParagraphMarkRunProperties? openXmlElement, FitText? value)
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

  public static VerticalPositionKind? GetVerticalTextAlignment(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VerticalTextAlignment>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<VerticalPositionValues, VerticalPositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetVerticalTextAlignment(ParagraphMarkRunProperties? openXmlElement, VerticalPositionKind? value)
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

  public static Boolean? GetRightToLeftText(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RightToLeftText>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetRightToLeftText(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Boolean? GetComplexScript(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ComplexScript>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetComplexScript(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static EmphasisMarkKind? GetEmphasis(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Emphasis>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<EmphasisMarkValues, EmphasisMarkKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetEmphasis(ParagraphMarkRunProperties? openXmlElement, EmphasisMarkKind? value)
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

  public static LanguageType? GetLanguages(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Languages>();
    if (itemElement != null)
      return LanguageTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLanguages(ParagraphMarkRunProperties? openXmlElement, LanguageType? value)
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

  public static EastAsianLayout? GetEastAsianLayout(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout>();
    if (itemElement != null)
      return EastAsianLayoutConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEastAsianLayout(ParagraphMarkRunProperties? openXmlElement, EastAsianLayout? value)
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

  public static Boolean? GetSpecVanish(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SpecVanish>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSpecVanish(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
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

  public static Glow? GetGlow(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Glow>();
    if (itemElement != null)
      return GlowConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGlow(ParagraphMarkRunProperties? openXmlElement, Glow? value)
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

  public static Reflection? GetReflection(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Reflection>();
    if (itemElement != null)
      return ReflectionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetReflection(ParagraphMarkRunProperties? openXmlElement, Reflection? value)
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

  public static TextOutlineEffect? GetTextOutlineEffect(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect>();
    if (itemElement != null)
      return TextOutlineEffectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextOutlineEffect(ParagraphMarkRunProperties? openXmlElement, TextOutlineEffect? value)
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

  public static FillTextEffect? GetFillTextEffect(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.FillTextEffect>();
    if (itemElement != null)
      return FillTextEffectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFillTextEffect(ParagraphMarkRunProperties? openXmlElement, FillTextEffect? value)
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

  public static Scene3D? GetScene3D(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Scene3D>();
    if (itemElement != null)
      return Scene3DConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetScene3D(ParagraphMarkRunProperties? openXmlElement, Scene3D? value)
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

  public static Properties3D? GetProperties3D(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Properties3D>();
    if (itemElement != null)
      return Properties3DConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetProperties3D(ParagraphMarkRunProperties? openXmlElement, Properties3D? value)
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

  public static LigaturesKind? GetLigatures(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Ligatures>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<LigaturesValues, LigaturesKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetLigatures(ParagraphMarkRunProperties? openXmlElement, LigaturesKind? value)
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

  public static NumberFormKind? GetNumberingFormat(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberingFormat>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<NumberFormValues, NumberFormKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetNumberingFormat(ParagraphMarkRunProperties? openXmlElement, NumberFormKind? value)
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

  public static NumberSpacingKind? GetNumberSpacing(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberSpacing>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<NumberSpacingValues, NumberSpacingKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetNumberSpacing(ParagraphMarkRunProperties? openXmlElement, NumberSpacingKind? value)
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

  public static StylisticSets? GetStylisticSets(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.StylisticSets>();
    if (itemElement != null)
      return StylisticSetsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStylisticSets(ParagraphMarkRunProperties? openXmlElement, StylisticSets? value)
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

  public static OnOffKind? GetContextualAlternatives(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ContextualAlternatives>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffValues, OnOffKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetContextualAlternatives(ParagraphMarkRunProperties? openXmlElement, OnOffKind? value)
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

  public static Boolean? GetOfficeMath(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<OfficeMath>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetOfficeMath(ParagraphMarkRunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<OfficeMath>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new OfficeMath();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ParagraphMarkRunPropertiesChange? GetParagraphMarkRunPropertiesChange(ParagraphMarkRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange>();
    if (itemElement != null)
      return ParagraphMarkRunPropertiesChangeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetParagraphMarkRunPropertiesChange(ParagraphMarkRunProperties? openXmlElement, ParagraphMarkRunPropertiesChange? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphMarkRunPropertiesChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.ParagraphMarkRunProperties? CreateModelElement(ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ParagraphMarkRunProperties();
      value.Inserted = GetInserted(openXmlElement);
      value.Deleted = GetDeleted(openXmlElement);
      value.MoveFrom = GetMoveFrom(openXmlElement);
      value.MoveTo = GetMoveTo(openXmlElement);
      value.ConflictInsertion = GetConflictInsertion(openXmlElement);
      value.ConflictDeletion = GetConflictDeletion(openXmlElement);
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
      value.OfficeMath = GetOfficeMath(openXmlElement);
      value.ParagraphMarkRunPropertiesChange = GetParagraphMarkRunPropertiesChange(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ParagraphMarkRunProperties? value)
    where OpenXmlElementType : ParagraphMarkRunProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetInserted(openXmlElement, value?.Inserted);
      SetDeleted(openXmlElement, value?.Deleted);
      SetMoveFrom(openXmlElement, value?.MoveFrom);
      SetMoveTo(openXmlElement, value?.MoveTo);
      SetConflictInsertion(openXmlElement, value?.ConflictInsertion);
      SetConflictDeletion(openXmlElement, value?.ConflictDeletion);
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
      SetOfficeMath(openXmlElement, value?.OfficeMath);
      SetParagraphMarkRunPropertiesChange(openXmlElement, value?.ParagraphMarkRunPropertiesChange);
      return openXmlElement;
    }
    return default;
  }
}