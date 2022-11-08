namespace DocxDocument.Model;

public interface ICompatibilitySettings
{
  /// <summary> 
  /// Add Document Grid Line Pitch To Lines in Table Cells.
  ///</summary> 
  public bool? AdjustLineHeightInTable { get; set; }
  /// <summary> 
  /// Align Table Rows Independently.
  ///</summary> 
  public bool? AlignTablesRowByRow { get; set; }
  /// <summary> 
  /// Allow Contextual Spacing of Paragraphs in Tables.
  ///</summary> 
  public bool? AllowSpaceOfSameStyleInTable { get; set; }
  /// <summary> 
  /// Use Legacy Ethiopic and Amharic Line Breaking Rules.
  ///</summary> 
  public bool? ApplyBreakingRules { get; set; }
  /// <summary> 
  /// Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
  ///</summary> 
  public bool? AutofitToFirstFixedWidthCell { get; set; }
  /// <summary> 
  /// Emulate Word 95 Full-Width Character Spacing.
  ///</summary> 
  public bool? AutoSpaceLikeWord95 { get; set; }
  /// <summary> 
  /// Balance Single Byte and Double Byte Characters.
  ///</summary> 
  public bool? BalanceSingleByteDoubleByteWidth { get; set; }
  /// <summary> 
  /// Use Cached Paragraph Information for Column Balancing.
  ///</summary> 
  public bool? CachedColumnBalance { get; set; }
  /// <summary> 
  /// Treat Backslash Quotation Delimiter as Two Quotation Marks.
  ///</summary> 
  public bool? ConvertMailMergeEscape { get; set; }
  /// <summary> 
  /// Always Use Fixed Width for Hangul Characters.
  ///</summary> 
  public bool? DisplayHangulFixedWidth { get; set; }
  /// <summary> 
  /// Do Not AutoFit Tables To Fit Next To Wrapped Objects.
  ///</summary> 
  public bool? DoNotAutofitConstrainedTables { get; set; }
  /// <summary> 
  /// Don't Break Table Rows Around Floating Tables.
  ///</summary> 
  public bool? DoNotBreakConstrainedForcedTable { get; set; }
  /// <summary> 
  /// Do Not Allow Floating Tables To Break Across Pages.
  ///</summary> 
  public bool? DoNotBreakWrappedTables { get; set; }
  /// <summary> 
  /// Don't Justify Lines Ending in Soft Line Break.
  ///</summary> 
  public bool? DoNotExpandShiftReturn { get; set; }
  /// <summary> 
  /// Convert Backslash To Yen Sign When Entered.
  ///</summary> 
  public bool? DoNotLeaveBackslashAlone { get; set; }
  /// <summary> 
  /// Do Not Snap to Document Grid in Table Cells with Objects.
  ///</summary> 
  public bool? DoNotSnapToGridInCell { get; set; }
  /// <summary> 
  /// Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
  ///</summary> 
  public bool? DoNotSuppressIndentation { get; set; }
  /// <summary> 
  /// Do Not Suppress Paragraph Borders Next To Frames.
  ///</summary> 
  public bool? DoNotSuppressParagraphBorders { get; set; }
  /// <summary> 
  /// Do Not Compress Compressible Characters When Using Document Grid.
  ///</summary> 
  public bool? DoNotUseEastAsianBreakRules { get; set; }
  /// <summary> 
  /// Use Fixed Paragraph Spacing for HTML Auto Setting.
  ///</summary> 
  public bool? DoNotUseHTMLParagraphAutoSpacing { get; set; }
  /// <summary> 
  /// Ignore Hanging Indent When Creating Tab Stop After Numbering.
  ///</summary> 
  public bool? DoNotUseIndentAsNumberingTabStop { get; set; }
  /// <summary> 
  /// Don't Vertically Align Cells Containing Floating Objects.
  ///</summary> 
  public bool? DoNotVerticallyAlignCellWithShape { get; set; }
  /// <summary> 
  /// Ignore Vertical Alignment in Textboxes.
  ///</summary> 
  public bool? DoNotVerticallyAlignInTextBox { get; set; }
  /// <summary> 
  /// Do Not Allow Hanging Punctuation With Character Grid.
  ///</summary> 
  public bool? DoNotWrapTextWithPunctuation { get; set; }
  /// <summary> 
  /// Emulate Word 6.
  ///</summary> 
  public bool? FootnoteLayoutLikeWord8 { get; set; }
  /// <summary> 
  /// Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
  ///</summary> 
  public bool? ForgetLastTabAlignment { get; set; }
  /// <summary> 
  /// Allow Tables to AutoFit Into Page Margins.
  ///</summary> 
  public bool? GrowAutofit { get; set; }
  /// <summary> 
  /// Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
  ///</summary> 
  public bool? LayoutRawTableWidth { get; set; }
  /// <summary> 
  /// Allow Table Rows to Wrap Inline Objects Independently.
  ///</summary> 
  public bool? LayoutTableRowsApart { get; set; }
  /// <summary> 
  /// Emulate Word 6.
  ///</summary> 
  public bool? LineWrapLikeWord6 { get; set; }
  /// <summary> 
  /// Emulate Word 5.
  ///</summary> 
  public bool? MacWordSmallCaps { get; set; }
  /// <summary> 
  /// Do Not Balance Text Columns within a Section.
  ///</summary> 
  public bool? NoColumnBalance { get; set; }
  /// <summary> 
  /// Do Not Center Content on Lines With Exact Line Height.
  ///</summary> 
  public bool? NoExtraLineSpacing { get; set; }
  /// <summary> 
  /// Do Not Add Leading Between Lines of Text.
  ///</summary> 
  public bool? NoLeading { get; set; }
  /// <summary> 
  /// Do Not Increase Line Height for Raised/Lowered Text.
  ///</summary> 
  public bool? NoSpaceRaiseLower { get; set; }
  /// <summary> 
  /// Do Not Create Custom Tab Stop for Hanging Indent.
  ///</summary> 
  public bool? NoTabHangIndent { get; set; }
  /// <summary> 
  /// Print Body Text before Header/Footer Contents.
  ///</summary> 
  public bool? PrintBodyTextBeforeHeader { get; set; }
  /// <summary> 
  /// Print Colors as Black And White without Dithering.
  ///</summary> 
  public bool? PrintColorBlackWhite { get; set; }
  /// <summary> 
  /// Select Field When First or Last Character Is Selected.
  ///</summary> 
  public bool? SelectFieldWithFirstOrLastChar { get; set; }
  /// <summary> 
  /// Emulate Word 97 Text Wrapping Around Floating Objects.
  ///</summary> 
  public bool? ShapeLayoutLikeWord8 { get; set; }
  /// <summary> 
  /// Display Page/Column Breaks Present in Frames.
  ///</summary> 
  public bool? ShowBreaksInFrames { get; set; }
  /// <summary> 
  /// Add Additional Space Below Baseline For Underlined East Asian Text.
  ///</summary> 
  public bool? SpaceForUnderline { get; set; }
  /// <summary> 
  /// Only Expand/Condense Text By Whole Points.
  ///</summary> 
  public bool? SpacingInWholePoints { get; set; }
  /// <summary> 
  /// Always Move Paragraph Mark to Page after a Page Break.
  ///</summary> 
  public bool? SplitPageBreakAndParagraphMark { get; set; }
  /// <summary> 
  /// Increase Priority Of Font Size During Font Substitution.
  ///</summary> 
  public bool? SubFontBySize { get; set; }
  /// <summary> 
  /// Ignore Exact Line Height for Last Line on Page.
  ///</summary> 
  public bool? SuppressBottomSpacing { get; set; }
  /// <summary> 
  /// Ignore Minimum Line Height for First Line on Page.
  ///</summary> 
  public bool? SuppressSpacingAtTopOfPage { get; set; }
  /// <summary> 
  /// Do Not Use Space Before On First Line After a Page Break.
  ///</summary> 
  public bool? SuppressSpacingBeforeAfterPageBreak { get; set; }
  /// <summary> 
  /// Ignore Minimum and Exact Line Height for First Line on Page.
  ///</summary> 
  public bool? SuppressTopSpacing { get; set; }
  /// <summary> 
  /// Emulate WordPerfect 5.
  ///</summary> 
  public bool? SuppressTopSpacingWordPerfect { get; set; }
  /// <summary> 
  /// Swap Paragraph Borders on Odd Numbered Pages.
  ///</summary> 
  public bool? SwapBordersFacingPages { get; set; }
  /// <summary> 
  /// Emulate WordPerfect 6.
  ///</summary> 
  public bool? TruncateFontHeightsLikeWordPerfect { get; set; }
  /// <summary> 
  /// Underline Following Character Following Numbering.
  ///</summary> 
  public bool? UnderlineTabInNumberingList { get; set; }
  /// <summary> 
  /// Underline All Trailing Spaces.
  ///</summary> 
  public bool? UnderlineTrailingSpaces { get; set; }
  /// <summary> 
  /// Use Alternate Set of East Asian Line Breaking Rules.
  ///</summary> 
  public bool? UseAltKinsokuLineBreakRules { get; set; }
  /// <summary> 
  /// Use ANSI Kerning Pairs from Fonts.
  ///</summary> 
  public bool? UseAnsiKerningPairs { get; set; }
  /// <summary> 
  /// Do Not Bypass East Asian/Complex Script Layout Code.
  ///</summary> 
  public bool? UseFarEastLayout { get; set; }
  /// <summary> 
  /// Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
  ///</summary> 
  public bool? UseNormalStyleForList { get; set; }
  /// <summary> 
  /// Use Printer Metrics To Display Documents.
  ///</summary> 
  public bool? UsePrinterMetrics { get; set; }
  /// <summary> 
  /// Use Simplified Rules For Table Border Conflicts.
  ///</summary> 
  public bool? UseSingleBorderForContiguousCells { get; set; }
  /// <summary> 
  /// Emulate Word 2002 Table Style Rules.
  ///</summary> 
  public bool? UseWord2002TableStyleRules { get; set; }
  /// <summary> 
  /// Emulate Word 97 East Asian Line Breaking.
  ///</summary> 
  public bool? UseWord97LineBreakRules { get; set; }
  /// <summary> 
  /// Emulate WordPerfect 6.
  ///</summary> 
  public bool? WordPerfectJustification { get; set; }
  /// <summary> 
  /// Space width.
  ///</summary> 
  public bool? WordPerfectSpaceWidth { get; set; }
  /// <summary> 
  /// Line Wrap Trailing Spaces.
  ///</summary> 
  public bool? WrapTrailSpaces { get; set; }

