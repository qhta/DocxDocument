namespace DocumentModel.Wordprocessing;


/// <summary>
///   Compatibility Settings.
/// </summary>
public partial class Compatibility
{
  
  /// <summary>
  ///   Use Simplified Rules For Table Border Conflicts.
  /// </summary>
  public DMW.UseSingleBorderForContiguousCells? UseSingleBorderForContiguousCells { get; set; }
  
  
  /// <summary>
  ///   Emulate WordPerfect 6.x Paragraph Justification.
  /// </summary>
  public DMW.WordPerfectJustification? WordPerfectJustification { get; set; }
  
  
  /// <summary>
  ///   Do Not Create Custom Tab Stop for Hanging Indent.
  /// </summary>
  public DMW.NoTabHangIndent? NoTabHangIndent { get; set; }
  
  
  /// <summary>
  ///   Do Not Add Leading Between Lines of Text.
  /// </summary>
  public DMW.NoLeading? NoLeading { get; set; }
  
  
  /// <summary>
  ///   Add Additional Space Below Baseline For Underlined East Asian Text.
  /// </summary>
  public DMW.SpaceForUnderline? SpaceForUnderline { get; set; }
  
  
  /// <summary>
  ///   Do Not Balance Text Columns within a Section.
  /// </summary>
  public DMW.NoColumnBalance? NoColumnBalance { get; set; }
  
  
  /// <summary>
  ///   Balance Single Byte and Double Byte Characters.
  /// </summary>
  public DMW.BalanceSingleByteDoubleByteWidth? BalanceSingleByteDoubleByteWidth { get; set; }
  
  
  /// <summary>
  ///   Do Not Center Content on Lines With Exact Line Height.
  /// </summary>
  public DMW.NoExtraLineSpacing? NoExtraLineSpacing { get; set; }
  
  
  /// <summary>
  ///   Convert Backslash To Yen Sign When Entered.
  /// </summary>
  public DMW.DoNotLeaveBackslashAlone? DoNotLeaveBackslashAlone { get; set; }
  
  
  /// <summary>
  ///   Underline All Trailing Spaces.
  /// </summary>
  public DMW.UnderlineTrailingSpaces? UnderlineTrailingSpaces { get; set; }
  
  
  /// <summary>
  ///   Don't Justify Lines Ending in Soft Line Break.
  /// </summary>
  public DMW.DoNotExpandShiftReturn? DoNotExpandShiftReturn { get; set; }
  
  
  /// <summary>
  ///   Only Expand/Condense Text By Whole Points.
  /// </summary>
  public DMW.SpacingInWholePoints? SpacingInWholePoints { get; set; }
  
  
  /// <summary>
  ///   Emulate Word 6.0 Line Wrapping for East Asian Text.
  /// </summary>
  public DMW.LineWrapLikeWord6? LineWrapLikeWord6 { get; set; }
  
  
  /// <summary>
  ///   Print Body Text before Header/Footer Contents.
  /// </summary>
  public DMW.PrintBodyTextBeforeHeader? PrintBodyTextBeforeHeader { get; set; }
  
  
  /// <summary>
  ///   Print Colors as Black And White without Dithering.
  /// </summary>
  public DMW.PrintColorBlackWhite? PrintColorBlackWhite { get; set; }
  
  
  /// <summary>
  ///   Space width.
  /// </summary>
  public DMW.WordPerfectSpaceWidth? WordPerfectSpaceWidth { get; set; }
  
  
  /// <summary>
  ///   Display Page/Column Breaks Present in Frames.
  /// </summary>
  public DMW.ShowBreaksInFrames? ShowBreaksInFrames { get; set; }
  
  
  /// <summary>
  ///   Increase Priority Of Font Size During Font Substitution.
  /// </summary>
  public DMW.SubFontBySize? SubFontBySize { get; set; }
  
  
  /// <summary>
  ///   Ignore Exact Line Height for Last Line on Page.
  /// </summary>
  public DMW.SuppressBottomSpacing? SuppressBottomSpacing { get; set; }
  
  
  /// <summary>
  ///   Ignore Minimum and Exact Line Height for First Line on Page.
  /// </summary>
  public DMW.SuppressTopSpacing? SuppressTopSpacing { get; set; }
  
  
  /// <summary>
  ///   Ignore Minimum Line Height for First Line on Page.
  /// </summary>
  public DMW.SuppressSpacingAtTopOfPage? SuppressSpacingAtTopOfPage { get; set; }
  
  
  /// <summary>
  ///   Emulate WordPerfect 5.x Line Spacing.
  /// </summary>
  public DMW.SuppressTopSpacingWordPerfect? SuppressTopSpacingWordPerfect { get; set; }
  
  
  /// <summary>
  ///   Do Not Use Space Before On First Line After a Page Break.
  /// </summary>
  public DMW.SuppressSpacingBeforeAfterPageBreak? SuppressSpacingBeforeAfterPageBreak { get; set; }
  
  
  /// <summary>
  ///   Swap Paragraph Borders on Odd Numbered Pages.
  /// </summary>
  public DMW.SwapBordersFacingPages? SwapBordersFacingPages { get; set; }
  
  
  /// <summary>
  ///   Treat Backslash Quotation Delimiter as Two Quotation Marks.
  /// </summary>
  public DMW.ConvertMailMergeEscape? ConvertMailMergeEscape { get; set; }
  
  
  /// <summary>
  ///   Emulate WordPerfect 6.x Font Height Calculation.
  /// </summary>
  public DMW.TruncateFontHeightsLikeWordPerfect? TruncateFontHeightsLikeWordPerfect { get; set; }
  
  
  /// <summary>
  ///   Emulate Word 5.x for the Macintosh Small Caps Formatting.
  /// </summary>
  public DMW.MacWordSmallCaps? MacWordSmallCaps { get; set; }
  
  
  /// <summary>
  ///   Use Printer Metrics To Display Documents.
  /// </summary>
  public DMW.UsePrinterMetrics? UsePrinterMetrics { get; set; }
  
  
  /// <summary>
  ///   Do Not Suppress Paragraph Borders Next To Frames.
  /// </summary>
  public DMW.DoNotSuppressParagraphBorders? DoNotSuppressParagraphBorders { get; set; }
  
  
  /// <summary>
  ///   Line Wrap Trailing Spaces.
  /// </summary>
  public DMW.WrapTrailSpaces? WrapTrailSpaces { get; set; }
  
  
  /// <summary>
  ///   Emulate Word 6.x/95/97 Footnote Placement.
  /// </summary>
  public DMW.FootnoteLayoutLikeWord8? FootnoteLayoutLikeWord8 { get; set; }
  
  
  /// <summary>
  ///   Emulate Word 97 Text Wrapping Around Floating Objects.
  /// </summary>
  public DMW.ShapeLayoutLikeWord8? ShapeLayoutLikeWord8 { get; set; }
  
  
  /// <summary>
  ///   Align Table Rows Independently.
  /// </summary>
  public DMW.AlignTablesRowByRow? AlignTablesRowByRow { get; set; }
  
  
  /// <summary>
  ///   Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
  /// </summary>
  public DMW.ForgetLastTabAlignment? ForgetLastTabAlignment { get; set; }
  
  
  /// <summary>
  ///   Add Document Grid Line Pitch To Lines in Table Cells.
  /// </summary>
  public DMW.AdjustLineHeightInTable? AdjustLineHeightInTable { get; set; }
  
  
  /// <summary>
  ///   Emulate Word 95 Full-Width Character Spacing.
  /// </summary>
  public DMW.AutoSpaceLikeWord95? AutoSpaceLikeWord95 { get; set; }
  
  
  /// <summary>
  ///   Do Not Increase Line Height for Raised/Lowered Text.
  /// </summary>
  public DMW.NoSpaceRaiseLower? NoSpaceRaiseLower { get; set; }
  
  
  /// <summary>
  ///   Use Fixed Paragraph Spacing for HTML Auto Setting.
  /// </summary>
  public DMW.DoNotUseHTMLParagraphAutoSpacing? DoNotUseHTMLParagraphAutoSpacing { get; set; }
  
  
  /// <summary>
  ///   Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
  /// </summary>
  public DMW.LayoutRawTableWidth? LayoutRawTableWidth { get; set; }
  
  
  /// <summary>
  ///   Emulate Word 97 East Asian Line Breaking.
  /// </summary>
  public DMW.UseWord97LineBreakRules? UseWord97LineBreakRules { get; set; }
  
  
  /// <summary>
  ///   Do Not Allow Floating Tables To Break Across Pages.
  /// </summary>
  public DMW.DoNotBreakWrappedTables? DoNotBreakWrappedTables { get; set; }
  
  
  /// <summary>
  ///   Do Not Snap to Document Grid in Table Cells with Objects.
  /// </summary>
  public DMW.DoNotSnapToGridInCell? DoNotSnapToGridInCell { get; set; }
  
  
  /// <summary>
  ///   Select Field When First or Last Character Is Selected.
  /// </summary>
  public DMW.SelectFieldWithFirstOrLastChar? SelectFieldWithFirstOrLastChar { get; set; }
  
  
  /// <summary>
  ///   Use Legacy Ethiopic and Amharic Line Breaking Rules.
  /// </summary>
  public DMW.ApplyBreakingRules? ApplyBreakingRules { get; set; }
  
  
  /// <summary>
  ///   Do Not Allow Hanging Punctuation With Character Grid.
  /// </summary>
  public DMW.DoNotWrapTextWithPunctuation? DoNotWrapTextWithPunctuation { get; set; }
  
  
  /// <summary>
  ///   Do Not Compress Compressible Characters When Using Document Grid.
  /// </summary>
  public DMW.DoNotUseEastAsianBreakRules? DoNotUseEastAsianBreakRules { get; set; }
  
  
  /// <summary>
  ///   Emulate Word 2002 Table Style Rules.
  /// </summary>
  public DMW.UseWord2002TableStyleRules? UseWord2002TableStyleRules { get; set; }
  
  
  /// <summary>
  ///   Allow Tables to AutoFit Into Page Margins.
  /// </summary>
  public DMW.GrowAutofit? GrowAutofit { get; set; }
  
  
  /// <summary>
  ///   Do Not Bypass East Asian/Complex Script Layout Code.
  /// </summary>
  public DMW.UseFarEastLayout? UseFarEastLayout { get; set; }
  
  
  /// <summary>
  ///   Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
  /// </summary>
  public DMW.UseNormalStyleForList? UseNormalStyleForList { get; set; }
  
  
  /// <summary>
  ///   Ignore Hanging Indent When Creating Tab Stop After Numbering.
  /// </summary>
  public DMW.DoNotUseIndentAsNumberingTabStop? DoNotUseIndentAsNumberingTabStop { get; set; }
  
  
  /// <summary>
  ///   Use Alternate Set of East Asian Line Breaking Rules.
  /// </summary>
  public DMW.UseAltKinsokuLineBreakRules? UseAltKinsokuLineBreakRules { get; set; }
  
  
  /// <summary>
  ///   Allow Contextual Spacing of Paragraphs in Tables.
  /// </summary>
  public DMW.AllowSpaceOfSameStyleInTable? AllowSpaceOfSameStyleInTable { get; set; }
  
  
  /// <summary>
  ///   Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
  /// </summary>
  public DMW.DoNotSuppressIndentation? DoNotSuppressIndentation { get; set; }
  
  
  /// <summary>
  ///   Do Not AutoFit Tables To Fit Next To Wrapped Objects.
  /// </summary>
  public DMW.DoNotAutofitConstrainedTables? DoNotAutofitConstrainedTables { get; set; }
  
  
  /// <summary>
  ///   Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
  /// </summary>
  public DMW.AutofitToFirstFixedWidthCell? AutofitToFirstFixedWidthCell { get; set; }
  
  
  /// <summary>
  ///   Underline Following Character Following Numbering.
  /// </summary>
  public DMW.UnderlineTabInNumberingList? UnderlineTabInNumberingList { get; set; }
  
  
  /// <summary>
  ///   Always Use Fixed Width for Hangul Characters.
  /// </summary>
  public DMW.DisplayHangulFixedWidth? DisplayHangulFixedWidth { get; set; }
  
  
  /// <summary>
  ///   Always Move Paragraph Mark to Page after a Page Break.
  /// </summary>
  public DMW.SplitPageBreakAndParagraphMark? SplitPageBreakAndParagraphMark { get; set; }
  
  
  /// <summary>
  ///   Don't Vertically Align Cells Containing Floating Objects.
  /// </summary>
  public DMW.DoNotVerticallyAlignCellWithShape? DoNotVerticallyAlignCellWithShape { get; set; }
  
  
  /// <summary>
  ///   Don't Break Table Rows Around Floating Tables.
  /// </summary>
  public DMW.DoNotBreakConstrainedForcedTable? DoNotBreakConstrainedForcedTable { get; set; }
  
  
  /// <summary>
  ///   Ignore Vertical Alignment in Textboxes.
  /// </summary>
  public DMW.DoNotVerticallyAlignInTextBox? DoNotVerticallyAlignInTextBox { get; set; }
  
  
  /// <summary>
  ///   Use ANSI Kerning Pairs from Fonts.
  /// </summary>
  public DMW.UseAnsiKerningPairs? UseAnsiKerningPairs { get; set; }
  
  
  /// <summary>
  ///   Use Cached Paragraph Information for Column Balancing.
  /// </summary>
  public DMW.CachedColumnBalance? CachedColumnBalance { get; set; }
  
}
