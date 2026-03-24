namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a compatibility option.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcompatibility?view=office-pia` for Office interop details.
/// </remarks>
public enum WdCompatibility
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
  /// Specifies a compatibility option.
  /// </summary>
  OrigWordTableRules = 9,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  TransparentMetafiles = 10,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  ShowBreaksInFrames = 11,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  SwapBordersFacingPages = 12,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  LeaveBackslashAlone = 13,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  ExpandShiftReturn = 14,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  DontULTrailSpace = 15,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  DontBalanceSingleByteDoubleByteWidth = 16,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  SuppressTopSpacingMac5 = 17,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  SpacingInWholePoints = 18,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  PrintBodyTextBeforeHeader = 19,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  NoLeading = 20,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  NoSpaceForUL = 21,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  MWSmallCaps = 22,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  NoExtraLineSpacing = 23,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  TruncateFontHeight = 24,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  SubFontBySize = 25,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  UsePrinterMetrics = 26,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  WW6BorderRules = 27,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  ExactOnTop = 28,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  SuppressBottomSpacing = 29,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  WPSpaceWidth = 30,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  WPJustification = 31,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  LineWrapLikeWord6 = 32,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  ShapeLayoutLikeWW8 = 33,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  FootnoteLayoutLikeWW8 = 34,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  DontUseHTMLParagraphAutoSpacing = 35,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  DontAdjustLineHeightInTable = 36,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  ForgetLastTabAlignment = 37,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  AutospaceLikeWW7 = 38,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  AlignTablesRowByRow = 39,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  LayoutRawTableWidth = 40,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  LayoutTableRowsApart = 41,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  UseWord97LineBreakingRules = 42,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  DontBreakWrappedTables = 43,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  DontSnapTextToGridInTableWithObjects = 44,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  SelectFieldWithFirstOrLastCharacter = 45,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  ApplyBreakingRules = 46,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  DontWrapTextWithPunctuation = 47,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  DontUseAsianBreakRulesInGrid = 48,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  UseWord2002TableStyleRules = 49,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  GrowAutofit = 50,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  UseNormalStyleForList = 51,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  DontUseIndentAsNumberingTabStop = 52,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  FELineBreak11 = 53,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  AllowSpaceOfSameStyleInTable = 54,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  WW11IndentRules = 55,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  DontAutofitConstrainedTables = 56,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  AutofitLikeWW11 = 57,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  UnderlineTabInNumList = 58,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  HangulWidthLikeWW11 = 59,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  SplitPgBreakAndParaMark = 60,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  DontVertAlignCellWithShape = 61,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  DontBreakConstrainedForcedTables = 62,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  DontVertAlignInTextbox = 63,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  Word11KerningPairs = 64,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  CachedColBalance = 65,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  DisableOTKerning = 66,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  FlipMirrorIndents = 67,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  DontOverrideTableStyleFontSzAndJustification = 68,
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  UseWord2010TableStyleRules = 69
}
