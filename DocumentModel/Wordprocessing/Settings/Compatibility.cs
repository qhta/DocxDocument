namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Compatibility Settings.
/// </summary>
public class Compatibility: ModelElement
{
  /// <summary>
  ///   Use Simplified Rules For Table Border Conflicts.
  /// </summary>
  public bool? UseSingleBorderForContiguousCells { get; set; }

  /// <summary>
  ///   Emulate WordPerfect 6.x Paragraph Justification.
  /// </summary>
  public bool? WordPerfectJustification { get; set; }

  /// <summary>
  ///   Do Not Create Custom Tab Stop for Hanging Indent.
  /// </summary>
  public bool? NoTabHangIndent { get; set; }

  /// <summary>
  ///   Do Not Add Leading Between Lines of Text.
  /// </summary>
  public bool? NoLeading { get; set; }

  /// <summary>
  ///   Add Additional Space Below Baseline For Underlined East Asian Text.
  /// </summary>
  public bool? SpaceForUnderline { get; set; }

  /// <summary>
  ///   Do Not Balance Text Columns within a Section.
  /// </summary>
  public bool? NoColumnBalance { get; set; }

  /// <summary>
  ///   Balance Single Byte and Double Byte Characters.
  /// </summary>
  public bool? BalanceSingleByteDoubleByteWidth { get; set; }

  /// <summary>
  ///   Do Not Center Content on Lines With Exact Line Height.
  /// </summary>
  public bool? NoExtraLineSpacing { get; set; }

  /// <summary>
  ///   Convert Backslash To Yen Sign When Entered.
  /// </summary>
  public bool? DoNotLeaveBackslashAlone { get; set; }

  /// <summary>
  ///   Underline All Trailing Spaces.
  /// </summary>
  public bool? UnderlineTrailingSpaces { get; set; }

  /// <summary>
  ///   Don't Justify Lines Ending in Soft Line Break.
  /// </summary>
  public bool? DoNotExpandShiftReturn { get; set; }

  /// <summary>
  ///   Only Expand/Condense Text By Whole Points.
  /// </summary>
  public bool? SpacingInWholePoints { get; set; }

  /// <summary>
  ///   Emulate Word 6.0 Line Wrapping for East Asian Text.
  /// </summary>
  public bool? LineWrapLikeWord6 { get; set; }

  /// <summary>
  ///   Print Body Text before Header/Footer Contents.
  /// </summary>
  public bool? PrintBodyTextBeforeHeader { get; set; }

  /// <summary>
  ///   Print Colors as Black And White without Dithering.
  /// </summary>
  public bool? PrintColorBlackWhite { get; set; }

  /// <summary>
  ///   Space width.
  /// </summary>
  public bool? WordPerfectSpaceWidth { get; set; }

  /// <summary>
  ///   Display Page/Column Breaks Present in Frames.
  /// </summary>
  public bool? ShowBreaksInFrames { get; set; }

  /// <summary>
  ///   Increase Priority Of Font Size During Font Substitution.
  /// </summary>
  public bool? SubFontBySize { get; set; }

  /// <summary>
  ///   Ignore Exact Line Height for Last Line on Page.
  /// </summary>
  public bool? SuppressBottomSpacing { get; set; }

  /// <summary>
  ///   Ignore Minimum and Exact Line Height for First Line on Page.
  /// </summary>
  public bool? SuppressTopSpacing { get; set; }

  /// <summary>
  ///   Ignore Minimum Line Height for First Line on Page.
  /// </summary>
  public bool? SuppressSpacingAtTopOfPage { get; set; }

  /// <summary>
  ///   Emulate WordPerfect 5.x Line Spacing.
  /// </summary>
  public bool? SuppressTopSpacingWordPerfect { get; set; }

  /// <summary>
  ///   Do Not Use Space Before On First Line After a Page Break.
  /// </summary>
  public bool? SuppressSpacingBeforeAfterPageBreak { get; set; }

  /// <summary>
  ///   Swap Paragraph Borders on Odd Numbered Pages.
  /// </summary>
  public bool? SwapBordersFacingPages { get; set; }

  /// <summary>
  ///   Treat Backslash Quotation Delimiter as Two Quotation Marks.
  /// </summary>
  public bool? ConvertMailMergeEscape { get; set; }

  /// <summary>
  ///   Emulate WordPerfect 6.x Font Height Calculation.
  /// </summary>
  public bool? TruncateFontHeightsLikeWordPerfect { get; set; }

  /// <summary>
  ///   Emulate Word 5.x for the Macintosh Small Caps Formatting.
  /// </summary>
  public bool? MacWordSmallCaps { get; set; }

  /// <summary>
  ///   Use Printer Metrics To Display Documents.
  /// </summary>
  public bool? UsePrinterMetrics { get; set; }

  /// <summary>
  ///   Do Not Suppress Paragraph Borders Next To Frames.
  /// </summary>
  public bool? DoNotSuppressParagraphBorders { get; set; }

  /// <summary>
  ///   Line Wrap Trailing Spaces.
  /// </summary>
  public bool? WrapTrailSpaces { get; set; }

  /// <summary>
  ///   Emulate Word 6.x/95/97 Footnote Placement.
  /// </summary>
  public bool? FootnoteLayoutLikeWord8 { get; set; }

  /// <summary>
  ///   Emulate Word 97 Text Wrapping Around Floating Objects.
  /// </summary>
  public bool? ShapeLayoutLikeWord8 { get; set; }

