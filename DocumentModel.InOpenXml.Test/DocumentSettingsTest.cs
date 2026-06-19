namespace DocumentModel.InOpenXml.Test
{
  /// <summary>
  /// Provides comprehensive serialization tests for <see cref="DocumentSettings"/>.
  /// </summary>
  public class DocumentSettingsTest: _AbstractModelTestClass<DocumentSettings>
  {

    ///// <summary>
    ///// Creates a sample <see cref="DocumentSettings"/> instance for testing.
    ///// </summary>
    ///// <returns>A populated <see cref="DocumentSettings"/> object.</returns>
    //protected override DocumentSettings CreateSampleData()
    //{
    // return new DocumentSettings
    //    {
    //      AlignBorderAndEdges = true,
    //      AlwaysMergeEmptyNamespace = true,
    //      AlwaysShowPlaceholderText = false,
    //      AutoFormatOverride = true,
    //      AutoHyphenation = false,
    //      BookFoldPrinting = true,
    //      BookFoldPrintingSheets = 8,
    //      BookFoldReversePrinting = false,
    //      BordersDoNotSurroundFooter = true,
    //      BordersDoNotSurroundHeader = false,
    //      CharacterSpacingControl = CharacterSpacing.CompressPunctuation,
    //      ChartTrackingRefBased = true,
    //      ClickAndTypeStyle = "Normal",
    //      ConflictMode = false,
    //      ConsecutiveHyphenLimit = 2,
    //      DecimalSymbol = ".",
    //      DefaultImageDpi = 300,
    //      DefaultTableStyle = "TableGrid",
    //      DefaultTabStop = 720,
    //      DiscardImageEditingData = true,
    //      DisplayBackgroundShape = false,
    //      DisplayHorizontalDrawingGrid = 5,
    //      DisplayVerticalDrawingGrid = 10,
    //      DoNotAutoCompressPictures = true,
    //      DoNotDemarcateInvalidXml = false,
    //      DoNotDisplayPageBoundaries = true,
    //      DoNotHyphenateCaps = false,
    //      DoNotIncludeSubdocsInStats = true,
    //      DoNotShadeFormData = false,
    //      DoNotTrackFormatting = true,
    //      DoNotTrackMoves = false,
    //      DoNotUseMarginsForDrawingGridOrigin = true,
    //      DoNotValidateAgainstSchema = false,
    //      EmbedSystemFonts = true,
    //      EmbedTrueTypeFonts = false,
    //      EvenAndOddHeaders = true,
    //      ForceUpgrade = false,
    //      FormsDesign = true,
    //      GutterAtTop = false,
    //      HideGrammaticalErrors = true,
    //      HideSpellingErrors = false,
    //      HyphenationZone = new Twips(360),
    //      IgnoreMixedContent = true,
    //      LinkStyles = false,
    //      ListSeparator = ";",
    //      MirrorMargins = true,
    //      NoPunctuationKerning = false,
    //      PrintFormsData = true,
    //      PrintFractionalCharacterWidth = false,
    //      PrintPostScriptOverText = true,
    //      PrintTwoOnOne = false,
    //      RemoveDateAndTime = true,
    //      RemovePersonalInformation = false,
    //      SaveFormsData = false,
    //      SaveInvalidXml = false,
    //      SavePreviewPicture = false,
    //      SaveSubsetFonts = false,
    //      SaveXmlDataOnly = false,
    //      ShowEnvelope = false,
    //      ShowXmlTags = true,
    //      StrictFirstAndLastChars = false,
    //      StylePaneSortMethods = StylePaneSortMethods.Typeface,
    //      SummaryLength = new Percent(50),
    //      TrackRevisions = false,
    //      UICompatibleWith97To2003 = false,
    //      UpdateFieldsOnOpen = false,
    //      UseXsltWhenSaving = false,
    //      View = ViewType.PrintView,
    //      Zoom = "100%", // PresetZoom.FullPage,

    //      ActiveWritingStyles =
    //      [
    //        new ActiveWritingStyle
    //        {
    //          ApplicationName = "MyApp",
    //          CheckStyle = true,
    //          DllVersion = 1,
    //          VendorID = 1234,
    //          Language = "en-US",
    //          NaturalLanguageGrammarCheck = true
    //        },
    //        new ActiveWritingStyle
    //        {
    //          ApplicationName = "AnotherApp",
    //          CheckStyle = false,
    //          DllVersion = 2,
    //          VendorID = 5678,
    //          Language = "fr-FR",
    //          NaturalLanguageGrammarCheck = false
    //        }
    //      ],

    //      AttachedSchemas = new AttachedSchemas([
    //        new AttachedSchema
    //        {
    //          Uri = "http://schemas.microsoft.com/office/word/2010/wordml",
    //        },
    //        new AttachedSchema
    //        {
    //          Uri = "http://schemas.microsoft.com/office/word/2012/wordml",
    //        }
    //      ]),

    //      AttachedTemplate = new AttachedTemplate("file:///C:/Users/qhta1/AppData/Roaming/Microsoft/Templates/NormalEmail.dotm\" TargetMode=\"External\"/"),
    //      Captions = new Captions
    //      {
    //        CaptionDefinitions = new CaptionDefinitions([
    //          new CaptionDefinition
    //          {
    //            Name = "Figure",
    //            Position = CaptionPosition.Below,
    //            ChapterNumber = true,
    //            NumberFormat = NumberFormat.Decimal,
    //          },
    //          new CaptionDefinition
    //          {
    //            Name = "Table",
    //            Position = CaptionPosition.Above,
    //            ChapterNumber = false,
    //            NoLabel = true,
    //          }
    //        ]),
    //        AutoCaptions = new AutoCaptions([
    //          new AutoCaption
    //          {
    //            Name = "Figure",
    //            Caption = "Fig.",
    //          },
    //          new AutoCaption
    //          {
    //            Name = "Table",
    //            Caption = "Tab.",
    //          }
    //        ])
    //      },

    //      Compatibility = new CompatibilitySettings
    //      {
    //        UseSingleBorderForContiguousCells = true,
    //        WordPerfectJustification = true,
    //        NoTabHangIndent = true,
    //        NoLeading = true,
    //        SpaceForUnderline = true,
    //        NoColumnBalance = true,
    //        BalanceSingleByteDoubleByteWidth = true,
    //        NoExtraLineSpacing = true,
    //        DoNotLeaveBackslashAlone = true,
    //        UnderlineTrailingSpaces = true,
    //        DoNotExpandShiftReturn = true,
    //        SpacingInWholePoints = true,
    //        LineWrapLikeWord6 = true,
    //        PrintBodyTextBeforeHeader = true,
    //        PrintColorBlackWhite = true,
    //        WordPerfectSpaceWidth = true,
    //        ShowBreaksInFrames = true,
    //        SubFontBySize = true,
    //        SuppressBottomSpacing = true,
    //        SuppressTopSpacing = true,
    //        SuppressSpacingAtTopOfPage = true,
    //        SuppressTopSpacingWordPerfect = true,
    //        SuppressSpacingBeforeAfterPageBreak = true,
    //        SwapBordersFacingPages = true,
    //        ConvertMailMergeEscape = true,
    //        TruncateFontHeightsLikeWordPerfect = true,
    //        MacWordSmallCaps = true,
    //        UsePrinterMetrics = true,
    //        DoNotSuppressParagraphBorders = true,
    //        WrapTrailSpaces = true,
    //        FootnoteLayoutLikeWord8 = true,
    //        ShapeLayoutLikeWord8 = true,
    //        AlignTablesRowByRow = true,
    //        ForgetLastTabAlignment = true,
    //        AdjustLineHeightInTable = true,
    //        AutoSpaceLikeWord95 = true,
    //        NoSpaceRaiseLower = true,
    //        DoNotUseHTMLParagraphAutoSpacing = true,
    //        LayoutRawTableWidth = true,
    //        LayoutTableRowsApart = true,
    //        UseWord97LineBreakRules = true,
    //        DoNotBreakWrappedTables = true,
    //        DoNotSnapToGridInCell = true,
    //        SelectFieldWithFirstOrLastChar = true,
    //        ApplyBreakingRules = true,
    //        DoNotWrapTextWithPunctuation = true,
    //        DoNotUseEastAsianBreakRules = true,
    //        UseWord2002TableStyleRules = true,
    //        GrowAutofit = true,
    //        UseFarEastLayout = true,
    //        UseNormalStyleForList = true,
    //        DoNotUseIndentAsNumberingTabStop = true,
    //        UseAltKinsokuLineBreakRules = true,
    //        AllowSpaceOfSameStyleInTable = true,
    //        DoNotSuppressIndentation = true,
    //        DoNotAutofitConstrainedTables = true,
    //        AutofitToFirstFixedWidthCell = true,
    //        UnderlineTabInNumberingList = true,
    //        DisplayHangulFixedWidth = true,
    //        SplitPageBreakAndParagraphMark = true,
    //        DoNotVerticallyAlignCellWithShape = true,
    //        DoNotBreakConstrainedForcedTable = true,
    //        DoNotVerticallyAlignInTextBox = true,
    //        UseAnsiKerningPairs = true,
    //        CachedColumnBalance = true,
    //      }
    //    };
    //}

    /// <summary>
    /// Updates the provided <see cref="DocumentSettings"/> instance with new test data and adds a compatibility setting.
    /// </summary>
    /// <param name="document">The document in which to update the settings.</param>
    /// <param name="data">The document settings to update.</param>
    /// <returns>The updated document settings.</returns>
    protected override DocumentSettings UpdateDataInDocument(Document document, DocumentSettings data)
    {
      TestHelper.UpdateTestData(data);
      data.Add(new CompatibilitySetting { Name = "CompatibilityMode", Val = "value" });
      return data;
    }

    /// <summary>
    /// Retrieves the XML representation of the document settings from the specified WordprocessingML document.
    /// </summary>
    /// <remarks>The returned XML represents the settings part of the WordprocessingML document, which may
    /// include configuration such as compatibility options, protection settings, and other document-level properties.
    /// Ensure that the document contains a settings part; otherwise, a NullReferenceException may occur.</remarks>
    /// <param name="document">The document from which to extract the settings as Open XML. Must contain a valid WordprocessingDocument with
    /// settings part present.</param>
    /// <returns>A string containing the outer XML of the document settings part.</returns>
    protected override string GetOpenXmlFromDocument(Document document)
    {
      return document.WordprocessingDocument!.GetDocumentSettings()!.OuterXml;
    }
  }
}