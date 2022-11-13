using Qhta.OpenXMLTools;

using CX = DocumentFormat.OpenXml.CustomXmlSchemaReferences;
using DM = DocxDocument.Model;
using OM = DocumentFormat.OpenXml.Math;
using OO = DocumentFormat.OpenXml;
using WD = DocumentFormat.OpenXml.Wordprocessing;

namespace DocxDocument.Reader;

public partial class DocxReader
{
  public DM.DocumentSettings? ReadDocumentSettings()
  {
    return ReadDocumentSettings(Parts.AllDocumentSettings);
  }

  public DM.DocumentSettings? ReadDocumentSettings(Parts parts)
  {
    if (parts.HasFlag(Parts.DocumentSettings))
      return ReadDocumentSettings(WordprocessingDocument.MainDocumentPart?.DocumentSettingsPart?.Settings);
    return null;
  }

  private DM.DocumentSettings? ReadDocumentSettings(WD.Settings? wdSettings)
  {
    if (wdSettings is not null)
    {
      return new DM.DocumentSettings(wdSettings);
      //DM.DocumentSettings dmDocumentSettings = new DM.DocumentSettings();

      //#region Automation settings
      //dmDocumentSettings.DoNotIncludeSubdocsInStats = ReadBoolean(wdSettings.GetDoNotIncludeSubdocsInStats());
      //dmDocumentSettings.SavePreviewPicture = ReadBoolean(wdSettings.GetSavePreviewPicture());
      //dmDocumentSettings.SummaryLength = ReadPercentage(wdSettings.GetSummaryLength()?.Val);
      //#endregion

      //#region Change Tracking settings
      //dmDocumentSettings.TrackRevisions = ReadBoolean(wdSettings.GetTrackRevisions());
      //dmDocumentSettings.DoNotTrackFormatting = ReadBoolean(wdSettings.GetDoNotTrackFormatting());
      //dmDocumentSettings.DoNotTrackMoves = ReadBoolean(wdSettings.GetDoNotTrackMoves());
      //dmDocumentSettings.RevisionView = ReadEnum<DM.RevisionView>(wdSettings.GetRevisionView());
      //#endregion

      //#region Character Spacing settings
      //dmDocumentSettings.CharacterSpacingControl = ReadEnum<DM.CharacterSpacing>(wdSettings.GetCharacterSpacingControl());
      //dmDocumentSettings.NoPunctuationKerning = ReadBoolean(wdSettings.GetNoPunctuationKerning());

      //#endregion

      //#region Compatibility settings
      //dmDocumentSettings.Compatibility = ReadCompatibility(wdSettings.GetCompatibility());
      //dmDocumentSettings.ForceUpgrade = ReadBoolean(wdSettings.GetForceUpgrade());
      //#endregion

      //#region Custom XML settings
      //dmDocumentSettings.AlwaysMergeEmptyNamespace = ReadBoolean(wdSettings.GetAlwaysMergeEmptyNamespace());
      //dmDocumentSettings.AlwaysShowPlaceholderText = ReadBoolean(wdSettings.GetAlwaysShowPlaceholderText());
      //dmDocumentSettings.ShowXmlTags = ReadBoolean(wdSettings.GetShowXmlTags());
      //dmDocumentSettings.DoNotDemarcateInvalidXml = ReadBoolean(wdSettings.GetDoNotDemarcateInvalidXml());
      //dmDocumentSettings.DoNotValidateAgainstSchema = ReadBoolean(wdSettings.GetDoNotValidateAgainstSchema());
      //dmDocumentSettings.IgnoreMixedContent = ReadBoolean(wdSettings.GetIgnoreMixedContent());
      //dmDocumentSettings.SaveInvalidXml = ReadBoolean(wdSettings.GetSaveInvalidXml());
      //dmDocumentSettings.SaveXmlDataOnly = ReadBoolean(wdSettings.GetSaveXmlDataOnly());
      //dmDocumentSettings.UseXsltWhenSaving = ReadBoolean(wdSettings.GetUseXsltWhenSaving());
      //var saveThroughXslt = wdSettings.GetSaveThroughXslt();
      //if (saveThroughXslt is not null)
      //{
      //  dmDocumentSettings.SaveThroughXslt = ReadString(saveThroughXslt);
      //  if (saveThroughXslt.SolutionId is not null)
      //    dmDocumentSettings.SolutionId = ReadString(saveThroughXslt.SolutionId);
      //}
      //dmDocumentSettings.AttachedSchema = ReadString(wdSettings.GetAttachedSchema());
      //dmDocumentSettings.SchemaLibrary = ReadSchemaLibrary(wdSettings.GetSchemaLibrary());
      //#endregion

      //#region DisplayGrid settings
      //dmDocumentSettings.DrawingGridHorizontalOrigin = ReadTwips(wdSettings.GetDrawingGridHorizontalOrigin());
      //dmDocumentSettings.DrawingGridHorizontalSpacing = ReadTwips(wdSettings.GetDrawingGridHorizontalSpacing());
      //dmDocumentSettings.DrawingGridVerticalOrigin = ReadTwips(wdSettings.GetDrawingGridVerticalOrigin());
      //dmDocumentSettings.DrawingGridVerticalSpacing = ReadTwips(wdSettings.GetDrawingGridVerticalSpacing());
      //dmDocumentSettings.DisplayHorizontalDrawingGrid = ReadInteger(wdSettings.GetDisplayHorizontalDrawingGrid());
      //dmDocumentSettings.DisplayVerticalDrawingGrid = ReadInteger(wdSettings.GetDisplayVerticalDrawingGrid());
      //dmDocumentSettings.DoNotUseMarginsForDrawingGridOrigin = ReadBoolean(wdSettings.GetDoNotUseMarginsForDrawingGridOrigin());
      //#endregion

      //#region Mailing settings
      //dmDocumentSettings.DocumentType = ReadEnum<DM.MailingType>(wdSettings.GetDocumentType());
      //dmDocumentSettings.ShowEnvelope = ReadBoolean(wdSettings.GetShowEnvelope());
      //dmDocumentSettings.MailMerge = ReadEnumMailMergeSettings(wdSettings.GetMailMerge());
      //#endregion

      //#region Field evaluation
      //dmDocumentSettings.DecimalSymbol = ReadString(wdSettings.GetDecimalSymbol());
      //dmDocumentSettings.ListSeparator = ReadString(wdSettings.GetListSeparator());
      //dmDocumentSettings.UpdateFields = ReadBoolean(wdSettings.GetUpdateFieldsOnOpen());
      //#endregion

      //#region Forms settings
      //dmDocumentSettings.DoNotShadeFormData = ReadBoolean(wdSettings.GetDoNotShadeFormData());
      //dmDocumentSettings.SaveFormsData = ReadBoolean(wdSettings.GetSaveFormsData());
      //dmDocumentSettings.FormsDesign = ReadBoolean(wdSettings.GetFormsDesign());
      //#endregion

      //#region Embed Fonts settings
      //dmDocumentSettings.SaveSubsetFonts = ReadBoolean(wdSettings.GetSaveSubsetFonts());
      //dmDocumentSettings.EmbedSystemFonts = ReadBoolean(wdSettings.GetEmbedSystemFonts());
      //dmDocumentSettings.EmbedTrueTypeFonts = ReadBoolean(wdSettings.GetEmbedTrueTypeFonts());
      //#endregion

      //#region Images settings
      //dmDocumentSettings.DoNotAutoCompressPictures = ReadBoolean(wdSettings.GetDoNotAutoCompressPictures());
      //dmDocumentSettings.DefaultImageDpi = ReadInteger(wdSettings.GetDefaultImageDpi()?.Val);
      //dmDocumentSettings.DiscardImageEditingData = ReadBoolean(wdSettings.GetDiscardImageEditingData());
      //#endregion

      //#region Hyphenation settings
      //dmDocumentSettings.AutoHyphenation = ReadBoolean(wdSettings.GetAutoHyphenation());
      //dmDocumentSettings.DoNotHyphenateCaps = ReadBoolean(wdSettings.GetDoNotHyphenateCaps());
      //dmDocumentSettings.ConsecutiveHyphenLimit = ReadEnum<int>(wdSettings.GetConsecutiveHyphenLimit());
      //#endregion

      //#region Kinsoku line breaking settings
      //dmDocumentSettings.StrictFirstAndLastChars = ReadBoolean(wdSettings.GetStrictFirstAndLastChars());
      //dmDocumentSettings.NoLineBreaksAfter = ReadKinsokuText(wdSettings.GetNoLineBreaksAfterKinsoku());
      //dmDocumentSettings.NoLineBreaksBefore = ReadKinsokuText(wdSettings.GetNoLineBreaksBeforeKinsoku());
      //#endregion

      //#region Layout settings
      //dmDocumentSettings.MirrorMargins = ReadBoolean(wdSettings.GetMirrorMargins());
      //dmDocumentSettings.EvenAndOddHeaders = ReadBoolean(wdSettings.GetEvenAndOddHeaders());
      //dmDocumentSettings.BordersDoNotSurroundFooter = ReadBoolean(wdSettings.GetBordersDoNotSurroundFooter());
      //dmDocumentSettings.BordersDoNotSurroundHeader = ReadBoolean(wdSettings.GetBordersDoNotSurroundHeader());
      //dmDocumentSettings.AlignBorderAndEdges = ReadBoolean(wdSettings.GetAlignBorderAndEdges());
      //dmDocumentSettings.DisplayBackgroundShape = ReadBoolean(wdSettings.GetDisplayBackgroundShape());
      //dmDocumentSettings.GutterAtTop = ReadBoolean(wdSettings.GetGutterAtTop());
      //dmDocumentSettings.DefaultTabStop = ReadTwips(wdSettings.GetDefaultTabStop());
      //dmDocumentSettings.ReadModeInkLockDown = ReadReadModeInkLockDown(wdSettings.GetReadModeInkLockDown());
      //#endregion

      //#region Printing settings
      //dmDocumentSettings.PrintFormsData = ReadBoolean(wdSettings.GetPrintFormsData());
      //dmDocumentSettings.PrintFractionalCharacterWidth = ReadBoolean(wdSettings.GetPrintFractionalCharacterWidth());
      //dmDocumentSettings.PrintPostScriptOverText = ReadBoolean(wdSettings.GetPrintPostScriptOverText());
      //dmDocumentSettings.PrintTwoOnOne = ReadBoolean(wdSettings.GetPrintTwoOnOne());
      //dmDocumentSettings.BookFoldPrinting = ReadBoolean(wdSettings.GetBookFoldPrinting());
      //dmDocumentSettings.GetBookFoldReversePrinting = ReadBoolean(wdSettings.GetBookFoldReversePrinting());
      //dmDocumentSettings.BookFoldPrintingSheets = ReadInteger(wdSettings.GetBookFoldPrintingSheets()?.Val);
      //#endregion

      //#region Proofing settings
      //dmDocumentSettings.ActiveWritingStyle = ReadWritingStyle(wdSettings.GetActiveWritingStyle());
      //dmDocumentSettings.HideGrammaticalErrors = ReadBoolean(wdSettings.GetHideGrammaticalErrors());
      //dmDocumentSettings.HideSpellingErrors = ReadBoolean(wdSettings.GetHideSpellingErrors());
      //dmDocumentSettings.ProofState = ReadProofState(wdSettings.GetProofState());
      //#endregion

      //#region Document Protection settings
      //dmDocumentSettings.DocumentProtection = ReadDocumentProtection(wdSettings.GetDocumentProtection());
      //dmDocumentSettings.WriteProtection = ReadWriteProtection(wdSettings.GetWriteProtection());
      //dmDocumentSettings.RemoveDateAndTime = ReadBoolean(wdSettings.GetRemoveDateAndTime());
      //dmDocumentSettings.RemovePersonalInformation = ReadBoolean(wdSettings.GetRemovePersonalInformation());
      //dmDocumentSettings.AutoFormatOverride = ReadBoolean(wdSettings.GetAutoFormatOverride());
      //#endregion

      //#region Style and Theme settings
      //dmDocumentSettings.GetStyleLockStylesPart = ReadBoolean(wdSettings.GetStyleLockStylesPart());
      //dmDocumentSettings.StyleLockThemesPart = ReadBoolean(wdSettings.GetStyleLockThemesPart());
      //dmDocumentSettings.ClickAndTypeStyle = ReadString(wdSettings.GetClickAndTypeStyle());
      //dmDocumentSettings.DefaultTableStyle = ReadString(wdSettings.GetDefaultTableStyle());
      //dmDocumentSettings.LinkStyles = ReadBoolean(wdSettings.GetLinkStyles());
      //dmDocumentSettings.AttachedTemplate = ReadString(wdSettings.GetAttachedTemplate());
      //dmDocumentSettings.ColorSchemeMapping = ReadColorSchemeMapping(wdSettings.GetColorSchemeMapping());
      //dmDocumentSettings.ThemeFontLanguages = ReadThemeFontLang(wdSettings.GetThemeFontLanguages());
      //dmDocumentSettings.StylePaneFormatFilter = ReadStylePaneFormatFilter(wdSettings.GetStylePaneFormatFilter());
      //dmDocumentSettings.StylePaneSortMethods = ReadStylePaneSortMethods(wdSettings.GetStylePaneSortMethods());
      //#endregion

      //#region Document View settings
      //dmDocumentSettings.DoNotDisplayPageBoundaries = ReadBoolean(wdSettings.GetDoNotDisplayPageBoundaries());
      //dmDocumentSettings.View = ReadEnum<DM.DocView>(wdSettings.GetView());
      //dmDocumentSettings.Zoom = ReadZoom(wdSettings.GetZoom());
      //#endregion

      //#region Other settings
      ////dmDocumentSettings.Captions = ReadCaptions(wdSettings.GetCaptions());
      //dmDocumentSettings.DocumentVariables = ReadDocumentVariables(wdSettings.GetDocumentVariables());
      //dmDocumentSettings.EndnoteDocumentWideProperties = ReadEndnoteDocumentWideProperties(wdSettings.GetEndnoteDocumentWideProperties());
      //dmDocumentSettings.FootnoteDocumentWideProperties = ReadFootnoteDocumentWideProperties(wdSettings.GetFootnoteDocumentWideProperties());
      //dmDocumentSettings.MathProperties = ReadMathProperties(wdSettings.GetMathProperties());
      //#endregion

      //return dmDocumentSettings;
    }
    return null;
  }