  /// <summary>
  ///   Align Table Rows Independently.
  /// </summary>
  public bool? AlignTablesRowByRow { get; set; }

  /// <summary>
  ///   Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
  /// </summary>
  public bool? ForgetLastTabAlignment { get; set; }

  /// <summary>
  ///   Add Document Grid Line Pitch To Lines in Table Cells.
  /// </summary>
  public bool? AdjustLineHeightInTable { get; set; }

  /// <summary>
  ///   Emulate Word 95 Full-Width Character Spacing.
  /// </summary>
  public bool? AutoSpaceLikeWord95 { get; set; }

  /// <summary>
  ///   Do Not Increase Line Height for Raised/Lowered Text.
  /// </summary>
  public bool? NoSpaceRaiseLower { get; set; }

  /// <summary>
  ///   Use Fixed Paragraph Spacing for HTML Auto Setting.
  /// </summary>
  public bool? DoNotUseHTMLParagraphAutoSpacing { get; set; }

  /// <summary>
  ///   Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
  /// </summary>
  public bool? LayoutRawTableWidth { get; set; }

  /// <summary>
  ///   Allow Table Rows to Wrap Inline Objects Independently.
  /// </summary>
  public bool? LayoutTableRowsApart { get; set; }

  /// <summary>
  ///   Emulate Word 97 East Asian Line Breaking.
  /// </summary>
  public bool? UseWord97LineBreakRules { get; set; }

  /// <summary>
  ///   Do Not Allow Floating Tables To Break Across Pages.
  /// </summary>
  public bool? DoNotBreakWrappedTables { get; set; }

  /// <summary>
  ///   Do Not Snap to Document Grid in Table Cells with Objects.
  /// </summary>
  public bool? DoNotSnapToGridInCell { get; set; }

  /// <summary>
  ///   Select Field When First or Last Character Is Selected.
  /// </summary>
  public bool? SelectFieldWithFirstOrLastChar { get; set; }

  /// <summary>
  ///   Use Legacy Ethiopic and Amharic Line Breaking Rules.
  /// </summary>
  public bool? ApplyBreakingRules { get; set; }

  /// <summary>
  ///   Do Not Allow Hanging Punctuation With Character Grid.
  /// </summary>
  public bool? DoNotWrapTextWithPunctuation { get; set; }

  /// <summary>
  ///   Do Not Compress Compressible Characters When Using Document Grid.
  /// </summary>
  public bool? DoNotUseEastAsianBreakRules { get; set; }

  /// <summary>
  ///   Emulate Word 2002 Table Style Rules.
  /// </summary>
  public bool? UseWord2002TableStyleRules { get; set; }

  /// <summary>
  ///   Allow Tables to AutoFit Into Page Margins.
  /// </summary>
  public bool? GrowAutofit { get; set; }

  /// <summary>
  ///   Do Not Bypass East Asian/Complex Script Layout Code.
  /// </summary>
  public bool? UseFarEastLayout { get; set; }

  /// <summary>
  ///   Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
  /// </summary>
  public bool? UseNormalStyleForList { get; set; }

  /// <summary>
  ///   Ignore Hanging Indent When Creating Tab Stop After Numbering.
  /// </summary>
  public bool? DoNotUseIndentAsNumberingTabStop { get; set; }

  /// <summary>
  ///   Use Alternate Set of East Asian Line Breaking Rules.
  /// </summary>
  public bool? UseAltKinsokuLineBreakRules { get; set; }

  /// <summary>
  ///   Allow Contextual Spacing of Paragraphs in Tables.
  /// </summary>
  public bool? AllowSpaceOfSameStyleInTable { get; set; }

  /// <summary>
  ///   Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
  /// </summary>
  public bool? DoNotSuppressIndentation { get; set; }

  /// <summary>
  ///   Do Not AutoFit Tables To Fit Next To Wrapped Objects.
  /// </summary>
  public bool? DoNotAutofitConstrainedTables { get; set; }

  /// <summary>
  ///   Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
  /// </summary>
  public bool? AutofitToFirstFixedWidthCell { get; set; }

  /// <summary>
  ///   Underline Following Character Following Numbering.
  /// </summary>
  public bool? UnderlineTabInNumberingList { get; set; }

  /// <summary>
  ///   Always Use Fixed Width for Hangul Characters.
  /// </summary>
  public bool? DisplayHangulFixedWidth { get; set; }

  /// <summary>
  ///   Always Move Paragraph Mark to Page after a Page Break.
  /// </summary>
  public bool? SplitPageBreakAndParagraphMark { get; set; }

  /// <summary>
  ///   Don't Vertically Align Cells Containing Floating Objects.
  /// </summary>
  public bool? DoNotVerticallyAlignCellWithShape { get; set; }

  /// <summary>
  ///   Don't Break Table Rows Around Floating Tables.
  /// </summary>
  public bool? DoNotBreakConstrainedForcedTable { get; set; }

  /// <summary>
  ///   Ignore Vertical Alignment in Textboxes.
  /// </summary>
  public bool? DoNotVerticallyAlignInTextBox { get; set; }

  /// <summary>
  ///   Use ANSI Kerning Pairs from Fonts.
  /// </summary>
  public bool? UseAnsiKerningPairs { get; set; }

  /// <summary>
  ///   Use Cached Paragraph Information for Column Balancing.
  /// </summary>
  public bool? CachedColumnBalance { get; set; }

  public CompatibilitySettings? CompatibilitySettings { get; set; }
}