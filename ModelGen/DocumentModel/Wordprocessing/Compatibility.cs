namespace DocumentModel.Wordprocessing;


/// <summary>
///   Compatibility Settings.
/// </summary>
public partial class Compatibility
{
  
  /// <summary>
  ///   Use Simplified Rules For Table Border Conflicts.
  /// </summary>
  public DocumentModel.Wordprocessing.UseSingleBorderForContiguousCells? UseSingleBorderForContiguousCells { get; set; }
  
  
  /// <summary>
  ///   Emulate WordPerfect 6.x Paragraph Justification.
  /// </summary>
  public DocumentModel.Wordprocessing.WordPerfectJustification? WordPerfectJustification { get; set; }
  
  
  /// <summary>
  ///   Do Not Create Custom Tab Stop for Hanging Indent.
  /// </summary>
  public DocumentModel.Wordprocessing.NoTabHangIndent? NoTabHangIndent { get; set; }
  
  
  /// <summary>
  ///   Do Not Add Leading Between Lines of Text.
  /// </summary>
  public DocumentModel.Wordprocessing.NoLeading? NoLeading { get; set; }
  
  
  /// <summary>
  ///   Add Additional Space Below Baseline For Underlined East Asian Text.
  /// </summary>
  public DocumentModel.Wordprocessing.SpaceForUnderline? SpaceForUnderline { get; set; }
  
  
  /// <summary>
  ///   Do Not Balance Text Columns within a Section.
  /// </summary>
  public DocumentModel.Wordprocessing.NoColumnBalance? NoColumnBalance { get; set; }
  
  
  /// <summary>
  ///   Balance Single Byte and Double Byte Characters.
  /// </summary>
  public DocumentModel.Wordprocessing.BalanceSingleByteDoubleByteWidth? BalanceSingleByteDoubleByteWidth { get; set; }
  
  
  /// <summary>
  ///   Do Not Center Content on Lines With Exact Line Height.
  /// </summary>
  public DocumentModel.Wordprocessing.NoExtraLineSpacing? NoExtraLineSpacing { get; set; }
  
  
  /// <summary>
  ///   Convert Backslash To Yen Sign When Entered.
  /// </summary>
  public DocumentModel.Wordprocessing.DoNotLeaveBackslashAlone? DoNotLeaveBackslashAlone { get; set; }
  
  
  /// <summary>
  ///   Underline All Trailing Spaces.
  /// </summary>
  public DocumentModel.Wordprocessing.UnderlineTrailingSpaces? UnderlineTrailingSpaces { get; set; }
  
  
  /// <summary>
  ///   Don't Justify Lines Ending in Soft Line Break.
  /// </summary>
  public DocumentModel.Wordprocessing.DoNotExpandShiftReturn? DoNotExpandShiftReturn { get; set; }
  
  
  /// <summary>
  ///   Only Expand/Condense Text By Whole Points.
  /// </summary>
  public DocumentModel.Wordprocessing.SpacingInWholePoints? SpacingInWholePoints { get; set; }
  
  
  /// <summary>
  ///   Emulate Word 6.0 Line Wrapping for East Asian Text.
  /// </summary>
  public DocumentModel.Wordprocessing.LineWrapLikeWord6? LineWrapLikeWord6 { get; set; }
  
  
  /// <summary>
  ///   Print Body Text before Header/Footer Contents.
  /// </summary>
  public DocumentModel.Wordprocessing.PrintBodyTextBeforeHeader? PrintBodyTextBeforeHeader { get; set; }
  
  
  /// <summary>
  ///   Print Colors as Black And White without Dithering.
  /// </summary>
  public DocumentModel.Wordprocessing.PrintColorBlackWhite? PrintColorBlackWhite { get; set; }
  
  
  /// <summary>
  ///   Space width.
  /// </summary>
  public DocumentModel.Wordprocessing.WordPerfectSpaceWidth? WordPerfectSpaceWidth { get; set; }
  
  
  /// <summary>
  ///   Display Page/Column Breaks Present in Frames.
  /// </summary>
  public DocumentModel.Wordprocessing.ShowBreaksInFrames? ShowBreaksInFrames { get; set; }
  
  
  /// <summary>
  ///   Increase Priority Of Font Size During Font Substitution.
  /// </summary>
  public DocumentModel.Wordprocessing.SubFontBySize? SubFontBySize { get; set; }
  
  
  /// <summary>
  ///   Ignore Exact Line Height for Last Line on Page.
  /// </summary>
  public DocumentModel.Wordprocessing.SuppressBottomSpacing? SuppressBottomSpacing { get; set; }
  
  
  /// <summary>
  ///   Ignore Minimum and Exact Line Height for First Line on Page.
  /// </summary>
  public DocumentModel.Wordprocessing.SuppressTopSpacing? SuppressTopSpacing { get; set; }
  
  
  /// <summary>
  ///   Ignore Minimum Line Height for First Line on Page.
  /// </summary>
  public DocumentModel.Wordprocessing.SuppressSpacingAtTopOfPage? SuppressSpacingAtTopOfPage { get; set; }
  
  
  /// <summary>
  ///   Emulate WordPerfect 5.x Line Spacing.
  /// </summary>
  public DocumentModel.Wordprocessing.SuppressTopSpacingWordPerfect? SuppressTopSpacingWordPerfect { get; set; }
  
  
  /// <summary>
  ///   Do Not Use Space Before On First Line After a Page Break.
  /// </summary>
  public DocumentModel.Wordprocessing.SuppressSpacingBeforeAfterPageBreak? SuppressSpacingBeforeAfterPageBreak { get; set; }
  
  
  /// <summary>
  ///   Swap Paragraph Borders on Odd Numbered Pages.
  /// </summary>
  public DocumentModel.Wordprocessing.SwapBordersFacingPages? SwapBordersFacingPages { get; set; }
  
  
  /// <summary>
  ///   Treat Backslash Quotation Delimiter as Two Quotation Marks.
  /// </summary>
  public DocumentModel.Wordprocessing.ConvertMailMergeEscape? ConvertMailMergeEscape { get; set; }
  
  
  /// <summary>
  ///   Emulate WordPerfect 6.x Font Height Calculation.
  /// </summary>
  public DocumentModel.Wordprocessing.TruncateFontHeightsLikeWordPerfect? TruncateFontHeightsLikeWordPerfect { get; set; }
  
  
  /// <summary>
  ///   Emulate Word 5.x for the Macintosh Small Caps Formatting.
  /// </summary>
  public DocumentModel.Wordprocessing.MacWordSmallCaps? MacWordSmallCaps { get; set; }
  
  
  /// <summary>
  ///   Use Printer Metrics To Display Documents.
  /// </summary>
  public DocumentModel.Wordprocessing.UsePrinterMetrics? UsePrinterMetrics { get; set; }
  
  
  /// <summary>
  ///   Do Not Suppress Paragraph Borders Next To Frames.
  /// </summary>
  public DocumentModel.Wordprocessing.DoNotSuppressParagraphBorders? DoNotSuppressParagraphBorders { get; set; }
  
  
  /// <summary>
  ///   Line Wrap Trailing Spaces.
  /// </summary>
  public DocumentModel.Wordprocessing.WrapTrailSpaces? WrapTrailSpaces { get; set; }
  
  
  /// <summary>
  ///   Emulate Word 6.x/95/97 Footnote Placement.
  /// </summary>
  public DocumentModel.Wordprocessing.FootnoteLayoutLikeWord8? FootnoteLayoutLikeWord8 { get; set; }
  
  
  /// <summary>
  ///   Emulate Word 97 Text Wrapping Around Floating Objects.
  /// </summary>
  public DocumentModel.Wordprocessing.ShapeLayoutLikeWord8? ShapeLayoutLikeWord8 { get; set; }
  
  
  /// <summary>
  ///   Align Table Rows Independently.
  /// </summary>
  public DocumentModel.Wordprocessing.AlignTablesRowByRow? AlignTablesRowByRow { get; set; }
  
  
  /// <summary>
  ///   Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
  /// </summary>
  public DocumentModel.Wordprocessing.ForgetLastTabAlignment? ForgetLastTabAlignment { get; set; }
  
  
  /// <summary>
  ///   Add Document Grid Line Pitch To Lines in Table Cells.
  /// </summary>
  public DocumentModel.Wordprocessing.AdjustLineHeightInTable? AdjustLineHeightInTable { get; set; }
  
  
  /// <summary>
  ///   Emulate Word 95 Full-Width Character Spacing.
  /// </summary>
  public DocumentModel.Wordprocessing.AutoSpaceLikeWord95? AutoSpaceLikeWord95 { get; set; }
  
  
  /// <summary>
  ///   Do Not Increase Line Height for Raised/Lowered Text.
  /// </summary>
  public DocumentModel.Wordprocessing.NoSpaceRaiseLower? NoSpaceRaiseLower { get; set; }
  
  
  /// <summary>
  ///   Use Fixed Paragraph Spacing for HTML Auto Setting.
  /// </summary>
  public DocumentModel.Wordprocessing.DoNotUseHTMLParagraphAutoSpacing? DoNotUseHTMLParagraphAutoSpacing { get; set; }
  
  
  /// <summary>
  ///   Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
  /// </summary>
  public DocumentModel.Wordprocessing.LayoutRawTableWidth? LayoutRawTableWidth { get; set; }
  
  
  /// <summary>
  ///   Emulate Word 97 East Asian Line Breaking.
  /// </summary>
  public DocumentModel.Wordprocessing.UseWord97LineBreakRules? UseWord97LineBreakRules { get; set; }
  
  
  /// <summary>
  ///   Do Not Allow Floating Tables To Break Across Pages.
  /// </summary>
  public DocumentModel.Wordprocessing.DoNotBreakWrappedTables? DoNotBreakWrappedTables { get; set; }
  
  
  /// <summary>
  ///   Do Not Snap to Document Grid in Table Cells with Objects.
  /// </summary>
  public DocumentModel.Wordprocessing.DoNotSnapToGridInCell? DoNotSnapToGridInCell { get; set; }
  
  
  /// <summary>
  ///   Select Field When First or Last Character Is Selected.
  /// </summary>
  public DocumentModel.Wordprocessing.SelectFieldWithFirstOrLastChar? SelectFieldWithFirstOrLastChar { get; set; }
  
  
  /// <summary>
  ///   Use Legacy Ethiopic and Amharic Line Breaking Rules.
  /// </summary>
  public DocumentModel.Wordprocessing.ApplyBreakingRules? ApplyBreakingRules { get; set; }
  
  
  /// <summary>
  ///   Do Not Allow Hanging Punctuation With Character Grid.
  /// </summary>
  public DocumentModel.Wordprocessing.DoNotWrapTextWithPunctuation? DoNotWrapTextWithPunctuation { get; set; }
  
  
  /// <summary>
  ///   Do Not Compress Compressible Characters When Using Document Grid.
  /// </summary>
  public DocumentModel.Wordprocessing.DoNotUseEastAsianBreakRules? DoNotUseEastAsianBreakRules { get; set; }
  
  
  /// <summary>
  ///   Emulate Word 2002 Table Style Rules.
  /// </summary>
  public DocumentModel.Wordprocessing.UseWord2002TableStyleRules? UseWord2002TableStyleRules { get; set; }
  
  
  /// <summary>
  ///   Allow Tables to AutoFit Into Page Margins.
  /// </summary>
  public DocumentModel.Wordprocessing.GrowAutofit? GrowAutofit { get; set; }
  
  
  /// <summary>
  ///   Do Not Bypass East Asian/Complex Script Layout Code.
  /// </summary>
  public DocumentModel.Wordprocessing.UseFarEastLayout? UseFarEastLayout { get; set; }
  
  
  /// <summary>
  ///   Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
  /// </summary>
  public DocumentModel.Wordprocessing.UseNormalStyleForList? UseNormalStyleForList { get; set; }
  
  
  /// <summary>
  ///   Ignore Hanging Indent When Creating Tab Stop After Numbering.
  /// </summary>
  public DocumentModel.Wordprocessing.DoNotUseIndentAsNumberingTabStop? DoNotUseIndentAsNumberingTabStop { get; set; }
  
  
  /// <summary>
  ///   Use Alternate Set of East Asian Line Breaking Rules.
  /// </summary>
  public DocumentModel.Wordprocessing.UseAltKinsokuLineBreakRules? UseAltKinsokuLineBreakRules { get; set; }
  
  
  /// <summary>
  ///   Allow Contextual Spacing of Paragraphs in Tables.
  /// </summary>
  public DocumentModel.Wordprocessing.AllowSpaceOfSameStyleInTable? AllowSpaceOfSameStyleInTable { get; set; }
  
  
  /// <summary>
  ///   Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
  /// </summary>
  public DocumentModel.Wordprocessing.DoNotSuppressIndentation? DoNotSuppressIndentation { get; set; }
  
  
  /// <summary>
  ///   Do Not AutoFit Tables To Fit Next To Wrapped Objects.
  /// </summary>
  public DocumentModel.Wordprocessing.DoNotAutofitConstrainedTables? DoNotAutofitConstrainedTables { get; set; }
  
  
  /// <summary>
  ///   Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
  /// </summary>
  public DocumentModel.Wordprocessing.AutofitToFirstFixedWidthCell? AutofitToFirstFixedWidthCell { get; set; }
  
  
  /// <summary>
  ///   Underline Following Character Following Numbering.
  /// </summary>
  public DocumentModel.Wordprocessing.UnderlineTabInNumberingList? UnderlineTabInNumberingList { get; set; }
  
  
  /// <summary>
  ///   Always Use Fixed Width for Hangul Characters.
  /// </summary>
  public DocumentModel.Wordprocessing.DisplayHangulFixedWidth? DisplayHangulFixedWidth { get; set; }
  
  
  /// <summary>
  ///   Always Move Paragraph Mark to Page after a Page Break.
  /// </summary>
  public DocumentModel.Wordprocessing.SplitPageBreakAndParagraphMark? SplitPageBreakAndParagraphMark { get; set; }
  
  
  /// <summary>
  ///   Don't Vertically Align Cells Containing Floating Objects.
  /// </summary>
  public DocumentModel.Wordprocessing.DoNotVerticallyAlignCellWithShape? DoNotVerticallyAlignCellWithShape { get; set; }
  
  
  /// <summary>
  ///   Don't Break Table Rows Around Floating Tables.
  /// </summary>
  public DocumentModel.Wordprocessing.DoNotBreakConstrainedForcedTable? DoNotBreakConstrainedForcedTable { get; set; }
  
  
  /// <summary>
  ///   Ignore Vertical Alignment in Textboxes.
  /// </summary>
  public DocumentModel.Wordprocessing.DoNotVerticallyAlignInTextBox? DoNotVerticallyAlignInTextBox { get; set; }
  
  
  /// <summary>
  ///   Use ANSI Kerning Pairs from Fonts.
  /// </summary>
  public DocumentModel.Wordprocessing.UseAnsiKerningPairs? UseAnsiKerningPairs { get; set; }
  
  
  /// <summary>
  ///   Use Cached Paragraph Information for Column Balancing.
  /// </summary>
  public DocumentModel.Wordprocessing.CachedColumnBalance? CachedColumnBalance { get; set; }
  
  public DM.ElementCollection<CompatibilitySetting>? Items { get; set; }
  
}
