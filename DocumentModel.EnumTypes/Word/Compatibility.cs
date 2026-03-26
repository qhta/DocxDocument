namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a compatibility option.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcompatibility?view=office-pia` for Office interop details.
/// </remarks>
public enum Compatibility
{
  /// <summary>
  /// Don't add automatic tab stop for hanging indent.
  /// </summary>
  NoTabHangIndent = 1,
  /// <summary>
  /// Don't add extra space for raised/lowered characters.
  /// </summary>
  NoSpaceRaiseLower = 2,
  /// <summary>
  /// Print colors as black on noncolor printers.
  /// </summary>
  PrintColBlack = 3,
  /// <summary>
  /// Wrap trailing spaces to next line.
  /// </summary>
  WrapTrailSpaces = 4,
  /// <summary>
  /// Don't balance columns for continuous section starts.
  /// </summary>
  NoColumnBalance = 5,
  /// <summary>
  /// Treat " as "" in mail merge data sources.
  /// </summary>
  ConvMailMergeEsc = 6,
  /// <summary>
  /// Suppress Space Before after a hard page or column break.
  /// </summary>
  SuppressSpBfAfterPgBrk = 7,
  /// <summary>
  /// Suppress extra line spacing at top of page.
  /// </summary>
  SuppressTopSpacing = 8,
  /// <summary>
  /// Combine table borders like Word 5.x for the Macintosh.
  /// </summary>
  OrigWordTableRules = 9,
  /// <summary>
  /// Don't blank the area behind metafile pictures.
  /// </summary>
  TransparentMetafiles = 10,
  /// <summary>
  /// Show hard page or column breaks in frames.
  /// </summary>
  ShowBreaksInFrames = 11,
  /// <summary>
  /// Swap left and right borders on odd facing pages.
  /// </summary>
  SwapBordersFacingPages = 12,
  /// <summary>
  /// Convert backslash characters into yen signs.
  /// </summary>
  LeaveBackslashAlone = 13,
  /// <summary>
  /// Don't expand character spaces on the line ending Shift+Return.
  /// </summary>
  ExpandShiftReturn = 14,
  /// <summary>
  /// Draw underline on trailing spaces.
  /// </summary>
  DontULTrailSpace = 15,
  /// <summary>
  /// Balance SBCS characters and DBCS characters.
  /// </summary>
  DontBalanceSingleByteDoubleByteWidth = 16,
  /// <summary>
  /// Suppress extra line spacing at top of page like Word 5.x for the Macintosh.
  /// </summary>
  SuppressTopSpacingMac5 = 17,
  /// <summary>
  /// Expand/condense by whole number of points.
  /// </summary>
  SpacingInWholePoints = 18,
  /// <summary>
  /// Print body text before header/footer.
  /// </summary>
  PrintBodyTextBeforeHeader = 19,
  /// <summary>
  /// Don't add leading (extra space) between rows of text.
  /// </summary>
  NoLeading = 20,
  /// <summary>
  /// Add space for underline.
  /// </summary>
  NoSpaceForUL = 21,
  /// <summary>
  /// Use larger small caps like Word 5.x for the Macintosh.
  /// </summary>
  MWSmallCaps = 22,
  /// <summary>
  /// Suppress extra line spacing like WordPerfect 5.x.
  /// </summary>
  NoExtraLineSpacing = 23,
  /// <summary>
  /// Truncate font height.
  /// </summary>
  TruncateFontHeight = 24,
  /// <summary>
  /// Substitute fonts based on font size.
  /// </summary>
  SubFontBySize = 25,
  /// <summary>
  /// Use printer metrics to lay out document.
  /// </summary>
  UsePrinterMetrics = 26,
  /// <summary>
  /// Use Word 6.x/95 border rules.
  /// </summary>
  WW6BorderRules = 27,
  /// <summary>
  /// Don't center "exact line height" lines.
  /// </summary>
  ExactOnTop = 28,
  /// <summary>
  /// Suppress extra line spacing at bottom of page.
  /// </summary>
  SuppressBottomSpacing = 29,
  /// <summary>
  /// Set the width of a space like WordPerfect 5.x.
  /// </summary>
  WPSpaceWidth = 30,
  /// <summary>
  /// Do full justification like WordPerfect 6.x for Windows.
  /// </summary>
  WPJustification = 31,
  /// <summary>
  /// Line wrap like Word 6.0.
  /// </summary>
  LineWrapLikeWord6 = 32,
  /// <summary>
  /// Lay out autoshapes like Word 97.
  /// </summary>
  ShapeLayoutLikeWW8 = 33,
  /// <summary>
  /// Lay out footnotes like Word 6.x/95/97.
  /// </summary>
  FootnoteLayoutLikeWW8 = 34,
  /// <summary>
  /// Don't use HTML paragraph auto spacing.
  /// </summary>
  DontUseHTMLParagraphAutoSpacing = 35,
  /// <summary>
  /// Adjust line height to grid height in the table.
  /// </summary>
  DontAdjustLineHeightInTable = 36,
  /// <summary>
  /// Forget last tab alignment.
  /// </summary>
  ForgetLastTabAlignment = 37,
  /// <summary>
  /// Autospace like Word 95.
  /// </summary>
  AutospaceLikeWW7 = 38,
  /// <summary>
  /// Align table rows independently.
  /// </summary>
  AlignTablesRowByRow = 39,
  /// <summary>
  /// Lay out tables with raw width.
  /// </summary>
  LayoutRawTableWidth = 40,
  /// <summary>
  /// Allow table rows to lay out apart.
  /// </summary>
  LayoutTableRowsApart = 41,
  /// <summary>
  /// Use Word 97 line breaking rules for Asian text.
  /// </summary>
  UseWord97LineBreakingRules = 42,
  /// <summary>
  /// Don't break wrapped tables across pages.
  /// </summary>
  DontBreakWrappedTables = 43,
  /// <summary>
  /// Don't snap text to grid inside table with inline objects.
  /// </summary>
  DontSnapTextToGridInTableWithObjects = 44,
  /// <summary>
  /// Select entire field with first or last character.
  /// </summary>
  SelectFieldWithFirstOrLastCharacter = 45,
  /// <summary>
  /// Use line-breaking rules.
  /// </summary>
  ApplyBreakingRules = 46,
  /// <summary>
  /// Don't allow hanging punctuation with character grid.
  /// </summary>
  DontWrapTextWithPunctuation = 47,
  /// <summary>
  /// Don't use Asian rules for line breaks with character grid.
  /// </summary>
  DontUseAsianBreakRulesInGrid = 48,
  /// <summary>
  /// Use Word 2002 table style rules.
  /// </summary>
  UseWord2002TableStyleRules = 49,
  /// <summary>
  /// Allow tables to extend into margins.
  /// </summary>
  GrowAutofit = 50,
  /// <summary>
  /// Use the Normal style instead of the List Paragraph style for bulleted or numbered lists.
  /// </summary>
  UseNormalStyleForList = 51,
  /// <summary>
  /// Do not use hanging indent as tab stop for bullets and numbering.
  /// </summary>
  DontUseIndentAsNumberingTabStop = 52,
  /// <summary>
  /// Use Word 2003 hanging-punctuation rules in Asian langauges.
  /// </summary>
  FELineBreak11 = 53,
  /// <summary>
  /// Allow space between paragraphs of the same style in a table.
  /// </summary>
  AllowSpaceOfSameStyleInTable = 54,
  /// <summary>
  /// Use Word 2003 indent rules for text next to wrapped objects.
  /// </summary>
  WW11IndentRules = 55,
  /// <summary>
  /// Do not autofit tables next to wrapped objects.
  /// </summary>
  DontAutofitConstrainedTables = 56,
  /// <summary>
  /// Use Microsoft Office Word 2003 table autofit rules.
  /// </summary>
  AutofitLikeWW11 = 57,
  /// <summary>
  /// Underline the tab character between the number and the text in numbered lists.
  /// </summary>
  UnderlineTabInNumList = 58,
  /// <summary>
  /// Do not use proportional width for Korean characters.
  /// </summary>
  HangulWidthLikeWW11 = 59,
  /// <summary>
  /// Split apart page break and paragraph mark.
  /// </summary>
  SplitPgBreakAndParaMark = 60,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  DontVertAlignCellWithShape = 61,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  DontBreakConstrainedForcedTables = 62,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  DontVertAlignInTextbox = 63,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  Word11KerningPairs = 64,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  CachedColBalance = 65,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  DisableOTKerning = 66,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  FlipMirrorIndents = 67,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  DontOverrideTableStyleFontSzAndJustification = 68,
  /// <summary>
  /// Use Word 2010 table style rules.
  /// </summary>
  UseWord2010TableStyleRules = 69
}
