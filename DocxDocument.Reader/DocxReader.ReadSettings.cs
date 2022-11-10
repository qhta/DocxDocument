using Qhta.OpenXMLTools;

using CX = DocumentFormat.OpenXml.CustomXmlSchemaReferences;
using DM = DocxDocument.Model;
using OM = DocumentFormat.OpenXml.Math;
using OO = DocumentFormat.OpenXml;
using W = DocumentFormat.OpenXml.Wordprocessing;

namespace DocxDocument.Reader;

public partial class DocxReader
{
  public DM.DocumentSettings ReadDocumentSettings()
  {
    return ReadDocumentSettings(Parts.AllDocumentSettings);
  }

  public DM.DocumentSettings ReadDocumentSettings(Parts parts)
  {
    var dmDocumentSettings = new DM.DocumentSettings();
    if (parts.HasFlag(Parts.DocumentSettings))
      ReadDocumentSettings(dmDocumentSettings);
    return dmDocumentSettings;
  }

  private void ReadDocumentSettings(DM.DocumentSettings dmDocumentSettings)
  {
    var docSettings = WordprocessingDocument.MainDocumentPart?.DocumentSettingsPart?.Settings;
    if (docSettings is not null)
    {
      #region Automation settings
      dmDocumentSettings.DoNotIncludeSubdocsInStats = ReadBoolean(docSettings.GetDoNotIncludeSubdocsInStats());
      dmDocumentSettings.SavePreviewPicture = ReadBoolean(docSettings.GetSavePreviewPicture());
      dmDocumentSettings.SummaryLength = ReadPercentage(docSettings.GetSummaryLength()?.Val);
      #endregion

      #region Change Tracking settings
      dmDocumentSettings.TrackRevisions = ReadBoolean(docSettings.GetTrackRevisions());
      dmDocumentSettings.DoNotTrackFormatting = ReadBoolean(docSettings.GetDoNotTrackFormatting());
      dmDocumentSettings.DoNotTrackMoves = ReadBoolean(docSettings.GetDoNotTrackMoves());
      dmDocumentSettings.RevisionView = ReadEnum<DM.RevisionView>(docSettings.GetRevisionView());
      #endregion

      #region Character Spacing settings
      dmDocumentSettings.CharacterSpacingControl = ReadEnum<DM.CharacterSpacing>(docSettings.GetCharacterSpacingControl());
      dmDocumentSettings.NoPunctuationKerning = ReadBoolean(docSettings.GetNoPunctuationKerning());

      #endregion

      #region Compatibility settings
      dmDocumentSettings.Compatibility = ReadCompatibility(docSettings.GetCompatibility());
      dmDocumentSettings.ForceUpgrade = ReadBoolean(docSettings.GetForceUpgrade());
      #endregion

      #region Custom XML settings
      dmDocumentSettings.AlwaysMergeEmptyNamespace = ReadBoolean(docSettings.GetAlwaysMergeEmptyNamespace());
      dmDocumentSettings.AlwaysShowPlaceholderText = ReadBoolean(docSettings.GetAlwaysShowPlaceholderText());
      dmDocumentSettings.ShowXmlTags = ReadBoolean(docSettings.GetShowXmlTags());
      dmDocumentSettings.DoNotDemarcateInvalidXml = ReadBoolean(docSettings.GetDoNotDemarcateInvalidXml());
      dmDocumentSettings.DoNotValidateAgainstSchema = ReadBoolean(docSettings.GetDoNotValidateAgainstSchema());
      dmDocumentSettings.IgnoreMixedContent = ReadBoolean(docSettings.GetIgnoreMixedContent());
      dmDocumentSettings.SaveInvalidXml = ReadBoolean(docSettings.GetSaveInvalidXml());
      dmDocumentSettings.SaveXmlDataOnly = ReadBoolean(docSettings.GetSaveXmlDataOnly());
      dmDocumentSettings.UseXsltWhenSaving = ReadBoolean(docSettings.GetUseXsltWhenSaving());
      var saveThroughXslt = docSettings.GetSaveThroughXslt();
      if (saveThroughXslt is not null)
      {
        dmDocumentSettings.SaveThroughXslt = ReadString(saveThroughXslt);
        if (saveThroughXslt.SolutionId is not null)
          dmDocumentSettings.SolutionId = ReadString(saveThroughXslt.SolutionId);
      }
      dmDocumentSettings.AttachedSchema = ReadString(docSettings.GetAttachedSchema());
      dmDocumentSettings.SchemaLibrary = ReadSchemaLibrary(docSettings.GetSchemaLibrary());
      #endregion

      #region DisplayGrid settings
      dmDocumentSettings.DrawingGridHorizontalOrigin = ReadTwips(docSettings.GetDrawingGridHorizontalOrigin());
      dmDocumentSettings.DrawingGridHorizontalSpacing = ReadTwips(docSettings.GetDrawingGridHorizontalSpacing());
      dmDocumentSettings.DrawingGridVerticalOrigin = ReadTwips(docSettings.GetDrawingGridVerticalOrigin());
      dmDocumentSettings.DrawingGridVerticalSpacing = ReadTwips(docSettings.GetDrawingGridVerticalSpacing());
      dmDocumentSettings.DisplayHorizontalDrawingGridEvery = ReadInteger(docSettings.GetDisplayHorizontalDrawingGrid());
      dmDocumentSettings.DisplayVerticalDrawingGridEvery = ReadInteger(docSettings.GetDisplayVerticalDrawingGrid());
      dmDocumentSettings.DoNotUseMarginsForDrawingGridOrigin = ReadBoolean(docSettings.GetDoNotUseMarginsForDrawingGridOrigin());
      #endregion

      #region Mailing settings
      dmDocumentSettings.DocumentType = ReadEnum<DM.MailingType>(docSettings.GetDocumentType());
      dmDocumentSettings.ShowEnvelope = ReadBoolean(docSettings.GetShowEnvelope());
      dmDocumentSettings.MailMerge = ReadEnumMailMergeSettings(docSettings.GetMailMerge());
      #endregion

      #region Field evaluation
      dmDocumentSettings.DecimalSymbol = ReadString(docSettings.GetDecimalSymbol());
      dmDocumentSettings.ListSeparator = ReadString(docSettings.GetListSeparator());
      dmDocumentSettings.UpdateFields = ReadBoolean(docSettings.GetUpdateFieldsOnOpen());
      #endregion

      #region Forms settings
      dmDocumentSettings.DoNotShadeFormData = ReadBoolean(docSettings.GetDoNotShadeFormData());
      dmDocumentSettings.SaveFormsData = ReadBoolean(docSettings.GetSaveFormsData());
      dmDocumentSettings.FormsDesign = ReadBoolean(docSettings.GetFormsDesign());
      #endregion

      #region Embed Fonts settings
      dmDocumentSettings.SaveSubsetFonts = ReadBoolean(docSettings.GetSaveSubsetFonts());
      dmDocumentSettings.EmbedSystemFonts = ReadBoolean(docSettings.GetEmbedSystemFonts());
      dmDocumentSettings.EmbedTrueTypeFonts = ReadBoolean(docSettings.GetEmbedTrueTypeFonts());
      #endregion

      #region Images settings
      dmDocumentSettings.DoNotAutoCompressPictures = ReadBoolean(docSettings.GetDoNotAutoCompressPictures());
      dmDocumentSettings.DefaultImageDpi = ReadInteger(docSettings.GetDefaultImageDpi()?.Val);
      dmDocumentSettings.DiscardImageEditingData = ReadBoolean(docSettings.GetDiscardImageEditingData());
      #endregion

      #region Hyphenation settings
      dmDocumentSettings.AutoHyphenation = ReadBoolean(docSettings.GetAutoHyphenation());
      dmDocumentSettings.DoNotHyphenateCaps = ReadBoolean(docSettings.GetDoNotHyphenateCaps());
      dmDocumentSettings.ConsecutiveHyphenLimit = ReadEnum<int>(docSettings.GetConsecutiveHyphenLimit());
      #endregion

      #region Kinsoku line breaking settings
      dmDocumentSettings.StrictFirstAndLastChars = ReadBoolean(docSettings.GetStrictFirstAndLastChars());
      dmDocumentSettings.NoLineBreaksAfter = ReadKinsokuText(docSettings.GetNoLineBreaksAfterKinsoku());
      dmDocumentSettings.NoLineBreaksBefore = ReadKinsokuText(docSettings.GetNoLineBreaksBeforeKinsoku());
      #endregion

      #region Layout settings
      dmDocumentSettings.MirrorMargins = ReadBoolean(docSettings.GetMirrorMargins());
      dmDocumentSettings.EvenAndOddHeaders = ReadBoolean(docSettings.GetEvenAndOddHeaders());
      dmDocumentSettings.BordersDoNotSurroundFooter = ReadBoolean(docSettings.GetBordersDoNotSurroundFooter());
      dmDocumentSettings.BordersDoNotSurroundHeader = ReadBoolean(docSettings.GetBordersDoNotSurroundHeader());
      dmDocumentSettings.AlignBorderAndEdges = ReadBoolean(docSettings.GetAlignBorderAndEdges());
      dmDocumentSettings.DisplayBackgroundShape = ReadBoolean(docSettings.GetDisplayBackgroundShape());
      dmDocumentSettings.GutterAtTop = ReadBoolean(docSettings.GetGutterAtTop());
      dmDocumentSettings.DefaultTabStop = ReadTwips(docSettings.GetDefaultTabStop());
      dmDocumentSettings.ReadModeInkLockDown = ReadReadModeInkLockDown(docSettings.GetReadModeInkLockDown());
      #endregion

      #region Printing settings
      dmDocumentSettings.PrintFormsData = ReadBoolean(docSettings.GetPrintFormsData());
      dmDocumentSettings.PrintFractionalCharacterWidth = ReadBoolean(docSettings.GetPrintFractionalCharacterWidth());
      dmDocumentSettings.PrintPostScriptOverText = ReadBoolean(docSettings.GetPrintPostScriptOverText());
      dmDocumentSettings.PrintTwoOnOne = ReadBoolean(docSettings.GetPrintTwoOnOne());
      dmDocumentSettings.BookFoldPrinting = ReadBoolean(docSettings.GetBookFoldPrinting());
      dmDocumentSettings.GetBookFoldReversePrinting = ReadBoolean(docSettings.GetBookFoldReversePrinting());
      dmDocumentSettings.BookFoldPrintingSheets = ReadInteger(docSettings.GetBookFoldPrintingSheets()?.Val);
      #endregion

      #region Proofing settings
      dmDocumentSettings.ActiveWritingStyle = ReadWritingStyle(docSettings.GetActiveWritingStyle());
      dmDocumentSettings.HideGrammaticalErrors = ReadBoolean(docSettings.GetHideGrammaticalErrors());
      dmDocumentSettings.HideSpellingErrors = ReadBoolean(docSettings.GetHideSpellingErrors());
      dmDocumentSettings.ProofState = ReadProofState(docSettings.GetProofState());
      #endregion

      #region Document Protection settings
      dmDocumentSettings.DocumentProtection = ReadDocumentProtection(docSettings.GetDocumentProtection());
      dmDocumentSettings.WriteProtection = ReadWriteProtection(docSettings.GetWriteProtection());
      dmDocumentSettings.RemoveDateAndTime = ReadBoolean(docSettings.GetRemoveDateAndTime());
      dmDocumentSettings.RemovePersonalInformation = ReadBoolean(docSettings.GetRemovePersonalInformation());
      dmDocumentSettings.AutoFormatOverride = ReadBoolean(docSettings.GetAutoFormatOverride());
      #endregion

      #region Style and Theme settings
      dmDocumentSettings.GetStyleLockStylesPart = ReadBoolean(docSettings.GetStyleLockStylesPart());
      dmDocumentSettings.StyleLockThemesPart = ReadBoolean(docSettings.GetStyleLockThemesPart());
      dmDocumentSettings.ClickAndTypeStyle = ReadString(docSettings.GetClickAndTypeStyle());
      dmDocumentSettings.DefaultTableStyle = ReadString(docSettings.GetDefaultTableStyle());
      dmDocumentSettings.LinkStyles = ReadBoolean(docSettings.GetLinkStyles());
      dmDocumentSettings.AttachedTemplate = ReadString(docSettings.GetAttachedTemplate());
      dmDocumentSettings.ColorSchemeMapping = ReadColorSchemeMapping(docSettings.GetColorSchemeMapping());
      dmDocumentSettings.ThemeFontLanguages = ReadThemeFontLang(docSettings.GetThemeFontLanguages());
      dmDocumentSettings.StylePaneFormatFilter = ReadStylePaneFormatFilter(docSettings.GetStylePaneFormatFilter());
      dmDocumentSettings.StylePaneSortMethods = ReadStylePaneSortMethods(docSettings.GetStylePaneSortMethods());
      #endregion

      #region Document View settings
      dmDocumentSettings.DoNotDisplayPageBoundaries = ReadBoolean(docSettings.GetDoNotDisplayPageBoundaries());
      dmDocumentSettings.View = ReadEnum<DM.DocView>(docSettings.GetView());
      dmDocumentSettings.Zoom = ReadZoom(docSettings.GetZoom());
      #endregion

      #region Other settings
      dmDocumentSettings.Captions = ReadCaptions(docSettings.GetCaptions());
      dmDocumentSettings.DocumentVariables = ReadDocumentVariables(docSettings.GetDocumentVariables());
      dmDocumentSettings.EndnoteDocumentWideProperties = ReadEndnoteDocumentWideProperties(docSettings.GetEndnoteDocumentWideProperties());
      dmDocumentSettings.FootnoteDocumentWideProperties = ReadFootnoteDocumentWideProperties(docSettings.GetFootnoteDocumentWideProperties());
      dmDocumentSettings.MathProperties = ReadMathProperties(docSettings.GetMathProperties());
      #endregion
    }
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
    if (element is W.NoLineBreaksAfterKinsoku w1)
    {
      return new DM.LangText { Lang = w1.Language, Text = w1.Val };
    }
    if (element is W.NoLineBreaksBeforeKinsoku w2)
    {
      return new DM.LangText { Lang = w2.Language, Text = w2.Val };
    }
    return null;
  }

