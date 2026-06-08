namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Compatibility Settings.
/// </summary>
public class Compatibility: ModelElement
{
  /// <summary>
  ///   Use Simplified Rules For ITable IBorder IConflicts.
  /// </summary>
  public bool? UseSingleBorderForContiguousCells { get; set; }

  /// <summary>
  ///   Emulate WordPerfect 6.x IParagraph Justification.
  /// </summary>
  public bool? WordPerfectJustification { get; set; }

  /// <summary>
  ///   Do Not Create Custom Tab Stop for Hanging Indent.
  /// </summary>
  public bool? NoTabHangIndent { get; set; }

  /// <summary>
  ///   Do Not Add Leading Between ILines of Text.
  /// </summary>
  public bool? NoLeading { get; set; }

  /// <summary>
  ///   Add Additional Space Below Baseline For Underlined East Asian Text.
  /// </summary>
  public bool? SpaceForUnderline { get; set; }

  /// <summary>
  ///   Do Not Balance Text IColumns within a ISection.
  /// </summary>
  public bool? NoColumnBalance { get; set; }

  /// <summary>
  ///   Balance Single Byte and Double Byte ICharacters.
  /// </summary>
  public bool? BalanceSingleByteDoubleByteWidth { get; set; }

  /// <summary>
  ///   Do Not Center Content on ILines With Exact ILine Height.
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
  ///   Don't Justify ILines Ending in Soft ILine IBreak.
  /// </summary>
  public bool? DoNotExpandShiftReturn { get; set; }

  /// <summary>
  ///   Only Expand/Condense Text By Whole IPoints.
  /// </summary>
  public bool? SpacingInWholePoints { get; set; }

  /// <summary>
  ///   Emulate Word 6.0 ILine Wrapping for East Asian Text.
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
  ///   Display IPage/IColumn IBreaks Present in IFrames.
  /// </summary>
  public bool? ShowBreaksInFrames { get; set; }

  /// <summary>
  ///   Increase Priority Of IFont Size During IFont Substitution.
  /// </summary>
  public bool? SubFontBySize { get; set; }

  /// <summary>
  ///   Ignore Exact ILine Height for Last ILine on IPage.
  /// </summary>
  public bool? SuppressBottomSpacing { get; set; }

  /// <summary>
  ///   Ignore Minimum and Exact ILine Height for First ILine on IPage.
  /// </summary>
  public bool? SuppressTopSpacing { get; set; }

  /// <summary>
  ///   Ignore Minimum ILine Height for First ILine on IPage.
  /// </summary>
  public bool? SuppressSpacingAtTopOfPage { get; set; }

  /// <summary>
  ///   Emulate WordPerfect 5.x ILine Spacing.
  /// </summary>
  public bool? SuppressTopSpacingWordPerfect { get; set; }

  /// <summary>
  ///   Do Not Use Space Before On First ILine After a IPage IBreak.
  /// </summary>
  public bool? SuppressSpacingBeforeAfterPageBreak { get; set; }

  /// <summary>
  ///   Swap IParagraph IBorders on Odd Numbered IPages.
  /// </summary>
  public bool? SwapBordersFacingPages { get; set; }

  /// <summary>
  ///   Treat Backslash Quotation Delimiter as Two Quotation Marks.
  /// </summary>
  public bool? ConvertMailMergeEscape { get; set; }

  /// <summary>
  ///   Emulate WordPerfect 6.x IFont Height Calculation.
  /// </summary>
  public bool? TruncateFontHeightsLikeWordPerfect { get; set; }

  /// <summary>
  ///   Emulate Word 5.x for the Macintosh Small Caps Formatting.
  /// </summary>
  public bool? MacWordSmallCaps { get; set; }

  /// <summary>
  ///   Use Printer Metrics To Display IDocuments.
  /// </summary>
  public bool? UsePrinterMetrics { get; set; }

  /// <summary>
  ///   Do Not Suppress IParagraph IBorders Next To IFrames.
  /// </summary>
  public bool? DoNotSuppressParagraphBorders { get; set; }

  /// <summary>
  ///   ILine Wrap Trailing Spaces.
  /// </summary>
  public bool? WrapTrailSpaces { get; set; }

  /// <summary>
  ///   Emulate Word 6.x/95/97 IFootnote Placement.
  /// </summary>
  public bool? FootnoteLayoutLikeWord8 { get; set; }

  /// <summary>
  ///   Emulate Word 97 Text Wrapping Around Floating Objects.
  /// </summary>
  public bool? ShapeLayoutLikeWord8 { get; set; }

  /// <summary>
  ///   Align ITable IRows Independently.
  /// </summary>
  public bool? AlignTablesRowByRow { get; set; }

  /// <summary>
  ///   Ignore Width of Last Tab Stop When Aligning IParagraph If It Is Not Left Aligned.
  /// </summary>
  public bool? ForgetLastTabAlignment { get; set; }

  /// <summary>
  ///   Add IDocument Grid ILine Pitch To ILines in ITable ICells.
  /// </summary>
  public bool? AdjustLineHeightInTable { get; set; }

