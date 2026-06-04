namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a compatibility option.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcompatibility?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdCompatibility))]
public enum Compatibility
{
  /// <summary>
  /// Don't add automatic tab stop for hanging indent.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdNoTabHangIndent))]
  NoTabHangIndent = 1,
  /// <summary>
  /// Don't add extra space for raised/lowered characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdNoSpaceRaiseLower))]
  NoSpaceRaiseLower = 2,
  /// <summary>
  /// Print colors as black on noncolor printers.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdPrintColBlack))]
  PrintColBlack = 3,
  /// <summary>
  /// Wrap trailing spaces to next line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdWrapTrailSpaces))]
  WrapTrailSpaces = 4,
  /// <summary>
  /// Don't balance columns for continuous section starts.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdNoColumnBalance))]
  NoColumnBalance = 5,
  /// <summary>
  /// Treat " as "" in mail merge data sources.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdConvMailMergeEsc))]
  ConvMailMergeEsc = 6,
  /// <summary>
  /// Suppress Space Before after a hard page or column break.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdSuppressSpBfAfterPgBrk))]
  SuppressSpBfAfterPgBrk = 7,
  /// <summary>
  /// Suppress extra line spacing at top of page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdSuppressTopSpacing))]
  SuppressTopSpacing = 8,
  /// <summary>
  /// Combine table borders like Word 5.x for the Macintosh.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdOrigWordTableRules))]
  OrigWordTableRules = 9,
  /// <summary>
  /// Don't blank the area behind metafile pictures.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdTransparentMetafiles))]
  TransparentMetafiles = 10,
  /// <summary>
  /// Show hard page or column breaks in frames.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdShowBreaksInFrames))]
  ShowBreaksInFrames = 11,
  /// <summary>
  /// Swap left and right borders on odd facing pages.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdSwapBordersFacingPages))]
  SwapBordersFacingPages = 12,
  /// <summary>
  /// Convert backslash characters into yen signs.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdLeaveBackslashAlone))]
  LeaveBackslashAlone = 13,
  /// <summary>
  /// Don't expand character spaces on the line ending Shift+Return.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdExpandShiftReturn))]
  ExpandShiftReturn = 14,
  /// <summary>
  /// Draw underline on trailing spaces.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdDontULTrailSpace))]
  DontULTrailSpace = 15,
  /// <summary>
  /// Balance SBCS characters and DBCS characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdDontBalanceSingleByteDoubleByteWidth))]
  DontBalanceSingleByteDoubleByteWidth = 16,
  /// <summary>
  /// Suppress extra line spacing at top of page like Word 5.x for the Macintosh.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdSuppressTopSpacingMac5))]
  SuppressTopSpacingMac5 = 17,
  /// <summary>
  /// Expand/condense by whole number of points.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdSpacingInWholePoints))]
  SpacingInWholePoints = 18,
  /// <summary>
  /// Print body text before header/footer.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdPrintBodyTextBeforeHeader))]
  PrintBodyTextBeforeHeader = 19,
  /// <summary>
  /// Don't add leading (extra space) between rows of text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdNoLeading))]
  NoLeading = 20,
  /// <summary>
  /// Add space for underline.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdNoSpaceForUL))]
  NoSpaceForUL = 21,
  /// <summary>
  /// Use larger small caps like Word 5.x for the Macintosh.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdMWSmallCaps))]
  MWSmallCaps = 22,
  /// <summary>
  /// Suppress extra line spacing like WordPerfect 5.x.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdNoExtraLineSpacing))]
  NoExtraLineSpacing = 23,
  /// <summary>
  /// Truncate font height.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdTruncateFontHeight))]
  TruncateFontHeight = 24,
  /// <summary>
  /// Substitute fonts based on font size.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdSubFontBySize))]
  SubFontBySize = 25,
  /// <summary>
  /// Use printer metrics to lay out document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdUsePrinterMetrics))]
  UsePrinterMetrics = 26,
  /// <summary>
  /// Use Word 6.x/95 border rules.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdWW6BorderRules))]
  WW6BorderRules = 27,
  /// <summary>
  /// Don't center "exact line height" lines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdExactOnTop))]
  ExactOnTop = 28,
  /// <summary>
  /// Suppress extra line spacing at bottom of page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdSuppressBottomSpacing))]
  SuppressBottomSpacing = 29,
  /// <summary>
  /// Set the width of a space like WordPerfect 5.x.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdWPSpaceWidth))]
  WPSpaceWidth = 30,
  /// <summary>
  /// Do full justification like WordPerfect 6.x for Windows.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdWPJustification))]
  WPJustification = 31,
  /// <summary>
  /// Line wrap like Word 6.0.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdLineWrapLikeWord6))]
  LineWrapLikeWord6 = 32,
  /// <summary>
  /// Lay out autoshapes like Word 97.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdShapeLayoutLikeWW8))]
  ShapeLayoutLikeWW8 = 33,
  /// <summary>
  /// Lay out footnotes like Word 6.x/95/97.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdFootnoteLayoutLikeWW8))]
  FootnoteLayoutLikeWW8 = 34,
  /// <summary>
  /// Don't use HTML paragraph auto spacing.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdDontUseHTMLParagraphAutoSpacing))]
  DontUseHTMLParagraphAutoSpacing = 35,
  /// <summary>
  /// Adjust line height to grid height in the table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdDontAdjustLineHeightInTable))]
  DontAdjustLineHeightInTable = 36,
  /// <summary>
  /// Forget last tab alignment.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdForgetLastTabAlignment))]
  ForgetLastTabAlignment = 37,
  /// <summary>
  /// Autospace like Word 95.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdAutospaceLikeWW7))]
  AutospaceLikeWW7 = 38,
  /// <summary>
  /// Align table rows independently.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdAlignTablesRowByRow))]
  AlignTablesRowByRow = 39,
  /// <summary>
  /// Lay out tables with raw width.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdLayoutRawTableWidth))]
  LayoutRawTableWidth = 40,
  /// <summary>
  /// Allow table rows to lay out apart.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdLayoutTableRowsApart))]
  LayoutTableRowsApart = 41,
  /// <summary>
  /// Use Word 97 line breaking rules for Asian text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdUseWord97LineBreakingRules))]
  UseWord97LineBreakingRules = 42,
  /// <summary>
  /// Don't break wrapped tables across pages.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdDontBreakWrappedTables))]
  DontBreakWrappedTables = 43,
  /// <summary>
  /// Don't snap text to grid inside table with inline objects.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdDontSnapTextToGridInTableWithObjects))]
  DontSnapTextToGridInTableWithObjects = 44,
  /// <summary>
  /// Select entire field with first or last character.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdSelectFieldWithFirstOrLastCharacter))]
  SelectFieldWithFirstOrLastCharacter = 45,
  /// <summary>
  /// Use line-breaking rules.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdApplyBreakingRules))]
  ApplyBreakingRules = 46,
  /// <summary>
  /// Don't allow hanging punctuation with character grid.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdDontWrapTextWithPunctuation))]
  DontWrapTextWithPunctuation = 47,
  /// <summary>
  /// Don't use Asian rules for line breaks with character grid.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdDontUseAsianBreakRulesInGrid))]
  DontUseAsianBreakRulesInGrid = 48,
  /// <summary>
  /// Use Word 2002 table style rules.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdUseWord2002TableStyleRules))]
  UseWord2002TableStyleRules = 49,
  /// <summary>
  /// Allow tables to extend into margins.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdGrowAutofit))]
  GrowAutofit = 50,
  /// <summary>
  /// Use the Normal style instead of the List Paragraph style for bulleted or numbered lists.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdUseNormalStyleForList))]
  UseNormalStyleForList = 51,
  /// <summary>
  /// Do not use hanging indent as tab stop for bullets and numbering.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdDontUseIndentAsNumberingTabStop))]
  DontUseIndentAsNumberingTabStop = 52,
  /// <summary>
  /// Use Word 2003 hanging-punctuation rules in Asian langauges.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdFELineBreak11))]
  FELineBreak11 = 53,
  /// <summary>
  /// Allow space between paragraphs of the same style in a table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdAllowSpaceOfSameStyleInTable))]
  AllowSpaceOfSameStyleInTable = 54,
  /// <summary>
  /// Use Word 2003 indent rules for text next to wrapped objects.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdWW11IndentRules))]
  WW11IndentRules = 55,
  /// <summary>
  /// Do not autofit tables next to wrapped objects.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdDontAutofitConstrainedTables))]
  DontAutofitConstrainedTables = 56,
  /// <summary>
  /// Use Microsoft Office Word 2003 table autofit rules.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdAutofitLikeWW11))]
  AutofitLikeWW11 = 57,
  /// <summary>
  /// Underline the tab character between the number and the text in numbered lists.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdUnderlineTabInNumList))]
  UnderlineTabInNumList = 58,
  /// <summary>
  /// Do not use proportional width for Korean characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdHangulWidthLikeWW11))]
  HangulWidthLikeWW11 = 59,
  /// <summary>
  /// Split apart page break and paragraph mark.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdSplitPgBreakAndParaMark))]
  SplitPgBreakAndParaMark = 60,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdDontVertAlignCellWithShape))]
  DontVertAlignCellWithShape = 61,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdDontBreakConstrainedForcedTables))]
  DontBreakConstrainedForcedTables = 62,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdDontVertAlignInTextbox))]
  DontVertAlignInTextbox = 63,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdWord11KerningPairs))]
  Word11KerningPairs = 64,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdCachedColBalance))]
  CachedColBalance = 65,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdDisableOTKerning))]
  DisableOTKerning = 66,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdFlipMirrorIndents))]
  FlipMirrorIndents = 67,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdDontOverrideTableStyleFontSzAndJustification))]
  DontOverrideTableStyleFontSzAndJustification = 68,
  /// <summary>
  /// Use Word 2010 table style rules.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibility.wdUseWord2010TableStyleRules))]
  UseWord2010TableStyleRules = 69
}
