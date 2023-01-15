using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Office2013.Word;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.CustomXml;
using DocumentModel.Math;
using DocumentModel.OpenXml.CustomXml;
using DocumentModel.OpenXml.Math;
using DocumentModel.Wordprocessing;
using ActiveWritingStyle = DocumentModel.Wordprocessing.ActiveWritingStyle;
using Captions = DocumentModel.Wordprocessing.Captions;
using ColorSchemeMapping = DocumentModel.Wordprocessing.ColorSchemeMapping;
using Compatibility = DocumentModel.Wordprocessing.Compatibility;
using DocumentProtection = DocumentModel.Wordprocessing.DocumentProtection;
using DocumentVariables = DocumentModel.Wordprocessing.DocumentVariables;
using EndnoteDocumentWideProperties = DocumentModel.Wordprocessing.EndnoteDocumentWideProperties;
using FootnoteDocumentWideProperties = DocumentModel.Wordprocessing.FootnoteDocumentWideProperties;
using HeaderShapeDefaults = DocumentModel.Wordprocessing.HeaderShapeDefaults;
using LanguageType = DocumentModel.Wordprocessing.LanguageType;
using MailMerge = DocumentModel.Wordprocessing.MailMerge;
using NoLineBreaksAfterKinsoku = DocumentModel.Wordprocessing.NoLineBreaksAfterKinsoku;
using NoLineBreaksBeforeKinsoku = DocumentModel.Wordprocessing.NoLineBreaksBeforeKinsoku;
using ProofState = DocumentModel.Wordprocessing.ProofState;
using ReadModeInkLockDown = DocumentModel.Wordprocessing.ReadModeInkLockDown;
using RelationshipType = DocumentModel.Wordprocessing.RelationshipType;
using RevisionView = DocumentModel.Wordprocessing.RevisionView;
using Rsids = DocumentModel.Wordprocessing.Rsids;
using SaveThroughXslt = DocumentModel.Wordprocessing.SaveThroughXslt;
using Settings = DocumentFormat.OpenXml.Wordprocessing.Settings;
using ShapeDefaults = DocumentModel.Wordprocessing.ShapeDefaults;
using StylePaneFormatFilter = DocumentModel.Wordprocessing.StylePaneFormatFilter;
using WriteProtection = DocumentModel.Wordprocessing.WriteProtection;
using Zoom = DocumentModel.Wordprocessing.Zoom;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Document Settings.
/// </summary>
public static class SettingsConverter
{
  /// <summary>
  ///   Write Protection.
  /// </summary>
  public static WriteProtection? GetWriteProtection(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WriteProtection>();
    if (itemElement != null)
      return WriteProtectionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWriteProtection(Settings? openXmlElement, WriteProtection? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WriteProtection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WriteProtectionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.WriteProtection>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Document View Setting.
  /// </summary>
  public static ViewKind? GetView(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<View>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<ViewValues, ViewKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetView(Settings? openXmlElement, ViewKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<View>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<View, ViewValues, ViewKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Magnification Setting.
  /// </summary>
  public static Zoom? GetZoom(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Zoom>();
    if (itemElement != null)
      return ZoomConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetZoom(Settings? openXmlElement, Zoom? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Zoom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ZoomConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Zoom>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Remove Personal Information from Document Properties.
  /// </summary>
  public static Boolean? GetRemovePersonalInformation(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RemovePersonalInformation>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetRemovePersonalInformation(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<RemovePersonalInformation>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new RemovePersonalInformation();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Remove Date and Time from Annotations.
  /// </summary>
  public static Boolean? GetRemoveDateAndTime(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RemoveDateAndTime>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetRemoveDateAndTime(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<RemoveDateAndTime>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new RemoveDateAndTime();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Display Visual Boundary For Header/Footer or Between Pages.
  /// </summary>
  public static Boolean? GetDoNotDisplayPageBoundaries(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotDisplayPageBoundaries>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotDisplayPageBoundaries(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotDisplayPageBoundaries>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotDisplayPageBoundaries();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Display Background Objects When Displaying Document.
  /// </summary>
  public static Boolean? GetDisplayBackgroundShape(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DisplayBackgroundShape>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDisplayBackgroundShape(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DisplayBackgroundShape>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DisplayBackgroundShape();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Print PostScript Codes With Document Text.
  /// </summary>
  public static Boolean? GetPrintPostScriptOverText(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PrintPostScriptOverText>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetPrintPostScriptOverText(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<PrintPostScriptOverText>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new PrintPostScriptOverText();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Print Fractional Character Widths.
  /// </summary>
  public static Boolean? GetPrintFractionalCharacterWidth(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PrintFractionalCharacterWidth>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetPrintFractionalCharacterWidth(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<PrintFractionalCharacterWidth>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new PrintFractionalCharacterWidth();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Only Print Form Field Content.
  /// </summary>
  public static Boolean? GetPrintFormsData(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PrintFormsData>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetPrintFormsData(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<PrintFormsData>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new PrintFormsData();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Embed TrueType Fonts.
  /// </summary>
  public static Boolean? GetEmbedTrueTypeFonts(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EmbedTrueTypeFonts>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetEmbedTrueTypeFonts(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<EmbedTrueTypeFonts>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new EmbedTrueTypeFonts();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Embed Common System Fonts.
  /// </summary>
  public static Boolean? GetEmbedSystemFonts(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EmbedSystemFonts>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetEmbedSystemFonts(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<EmbedSystemFonts>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new EmbedSystemFonts();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Subset Fonts When Embedding.
  /// </summary>
  public static Boolean? GetSaveSubsetFonts(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SaveSubsetFonts>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSaveSubsetFonts(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SaveSubsetFonts>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SaveSubsetFonts();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Only Save Form Field Content.
  /// </summary>
  public static Boolean? GetSaveFormsData(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SaveFormsData>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSaveFormsData(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SaveFormsData>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SaveFormsData();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Mirror Page Margins.
  /// </summary>
  public static Boolean? GetMirrorMargins(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MirrorMargins>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetMirrorMargins(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<MirrorMargins>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new MirrorMargins();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Align Paragraph and Table Borders with Page Border.
  /// </summary>
  public static Boolean? GetAlignBorderAndEdges(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AlignBorderAndEdges>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAlignBorderAndEdges(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AlignBorderAndEdges>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AlignBorderAndEdges();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Page Border Excludes Header.
  /// </summary>
  public static Boolean? GetBordersDoNotSurroundHeader(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BordersDoNotSurroundHeader>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBordersDoNotSurroundHeader(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<BordersDoNotSurroundHeader>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new BordersDoNotSurroundHeader();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Page Border Excludes Footer.
  /// </summary>
  public static Boolean? GetBordersDoNotSurroundFooter(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BordersDoNotSurroundFooter>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBordersDoNotSurroundFooter(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<BordersDoNotSurroundFooter>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new BordersDoNotSurroundFooter();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Position Gutter At Top of Page.
  /// </summary>
  public static Boolean? GetGutterAtTop(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<GutterAtTop>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetGutterAtTop(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<GutterAtTop>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new GutterAtTop();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Display Visual Indication of Spelling Errors.
  /// </summary>
  public static Boolean? GetHideSpellingErrors(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HideSpellingErrors>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetHideSpellingErrors(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<HideSpellingErrors>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new HideSpellingErrors();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Display Visual Indication of Grammatical Errors.
  /// </summary>
  public static Boolean? GetHideGrammaticalErrors(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HideGrammaticalErrors>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetHideGrammaticalErrors(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<HideGrammaticalErrors>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new HideGrammaticalErrors();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<ActiveWritingStyle>? GetActiveWritingStyles(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ActiveWritingStyle>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle>())
      {
        var newItem = ActiveWritingStyleConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetActiveWritingStyles(Settings? openXmlElement, Collection<ActiveWritingStyle>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ActiveWritingStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static ProofState? GetProofState(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofState>();
    if (itemElement != null)
      return ProofStateConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetProofState(Settings? openXmlElement, ProofState? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofState>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ProofStateConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ProofState>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetFormsDesign(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FormsDesign>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetFormsDesign(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<FormsDesign>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new FormsDesign();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RelationshipType? GetAttachedTemplate(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AttachedTemplate>();
    if (itemElement != null)
      return RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAttachedTemplate(Settings? openXmlElement, RelationshipType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AttachedTemplate>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelationshipTypeConverter.CreateOpenXmlElement<AttachedTemplate>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetLinkStyles(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LinkStyles>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetLinkStyles(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<LinkStyles>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new LinkStyles();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static StylePaneFormatFilter? GetStylePaneFormatFilter(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter>();
    if (itemElement != null)
      return StylePaneFormatFilterConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStylePaneFormatFilter(Settings? openXmlElement, StylePaneFormatFilter? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StylePaneFormatFilterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetStylePaneSortMethods(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<StylePaneSortMethods>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetStylePaneSortMethods(Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StylePaneSortMethods>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new StylePaneSortMethods { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentKind? GetDocumentType(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentType>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<DocumentTypeValues, DocumentKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetDocumentType(Settings? openXmlElement, DocumentKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentType, DocumentTypeValues, DocumentKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MailMerge? GetMailMerge(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMerge>();
    if (itemElement != null)
      return MailMergeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMailMerge(Settings? openXmlElement, MailMerge? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMerge>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MailMergeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MailMerge>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RevisionView? GetRevisionView(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RevisionView>();
    if (itemElement != null)
      return RevisionViewConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRevisionView(Settings? openXmlElement, RevisionView? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RevisionView>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RevisionViewConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RevisionView>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetTrackRevisions(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TrackRevisions>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetTrackRevisions(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<TrackRevisions>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new TrackRevisions();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetDoNotTrackMoves(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotTrackMoves>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotTrackMoves(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotTrackMoves>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotTrackMoves();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetDoNotTrackFormatting(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotTrackFormatting>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotTrackFormatting(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotTrackFormatting>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotTrackFormatting();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentProtection? GetDocumentProtection(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentProtection>();
    if (itemElement != null)
      return DocumentProtectionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDocumentProtection(Settings? openXmlElement, DocumentProtection? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentProtection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentProtectionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocumentProtection>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetAutoFormatOverride(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AutoFormatOverride>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAutoFormatOverride(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AutoFormatOverride>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AutoFormatOverride();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int16? GetDefaultTabStop(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DefaultTabStop>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDefaultTabStop(Settings? openXmlElement, Int16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DefaultTabStop>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DefaultTabStop { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetAutoHyphenation(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AutoHyphenation>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAutoHyphenation(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AutoHyphenation>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AutoHyphenation();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UInt16? GetConsecutiveHyphenLimit(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ConsecutiveHyphenLimit>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetConsecutiveHyphenLimit(Settings? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ConsecutiveHyphenLimit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new ConsecutiveHyphenLimit { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetHyphenationZone(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<HyphenationZone>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetHyphenationZone(Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HyphenationZone>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new HyphenationZone { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetDoNotHyphenateCaps(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotHyphenateCaps>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotHyphenateCaps(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotHyphenateCaps>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotHyphenateCaps();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowEnvelope(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowEnvelope>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowEnvelope(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowEnvelope>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowEnvelope();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetSummaryLength(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SummaryLength>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSummaryLength(Settings? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SummaryLength>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new SummaryLength { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetClickAndTypeStyle(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ClickAndTypeStyle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetClickAndTypeStyle(Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ClickAndTypeStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new ClickAndTypeStyle { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetDefaultTableStyle(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DefaultTableStyle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDefaultTableStyle(Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DefaultTableStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DefaultTableStyle { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetEvenAndOddHeaders(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EvenAndOddHeaders>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetEvenAndOddHeaders(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<EvenAndOddHeaders>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new EvenAndOddHeaders();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetBookFoldReversePrinting(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BookFoldReversePrinting>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBookFoldReversePrinting(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<BookFoldReversePrinting>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new BookFoldReversePrinting();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetBookFoldPrinting(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BookFoldPrinting>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBookFoldPrinting(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<BookFoldPrinting>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new BookFoldPrinting();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int16? GetBookFoldPrintingSheets(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BookFoldPrintingSheets>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetBookFoldPrintingSheets(Settings? openXmlElement, Int16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BookFoldPrintingSheets>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new BookFoldPrintingSheets { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetDrawingGridHorizontalSpacing(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DrawingGridHorizontalSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDrawingGridHorizontalSpacing(Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DrawingGridHorizontalSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DrawingGridHorizontalSpacing { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetDrawingGridVerticalSpacing(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DrawingGridVerticalSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDrawingGridVerticalSpacing(Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DrawingGridVerticalSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DrawingGridVerticalSpacing { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetDisplayHorizontalDrawingGrid(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DisplayHorizontalDrawingGrid>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDisplayHorizontalDrawingGrid(Settings? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DisplayHorizontalDrawingGrid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DisplayHorizontalDrawingGrid { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetDisplayVerticalDrawingGrid(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DisplayVerticalDrawingGrid>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDisplayVerticalDrawingGrid(Settings? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DisplayVerticalDrawingGrid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DisplayVerticalDrawingGrid { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetDoNotUseMarginsForDrawingGridOrigin(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotUseMarginsForDrawingGridOrigin>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotUseMarginsForDrawingGridOrigin(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotUseMarginsForDrawingGridOrigin>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotUseMarginsForDrawingGridOrigin();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetDrawingGridHorizontalOrigin(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DrawingGridHorizontalOrigin>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDrawingGridHorizontalOrigin(Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DrawingGridHorizontalOrigin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DrawingGridHorizontalOrigin { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetDrawingGridVerticalOrigin(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DrawingGridVerticalOrigin>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDrawingGridVerticalOrigin(Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DrawingGridVerticalOrigin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DrawingGridVerticalOrigin { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetDoNotShadeFormData(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotShadeFormData>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotShadeFormData(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotShadeFormData>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotShadeFormData();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetNoPunctuationKerning(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoPunctuationKerning>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoPunctuationKerning(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<NoPunctuationKerning>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new NoPunctuationKerning();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static CharacterSpacingKind? GetCharacterSpacingControl(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CharacterSpacingControl>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<CharacterSpacingValues, CharacterSpacingKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetCharacterSpacingControl(Settings? openXmlElement, CharacterSpacingKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CharacterSpacingControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<CharacterSpacingControl, CharacterSpacingValues, CharacterSpacingKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetPrintTwoOnOne(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PrintTwoOnOne>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetPrintTwoOnOne(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<PrintTwoOnOne>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new PrintTwoOnOne();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetStrictFirstAndLastChars(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StrictFirstAndLastChars>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetStrictFirstAndLastChars(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<StrictFirstAndLastChars>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new StrictFirstAndLastChars();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static NoLineBreaksAfterKinsoku? GetNoLineBreaksAfterKinsoku(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku>();
    if (itemElement != null)
      return NoLineBreaksAfterKinsokuConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNoLineBreaksAfterKinsoku(Settings? openXmlElement, NoLineBreaksAfterKinsoku? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoLineBreaksAfterKinsokuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static NoLineBreaksBeforeKinsoku? GetNoLineBreaksBeforeKinsoku(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksBeforeKinsoku>();
    if (itemElement != null)
      return NoLineBreaksBeforeKinsokuConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNoLineBreaksBeforeKinsoku(Settings? openXmlElement, NoLineBreaksBeforeKinsoku? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksBeforeKinsoku>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoLineBreaksBeforeKinsokuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksBeforeKinsoku>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetSavePreviewPicture(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SavePreviewPicture>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSavePreviewPicture(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SavePreviewPicture>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SavePreviewPicture();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetDoNotValidateAgainstSchema(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotValidateAgainstSchema>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotValidateAgainstSchema(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotValidateAgainstSchema>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotValidateAgainstSchema();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetSaveInvalidXml(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SaveInvalidXml>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSaveInvalidXml(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SaveInvalidXml>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SaveInvalidXml();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetIgnoreMixedContent(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<IgnoreMixedContent>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetIgnoreMixedContent(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<IgnoreMixedContent>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new IgnoreMixedContent();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetAlwaysShowPlaceholderText(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AlwaysShowPlaceholderText>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAlwaysShowPlaceholderText(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AlwaysShowPlaceholderText>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AlwaysShowPlaceholderText();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetDoNotDemarcateInvalidXml(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotDemarcateInvalidXml>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotDemarcateInvalidXml(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotDemarcateInvalidXml>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotDemarcateInvalidXml();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetSaveXmlDataOnly(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SaveXmlDataOnly>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSaveXmlDataOnly(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SaveXmlDataOnly>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SaveXmlDataOnly();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetUseXsltWhenSaving(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UseXsltWhenSaving>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUseXsltWhenSaving(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<UseXsltWhenSaving>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new UseXsltWhenSaving();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SaveThroughXslt? GetSaveThroughXslt(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt>();
    if (itemElement != null)
      return SaveThroughXsltConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSaveThroughXslt(Settings? openXmlElement, SaveThroughXslt? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SaveThroughXsltConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowXmlTags(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowXmlTags>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowXmlTags(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowXmlTags>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowXmlTags();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetAlwaysMergeEmptyNamespace(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AlwaysMergeEmptyNamespace>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAlwaysMergeEmptyNamespace(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AlwaysMergeEmptyNamespace>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AlwaysMergeEmptyNamespace();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetUpdateFieldsOnOpen(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UpdateFieldsOnOpen>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUpdateFieldsOnOpen(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<UpdateFieldsOnOpen>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new UpdateFieldsOnOpen();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static HeaderShapeDefaults? GetHeaderShapeDefaults(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults>();
    if (itemElement != null)
      return HeaderShapeDefaultsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHeaderShapeDefaults(Settings? openXmlElement, HeaderShapeDefaults? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HeaderShapeDefaultsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static FootnoteDocumentWideProperties? GetFootnoteDocumentWideProperties(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties>();
    if (itemElement != null)
      return FootnoteDocumentWidePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFootnoteDocumentWideProperties(Settings? openXmlElement, FootnoteDocumentWideProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FootnoteDocumentWidePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static EndnoteDocumentWideProperties? GetEndnoteDocumentWideProperties(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties>();
    if (itemElement != null)
      return EndnoteDocumentWidePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEndnoteDocumentWideProperties(Settings? openXmlElement, EndnoteDocumentWideProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EndnoteDocumentWidePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Compatibility? GetCompatibility(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Compatibility>();
    if (itemElement != null)
      return CompatibilityConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCompatibility(Settings? openXmlElement, Compatibility? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Compatibility>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CompatibilityConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Compatibility>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentVariables? GetDocumentVariables(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentVariables>();
    if (itemElement != null)
      return DocumentVariablesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDocumentVariables(Settings? openXmlElement, DocumentVariables? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentVariables>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentVariablesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocumentVariables>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Rsids? GetRsids(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Rsids>();
    if (itemElement != null)
      return RsidsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRsids(Settings? openXmlElement, Rsids? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Rsids>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RsidsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Rsids>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MathProperties? GetMathProperties(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.MathProperties>();
    if (itemElement != null)
      return MathPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMathProperties(Settings? openXmlElement, MathProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MathProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MathPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.MathProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetUICompatibleWith97To2003(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UICompatibleWith97To2003>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUICompatibleWith97To2003(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<UICompatibleWith97To2003>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new UICompatibleWith97To2003();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<String>? GetAttachedSchemas(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<String>();
      foreach (var item in openXmlElement.Elements<AttachedSchema>())
      {
        var newItem = StringValueConverter.GetValue(item);
        if (newItem != null)
          collection.Add((string)newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetAttachedSchemas(Settings? openXmlElement, Collection<String>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<AttachedSchema>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = StringValueConverter.CreateOpenXmlElement<AttachedSchema>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static LanguageType? GetThemeFontLanguages(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ThemeFontLanguages>();
    if (itemElement != null)
      return LanguageTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetThemeFontLanguages(Settings? openXmlElement, LanguageType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ThemeFontLanguages>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LanguageTypeConverter.CreateOpenXmlElement<ThemeFontLanguages>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ColorSchemeMapping? GetColorSchemeMapping(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping>();
    if (itemElement != null)
      return ColorSchemeMappingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorSchemeMapping(Settings? openXmlElement, ColorSchemeMapping? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorSchemeMappingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetDoNotIncludeSubdocsInStats(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotIncludeSubdocsInStats>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotIncludeSubdocsInStats(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotIncludeSubdocsInStats>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotIncludeSubdocsInStats();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetDoNotAutoCompressPictures(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotAutoCompressPictures>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotAutoCompressPictures(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotAutoCompressPictures>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotAutoCompressPictures();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetForceUpgrade(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ForceUpgrade>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetForceUpgrade(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ForceUpgrade>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ForceUpgrade();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Captions? GetCaptions(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Captions>();
    if (itemElement != null)
      return CaptionsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCaptions(Settings? openXmlElement, Captions? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Captions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CaptionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Captions>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ReadModeInkLockDown? GetReadModeInkLockDown(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown>();
    if (itemElement != null)
      return ReadModeInkLockDownConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetReadModeInkLockDown(Settings? openXmlElement, ReadModeInkLockDown? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ReadModeInkLockDownConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SchemaLibrary? GetSchemaLibrary(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary>();
    if (itemElement != null)
      return SchemaLibraryConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSchemaLibrary(Settings? openXmlElement, SchemaLibrary? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SchemaLibraryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ShapeDefaults? GetShapeDefaults(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults>();
    if (itemElement != null)
      return ShapeDefaultsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeDefaults(Settings? openXmlElement, ShapeDefaults? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeDefaultsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetDecimalSymbol(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DecimalSymbol>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDecimalSymbol(Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DecimalSymbol>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DecimalSymbol { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetListSeparator(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ListSeparator>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetListSeparator(Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ListSeparator>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new ListSeparator { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Byte[]? GetDocumentId(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentId>();
    if (itemElement != null)
      return ByteArrayConverter.GetValue(itemElement);
    return null;
  }

  public static void SetDocumentId(Settings? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ByteArrayConverter.CreateOpenXmlElement<DocumentId>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static OnOffKind? GetDiscardImageEditingData(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DiscardImageEditingData>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffValues, OnOffKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetDiscardImageEditingData(Settings? openXmlElement, OnOffKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DiscardImageEditingData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DiscardImageEditingData, OnOffValues, OnOffKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetDefaultImageDpi(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DefaultImageDpi>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDefaultImageDpi(Settings? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DefaultImageDpi>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DefaultImageDpi { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static OnOffKind? GetConflictMode(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ConflictMode>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffValues, OnOffKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetConflictMode(Settings? openXmlElement, OnOffKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ConflictMode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<ConflictMode, OnOffValues, OnOffKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetChartTrackingRefBased(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ChartTrackingRefBased>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetChartTrackingRefBased(Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ChartTrackingRefBased>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ChartTrackingRefBased();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetPersistentDocumentId(Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PersistentDocumentId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPersistentDocumentId(Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PersistentDocumentId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PersistentDocumentId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Settings? CreateModelElement(Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Settings();
      value.WriteProtection = GetWriteProtection(openXmlElement);
      value.View = GetView(openXmlElement);
      value.Zoom = GetZoom(openXmlElement);
      value.RemovePersonalInformation = GetRemovePersonalInformation(openXmlElement);
      value.RemoveDateAndTime = GetRemoveDateAndTime(openXmlElement);
      value.DoNotDisplayPageBoundaries = GetDoNotDisplayPageBoundaries(openXmlElement);
      value.DisplayBackgroundShape = GetDisplayBackgroundShape(openXmlElement);
      value.PrintPostScriptOverText = GetPrintPostScriptOverText(openXmlElement);
      value.PrintFractionalCharacterWidth = GetPrintFractionalCharacterWidth(openXmlElement);
      value.PrintFormsData = GetPrintFormsData(openXmlElement);
      value.EmbedTrueTypeFonts = GetEmbedTrueTypeFonts(openXmlElement);
      value.EmbedSystemFonts = GetEmbedSystemFonts(openXmlElement);
      value.SaveSubsetFonts = GetSaveSubsetFonts(openXmlElement);
      value.SaveFormsData = GetSaveFormsData(openXmlElement);
      value.MirrorMargins = GetMirrorMargins(openXmlElement);
      value.AlignBorderAndEdges = GetAlignBorderAndEdges(openXmlElement);
      value.BordersDoNotSurroundHeader = GetBordersDoNotSurroundHeader(openXmlElement);
      value.BordersDoNotSurroundFooter = GetBordersDoNotSurroundFooter(openXmlElement);
      value.GutterAtTop = GetGutterAtTop(openXmlElement);
      value.HideSpellingErrors = GetHideSpellingErrors(openXmlElement);
      value.HideGrammaticalErrors = GetHideGrammaticalErrors(openXmlElement);
      value.ActiveWritingStyles = GetActiveWritingStyles(openXmlElement);
      value.ProofState = GetProofState(openXmlElement);
      value.FormsDesign = GetFormsDesign(openXmlElement);
      value.AttachedTemplate = GetAttachedTemplate(openXmlElement);
      value.LinkStyles = GetLinkStyles(openXmlElement);
      value.StylePaneFormatFilter = GetStylePaneFormatFilter(openXmlElement);
      value.StylePaneSortMethods = GetStylePaneSortMethods(openXmlElement);
      value.DocumentType = GetDocumentType(openXmlElement);
      value.MailMerge = GetMailMerge(openXmlElement);
      value.RevisionView = GetRevisionView(openXmlElement);
      value.TrackRevisions = GetTrackRevisions(openXmlElement);
      value.DoNotTrackMoves = GetDoNotTrackMoves(openXmlElement);
      value.DoNotTrackFormatting = GetDoNotTrackFormatting(openXmlElement);
      value.DocumentProtection = GetDocumentProtection(openXmlElement);
      value.AutoFormatOverride = GetAutoFormatOverride(openXmlElement);
      value.DefaultTabStop = GetDefaultTabStop(openXmlElement);
      value.AutoHyphenation = GetAutoHyphenation(openXmlElement);
      value.ConsecutiveHyphenLimit = GetConsecutiveHyphenLimit(openXmlElement);
      value.HyphenationZone = GetHyphenationZone(openXmlElement);
      value.DoNotHyphenateCaps = GetDoNotHyphenateCaps(openXmlElement);
      value.ShowEnvelope = GetShowEnvelope(openXmlElement);
      value.SummaryLength = GetSummaryLength(openXmlElement);
      value.ClickAndTypeStyle = GetClickAndTypeStyle(openXmlElement);
      value.DefaultTableStyle = GetDefaultTableStyle(openXmlElement);
      value.EvenAndOddHeaders = GetEvenAndOddHeaders(openXmlElement);
      value.BookFoldReversePrinting = GetBookFoldReversePrinting(openXmlElement);
      value.BookFoldPrinting = GetBookFoldPrinting(openXmlElement);
      value.BookFoldPrintingSheets = GetBookFoldPrintingSheets(openXmlElement);
      value.DrawingGridHorizontalSpacing = GetDrawingGridHorizontalSpacing(openXmlElement);
      value.DrawingGridVerticalSpacing = GetDrawingGridVerticalSpacing(openXmlElement);
      value.DisplayHorizontalDrawingGrid = GetDisplayHorizontalDrawingGrid(openXmlElement);
      value.DisplayVerticalDrawingGrid = GetDisplayVerticalDrawingGrid(openXmlElement);
      value.DoNotUseMarginsForDrawingGridOrigin = GetDoNotUseMarginsForDrawingGridOrigin(openXmlElement);
      value.DrawingGridHorizontalOrigin = GetDrawingGridHorizontalOrigin(openXmlElement);
      value.DrawingGridVerticalOrigin = GetDrawingGridVerticalOrigin(openXmlElement);
      value.DoNotShadeFormData = GetDoNotShadeFormData(openXmlElement);
      value.NoPunctuationKerning = GetNoPunctuationKerning(openXmlElement);
      value.CharacterSpacingControl = GetCharacterSpacingControl(openXmlElement);
      value.PrintTwoOnOne = GetPrintTwoOnOne(openXmlElement);
      value.StrictFirstAndLastChars = GetStrictFirstAndLastChars(openXmlElement);
      value.NoLineBreaksAfterKinsoku = GetNoLineBreaksAfterKinsoku(openXmlElement);
      value.NoLineBreaksBeforeKinsoku = GetNoLineBreaksBeforeKinsoku(openXmlElement);
      value.SavePreviewPicture = GetSavePreviewPicture(openXmlElement);
      value.DoNotValidateAgainstSchema = GetDoNotValidateAgainstSchema(openXmlElement);
      value.SaveInvalidXml = GetSaveInvalidXml(openXmlElement);
      value.IgnoreMixedContent = GetIgnoreMixedContent(openXmlElement);
      value.AlwaysShowPlaceholderText = GetAlwaysShowPlaceholderText(openXmlElement);
      value.DoNotDemarcateInvalidXml = GetDoNotDemarcateInvalidXml(openXmlElement);
      value.SaveXmlDataOnly = GetSaveXmlDataOnly(openXmlElement);
      value.UseXsltWhenSaving = GetUseXsltWhenSaving(openXmlElement);
      value.SaveThroughXslt = GetSaveThroughXslt(openXmlElement);
      value.ShowXmlTags = GetShowXmlTags(openXmlElement);
      value.AlwaysMergeEmptyNamespace = GetAlwaysMergeEmptyNamespace(openXmlElement);
      value.UpdateFieldsOnOpen = GetUpdateFieldsOnOpen(openXmlElement);
      value.HeaderShapeDefaults = GetHeaderShapeDefaults(openXmlElement);
      value.FootnoteDocumentWideProperties = GetFootnoteDocumentWideProperties(openXmlElement);
      value.EndnoteDocumentWideProperties = GetEndnoteDocumentWideProperties(openXmlElement);
      value.Compatibility = GetCompatibility(openXmlElement);
      value.DocumentVariables = GetDocumentVariables(openXmlElement);
      value.Rsids = GetRsids(openXmlElement);
      value.MathProperties = GetMathProperties(openXmlElement);
      value.UICompatibleWith97To2003 = GetUICompatibleWith97To2003(openXmlElement);
      value.AttachedSchemas = GetAttachedSchemas(openXmlElement);
      value.ThemeFontLanguages = GetThemeFontLanguages(openXmlElement);
      value.ColorSchemeMapping = GetColorSchemeMapping(openXmlElement);
      value.DoNotIncludeSubdocsInStats = GetDoNotIncludeSubdocsInStats(openXmlElement);
      value.DoNotAutoCompressPictures = GetDoNotAutoCompressPictures(openXmlElement);
      value.ForceUpgrade = GetForceUpgrade(openXmlElement);
      value.Captions = GetCaptions(openXmlElement);
      value.ReadModeInkLockDown = GetReadModeInkLockDown(openXmlElement);
      value.SchemaLibrary = GetSchemaLibrary(openXmlElement);
      value.ShapeDefaults = GetShapeDefaults(openXmlElement);
      value.DecimalSymbol = GetDecimalSymbol(openXmlElement);
      value.ListSeparator = GetListSeparator(openXmlElement);
      value.DocumentId = GetDocumentId(openXmlElement);
      value.DiscardImageEditingData = GetDiscardImageEditingData(openXmlElement);
      value.DefaultImageDpi = GetDefaultImageDpi(openXmlElement);
      value.ConflictMode = GetConflictMode(openXmlElement);
      value.ChartTrackingRefBased = GetChartTrackingRefBased(openXmlElement);
      value.PersistentDocumentId = GetPersistentDocumentId(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Settings? value)
    where OpenXmlElementType : Settings, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWriteProtection(openXmlElement, value?.WriteProtection);
      SetView(openXmlElement, value?.View);
      SetZoom(openXmlElement, value?.Zoom);
      SetRemovePersonalInformation(openXmlElement, value?.RemovePersonalInformation);
      SetRemoveDateAndTime(openXmlElement, value?.RemoveDateAndTime);
      SetDoNotDisplayPageBoundaries(openXmlElement, value?.DoNotDisplayPageBoundaries);
      SetDisplayBackgroundShape(openXmlElement, value?.DisplayBackgroundShape);
      SetPrintPostScriptOverText(openXmlElement, value?.PrintPostScriptOverText);
      SetPrintFractionalCharacterWidth(openXmlElement, value?.PrintFractionalCharacterWidth);
      SetPrintFormsData(openXmlElement, value?.PrintFormsData);
      SetEmbedTrueTypeFonts(openXmlElement, value?.EmbedTrueTypeFonts);
      SetEmbedSystemFonts(openXmlElement, value?.EmbedSystemFonts);
      SetSaveSubsetFonts(openXmlElement, value?.SaveSubsetFonts);
      SetSaveFormsData(openXmlElement, value?.SaveFormsData);
      SetMirrorMargins(openXmlElement, value?.MirrorMargins);
      SetAlignBorderAndEdges(openXmlElement, value?.AlignBorderAndEdges);
      SetBordersDoNotSurroundHeader(openXmlElement, value?.BordersDoNotSurroundHeader);
      SetBordersDoNotSurroundFooter(openXmlElement, value?.BordersDoNotSurroundFooter);
      SetGutterAtTop(openXmlElement, value?.GutterAtTop);
      SetHideSpellingErrors(openXmlElement, value?.HideSpellingErrors);
      SetHideGrammaticalErrors(openXmlElement, value?.HideGrammaticalErrors);
      SetActiveWritingStyles(openXmlElement, value?.ActiveWritingStyles);
      SetProofState(openXmlElement, value?.ProofState);
      SetFormsDesign(openXmlElement, value?.FormsDesign);
      SetAttachedTemplate(openXmlElement, value?.AttachedTemplate);
      SetLinkStyles(openXmlElement, value?.LinkStyles);
      SetStylePaneFormatFilter(openXmlElement, value?.StylePaneFormatFilter);
      SetStylePaneSortMethods(openXmlElement, value?.StylePaneSortMethods);
      SetDocumentType(openXmlElement, value?.DocumentType);
      SetMailMerge(openXmlElement, value?.MailMerge);
      SetRevisionView(openXmlElement, value?.RevisionView);
      SetTrackRevisions(openXmlElement, value?.TrackRevisions);
      SetDoNotTrackMoves(openXmlElement, value?.DoNotTrackMoves);
      SetDoNotTrackFormatting(openXmlElement, value?.DoNotTrackFormatting);
      SetDocumentProtection(openXmlElement, value?.DocumentProtection);
      SetAutoFormatOverride(openXmlElement, value?.AutoFormatOverride);
      SetDefaultTabStop(openXmlElement, value?.DefaultTabStop);
      SetAutoHyphenation(openXmlElement, value?.AutoHyphenation);
      SetConsecutiveHyphenLimit(openXmlElement, value?.ConsecutiveHyphenLimit);
      SetHyphenationZone(openXmlElement, value?.HyphenationZone);
      SetDoNotHyphenateCaps(openXmlElement, value?.DoNotHyphenateCaps);
      SetShowEnvelope(openXmlElement, value?.ShowEnvelope);
      SetSummaryLength(openXmlElement, value?.SummaryLength);
      SetClickAndTypeStyle(openXmlElement, value?.ClickAndTypeStyle);
      SetDefaultTableStyle(openXmlElement, value?.DefaultTableStyle);
      SetEvenAndOddHeaders(openXmlElement, value?.EvenAndOddHeaders);
      SetBookFoldReversePrinting(openXmlElement, value?.BookFoldReversePrinting);
      SetBookFoldPrinting(openXmlElement, value?.BookFoldPrinting);
      SetBookFoldPrintingSheets(openXmlElement, value?.BookFoldPrintingSheets);
      SetDrawingGridHorizontalSpacing(openXmlElement, value?.DrawingGridHorizontalSpacing);
      SetDrawingGridVerticalSpacing(openXmlElement, value?.DrawingGridVerticalSpacing);
      SetDisplayHorizontalDrawingGrid(openXmlElement, value?.DisplayHorizontalDrawingGrid);
      SetDisplayVerticalDrawingGrid(openXmlElement, value?.DisplayVerticalDrawingGrid);
      SetDoNotUseMarginsForDrawingGridOrigin(openXmlElement, value?.DoNotUseMarginsForDrawingGridOrigin);
      SetDrawingGridHorizontalOrigin(openXmlElement, value?.DrawingGridHorizontalOrigin);
      SetDrawingGridVerticalOrigin(openXmlElement, value?.DrawingGridVerticalOrigin);
      SetDoNotShadeFormData(openXmlElement, value?.DoNotShadeFormData);
      SetNoPunctuationKerning(openXmlElement, value?.NoPunctuationKerning);
      SetCharacterSpacingControl(openXmlElement, value?.CharacterSpacingControl);
      SetPrintTwoOnOne(openXmlElement, value?.PrintTwoOnOne);
      SetStrictFirstAndLastChars(openXmlElement, value?.StrictFirstAndLastChars);
      SetNoLineBreaksAfterKinsoku(openXmlElement, value?.NoLineBreaksAfterKinsoku);
      SetNoLineBreaksBeforeKinsoku(openXmlElement, value?.NoLineBreaksBeforeKinsoku);
      SetSavePreviewPicture(openXmlElement, value?.SavePreviewPicture);
      SetDoNotValidateAgainstSchema(openXmlElement, value?.DoNotValidateAgainstSchema);
      SetSaveInvalidXml(openXmlElement, value?.SaveInvalidXml);
      SetIgnoreMixedContent(openXmlElement, value?.IgnoreMixedContent);
      SetAlwaysShowPlaceholderText(openXmlElement, value?.AlwaysShowPlaceholderText);
      SetDoNotDemarcateInvalidXml(openXmlElement, value?.DoNotDemarcateInvalidXml);
      SetSaveXmlDataOnly(openXmlElement, value?.SaveXmlDataOnly);
      SetUseXsltWhenSaving(openXmlElement, value?.UseXsltWhenSaving);
      SetSaveThroughXslt(openXmlElement, value?.SaveThroughXslt);
      SetShowXmlTags(openXmlElement, value?.ShowXmlTags);
      SetAlwaysMergeEmptyNamespace(openXmlElement, value?.AlwaysMergeEmptyNamespace);
      SetUpdateFieldsOnOpen(openXmlElement, value?.UpdateFieldsOnOpen);
      SetHeaderShapeDefaults(openXmlElement, value?.HeaderShapeDefaults);
      SetFootnoteDocumentWideProperties(openXmlElement, value?.FootnoteDocumentWideProperties);
      SetEndnoteDocumentWideProperties(openXmlElement, value?.EndnoteDocumentWideProperties);
      SetCompatibility(openXmlElement, value?.Compatibility);
      SetDocumentVariables(openXmlElement, value?.DocumentVariables);
      SetRsids(openXmlElement, value?.Rsids);
      SetMathProperties(openXmlElement, value?.MathProperties);
      SetUICompatibleWith97To2003(openXmlElement, value?.UICompatibleWith97To2003);
      SetAttachedSchemas(openXmlElement, value?.AttachedSchemas);
      SetThemeFontLanguages(openXmlElement, value?.ThemeFontLanguages);
      SetColorSchemeMapping(openXmlElement, value?.ColorSchemeMapping);
      SetDoNotIncludeSubdocsInStats(openXmlElement, value?.DoNotIncludeSubdocsInStats);
      SetDoNotAutoCompressPictures(openXmlElement, value?.DoNotAutoCompressPictures);
      SetForceUpgrade(openXmlElement, value?.ForceUpgrade);
      SetCaptions(openXmlElement, value?.Captions);
      SetReadModeInkLockDown(openXmlElement, value?.ReadModeInkLockDown);
      SetSchemaLibrary(openXmlElement, value?.SchemaLibrary);
      SetShapeDefaults(openXmlElement, value?.ShapeDefaults);
      SetDecimalSymbol(openXmlElement, value?.DecimalSymbol);
      SetListSeparator(openXmlElement, value?.ListSeparator);
      SetDocumentId(openXmlElement, value?.DocumentId);
      SetDiscardImageEditingData(openXmlElement, value?.DiscardImageEditingData);
      SetDefaultImageDpi(openXmlElement, value?.DefaultImageDpi);
      SetConflictMode(openXmlElement, value?.ConflictMode);
      SetChartTrackingRefBased(openXmlElement, value?.ChartTrackingRefBased);
      SetPersistentDocumentId(openXmlElement, value?.PersistentDocumentId);
      return openXmlElement;
    }
    return default;
  }
}