  public static DM.MathProperties? ReadMathProperties(OM.MathProperties docMathProperties)
  {
    if (docMathProperties is not null)
    {
      var dmMathPropeties = new DM.MathProperties();
      dmMathPropeties.BreakBinary = ReadEnum<DM.BreakBinaryOperator,OM.BreakBinaryOperatorValues>(docMathProperties.BreakBinary?.Val);
      dmMathPropeties.BreakBinarySubtraction = ReadEnum<DM.BreakBinarySubstraction, OM.BreakBinarySubtractionValues>(docMathProperties.BreakBinarySubtraction?.Val);
      dmMathPropeties.DefaultJustification = ReadEnum<DM.MathJustification, OM.JustificationValues>(docMathProperties.DefaultJustification?.Val);
      dmMathPropeties.DisplayDefaults = ReadBoolean(docMathProperties.DisplayDefaults);
      dmMathPropeties.InterSpacing = ReadTwips(docMathProperties.InterSpacing);
      dmMathPropeties.IntraSpacing = ReadTwips(docMathProperties.IntraSpacing);
      dmMathPropeties.LeftMargin = ReadTwips(docMathProperties.LeftMargin);
      dmMathPropeties.MathFont = ReadString(docMathProperties.MathFont?.Val);
      dmMathPropeties.PostSpacing = ReadTwips(docMathProperties.PostSpacing);
      dmMathPropeties.PreSpacing = ReadTwips(docMathProperties.PreSpacing);
      dmMathPropeties.RightMargin = ReadTwips(docMathProperties.RightMargin);
      dmMathPropeties.SmallFraction = ReadBoolean(docMathProperties.SmallFraction);
      dmMathPropeties.WrapIndent = ReadTwips(docMathProperties.Elements<OM.WrapIndent>().FirstOrDefault());
      dmMathPropeties.WrapRight = ReadBoolean(docMathProperties.Elements<OM.WrapRight>().FirstOrDefault());
      dmMathPropeties.IntegralLimitLocation = ReadEnum<DM.LimitLocation, OM.LimitLocationValues>(docMathProperties.Elements<OM.IntegralLimitLocation>().FirstOrDefault()?.Val);
      dmMathPropeties.NaryLimitLocation = ReadEnum<DM.LimitLocation, OM.LimitLocationValues>(docMathProperties.Elements<OM.NaryLimitLocation>().FirstOrDefault()?.Val);
      return dmMathPropeties;
    }
    return default;
  }