  /// <summary>
  ///  Specifies the feature set to use when editing the document. Valid values and their meanings are:
  ///  <list type="table">
  ///    <item>
  ///     <term>11</term>
  ///     <description>Use features specified in [MS-DOC].</description>
  ///    </item>
  ///    <item>
  ///     <term>12</term>
  ///     <description>Use word processing features specified in [ECMA-376]. This is the default..</description>
  ///    </item>
  ///    <item>
  ///    <term>14</term>
  ///    <description>
  ///      Use word processing features specified in [ISO/IEC29500-1:2011] and [ISO / IEC29500 - 4:2011]
  ///      as well as those specified in this document with the exception of the features defined by the following elements and/or parts;
  ///      commentsExtended(section 2.1.2), people(enumeration) (section 2.1.3), collapsed(section 2.5.1.3), docId(section 2.5.1.7),
  ///      repeatingSection(section 2.5.1.10), repeatingSectionItem(section 2.5.1.11), chartTrackingRefBased(section 2.5.1.2),
  ///      commentsEx(section 2.5.1.5), people(element) (section 2.5.1.9), color(section 2.5.1.4), dataBinding(section 2.5.1.6),
  ///      appearance(section 2.5.1.1), singleColumnNotes(section 2.5.1.13),
  ///      webExtensionLinked(section 2.5.1.13),(section 2.5.1.12).
  ///    </description>
  ///    </item>
  ///    <item>
  ///      <term>15</term>
  ///      <description>Use word processing features specified in [ISO/IEC29500-1:2011] and [ISO / IEC29500 - 4:2011] as well as those specified in this document.</description>
  ///     </item>
  /// </list>
  /// </summary>
  public int? CompatibilityMode { get; set; }