  /// <summary>
  ///   Emulate Word 95 Full-Width Character Spacing.
  /// </summary>
  public bool? AutoSpaceLikeWord95 { get; set; }

  /// <summary>
  ///   Do Not Increase ILine Height for Raised/Lowered Text.
  /// </summary>
  public bool? NoSpaceRaiseLower { get; set; }

  /// <summary>
  ///   Use Fixed IParagraph Spacing for HTML Auto Setting.
  /// </summary>
  public bool? DoNotUseHTMLParagraphAutoSpacing { get; set; }

  /// <summary>
  ///   Ignore Space Before ITable When Deciding If ITable Should Wrap Floating Object.
  /// </summary>
  public bool? LayoutRawTableWidth { get; set; }

  /// <summary>
  ///   Allow ITable IRows Ito Wrap Inline Objects Independently.
  /// </summary>
  public bool? LayoutTableRowsApart { get; set; }

  /// <summary>
  ///   Emulate Word 97 East Asian ILine Breaking.
  /// </summary>
  public bool? UseWord97LineBreakRules { get; set; }

  /// <summary>
  ///   Do Not Allow Floating ITables To IBreak Across IPages.
  /// </summary>
  public bool? DoNotBreakWrappedTables { get; set; }

  /// <summary>
  ///   Do Not Snap Ito IDocument Grid in ITable ICells with Objects.
  /// </summary>
  public bool? DoNotSnapToGridInCell { get; set; }

  /// <summary>
  ///   Select IField When First or Last Character Is Selected.
  /// </summary>
  public bool? SelectFieldWithFirstOrLastChar { get; set; }

  /// <summary>
  ///   Use Legacy Ethiopic and Amharic ILine Breaking Rules.
  /// </summary>
  public bool? ApplyBreakingRules { get; set; }

  /// <summary>
  ///   Do Not Allow Hanging Punctuation With Character Grid.
  /// </summary>
  public bool? DoNotWrapTextWithPunctuation { get; set; }

  /// <summary>
  ///   Do Not Compress Compressible ICharacters When Using IDocument Grid.
  /// </summary>
  public bool? DoNotUseEastAsianBreakRules { get; set; }

  /// <summary>
  ///   Emulate Word 2002 ITable IStyle Rules.
  /// </summary>
  public bool? UseWord2002TableStyleRules { get; set; }

  /// <summary>
  ///   Allow ITables Ito AutoFit Into IPage Margins.
  /// </summary>
  public bool? GrowAutofit { get; set; }

  /// <summary>
  ///   Do Not Bypass East Asian/Complex Script Layout Code.
  /// </summary>
  public bool? UseFarEastLayout { get; set; }

  /// <summary>
  ///   Do Not Automatically Apply IList IParagraph IStyle To Bulleted/Numbered Text.
  /// </summary>
  public bool? UseNormalStyleForList { get; set; }

  /// <summary>
  ///   Ignore Hanging Indent When Creating Tab Stop After Numbering.
  /// </summary>
  public bool? DoNotUseIndentAsNumberingTabStop { get; set; }

  /// <summary>
  ///   Use Alternate Set of East Asian ILine Breaking Rules.
  /// </summary>
  public bool? UseAltKinsokuLineBreakRules { get; set; }

  /// <summary>
  ///   Allow Contextual Spacing of IParagraphs in ITables.
  /// </summary>
  public bool? AllowSpaceOfSameStyleInTable { get; set; }

  /// <summary>
  ///   Do Not Ignore Floating Objects When Calculating IParagraph Indentation.
  /// </summary>
  public bool? DoNotSuppressIndentation { get; set; }

  /// <summary>
  ///   Do Not AutoFit ITables To Fit Next To Wrapped Objects.
  /// </summary>
  public bool? DoNotAutofitConstrainedTables { get; set; }

  /// <summary>
  ///   Allow ITable IColumns To Exceed Preferred Widths of Constituent ICells.
  /// </summary>
  public bool? AutofitToFirstFixedWidthCell { get; set; }

  /// <summary>
  ///   Underline Following Character Following Numbering.
  /// </summary>
  public bool? UnderlineTabInNumberingList { get; set; }

  /// <summary>
  ///   Always Use Fixed Width for Hangul ICharacters.
  /// </summary>
  public bool? DisplayHangulFixedWidth { get; set; }

  /// <summary>
  ///   Always Move IParagraph Mark Ito IPage after a IPage IBreak.
  /// </summary>
  public bool? SplitPageBreakAndParagraphMark { get; set; }

  /// <summary>
  ///   Don't Vertically Align ICells Containing Floating Objects.
  /// </summary>
  public bool? DoNotVerticallyAlignCellWithShape { get; set; }

  /// <summary>
  ///   Don't IBreak ITable IRows Around Floating ITables.
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
  ///   Use Cached IParagraph Information for IColumn Balancing.
  /// </summary>
  public bool? CachedColumnBalance { get; set; }

  public CompatibilitySettings? CompatibilitySettings { get; set; }
}
