namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies a set of optional compatibility options for the current document.
/// </summary>
[DataContract]
public partial class Compatibility: IOpenXmlElementMappedObject
{
  public Compatibility()
  {
    _Element = new DXW.Compatibility();
  }

  public Compatibility(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXW.Compatibility)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType: DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
    return validTypeElement;
      throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public Compatibility(DXW.Compatibility openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.Compatibility _Element { get; private set; }

  /// <summary>
  /// Use Simplified Rules For Table Border Conflicts.
  /// </summary>
  [DataMember]
  public Boolean? UseSingleBorderForContiguousCells
  {
    get => _Element.GetBooleanVal<DXW.UseSingleBorderForContiguousCells>();
    set => _Element.SetBooleanVal<DXW.UseSingleBorderForContiguousCells>(value);
  }

  /// <summary>
  /// Emulate WordPerfect 6.x Paragraph Justification.
  /// </summary>
  [DataMember]
  public  Boolean? WordPerfectJustification
  {
    get => _Element.GetBooleanVal<DXW.WordPerfectJustification>();
    set => _Element.SetBooleanVal<DXW.WordPerfectJustification>(value);
  }

  /// <summary>
  /// Do Not Create Custom Tab Stop for Hanging Indent.
  /// </summary>
  [DataMember]
  public  Boolean? NoTabHangIndent
  {
    get => _Element.GetBooleanVal<DXW.NoTabHangIndent>();
    set => _Element.SetBooleanVal<DXW.NoTabHangIndent>(value);
  }

  /// <summary>
  /// Do Not Add Leading Between Lines of Text.
  /// </summary>
  [DataMember]
  public  Boolean? NoLeading
  {
    get => _Element.GetBooleanVal<DXW.NoLeading>();
    set => _Element.SetBooleanVal<DXW.NoLeading>(value);
  }

  /// <summary>
  /// Add Additional Space Below Baseline For Underlined East Asian Text.
  /// </summary>
  [DataMember]
  public  Boolean? SpaceForUnderline
  {
    get => _Element.GetBooleanVal<DXW.SpaceForUnderline>();
    set => _Element.SetBooleanVal<DXW.SpaceForUnderline>(value);
  }

  /// <summary>
  /// Do Not Balance Text Columns within a Section.
  /// </summary>
  [DataMember]
  public  Boolean? NoColumnBalance
  {
    get => _Element.GetBooleanVal<DXW.NoColumnBalance>();
    set => _Element.SetBooleanVal<DXW.NoColumnBalance>(value);
  }

  /// <summary>
  /// Balance Single Byte and Double Byte Characters.
  /// </summary>
  [DataMember]
  public  Boolean? BalanceSingleByteDoubleByteWidth
  {
    get => _Element.GetBooleanVal<DXW.BalanceSingleByteDoubleByteWidth>();
    set => _Element.SetBooleanVal<DXW.BalanceSingleByteDoubleByteWidth>(value);
  }

  /// <summary>
  /// Do Not Center Content on Lines With Exact Line Height.
  /// </summary>
  [DataMember]
  public  Boolean? NoExtraLineSpacing
  {
    get => _Element.GetBooleanVal<DXW.NoExtraLineSpacing>();
    set => _Element.SetBooleanVal<DXW.NoExtraLineSpacing>(value);
  }

  /// <summary>
  /// Convert Backslash To Yen Sign When Entered.
  /// </summary>
  [DataMember]
  public  Boolean? DoNotLeaveBackslashAlone
  {
    get => _Element.GetBooleanVal<DXW.DoNotLeaveBackslashAlone>();
    set => _Element.SetBooleanVal<DXW.DoNotLeaveBackslashAlone>(value);
  }

  /// <summary>
  /// Underline All Trailing Spaces.
  /// </summary>
  [DataMember]
  public  Boolean? UnderlineTrailingSpaces
  {
    get => _Element.GetBooleanVal<DXW.UnderlineTrailingSpaces>();
    set => _Element.SetBooleanVal<DXW.UnderlineTrailingSpaces>(value);
  }

  /// <summary>
  /// Don't Justify Lines Ending in Soft Line Break.
  /// </summary>
  [DataMember]
  public  Boolean? DoNotExpandShiftReturn
  {
    get => _Element.GetBooleanVal<DXW.DoNotExpandShiftReturn>();
    set => _Element.SetBooleanVal<DXW.DoNotExpandShiftReturn>(value);
  }

  /// <summary>
  /// Only Expand/Condense Text By Whole Points.
  /// </summary>
  [DataMember]
  public  Boolean? SpacingInWholePoints
  {
    get => _Element.GetBooleanVal<DXW.SpacingInWholePoints>();
    set => _Element.SetBooleanVal<DXW.SpacingInWholePoints>(value);
  }

  /// <summary>
  /// Emulate Word 6.0 Line Wrapping for East Asian Text.
  /// </summary>
  [DataMember]
  public  Boolean? LineWrapLikeWord6
  {
    get => _Element.GetBooleanVal<DXW.LineWrapLikeWord6>();
    set => _Element.SetBooleanVal<DXW.LineWrapLikeWord6>(value);
  }

  /// <summary>
  /// Print Body Text before Header/Footer Contents.
  /// </summary>
  [DataMember]
  public  Boolean? PrintBodyTextBeforeHeader
  {
    get => _Element.GetBooleanVal<DXW.PrintBodyTextBeforeHeader>();
    set => _Element.SetBooleanVal<DXW.PrintBodyTextBeforeHeader>(value);
  }

  /// <summary>
  /// Print Colors as Black And White without Dithering.
  /// </summary>
  [DataMember]
  public  Boolean? PrintColorBlackWhite
  {
    get => _Element.GetBooleanVal<DXW.PrintColorBlackWhite>();
    set => _Element.SetBooleanVal<DXW.PrintColorBlackWhite>(value);
  }

  /// <summary>
  /// Space width.
  /// </summary>
  [DataMember]
  public  Boolean? WordPerfectSpaceWidth
  {
    get => _Element.GetBooleanVal<DXW.WordPerfectSpaceWidth>();
    set => _Element.SetBooleanVal<DXW.WordPerfectSpaceWidth>(value);
  }

  /// <summary>
  /// Display Page/Column Breaks Present in Frames.
  /// </summary>
  [DataMember]
  public  Boolean? ShowBreaksInFrames
  {
    get => _Element.GetBooleanVal<DXW.ShowBreaksInFrames>();
    set => _Element.SetBooleanVal<DXW.ShowBreaksInFrames>(value);
  }

  /// <summary>
  /// Increase Priority Of Font Size During Font Substitution.
  /// </summary>
  [DataMember]
  public  Boolean? SubFontBySize
  {
    get => _Element.GetBooleanVal<DXW.SubFontBySize>();
    set => _Element.SetBooleanVal<DXW.SubFontBySize>(value);
  }

  /// <summary>
  /// Ignore Exact Line Height for Last Line on Page.
  /// </summary>
  [DataMember]
  public  Boolean? SuppressBottomSpacing
  {
    get => _Element.GetBooleanVal<DXW.SuppressBottomSpacing>();
    set => _Element.SetBooleanVal<DXW.SuppressBottomSpacing>(value);
  }

  /// <summary>
  /// Ignore Minimum and Exact Line Height for First Line on Page.
  /// </summary>
  [DataMember]
  public  Boolean? SuppressTopSpacing
  {
    get => _Element.GetBooleanVal<DXW.SuppressTopSpacing>();
    set => _Element.SetBooleanVal<DXW.SuppressTopSpacing>(value);
  }

  /// <summary>
  /// Ignore Minimum Line Height for First Line on Page.
  /// </summary>
  [DataMember]
  public  Boolean? SuppressSpacingAtTopOfPage
  {
    get => _Element.GetBooleanVal<DXW.SuppressSpacingAtTopOfPage>();
    set => _Element.SetBooleanVal<DXW.SuppressSpacingAtTopOfPage>(value);
  }

  /// <summary>
  /// Emulate WordPerfect 5.x Line Spacing.
  /// </summary>
  [DataMember]
  public  Boolean? SuppressTopSpacingWordPerfect
  {
    get => _Element.GetBooleanVal<DXW.SuppressTopSpacingWordPerfect>();
    set => _Element.SetBooleanVal<DXW.SuppressTopSpacingWordPerfect>(value);
  }

  /// <summary>
  /// Do Not Use Space Before On First Line After a Page Break.
  /// </summary>
  [DataMember]
  public  Boolean? SuppressSpacingBeforeAfterPageBreak
  {
    get => _Element.GetBooleanVal<DXW.SuppressSpacingBeforeAfterPageBreak>();
    set => _Element.SetBooleanVal<DXW.SuppressSpacingBeforeAfterPageBreak>(value);
  }

  /// <summary>
  /// Swap Paragraph Borders on Odd Numbered Pages.
  /// </summary>
  [DataMember]
  public  Boolean? SwapBordersFacingPages
  {
    get => _Element.GetBooleanVal<DXW.SwapBordersFacingPages>();
    set => _Element.SetBooleanVal<DXW.SwapBordersFacingPages>(value);
  }

  /// <summary>
  /// Treat Backslash Quotation Delimiter as Two Quotation Marks.
  /// </summary>
  [DataMember]
  public  Boolean? ConvertMailMergeEscape
  {
    get => _Element.GetBooleanVal<DXW.ConvertMailMergeEscape>();
    set => _Element.SetBooleanVal<DXW.ConvertMailMergeEscape>(value);
  }

  /// <summary>
  /// Emulate WordPerfect 6.x Font Height Calculation.
  /// </summary>
  [DataMember]
  public  Boolean? TruncateFontHeightsLikeWordPerfect
  {
    get => _Element.GetBooleanVal<DXW.TruncateFontHeightsLikeWordPerfect>();
    set => _Element.SetBooleanVal<DXW.TruncateFontHeightsLikeWordPerfect>(value);
  }

  /// <summary>
  /// Emulate Word 5.x for the Macintosh Small Caps Formatting.
  /// </summary>
  [DataMember]
  public  Boolean? MacWordSmallCaps
  {
    get => _Element.GetBooleanVal<DXW.MacWordSmallCaps>();
    set => _Element.SetBooleanVal<DXW.MacWordSmallCaps>(value);
  }

  /// <summary>
  /// Use Printer Metrics To Display Documents.
  /// </summary>
  [DataMember]
  public  Boolean? UsePrinterMetrics
  {
    get => _Element.GetBooleanVal<DXW.UsePrinterMetrics>();
    set => _Element.SetBooleanVal<DXW.UsePrinterMetrics>(value);
  }

  /// <summary>
  /// Do Not Suppress Paragraph Borders Next To Frames.
  /// </summary>
  [DataMember]
  public  Boolean? DoNotSuppressParagraphBorders
  {
    get => _Element.GetBooleanVal<DXW.DoNotSuppressParagraphBorders>();
    set => _Element.SetBooleanVal<DXW.DoNotSuppressParagraphBorders>(value);
  }

  /// <summary>
  /// Line Wrap Trailing Spaces.
  /// </summary>
  [DataMember]
  public  Boolean? WrapTrailSpaces
  {
    get => _Element.GetBooleanVal<DXW.WrapTrailSpaces>();
    set => _Element.SetBooleanVal<DXW.WrapTrailSpaces>(value);
  }

  /// <summary>
  /// Emulate Word 6.x/95/97 Footnote Placement.
  /// </summary>
  [DataMember]
  public  Boolean? FootnoteLayoutLikeWord8
  {
    get => _Element.GetBooleanVal<DXW.FootnoteLayoutLikeWord8>();
    set => _Element.SetBooleanVal<DXW.FootnoteLayoutLikeWord8>(value);
  }

  /// <summary>
  /// Emulate Word 97 Text Wrapping Around Floating Objects.
  /// </summary>
  [DataMember]
  public  Boolean? ShapeLayoutLikeWord8
  {
    get => _Element.GetBooleanVal<DXW.ShapeLayoutLikeWord8>();
    set => _Element.SetBooleanVal<DXW.ShapeLayoutLikeWord8>(value);
  }

  /// <summary>
  /// Align Table Rows Independently.
  /// </summary>
  [DataMember]
  public  Boolean? AlignTablesRowByRow
  {
    get => _Element.GetBooleanVal<DXW.AlignTablesRowByRow>();
    set => _Element.SetBooleanVal<DXW.AlignTablesRowByRow>(value);
  }

  /// <summary>
  /// Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
  /// </summary>
  [DataMember]
  public  Boolean? ForgetLastTabAlignment
  {
    get => _Element.GetBooleanVal<DXW.ForgetLastTabAlignment>();
    set => _Element.SetBooleanVal<DXW.ForgetLastTabAlignment>(value);
  }

  /// <summary>
  /// Add Document Grid Line Pitch To Lines in Table Cells.
  /// </summary>
  [DataMember]
  public  Boolean? AdjustLineHeightInTable
  {
    get => _Element.GetBooleanVal<DXW.AdjustLineHeightInTable>();
    set => _Element.SetBooleanVal<DXW.AdjustLineHeightInTable>(value);
  }

  /// <summary>
  /// Emulate Word 95 Full-Width Character Spacing.
  /// </summary>
  [DataMember]
  public  Boolean? AutoSpaceLikeWord95
  {
    get => _Element.GetBooleanVal<DXW.AutoSpaceLikeWord95>();
    set => _Element.SetBooleanVal<DXW.AutoSpaceLikeWord95>(value);
  }

  /// <summary>
  /// Do Not Increase Line Height for Raised/Lowered Text.
  /// </summary>
  [DataMember]
  public  Boolean? NoSpaceRaiseLower
  {
    get => _Element.GetBooleanVal<DXW.NoSpaceRaiseLower>();
    set => _Element.SetBooleanVal<DXW.NoSpaceRaiseLower>(value);
  }

  /// <summary>
  /// Use Fixed Paragraph Spacing for HTML Auto Setting.
  /// </summary>
  [DataMember]
  public  Boolean? DoNotUseHTMLParagraphAutoSpacing
  {
    get => _Element.GetBooleanVal<DXW.DoNotUseHTMLParagraphAutoSpacing>();
    set => _Element.SetBooleanVal<DXW.DoNotUseHTMLParagraphAutoSpacing>(value);
  }

  /// <summary>
  /// Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
  /// </summary>
  [DataMember]
  public  Boolean? LayoutRawTableWidth
  {
    get => _Element.GetBooleanVal<DXW.LayoutRawTableWidth>();
    set => _Element.SetBooleanVal<DXW.LayoutRawTableWidth>(value);
  }

  /// <summary>
  /// Allow Table Rows to Wrap Inline Objects Independently.
  /// </summary>
  [DataMember]
  public  Boolean? LayoutTableRowsApart
  {
    get => _Element.GetBooleanVal<DXW.LayoutTableRowsApart>();
    set => _Element.SetBooleanVal<DXW.LayoutTableRowsApart>(value);
  }

  /// <summary>
  /// Emulate Word 97 East Asian Line Breaking.
  /// </summary>
  [DataMember]
  public  Boolean? UseWord97LineBreakRules
  {
    get => _Element.GetBooleanVal<DXW.UseWord97LineBreakRules>();
    set => _Element.SetBooleanVal<DXW.UseWord97LineBreakRules>(value);
  }

  /// <summary>
  /// Do Not Allow Floating Tables To Break Across Pages.
  /// </summary>
  [DataMember]
  public  Boolean? DoNotBreakWrappedTables
  {
    get => _Element.GetBooleanVal<DXW.DoNotBreakWrappedTables>();
    set => _Element.SetBooleanVal<DXW.DoNotBreakWrappedTables>(value);
  }

  /// <summary>
  /// Do Not Snap to Document Grid in Table Cells with Objects.
  /// </summary>
  [DataMember]
  public  Boolean? DoNotSnapToGridInCell
  {
    get => _Element.GetBooleanVal<DXW.DoNotSnapToGridInCell>();
    set => _Element.SetBooleanVal<DXW.DoNotSnapToGridInCell>(value);
  }

  /// <summary>
  /// Select Field When First or Last Character Is Selected.
  /// </summary>
  [DataMember]
  public  Boolean? SelectFieldWithFirstOrLastChar
  {
    get => _Element.GetBooleanVal<DXW.SelectFieldWithFirstOrLastChar>();
    set => _Element.SetBooleanVal<DXW.SelectFieldWithFirstOrLastChar>(value);
  }

  /// <summary>
  /// Use Legacy Ethiopic and Amharic Line Breaking Rules.
  /// </summary>
  [DataMember]
  public  Boolean? ApplyBreakingRules
  {
    get => _Element.GetBooleanVal<DXW.ApplyBreakingRules>();
    set => _Element.SetBooleanVal<DXW.ApplyBreakingRules>(value);
  }

  /// <summary>
  /// Do Not Allow Hanging Punctuation With Character Grid.
  /// </summary>
  [DataMember]
  public  Boolean? DoNotWrapTextWithPunctuation
  {
    get => _Element.GetBooleanVal<DXW.DoNotWrapTextWithPunctuation>();
    set => _Element.SetBooleanVal<DXW.DoNotWrapTextWithPunctuation>(value);
  }

  /// <summary>
  /// Do Not Compress Compressible Characters When Using Document Grid.
  /// </summary>
  [DataMember]
  public  Boolean? DoNotUseEastAsianBreakRules
  {
    get => _Element.GetBooleanVal<DXW.DoNotUseEastAsianBreakRules>();
    set => _Element.SetBooleanVal<DXW.DoNotUseEastAsianBreakRules>(value);
  }

  /// <summary>
  /// Emulate Word 2002 Table Style Rules.
  /// </summary>
  [DataMember]
  public  Boolean? UseWord2002TableStyleRules
  {
    get => _Element.GetBooleanVal<DXW.UseWord2002TableStyleRules>();
    set => _Element.SetBooleanVal<DXW.UseWord2002TableStyleRules>(value);
  }

  /// <summary>
  /// Allow Tables to AutoFit Into Page Margins.
  /// </summary>
  [DataMember]
  public  Boolean? GrowAutofit
  {
    get => _Element.GetBooleanVal<DXW.GrowAutofit>();
    set => _Element.SetBooleanVal<DXW.GrowAutofit>(value);
  }

  /// <summary>
  /// Do Not Bypass East Asian/Complex Script Layout Code.
  /// </summary>
  [DataMember]
  public  Boolean? UseFarEastLayout
  {
    get => _Element.GetBooleanVal<DXW.UseFarEastLayout>();
    set => _Element.SetBooleanVal<DXW.UseFarEastLayout>(value);
  }

  /// <summary>
  /// Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
  /// </summary>
  [DataMember]
  public  Boolean? UseNormalStyleForList
  {
    get => _Element.GetBooleanVal<DXW.UseNormalStyleForList>();
    set => _Element.SetBooleanVal<DXW.UseNormalStyleForList>(value);
  }

  /// <summary>
  /// Ignore Hanging Indent When Creating Tab Stop After Numbering.
  /// </summary>
  [DataMember]
  public  Boolean? DoNotUseIndentAsNumberingTabStop
  {
    get => _Element.GetBooleanVal<DXW.DoNotUseIndentAsNumberingTabStop>();
    set => _Element.SetBooleanVal<DXW.DoNotUseIndentAsNumberingTabStop>(value);
  }

  /// <summary>
  /// Use Alternate Set of East Asian Line Breaking Rules.
  /// </summary>
  [DataMember]
  public  Boolean? UseAltKinsokuLineBreakRules
  {
    get => _Element.GetBooleanVal<DXW.UseAltKinsokuLineBreakRules>();
    set => _Element.SetBooleanVal<DXW.UseAltKinsokuLineBreakRules>(value);
  }

  /// <summary>
  /// Allow Contextual Spacing of Paragraphs in Tables.
  /// </summary>
  [DataMember]
  public  Boolean? AllowSpaceOfSameStyleInTable
  {
    get => _Element.GetBooleanVal<DXW.AllowSpaceOfSameStyleInTable>();
    set => _Element.SetBooleanVal<DXW.AllowSpaceOfSameStyleInTable>(value);
  }

  /// <summary>
  /// Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
  /// </summary>
  [DataMember]
  public  Boolean? DoNotSuppressIndentation
  {
    get => _Element.GetBooleanVal<DXW.DoNotSuppressIndentation>();
    set => _Element.SetBooleanVal<DXW.DoNotSuppressIndentation>(value);
  }

  /// <summary>
  /// Do Not AutoFit Tables To Fit Next To Wrapped Objects.
  /// </summary>
  [DataMember]
  public  Boolean? DoNotAutofitConstrainedTables
  {
    get => _Element.GetBooleanVal<DXW.DoNotAutofitConstrainedTables>();
    set => _Element.SetBooleanVal<DXW.DoNotAutofitConstrainedTables>(value);
  }

  /// <summary>
  /// Allow Table Columns To Exceed Preferred Widths of Constituent Cells.
  /// </summary>
  [DataMember]
  public  Boolean? AutofitToFirstFixedWidthCell
  {
    get => _Element.GetBooleanVal<DXW.AutofitToFirstFixedWidthCell>();
    set => _Element.SetBooleanVal<DXW.AutofitToFirstFixedWidthCell>(value);
  }

  /// <summary>
  /// Underline Following Character Following Numbering.
  /// </summary>
  [DataMember]
  public  Boolean? UnderlineTabInNumberingList
  {
    get => _Element.GetBooleanVal<DXW.UnderlineTabInNumberingList>();
    set => _Element.SetBooleanVal<DXW.UnderlineTabInNumberingList>(value);
  }

  /// <summary>
  /// Always Use Fixed Width for Hangul Characters.
  /// </summary>
  [DataMember]
  public  Boolean? DisplayHangulFixedWidth
  {
    get => _Element.GetBooleanVal<DXW.DisplayHangulFixedWidth>();
    set => _Element.SetBooleanVal<DXW.DisplayHangulFixedWidth>(value);
  }

  /// <summary>
  /// Always Move Paragraph Mark to Page after a Page Break.
  /// </summary>
  [DataMember]
  public  Boolean? SplitPageBreakAndParagraphMark
  {
    get => _Element.GetBooleanVal<DXW.SplitPageBreakAndParagraphMark>();
    set => _Element.SetBooleanVal<DXW.SplitPageBreakAndParagraphMark>(value);
  }

  /// <summary>
  /// Don't Vertically Align Cells Containing Floating Objects.
  /// </summary>
  [DataMember]
  public  Boolean? DoNotVerticallyAlignCellWithShape
  {
    get => _Element.GetBooleanVal<DXW.DoNotVerticallyAlignCellWithShape>();
    set => _Element.SetBooleanVal<DXW.DoNotVerticallyAlignCellWithShape>(value);
  }

  /// <summary>
  /// Don't Break Table Rows Around Floating Tables.
  /// </summary>
  [DataMember]
  public  Boolean? DoNotBreakConstrainedForcedTable
  {
    get => _Element.GetBooleanVal<DXW.DoNotBreakConstrainedForcedTable>();
    set => _Element.SetBooleanVal<DXW.DoNotBreakConstrainedForcedTable>(value);
  }

  /// <summary>
  /// Ignore Vertical Alignment in Textboxes.
  /// </summary>
  [DataMember]
  public  Boolean? DoNotVerticallyAlignInTextBox
  {
    get => _Element.GetBooleanVal<DXW.DoNotVerticallyAlignInTextBox>();
    set => _Element.SetBooleanVal<DXW.DoNotVerticallyAlignInTextBox>(value);
  }

  /// <summary>
  /// Use ANSI Kerning Pairs from Fonts.
  /// </summary>
  [DataMember]
  public  Boolean? UseAnsiKerningPairs
  {
    get => _Element.GetBooleanVal<DXW.UseAnsiKerningPairs>();
    set => _Element.SetBooleanVal<DXW.UseAnsiKerningPairs>(value);
  }

  /// <summary>
  /// Use Cached Paragraph Information for Column Balancing.
  /// </summary>
  [DataMember]
  public  Boolean? CachedColumnBalance
  {
    get => _Element.GetBooleanVal<DXW.CachedColumnBalance>();
    set => _Element.SetBooleanVal<DXW.CachedColumnBalance>(value);
  }

  /// <summary>
  /// Collection of other compatibility settings.
  /// </summary>
  [DataMember]
  public CompatibilitySettings CompatibilitySettings
  {
    get => new CompatibilitySettings(_Element);
  }
}