  /// <summary>
  /// Specifies how the style hierarchy of the document is evaluated.
  /// </summary>
  public bool? OverrideTableStyleFontSizeAndJustification { get; set; }

  /// <summary>
  /// Specifies whether [OpenType] features such as kerning (see [ISO/IEC29500-1:2011] section 17.3.2.19), ligatures,
  /// contextual alternates, stylistic sets, number spacing, and number formatting are to be used when displaying the font.
  /// </summary>
  public bool? EnableOpenTypeFeatures { get; set; }

  /// <summary>
  /// specifies whether the values of the inside and outside attributes of the ind element (as specified in [ISO/IEC29500-1:2011] section 17.3.1.12)
  /// are swapped when displaying paragraphs containing a mirrorIndents element (as specified in [ISO/IEC29500-1:2011] section 17.3.1.18).
  /// </summary>
  public bool? DoNotFlipMirrorIndents { get; set; }

  /// <summary>
  /// Specifies formatting information for the layout and display of multi-row table headers.
  /// </summary>
  public bool? DifferentiateMultirowTableHeaders { get; set; }

  /// <summary>
  /// specifies information about the layout of documents in which a hyphenated word ends a page or column.
  /// If the value of val is false, which is the default, then useWord2013TrackBottomHyphenation(section 2.3.8) controls the layout of the document.
  ///  If the value of val is true, then a line that ends with a hyphenated word is allowed to be the last line in a page or column.
  /// </summary>
  public bool? AllowHyphenationAtTrackBottom { get; set; }

  /// <summary>
  /// Specifies information about the layout of documents in which a hyphenated word ends a page or column.
  /// If the value of val is false, which is the default, then such a hyphenated word is displayed on the following page or column but the rest of the line that contained it is displayed on the previous page.
  /// If the value of val is true, then the line containing such a hyphenated word is displayed on the following page or column.
  /// If useWord2013TrackBottomHyphenation is not present, then the line containing such a hyphenated word is displayed on the following page or column as though useWord2013TrackBottomHyphenation were present with val set to true.
  /// If allowHyphenationAtTrackBottom(section 2.3.7) is set to true, useWord2013TrackBottomHyphenation MUST be ignored.
  /// </summary>
  public bool? UseWord2013TrackBottomHyphenation { get; set; }

  /// <summary>
  /// specifies information about the layout of document content which follows a floating table that breaks across pages.
  /// If the value of val is false, which is the default, then the document content that follows the floating table is added after the end of the table.
  /// If the value of val is true, then the document content that follows the floating table can be added to the same pages as the table.
  /// The content follows the usual page breaking rules and can flow around the table.
  /// </summary>
  public bool? AllowTextAfterFloatingTableBreak { get; set; }
}