  public static DM.FootnoteProperties? ReadFootnoteDocumentWideProperties(W.FootnoteDocumentWideProperties docFootnoteProperties)
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

  public static DM.EndnoteProperties? ReadEndnoteDocumentWideProperties(W.EndnoteDocumentWideProperties docEndnoteProperties)
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

  public static DM.DocumentVariables? ReadDocumentVariables(W.DocumentVariables? docDocumentVariables)
  {
    if (docDocumentVariables is not null)
    {
      var dmDocumentVariables = new DM.DocumentVariables();
      foreach (var docDocumentVariable in docDocumentVariables.OfType<W.DocumentVariable>())
      {
        var dmDocumentVariable = ReadDocumentVariable(docDocumentVariable);
        if (dmDocumentVariable is not null)
          dmDocumentVariables.Add(dmDocumentVariable);
      }
      return dmDocumentVariables;
    }
    return default;
  }

  public static KeyValuePair<string, object?>? ReadDocumentVariable(W.DocumentVariable? docDocumentVariable)
  {
    if (docDocumentVariable is not null)
    {
      string? name = docDocumentVariable.Name;
      if (name is not null)
        return new KeyValuePair<string, object?>(name, docDocumentVariable.Val);
    }
    return default;
  }

  public static DM.Captions? ReadCaptions(W.Captions? docCaptions)
  {
    if (docCaptions is not null)
    {
      var dmCaptions = new DM.Captions();
      foreach (var docCaption in docCaptions.OfType<W.Caption>())
      {
        var dmCaption = ReadCaption(docCaption);
        if (dmCaption is not null)
          dmCaptions.Add(dmCaption);
      }
      return dmCaptions;
    }
    return default;
  }

