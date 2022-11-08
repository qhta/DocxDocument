using System.Runtime.CompilerServices;

namespace DocxDocument.Model;

public class CompatibilitySettings: ICompatibilitySettings, IEnumerable<KeyValuePair<string, object?>>
{
  private Dictionary<object?> Items = new Dictionary<object?>();

  /// <summary> 
  /// Add Document Grid Line Pitch To Lines in Table Cells.
  ///</summary> 
  public bool? AdjustLineHeightInTable
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Align Table Rows Independently.
  ///</summary> 
  public bool? AlignTablesRowByRow
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Allow Contextual Spacing of Paragraphs in Tables.
  ///</summary> 
  public bool? AllowSpaceOfSameStyleInTable
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Use Legacy Ethiopic and Amharic Line Breaking Rules.
  ///</summary> 
  public bool? ApplyBreakingRules
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
  ///</summary> 
  public bool? AutofitToFirstFixedWidthCell
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Emulate Word 95 Full-Width Character Spacing.
  ///</summary> 
  public bool? AutoSpaceLikeWord95
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Balance Single Byte and Double Byte Characters.
  ///</summary> 
  public bool? BalanceSingleByteDoubleByteWidth
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Use Cached Paragraph Information for Column Balancing.
  ///</summary> 
  public bool? CachedColumnBalance
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Treat Backslash Quotation Delimiter as Two Quotation Marks.
  ///</summary> 
  public bool? ConvertMailMergeEscape
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Always Use Fixed Width for Hangul Characters.
  ///</summary> 
  public bool? DisplayHangulFixedWidth
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Do Not AutoFit Tables To Fit Next To Wrapped Objects.
  ///</summary> 
  public bool? DoNotAutofitConstrainedTables
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Don't Break Table Rows Around Floating Tables.
  ///</summary> 
  public bool? DoNotBreakConstrainedForcedTable
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Do Not Allow Floating Tables To Break Across Pages.
  ///</summary> 
  public bool? DoNotBreakWrappedTables
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Don't Justify Lines Ending in Soft Line Break.
  ///</summary> 
  public bool? DoNotExpandShiftReturn
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Convert Backslash To Yen Sign When Entered.
  ///</summary> 
  public bool? DoNotLeaveBackslashAlone
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Do Not Snap to Document Grid in Table Cells with Objects.
  ///</summary> 
  public bool? DoNotSnapToGridInCell
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
  ///</summary> 
  public bool? DoNotSuppressIndentation
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Do Not Suppress Paragraph Borders Next To Frames.
  ///</summary> 
  public bool? DoNotSuppressParagraphBorders
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Do Not Compress Compressible Characters When Using Document Grid.
  ///</summary> 
  public bool? DoNotUseEastAsianBreakRules
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Use Fixed Paragraph Spacing for HTML Auto Setting.
  ///</summary> 
  public bool? DoNotUseHTMLParagraphAutoSpacing
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Ignore Hanging Indent When Creating Tab Stop After Numbering.
  ///</summary> 
  public bool? DoNotUseIndentAsNumberingTabStop
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Don't Vertically Align Cells Containing Floating Objects.
  ///</summary> 
  public bool? DoNotVerticallyAlignCellWithShape
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Ignore Vertical Alignment in Textboxes.
  ///</summary> 
  public bool? DoNotVerticallyAlignInTextBox
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Do Not Allow Hanging Punctuation With Character Grid.
  ///</summary> 
  public bool? DoNotWrapTextWithPunctuation
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Emulate Word 6.
  ///</summary> 
  public bool? FootnoteLayoutLikeWord8
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
  ///</summary> 
  public bool? ForgetLastTabAlignment
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Allow Tables to AutoFit Into Page Margins.
  ///</summary> 
  public bool? GrowAutofit
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
  ///</summary> 
  public bool? LayoutRawTableWidth
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Allow Table Rows to Wrap Inline Objects Independently.
  ///</summary> 
  public bool? LayoutTableRowsApart
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Emulate Word 6.
  ///</summary> 
  public bool? LineWrapLikeWord6
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Gets the local name of the element.
  ///</summary> 
  public bool? MacWordSmallCaps
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Do Not Balance Text Columns within a Section.
  ///</summary> 
  public bool? NoColumnBalance
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Do Not Center Content on Lines With Exact Line Height.
  ///</summary> 
  public bool? NoExtraLineSpacing
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Do Not Add Leading Between Lines of Text.
  ///</summary> 
  public bool? NoLeading
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Do Not Increase Line Height for Raised/Lowered Text.
  ///</summary> 
  public bool? NoSpaceRaiseLower
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Do Not Create Custom Tab Stop for Hanging Indent.
  ///</summary> 
  public bool? NoTabHangIndent
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Print Body Text before Header/Footer Contents.
  ///</summary> 
  public bool? PrintBodyTextBeforeHeader
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Print Colors as Black And White without Dithering.
  ///</summary> 
  public bool? PrintColorBlackWhite
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Select Field When First or Last Character Is Selected.
  ///</summary> 
  public bool? SelectFieldWithFirstOrLastChar
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Emulate Word 97 Text Wrapping Around Floating Objects.
  ///</summary> 
  public bool? ShapeLayoutLikeWord8
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Display Page/Column Breaks Present in Frames.
  ///</summary> 
  public bool? ShowBreaksInFrames
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Add Additional Space Below Baseline For Underlined East Asian Text.
  ///</summary> 
  public bool? SpaceForUnderline
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Only Expand/Condense Text By Whole Points.
  ///</summary> 
  public bool? SpacingInWholePoints
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Always Move Paragraph Mark to Page after a Page Break.
  ///</summary> 
  public bool? SplitPageBreakAndParagraphMark
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Increase Priority Of Font Size During Font Substitution.
  ///</summary> 
  public bool? SubFontBySize
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Ignore Exact Line Height for Last Line on Page.
  ///</summary> 
  public bool? SuppressBottomSpacing
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Ignore Minimum Line Height for First Line on Page.
  ///</summary> 
  public bool? SuppressSpacingAtTopOfPage
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Do Not Use Space Before On First Line After a Page Break.
  ///</summary> 
  public bool? SuppressSpacingBeforeAfterPageBreak
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Ignore Minimum and Exact Line Height for First Line on Page.
  ///</summary> 
  public bool? SuppressTopSpacing
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Emulate WordPerfect 5.
  ///</summary> 
  public bool? SuppressTopSpacingWordPerfect
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Swap Paragraph Borders on Odd Numbered Pages.
  ///</summary> 
  public bool? SwapBordersFacingPages
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Emulate WordPerfect 6.
  ///</summary> 
  public bool? TruncateFontHeightsLikeWordPerfect
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Underline Following Character Following Numbering.
  ///</summary> 
  public bool? UnderlineTabInNumberingList
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Underline All Trailing Spaces.
  ///</summary> 
  public bool? UnderlineTrailingSpaces
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Use Alternate Set of East Asian Line Breaking Rules.
  ///</summary> 
  public bool? UseAltKinsokuLineBreakRules
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Use ANSI Kerning Pairs from Fonts.
  ///</summary> 
  public bool? UseAnsiKerningPairs
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Do Not Bypass East Asian/Complex Script Layout Code.
  ///</summary> 
  public bool? UseFarEastLayout
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
  ///</summary> 
  public bool? UseNormalStyleForList
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Use Printer Metrics To Display Documents.
  ///</summary> 
  public bool? UsePrinterMetrics
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Use Simplified Rules For Table Border Conflicts.
  ///</summary> 
  public bool? UseSingleBorderForContiguousCells
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Emulate Word 2002 Table Style Rules.
  ///</summary> 
  public bool? UseWord2002TableStyleRules
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Emulate Word 97 East Asian Line Breaking.
  ///</summary> 
  public bool? UseWord97LineBreakRules
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Emulate WordPerfect 6.
  ///</summary> 
  public bool? WordPerfectJustification
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Space width.
  ///</summary> 
  public bool? WordPerfectSpaceWidth
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Line Wrap Trailing Spaces.
  ///</summary> 
  public bool? WrapTrailSpaces
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  ///  Specifies the feature set to use when editing the document.
  /// </summary>
  public int? CompatibilityMode
  {
    get => (int?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// Specifies how the style hierarchy of the document is evaluated.
  /// </summary>
  public bool? OverrideTableStyleFontSizeAndJustification
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// Specifies whether [OpenType] features such as kerning (see [ISO/IEC29500-1:2011] section 17.3.2.19), ligatures,
  /// contextual alternates, stylistic sets, number spacing, and number formatting are to be used when displaying the font.
  /// </summary>
  public bool? EnableOpenTypeFeatures
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// specifies whether the values of the inside and outside attributes of the ind element (as specified in [ISO/IEC29500-1:2011] section 17.3.1.12)
  /// are swapped when displaying paragraphs containing a mirrorIndents element (as specified in [ISO/IEC29500-1:2011] section 17.3.1.18).
  /// </summary>
  public bool? DoNotFlipMirrorIndents
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// Specifies formatting information for the layout and display of multi-row table headers.
  /// </summary>
  public bool? DifferentiateMultirowTableHeaders
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }


  /// <summary>
  /// specifies information about the layout of documents in which a hyphenated word ends a page or column.
  /// If the value of val is false, which is the default, then useWord2013TrackBottomHyphenation(section 2.3.8) controls the layout of the document.
  ///  If the value of val is true, then a line that ends with a hyphenated word is allowed to be the last line in a page or column.
  /// </summary>
  public bool? AllowHyphenationAtTrackBottom
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// Specifies information about the layout of documents in which a hyphenated word ends a page or column.
  /// If the value of val is false, which is the default, then such a hyphenated word is displayed on the following page or column but the rest of the line that contained it is displayed on the previous page.
  /// If the value of val is true, then the line containing such a hyphenated word is displayed on the following page or column.
  /// If useWord2013TrackBottomHyphenation is not present, then the line containing such a hyphenated word is displayed on the following page or column as though useWord2013TrackBottomHyphenation were present with val set to true.
  /// If allowHyphenationAtTrackBottom(section 2.3.7) is set to true, useWord2013TrackBottomHyphenation MUST be ignored.
  /// </summary>
  public bool? UseWord2013TrackBottomHyphenation
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// specifies information about the layout of document content which follows a floating table that breaks across pages.
  /// If the value of val is false, which is the default, then the document content that follows the floating table is added after the end of the table.
  /// If the value of val is true, then the document content that follows the floating table can be added to the same pages as the table.
  /// The content follows the usual page breaking rules and can flow around the table.
  /// </summary>
  public bool? AllowTextAfterFloatingTableBreak
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  public void Clear()
  {
    Items.Clear();
  }

  [XmlIgnore]
  public int Count => Items.Count;


  public IEnumerator<KeyValuePair<string, object?>> GetEnumerator()
  {
    return (Items as IEnumerable<KeyValuePair<string, object?>>).GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return Items.GetEnumerator();
  }

  public bool Remove(string name)
  {
    return Items.Remove(name);
  }
}