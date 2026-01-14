namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents compatibility settings for a Wordprocessing document.
/// This class provides properties for emulating legacy behaviors, adjusting layout, formatting, printing, and other document features to ensure compatibility with various versions of word processing applications.
/// </summary>
public class Compatibility
{
  
  /// <summary>
  /// Use simplified rules for table border conflicts.
  /// </summary>
  public bool? UseSingleBorderForContiguousCells { get; set; }
  
  /// <summary>
  /// Emulate WordPerfect 6.x paragraph justification.
  /// </summary>
  public bool? WordPerfectJustification { get; set; }
  
  /// <summary>
  /// Do not create custom tab stop for hanging indent.
  /// </summary>
  public bool? NoTabHangIndent { get; set; }
  
  /// <summary>
  /// Do not add leading between lines of text.
  /// </summary>
  public bool? NoLeading { get; set; }
  
  /// <summary>
  /// Add additional space below baseline for underlined East Asian text.
  /// </summary>
  public bool? SpaceForUnderline { get; set; }
  
  /// <summary>
  /// Do not balance text columns within a section.
  /// </summary>
  public bool? NoColumnBalance { get; set; }
  
  /// <summary>
  /// Balance single byte and double byte characters.
  /// </summary>
  public bool? BalanceSingleByteDoubleByteWidth { get; set; }
  
  /// <summary>
  /// Do not center content on lines with exact line height.
  /// </summary>
  public bool? NoExtraLineSpacing { get; set; }
  
  /// <summary>
  /// Convert backslash to yen sign when entered.
  /// </summary>
  public bool? DoNotLeaveBackslashAlone { get; set; }
  
  /// <summary>
  /// Underline all trailing spaces.
  /// </summary>
  public bool? UnderlineTrailingSpaces { get; set; }
  
  /// <summary>
  /// Do not justify lines ending in soft line break.
  /// </summary>
  public bool? DoNotExpandShiftReturn { get; set; }
  
  /// <summary>
  /// Only expand/condense text by whole points.
  /// </summary>
  public bool? SpacingInWholePoints { get; set; }
  
  /// <summary>
  /// Emulate Word 6.0 line wrapping for East Asian text.
  /// </summary>
  public bool? LineWrapLikeWord6 { get; set; }
  
  /// <summary>
  /// Print body text before header/footer contents.
  /// </summary>
  public bool? PrintBodyTextBeforeHeader { get; set; }
  
  /// <summary>
  /// Print colors as black and white without dithering.
  /// </summary>
  public bool? PrintColorBlackWhite { get; set; }
  
  /// <summary>
  /// Use WordPerfect space width.
  /// </summary>
  public bool? WordPerfectSpaceWidth { get; set; }
  
  /// <summary>
  /// Display page/column breaks present in frames.
  /// </summary>
  public bool? ShowBreaksInFrames { get; set; }
  
  /// <summary>
  /// Increase priority of font size during font substitution.
  /// </summary>
  public bool? SubFontBySize { get; set; }
  
  /// <summary>
  /// Ignore exact line height for last line on page.
  /// </summary>
  public bool? SuppressBottomSpacing { get; set; }
  
  /// <summary>
  /// Ignore minimum and exact line height for first line on page.
  /// </summary>
  public bool? SuppressTopSpacing { get; set; }
  
  /// <summary>
  /// Ignore minimum line height for first line on page.
  /// </summary>
  public bool? SuppressSpacingAtTopOfPage { get; set; }
  
  /// <summary>
  /// Emulate WordPerfect 5.x line spacing.
  /// </summary>
  public bool? SuppressTopSpacingWordPerfect { get; set; }
  
  /// <summary>
  /// Do not use space before on first line after a page break.
  /// </summary>
  public bool? SuppressSpacingBeforeAfterPageBreak { get; set; }
  
  /// <summary>
  /// Swap paragraph borders on odd numbered pages.
  /// </summary>
  public bool? SwapBordersFacingPages { get; set; }
  
  /// <summary>
  /// Treat backslash quotation delimiter as two quotation marks.
  /// </summary>
  public bool? ConvertMailMergeEscape { get; set; }
  
  /// <summary>
  /// Emulate WordPerfect 6.x font height calculation.
  /// </summary>
  public bool? TruncateFontHeightsLikeWordPerfect { get; set; }
  
  /// <summary>
  /// Emulate Word 5.x for the Macintosh small caps formatting.
  /// </summary>
  public bool? MacWordSmallCaps { get; set; }
  
  /// <summary>
  /// Use printer metrics to display documents.
  /// </summary>
  public bool? UsePrinterMetrics { get; set; }
  
  /// <summary>
  /// Do not suppress paragraph borders next to frames.
  /// </summary>
  public bool? DoNotSuppressParagraphBorders { get; set; }
  
  /// <summary>
  /// Line wrap trailing spaces.
  /// </summary>
  public bool? WrapTrailSpaces { get; set; }
  
  /// <summary>
  /// Emulate Word 6.x/95/97 footnote placement.
  /// </summary>
  public bool? FootnoteLayoutLikeWord8 { get; set; }
  
  /// <summary>
  /// Emulate Word 97 text wrapping around floating objects.
  /// </summary>
  public bool? ShapeLayoutLikeWord8 { get; set; }
  
  /// <summary>
  /// Align table rows independently.
  /// </summary>
  public bool? AlignTablesRowByRow { get; set; }
  