  public static DM.Caption? ReadCaption(W.Caption? docCaption)
  {
    if (docCaption is not null)
    {
      var dmCaption = new DM.Caption();
      dmCaption.ChapterNumber = ReadBoolean(docCaption.ChapterNumber);
      dmCaption.Heading = ReadInteger(docCaption.Heading);
      dmCaption.Name = ReadString(docCaption.Name);
      dmCaption.NoLabel = ReadBoolean(docCaption.NoLabel);
      dmCaption.NumberFormat = ReadEnum<DM.NumberFormat, W.NumberFormatValues>(docCaption.NumberFormat);
      dmCaption.Position = ReadEnum<DM.CaptionPosition, W.CaptionPositionValues>(docCaption.Position);
      dmCaption.Separator = ReadEnum<DM.ChapterSeparator, W.ChapterSeparatorValues>(docCaption.Separator);
      return dmCaption;
    }
    return default;
  }

  public static DM.StylePaneSortMethods? ReadStylePaneSortMethods(W.StylePaneSortMethods docStylePaneSortMethods)
  {
    if (docStylePaneSortMethods is not null)
    {
      if (docStylePaneSortMethods.Val is not null)
      {
        if (int.TryParse(docStylePaneSortMethods.Val, NumberStyles.HexNumber, null, out var val))
          return (DM.StylePaneSortMethods)(int)val;
        if (Enum.TryParse<W.StylePaneSortMethodsValues>(docStylePaneSortMethods.Val, true, out var wVal))
          return (DM.StylePaneSortMethods)(int)wVal;
      }
    }
    return default;
  }

