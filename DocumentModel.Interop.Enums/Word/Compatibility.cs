namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a compatibility option.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcompatibility?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdCompatibility")]
public enum Compatibility
{
  /// <summary>
  /// Don't add automatic tab stop for hanging indent.
  /// </summary>
  [WordInteropEnumValue("wdNoTabHangIndent")]
  NoTabHangIndent = 1,
  /// <summary>
  /// Don't add extra space for raised/lowered characters.
  /// </summary>
  [WordInteropEnumValue("wdNoSpaceRaiseLower")]
  NoSpaceRaiseLower = 2,
  /// <summary>
  /// Print colors as black on noncolor printers.
  /// </summary>
  [WordInteropEnumValue("wdPrintColBlack")]
  PrintColBlack = 3,
  /// <summary>
  /// Wrap trailing spaces to next line.
  /// </summary>
  [WordInteropEnumValue("wdWrapTrailSpaces")]
  WrapTrailSpaces = 4,
  /// <summary>
  /// Don't balance columns for continuous section starts.
  /// </summary>
  [WordInteropEnumValue("wdNoColumnBalance")]
  NoColumnBalance = 5,
  /// <summary>
  /// Treat " as "" in mail merge data sources.
  /// </summary>
  [WordInteropEnumValue("wdConvMailMergeEsc")]
  ConvMailMergeEsc = 6,
  /// <summary>
  /// Suppress Space Before after a hard page or column break.
  /// </summary>
  [WordInteropEnumValue("wdSuppressSpBfAfterPgBrk")]
  SuppressSpBfAfterPgBrk = 7,
  /// <summary>
  /// Suppress extra line spacing at top of page.
  /// </summary>
  [WordInteropEnumValue("wdSuppressTopSpacing")]
  SuppressTopSpacing = 8,
  /// <summary>
  /// Combine table borders like Word 5.x for the Macintosh.
  /// </summary>
  [WordInteropEnumValue("wdOrigWordTableRules")]
  OrigWordTableRules = 9,
  /// <summary>
  /// Don't blank the area behind metafile pictures.
  /// </summary>
  [WordInteropEnumValue("wdTransparentMetafiles")]
  TransparentMetafiles = 10,
  /// <summary>
  /// Show hard page or column breaks in frames.
  /// </summary>
  [WordInteropEnumValue("wdShowBreaksInFrames")]
  ShowBreaksInFrames = 11,
  /// <summary>
  /// Swap left and right borders on odd facing pages.
  /// </summary>
  [WordInteropEnumValue("wdSwapBordersFacingPages")]
  SwapBordersFacingPages = 12,
  /// <summary>
  /// Convert backslash characters into yen signs.
  /// </summary>
  [WordInteropEnumValue("wdLeaveBackslashAlone")]
  LeaveBackslashAlone = 13,
  /// <summary>
  /// Don't expand character spaces on the line ending Shift+Return.
  /// </summary>
  [WordInteropEnumValue("wdExpandShiftReturn")]
  ExpandShiftReturn = 14,
  /// <summary>
  /// Draw underline on trailing spaces.
  /// </summary>
  [WordInteropEnumValue("wdDontULTrailSpace")]
  DontULTrailSpace = 15,
  /// <summary>
  /// Balance SBCS characters and DBCS characters.
  /// </summary>
  [WordInteropEnumValue("wdDontBalanceSingleByteDoubleByteWidth")]
  DontBalanceSingleByteDoubleByteWidth = 16,
  /// <summary>
  /// Suppress extra line spacing at top of page like Word 5.x for the Macintosh.
  /// </summary>
  [WordInteropEnumValue("wdSuppressTopSpacingMac5")]
  SuppressTopSpacingMac5 = 17,
  /// <summary>
  /// Expand/condense by whole number of points.
  /// </summary>
  [WordInteropEnumValue("wdSpacingInWholePoints")]
  SpacingInWholePoints = 18,
  /// <summary>
  /// Print body text before header/footer.
  /// </summary>
  [WordInteropEnumValue("wdPrintBodyTextBeforeHeader")]
  PrintBodyTextBeforeHeader = 19,
  /// <summary>
  /// Don't add leading (extra space) between rows of text.
  /// </summary>
  [WordInteropEnumValue("wdNoLeading")]
  NoLeading = 20,
  /// <summary>
  /// Add space for underline.
  /// </summary>
  [WordInteropEnumValue("wdNoSpaceForUL")]
  NoSpaceForUL = 21,
  /// <summary>
  /// Use larger small caps like Word 5.x for the Macintosh.
  /// </summary>
  [WordInteropEnumValue("wdMWSmallCaps")]
  MWSmallCaps = 22,
  /// <summary>
  /// Suppress extra line spacing like WordPerfect 5.x.
  /// </summary>
  [WordInteropEnumValue("wdNoExtraLineSpacing")]
  NoExtraLineSpacing = 23,
  /// <summary>
  /// Truncate font height.
  /// </summary>
  [WordInteropEnumValue("wdTruncateFontHeight")]
  TruncateFontHeight = 24,
  /// <summary>
  /// Substitute fonts based on font size.
  /// </summary>
  [WordInteropEnumValue("wdSubFontBySize")]
  SubFontBySize = 25,
  /// <summary>
  /// Use printer metrics to lay out document.
  /// </summary>
  [WordInteropEnumValue("wdUsePrinterMetrics")]
  UsePrinterMetrics = 26,
  /// <summary>
  /// Use Word 6.x/95 border rules.
  /// </summary>
  [WordInteropEnumValue("wdWW6BorderRules")]
  WW6BorderRules = 27,
  /// <summary>
  /// Don't center "exact line height" lines.
  /// </summary>
  [WordInteropEnumValue("wdExactOnTop")]
  ExactOnTop = 28,
  /// <summary>
  /// Suppress extra line spacing at bottom of page.
  /// </summary>
  [WordInteropEnumValue("wdSuppressBottomSpacing")]
  SuppressBottomSpacing = 29,
  /// <summary>
  /// Set the width of a space like WordPerfect 5.x.
  /// </summary>
  [WordInteropEnumValue("wdWPSpaceWidth")]
  WPSpaceWidth = 30,
  /// <summary>
  /// Do full justification like WordPerfect 6.x for Windows.
  /// </summary>
  [WordInteropEnumValue("wdWPJustification")]
  WPJustification = 31,
  /// <summary>
  /// Line wrap like Word 6.0.
  /// </summary>
  [WordInteropEnumValue("wdLineWrapLikeWord6")]
  LineWrapLikeWord6 = 32,
  /// <summary>
  /// Lay out autoshapes like Word 97.
  /// </summary>
  [WordInteropEnumValue("wdShapeLayoutLikeWW8")]
  ShapeLayoutLikeWW8 = 33,
  /// <summary>
  /// Lay out footnotes like Word 6.x/95/97.
  /// </summary>
  [WordInteropEnumValue("wdFootnoteLayoutLikeWW8")]
  FootnoteLayoutLikeWW8 = 34,
  /// <summary>
  /// Don't use HTML paragraph auto spacing.
  /// </summary>
  [WordInteropEnumValue("wdDontUseHTMLParagraphAutoSpacing")]
  DontUseHTMLParagraphAutoSpacing = 35,
  /// <summary>
  /// Adjust line height to grid height in the table.
  /// </summary>
  [WordInteropEnumValue("wdDontAdjustLineHeightInTable")]
  DontAdjustLineHeightInTable = 36,
  /// <summary>
  /// Forget last tab alignment.
  /// </summary>
  [WordInteropEnumValue("wdForgetLastTabAlignment")]
  ForgetLastTabAlignment = 37,
  /// <summary>
  /// Autospace like Word 95.
  /// </summary>
  [WordInteropEnumValue("wdAutospaceLikeWW7")]
  AutospaceLikeWW7 = 38,
  /// <summary>
  /// Align table rows independently.
  /// </summary>
  [WordInteropEnumValue("wdAlignTablesRowByRow")]
  AlignTablesRowByRow = 39,
  /// <summary>
  /// Lay out tables with raw width.
  /// </summary>
  [WordInteropEnumValue("wdLayoutRawTableWidth")]
  LayoutRawTableWidth = 40,
  /// <summary>
  /// Allow table rows to lay out apart.
  /// </summary>
  [WordInteropEnumValue("wdLayoutTableRowsApart")]
  LayoutTableRowsApart = 41,
  /// <summary>
  /// Use Word 97 line breaking rules for Asian text.
  /// </summary>
  [WordInteropEnumValue("wdUseWord97LineBreakingRules")]
  UseWord97LineBreakingRules = 42,
  /// <summary>
  /// Don't break wrapped tables across pages.
  /// </summary>
  [WordInteropEnumValue("wdDontBreakWrappedTables")]
  DontBreakWrappedTables = 43,
  /// <summary>
  /// Don't snap text to grid inside table with inline objects.
  /// </summary>
  [WordInteropEnumValue("wdDontSnapTextToGridInTableWithObjects")]
  DontSnapTextToGridInTableWithObjects = 44,
  /// <summary>
  /// Select entire field with first or last character.
  /// </summary>
  [WordInteropEnumValue("wdSelectFieldWithFirstOrLastCharacter")]
  SelectFieldWithFirstOrLastCharacter = 45,
  /// <summary>
  /// Use line-breaking rules.
  /// </summary>
  [WordInteropEnumValue("wdApplyBreakingRules")]
  ApplyBreakingRules = 46,
  /// <summary>
  /// Don't allow hanging punctuation with character grid.
  /// </summary>
  [WordInteropEnumValue("wdDontWrapTextWithPunctuation")]
  DontWrapTextWithPunctuation = 47,
  /// <summary>
  /// Don't use Asian rules for line breaks with character grid.
  /// </summary>
  [WordInteropEnumValue("wdDontUseAsianBreakRulesInGrid")]
  DontUseAsianBreakRulesInGrid = 48,
  /// <summary>
  /// Use Word 2002 table style rules.
  /// </summary>
  [WordInteropEnumValue("wdUseWord2002TableStyleRules")]
  UseWord2002TableStyleRules = 49,
  /// <summary>
  /// Allow tables to extend into margins.
  /// </summary>
  [WordInteropEnumValue("wdGrowAutofit")]
  GrowAutofit = 50,
  /// <summary>
  /// Use the Normal style instead of the List Paragraph style for bulleted or numbered lists.
  /// </summary>
  [WordInteropEnumValue("wdUseNormalStyleForList")]
  UseNormalStyleForList = 51,
  /// <summary>
  /// Do not use hanging indent as tab stop for bullets and numbering.
  /// </summary>
  [WordInteropEnumValue("wdDontUseIndentAsNumberingTabStop")]
  DontUseIndentAsNumberingTabStop = 52,
  /// <summary>
  /// Use Word 2003 hanging-punctuation rules in Asian langauges.
  /// </summary>
  [WordInteropEnumValue("wdFELineBreak11")]
  FELineBreak11 = 53,
  /// <summary>
  /// Allow space between paragraphs of the same style in a table.
  /// </summary>
  [WordInteropEnumValue("wdAllowSpaceOfSameStyleInTable")]
  AllowSpaceOfSameStyleInTable = 54,
  /// <summary>
  /// Use Word 2003 indent rules for text next to wrapped objects.
  /// </summary>
  [WordInteropEnumValue("wdWW11IndentRules")]
  WW11IndentRules = 55,
  /// <summary>
  /// Do not autofit tables next to wrapped objects.
  /// </summary>
  [WordInteropEnumValue("wdDontAutofitConstrainedTables")]
  DontAutofitConstrainedTables = 56,
  /// <summary>
  /// Use Microsoft Office Word 2003 table autofit rules.
  /// </summary>
  [WordInteropEnumValue("wdAutofitLikeWW11")]
  AutofitLikeWW11 = 57,
  /// <summary>
  /// Underline the tab character between the number and the text in numbered lists.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineTabInNumList")]
  UnderlineTabInNumList = 58,
  /// <summary>
  /// Do not use proportional width for Korean characters.
  /// </summary>
  [WordInteropEnumValue("wdHangulWidthLikeWW11")]
  HangulWidthLikeWW11 = 59,
  /// <summary>
  /// Split apart page break and paragraph mark.
  /// </summary>
  [WordInteropEnumValue("wdSplitPgBreakAndParaMark")]
  SplitPgBreakAndParaMark = 60,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdDontVertAlignCellWithShape")]
  DontVertAlignCellWithShape = 61,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdDontBreakConstrainedForcedTables")]
  DontBreakConstrainedForcedTables = 62,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdDontVertAlignInTextbox")]
  DontVertAlignInTextbox = 63,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdWord11KerningPairs")]
  Word11KerningPairs = 64,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdCachedColBalance")]
  CachedColBalance = 65,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdDisableOTKerning")]
  DisableOTKerning = 66,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdFlipMirrorIndents")]
  FlipMirrorIndents = 67,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdDontOverrideTableStyleFontSzAndJustification")]
  DontOverrideTableStyleFontSzAndJustification = 68,
  /// <summary>
  /// Use Word 2010 table style rules.
  /// </summary>
  [WordInteropEnumValue("wdUseWord2010TableStyleRules")]
  UseWord2010TableStyleRules = 69
}