  public static DM.LangText? ReadKinsokuText(OO.OpenXmlLeafElement? element)
  {
    if (element is WD.NoLineBreaksAfterKinsoku w1)
    {
      return new DM.LangText { Lang = w1.Language, Text = w1.Val };
    }
    if (element is WD.NoLineBreaksBeforeKinsoku w2)
    {
      return new DM.LangText { Lang = w2.Language, Text = w2.Val };
    }
    return null;
  }

  public static DM.FootnoteProperties? ReadFootnoteDocumentWideProperties(WD.FootnoteDocumentWideProperties docFootnoteProperties)
  {
    if (docFootnoteProperties is not null)
    {
      var dmFootnoteProperties = new DM.FootnoteProperties();
      dmFootnoteProperties.FootnotePosition = ReadEnum<DM.FootnotePosition>(docFootnoteProperties.FootnotePosition);
      dmFootnoteProperties.NumberingFormat = ReadEnum<DM.NumberingFormat>(docFootnoteProperties.NumberingFormat);
      dmFootnoteProperties.NumberingRestart = ReadEnum<DM.RestartNumber>(docFootnoteProperties.NumberingRestart);
      dmFootnoteProperties.NumberingStart = ReadInteger(docFootnoteProperties.NumberingStart?.Val);
      return dmFootnoteProperties;
    }
    return default;
  }

  public static DM.EndnoteProperties? ReadEndnoteDocumentWideProperties(WD.EndnoteDocumentWideProperties docEndnoteProperties)
  {
    if (docEndnoteProperties is not null)
    {
      var dmEndnoteProperties = new DM.EndnoteProperties();
      dmEndnoteProperties.EndnotePosition = ReadEnum<DM.EndnotePosition>(docEndnoteProperties.EndnotePosition);
      dmEndnoteProperties.NumberingFormat = ReadEnum<DM.NumberingFormat>(docEndnoteProperties.NumberingFormat);
      dmEndnoteProperties.NumberingRestart = ReadEnum<DM.RestartNumber>(docEndnoteProperties.NumberingRestart);
      dmEndnoteProperties.NumberingStart = ReadInteger(docEndnoteProperties.NumberingStart?.Val);
      return dmEndnoteProperties;
    }
    return default;
  }

