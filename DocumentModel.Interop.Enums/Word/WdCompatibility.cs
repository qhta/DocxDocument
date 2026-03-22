namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a compatibility option.
/// </summary>
public enum WdCompatibility
{
  /// <summary>
  /// Don't add automatic tab stop for hanging indent.
  /// </summary>
  wdNoTabHangIndent = unchecked((int)1),
  /// <summary>
  /// Don't add extra space for raised/lowered characters.
  /// </summary>
  wdNoSpaceRaiseLower = unchecked((int)2),
  /// <summary>
  /// Print colors as black on noncolor printers.
  /// </summary>
  wdPrintColBlack = unchecked((int)3),
  /// <summary>
  /// Wrap trailing spaces to next line.
  /// </summary>
  wdWrapTrailSpaces = unchecked((int)4),
  /// <summary>
  /// Don't balance columns for continuous section starts.
  /// </summary>
  wdNoColumnBalance = unchecked((int)5),
  /// <summary>
  /// Treat " as "" in mail merge data sources.
  /// </summary>
  wdConvMailMergeEsc = unchecked((int)6),
  /// <summary>
  /// Suppress Space Before after a hard page or column break.
  /// </summary>
  wdSuppressSpBfAfterPgBrk = unchecked((int)7),
  /// <summary>
  /// Suppress extra line spacing at top of page.
  /// [System.Runtime.InteropServices.Guid("8B0DD4CD-D15D-3290-81BA-A73BC181E06F")] public enum WdCompatibility ﾉ
  /// Expand table
  /// </summary>
  wdSuppressTopSpacing = unchecked((int)8),
  /// <summary>
  /// Combine table borders like Word 5.x for the Macintosh.
  /// </summary>
  wdOrigWordTableRules = unchecked((int)9),
  /// <summary>
  /// Don't blank the area behind metafile pictures.
  /// </summary>
  wdTransparentMetafiles = unchecked((int)10),
  /// <summary>
  /// Show hard page or column breaks in frames.
  /// </summary>
  wdShowBreaksInFrames = unchecked((int)11),
  /// <summary>
  /// Swap left and right borders on odd facing pages.
  /// </summary>
  wdSwapBordersFacingPages = unchecked((int)12),
  /// <summary>
  /// Convert backslash characters into yen signs.
  /// </summary>
  wdLeaveBackslashAlone = unchecked((int)13),
  /// <summary>
  /// Don't expand character spaces on the line ending Shift+Return.
  /// </summary>
  wdExpandShiftReturn = unchecked((int)14),
  /// <summary>
  /// Draw underline on trailing spaces. wdDontBalanceSingleByteDoubleByteWidth16 Balance SBCS characters and DBCS
  /// characters.
  /// </summary>
  wdDontULTrailSpace = unchecked((int)15),
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  wdDontBalanceSingleByteDoubleByteWidth = unchecked((int)16),
  /// <summary>
  /// Suppress extra line spacing at top of page like Word 5.x for the Macintosh.
  /// </summary>
  wdSuppressTopSpacingMac5 = unchecked((int)17),
  /// <summary>
  /// Expand/condense by whole number of points.
  /// </summary>
  wdSpacingInWholePoints = unchecked((int)18),
  /// <summary>
  /// Print body text before header/footer.
  /// </summary>
  wdPrintBodyTextBeforeHeader = unchecked((int)19),
  /// <summary>
  /// Don't add leading (extra space) between rows of text.
  /// </summary>
  wdNoLeading = unchecked((int)20),
  /// <summary>
  /// Add space for underline.
  /// </summary>
  wdNoSpaceForUL = unchecked((int)21),
  /// <summary>
  /// Use larger small caps like Word 5.x for the Macintosh.
  /// </summary>
  wdMWSmallCaps = unchecked((int)22),
  /// <summary>
  /// Suppress extra line spacing like WordPerfect 5.x.
  /// </summary>
  wdNoExtraLineSpacing = unchecked((int)23),
  /// <summary>
  /// Truncate font height.
  /// </summary>
  wdTruncateFontHeight = unchecked((int)24),
  /// <summary>
  /// Substitute fonts based on font size.
  /// </summary>
  wdSubFontBySize = unchecked((int)25),
  /// <summary>
  /// Use printer metrics to lay out document.
  /// </summary>
  wdUsePrinterMetrics = unchecked((int)26),
  /// <summary>
  /// Use Word 6.x/95 border rules.
  /// </summary>
  wdWW6BorderRules = unchecked((int)27),
  /// <summary>
  /// Don't center "exact line height" lines.
  /// </summary>
  wdExactOnTop = unchecked((int)28),
  /// <summary>
  /// Suppress extra line spacing at bottom of page.
  /// </summary>
  wdSuppressBottomSpacing = unchecked((int)29),
  /// <summary>
  /// Set the width of a space like WordPerfect 5.x.
  /// </summary>
  wdWPSpaceWidth = unchecked((int)30),
  /// <summary>
  /// Do full justification like WordPerfect 6.x for Windows.
  /// </summary>
  wdWPJustification = unchecked((int)31),
  /// <summary>
  /// Line wrap like Word 6.0.
  /// </summary>
  wdLineWrapLikeWord6 = unchecked((int)32),
  /// <summary>
  /// Lay out autoshapes like Word 97.
  /// </summary>
  wdShapeLayoutLikeWW8 = unchecked((int)33),
  /// <summary>
  /// Lay out footnotes like Word 6.x/95/97.
  /// </summary>
  wdFootnoteLayoutLikeWW8 = unchecked((int)34),
  /// <summary>
  /// Don't use HTML paragraph auto spacing.
  /// </summary>
  wdDontUseHTMLParagraphAutoSpacing = unchecked((int)35),
  /// <summary>
  /// Adjust line height to grid height in the table.
  /// </summary>
  wdDontAdjustLineHeightInTable = unchecked((int)36),
  /// <summary>
  /// Forget last tab alignment.
  /// </summary>
  wdForgetLastTabAlignment = unchecked((int)37),
  /// <summary>
  /// Autospace like Word 95.
  /// </summary>
  wdAutospaceLikeWW7 = unchecked((int)38),
  /// <summary>
  /// Align table rows independently.
  /// </summary>
  wdAlignTablesRowByRow = unchecked((int)39),
  /// <summary>
  /// Lay out tables with raw width.
  /// </summary>
  wdLayoutRawTableWidth = unchecked((int)40),
  /// <summary>
  /// Allow table rows to lay out apart.
  /// </summary>
  wdLayoutTableRowsApart = unchecked((int)41),
  /// <summary>
  /// Use
  /// </summary>
  wdUseWord97LineBreakingRules = unchecked((int)42),
  /// <summary>
  /// Don't break wrapped tables across pages.
  /// </summary>
  wdDontBreakWrappedTables = unchecked((int)43),
  /// <summary>
  /// Don't snap text to grid inside table with inline objects. wdSelectFieldWithFirstOrLastCharacter45 Select
  /// entire field with first or last character.
  /// </summary>
  wdDontSnapTextToGridInTableWithObjects = unchecked((int)44),
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  wdSelectFieldWithFirstOrLastCharacter = unchecked((int)45),
  /// <summary>
  /// Use line-breaking rules.
  /// </summary>
  wdApplyBreakingRules = unchecked((int)46),
  /// <summary>
  /// Don't allow hanging punctuation with character grid.
  /// </summary>
  wdDontWrapTextWithPunctuation = unchecked((int)47),
  /// <summary>
  /// Don't use Asian rules for line breaks with character grid.
  /// </summary>
  wdDontUseAsianBreakRulesInGrid = unchecked((int)48),
  /// <summary>
  /// Use
  /// </summary>
  wdUseWord2002TableStyleRules = unchecked((int)49),
  /// <summary>
  /// Allow tables to extend into margins.
  /// </summary>
  wdGrowAutofit = unchecked((int)50),
  /// <summary>
  /// Use the Normal style instead of the List Paragraph style for bulleted or numbered lists.
  /// </summary>
  wdUseNormalStyleForList = unchecked((int)51),
  /// <summary>
  /// Do not use hanging indent as tab stop for bullets and numbering.
  /// </summary>
  wdDontUseIndentAsNumberingTabStop = unchecked((int)52),
  /// <summary>
  /// Use
  /// </summary>
  wdFELineBreak11 = unchecked((int)53),
  /// <summary>
  /// Allow space between paragraphs of the same style in a table.
  /// </summary>
  wdAllowSpaceOfSameStyleInTable = unchecked((int)54),
  /// <summary>
  /// Use
  /// </summary>
  wdWW11IndentRules = unchecked((int)55),
  /// <summary>
  /// Do not autofit tables next to wrapped objects.
  /// </summary>
  wdDontAutofitConstrainedTables = unchecked((int)56),
  /// <summary>
  /// Use Microsoft Office
  /// </summary>
  wdAutofitLikeWW11 = unchecked((int)57),
  /// <summary>
  /// Underline the tab character between the number and the text in numbered lists.
  /// </summary>
  wdUnderlineTabInNumList = unchecked((int)58),
  /// <summary>
  /// Do not use proportional width for Korean characters.
  /// </summary>
  wdHangulWidthLikeWW11 = unchecked((int)59),
  /// <summary>
  /// Split apart page break and paragraph mark.
  /// </summary>
  wdSplitPgBreakAndParaMark = unchecked((int)60),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  wdDontVertAlignCellWithShape = unchecked((int)61),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  wdDontBreakConstrainedForcedTables = unchecked((int)62),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  wdDontVertAlignInTextbox = unchecked((int)63),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  wdWord11KerningPairs = unchecked((int)64),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  wdCachedColBalance = unchecked((int)65),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  wdDisableOTKerning = unchecked((int)66),
  /// <summary>
  /// Reserved for internal use. wdDontOverrideTableStyleFontSzAndJustification68 Reserved for internal use.
  /// </summary>
  wdFlipMirrorIndents = unchecked((int)67),
  /// <summary>
  /// Specifies a compatibility option.
  /// </summary>
  wdDontOverrideTableStyleFontSzAndJustification = unchecked((int)68),
  /// <summary>
  /// Use
  /// </summary>
  wdUseWord2010TableStyleRules = unchecked((int)69)
}
