namespace DocumentModel.Wordprocessing;

/// <summary>
/// Compatibility Settings.
/// </summary>
public interface ICompatibility // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Use Simplified Rules For Table Border Conflicts.
  /// </summary>
  public System.Boolean? UseSingleBorderForContiguousCells { get ; set; }
  
  /// <summary>
  /// Emulate WordPerfect 6.x Paragraph Justification.
  /// </summary>
  public System.Boolean? WordPerfectJustification { get ; set; }
  
  /// <summary>
  /// Do Not Create Custom Tab Stop for Hanging Indent.
  /// </summary>
  public System.Boolean? NoTabHangIndent { get ; set; }
  
  /// <summary>
  /// Do Not Add Leading Between Lines of Text.
  /// </summary>
  public System.Boolean? NoLeading { get ; set; }
  
  /// <summary>
  /// Add Additional Space Below Baseline For Underlined East Asian Text.
  /// </summary>
  public System.Boolean? SpaceForUnderline { get ; set; }
  
  /// <summary>
  /// Do Not Balance Text Columns within a Section.
  /// </summary>
  public System.Boolean? NoColumnBalance { get ; set; }
  
  /// <summary>
  /// Balance Single Byte and Double Byte Characters.
  /// </summary>
  public System.Boolean? BalanceSingleByteDoubleByteWidth { get ; set; }
  
  /// <summary>
  /// Do Not Center Content on Lines With Exact Line Height.
  /// </summary>
  public System.Boolean? NoExtraLineSpacing { get ; set; }
  
  /// <summary>
  /// Convert Backslash To Yen Sign When Entered.
  /// </summary>
  public System.Boolean? DoNotLeaveBackslashAlone { get ; set; }
  
  /// <summary>
  /// Underline All Trailing Spaces.
  /// </summary>
  public System.Boolean? UnderlineTrailingSpaces { get ; set; }
  
  /// <summary>
  /// Don't Justify Lines Ending in Soft Line Break.
  /// </summary>
  public System.Boolean? DoNotExpandShiftReturn { get ; set; }
  
  /// <summary>
  /// Only Expand/Condense Text By Whole Points.
  /// </summary>
  public System.Boolean? SpacingInWholePoints { get ; set; }
  
  /// <summary>
  /// Emulate Word 6.0 Line Wrapping for East Asian Text.
  /// </summary>
  public System.Boolean? LineWrapLikeWord6 { get ; set; }
  
  /// <summary>
  /// Print Body Text before Header/Footer Contents.
  /// </summary>
  public System.Boolean? PrintBodyTextBeforeHeader { get ; set; }
  
  /// <summary>
  /// Print Colors as Black And White without Dithering.
  /// </summary>
  public System.Boolean? PrintColorBlackWhite { get ; set; }
  
  /// <summary>
  /// Space width.
  /// </summary>
  public System.Boolean? WordPerfectSpaceWidth { get ; set; }
  
  /// <summary>
  /// Display Page/Column Breaks Present in Frames.
  /// </summary>
  public System.Boolean? ShowBreaksInFrames { get ; set; }
  
  /// <summary>
  /// Increase Priority Of Font Size During Font Substitution.
  /// </summary>
  public System.Boolean? SubFontBySize { get ; set; }
  
  /// <summary>
  /// Ignore Exact Line Height for Last Line on Page.
  /// </summary>
  public System.Boolean? SuppressBottomSpacing { get ; set; }
  
  /// <summary>
  /// Ignore Minimum and Exact Line Height for First Line on Page.
  /// </summary>
  public System.Boolean? SuppressTopSpacing { get ; set; }
  
  /// <summary>
  /// Ignore Minimum Line Height for First Line on Page.
  /// </summary>
  public System.Boolean? SuppressSpacingAtTopOfPage { get ; set; }
  
  /// <summary>
  /// Emulate WordPerfect 5.x Line Spacing.
  /// </summary>
  public System.Boolean? SuppressTopSpacingWordPerfect { get ; set; }
  
  /// <summary>
  /// Do Not Use Space Before On First Line After a Page Break.
  /// </summary>
  public System.Boolean? SuppressSpacingBeforeAfterPageBreak { get ; set; }
  
  /// <summary>
  /// Swap Paragraph Borders on Odd Numbered Pages.
  /// </summary>
  public System.Boolean? SwapBordersFacingPages { get ; set; }
  
  /// <summary>
  /// Treat Backslash Quotation Delimiter as Two Quotation Marks.
  /// </summary>
  public System.Boolean? ConvertMailMergeEscape { get ; set; }
  
  /// <summary>
  /// Emulate WordPerfect 6.x Font Height Calculation.
  /// </summary>
  public System.Boolean? TruncateFontHeightsLikeWordPerfect { get ; set; }
  
  /// <summary>
  /// Emulate Word 5.x for the Macintosh Small Caps Formatting.
  /// </summary>
  public System.Boolean? MacWordSmallCaps { get ; set; }
  
  /// <summary>
  /// Use Printer Metrics To Display Documents.
  /// </summary>
  public System.Boolean? UsePrinterMetrics { get ; set; }
  
  /// <summary>
  /// Do Not Suppress Paragraph Borders Next To Frames.
  /// </summary>
  public System.Boolean? DoNotSuppressParagraphBorders { get ; set; }
  
  /// <summary>
  /// Line Wrap Trailing Spaces.
  /// </summary>
  public System.Boolean? WrapTrailSpaces { get ; set; }
  
  /// <summary>
  /// Emulate Word 6.x/95/97 Footnote Placement.
  /// </summary>
  public System.Boolean? FootnoteLayoutLikeWord8 { get ; set; }
  
  /// <summary>
  /// Emulate Word 97 Text Wrapping Around Floating Objects.
  /// </summary>
  public System.Boolean? ShapeLayoutLikeWord8 { get ; set; }
  
  /// <summary>
  /// Align Table Rows Independently.
  /// </summary>
  public System.Boolean? AlignTablesRowByRow { get ; set; }
  
  /// <summary>
  /// Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
  /// </summary>
  public System.Boolean? ForgetLastTabAlignment { get ; set; }
  
  /// <summary>
  /// Add Document Grid Line Pitch To Lines in Table Cells.
  /// </summary>
  public System.Boolean? AdjustLineHeightInTable { get ; set; }
  
  /// <summary>
  /// Emulate Word 95 Full-Width Character Spacing.
  /// </summary>
  public System.Boolean? AutoSpaceLikeWord95 { get ; set; }
  
  /// <summary>
  /// Do Not Increase Line Height for Raised/Lowered Text.
  /// </summary>
  public System.Boolean? NoSpaceRaiseLower { get ; set; }
  
  /// <summary>
  /// Use Fixed Paragraph Spacing for HTML Auto Setting.
  /// </summary>
  public System.Boolean? DoNotUseHTMLParagraphAutoSpacing { get ; set; }
  
  /// <summary>
  /// Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
  /// </summary>
  public System.Boolean? LayoutRawTableWidth { get ; set; }
  
  /// <summary>
  /// Allow Table Rows to Wrap Inline Objects Independently.
  /// </summary>
  public System.Boolean? LayoutTableRowsApart { get ; set; }
  
  /// <summary>
  /// Emulate Word 97 East Asian Line Breaking.
  /// </summary>
  public System.Boolean? UseWord97LineBreakRules { get ; set; }
  
  /// <summary>
  /// Do Not Allow Floating Tables To Break Across Pages.
  /// </summary>
  public System.Boolean? DoNotBreakWrappedTables { get ; set; }
  
  /// <summary>
  /// Do Not Snap to Document Grid in Table Cells with Objects.
  /// </summary>
  public System.Boolean? DoNotSnapToGridInCell { get ; set; }
  
  /// <summary>
  /// Select Field When First or Last Character Is Selected.
  /// </summary>
  public System.Boolean? SelectFieldWithFirstOrLastChar { get ; set; }
  
  /// <summary>
  /// Use Legacy Ethiopic and Amharic Line Breaking Rules.
  /// </summary>
  public System.Boolean? ApplyBreakingRules { get ; set; }
  
  /// <summary>
  /// Do Not Allow Hanging Punctuation With Character Grid.
  /// </summary>
  public System.Boolean? DoNotWrapTextWithPunctuation { get ; set; }
  
  /// <summary>
  /// Do Not Compress Compressible Characters When Using Document Grid.
  /// </summary>
  public System.Boolean? DoNotUseEastAsianBreakRules { get ; set; }
  
  /// <summary>
  /// Emulate Word 2002 Table Style Rules.
  /// </summary>
  public System.Boolean? UseWord2002TableStyleRules { get ; set; }
  
  /// <summary>
  /// Allow Tables to AutoFit Into Page Margins.
  /// </summary>
  public System.Boolean? GrowAutofit { get ; set; }
  
  /// <summary>
  /// Do Not Bypass East Asian/Complex Script Layout Code.
  /// </summary>
  public System.Boolean? UseFarEastLayout { get ; set; }
  
  /// <summary>
  /// Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
  /// </summary>
  public System.Boolean? UseNormalStyleForList { get ; set; }
  
  /// <summary>
  /// Ignore Hanging Indent When Creating Tab Stop After Numbering.
  /// </summary>
  public System.Boolean? DoNotUseIndentAsNumberingTabStop { get ; set; }
  
  /// <summary>
  /// Use Alternate Set of East Asian Line Breaking Rules.
  /// </summary>
  public System.Boolean? UseAltKinsokuLineBreakRules { get ; set; }
  
  /// <summary>
  /// Allow Contextual Spacing of Paragraphs in Tables.
  /// </summary>
  public System.Boolean? AllowSpaceOfSameStyleInTable { get ; set; }
  
  /// <summary>
  /// Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
  /// </summary>
  public System.Boolean? DoNotSuppressIndentation { get ; set; }
  
  /// <summary>
  /// Do Not AutoFit Tables To Fit Next To Wrapped Objects.
  /// </summary>
  public System.Boolean? DoNotAutofitConstrainedTables { get ; set; }
  
  /// <summary>
  /// Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
  /// </summary>
  public System.Boolean? AutofitToFirstFixedWidthCell { get ; set; }
  
  /// <summary>
  /// Underline Following Character Following Numbering.
  /// </summary>
  public System.Boolean? UnderlineTabInNumberingList { get ; set; }
  
  /// <summary>
  /// Always Use Fixed Width for Hangul Characters.
  /// </summary>
  public System.Boolean? DisplayHangulFixedWidth { get ; set; }
  
  /// <summary>
  /// Always Move Paragraph Mark to Page after a Page Break.
  /// </summary>
  public System.Boolean? SplitPageBreakAndParagraphMark { get ; set; }
  
  /// <summary>
  /// Don't Vertically Align Cells Containing Floating Objects.
  /// </summary>
  public System.Boolean? DoNotVerticallyAlignCellWithShape { get ; set; }
  
  /// <summary>
  /// Don't Break Table Rows Around Floating Tables.
  /// </summary>
  public System.Boolean? DoNotBreakConstrainedForcedTable { get ; set; }
  
  /// <summary>
  /// Ignore Vertical Alignment in Textboxes.
  /// </summary>
  public System.Boolean? DoNotVerticallyAlignInTextBox { get ; set; }
  
  /// <summary>
  /// Use ANSI Kerning Pairs from Fonts.
  /// </summary>
  public System.Boolean? UseAnsiKerningPairs { get ; set; }
  
  /// <summary>
  /// Use Cached Paragraph Information for Column Balancing.
  /// </summary>
  public System.Boolean? CachedColumnBalance { get ; set; }
  
}