  public static DM.DocumentVariables? ReadDocumentVariables(WD.DocumentVariables? docDocumentVariables)
  {
    if (docDocumentVariables is not null)
    {
      var dmDocumentVariables = new DM.DocumentVariables();
      foreach (var docDocumentVariable in docDocumentVariables.OfType<WD.DocumentVariable>())
      {
        var dmDocumentVariable = ReadDocumentVariable(docDocumentVariable);
        if (dmDocumentVariable is not null)
          dmDocumentVariables.Add(dmDocumentVariable);
      }
      return dmDocumentVariables;
    }
    return default;
  }

  public static DM.DocumentVariable? ReadDocumentVariable(WD.DocumentVariable? docDocumentVariable)
  {
    if (docDocumentVariable is not null)
    {
      string? name = docDocumentVariable.Name;
      if (name is not null)
        return new DM.DocumentVariable{ Name = name, Value = docDocumentVariable.Val?.Value };
    }
    return default;
  }

  //public static DM.Captions? ReadCaptions(WD.Captions? wdCaptions)
  //{
  //  if (wdCaptions is not null)
  //  {
  //    var dmCaptions = new DM.Captions();
  //    foreach (var wdCaption in wdCaptions.OfType<WD.Caption>())
  //    {
  //      var dmCaption = ReadCaption(wdCaption);
  //      if (dmCaption is not null)
  //        dmCaptions.Add(dmCaption);
  //    }
  //    return dmCaptions;
  //  }
  //  return default;
  //}

  //public static DM.Caption? ReadCaption(WD.Caption? docCaption)
  //{
  //  if (docCaption is not null)
  //  {
  //    var dmCaption = new DM.Caption();
  //    dmCaption.ChapterNumber = ReadBoolean(docCaption.ChapterNumber);
  //    dmCaption.Heading = ReadInteger(docCaption.Heading);
  //    dmCaption.Name = ReadString(docCaption.Name);
  //    dmCaption.NoLabel = ReadBoolean(docCaption.NoLabel);
  //    dmCaption.NumberFormat = ReadEnum<DM.NumberFormat, WD.NumberFormatValues>(docCaption.NumberFormat);
  //    dmCaption.Position = ReadEnum<DM.CaptionPosition, WD.CaptionPositionValues>(docCaption.Position);
  //    dmCaption.Separator = ReadEnum<DM.ChapterSeparator, WD.ChapterSeparatorValues>(docCaption.Separator);
  //    return dmCaption;
  //  }
  //  return default;
  //}

  public static DM.StylePaneSortMethods? ReadStylePaneSortMethods(WD.StylePaneSortMethods docStylePaneSortMethods)
  {
    if (docStylePaneSortMethods is not null)
    {
      if (docStylePaneSortMethods.Val is not null)
      {
        if (int.TryParse(docStylePaneSortMethods.Val, NumberStyles.HexNumber, null, out var val))
          return (DM.StylePaneSortMethods)(int)val;
        if (Enum.TryParse<WD.StylePaneSortMethodsValues>(docStylePaneSortMethods.Val, true, out var wVal))
          return (DM.StylePaneSortMethods)(int)wVal;
      }
    }
    return default;
  }

  public static DM.StylePaneFormatFilter? ReadStylePaneFormatFilter(WD.StylePaneFormatFilter docStylePaneFormatFilter)
  {
    if (docStylePaneFormatFilter is not null)
    {
      if (docStylePaneFormatFilter.Val is not null)
      {
        var val = ReadHexBinary(docStylePaneFormatFilter.Val);
        if (val != null)
          return (DM.StylePaneFormatFilter)(int)val;
      }
      if (ReadBoolean(docStylePaneFormatFilter.AllStyles) == true)
        return DM.StylePaneFormatFilter.AllStyles;
      var dmStylePaneFormatFilter = default(DM.StylePaneFormatFilter);
      if (ReadBoolean(docStylePaneFormatFilter.AlternateStyleNames) == true)
        dmStylePaneFormatFilter |= DM.StylePaneFormatFilter.AlternateStyleNames;
      if (ReadBoolean(docStylePaneFormatFilter.CustomStyles) == true)
        dmStylePaneFormatFilter |= DM.StylePaneFormatFilter.CustomStyles;
      if (ReadBoolean(docStylePaneFormatFilter.DirectFormattingOnNumbering) == true)
        dmStylePaneFormatFilter |= DM.StylePaneFormatFilter.DirectFormattingOnNumbering;
      if (ReadBoolean(docStylePaneFormatFilter.DirectFormattingOnParagraphs) == true)
        dmStylePaneFormatFilter |= DM.StylePaneFormatFilter.DirectFormattingOnParagraphs;
      if (ReadBoolean(docStylePaneFormatFilter.DirectFormattingOnRuns) == true)
        dmStylePaneFormatFilter |= DM.StylePaneFormatFilter.DirectFormattingOnRuns;
      if (ReadBoolean(docStylePaneFormatFilter.DirectFormattingOnTables) == true)
        dmStylePaneFormatFilter |= DM.StylePaneFormatFilter.DirectFormattingOnTables;
      if (ReadBoolean(docStylePaneFormatFilter.HeadingStyles) == true)
        dmStylePaneFormatFilter |= DM.StylePaneFormatFilter.HeadingStyles;
      if (ReadBoolean(docStylePaneFormatFilter.LatentStyles) == true)
        dmStylePaneFormatFilter |= DM.StylePaneFormatFilter.LatentStyles;
      if (ReadBoolean(docStylePaneFormatFilter.NumberingStyles) == true)
        dmStylePaneFormatFilter |= DM.StylePaneFormatFilter.NumberingStyles;
      if (ReadBoolean(docStylePaneFormatFilter.StylesInUse) == true)
        dmStylePaneFormatFilter |= DM.StylePaneFormatFilter.StylesInUse;
      if (ReadBoolean(docStylePaneFormatFilter.TableStyles) == true)
        dmStylePaneFormatFilter |= DM.StylePaneFormatFilter.TableStyles;
      if (ReadBoolean(docStylePaneFormatFilter.Top3HeadingStyles) == true)
        dmStylePaneFormatFilter |= DM.StylePaneFormatFilter.Top3HeadingStyles;
      if (ReadBoolean(docStylePaneFormatFilter.VisibleStyles) == true)
        dmStylePaneFormatFilter |= DM.StylePaneFormatFilter.VisibleStyles;
      return dmStylePaneFormatFilter;
    }
    return default;
  }

