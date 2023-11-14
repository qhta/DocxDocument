namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies a set of optional compatibility options for the current document.
/// </summary>
[DataContract]
public partial class Compatibility: ModelElement<DXW.Compatibility>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public Compatibility(): base(){ }

  public Compatibility(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public Compatibility(DXW.Compatibility openXmlElement): base(openXmlElement) { }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  /// <summary>
  /// Use Simplified Rules For Table Border Conflicts.
  /// </summary>
  [DataMember]
  public bool? UseSingleBorderForContiguousCells
  {
    get => _Element?.GetBoolVal<DXW.UseSingleBorderForContiguousCells>();
    set => _ExistingElement.SetBoolVal<DXW.UseSingleBorderForContiguousCells>(value);
  }

  /// <summary>
  /// Emulate WordPerfect 6.x Paragraph Justification.
  /// </summary>
  [DataMember]
  public  bool? WordPerfectJustification
  {
    get => _Element?.GetBoolVal<DXW.WordPerfectJustification>();
    set => _ExistingElement.SetBoolVal<DXW.WordPerfectJustification>(value);
  }

  /// <summary>
  /// Do Not Create Custom Tab Stop for Hanging Indent.
  /// </summary>
  [DataMember]
  public  bool? NoTabHangIndent
  {
    get => _Element?.GetBoolVal<DXW.NoTabHangIndent>();
    set => _ExistingElement.SetBoolVal<DXW.NoTabHangIndent>(value);
  }

  /// <summary>
  /// Do Not Add Leading Between Lines of Text.
  /// </summary>
  [DataMember]
  public  bool? NoLeading
  {
    get => _Element?.GetBoolVal<DXW.NoLeading>();
    set => _ExistingElement.SetBoolVal<DXW.NoLeading>(value);
  }

  /// <summary>
  /// Add Additional Space Below Baseline For Underlined East Asian Text.
  /// </summary>
  [DataMember]
  public  bool? SpaceForUnderline
  {
    get => _Element?.GetBoolVal<DXW.SpaceForUnderline>();
    set => _ExistingElement.SetBoolVal<DXW.SpaceForUnderline>(value);
  }

  /// <summary>
  /// Do Not Balance Text Columns within a Section.
  /// </summary>
  [DataMember]
  public  bool? NoColumnBalance
  {
    get => _Element?.GetBoolVal<DXW.NoColumnBalance>();
    set => _ExistingElement.SetBoolVal<DXW.NoColumnBalance>(value);
  }

  /// <summary>
  /// Balance Single Byte and Double Byte Characters.
  /// </summary>
  [DataMember]
  public  bool? BalanceSingleByteDoubleByteWidth
  {
    get => _Element?.GetBoolVal<DXW.BalanceSingleByteDoubleByteWidth>();
    set => _ExistingElement.SetBoolVal<DXW.BalanceSingleByteDoubleByteWidth>(value);
  }

  /// <summary>
  /// Do Not Center Content on Lines With Exact Line Height.
  /// </summary>
  [DataMember]
  public  bool? NoExtraLineSpacing
  {
    get => _Element?.GetBoolVal<DXW.NoExtraLineSpacing>();
    set => _ExistingElement.SetBoolVal<DXW.NoExtraLineSpacing>(value);
  }

  /// <summary>
  /// Convert Backslash To Yen Sign When Entered.
  /// </summary>
  [DataMember]
  public  bool? DoNotLeaveBackslashAlone
  {
    get => _Element?.GetBoolVal<DXW.DoNotLeaveBackslashAlone>();
    set => _ExistingElement.SetBoolVal<DXW.DoNotLeaveBackslashAlone>(value);
  }

  /// <summary>
  /// Underline All Trailing Spaces.
  /// </summary>
  [DataMember]
  public  bool? UnderlineTrailingSpaces
  {
    get => _Element?.GetBoolVal<DXW.UnderlineTrailingSpaces>();
    set => _ExistingElement.SetBoolVal<DXW.UnderlineTrailingSpaces>(value);
  }

  /// <summary>
  /// Don't Justify Lines Ending in Soft Line Break.
  /// </summary>
  [DataMember]
  public  bool? DoNotExpandShiftReturn
  {
    get => _Element?.GetBoolVal<DXW.DoNotExpandShiftReturn>();
    set => _ExistingElement.SetBoolVal<DXW.DoNotExpandShiftReturn>(value);
  }

  /// <summary>
  /// Only Expand/Condense Text By Whole Points.
  /// </summary>
  [DataMember]
  public  bool? SpacingInWholePoints
  {
    get => _Element?.GetBoolVal<DXW.SpacingInWholePoints>();
    set => _ExistingElement.SetBoolVal<DXW.SpacingInWholePoints>(value);
  }

  /// <summary>
  /// Emulate Word 6.0 Line Wrapping for East Asian Text.
  /// </summary>
  [DataMember]
  public  bool? LineWrapLikeWord6
  {
    get => _Element?.GetBoolVal<DXW.LineWrapLikeWord6>();
    set => _ExistingElement.SetBoolVal<DXW.LineWrapLikeWord6>(value);
  }

  /// <summary>
  /// Print Body Text before Header/Footer Contents.
  /// </summary>
  [DataMember]
  public  bool? PrintBodyTextBeforeHeader
  {
    get => _Element?.GetBoolVal<DXW.PrintBodyTextBeforeHeader>();
    set => _ExistingElement.SetBoolVal<DXW.PrintBodyTextBeforeHeader>(value);
  }

  /// <summary>
  /// Print Colors as Black And White without Dithering.
  /// </summary>
  [DataMember]
  public  bool? PrintColorBlackWhite
  {
    get => _Element?.GetBoolVal<DXW.PrintColorBlackWhite>();
    set => _ExistingElement.SetBoolVal<DXW.PrintColorBlackWhite>(value);
  }

  /// <summary>
  /// Space width.
  /// </summary>
  [DataMember]
  public  bool? WordPerfectSpaceWidth
  {
    get => _Element?.GetBoolVal<DXW.WordPerfectSpaceWidth>();
    set => _ExistingElement.SetBoolVal<DXW.WordPerfectSpaceWidth>(value);
  }

  /// <summary>
  /// Display Page/Column Breaks Present in Frames.
  /// </summary>
  [DataMember]
  public  bool? ShowBreaksInFrames
  {
    get => _Element?.GetBoolVal<DXW.ShowBreaksInFrames>();
    set => _ExistingElement.SetBoolVal<DXW.ShowBreaksInFrames>(value);
  }

  /// <summary>
  /// Increase Priority Of Font Size During Font Substitution.
  /// </summary>
  [DataMember]
  public  bool? SubFontBySize
  {
    get => _Element?.GetBoolVal<DXW.SubFontBySize>();
    set => _ExistingElement.SetBoolVal<DXW.SubFontBySize>(value);
  }

  /// <summary>
  /// Ignore Exact Line Height for Last Line on Page.
  /// </summary>
  [DataMember]
  public  bool? SuppressBottomSpacing
  {
    get => _Element?.GetBoolVal<DXW.SuppressBottomSpacing>();
    set => _ExistingElement.SetBoolVal<DXW.SuppressBottomSpacing>(value);
  }

  /// <summary>
  /// Ignore Minimum and Exact Line Height for First Line on Page.
  /// </summary>
  [DataMember]
  public  bool? SuppressTopSpacing
  {
    get => _Element?.GetBoolVal<DXW.SuppressTopSpacing>();
    set => _ExistingElement.SetBoolVal<DXW.SuppressTopSpacing>(value);
  }

  /// <summary>
  /// Ignore Minimum Line Height for First Line on Page.
  /// </summary>
  [DataMember]
  public  bool? SuppressSpacingAtTopOfPage
  {
    get => _Element?.GetBoolVal<DXW.SuppressSpacingAtTopOfPage>();
    set => _ExistingElement.SetBoolVal<DXW.SuppressSpacingAtTopOfPage>(value);
  }

  /// <summary>
  /// Emulate WordPerfect 5.x Line Spacing.
  /// </summary>
  [DataMember]
  public  bool? SuppressTopSpacingWordPerfect
  {
    get => _Element?.GetBoolVal<DXW.SuppressTopSpacingWordPerfect>();
    set => _ExistingElement.SetBoolVal<DXW.SuppressTopSpacingWordPerfect>(value);
  }

  /// <summary>
  /// Do Not Use Space Before On First Line After a Page Break.
  /// </summary>
  [DataMember]
  public  bool? SuppressSpacingBeforeAfterPageBreak
  {
    get => _Element?.GetBoolVal<DXW.SuppressSpacingBeforeAfterPageBreak>();
    set => _ExistingElement.SetBoolVal<DXW.SuppressSpacingBeforeAfterPageBreak>(value);
  }

  /// <summary>
  /// Swap Paragraph Borders on Odd Numbered Pages.
  /// </summary>
  [DataMember]
  public  bool? SwapBordersFacingPages
  {
    get => _Element?.GetBoolVal<DXW.SwapBordersFacingPages>();
    set => _ExistingElement.SetBoolVal<DXW.SwapBordersFacingPages>(value);
  }

  /// <summary>
  /// Treat Backslash Quotation Delimiter as Two Quotation Marks.
  /// </summary>
  [DataMember]
  public  bool? ConvertMailMergeEscape
  {
    get => _Element?.GetBoolVal<DXW.ConvertMailMergeEscape>();
    set => _ExistingElement.SetBoolVal<DXW.ConvertMailMergeEscape>(value);
  }

  /// <summary>
  /// Emulate WordPerfect 6.x Font Height Calculation.
  /// </summary>
  [DataMember]
  public  bool? TruncateFontHeightsLikeWordPerfect
  {
    get => _Element?.GetBoolVal<DXW.TruncateFontHeightsLikeWordPerfect>();
    set => _ExistingElement.SetBoolVal<DXW.TruncateFontHeightsLikeWordPerfect>(value);
  }

  /// <summary>
  /// Emulate Word 5.x for the Macintosh Small Caps Formatting.
  /// </summary>
  [DataMember]
  public  bool? MacWordSmallCaps
  {
    get => _Element?.GetBoolVal<DXW.MacWordSmallCaps>();
    set => _ExistingElement.SetBoolVal<DXW.MacWordSmallCaps>(value);
  }

  /// <summary>
  /// Use Printer Metrics To Display Documents.
  /// </summary>
  [DataMember]
  public  bool? UsePrinterMetrics
  {
    get => _Element?.GetBoolVal<DXW.UsePrinterMetrics>();
    set => _ExistingElement.SetBoolVal<DXW.UsePrinterMetrics>(value);
  }

  /// <summary>
  /// Do Not Suppress Paragraph Borders Next To Frames.
  /// </summary>
  [DataMember]
  public  bool? DoNotSuppressParagraphBorders
  {
    get => _Element?.GetBoolVal<DXW.DoNotSuppressParagraphBorders>();
    set => _ExistingElement.SetBoolVal<DXW.DoNotSuppressParagraphBorders>(value);
  }

  /// <summary>
  /// Line Wrap Trailing Spaces.
  /// </summary>
  [DataMember]
  public  bool? WrapTrailSpaces
  {
    get => _Element?.GetBoolVal<DXW.WrapTrailSpaces>();
    set => _ExistingElement.SetBoolVal<DXW.WrapTrailSpaces>(value);
  }

  /// <summary>
  /// Emulate Word 6.x/95/97 Footnote Placement.
  /// </summary>
  [DataMember]
  public  bool? FootnoteLayoutLikeWord8
  {
    get => _Element?.GetBoolVal<DXW.FootnoteLayoutLikeWord8>();
    set => _ExistingElement.SetBoolVal<DXW.FootnoteLayoutLikeWord8>(value);
  }

  /// <summary>
  /// Emulate Word 97 Text Wrapping Around Floating Objects.
  /// </summary>
  [DataMember]
  public  bool? ShapeLayoutLikeWord8
  {
    get => _Element?.GetBoolVal<DXW.ShapeLayoutLikeWord8>();
    set => _ExistingElement.SetBoolVal<DXW.ShapeLayoutLikeWord8>(value);
  }

  /// <summary>
  /// Align Table Rows Independently.
  /// </summary>
  [DataMember]
  public  bool? AlignTablesRowByRow
  {
    get => _Element?.GetBoolVal<DXW.AlignTablesRowByRow>();
    set => _ExistingElement.SetBoolVal<DXW.AlignTablesRowByRow>(value);
  }

  /// <summary>
  /// Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
  /// </summary>
  [DataMember]
  public  bool? ForgetLastTabAlignment
  {
    get => _Element?.GetBoolVal<DXW.ForgetLastTabAlignment>();
    set => _ExistingElement.SetBoolVal<DXW.ForgetLastTabAlignment>(value);
  }

  /// <summary>
  /// Add Document Grid Line Pitch To Lines in Table Cells.
  /// </summary>
  [DataMember]
  public  bool? AdjustLineHeightInTable
  {
    get => _Element?.GetBoolVal<DXW.AdjustLineHeightInTable>();
    set => _ExistingElement.SetBoolVal<DXW.AdjustLineHeightInTable>(value);
  }

  /// <summary>
  /// Emulate Word 95 Full-Width Character Spacing.
  /// </summary>
  [DataMember]
  public  bool? AutoSpaceLikeWord95
  {
    get => _Element?.GetBoolVal<DXW.AutoSpaceLikeWord95>();
    set => _ExistingElement.SetBoolVal<DXW.AutoSpaceLikeWord95>(value);
  }

  /// <summary>
  /// Do Not Increase Line Height for Raised/Lowered Text.
  /// </summary>
  [DataMember]
  public  bool? NoSpaceRaiseLower
  {
    get => _Element?.GetBoolVal<DXW.NoSpaceRaiseLower>();
    set => _ExistingElement.SetBoolVal<DXW.NoSpaceRaiseLower>(value);
  }

  /// <summary>
  /// Use Fixed Paragraph Spacing for HTML Auto Setting.
  /// </summary>
  [DataMember]
  public  bool? DoNotUseHTMLParagraphAutoSpacing
  {
    get => _Element?.GetBoolVal<DXW.DoNotUseHTMLParagraphAutoSpacing>();
    set => _ExistingElement.SetBoolVal<DXW.DoNotUseHTMLParagraphAutoSpacing>(value);
  }

  /// <summary>
  /// Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
  /// </summary>
  [DataMember]
  public  bool? LayoutRawTableWidth
  {
    get => _Element?.GetBoolVal<DXW.LayoutRawTableWidth>();
    set => _ExistingElement.SetBoolVal<DXW.LayoutRawTableWidth>(value);
  }

  /// <summary>
  /// Allow Table Rows to Wrap Inline Objects Independently.
  /// </summary>
  [DataMember]
  public  bool? LayoutTableRowsApart
  {
    get => _Element?.GetBoolVal<DXW.LayoutTableRowsApart>();
    set => _ExistingElement.SetBoolVal<DXW.LayoutTableRowsApart>(value);
  }

  /// <summary>
  /// Emulate Word 97 East Asian Line Breaking.
  /// </summary>
  [DataMember]
  public  bool? UseWord97LineBreakRules
  {
    get => _Element?.GetBoolVal<DXW.UseWord97LineBreakRules>();
    set => _ExistingElement.SetBoolVal<DXW.UseWord97LineBreakRules>(value);
  }

  /// <summary>
  /// Do Not Allow Floating Tables To Break Across Pages.
  /// </summary>
  [DataMember]
  public  bool? DoNotBreakWrappedTables
  {
    get => _Element?.GetBoolVal<DXW.DoNotBreakWrappedTables>();
    set => _ExistingElement.SetBoolVal<DXW.DoNotBreakWrappedTables>(value);
  }

  /// <summary>
  /// Do Not Snap to Document Grid in Table Cells with Objects.
  /// </summary>
  [DataMember]
  public  bool? DoNotSnapToGridInCell
  {
    get => _Element?.GetBoolVal<DXW.DoNotSnapToGridInCell>();
    set => _ExistingElement.SetBoolVal<DXW.DoNotSnapToGridInCell>(value);
  }

  /// <summary>
  /// Select Field When First or Last Character Is Selected.
  /// </summary>
  [DataMember]
  public  bool? SelectFieldWithFirstOrLastChar
  {
    get => _Element?.GetBoolVal<DXW.SelectFieldWithFirstOrLastChar>();
    set => _ExistingElement.SetBoolVal<DXW.SelectFieldWithFirstOrLastChar>(value);
  }

  /// <summary>
  /// Use Legacy Ethiopic and Amharic Line Breaking Rules.
  /// </summary>
  [DataMember]
  public  bool? ApplyBreakingRules
  {
    get => _Element?.GetBoolVal<DXW.ApplyBreakingRules>();
    set => _ExistingElement.SetBoolVal<DXW.ApplyBreakingRules>(value);
  }

  /// <summary>
  /// Do Not Allow Hanging Punctuation With Character Grid.
  /// </summary>
  [DataMember]
  public  bool? DoNotWrapTextWithPunctuation
  {
    get => _Element?.GetBoolVal<DXW.DoNotWrapTextWithPunctuation>();
    set => _ExistingElement.SetBoolVal<DXW.DoNotWrapTextWithPunctuation>(value);
  }

  /// <summary>
  /// Do Not Compress Compressible Characters When Using Document Grid.
  /// </summary>
  [DataMember]
  public  bool? DoNotUseEastAsianBreakRules
  {
    get => _Element?.GetBoolVal<DXW.DoNotUseEastAsianBreakRules>();
    set => _ExistingElement.SetBoolVal<DXW.DoNotUseEastAsianBreakRules>(value);
  }

  /// <summary>
  /// Emulate Word 2002 Table Style Rules.
  /// </summary>
  [DataMember]
  public  bool? UseWord2002TableStyleRules
  {
    get => _Element?.GetBoolVal<DXW.UseWord2002TableStyleRules>();
    set => _ExistingElement.SetBoolVal<DXW.UseWord2002TableStyleRules>(value);
  }

  /// <summary>
  /// Allow Tables to AutoFit Into Page Margins.
  /// </summary>
  [DataMember]
  public  bool? GrowAutofit
  {
    get => _Element?.GetBoolVal<DXW.GrowAutofit>();
    set => _ExistingElement.SetBoolVal<DXW.GrowAutofit>(value);
  }

  /// <summary>
  /// Do Not Bypass East Asian/Complex Script Layout Code.
  /// </summary>
  [DataMember]
  public  bool? UseFarEastLayout
  {
    get => _Element?.GetBoolVal<DXW.UseFarEastLayout>();
    set => _ExistingElement.SetBoolVal<DXW.UseFarEastLayout>(value);
  }

  /// <summary>
  /// Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
  /// </summary>
  [DataMember]
  public  bool? UseNormalStyleForList
  {
    get => _Element?.GetBoolVal<DXW.UseNormalStyleForList>();
    set => _ExistingElement.SetBoolVal<DXW.UseNormalStyleForList>(value);
  }

  /// <summary>
  /// Ignore Hanging Indent When Creating Tab Stop After Numbering.
  /// </summary>
  [DataMember]
  public  bool? DoNotUseIndentAsNumberingTabStop
  {
    get => _Element?.GetBoolVal<DXW.DoNotUseIndentAsNumberingTabStop>();
    set => _ExistingElement.SetBoolVal<DXW.DoNotUseIndentAsNumberingTabStop>(value);
  }

  /// <summary>
  /// Use Alternate Set of East Asian Line Breaking Rules.
  /// </summary>
  [DataMember]
  public  bool? UseAltKinsokuLineBreakRules
  {
    get => _Element?.GetBoolVal<DXW.UseAltKinsokuLineBreakRules>();
    set => _ExistingElement.SetBoolVal<DXW.UseAltKinsokuLineBreakRules>(value);
  }

  /// <summary>
  /// Allow Contextual Spacing of Paragraphs in Tables.
  /// </summary>
  [DataMember]
  public  bool? AllowSpaceOfSameStyleInTable
  {
    get => _Element?.GetBoolVal<DXW.AllowSpaceOfSameStyleInTable>();
    set => _ExistingElement.SetBoolVal<DXW.AllowSpaceOfSameStyleInTable>(value);
  }

  /// <summary>
  /// Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
  /// </summary>
  [DataMember]
  public  bool? DoNotSuppressIndentation
  {
    get => _Element?.GetBoolVal<DXW.DoNotSuppressIndentation>();
    set => _ExistingElement.SetBoolVal<DXW.DoNotSuppressIndentation>(value);
  }

  /// <summary>
  /// Do Not AutoFit Tables To Fit Next To Wrapped Objects.
  /// </summary>
  [DataMember]
  public  bool? DoNotAutofitConstrainedTables
  {
    get => _Element?.GetBoolVal<DXW.DoNotAutofitConstrainedTables>();
    set => _ExistingElement.SetBoolVal<DXW.DoNotAutofitConstrainedTables>(value);
  }

  /// <summary>
  /// Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
  /// </summary>
  [DataMember]
  public  bool? AutofitToFirstFixedWidthCell
  {
    get => _Element?.GetBoolVal<DXW.AutofitToFirstFixedWidthCell>();
    set => _ExistingElement.SetBoolVal<DXW.AutofitToFirstFixedWidthCell>(value);
  }

  /// <summary>
  /// Underline Following Character Following Numbering.
  /// </summary>
  [DataMember]
  public  bool? UnderlineTabInNumberingList
  {
    get => _Element?.GetBoolVal<DXW.UnderlineTabInNumberingList>();
    set => _ExistingElement.SetBoolVal<DXW.UnderlineTabInNumberingList>(value);
  }

  /// <summary>
  /// Always Use Fixed Width for Hangul Characters.
  /// </summary>
  [DataMember]
  public  bool? DisplayHangulFixedWidth
  {
    get => _Element?.GetBoolVal<DXW.DisplayHangulFixedWidth>();
    set => _ExistingElement.SetBoolVal<DXW.DisplayHangulFixedWidth>(value);
  }

  /// <summary>
  /// Always Move Paragraph Mark to Page after a Page Break.
  /// </summary>
  [DataMember]
  public  bool? SplitPageBreakAndParagraphMark
  {
    get => _Element?.GetBoolVal<DXW.SplitPageBreakAndParagraphMark>();
    set => _ExistingElement.SetBoolVal<DXW.SplitPageBreakAndParagraphMark>(value);
  }

  /// <summary>
  /// Don't Vertically Align Cells Containing Floating Objects.
  /// </summary>
  [DataMember]
  public  bool? DoNotVerticallyAlignCellWithShape
  {
    get => _Element?.GetBoolVal<DXW.DoNotVerticallyAlignCellWithShape>();
    set => _ExistingElement.SetBoolVal<DXW.DoNotVerticallyAlignCellWithShape>(value);
  }

  /// <summary>
  /// Don't Break Table Rows Around Floating Tables.
  /// </summary>
  [DataMember]
  public  bool? DoNotBreakConstrainedForcedTable
  {
    get => _Element?.GetBoolVal<DXW.DoNotBreakConstrainedForcedTable>();
    set => _ExistingElement.SetBoolVal<DXW.DoNotBreakConstrainedForcedTable>(value);
  }

  /// <summary>
  /// Ignore Vertical Alignment in Textboxes.
  /// </summary>
  [DataMember]
  public  bool? DoNotVerticallyAlignInTextBox
  {
    get => _Element?.GetBoolVal<DXW.DoNotVerticallyAlignInTextBox>();
    set => _ExistingElement.SetBoolVal<DXW.DoNotVerticallyAlignInTextBox>(value);
  }

  /// <summary>
  /// Use ANSI Kerning Pairs from Fonts.
  /// </summary>
  [DataMember]
  public  bool? UseAnsiKerningPairs
  {
    get => _Element?.GetBoolVal<DXW.UseAnsiKerningPairs>();
    set => _ExistingElement.SetBoolVal<DXW.UseAnsiKerningPairs>(value);
  }

  /// <summary>
  /// Use Cached Paragraph Information for Column Balancing.
  /// </summary>
  [DataMember]
  public  bool? CachedColumnBalance
  {
    get => _Element?.GetBoolVal<DXW.CachedColumnBalance>();
    set => _ExistingElement.SetBoolVal<DXW.CachedColumnBalance>(value);
  }

  /// <summary>
  /// Collection of other compatibility settings.
  /// </summary>
  [DataMember]
  public CompatibilitySettings? CompatibilitySettings
  {
    get => _Element?.GetObject<CompatibilitySettings, DXW.Compatibility>();
    set => _ExistingElement.SetObject<CompatibilitySettings, DXW.Compatibility>(value);
  }

}