  /// <summary>
  /// Ignore width of last tab stop when aligning paragraph if it is not left aligned.
  /// </summary>
  public bool? ForgetLastTabAlignment { get; set; }
  
  /// <summary>
  /// Add document grid line pitch to lines in table cells.
  /// </summary>
  public bool? AdjustLineHeightInTable { get; set; }
  
  /// <summary>
  /// Emulate Word 95 full-width character spacing.
  /// </summary>
  public bool? AutoSpaceLikeWord95 { get; set; }
  
  /// <summary>
  /// Do not increase line height for raised/lowered text.
  /// </summary>
  public bool? NoSpaceRaiseLower { get; set; }
  
  /// <summary>
  /// Use fixed paragraph spacing for HTML auto setting.
  /// </summary>
  public bool? DoNotUseHTMLParagraphAutoSpacing { get; set; }
  
  /// <summary>
  /// Ignore space before table when deciding if table should wrap floating object.
  /// </summary>
  public bool? LayoutRawTableWidth { get; set; }
  
  /// <summary>
  /// Allow table rows to wrap inline objects independently.
  /// </summary>
  public bool? LayoutTableRowsApart { get; set; }
  
  /// <summary>
  /// Emulate Word 97 East Asian line breaking.
  /// </summary>
  public bool? UseWord97LineBreakRules { get; set; }
  
  /// <summary>
  /// Do not allow floating tables to break across pages.
  /// </summary>
  public bool? DoNotBreakWrappedTables { get; set; }
  
  /// <summary>
  /// Do not snap to document grid in table cells with objects.
  /// </summary>
  public bool? DoNotSnapToGridInCell { get; set; }
  
  /// <summary>
  /// Select field when first or last character is selected.
  /// </summary>
  public bool? SelectFieldWithFirstOrLastChar { get; set; }
  
  /// <summary>
  /// Use legacy Ethiopic and Amharic line breaking rules.
  /// </summary>
  public bool? ApplyBreakingRules { get; set; }
  
  /// <summary>
  /// Do not allow hanging punctuation with character grid.
  /// </summary>
  public bool? DoNotWrapTextWithPunctuation { get; set; }
  
  /// <summary>
  /// Do not compress compressible characters when using document grid.
  /// </summary>
  public bool? DoNotUseEastAsianBreakRules { get; set; }
  
  /// <summary>
  /// Emulate Word 2002 table style rules.
  /// </summary>
  public bool? UseWord2002TableStyleRules { get; set; }
  
  /// <summary>
  /// Allow tables to autofit into page margins.
  /// </summary>
  public bool? GrowAutofit { get; set; }
  
  /// <summary>
  /// Do not bypass East Asian/complex script layout code.
  /// </summary>
  public bool? UseFarEastLayout { get; set; }
  
  /// <summary>
  /// Do not automatically apply list paragraph style to bulleted/numbered text.
  /// </summary>
  public bool? UseNormalStyleForList { get; set; }
  
  /// <summary>
  /// Ignore hanging indent when creating tab stop after numbering.
  /// </summary>
  public bool? DoNotUseIndentAsNumberingTabStop { get; set; }
  
  /// <summary>
  /// Use alternate set of East Asian line breaking rules.
  /// </summary>
  public bool? UseAltKinsokuLineBreakRules { get; set; }
  
  /// <summary>
  /// Allow contextual spacing of paragraphs in tables.
  /// </summary>
  public bool? AllowSpaceOfSameStyleInTable { get; set; }
  
  /// <summary>
  /// Do not ignore floating objects when calculating paragraph indentation.
  /// </summary>
  public bool? DoNotSuppressIndentation { get; set; }
  
  /// <summary>
  /// Do not autofit tables to fit next to wrapped objects.
  /// </summary>
  public bool? DoNotAutofitConstrainedTables { get; set; }
  
  /// <summary>
  /// Allow table columns to exceed preferred widths of constituent cells.
  /// </summary>
  public bool? AutofitToFirstFixedWidthCell { get; set; }
  
  /// <summary>
  /// Underline following character following numbering.
  /// </summary>
  public bool? UnderlineTabInNumberingList { get; set; }
  
  /// <summary>
  /// Always use fixed width for Hangul characters.
  /// </summary>
  public bool? DisplayHangulFixedWidth { get; set; }
  
  /// <summary>
  /// Always move paragraph mark to page after a page break.
  /// </summary>
  public bool? SplitPageBreakAndParagraphMark { get; set; }
  
  /// <summary>
  /// Do not vertically align cells containing floating objects.
  /// </summary>
  public bool? DoNotVerticallyAlignCellWithShape { get; set; }
  
  /// <summary>
  /// Do not break table rows around floating tables.
  /// </summary>
  public bool? DoNotBreakConstrainedForcedTable { get; set; }
  
  /// <summary>
  /// Ignore vertical alignment in textboxes.
  /// </summary>
  public bool? DoNotVerticallyAlignInTextBox { get; set; }
  
  /// <summary>
  /// Use ANSI kerning pairs from fonts.
  /// </summary>
  public bool? UseAnsiKerningPairs { get; set; }
  
  /// <summary>
  /// Use cached paragraph information for column balancing.
  /// </summary>
  public bool? CachedColumnBalance { get; set; }
  
  /// <summary>
  /// Compatibility settings collection for additional options.
  /// </summary>
  public CompatibilitySettings? CompatibilitySettings { get; set; }
}