  public static DM.StylePaneFormatFilter? ReadStylePaneFormatFilter(W.StylePaneFormatFilter docStylePaneFormatFilter)
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

  public static DM.ScriptTypeLanguage? ReadThemeFontLang(W.LanguageType? docLanguageType)
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

  public static DM.Zoom? ReadZoom(W.Zoom? docZoom)
  {
    if (docZoom is not null)
    {
      var dmZoom = new DM.Zoom();
      dmZoom.Percent = ReadPercentage(docZoom.Percent);
      dmZoom.Preset = ReadEnum<DM.PresetZoom, W.PresetZoomValues>(docZoom.Val);
      return dmZoom;
    }
    return default;
  }

  public static DM.ColorSchemeMapping? ReadColorSchemeMapping(W.ColorSchemeMapping? doc)
  {
    if (doc is not null)
    {
      var dm = new DM.ColorSchemeMapping();
      dm.Accent1 = ReadEnum<DM.ThemeColorIndex, W.ColorSchemeIndexValues>(doc.Accent1);
      dm.Accent2 = ReadEnum<DM.ThemeColorIndex, W.ColorSchemeIndexValues>(doc.Accent2);
      dm.Accent3 = ReadEnum<DM.ThemeColorIndex, W.ColorSchemeIndexValues>(doc.Accent3);
      dm.Accent4 = ReadEnum<DM.ThemeColorIndex, W.ColorSchemeIndexValues>(doc.Accent4);
      dm.Accent5 = ReadEnum<DM.ThemeColorIndex, W.ColorSchemeIndexValues>(doc.Accent5);
      dm.Accent6 = ReadEnum<DM.ThemeColorIndex, W.ColorSchemeIndexValues>(doc.Accent6);
      dm.Background1 = ReadEnum<DM.ThemeColorIndex, W.ColorSchemeIndexValues>(doc.Background1);
      dm.Background2 = ReadEnum<DM.ThemeColorIndex, W.ColorSchemeIndexValues>(doc.Background2);
      dm.Text1 = ReadEnum<DM.ThemeColorIndex, W.ColorSchemeIndexValues>(doc.Text1);
      dm.Text2 = ReadEnum<DM.ThemeColorIndex, W.ColorSchemeIndexValues>(doc.Text2);
      dm.Hyperlink = ReadEnum<DM.ThemeColorIndex, W.ColorSchemeIndexValues>(doc.Hyperlink);
      dm.FollowedHyperlink = ReadEnum<DM.ThemeColorIndex, W.ColorSchemeIndexValues>(doc.FollowedHyperlink);
      return dm;
    }
    return default;
  }