  public static DM.ScriptTypeLanguage? ReadThemeFontLang(WD.LanguageType? docLanguageType)
  {
    if (docLanguageType is not null)
    {
      var dmLanguageType = new DM.ScriptTypeLanguage();
      dmLanguageType.Default = docLanguageType.Val;
      dmLanguageType.Bidi = docLanguageType.Bidi;
      dmLanguageType.EastAsia = docLanguageType.EastAsia;
      return dmLanguageType;
    }
    return default;
  }

  public static DM.Zoom? ReadZoom(WD.Zoom? docZoom)
  {
    if (docZoom is not null)
    {
      var dmZoom = new DM.Zoom();
      dmZoom.Percent = ReadPercentage(docZoom.Percent);
      dmZoom.Preset = ReadEnum<DM.PresetZoom, WD.PresetZoomValues>(docZoom.Val);
      return dmZoom;
    }
    return default;
  }

  //public static DM.ColorSchemeMapping? ReadColorSchemeMapping(WD.ColorSchemeMapping? wdColorSchemeMapping)
  //{
  //  if (wdColorSchemeMapping is not null)
  //  {
  //    return new DM.ColorSchemeMapping(wdColorSchemeMapping);
  //    var dm = new DM.ColorSchemeMapping();
  //    dm.Accent1 = ReadEnum<DM.ThemeColorIndex, WD.ColorSchemeIndexValues>(wdColorSchemeMapping.Accent1);
  //    dm.Accent2 = ReadEnum<DM.ThemeColorIndex, WD.ColorSchemeIndexValues>(wdColorSchemeMapping.Accent2);
  //    dm.Accent3 = ReadEnum<DM.ThemeColorIndex, WD.ColorSchemeIndexValues>(wdColorSchemeMapping.Accent3);
  //    dm.Accent4 = ReadEnum<DM.ThemeColorIndex, WD.ColorSchemeIndexValues>(wdColorSchemeMapping.Accent4);
  //    dm.Accent5 = ReadEnum<DM.ThemeColorIndex, WD.ColorSchemeIndexValues>(wdColorSchemeMapping.Accent5);
  //    dm.Accent6 = ReadEnum<DM.ThemeColorIndex, WD.ColorSchemeIndexValues>(wdColorSchemeMapping.Accent6);
  //    dm.Background1 = ReadEnum<DM.ThemeColorIndex, WD.ColorSchemeIndexValues>(wdColorSchemeMapping.Background1);
  //    dm.Background2 = ReadEnum<DM.ThemeColorIndex, WD.ColorSchemeIndexValues>(wdColorSchemeMapping.Background2);
  //    dm.Text1 = ReadEnum<DM.ThemeColorIndex, WD.ColorSchemeIndexValues>(wdColorSchemeMapping.Text1);
  //    dm.Text2 = ReadEnum<DM.ThemeColorIndex, WD.ColorSchemeIndexValues>(wdColorSchemeMapping.Text2);
  //    dm.Hyperlink = ReadEnum<DM.ThemeColorIndex, WD.ColorSchemeIndexValues>(wdColorSchemeMapping.Hyperlink);
  //    dm.FollowedHyperlink = ReadEnum<DM.ThemeColorIndex, WD.ColorSchemeIndexValues>(wdColorSchemeMapping.FollowedHyperlink);
  //    return dm;
  //  }
  //  return default;
  //}

  public static DM.WritingStyle? ReadWritingStyle(WD.ActiveWritingStyle? docWritingStyle)
  {
    if (docWritingStyle is not null)
    {
      var dmWritingStyle = new DM.WritingStyle();
      dmWritingStyle.ApplicationName = ReadString(docWritingStyle.ApplicationName);
      dmWritingStyle.CheckStyle = ReadBoolean(docWritingStyle.CheckStyle);
      dmWritingStyle.DllVersion = ReadInteger(docWritingStyle.DllVersion);
      dmWritingStyle.Language = ReadString(docWritingStyle.Language);
      dmWritingStyle.NaturalLanguageGrammarCheck = ReadBoolean(docWritingStyle.NaturalLanguageGrammarCheck);
      dmWritingStyle.VendorID = ReadInteger(docWritingStyle.VendorID);
      return dmWritingStyle;
    }
    return default;
  }

  public static DM.ReadModeInkLockDown? ReadReadModeInkLockDown(WD.ReadModeInkLockDown? docReadModeInkLockDown)
  {
    if (docReadModeInkLockDown is not null)
    {
      var dmReadModeInkLockDown = new DM.ReadModeInkLockDown();
      dmReadModeInkLockDown.FontSize = ReadPercentage(docReadModeInkLockDown.FontSize);
      dmReadModeInkLockDown.UseActualPages = ReadBoolean(docReadModeInkLockDown.UseActualPages);
      dmReadModeInkLockDown.Width = ReadInteger(docReadModeInkLockDown.Width);
      dmReadModeInkLockDown.Height = ReadInteger(docReadModeInkLockDown.Height);
      return dmReadModeInkLockDown;
    }
    return default;
  }

  public static DM.MailMergeSettings? ReadEnumMailMergeSettings(WD.MailMerge docMailMerge)
  {
    if (docMailMerge is not null)
    {
      var dmMailMergeSettings = new DM.MailMergeSettings();
      dmMailMergeSettings.ActiveRecord = ReadInteger(docMailMerge.ActiveRecord);
      dmMailMergeSettings.AddressFieldName = ReadString(docMailMerge.AddressFieldName);
      dmMailMergeSettings.CheckErrors = ReadInteger(docMailMerge.CheckErrors);
      dmMailMergeSettings.ConnectString = ReadString(docMailMerge.ConnectString);
      dmMailMergeSettings.DataSourceObject = ReadDataSourceObject(docMailMerge.DataSourceObject);
      dmMailMergeSettings.DataType = ReadEnum<DM.MailMergeDataType>(docMailMerge.DataType);
      dmMailMergeSettings.Destination = ReadEnum<DM.MailMergeDestinationType>(docMailMerge.Destination);
      dmMailMergeSettings.DoNotSuppressBlankLines = ReadBoolean(docMailMerge.DoNotSuppressBlankLines);
      dmMailMergeSettings.LinkToQuery = ReadBoolean(docMailMerge.LinkToQuery);
      dmMailMergeSettings.MailAsAttachment = ReadBoolean(docMailMerge.MailAsAttachment);
      dmMailMergeSettings.MailSubject = ReadString(docMailMerge.MailSubject);
      dmMailMergeSettings.MainDocumentType = ReadEnum<DM.MailMergeDocumentType>(docMailMerge.MainDocumentType);
      dmMailMergeSettings.Query = ReadString(docMailMerge.Query);
      dmMailMergeSettings.ViewMergedData = ReadBoolean(docMailMerge.ViewMergedData);
      dmMailMergeSettings.HeaderSource = ReadRelationship(docMailMerge.HeaderSource);
      dmMailMergeSettings.DataSourceReference = ReadRelationship(docMailMerge.DataSourceReference);
      return dmMailMergeSettings;
    }
    return default;
  }

