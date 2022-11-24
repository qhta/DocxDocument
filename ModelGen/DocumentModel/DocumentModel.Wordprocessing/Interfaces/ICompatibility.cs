namespace DocumentModel.Wordprocessing;

/// <summary>
/// Compatibility Settings.
/// </summary>
public interface ICompatibility // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Use Simplified Rules For Table Border Conflicts.
  /// </summary>
  public IUseSingleBorderForContiguousCells? UseSingleBorderForContiguousCells { get ; set; }
  
  /// <summary>
  /// Emulate WordPerfect 6.x Paragraph Justification.
  /// </summary>
  public IWordPerfectJustification? WordPerfectJustification { get ; set; }
  
  /// <summary>
  /// Do Not Create Custom Tab Stop for Hanging Indent.
  /// </summary>
  public INoTabHangIndent? NoTabHangIndent { get ; set; }
  
  /// <summary>
  /// Do Not Add Leading Between Lines of Text.
  /// </summary>
  public INoLeading? NoLeading { get ; set; }
  
  /// <summary>
  /// Add Additional Space Below Baseline For Underlined East Asian Text.
  /// </summary>
  public ISpaceForUnderline? SpaceForUnderline { get ; set; }
  
  /// <summary>
  /// Do Not Balance Text Columns within a Section.
  /// </summary>
  public INoColumnBalance? NoColumnBalance { get ; set; }
  
  /// <summary>
  /// Balance Single Byte and Double Byte Characters.
  /// </summary>
  public IBalanceSingleByteDoubleByteWidth? BalanceSingleByteDoubleByteWidth { get ; set; }
  
  /// <summary>
  /// Do Not Center Content on Lines With Exact Line Height.
  /// </summary>
  public INoExtraLineSpacing? NoExtraLineSpacing { get ; set; }
  
  /// <summary>
  /// Convert Backslash To Yen Sign When Entered.
  /// </summary>
  public IDoNotLeaveBackslashAlone? DoNotLeaveBackslashAlone { get ; set; }
  
  /// <summary>
  /// Underline All Trailing Spaces.
  /// </summary>
  public IUnderlineTrailingSpaces? UnderlineTrailingSpaces { get ; set; }
  
  /// <summary>
  /// Don't Justify Lines Ending in Soft Line Break.
  /// </summary>
  public IDoNotExpandShiftReturn? DoNotExpandShiftReturn { get ; set; }
  
  /// <summary>
  /// Only Expand/Condense Text By Whole Points.
  /// </summary>
  public ISpacingInWholePoints? SpacingInWholePoints { get ; set; }
  
  /// <summary>
  /// Emulate Word 6.0 Line Wrapping for East Asian Text.
  /// </summary>
  public ILineWrapLikeWord6? LineWrapLikeWord6 { get ; set; }
  
  /// <summary>
  /// Print Body Text before Header/Footer Contents.
  /// </summary>
  public IPrintBodyTextBeforeHeader? PrintBodyTextBeforeHeader { get ; set; }
  
  /// <summary>
  /// Print Colors as Black And White without Dithering.
  /// </summary>
  public IPrintColorBlackWhite? PrintColorBlackWhite { get ; set; }
  
  /// <summary>
  /// Space width.
  /// </summary>
  public IWordPerfectSpaceWidth? WordPerfectSpaceWidth { get ; set; }
  
  /// <summary>
  /// Display Page/Column Breaks Present in Frames.
  /// </summary>
  public IShowBreaksInFrames? ShowBreaksInFrames { get ; set; }
  
  /// <summary>
  /// Increase Priority Of Font Size During Font Substitution.
  /// </summary>
  public ISubFontBySize? SubFontBySize { get ; set; }
  
  /// <summary>
  /// Ignore Exact Line Height for Last Line on Page.
  /// </summary>
  public ISuppressBottomSpacing? SuppressBottomSpacing { get ; set; }
  
  /// <summary>
  /// Ignore Minimum and Exact Line Height for First Line on Page.
  /// </summary>
  public ISuppressTopSpacing? SuppressTopSpacing { get ; set; }
  
  /// <summary>
  /// Ignore Minimum Line Height for First Line on Page.
  /// </summary>
  public ISuppressSpacingAtTopOfPage? SuppressSpacingAtTopOfPage { get ; set; }
  
  /// <summary>
  /// Emulate WordPerfect 5.x Line Spacing.
  /// </summary>
  public ISuppressTopSpacingWordPerfect? SuppressTopSpacingWordPerfect { get ; set; }
  
  /// <summary>
  /// Do Not Use Space Before On First Line After a Page Break.
  /// </summary>
  public ISuppressSpacingBeforeAfterPageBreak? SuppressSpacingBeforeAfterPageBreak { get ; set; }
  
  /// <summary>
  /// Swap Paragraph Borders on Odd Numbered Pages.
  /// </summary>
  public ISwapBordersFacingPages? SwapBordersFacingPages { get ; set; }
  
  /// <summary>
  /// Treat Backslash Quotation Delimiter as Two Quotation Marks.
  /// </summary>
  public IConvertMailMergeEscape? ConvertMailMergeEscape { get ; set; }
  
  /// <summary>
  /// Emulate WordPerfect 6.x Font Height Calculation.
  /// </summary>
  public ITruncateFontHeightsLikeWordPerfect? TruncateFontHeightsLikeWordPerfect { get ; set; }
  
  /// <summary>
  /// Emulate Word 5.x for the Macintosh Small Caps Formatting.
  /// </summary>
  public IMacWordSmallCaps? MacWordSmallCaps { get ; set; }
  
  /// <summary>
  /// Use Printer Metrics To Display Documents.
  /// </summary>
  public IUsePrinterMetrics? UsePrinterMetrics { get ; set; }
  
  /// <summary>
  /// Do Not Suppress Paragraph Borders Next To Frames.
  /// </summary>
  public IDoNotSuppressParagraphBorders? DoNotSuppressParagraphBorders { get ; set; }
  
  /// <summary>
  /// Line Wrap Trailing Spaces.
  /// </summary>
  public IWrapTrailSpaces? WrapTrailSpaces { get ; set; }
  
  /// <summary>
  /// Emulate Word 6.x/95/97 Footnote Placement.
  /// </summary>
  public IFootnoteLayoutLikeWord8? FootnoteLayoutLikeWord8 { get ; set; }
  
  /// <summary>
  /// Emulate Word 97 Text Wrapping Around Floating Objects.
  /// </summary>
  public IShapeLayoutLikeWord8? ShapeLayoutLikeWord8 { get ; set; }
  
  /// <summary>
  /// Align Table Rows Independently.
  /// </summary>
  public IAlignTablesRowByRow? AlignTablesRowByRow { get ; set; }
  
  /// <summary>
  /// Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
  /// </summary>
  public IForgetLastTabAlignment? ForgetLastTabAlignment { get ; set; }
  
  /// <summary>
  /// Add Document Grid Line Pitch To Lines in Table Cells.
  /// </summary>
  public IAdjustLineHeightInTable? AdjustLineHeightInTable { get ; set; }
  
  /// <summary>
  /// Emulate Word 95 Full-Width Character Spacing.
  /// </summary>
  public IAutoSpaceLikeWord95? AutoSpaceLikeWord95 { get ; set; }
  
  /// <summary>
  /// Do Not Increase Line Height for Raised/Lowered Text.
  /// </summary>
  public INoSpaceRaiseLower? NoSpaceRaiseLower { get ; set; }
  
  /// <summary>
  /// Use Fixed Paragraph Spacing for HTML Auto Setting.
  /// </summary>
  public IDoNotUseHTMLParagraphAutoSpacing? DoNotUseHTMLParagraphAutoSpacing { get ; set; }
  
  /// <summary>
  /// Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
  /// </summary>
  public ILayoutRawTableWidth? LayoutRawTableWidth { get ; set; }
  
  /// <summary>
  /// Allow Table Rows to Wrap Inline Objects Independently.
  /// </summary>
  public ILayoutTableRowsApart? LayoutTableRowsApart { get ; set; }
  
  /// <summary>
  /// Emulate Word 97 East Asian Line Breaking.
  /// </summary>
  public IUseWord97LineBreakRules? UseWord97LineBreakRules { get ; set; }
  
  /// <summary>
  /// Do Not Allow Floating Tables To Break Across Pages.
  /// </summary>
  public IDoNotBreakWrappedTables? DoNotBreakWrappedTables { get ; set; }
  
  /// <summary>
  /// Do Not Snap to Document Grid in Table Cells with Objects.
  /// </summary>
  public IDoNotSnapToGridInCell? DoNotSnapToGridInCell { get ; set; }
  
  /// <summary>
  /// Select Field When First or Last Character Is Selected.
  /// </summary>
  public ISelectFieldWithFirstOrLastChar? SelectFieldWithFirstOrLastChar { get ; set; }
  
  /// <summary>
  /// Use Legacy Ethiopic and Amharic Line Breaking Rules.
  /// </summary>
  public IApplyBreakingRules? ApplyBreakingRules { get ; set; }
  
  /// <summary>
  /// Do Not Allow Hanging Punctuation With Character Grid.
  /// </summary>
  public IDoNotWrapTextWithPunctuation? DoNotWrapTextWithPunctuation { get ; set; }
  
  /// <summary>
  /// Do Not Compress Compressible Characters When Using Document Grid.
  /// </summary>
  public IDoNotUseEastAsianBreakRules? DoNotUseEastAsianBreakRules { get ; set; }
  
  /// <summary>
  /// Emulate Word 2002 Table Style Rules.
  /// </summary>
  public IUseWord2002TableStyleRules? UseWord2002TableStyleRules { get ; set; }
  
  /// <summary>
  /// Allow Tables to AutoFit Into Page Margins.
  /// </summary>
  public IGrowAutofit? GrowAutofit { get ; set; }
  
  /// <summary>
  /// Do Not Bypass East Asian/Complex Script Layout Code.
  /// </summary>
  public IUseFarEastLayout? UseFarEastLayout { get ; set; }
  
  /// <summary>
  /// Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
  /// </summary>
  public IUseNormalStyleForList? UseNormalStyleForList { get ; set; }
  
  /// <summary>
  /// Ignore Hanging Indent When Creating Tab Stop After Numbering.
  /// </summary>
  public IDoNotUseIndentAsNumberingTabStop? DoNotUseIndentAsNumberingTabStop { get ; set; }
  
  /// <summary>
  /// Use Alternate Set of East Asian Line Breaking Rules.
  /// </summary>
  public IUseAltKinsokuLineBreakRules? UseAltKinsokuLineBreakRules { get ; set; }
  
  /// <summary>
  /// Allow Contextual Spacing of Paragraphs in Tables.
  /// </summary>
  public IAllowSpaceOfSameStyleInTable? AllowSpaceOfSameStyleInTable { get ; set; }
  
  /// <summary>
  /// Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
  /// </summary>
  public IDoNotSuppressIndentation? DoNotSuppressIndentation { get ; set; }
  
  /// <summary>
  /// Do Not AutoFit Tables To Fit Next To Wrapped Objects.
  /// </summary>
  public IDoNotAutofitConstrainedTables? DoNotAutofitConstrainedTables { get ; set; }
  
  /// <summary>
  /// Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
  /// </summary>
  public IAutofitToFirstFixedWidthCell? AutofitToFirstFixedWidthCell { get ; set; }
  
  /// <summary>
  /// Underline Following Character Following Numbering.
  /// </summary>
  public IUnderlineTabInNumberingList? UnderlineTabInNumberingList { get ; set; }
  
  /// <summary>
  /// Always Use Fixed Width for Hangul Characters.
  /// </summary>
  public IDisplayHangulFixedWidth? DisplayHangulFixedWidth { get ; set; }
  
  /// <summary>
  /// Always Move Paragraph Mark to Page after a Page Break.
  /// </summary>
  public ISplitPageBreakAndParagraphMark? SplitPageBreakAndParagraphMark { get ; set; }
  
  /// <summary>
  /// Don't Vertically Align Cells Containing Floating Objects.
  /// </summary>
  public IDoNotVerticallyAlignCellWithShape? DoNotVerticallyAlignCellWithShape { get ; set; }
  
  /// <summary>
  /// Don't Break Table Rows Around Floating Tables.
  /// </summary>
  public IDoNotBreakConstrainedForcedTable? DoNotBreakConstrainedForcedTable { get ; set; }
  
  /// <summary>
  /// Ignore Vertical Alignment in Textboxes.
  /// </summary>
  public IDoNotVerticallyAlignInTextBox? DoNotVerticallyAlignInTextBox { get ; set; }
  
  /// <summary>
  /// Use ANSI Kerning Pairs from Fonts.
  /// </summary>
  public IUseAnsiKerningPairs? UseAnsiKerningPairs { get ; set; }
  
  /// <summary>
  /// Use Cached Paragraph Information for Column Balancing.
  /// </summary>
  public ICachedColumnBalance? CachedColumnBalance { get ; set; }
  
}
