namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a compatibility option.
/// </summary>
public enum WdCompatibility
{
  /// <summary>
  /// Don't add automatic tab stop for hanging indent.
  /// </summary>
  NoTabHangIndent = unchecked((int)1),
  /// <summary>
  /// Don't add extra space for raised/lowered characters.
  /// </summary>
  NoSpaceRaiseLower = unchecked((int)2),
  /// <summary>
  /// Print colors as black on noncolor printers.
  /// </summary>
  PrintColBlack = unchecked((int)3),
  /// <summary>
  /// Wrap trailing spaces to next line.
  /// </summary>
  WrapTrailSpaces = unchecked((int)4),
  /// <summary>
  /// Don't balance columns for continuous section starts.
  /// </summary>
  NoColumnBalance = unchecked((int)5),
  /// <summary>
  /// Treat " as "" in mail merge data sources.
  /// </summary>
  ConvMailMergeEsc = unchecked((int)6),
  /// <summary>
  /// Suppress Space Before after a hard page or column break.
  /// </summary>
  SuppressSpBfAfterPgBrk = unchecked((int)7),
  /// <summary>
  /// Suppress extra line spacing at top of page.
  /// [System.Runtime.InteropServices.Guid("8B0DD4CD-D15D-3290-81BA-A73BC181E06F")] public enum WdCompatibility ﾉ
  /// Expand table
  /// </summary>
  SuppressTopSpacing = unchecked((int)8),
  /// <summary>
  /// Combine table borders like Word 5.x for the Macintosh.
  /// </summary>
  OrigWordTableRules = unchecked((int)9),
  /// <summary>
  /// Don't blank the area behind metafile pictures.
  /// </summary>
  TransparentMetafiles = unchecked((int)10),
  /// <summary>
  /// Show hard page or column breaks in frames.
  /// </summary>
  ShowBreaksInFrames = unchecked((int)11),
  /// <summary>
  /// Swap left and right borders on odd facing pages.
  /// </summary>
  SwapBordersFacingPages = unchecked((int)12),
  /// <summary>
  /// Convert backslash characters into yen signs.
  /// </summary>
  LeaveBackslashAlone = unchecked((int)13),
  /// <summary>
  /// Don't expand character spaces on the line ending Shift+Return.
  /// </summary>
  ExpandShiftReturn = unchecked((int)14),
  /// <summary>
  /// Draw underline on trailing spaces. wdDontBalanceSingleByteDoubleByteWidth16 Balance SBCS characters and DBCS
  /// characters.
  /// </summary>
  DontULTrailSpace = unchecked((int)15),
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  DontBalanceSingleByteDoubleByteWidth = unchecked((int)16),
  /// <summary>
  /// Suppress extra line spacing at top of page like Word 5.x for the Macintosh.
  /// </summary>
  SuppressTopSpacingMac5 = unchecked((int)17),
  /// <summary>
  /// Expand/condense by whole number of points.
  /// </summary>
  SpacingInWholePoints = unchecked((int)18),
  /// <summary>
  /// Print body text before header/footer.
  /// </summary>
  PrintBodyTextBeforeHeader = unchecked((int)19),
  /// <summary>
  /// Don't add leading (extra space) between rows of text.
  /// </summary>
  NoLeading = unchecked((int)20),
  /// <summary>
  /// Add space for underline.
  /// </summary>
  NoSpaceForUL = unchecked((int)21),
  /// <summary>
  /// Use larger small caps like Word 5.x for the Macintosh.
  /// </summary>
  MWSmallCaps = unchecked((int)22),
  /// <summary>
  /// Suppress extra line spacing like WordPerfect 5.x.
  /// </summary>
  NoExtraLineSpacing = unchecked((int)23),
  /// <summary>
  /// Truncate font height.
  /// </summary>
  TruncateFontHeight = unchecked((int)24),
  /// <summary>
  /// Substitute fonts based on font size.
  /// </summary>
  SubFontBySize = unchecked((int)25),
  /// <summary>
  /// Use printer metrics to lay out document.
  /// </summary>
  UsePrinterMetrics = unchecked((int)26),
  /// <summary>
  /// Use Word 6.x/95 border rules.
  /// </summary>
  WW6BorderRules = unchecked((int)27),
  /// <summary>
  /// Don't center "exact line height" lines.
  /// </summary>
  ExactOnTop = unchecked((int)28),
  /// <summary>
  /// Suppress extra line spacing at bottom of page.
  /// </summary>
  SuppressBottomSpacing = unchecked((int)29),
  /// <summary>
  /// Set the width of a space like WordPerfect 5.x.
  /// </summary>
  WPSpaceWidth = unchecked((int)30),
  /// <summary>
  /// Do full justification like WordPerfect 6.x for Windows.
  /// </summary>
  WPJustification = unchecked((int)31),
  /// <summary>
  /// Line wrap like Word 6.0.
  /// </summary>
  LineWrapLikeWord6 = unchecked((int)32),
  /// <summary>
  /// Lay out autoshapes like Word 97.
  /// </summary>
  ShapeLayoutLikeWW8 = unchecked((int)33),
  /// <summary>
  /// Lay out footnotes like Word 6.x/95/97.
  /// </summary>
  FootnoteLayoutLikeWW8 = unchecked((int)34),
  /// <summary>
  /// Don't use HTML paragraph auto spacing.
  /// </summary>
  DontUseHTMLParagraphAutoSpacing = unchecked((int)35),
  /// <summary>
  /// Adjust line height to grid height in the table.
  /// </summary>
  DontAdjustLineHeightInTable = unchecked((int)36),
  /// <summary>
  /// Forget last tab alignment.
  /// </summary>
  ForgetLastTabAlignment = unchecked((int)37),
  /// <summary>
  /// Autospace like Word 95.
  /// </summary>
  AutospaceLikeWW7 = unchecked((int)38),
  /// <summary>
  /// Align table rows independently.
  /// </summary>
  AlignTablesRowByRow = unchecked((int)39),
  /// <summary>
  /// Lay out tables with raw width.
  /// </summary>
  LayoutRawTableWidth = unchecked((int)40),
  /// <summary>
  /// Allow table rows to lay out apart.
  /// </summary>
  LayoutTableRowsApart = unchecked((int)41),
  /// <summary>
  /// Use
  /// </summary>
  UseWord97LineBreakingRules = unchecked((int)42),
  /// <summary>
  /// Don't break wrapped tables across pages.
  /// </summary>
  DontBreakWrappedTables = unchecked((int)43),
  /// <summary>
  /// Don't snap text to grid inside table with inline objects. wdSelectFieldWithFirstOrLastCharacter45 Select
  /// entire field with first or last character.
  /// </summary>
  DontSnapTextToGridInTableWithObjects = unchecked((int)44),
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  SelectFieldWithFirstOrLastCharacter = unchecked((int)45),
  /// <summary>
  /// Use line-breaking rules.
  /// </summary>
  ApplyBreakingRules = unchecked((int)46),
  /// <summary>
  /// Don't allow hanging punctuation with character grid.
  /// </summary>
  DontWrapTextWithPunctuation = unchecked((int)47),
  /// <summary>
  /// Don't use Asian rules for line breaks with character grid.
  /// </summary>
  DontUseAsianBreakRulesInGrid = unchecked((int)48),
  /// <summary>
  /// Use
  /// </summary>
  UseWord2002TableStyleRules = unchecked((int)49),
  /// <summary>
  /// Allow tables to extend into margins.
  /// </summary>
  GrowAutofit = unchecked((int)50),
  /// <summary>
  /// Use the Normal style instead of the List Paragraph style for bulleted or numbered lists.
  /// </summary>
  UseNormalStyleForList = unchecked((int)51),
  /// <summary>
  /// Do not use hanging indent as tab stop for bullets and numbering.
  /// </summary>
  DontUseIndentAsNumberingTabStop = unchecked((int)52),
  /// <summary>
  /// Use
  /// </summary>
  FELineBreak11 = unchecked((int)53),
  /// <summary>
  /// Allow space between paragraphs of the same style in a table.
  /// </summary>
  AllowSpaceOfSameStyleInTable = unchecked((int)54),
  /// <summary>
  /// Use
  /// </summary>
  WW11IndentRules = unchecked((int)55),
  /// <summary>
  /// Do not autofit tables next to wrapped objects.
  /// </summary>
  DontAutofitConstrainedTables = unchecked((int)56),
  /// <summary>
  /// Use Microsoft Office
  /// </summary>
  AutofitLikeWW11 = unchecked((int)57),
  /// <summary>
  /// Underline the tab character between the number and the text in numbered lists.
  /// </summary>
  UnderlineTabInNumList = unchecked((int)58),
  /// <summary>
  /// Do not use proportional width for Korean characters.
  /// </summary>
  HangulWidthLikeWW11 = unchecked((int)59),
  /// <summary>
  /// Split apart page break and paragraph mark.
  /// </summary>
  SplitPgBreakAndParaMark = unchecked((int)60),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  DontVertAlignCellWithShape = unchecked((int)61),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  DontBreakConstrainedForcedTables = unchecked((int)62),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  DontVertAlignInTextbox = unchecked((int)63),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  Word11KerningPairs = unchecked((int)64),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  CachedColBalance = unchecked((int)65),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  DisableOTKerning = unchecked((int)66),
  /// <summary>
  /// Reserved for internal use. wdDontOverrideTableStyleFontSzAndJustification68 Reserved for internal use.
  /// </summary>
  FlipMirrorIndents = unchecked((int)67),
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  DontOverrideTableStyleFontSzAndJustification = unchecked((int)68),
  /// <summary>
  /// Use
  /// </summary>
  UseWord2010TableStyleRules = unchecked((int)69)
}