  public static DM.DataSourceObject? ReadDataSourceObject(WD.DataSourceObject? docDataSourceObject)
  {
    if (docDataSourceObject is not null)
    {
      var dmDataSourceObject = new DM.DataSourceObject();
      dmDataSourceObject.ColumnDelimiter = ReadInteger(docDataSourceObject.ColumnDelimiter);
      dmDataSourceObject.DataSourceTableName = ReadString(docDataSourceObject.DataSourceTableName);
      dmDataSourceObject.FirstRowHeader = ReadBoolean(docDataSourceObject.FirstRowHeader);
      dmDataSourceObject.MailMergeSource = ReadEnum<DM.MailMergeSourceType>(docDataSourceObject.MailMergeSource);
      dmDataSourceObject.SourceReference = ReadRelationship(docDataSourceObject.SourceReference);
      dmDataSourceObject.UdlConnectionString = ReadString(docDataSourceObject.UdlConnectionString);
      return dmDataSourceObject;
    }
    return default;
  }

  public static DM.SchemaLibrary? ReadSchemaLibrary(CX.SchemaLibrary docSchemaLibrary)
  {
    if (docSchemaLibrary is not null)
    {
      var dmSchemaLibrary = new DM.SchemaLibrary();
      foreach (var docSchema in docSchemaLibrary.OfType<DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema>())
      {
        var dmSchema = new DM.Schema();
        dmSchema.SchemaLocation = docSchema.SchemaLocation;
        dmSchema.ManifestLocation = docSchema.ManifestLocation;
        dmSchema.Uri = docSchema.Uri;
        dmSchemaLibrary.Add(dmSchema);
      }
      return dmSchemaLibrary;
    }
    return default;
  }