  public static DM.WritingStyle? ReadWritingStyle(W.ActiveWritingStyle? docWritingStyle)
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

  public static DM.ReadModeInkLockDown? ReadReadModeInkLockDown(W.ReadModeInkLockDown? docReadModeInkLockDown)
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

  public static DM.MailMergeSettings? ReadEnumMailMergeSettings(W.MailMerge docMailMerge)
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
      dmMailMergeSettings.HeaderSource = ReadString(docMailMerge.HeaderSource);
      dmMailMergeSettings.DataSourceReference = ReadString(docMailMerge.DataSourceReference);
      return dmMailMergeSettings;
    }
    return default;
  }

  public static DM.DataSourceObject? ReadDataSourceObject(W.DataSourceObject? docDataSourceObject)
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

  public static DM.CompatibilitySettings? ReadCompatibility(W.Compatibility? docCompatibility)
  {
    if (docCompatibility is not null)
    {
      var dmCompatibility = new DM.CompatibilitySettings();
      dmCompatibility.AdjustLineHeightInTable = ReadBoolean(docCompatibility.AdjustLineHeightInTable);
      dmCompatibility.AlignTablesRowByRow = ReadBoolean(docCompatibility.AlignTablesRowByRow);
      dmCompatibility.AllowSpaceOfSameStyleInTable = ReadBoolean(docCompatibility.AllowSpaceOfSameStyleInTable);
      dmCompatibility.ApplyBreakingRules = ReadBoolean(docCompatibility.ApplyBreakingRules);
      dmCompatibility.AutofitToFirstFixedWidthCell = ReadBoolean(docCompatibility.AutofitToFirstFixedWidthCell);
      dmCompatibility.AutoSpaceLikeWord95 = ReadBoolean(docCompatibility.AutoSpaceLikeWord95);
      dmCompatibility.BalanceSingleByteDoubleByteWidth = ReadBoolean(docCompatibility.BalanceSingleByteDoubleByteWidth);
      dmCompatibility.CachedColumnBalance = ReadBoolean(docCompatibility.CachedColumnBalance);
      dmCompatibility.ConvertMailMergeEscape = ReadBoolean(docCompatibility.ConvertMailMergeEscape);
      dmCompatibility.DisplayHangulFixedWidth = ReadBoolean(docCompatibility.DisplayHangulFixedWidth);
      dmCompatibility.DoNotAutofitConstrainedTables = ReadBoolean(docCompatibility.DoNotAutofitConstrainedTables);
      dmCompatibility.DoNotBreakConstrainedForcedTable = ReadBoolean(docCompatibility.DoNotBreakConstrainedForcedTable);
      dmCompatibility.DoNotBreakWrappedTables = ReadBoolean(docCompatibility.DoNotBreakWrappedTables);
      dmCompatibility.DoNotExpandShiftReturn = ReadBoolean(docCompatibility.DoNotExpandShiftReturn);
      dmCompatibility.DoNotLeaveBackslashAlone = ReadBoolean(docCompatibility.DoNotLeaveBackslashAlone);
      dmCompatibility.DoNotSnapToGridInCell = ReadBoolean(docCompatibility.DoNotSnapToGridInCell);
      dmCompatibility.DoNotSuppressIndentation = ReadBoolean(docCompatibility.DoNotSuppressIndentation);
      dmCompatibility.DoNotSuppressParagraphBorders = ReadBoolean(docCompatibility.DoNotSuppressParagraphBorders);
      dmCompatibility.DoNotUseEastAsianBreakRules = ReadBoolean(docCompatibility.DoNotUseEastAsianBreakRules);
      dmCompatibility.DoNotUseHTMLParagraphAutoSpacing = ReadBoolean(docCompatibility.DoNotUseHTMLParagraphAutoSpacing);
      dmCompatibility.DoNotUseIndentAsNumberingTabStop = ReadBoolean(docCompatibility.DoNotUseIndentAsNumberingTabStop);
      dmCompatibility.DoNotVerticallyAlignCellWithShape = ReadBoolean(docCompatibility.DoNotVerticallyAlignCellWithShape);
      dmCompatibility.DoNotVerticallyAlignInTextBox = ReadBoolean(docCompatibility.DoNotVerticallyAlignInTextBox);
      dmCompatibility.DoNotWrapTextWithPunctuation = ReadBoolean(docCompatibility.DoNotWrapTextWithPunctuation);
      dmCompatibility.FootnoteLayoutLikeWord8 = ReadBoolean(docCompatibility.FootnoteLayoutLikeWord8);
      dmCompatibility.ForgetLastTabAlignment = ReadBoolean(docCompatibility.ForgetLastTabAlignment);
      dmCompatibility.GrowAutofit = ReadBoolean(docCompatibility.GrowAutofit);
      dmCompatibility.LayoutRawTableWidth = ReadBoolean(docCompatibility.LayoutRawTableWidth);
      dmCompatibility.LayoutTableRowsApart = ReadBoolean(docCompatibility.LayoutTableRowsApart);
      dmCompatibility.LineWrapLikeWord6 = ReadBoolean(docCompatibility.LineWrapLikeWord6);
      dmCompatibility.MacWordSmallCaps = ReadBoolean(docCompatibility.MacWordSmallCaps);
      dmCompatibility.NoColumnBalance = ReadBoolean(docCompatibility.NoColumnBalance);
      dmCompatibility.NoExtraLineSpacing = ReadBoolean(docCompatibility.NoExtraLineSpacing);
      dmCompatibility.NoLeading = ReadBoolean(docCompatibility.NoLeading);
      dmCompatibility.NoSpaceRaiseLower = ReadBoolean(docCompatibility.NoSpaceRaiseLower);
      dmCompatibility.NoTabHangIndent = ReadBoolean(docCompatibility.NoTabHangIndent);
      dmCompatibility.PrintBodyTextBeforeHeader = ReadBoolean(docCompatibility.PrintBodyTextBeforeHeader);
      dmCompatibility.PrintColorBlackWhite = ReadBoolean(docCompatibility.PrintColorBlackWhite);
      dmCompatibility.SelectFieldWithFirstOrLastChar = ReadBoolean(docCompatibility.SelectFieldWithFirstOrLastChar);
      dmCompatibility.ShapeLayoutLikeWord8 = ReadBoolean(docCompatibility.ShapeLayoutLikeWord8);
      dmCompatibility.ShowBreaksInFrames = ReadBoolean(docCompatibility.ShowBreaksInFrames);
      dmCompatibility.SpaceForUnderline = ReadBoolean(docCompatibility.SpaceForUnderline);
      dmCompatibility.SpacingInWholePoints = ReadBoolean(docCompatibility.SpacingInWholePoints);
      dmCompatibility.SplitPageBreakAndParagraphMark = ReadBoolean(docCompatibility.SplitPageBreakAndParagraphMark);
      dmCompatibility.SubFontBySize = ReadBoolean(docCompatibility.SubFontBySize);
      dmCompatibility.SuppressBottomSpacing = ReadBoolean(docCompatibility.SuppressBottomSpacing);
      dmCompatibility.SuppressSpacingAtTopOfPage = ReadBoolean(docCompatibility.SuppressSpacingAtTopOfPage);
      dmCompatibility.SuppressSpacingBeforeAfterPageBreak = ReadBoolean(docCompatibility.SuppressSpacingBeforeAfterPageBreak);
      dmCompatibility.SuppressTopSpacing = ReadBoolean(docCompatibility.SuppressTopSpacing);
      dmCompatibility.SuppressTopSpacingWordPerfect = ReadBoolean(docCompatibility.SuppressTopSpacingWordPerfect);
      dmCompatibility.SwapBordersFacingPages = ReadBoolean(docCompatibility.SwapBordersFacingPages);
      dmCompatibility.TruncateFontHeightsLikeWordPerfect = ReadBoolean(docCompatibility.TruncateFontHeightsLikeWordPerfect);
      dmCompatibility.UnderlineTabInNumberingList = ReadBoolean(docCompatibility.UnderlineTabInNumberingList);
      dmCompatibility.UnderlineTrailingSpaces = ReadBoolean(docCompatibility.UnderlineTrailingSpaces);
      dmCompatibility.UseAltKinsokuLineBreakRules = ReadBoolean(docCompatibility.UseAltKinsokuLineBreakRules);
      dmCompatibility.UseAnsiKerningPairs = ReadBoolean(docCompatibility.UseAnsiKerningPairs);
      dmCompatibility.UseFarEastLayout = ReadBoolean(docCompatibility.UseFarEastLayout);
      dmCompatibility.UseNormalStyleForList = ReadBoolean(docCompatibility.UseNormalStyleForList);
      dmCompatibility.UsePrinterMetrics = ReadBoolean(docCompatibility.UsePrinterMetrics);
      dmCompatibility.UseSingleBorderForContiguousCells = ReadBoolean(docCompatibility.UseSingleBorderForContiguousCells);
      dmCompatibility.UseWord2002TableStyleRules = ReadBoolean(docCompatibility.UseWord2002TableStyleRules);
      dmCompatibility.UseWord97LineBreakRules = ReadBoolean(docCompatibility.UseWord97LineBreakRules);
      dmCompatibility.WordPerfectJustification = ReadBoolean(docCompatibility.WordPerfectJustification);
      dmCompatibility.WordPerfectSpaceWidth = ReadBoolean(docCompatibility.WordPerfectSpaceWidth);
      dmCompatibility.WrapTrailSpaces = ReadBoolean(docCompatibility.WrapTrailSpaces);
      foreach (var docSetting in docCompatibility.OfType<W.CompatibilitySetting>())
      {
        var name = docSetting.Name;
        var aNamespace = docSetting.NamespaceUri;
        string? value = ReadString(docSetting.Val);
        if (name is not null)
        {
          switch (name.Value)
          {
            case W.CompatSettingNameValues.CompatibilityMode:
              dmCompatibility.CompatibilityMode = ReadInteger(docSetting.Val);
              break;
            case W.CompatSettingNameValues.OverrideTableStyleFontSizeAndJustification:
              dmCompatibility.OverrideTableStyleFontSizeAndJustification = ReadBoolean(docSetting.Val);
              break;
            case W.CompatSettingNameValues.EnableOpenTypeFeatures:
              dmCompatibility.EnableOpenTypeFeatures = ReadBoolean(docSetting.Val);
              break;
            case W.CompatSettingNameValues.DoNotFlipMirrorIndents:
              dmCompatibility.DoNotFlipMirrorIndents = ReadBoolean(docSetting.Val);
              break;
            case W.CompatSettingNameValues.DifferentiateMultirowTableHeaders:
              dmCompatibility.DifferentiateMultirowTableHeaders = ReadBoolean(docSetting.Val);
              break;
            case W.CompatSettingNameValues.UseWord2013TrackBottomHyphenation:
              dmCompatibility.UseWord2013TrackBottomHyphenation = ReadBoolean(docSetting.Val);
              break;
            case W.CompatSettingNameValues.AllowHyphenationAtTrackBottom:
              dmCompatibility.AllowHyphenationAtTrackBottom = ReadBoolean(docSetting.Val);
              break;
            case W.CompatSettingNameValues.AllowTextAfterFloatingTableBreak:
              dmCompatibility.AllowTextAfterFloatingTableBreak = ReadBoolean(docSetting.Val);
              break;
          }
        }
      }

      return dmCompatibility;
    }
    return default;
  }

  public static DM.WriteProtection? ReadWriteProtection(W.WriteProtection? docWriteProtection)
  {
    if (docWriteProtection is not null)
    {
      var dmWriteProtection = new DM.WriteProtection();
      dmWriteProtection.AlgorithmIdExtensibility = ReadHexBinary(docWriteProtection.AlgorithmIdExtensibility);
      dmWriteProtection.AlgorithmIdExtensibilitySource = ReadString(docWriteProtection.AlgorithmIdExtensibilitySource);
      dmWriteProtection.AlgorithmName = ReadString(docWriteProtection.AlgorithmName);
      dmWriteProtection.CryptographicAlgorithmClass =
        ReadEnum<DM.CryptAlgorithmClass, W.CryptAlgorithmClassValues>(docWriteProtection.CryptographicAlgorithmClass);
      dmWriteProtection.CryptographicAlgorithmSid = ReadInteger(docWriteProtection.CryptographicAlgorithmSid);
      dmWriteProtection.CryptographicAlgorithmType =
        ReadEnum<DM.CryptAlgorithmType, W.CryptAlgorithmValues>(docWriteProtection.CryptographicAlgorithmType);
      dmWriteProtection.CryptographicProvider = ReadString(docWriteProtection.CryptographicProvider);
      dmWriteProtection.CryptographicProviderType =
        ReadEnum<DM.CryptProviderType, W.CryptProviderValues>(docWriteProtection.CryptographicProviderType);
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

  public static DM.DocumentProtection? ReadDocumentProtection(W.DocumentProtection? docDocumentProtection)
  {
    if (docDocumentProtection is not null)
    {
      var dmDocumentProtection = new DM.DocumentProtection();
      dmDocumentProtection.AlgorithmIdExtensibility = ReadHexBinary(docDocumentProtection.AlgorithmIdExtensibility);
      dmDocumentProtection.AlgorithmIdExtensibilitySource = ReadString(docDocumentProtection.AlgorithmIdExtensibilitySource);
      dmDocumentProtection.AlgorithmName = ReadString(docDocumentProtection.AlgorithmName);
      dmDocumentProtection.CryptographicAlgorithmClass =
        ReadEnum<DM.CryptAlgorithmClass, W.CryptAlgorithmClassValues>(docDocumentProtection.CryptographicAlgorithmClass);
      dmDocumentProtection.CryptographicAlgorithmSid = ReadInteger(docDocumentProtection.CryptographicAlgorithmSid);
      dmDocumentProtection.CryptographicAlgorithmType =
        ReadEnum<DM.CryptAlgorithmType, W.CryptAlgorithmValues>(docDocumentProtection.CryptographicAlgorithmType);
      dmDocumentProtection.CryptographicProvider = ReadString(docDocumentProtection.CryptographicProvider);
      dmDocumentProtection.CryptographicProviderType =
        ReadEnum<DM.CryptProviderType, W.CryptProviderValues>(docDocumentProtection.CryptographicProviderType);
      dmDocumentProtection.CryptographicProviderTypeExtensibility = ReadHexBinary(docDocumentProtection.CryptographicProviderTypeExtensibility);
      dmDocumentProtection.CryptographicProviderTypeExtSource = ReadString(docDocumentProtection.CryptographicProviderTypeExtSource);
      dmDocumentProtection.CryptographicSpinCount = ReadInteger(docDocumentProtection.CryptographicSpinCount);
      dmDocumentProtection.Edit = ReadEnum<DM.DocProtection, W.DocumentProtectionValues>(docDocumentProtection.Edit);
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

  public static DM.ProofState? ReadProofState(W.ProofState? element)
  {
    if (element is not null)
    {
      var dmProofState = new DM.ProofState();
      dmProofState.Spelling = ReadEnum<DM.ProofingState, W.ProofingStateValues>(element.Spelling);
      dmProofState.Grammar = ReadEnum<DM.ProofingState, W.ProofingStateValues>(element.Grammar);
    }
    return default;
  }

  public static DM.Revisions? ReadRsIds(W.Settings? docSettings)
  {
    W.Rsids? docRsIds = docSettings?.GetRsids();
    if (docRsIds == null)
      return null;
    var dmRsIds = new DM.Revisions();
    dmRsIds.RsidRoot = ToHexInt(docRsIds.RsidRoot?.Val);
    foreach (var item in docRsIds.Elements<W.Rsid>())
    {
      var val = ToHexInt(item.Val);
      if (val is DM.HexInt hint)
        dmRsIds.Add(hint);
    }
    return dmRsIds;
  }
}