namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a compatibility option.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcompatibility?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdCompatibility")]
public enum Compatibility
{
  /// <summary>
  /// Don't add automatic tab stop for hanging indent.
  /// </summary>
  [InteropEnumValue("wdNoTabHangIndent")]
  NoTabHangIndent = 1,
  /// <summary>
  /// Don't add extra space for raised/lowered characters.
  /// </summary>
  [InteropEnumValue("wdNoSpaceRaiseLower")]
  NoSpaceRaiseLower = 2,
  /// <summary>
  /// Print colors as black on noncolor printers.
  /// </summary>
  [InteropEnumValue("wdPrintColBlack")]
  PrintColBlack = 3,
  /// <summary>
  /// Wrap trailing spaces to next line.
  /// </summary>
  [InteropEnumValue("wdWrapTrailSpaces")]
  WrapTrailSpaces = 4,
  /// <summary>
  /// Don't balance columns for continuous section starts.
  /// </summary>
  [InteropEnumValue("wdNoColumnBalance")]
  NoColumnBalance = 5,
  /// <summary>
  /// Treat " as "" in mail merge data sources.
  /// </summary>
  [InteropEnumValue("wdConvMailMergeEsc")]
  ConvMailMergeEsc = 6,
  /// <summary>
  /// Suppress Space Before after a hard page or column break.
  /// </summary>
  [InteropEnumValue("wdSuppressSpBfAfterPgBrk")]
  SuppressSpBfAfterPgBrk = 7,
  /// <summary>
  /// Suppress extra line spacing at top of page.
  /// </summary>
  [InteropEnumValue("wdSuppressTopSpacing")]
  SuppressTopSpacing = 8,
  /// <summary>
  /// Combine table borders like Word 5.x for the Macintosh.
  /// </summary>
  [InteropEnumValue("wdOrigWordTableRules")]
  OrigWordTableRules = 9,
  /// <summary>
  /// Don't blank the area behind metafile pictures.
  /// </summary>
  [InteropEnumValue("wdTransparentMetafiles")]
  TransparentMetafiles = 10,
  /// <summary>
  /// Show hard page or column breaks in frames.
  /// </summary>
  [InteropEnumValue("wdShowBreaksInFrames")]
  ShowBreaksInFrames = 11,
  /// <summary>
  /// Swap left and right borders on odd facing pages.
  /// </summary>
  [InteropEnumValue("wdSwapBordersFacingPages")]
  SwapBordersFacingPages = 12,
  /// <summary>
  /// Convert backslash characters into yen signs.
  /// </summary>
  [InteropEnumValue("wdLeaveBackslashAlone")]
  LeaveBackslashAlone = 13,
  /// <summary>
  /// Don't expand character spaces on the line ending Shift+Return.
  /// </summary>
  [InteropEnumValue("wdExpandShiftReturn")]
  ExpandShiftReturn = 14,
  /// <summary>
  /// Draw underline on trailing spaces.
  /// </summary>
  [InteropEnumValue("wdDontULTrailSpace")]
  DontULTrailSpace = 15,
  /// <summary>
  /// Balance SBCS characters and DBCS characters.
  /// </summary>
  [InteropEnumValue("wdDontBalanceSingleByteDoubleByteWidth")]
  DontBalanceSingleByteDoubleByteWidth = 16,
  /// <summary>
  /// Suppress extra line spacing at top of page like Word 5.x for the Macintosh.
  /// </summary>
  [InteropEnumValue("wdSuppressTopSpacingMac5")]
  SuppressTopSpacingMac5 = 17,
  /// <summary>
  /// Expand/condense by whole number of points.
  /// </summary>
  [InteropEnumValue("wdSpacingInWholePoints")]
  SpacingInWholePoints = 18,
  /// <summary>
  /// Print body text before header/footer.
  /// </summary>
  [InteropEnumValue("wdPrintBodyTextBeforeHeader")]
  PrintBodyTextBeforeHeader = 19,
  /// <summary>
  /// Don't add leading (extra space) between rows of text.
  /// </summary>
  [InteropEnumValue("wdNoLeading")]
  NoLeading = 20,
  /// <summary>
  /// Add space for underline.
  /// </summary>
  [InteropEnumValue("wdNoSpaceForUL")]
  NoSpaceForUL = 21,
  /// <summary>
  /// Use larger small caps like Word 5.x for the Macintosh.
  /// </summary>
  [InteropEnumValue("wdMWSmallCaps")]
  MWSmallCaps = 22,
  /// <summary>
  /// Suppress extra line spacing like WordPerfect 5.x.
  /// </summary>
  [InteropEnumValue("wdNoExtraLineSpacing")]
  NoExtraLineSpacing = 23,
  /// <summary>
  /// Truncate font height.
  /// </summary>
  [InteropEnumValue("wdTruncateFontHeight")]
  TruncateFontHeight = 24,
  /// <summary>
  /// Substitute fonts based on font size.
  /// </summary>
  [InteropEnumValue("wdSubFontBySize")]
  SubFontBySize = 25,
  /// <summary>
  /// Use printer metrics to lay out document.
  /// </summary>
  [InteropEnumValue("wdUsePrinterMetrics")]
  UsePrinterMetrics = 26,
  /// <summary>
  /// Use Word 6.x/95 border rules.
  /// </summary>
  [InteropEnumValue("wdWW6BorderRules")]
  WW6BorderRules = 27,
  /// <summary>
  /// Don't center "exact line height" lines.
  /// </summary>
  [InteropEnumValue("wdExactOnTop")]
  ExactOnTop = 28,
  /// <summary>
  /// Suppress extra line spacing at bottom of page.
  /// </summary>
  [InteropEnumValue("wdSuppressBottomSpacing")]
  SuppressBottomSpacing = 29,
  /// <summary>
  /// Set the width of a space like WordPerfect 5.x.
  /// </summary>
  [InteropEnumValue("wdWPSpaceWidth")]
  WPSpaceWidth = 30,
  /// <summary>
  /// Do full justification like WordPerfect 6.x for Windows.
  /// </summary>
  [InteropEnumValue("wdWPJustification")]
  WPJustification = 31,
  /// <summary>
  /// Line wrap like Word 6.0.
  /// </summary>
  [InteropEnumValue("wdLineWrapLikeWord6")]
  LineWrapLikeWord6 = 32,
  /// <summary>
  /// Lay out autoshapes like Word 97.
  /// </summary>
  [InteropEnumValue("wdShapeLayoutLikeWW8")]
  ShapeLayoutLikeWW8 = 33,
  /// <summary>
  /// Lay out footnotes like Word 6.x/95/97.
  /// </summary>
  [InteropEnumValue("wdFootnoteLayoutLikeWW8")]
  FootnoteLayoutLikeWW8 = 34,
  /// <summary>
  /// Don't use HTML paragraph auto spacing.
  /// </summary>
  [InteropEnumValue("wdDontUseHTMLParagraphAutoSpacing")]
  DontUseHTMLParagraphAutoSpacing = 35,
  /// <summary>
  /// Adjust line height to grid height in the table.
  /// </summary>
  [InteropEnumValue("wdDontAdjustLineHeightInTable")]
  DontAdjustLineHeightInTable = 36,
  /// <summary>
  /// Forget last tab alignment.
  /// </summary>
  [InteropEnumValue("wdForgetLastTabAlignment")]
  ForgetLastTabAlignment = 37,
  /// <summary>
  /// Autospace like Word 95.
  /// </summary>
  [InteropEnumValue("wdAutospaceLikeWW7")]
  AutospaceLikeWW7 = 38,
  /// <summary>
  /// Align table rows independently.
  /// </summary>
  [InteropEnumValue("wdAlignTablesRowByRow")]
  AlignTablesRowByRow = 39,
  /// <summary>
  /// Lay out tables with raw width.
  /// </summary>
  [InteropEnumValue("wdLayoutRawTableWidth")]
  LayoutRawTableWidth = 40,
  /// <summary>
  /// Allow table rows to lay out apart.
  /// </summary>
  [InteropEnumValue("wdLayoutTableRowsApart")]
  LayoutTableRowsApart = 41,
  /// <summary>
  /// Use Word 97 line breaking rules for Asian text.
  /// </summary>
  [InteropEnumValue("wdUseWord97LineBreakingRules")]
  UseWord97LineBreakingRules = 42,
  /// <summary>
  /// Don't break wrapped tables across pages.
  /// </summary>
  [InteropEnumValue("wdDontBreakWrappedTables")]
  DontBreakWrappedTables = 43,
  /// <summary>
  /// Don't snap text to grid inside table with inline objects.
  /// </summary>
  [InteropEnumValue("wdDontSnapTextToGridInTableWithObjects")]
  DontSnapTextToGridInTableWithObjects = 44,
  /// <summary>
  /// Select entire field with first or last character.
  /// </summary>
  [InteropEnumValue("wdSelectFieldWithFirstOrLastCharacter")]
  SelectFieldWithFirstOrLastCharacter = 45,
  /// <summary>
  /// Use line-breaking rules.
  /// </summary>
  [InteropEnumValue("wdApplyBreakingRules")]
  ApplyBreakingRules = 46,
  /// <summary>
  /// Don't allow hanging punctuation with character grid.
  /// </summary>
  [InteropEnumValue("wdDontWrapTextWithPunctuation")]
  DontWrapTextWithPunctuation = 47,
  /// <summary>
  /// Don't use Asian rules for line breaks with character grid.
  /// </summary>
  [InteropEnumValue("wdDontUseAsianBreakRulesInGrid")]
  DontUseAsianBreakRulesInGrid = 48,
  /// <summary>
  /// Use Word 2002 table style rules.
  /// </summary>
  [InteropEnumValue("wdUseWord2002TableStyleRules")]
  UseWord2002TableStyleRules = 49,
  /// <summary>
  /// Allow tables to extend into margins.
  /// </summary>
  [InteropEnumValue("wdGrowAutofit")]
  GrowAutofit = 50,
  /// <summary>
  /// Use the Normal style instead of the List Paragraph style for bulleted or numbered lists.
  /// </summary>
  [InteropEnumValue("wdUseNormalStyleForList")]
  UseNormalStyleForList = 51,
  /// <summary>
  /// Do not use hanging indent as tab stop for bullets and numbering.
  /// </summary>
  [InteropEnumValue("wdDontUseIndentAsNumberingTabStop")]
  DontUseIndentAsNumberingTabStop = 52,
  /// <summary>
  /// Use Word 2003 hanging-punctuation rules in Asian langauges.
  /// </summary>
  [InteropEnumValue("wdFELineBreak11")]
  FELineBreak11 = 53,
  /// <summary>
  /// Allow space between paragraphs of the same style in a table.
  /// </summary>
  [InteropEnumValue("wdAllowSpaceOfSameStyleInTable")]
  AllowSpaceOfSameStyleInTable = 54,
  /// <summary>
  /// Use Word 2003 indent rules for text next to wrapped objects.
  /// </summary>
  [InteropEnumValue("wdWW11IndentRules")]
  WW11IndentRules = 55,
  /// <summary>
  /// Do not autofit tables next to wrapped objects.
  /// </summary>
  [InteropEnumValue("wdDontAutofitConstrainedTables")]
  DontAutofitConstrainedTables = 56,
  /// <summary>
  /// Use Microsoft Office Word 2003 table autofit rules.
  /// </summary>
  [InteropEnumValue("wdAutofitLikeWW11")]
  AutofitLikeWW11 = 57,
  /// <summary>
  /// Underline the tab character between the number and the text in numbered lists.
  /// </summary>
  [InteropEnumValue("wdUnderlineTabInNumList")]
  UnderlineTabInNumList = 58,
  /// <summary>
  /// Do not use proportional width for Korean characters.
  /// </summary>
  [InteropEnumValue("wdHangulWidthLikeWW11")]
  HangulWidthLikeWW11 = 59,
  /// <summary>
  /// Split apart page break and paragraph mark.
  /// </summary>
  [InteropEnumValue("wdSplitPgBreakAndParaMark")]
  SplitPgBreakAndParaMark = 60,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdDontVertAlignCellWithShape")]
  DontVertAlignCellWithShape = 61,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdDontBreakConstrainedForcedTables")]
  DontBreakConstrainedForcedTables = 62,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdDontVertAlignInTextbox")]
  DontVertAlignInTextbox = 63,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdWord11KerningPairs")]
  Word11KerningPairs = 64,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdCachedColBalance")]
  CachedColBalance = 65,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdDisableOTKerning")]
  DisableOTKerning = 66,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdFlipMirrorIndents")]
  FlipMirrorIndents = 67,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdDontOverrideTableStyleFontSzAndJustification")]
  DontOverrideTableStyleFontSzAndJustification = 68,
  /// <summary>
  /// Use Word 2010 table style rules.
  /// </summary>
  [InteropEnumValue("wdUseWord2010TableStyleRules")]
  UseWord2010TableStyleRules = 69
}