  public static DM.CompatibilitySettings? ReadCompatibility(WD.Compatibility? wdCompatibility)
  {
    if (wdCompatibility is not null)
    {
      var dmCompatibility = new DM.CompatibilitySettings();
      dmCompatibility.AdjustLineHeightInTable = ReadBoolean(wdCompatibility.AdjustLineHeightInTable);
      dmCompatibility.AlignTablesRowByRow = ReadBoolean(wdCompatibility.AlignTablesRowByRow);
      dmCompatibility.AllowSpaceOfSameStyleInTable = ReadBoolean(wdCompatibility.AllowSpaceOfSameStyleInTable);
      dmCompatibility.ApplyBreakingRules = ReadBoolean(wdCompatibility.ApplyBreakingRules);
      dmCompatibility.AutofitToFirstFixedWidthCell = ReadBoolean(wdCompatibility.AutofitToFirstFixedWidthCell);
      dmCompatibility.AutoSpaceLikeWord95 = ReadBoolean(wdCompatibility.AutoSpaceLikeWord95);
      dmCompatibility.BalanceSingleByteDoubleByteWidth = ReadBoolean(wdCompatibility.BalanceSingleByteDoubleByteWidth);
      dmCompatibility.CachedColumnBalance = ReadBoolean(wdCompatibility.CachedColumnBalance);
      dmCompatibility.ConvertMailMergeEscape = ReadBoolean(wdCompatibility.ConvertMailMergeEscape);
      dmCompatibility.DisplayHangulFixedWidth = ReadBoolean(wdCompatibility.DisplayHangulFixedWidth);
      dmCompatibility.DoNotAutofitConstrainedTables = ReadBoolean(wdCompatibility.DoNotAutofitConstrainedTables);
      dmCompatibility.DoNotBreakConstrainedForcedTable = ReadBoolean(wdCompatibility.DoNotBreakConstrainedForcedTable);
      dmCompatibility.DoNotBreakWrappedTables = ReadBoolean(wdCompatibility.DoNotBreakWrappedTables);
      dmCompatibility.DoNotExpandShiftReturn = ReadBoolean(wdCompatibility.DoNotExpandShiftReturn);
      dmCompatibility.DoNotLeaveBackslashAlone = ReadBoolean(wdCompatibility.DoNotLeaveBackslashAlone);
      dmCompatibility.DoNotSnapToGridInCell = ReadBoolean(wdCompatibility.DoNotSnapToGridInCell);
      dmCompatibility.DoNotSuppressIndentation = ReadBoolean(wdCompatibility.DoNotSuppressIndentation);
      dmCompatibility.DoNotSuppressParagraphBorders = ReadBoolean(wdCompatibility.DoNotSuppressParagraphBorders);
      dmCompatibility.DoNotUseEastAsianBreakRules = ReadBoolean(wdCompatibility.DoNotUseEastAsianBreakRules);
      dmCompatibility.DoNotUseHTMLParagraphAutoSpacing = ReadBoolean(wdCompatibility.DoNotUseHTMLParagraphAutoSpacing);
      dmCompatibility.DoNotUseIndentAsNumberingTabStop = ReadBoolean(wdCompatibility.DoNotUseIndentAsNumberingTabStop);
      dmCompatibility.DoNotVerticallyAlignCellWithShape = ReadBoolean(wdCompatibility.DoNotVerticallyAlignCellWithShape);
      dmCompatibility.DoNotVerticallyAlignInTextBox = ReadBoolean(wdCompatibility.DoNotVerticallyAlignInTextBox);
      dmCompatibility.DoNotWrapTextWithPunctuation = ReadBoolean(wdCompatibility.DoNotWrapTextWithPunctuation);
      dmCompatibility.FootnoteLayoutLikeWord8 = ReadBoolean(wdCompatibility.FootnoteLayoutLikeWord8);
      dmCompatibility.ForgetLastTabAlignment = ReadBoolean(wdCompatibility.ForgetLastTabAlignment);
      dmCompatibility.GrowAutofit = ReadBoolean(wdCompatibility.GrowAutofit);
      dmCompatibility.LayoutRawTableWidth = ReadBoolean(wdCompatibility.LayoutRawTableWidth);
      dmCompatibility.LayoutTableRowsApart = ReadBoolean(wdCompatibility.LayoutTableRowsApart);
      dmCompatibility.LineWrapLikeWord6 = ReadBoolean(wdCompatibility.LineWrapLikeWord6);
      dmCompatibility.MacWordSmallCaps = ReadBoolean(wdCompatibility.MacWordSmallCaps);
      dmCompatibility.NoColumnBalance = ReadBoolean(wdCompatibility.NoColumnBalance);
      dmCompatibility.NoExtraLineSpacing = ReadBoolean(wdCompatibility.NoExtraLineSpacing);
      dmCompatibility.NoLeading = ReadBoolean(wdCompatibility.NoLeading);
      dmCompatibility.NoSpaceRaiseLower = ReadBoolean(wdCompatibility.NoSpaceRaiseLower);
      dmCompatibility.NoTabHangIndent = ReadBoolean(wdCompatibility.NoTabHangIndent);
      dmCompatibility.PrintBodyTextBeforeHeader = ReadBoolean(wdCompatibility.PrintBodyTextBeforeHeader);
      dmCompatibility.PrintColorBlackWhite = ReadBoolean(wdCompatibility.PrintColorBlackWhite);
      dmCompatibility.SelectFieldWithFirstOrLastChar = ReadBoolean(wdCompatibility.SelectFieldWithFirstOrLastChar);
      dmCompatibility.ShapeLayoutLikeWord8 = ReadBoolean(wdCompatibility.ShapeLayoutLikeWord8);
      dmCompatibility.ShowBreaksInFrames = ReadBoolean(wdCompatibility.ShowBreaksInFrames);
      dmCompatibility.SpaceForUnderline = ReadBoolean(wdCompatibility.SpaceForUnderline);
      dmCompatibility.SpacingInWholePoints = ReadBoolean(wdCompatibility.SpacingInWholePoints);
      dmCompatibility.SplitPageBreakAndParagraphMark = ReadBoolean(wdCompatibility.SplitPageBreakAndParagraphMark);
      dmCompatibility.SubFontBySize = ReadBoolean(wdCompatibility.SubFontBySize);
      dmCompatibility.SuppressBottomSpacing = ReadBoolean(wdCompatibility.SuppressBottomSpacing);
      dmCompatibility.SuppressSpacingAtTopOfPage = ReadBoolean(wdCompatibility.SuppressSpacingAtTopOfPage);
      dmCompatibility.SuppressSpacingBeforeAfterPageBreak = ReadBoolean(wdCompatibility.SuppressSpacingBeforeAfterPageBreak);
      dmCompatibility.SuppressTopSpacing = ReadBoolean(wdCompatibility.SuppressTopSpacing);
      dmCompatibility.SuppressTopSpacingWordPerfect = ReadBoolean(wdCompatibility.SuppressTopSpacingWordPerfect);
      dmCompatibility.SwapBordersFacingPages = ReadBoolean(wdCompatibility.SwapBordersFacingPages);
      dmCompatibility.TruncateFontHeightsLikeWordPerfect = ReadBoolean(wdCompatibility.TruncateFontHeightsLikeWordPerfect);
      dmCompatibility.UnderlineTabInNumberingList = ReadBoolean(wdCompatibility.UnderlineTabInNumberingList);
      dmCompatibility.UnderlineTrailingSpaces = ReadBoolean(wdCompatibility.UnderlineTrailingSpaces);
      dmCompatibility.UseAltKinsokuLineBreakRules = ReadBoolean(wdCompatibility.UseAltKinsokuLineBreakRules);
      dmCompatibility.UseAnsiKerningPairs = ReadBoolean(wdCompatibility.UseAnsiKerningPairs);
      dmCompatibility.UseFarEastLayout = ReadBoolean(wdCompatibility.UseFarEastLayout);
      dmCompatibility.UseNormalStyleForList = ReadBoolean(wdCompatibility.UseNormalStyleForList);
      dmCompatibility.UsePrinterMetrics = ReadBoolean(wdCompatibility.UsePrinterMetrics);
      dmCompatibility.UseSingleBorderForContiguousCells = ReadBoolean(wdCompatibility.UseSingleBorderForContiguousCells);
      dmCompatibility.UseWord2002TableStyleRules = ReadBoolean(wdCompatibility.UseWord2002TableStyleRules);
      dmCompatibility.UseWord97LineBreakRules = ReadBoolean(wdCompatibility.UseWord97LineBreakRules);
      dmCompatibility.WordPerfectJustification = ReadBoolean(wdCompatibility.WordPerfectJustification);
      dmCompatibility.WordPerfectSpaceWidth = ReadBoolean(wdCompatibility.WordPerfectSpaceWidth);
      dmCompatibility.WrapTrailSpaces = ReadBoolean(wdCompatibility.WrapTrailSpaces);
      foreach (var wdSetting in wdCompatibility.OfType<WD.CompatibilitySetting>())
      {
        var name = wdSetting.Name;
        var aNamespace = wdSetting.NamespaceUri;
        string? value = ReadString(wdSetting.Val);
        if (name is not null)
        {
          switch (name.Value)
          {
            case WD.CompatSettingNameValues.CompatibilityMode:
              dmCompatibility.CompatibilityMode = ReadInteger(wdSetting.Val);
              break;
            case WD.CompatSettingNameValues.OverrideTableStyleFontSizeAndJustification:
              dmCompatibility.OverrideTableStyleFontSizeAndJustification = ReadBoolean(wdSetting.Val);
              break;
            case WD.CompatSettingNameValues.EnableOpenTypeFeatures:
              dmCompatibility.EnableOpenTypeFeatures = ReadBoolean(wdSetting.Val);
              break;
            case WD.CompatSettingNameValues.DoNotFlipMirrorIndents:
              dmCompatibility.DoNotFlipMirrorIndents = ReadBoolean(wdSetting.Val);
              break;
            case WD.CompatSettingNameValues.DifferentiateMultirowTableHeaders:
              dmCompatibility.DifferentiateMultirowTableHeaders = ReadBoolean(wdSetting.Val);
              break;
            case WD.CompatSettingNameValues.UseWord2013TrackBottomHyphenation:
              dmCompatibility.UseWord2013TrackBottomHyphenation = ReadBoolean(wdSetting.Val);
              break;
            case WD.CompatSettingNameValues.AllowHyphenationAtTrackBottom:
              dmCompatibility.AllowHyphenationAtTrackBottom = ReadBoolean(wdSetting.Val);
              break;
            case WD.CompatSettingNameValues.AllowTextAfterFloatingTableBreak:
              dmCompatibility.AllowTextAfterFloatingTableBreak = ReadBoolean(wdSetting.Val);
              break;
          }
        }
      }

      return dmCompatibility;
    }
    return default;
  }

