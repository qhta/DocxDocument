namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents compatibility settings for a Wordprocessing document.
/// This class provides properties for emulating legacy behaviors, adjusting layout, formatting, printing, and other document features to ensure compatibility with various versions of word processing applications.
/// </summary>
[XmlRoot("CompatibilitySettings", Namespace = "DocumentModel.Wordprocessing")]
public sealed partial class CompatibilitySettings : ModelElement<DXW.Compatibility>
{
  /// <summary>
  /// Known properties that can be set in CompatibilitySettings.
  /// </summary>
  public static KnownProperties KnownProperties
  {
    get
    {
      if (_KnownProperties == null)
        _KnownProperties = new KnownProperties(typeof(CompatibilitySettings));
      return _KnownProperties;
    }
  }
  private static KnownProperties? _KnownProperties;

  /// <summary>
  /// Default constructor for the Compatibility class.
  /// </summary>
  public CompatibilitySettings()
  {
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref = "DocumentSettings"/> class and attaches it to the specified Wordprocessing document model.
  /// </summary>
  /// <param name = "document">The Wordprocessing document model to attach to.</param>
  public CompatibilitySettings(Wordprocessing.Document document)
  {
    if (document.WordprocessingDocument != null)
      AttachAndLoad(document.WordprocessingDocument);
  }

  /// <summary>
  /// Use simplified rules for table border conflicts.
  /// </summary>
  public bool? UseSingleBorderForContiguousCells { get => _UseSingleBorderForContiguousCells; set => UpdateField(ref _UseSingleBorderForContiguousCells, value, nameof(UseSingleBorderForContiguousCells)); }
  private bool? _UseSingleBorderForContiguousCells;

  /// <summary>
  /// Emulate WordPerfect 6.x paragraph justification.
  /// </summary>
  public bool? WordPerfectJustification { get => _WordPerfectJustification; set => UpdateField(ref _WordPerfectJustification, value, nameof(WordPerfectJustification)); }
  private bool? _WordPerfectJustification;

  /// <summary>
  /// Do not create custom tab stop for hanging indent.
  /// </summary>
  public bool? NoTabHangIndent { get => _NoTabHangIndent; set => UpdateField(ref _NoTabHangIndent, value, nameof(NoTabHangIndent)); }
  private bool? _NoTabHangIndent;

  /// <summary>
  /// Do not add leading between lines of text.
  /// </summary>
  public bool? NoLeading { get => _NoLeading; set => UpdateField(ref _NoLeading, value, nameof(NoLeading)); }
  private bool? _NoLeading;

  /// <summary>
  /// Add additional space below baseline for underlined East Asian text.
  /// </summary>
  public bool? SpaceForUnderline { get => _SpaceForUnderline; set => UpdateField(ref _SpaceForUnderline, value, nameof(SpaceForUnderline)); }
  private bool? _SpaceForUnderline;

  /// <summary>
  /// Do not balance text columns within a section.
  /// </summary>
  public bool? NoColumnBalance { get => _NoColumnBalance; set => UpdateField(ref _NoColumnBalance, value, nameof(NoColumnBalance)); }
  private bool? _NoColumnBalance;

  /// <summary>
  /// Balance single byte and double byte characters.
  /// </summary>
  public bool? BalanceSingleByteDoubleByteWidth { get => _BalanceSingleByteDoubleByteWidth; set => UpdateField(ref _BalanceSingleByteDoubleByteWidth, value, nameof(BalanceSingleByteDoubleByteWidth)); }
  private bool? _BalanceSingleByteDoubleByteWidth;

  /// <summary>
  /// Do not center content on lines with exact line height.
  /// </summary>
  public bool? NoExtraLineSpacing { get => _NoExtraLineSpacing; set => UpdateField(ref _NoExtraLineSpacing, value, nameof(NoExtraLineSpacing)); }
  private bool? _NoExtraLineSpacing;

  /// <summary>
  /// Convert backslash to yen sign when entered.
  /// </summary>
  public bool? DoNotLeaveBackslashAlone { get => _DoNotLeaveBackslashAlone; set => UpdateField(ref _DoNotLeaveBackslashAlone, value, nameof(DoNotLeaveBackslashAlone)); }
  private bool? _DoNotLeaveBackslashAlone;

  /// <summary>
  /// Underline all trailing spaces.
  /// </summary>
  public bool? UnderlineTrailingSpaces { get => _UnderlineTrailingSpaces; set => UpdateField(ref _UnderlineTrailingSpaces, value, nameof(UnderlineTrailingSpaces)); }
  private bool? _UnderlineTrailingSpaces;

  /// <summary>
  /// Do not justify lines ending in soft line break.
  /// </summary>
  public bool? DoNotExpandShiftReturn { get => _DoNotExpandShiftReturn; set => UpdateField(ref _DoNotExpandShiftReturn, value, nameof(DoNotExpandShiftReturn)); }
  private bool? _DoNotExpandShiftReturn;

  /// <summary>
  /// Only expand/condense text by whole points.
  /// </summary>
  public bool? SpacingInWholePoints { get => _SpacingInWholePoints; set => UpdateField(ref _SpacingInWholePoints, value, nameof(SpacingInWholePoints)); }
  private bool? _SpacingInWholePoints;

  /// <summary>
  /// Emulate Word 6.0 line wrapping for East Asian text.
  /// </summary>
  public bool? LineWrapLikeWord6 { get => _LineWrapLikeWord6; set => UpdateField(ref _LineWrapLikeWord6, value, nameof(LineWrapLikeWord6)); }
  private bool? _LineWrapLikeWord6;

  /// <summary>
  /// Print body text before header/footer contents.
  /// </summary>
  public bool? PrintBodyTextBeforeHeader { get => _PrintBodyTextBeforeHeader; set => UpdateField(ref _PrintBodyTextBeforeHeader, value, nameof(PrintBodyTextBeforeHeader)); }
  private bool? _PrintBodyTextBeforeHeader;

  /// <summary>
  /// Print colors as black and white without dithering.
  /// </summary>
  public bool? PrintColorBlackWhite { get => _PrintColorBlackWhite; set => UpdateField(ref _PrintColorBlackWhite, value, nameof(PrintColorBlackWhite)); }
  private bool? _PrintColorBlackWhite;

  /// <summary>
  /// Use WordPerfect space width.
  /// </summary>
  public bool? WordPerfectSpaceWidth { get => _WordPerfectSpaceWidth; set => UpdateField(ref _WordPerfectSpaceWidth, value, nameof(WordPerfectSpaceWidth)); }
  private bool? _WordPerfectSpaceWidth;

  /// <summary>
  /// Display page/column breaks present in frames.
  /// </summary>
  public bool? ShowBreaksInFrames { get => _ShowBreaksInFrames; set => UpdateField(ref _ShowBreaksInFrames, value, nameof(ShowBreaksInFrames)); }
  private bool? _ShowBreaksInFrames;

  /// <summary>
  /// Increase priority of font size during font substitution.
  /// </summary>
  public bool? SubFontBySize { get => _SubFontBySize; set => UpdateField(ref _SubFontBySize, value, nameof(SubFontBySize)); }
  private bool? _SubFontBySize;

  /// <summary>
  /// Ignore exact line height for last line on page.
  /// </summary>
  public bool? SuppressBottomSpacing { get => _SuppressBottomSpacing; set => UpdateField(ref _SuppressBottomSpacing, value, nameof(SuppressBottomSpacing)); }
  private bool? _SuppressBottomSpacing;

  /// <summary>
  /// Ignore minimum and exact line height for first line on page.
  /// </summary>
  public bool? SuppressTopSpacing { get => _SuppressTopSpacing; set => UpdateField(ref _SuppressTopSpacing, value, nameof(SuppressTopSpacing)); }
  private bool? _SuppressTopSpacing;

  /// <summary>
  /// Ignore minimum line height for first line on page.
  /// </summary>
  public bool? SuppressSpacingAtTopOfPage { get => _SuppressSpacingAtTopOfPage; set => UpdateField(ref _SuppressSpacingAtTopOfPage, value, nameof(SuppressSpacingAtTopOfPage)); }
  private bool? _SuppressSpacingAtTopOfPage;

  /// <summary>
  /// Emulate WordPerfect 5.x line spacing.
  /// </summary>
  public bool? SuppressTopSpacingWordPerfect { get => _SuppressTopSpacingWordPerfect; set => UpdateField(ref _SuppressTopSpacingWordPerfect, value, nameof(SuppressTopSpacingWordPerfect)); }
  private bool? _SuppressTopSpacingWordPerfect;

  /// <summary>
  /// Do not use space before on first line after a page break.
  /// </summary>
  public bool? SuppressSpacingBeforeAfterPageBreak { get => _SuppressSpacingBeforeAfterPageBreak; set => UpdateField(ref _SuppressSpacingBeforeAfterPageBreak, value, nameof(SuppressSpacingBeforeAfterPageBreak)); }
  private bool? _SuppressSpacingBeforeAfterPageBreak;

  /// <summary>
  /// Swap paragraph borders on odd numbered pages.
  /// </summary>
  public bool? SwapBordersFacingPages { get => _SwapBordersFacingPages; set => UpdateField(ref _SwapBordersFacingPages, value, nameof(SwapBordersFacingPages)); }
  private bool? _SwapBordersFacingPages;

  /// <summary>
  /// Treat backslash quotation delimiter as two quotation marks.
  /// </summary>
  public bool? ConvertMailMergeEscape { get => _ConvertMailMergeEscape; set => UpdateField(ref _ConvertMailMergeEscape, value, nameof(ConvertMailMergeEscape)); }
  private bool? _ConvertMailMergeEscape;

  /// <summary>
  /// Emulate WordPerfect 6.x font height calculation.
  /// </summary>
  public bool? TruncateFontHeightsLikeWordPerfect { get => _TruncateFontHeightsLikeWordPerfect; set => UpdateField(ref _TruncateFontHeightsLikeWordPerfect, value, nameof(TruncateFontHeightsLikeWordPerfect)); }
  private bool? _TruncateFontHeightsLikeWordPerfect;

  /// <summary>
  /// Emulate Word 5.x for the Macintosh small caps formatting.
  /// </summary>
  public bool? MacWordSmallCaps { get => _MacWordSmallCaps; set => UpdateField(ref _MacWordSmallCaps, value, nameof(MacWordSmallCaps)); }
  private bool? _MacWordSmallCaps;

  /// <summary>
  /// Use printer metrics to display documents.
  /// </summary>
  public bool? UsePrinterMetrics { get => _UsePrinterMetrics; set => UpdateField(ref _UsePrinterMetrics, value, nameof(UsePrinterMetrics)); }
  private bool? _UsePrinterMetrics;

  /// <summary>
  /// Do not suppress paragraph borders next to frames.
  /// </summary>
  public bool? DoNotSuppressParagraphBorders { get => _DoNotSuppressParagraphBorders; set => UpdateField(ref _DoNotSuppressParagraphBorders, value, nameof(DoNotSuppressParagraphBorders)); }
  private bool? _DoNotSuppressParagraphBorders;

  /// <summary>
  /// Line wrap trailing spaces.
  /// </summary>
  public bool? WrapTrailSpaces { get => _WrapTrailSpaces; set => UpdateField(ref _WrapTrailSpaces, value, nameof(WrapTrailSpaces)); }
  private bool? _WrapTrailSpaces;

  /// <summary>
  /// Emulate Word 6.x/95/97 footnote placement.
  /// </summary>
  public bool? FootnoteLayoutLikeWord8 { get => _FootnoteLayoutLikeWord8; set => UpdateField(ref _FootnoteLayoutLikeWord8, value, nameof(FootnoteLayoutLikeWord8)); }
  private bool? _FootnoteLayoutLikeWord8;

  /// <summary>
  /// Emulate Word 97 text wrapping around floating objects.
  /// </summary>
  public bool? ShapeLayoutLikeWord8 { get => _ShapeLayoutLikeWord8; set => UpdateField(ref _ShapeLayoutLikeWord8, value, nameof(ShapeLayoutLikeWord8)); }
  private bool? _ShapeLayoutLikeWord8;

  /// <summary>
  /// Align table rows independently.
  /// </summary>
  public bool? AlignTablesRowByRow { get => _AlignTablesRowByRow; set => UpdateField(ref _AlignTablesRowByRow, value, nameof(AlignTablesRowByRow)); }
  private bool? _AlignTablesRowByRow;

  /// <summary>
  /// Ignore width of last tab stop when aligning paragraph if it is not left aligned.
  /// </summary>
  public bool? ForgetLastTabAlignment { get => _ForgetLastTabAlignment; set => UpdateField(ref _ForgetLastTabAlignment, value, nameof(ForgetLastTabAlignment)); }
  private bool? _ForgetLastTabAlignment;

  /// <summary>
  /// Add document grid line pitch to lines in table cells.
  /// </summary>
  public bool? AdjustLineHeightInTable { get => _AdjustLineHeightInTable; set => UpdateField(ref _AdjustLineHeightInTable, value, nameof(AdjustLineHeightInTable)); }
  private bool? _AdjustLineHeightInTable;

  /// <summary>
  /// Emulate Word 95 full-width character spacing.
  /// </summary>
  public bool? AutoSpaceLikeWord95 { get => _AutoSpaceLikeWord95; set => UpdateField(ref _AutoSpaceLikeWord95, value, nameof(AutoSpaceLikeWord95)); }
  private bool? _AutoSpaceLikeWord95;

  /// <summary>
  /// Do not increase line height for raised/lowered text.
  /// </summary>
  public bool? NoSpaceRaiseLower { get => _NoSpaceRaiseLower; set => UpdateField(ref _NoSpaceRaiseLower, value, nameof(NoSpaceRaiseLower)); }
  private bool? _NoSpaceRaiseLower;

  /// <summary>
  /// Use fixed paragraph spacing for HTML auto setting.
  /// </summary>
  public bool? DoNotUseHTMLParagraphAutoSpacing { get => _DoNotUseHTMLParagraphAutoSpacing; set => UpdateField(ref _DoNotUseHTMLParagraphAutoSpacing, value, nameof(DoNotUseHTMLParagraphAutoSpacing)); }
  private bool? _DoNotUseHTMLParagraphAutoSpacing;

  /// <summary>
  /// Ignore space before table when deciding if table should wrap floating object.
  /// </summary>
  public bool? LayoutRawTableWidth { get => _LayoutRawTableWidth; set => UpdateField(ref _LayoutRawTableWidth, value, nameof(LayoutRawTableWidth)); }
  private bool? _LayoutRawTableWidth;

  /// <summary>
  /// Allow table rows to wrap inline objects independently.
  /// </summary>
  public bool? LayoutTableRowsApart { get => _LayoutTableRowsApart; set => UpdateField(ref _LayoutTableRowsApart, value, nameof(LayoutTableRowsApart)); }
  private bool? _LayoutTableRowsApart;

  /// <summary>
  /// Emulate Word 97 East Asian line breaking.
  /// </summary>
  public bool? UseWord97LineBreakRules { get => _UseWord97LineBreakRules; set => UpdateField(ref _UseWord97LineBreakRules, value, nameof(UseWord97LineBreakRules)); }
  private bool? _UseWord97LineBreakRules;

  /// <summary>
  /// Do not allow floating tables to break across pages.
  /// </summary>
  public bool? DoNotBreakWrappedTables { get => _DoNotBreakWrappedTables; set => UpdateField(ref _DoNotBreakWrappedTables, value, nameof(DoNotBreakWrappedTables)); }
  private bool? _DoNotBreakWrappedTables;

  /// <summary>
  /// Do not snap to document grid in table cells with objects.
  /// </summary>
  public bool? DoNotSnapToGridInCell { get => _DoNotSnapToGridInCell; set => UpdateField(ref _DoNotSnapToGridInCell, value, nameof(DoNotSnapToGridInCell)); }
  private bool? _DoNotSnapToGridInCell;

  /// <summary>
  /// Select field when first or last character is selected.
  /// </summary>
  public bool? SelectFieldWithFirstOrLastChar { get => _SelectFieldWithFirstOrLastChar; set => UpdateField(ref _SelectFieldWithFirstOrLastChar, value, nameof(SelectFieldWithFirstOrLastChar)); }
  private bool? _SelectFieldWithFirstOrLastChar;

  /// <summary>
  /// Use legacy Ethiopic and Amharic line breaking rules.
  /// </summary>
  public bool? ApplyBreakingRules { get => _ApplyBreakingRules; set => UpdateField(ref _ApplyBreakingRules, value, nameof(ApplyBreakingRules)); }
  private bool? _ApplyBreakingRules;

  /// <summary>
  /// Do not allow hanging punctuation with character grid.
  /// </summary>
  public bool? DoNotWrapTextWithPunctuation { get => _DoNotWrapTextWithPunctuation; set => UpdateField(ref _DoNotWrapTextWithPunctuation, value, nameof(DoNotWrapTextWithPunctuation)); }
  private bool? _DoNotWrapTextWithPunctuation;

  /// <summary>
  /// Do not compress compressible characters when using document grid.
  /// </summary>
  public bool? DoNotUseEastAsianBreakRules { get => _DoNotUseEastAsianBreakRules; set => UpdateField(ref _DoNotUseEastAsianBreakRules, value, nameof(DoNotUseEastAsianBreakRules)); }
  private bool? _DoNotUseEastAsianBreakRules;

  /// <summary>
  /// Emulate Word 2002 table style rules.
  /// </summary>
  public bool? UseWord2002TableStyleRules { get => _UseWord2002TableStyleRules; set => UpdateField(ref _UseWord2002TableStyleRules, value, nameof(UseWord2002TableStyleRules)); }
  private bool? _UseWord2002TableStyleRules;

  /// <summary>
  /// Allow tables to autofit into page margins.
  /// </summary>
  public bool? GrowAutofit { get => _GrowAutofit; set => UpdateField(ref _GrowAutofit, value, nameof(GrowAutofit)); }
  private bool? _GrowAutofit;

  /// <summary>
  /// Do not bypass East Asian/complex script layout code.
  /// </summary>
  public bool? UseFarEastLayout { get => _UseFarEastLayout; set => UpdateField(ref _UseFarEastLayout, value, nameof(UseFarEastLayout)); }
  private bool? _UseFarEastLayout;

  /// <summary>
  /// Do not automatically apply list paragraph style to bulleted/numbered text.
  /// </summary>
  public bool? UseNormalStyleForList { get => _UseNormalStyleForList; set => UpdateField(ref _UseNormalStyleForList, value, nameof(UseNormalStyleForList)); }
  private bool? _UseNormalStyleForList;

  /// <summary>
  /// Ignore hanging indent when creating tab stop after numbering.
  /// </summary>
  public bool? DoNotUseIndentAsNumberingTabStop { get => _DoNotUseIndentAsNumberingTabStop; set => UpdateField(ref _DoNotUseIndentAsNumberingTabStop, value, nameof(DoNotUseIndentAsNumberingTabStop)); }
  private bool? _DoNotUseIndentAsNumberingTabStop;

  /// <summary>
  /// Use alternate set of East Asian line breaking rules.
  /// </summary>
  public bool? UseAltKinsokuLineBreakRules { get => _UseAltKinsokuLineBreakRules; set => UpdateField(ref _UseAltKinsokuLineBreakRules, value, nameof(UseAltKinsokuLineBreakRules)); }
  private bool? _UseAltKinsokuLineBreakRules;

  /// <summary>
  /// Allow contextual spacing of paragraphs in tables.
  /// </summary>
  public bool? AllowSpaceOfSameStyleInTable { get => _AllowSpaceOfSameStyleInTable; set => UpdateField(ref _AllowSpaceOfSameStyleInTable, value, nameof(AllowSpaceOfSameStyleInTable)); }
  private bool? _AllowSpaceOfSameStyleInTable;

  /// <summary>
  /// Do not ignore floating objects when calculating paragraph indentation.
  /// </summary>
  public bool? DoNotSuppressIndentation { get => _DoNotSuppressIndentation; set => UpdateField(ref _DoNotSuppressIndentation, value, nameof(DoNotSuppressIndentation)); }
  private bool? _DoNotSuppressIndentation;

  /// <summary>
  /// Do not autofit tables to fit next to wrapped objects.
  /// </summary>
  public bool? DoNotAutofitConstrainedTables { get => _DoNotAutofitConstrainedTables; set => UpdateField(ref _DoNotAutofitConstrainedTables, value, nameof(DoNotAutofitConstrainedTables)); }
  private bool? _DoNotAutofitConstrainedTables;

  /// <summary>
  /// Allow table columns to exceed preferred widths of constituent cells.
  /// </summary>
  public bool? AutofitToFirstFixedWidthCell { get => _AutofitToFirstFixedWidthCell; set => UpdateField(ref _AutofitToFirstFixedWidthCell, value, nameof(AutofitToFirstFixedWidthCell)); }
  private bool? _AutofitToFirstFixedWidthCell;

  /// <summary>
  /// Underline following character following numbering.
  /// </summary>
  public bool? UnderlineTabInNumberingList { get => _UnderlineTabInNumberingList; set => UpdateField(ref _UnderlineTabInNumberingList, value, nameof(UnderlineTabInNumberingList)); }
  private bool? _UnderlineTabInNumberingList;

  /// <summary>
  /// Always use fixed width for Hangul characters.
  /// </summary>
  public bool? DisplayHangulFixedWidth { get => _DisplayHangulFixedWidth; set => UpdateField(ref _DisplayHangulFixedWidth, value, nameof(DisplayHangulFixedWidth)); }
  private bool? _DisplayHangulFixedWidth;

  /// <summary>
  /// Always move paragraph mark to page after a page break.
  /// </summary>
  public bool? SplitPageBreakAndParagraphMark { get => _SplitPageBreakAndParagraphMark; set => UpdateField(ref _SplitPageBreakAndParagraphMark, value, nameof(SplitPageBreakAndParagraphMark)); }
  private bool? _SplitPageBreakAndParagraphMark;

  /// <summary>
  /// Do not vertically align cells containing floating objects.
  /// </summary>
  public bool? DoNotVerticallyAlignCellWithShape { get => _DoNotVerticallyAlignCellWithShape; set => UpdateField(ref _DoNotVerticallyAlignCellWithShape, value, nameof(DoNotVerticallyAlignCellWithShape)); }
  private bool? _DoNotVerticallyAlignCellWithShape;

  /// <summary>
  /// Do not break table rows around floating tables.
  /// </summary>
  public bool? DoNotBreakConstrainedForcedTable { get => _DoNotBreakConstrainedForcedTable; set => UpdateField(ref _DoNotBreakConstrainedForcedTable, value, nameof(DoNotBreakConstrainedForcedTable)); }
  private bool? _DoNotBreakConstrainedForcedTable;

  /// <summary>
  /// Ignore vertical alignment in textboxes.
  /// </summary>
  public bool? DoNotVerticallyAlignInTextBox { get => _DoNotVerticallyAlignInTextBox; set => UpdateField(ref _DoNotVerticallyAlignInTextBox, value, nameof(DoNotVerticallyAlignInTextBox)); }
  private bool? _DoNotVerticallyAlignInTextBox;

  /// <summary>
  /// Use ANSI kerning pairs from fonts.
  /// </summary>
  public bool? UseAnsiKerningPairs { get => _UseAnsiKerningPairs; set => UpdateField(ref _UseAnsiKerningPairs, value, nameof(UseAnsiKerningPairs)); }
  private bool? _UseAnsiKerningPairs;

  /// <summary>
  /// Use cached paragraph information for column balancing.
  /// </summary>
  public bool? CachedColumnBalance { get => _CachedColumnBalance; set => UpdateField(ref _CachedColumnBalance, value, nameof(CachedColumnBalance)); }
  private bool? _CachedColumnBalance;

  /// <summary>
  /// Compatibility settings collection for additional options.
  /// </summary>
  public OtherSettings OtherSettings 
  { get => _OtherSettings ??= new OtherSettings(this, _openXmlElement);}
  private OtherSettings? _OtherSettings;

}