  public static DM.WriteProtection? ReadWriteProtection(WD.WriteProtection? docWriteProtection)
  {
    if (docWriteProtection is not null)
    {
      var dmWriteProtection = new DM.WriteProtection();
      dmWriteProtection.AlgorithmIdExtensibility = ReadHexBinary(docWriteProtection.AlgorithmIdExtensibility);
      dmWriteProtection.AlgorithmIdExtensibilitySource = ReadString(docWriteProtection.AlgorithmIdExtensibilitySource);
      dmWriteProtection.AlgorithmName = ReadString(docWriteProtection.AlgorithmName);
      dmWriteProtection.CryptographicAlgorithmClass =
        ReadEnum<DM.CryptAlgorithmClass, WD.CryptAlgorithmClassValues>(docWriteProtection.CryptographicAlgorithmClass);
      dmWriteProtection.CryptographicAlgorithmSid = ReadInteger(docWriteProtection.CryptographicAlgorithmSid);
      dmWriteProtection.CryptographicAlgorithmType =
        ReadEnum<DM.CryptAlgorithmType, WD.CryptAlgorithmValues>(docWriteProtection.CryptographicAlgorithmType);
      dmWriteProtection.CryptographicProvider = ReadString(docWriteProtection.CryptographicProvider);
      dmWriteProtection.CryptographicProviderType =
        ReadEnum<DM.CryptProviderType, WD.CryptProviderValues>(docWriteProtection.CryptographicProviderType);
      dmWriteProtection.CryptographicProviderTypeExtensibility = ReadHexBinary(docWriteProtection.CryptographicProviderTypeExtensibility);
      dmWriteProtection.CryptographicProviderTypeExtSource = ReadString(docWriteProtection.CryptographicProviderTypeExtSource);
      dmWriteProtection.CryptographicSpinCount = ReadInteger(docWriteProtection.CryptographicSpinCount);
      dmWriteProtection.Recommended = ReadBoolean(docWriteProtection.Recommended);
      dmWriteProtection.Hash = ReadBase64Binary(docWriteProtection.Hash);
      dmWriteProtection.HashValue = ReadBase64Binary(docWriteProtection.HashValue);
      dmWriteProtection.Salt = ReadBase64Binary(docWriteProtection.Salt);
      dmWriteProtection.SaltValue = ReadBase64Binary(docWriteProtection.SaltValue);
      dmWriteProtection.SpinCount = ReadInteger(docWriteProtection.SpinCount);
      return dmWriteProtection;
    }
    return default;
  }

  public static DM.DocumentProtection? ReadDocumentProtection(WD.DocumentProtection? docDocumentProtection)
  {
    if (docDocumentProtection is not null)
    {
      var dmDocumentProtection = new DM.DocumentProtection();
      dmDocumentProtection.AlgorithmIdExtensibility = ReadHexBinary(docDocumentProtection.AlgorithmIdExtensibility);
      dmDocumentProtection.AlgorithmIdExtensibilitySource = ReadString(docDocumentProtection.AlgorithmIdExtensibilitySource);
      dmDocumentProtection.AlgorithmName = ReadString(docDocumentProtection.AlgorithmName);
      dmDocumentProtection.CryptographicAlgorithmClass =
        ReadEnum<DM.CryptAlgorithmClass, WD.CryptAlgorithmClassValues>(docDocumentProtection.CryptographicAlgorithmClass);
      dmDocumentProtection.CryptographicAlgorithmSid = ReadInteger(docDocumentProtection.CryptographicAlgorithmSid);
      dmDocumentProtection.CryptographicAlgorithmType =
        ReadEnum<DM.CryptAlgorithmType, WD.CryptAlgorithmValues>(docDocumentProtection.CryptographicAlgorithmType);
      dmDocumentProtection.CryptographicProvider = ReadString(docDocumentProtection.CryptographicProvider);
      dmDocumentProtection.CryptographicProviderType =
        ReadEnum<DM.CryptProviderType, WD.CryptProviderValues>(docDocumentProtection.CryptographicProviderType);
      dmDocumentProtection.CryptographicProviderTypeExtensibility = ReadHexBinary(docDocumentProtection.CryptographicProviderTypeExtensibility);
      dmDocumentProtection.CryptographicProviderTypeExtSource = ReadString(docDocumentProtection.CryptographicProviderTypeExtSource);
      dmDocumentProtection.CryptographicSpinCount = ReadInteger(docDocumentProtection.CryptographicSpinCount);
      dmDocumentProtection.Edit = ReadEnum<DM.DocProtection, WD.DocumentProtectionValues>(docDocumentProtection.Edit);
      dmDocumentProtection.Enforcement = ReadBoolean(docDocumentProtection.Enforcement);
      dmDocumentProtection.Formatting = ReadBoolean(docDocumentProtection.Formatting);
      dmDocumentProtection.Hash = ReadBase64Binary(docDocumentProtection.Hash);
      dmDocumentProtection.HashValue = ReadBase64Binary(docDocumentProtection.HashValue);
      dmDocumentProtection.Salt = ReadBase64Binary(docDocumentProtection.Salt);
      dmDocumentProtection.SaltValue = ReadBase64Binary(docDocumentProtection.SaltValue);
      dmDocumentProtection.SpinCount = ReadInteger(docDocumentProtection.SpinCount);
      return dmDocumentProtection;
    }
    return default;
  }

  public static DM.ProofState? ReadProofState(WD.ProofState? element)
  {
    if (element is not null)
    {
      var dmProofState = new DM.ProofState();
      dmProofState.Spelling = ReadEnum<DM.ProofingState, WD.ProofingStateValues>(element.Spelling);
      dmProofState.Grammar = ReadEnum<DM.ProofingState, WD.ProofingStateValues>(element.Grammar);
    }
    return default;
  }

  public static DM.Revisions? ReadRsIds(WD.Settings? docSettings)
  {
    WD.Rsids? docRsIds = docSettings?.GetRsids();
    if (docRsIds == null)
      return null;
    var dmRsIds = new DM.Revisions();
    dmRsIds.RsidRoot = ToHexInt(docRsIds.RsidRoot?.Val);
    foreach (var item in docRsIds.Elements<WD.Rsid>())
    {
      var val = ToHexInt(item.Val);
      if (val is DM.HexInt hint)
        dmRsIds.Add(hint);
    }
    return dmRsIds;
  }
}