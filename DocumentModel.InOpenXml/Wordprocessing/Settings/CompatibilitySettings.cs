namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents compatibility settings for a Wordprocessing document.
/// This class provides properties for emulating legacy behaviors, adjusting layout, formatting, printing, and other document features to ensure compatibility with various versions of word processing applications.
/// </summary>
[DataContract]
[XmlRoot("CompatibilitySettings", Namespace = "DocumentModel.Wordprocessing")]
[OpenXmlType(typeof(DXW.Compatibility))]
[DirectAccess]
public sealed partial class CompatibilitySettings : ModelElement<DXW.Compatibility>
{
  /// <summary>
  /// Known properties that can be set in CompatibilitySettings.
  /// </summary>
  public static KnownProperties KnownProperties => _KnownProperties ??= new KnownProperties(typeof(CompatibilitySettings));
  private static KnownProperties? _KnownProperties;

  /// <summary>
  /// Default constructor for the Compatibility class.
  /// </summary>
  public CompatibilitySettings()
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="CompatibilitySettings"/> class with the specified settings and compatibility.
  /// </summary>
  /// <param name="settings">The document settings.</param>
  /// <param name="compatibility">The compatibility settings.</param>
  public CompatibilitySettings(DocumentSettings settings, DXW.Compatibility compatibility) : base(settings, compatibility)
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
  [OpenXmlElement(typeof(DXW.UseSingleBorderForContiguousCells))]
  public bool? UseSingleBorderForContiguousCells
  {
    get => _UseSingleBorderForContiguousCells ??= GetElement<bool?, DXW.UseSingleBorderForContiguousCells>(GetUpdatableElement());
    set => UpdateField(ref _UseSingleBorderForContiguousCells, value, nameof(UseSingleBorderForContiguousCells));
  }
  private bool? _UseSingleBorderForContiguousCells;

  /// <summary>
  /// Emulate WordPerfect 6.x paragraph justification.
  /// </summary>
  [OpenXmlElement(typeof(DXW.WordPerfectJustification))]
  public bool? WordPerfectJustification
  {
    get => _WordPerfectJustification ??= GetElement<bool?, DXW.WordPerfectJustification>(GetUpdatableElement());
    set => UpdateField(ref _WordPerfectJustification, value, nameof(WordPerfectJustification));
  }
  private bool? _WordPerfectJustification;

  /// <summary>
  /// Do not create custom tab stop for hanging indent.
  /// </summary>
  [OpenXmlElement(typeof(DXW.NoTabHangIndent))]
  public bool? NoTabHangIndent
  {
    get => _NoTabHangIndent ??= GetElement<bool?, DXW.NoTabHangIndent>(GetUpdatableElement());
    set => UpdateField(ref _NoTabHangIndent, value, nameof(NoTabHangIndent));
  }
  private bool? _NoTabHangIndent;

  /// <summary>
  /// Do not add leading between lines of text.
  /// </summary>
  [OpenXmlElement(typeof(DXW.NoLeading))]
  public bool? NoLeading
  {
    get => _NoLeading ??= GetElement<bool?, DXW.NoLeading>(GetUpdatableElement());
    set => UpdateField(ref _NoLeading, value, nameof(NoLeading));
  }
  private bool? _NoLeading;

  /// <summary>
  /// Add additional space below baseline for underlined East Asian text.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SpaceForUnderline))]
  public bool? SpaceForUnderline
  {
    get => _SpaceForUnderline ??= GetElement<bool?, DXW.SpaceForUnderline>(GetUpdatableElement());
    set => UpdateField(ref _SpaceForUnderline, value, nameof(SpaceForUnderline));
  }
  private bool? _SpaceForUnderline;

  /// <summary>
  /// Do not balance text columns within a section.
  /// </summary>
  [OpenXmlElement(typeof(DXW.NoColumnBalance))]
  public bool? NoColumnBalance
  {
    get => _NoColumnBalance ??= GetElement<bool?, DXW.NoColumnBalance>(GetUpdatableElement());
    set => UpdateField(ref _NoColumnBalance, value, nameof(NoColumnBalance));
  }
  private bool? _NoColumnBalance;

  /// <summary>
  /// Balance single byte and double byte characters.
  /// </summary>
  [OpenXmlElement(typeof(DXW.BalanceSingleByteDoubleByteWidth))]
  public bool? BalanceSingleByteDoubleByteWidth
  {
    get => _BalanceSingleByteDoubleByteWidth ??= GetElement<bool?, DXW.BalanceSingleByteDoubleByteWidth>(GetUpdatableElement());
    set => UpdateField(ref _BalanceSingleByteDoubleByteWidth, value, nameof(BalanceSingleByteDoubleByteWidth));
  }
  private bool? _BalanceSingleByteDoubleByteWidth;

  /// <summary>
  /// Do not center content on lines with exact line height.
  /// </summary>
  [OpenXmlElement(typeof(DXW.NoExtraLineSpacing))]
  public bool? NoExtraLineSpacing
  {
    get => _NoExtraLineSpacing ??= GetElement<bool?, DXW.NoExtraLineSpacing>(GetUpdatableElement());
    set => UpdateField(ref _NoExtraLineSpacing, value, nameof(NoExtraLineSpacing));
  }
  private bool? _NoExtraLineSpacing;

  /// <summary>
  /// Convert backslash to yen sign when entered.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DoNotLeaveBackslashAlone))]
  public bool? DoNotLeaveBackslashAlone
  {
    get => _DoNotLeaveBackslashAlone ??= GetElement<bool?, DXW.DoNotLeaveBackslashAlone>(GetUpdatableElement());
    set => UpdateField(ref _DoNotLeaveBackslashAlone, value, nameof(DoNotLeaveBackslashAlone));
  }
  private bool? _DoNotLeaveBackslashAlone;

  /// <summary>
  /// Underline all trailing spaces.
  /// </summary>
  [OpenXmlElement(typeof(DXW.UnderlineTrailingSpaces))]
  public bool? UnderlineTrailingSpaces
  {
    get => _UnderlineTrailingSpaces ??= GetElement<bool?, DXW.UnderlineTrailingSpaces>(GetUpdatableElement());
    set => UpdateField(ref _UnderlineTrailingSpaces, value, nameof(UnderlineTrailingSpaces));
  }
  private bool? _UnderlineTrailingSpaces;

  /// <summary>
  /// Do not justify lines ending in soft line break.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DoNotExpandShiftReturn))]
  public bool? DoNotExpandShiftReturn
  {
    get => _DoNotExpandShiftReturn ??= GetElement<bool?, DXW.DoNotExpandShiftReturn>(GetUpdatableElement());
    set => UpdateField(ref _DoNotExpandShiftReturn, value, nameof(DoNotExpandShiftReturn));
  }
  private bool? _DoNotExpandShiftReturn;

  /// <summary>
  /// Only expand/condense text by whole points.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SpacingInWholePoints))]
  public bool? SpacingInWholePoints
  {
    get => _SpacingInWholePoints ??= GetElement<bool?, DXW.SpacingInWholePoints>(GetUpdatableElement());
    set => UpdateField(ref _SpacingInWholePoints, value, nameof(SpacingInWholePoints));
  }
  private bool? _SpacingInWholePoints;

  /// <summary>
  /// Emulate Word 6.0 line wrapping for East Asian text.
  /// </summary>
  [OpenXmlElement(typeof(DXW.LineWrapLikeWord6))]
  public bool? LineWrapLikeWord6
  {
    get => _LineWrapLikeWord6 ??= GetElement<bool?, DXW.LineWrapLikeWord6>(GetUpdatableElement());
    set => UpdateField(ref _LineWrapLikeWord6, value, nameof(LineWrapLikeWord6));
  }
  private bool? _LineWrapLikeWord6;

  /// <summary>
  /// Print body text before header/footer contents.
  /// </summary>
  [OpenXmlElement(typeof(DXW.PrintBodyTextBeforeHeader))]
  public bool? PrintBodyTextBeforeHeader
  {
    get => _PrintBodyTextBeforeHeader ??= GetElement<bool?, DXW.PrintBodyTextBeforeHeader>(GetUpdatableElement());
    set => UpdateField(ref _PrintBodyTextBeforeHeader, value, nameof(PrintBodyTextBeforeHeader));
  }
  private bool? _PrintBodyTextBeforeHeader;

  /// <summary>
  /// Print colors as black and white without dithering.
  /// </summary>
  [OpenXmlElement(typeof(DXW.PrintColorBlackWhite))]
  public bool? PrintColorBlackWhite
  {
    get => _PrintColorBlackWhite ??= GetElement<bool?, DXW.PrintColorBlackWhite>(GetUpdatableElement());
    set => UpdateField(ref _PrintColorBlackWhite, value, nameof(PrintColorBlackWhite));
  }
  private bool? _PrintColorBlackWhite;

  /// <summary>
  /// Use WordPerfect space width.
  /// </summary>
  [OpenXmlElement(typeof(DXW.WordPerfectSpaceWidth))]
  public bool? WordPerfectSpaceWidth
  {
    get => _WordPerfectSpaceWidth ??= GetElement<bool?, DXW.WordPerfectSpaceWidth>(GetUpdatableElement());
    set => UpdateField(ref _WordPerfectSpaceWidth, value, nameof(WordPerfectSpaceWidth));
  }
  private bool? _WordPerfectSpaceWidth;

  /// <summary>
  /// Display page/column breaks present in frames.
  /// </summary>
  [OpenXmlElement(typeof(DXW.ShowBreaksInFrames))]
  public bool? ShowBreaksInFrames
  {
    get => _ShowBreaksInFrames ??= GetElement<bool?, DXW.ShowBreaksInFrames>(GetUpdatableElement());
    set => UpdateField(ref _ShowBreaksInFrames, value, nameof(ShowBreaksInFrames));
  }
  private bool? _ShowBreaksInFrames;

  /// <summary>
  /// Increase priority of font size during font substitution.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SubFontBySize))]
  public bool? SubFontBySize
  {
    get => _SubFontBySize ??= GetElement<bool?, DXW.SubFontBySize>(GetUpdatableElement());
    set => UpdateField(ref _SubFontBySize, value, nameof(SubFontBySize));
  }
  private bool? _SubFontBySize;

  /// <summary>
  /// Ignore exact line height for last line on page.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SuppressBottomSpacing))]
  public bool? SuppressBottomSpacing
  {
    get => _SuppressBottomSpacing ??= GetElement<bool?, DXW.SuppressBottomSpacing>(GetUpdatableElement());
    set => UpdateField(ref _SuppressBottomSpacing, value, nameof(SuppressBottomSpacing));
  }
  private bool? _SuppressBottomSpacing;

  /// <summary>
  /// Ignore minimum and exact line height for first line on page.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SuppressTopSpacing))]
  public bool? SuppressTopSpacing
  {
    get => _SuppressTopSpacing ??= GetElement<bool?, DXW.SuppressTopSpacing>(GetUpdatableElement());
    set => UpdateField(ref _SuppressTopSpacing, value, nameof(SuppressTopSpacing));
  }
  private bool? _SuppressTopSpacing;

  /// <summary>
  /// Ignore minimum line height for first line on page.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SuppressSpacingAtTopOfPage))]
  public bool? SuppressSpacingAtTopOfPage
  {
    get => _SuppressSpacingAtTopOfPage ??= GetElement<bool?, DXW.SuppressSpacingAtTopOfPage>(GetUpdatableElement());
    set => UpdateField(ref _SuppressSpacingAtTopOfPage, value, nameof(SuppressSpacingAtTopOfPage));
  }
  private bool? _SuppressSpacingAtTopOfPage;

  /// <summary>
  /// Emulate WordPerfect 5.x line spacing.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SuppressTopSpacingWordPerfect))]
  public bool? SuppressTopSpacingWordPerfect
  {
    get => _SuppressTopSpacingWordPerfect ??= GetElement<bool?, DXW.SuppressTopSpacingWordPerfect>(GetUpdatableElement());
    set => UpdateField(ref _SuppressTopSpacingWordPerfect, value, nameof(SuppressTopSpacingWordPerfect));
  }
  private bool? _SuppressTopSpacingWordPerfect;

  /// <summary>
  /// Do not use space before on first line after a page break.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SuppressSpacingBeforeAfterPageBreak))]
  public bool? SuppressSpacingBeforeAfterPageBreak
  {
    get => _SuppressSpacingBeforeAfterPageBreak ??= GetElement<bool?, DXW.SuppressSpacingBeforeAfterPageBreak>(GetUpdatableElement());
    set => UpdateField(ref _SuppressSpacingBeforeAfterPageBreak, value, nameof(SuppressSpacingBeforeAfterPageBreak));
  }
  private bool? _SuppressSpacingBeforeAfterPageBreak;

  /// <summary>
  /// Swap paragraph borders on odd numbered pages.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SwapBordersFacingPages))]
  public bool? SwapBordersFacingPages
  {
    get => _SwapBordersFacingPages ??= GetElement<bool?, DXW.SwapBordersFacingPages>(GetUpdatableElement());
    set => UpdateField(ref _SwapBordersFacingPages, value, nameof(SwapBordersFacingPages));
  }
  private bool? _SwapBordersFacingPages;

  /// <summary>
  /// Treat backslash quotation delimiter as two quotation marks.
  /// </summary>
  [OpenXmlElement(typeof(DXW.ConvertMailMergeEscape))]
  public bool? ConvertMailMergeEscape
  {
    get => _ConvertMailMergeEscape ??= GetElement<bool?, DXW.ConvertMailMergeEscape>(GetUpdatableElement());
    set => UpdateField(ref _ConvertMailMergeEscape, value, nameof(ConvertMailMergeEscape));
  }
  private bool? _ConvertMailMergeEscape;

  /// <summary>
  /// Emulate WordPerfect 6.x font height calculation.
  /// </summary>
  [OpenXmlElement(typeof(DXW.TruncateFontHeightsLikeWordPerfect))]
  public bool? TruncateFontHeightsLikeWordPerfect
  {
    get => _TruncateFontHeightsLikeWordPerfect ??= GetElement<bool?, DXW.TruncateFontHeightsLikeWordPerfect>(GetUpdatableElement());
    set => UpdateField(ref _TruncateFontHeightsLikeWordPerfect, value, nameof(TruncateFontHeightsLikeWordPerfect));
  }
  private bool? _TruncateFontHeightsLikeWordPerfect;

  /// <summary>
  /// Emulate Word 5.x for the Macintosh small caps formatting.
  /// </summary>
  [OpenXmlElement(typeof(DXW.MacWordSmallCaps))]
  public bool? MacWordSmallCaps
  {
    get => _MacWordSmallCaps ??= GetElement<bool?, DXW.MacWordSmallCaps>(GetUpdatableElement());
    set => UpdateField(ref _MacWordSmallCaps, value, nameof(MacWordSmallCaps));
  }
  private bool? _MacWordSmallCaps;

  /// <summary>
  /// Use printer metrics to display documents.
  /// </summary>
  [OpenXmlElement(typeof(DXW.UsePrinterMetrics))]
  public bool? UsePrinterMetrics
  {
    get => _UsePrinterMetrics ??= GetElement<bool?, DXW.UsePrinterMetrics>(GetUpdatableElement());
    set => UpdateField(ref _UsePrinterMetrics, value, nameof(UsePrinterMetrics));
  }
  private bool? _UsePrinterMetrics;

  /// <summary>
  /// Do not suppress paragraph borders next to frames.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DoNotSuppressParagraphBorders))]
  public bool? DoNotSuppressParagraphBorders
  {
    get => _DoNotSuppressParagraphBorders ??= GetElement<bool?, DXW.DoNotSuppressParagraphBorders>(GetUpdatableElement());
    set => UpdateField(ref _DoNotSuppressParagraphBorders, value, nameof(DoNotSuppressParagraphBorders));
  }
  private bool? _DoNotSuppressParagraphBorders;

  /// <summary>
  /// Line wrap trailing spaces.
  /// </summary>
  [OpenXmlElement(typeof(DXW.WrapTrailSpaces))]
  public bool? WrapTrailSpaces
  {
    get => _WrapTrailSpaces ??= GetElement<bool?, DXW.WrapTrailSpaces>(GetUpdatableElement());
    set => UpdateField(ref _WrapTrailSpaces, value, nameof(WrapTrailSpaces));
  }
  private bool? _WrapTrailSpaces;

  /// <summary>
  /// Emulate Word 6.x/95/97 footnote placement.
  /// </summary>
  [OpenXmlElement(typeof(DXW.FootnoteLayoutLikeWord8))]
  public bool? FootnoteLayoutLikeWord8
  {
    get => _FootnoteLayoutLikeWord8 ??= GetElement<bool?, DXW.FootnoteLayoutLikeWord8>(GetUpdatableElement());
    set => UpdateField(ref _FootnoteLayoutLikeWord8, value, nameof(FootnoteLayoutLikeWord8));
  }
  private bool? _FootnoteLayoutLikeWord8;

  /// <summary>
  /// Emulate Word 97 text wrapping around floating objects.
  /// </summary>
  [OpenXmlElement(typeof(DXW.ShapeLayoutLikeWord8))]
  public bool? ShapeLayoutLikeWord8
  {
    get => _ShapeLayoutLikeWord8 ??= GetElement<bool?, DXW.ShapeLayoutLikeWord8>(GetUpdatableElement());
    set => UpdateField(ref _ShapeLayoutLikeWord8, value, nameof(ShapeLayoutLikeWord8));
  }
  private bool? _ShapeLayoutLikeWord8;

  /// <summary>
  /// Align table rows independently.
  /// </summary>
  [OpenXmlElement(typeof(DXW.AlignTablesRowByRow))]
  public bool? AlignTablesRowByRow
  {
    get => _AlignTablesRowByRow ??= GetElement<bool?, DXW.AlignTablesRowByRow>(GetUpdatableElement());
    set => UpdateField(ref _AlignTablesRowByRow, value, nameof(AlignTablesRowByRow));
  }
  private bool? _AlignTablesRowByRow;

  /// <summary>
  /// Ignore width of last tab stop when aligning paragraph if it is not left aligned.
  /// </summary>
  [OpenXmlElement(typeof(DXW.ForgetLastTabAlignment))]
  public bool? ForgetLastTabAlignment
  {
    get => _ForgetLastTabAlignment ??= GetElement<bool?, DXW.ForgetLastTabAlignment>(GetUpdatableElement());
    set => UpdateField(ref _ForgetLastTabAlignment, value, nameof(ForgetLastTabAlignment));
  }
  private bool? _ForgetLastTabAlignment;

  /// <summary>
  /// Add document grid line pitch to lines in table cells.
  /// </summary>
  [OpenXmlElement(typeof(DXW.AdjustLineHeightInTable))]
  public bool? AdjustLineHeightInTable
  {
    get => _AdjustLineHeightInTable ??= GetElement<bool?, DXW.AdjustLineHeightInTable>(GetUpdatableElement());
    set => UpdateField(ref _AdjustLineHeightInTable, value, nameof(AdjustLineHeightInTable));
  }
  private bool? _AdjustLineHeightInTable;

  /// <summary>
  /// Emulate Word 95 full-width character spacing.
  /// </summary>
  [OpenXmlElement(typeof(DXW.AutoSpaceLikeWord95))]
  public bool? AutoSpaceLikeWord95
  {
    get => _AutoSpaceLikeWord95 ??= GetElement<bool?, DXW.AutoSpaceLikeWord95>(GetUpdatableElement());
    set => UpdateField(ref _AutoSpaceLikeWord95, value, nameof(AutoSpaceLikeWord95));
  }
  private bool? _AutoSpaceLikeWord95;

  /// <summary>
  /// Do not increase line height for raised/lowered text.
  /// </summary>
  [OpenXmlElement(typeof(DXW.NoSpaceRaiseLower))]
  public bool? NoSpaceRaiseLower
  {
    get => _NoSpaceRaiseLower ??= GetElement<bool?, DXW.NoSpaceRaiseLower>(GetUpdatableElement());
    set => UpdateField(ref _NoSpaceRaiseLower, value, nameof(NoSpaceRaiseLower));
  }
  private bool? _NoSpaceRaiseLower;

  /// <summary>
  /// Use fixed paragraph spacing for HTML auto setting.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DoNotUseHTMLParagraphAutoSpacing))]
  public bool? DoNotUseHTMLParagraphAutoSpacing
  {
    get => _DoNotUseHTMLParagraphAutoSpacing ??= GetElement<bool?, DXW.DoNotUseHTMLParagraphAutoSpacing>(GetUpdatableElement());
    set => UpdateField(ref _DoNotUseHTMLParagraphAutoSpacing, value, nameof(DoNotUseHTMLParagraphAutoSpacing));
  }
  private bool? _DoNotUseHTMLParagraphAutoSpacing;

  /// <summary>
  /// Ignore space before table when deciding if table should wrap floating object.
  /// </summary>
  [OpenXmlElement(typeof(DXW.LayoutRawTableWidth))]
  public bool? LayoutRawTableWidth
  {
    get => _LayoutRawTableWidth ??= GetElement<bool?, DXW.LayoutRawTableWidth>(GetUpdatableElement());
    set => UpdateField(ref _LayoutRawTableWidth, value, nameof(LayoutRawTableWidth));
  }
  private bool? _LayoutRawTableWidth;

  /// <summary>
  /// Allow table rows to wrap inline objects independently.
  /// </summary>
  [OpenXmlElement(typeof(DXW.LayoutTableRowsApart))]
  public bool? LayoutTableRowsApart
  {
    get => _LayoutTableRowsApart ??= GetElement<bool?, DXW.LayoutTableRowsApart>(GetUpdatableElement());
    set => UpdateField(ref _LayoutTableRowsApart, value, nameof(LayoutTableRowsApart));
  }
  private bool? _LayoutTableRowsApart;

  /// <summary>
  /// Emulate Word 97 East Asian line breaking.
  /// </summary>
  [OpenXmlElement(typeof(DXW.UseWord97LineBreakRules))]
  public bool? UseWord97LineBreakRules
  {
    get => _UseWord97LineBreakRules ??= GetElement<bool?, DXW.UseWord97LineBreakRules>(GetUpdatableElement());
    set => UpdateField(ref _UseWord97LineBreakRules, value, nameof(UseWord97LineBreakRules));
  }
  private bool? _UseWord97LineBreakRules;

  /// <summary>
  /// Do not allow floating tables to break across pages.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DoNotBreakWrappedTables))]
  public bool? DoNotBreakWrappedTables
  {
    get => _DoNotBreakWrappedTables ??= GetElement<bool?, DXW.DoNotBreakWrappedTables>(GetUpdatableElement());
    set => UpdateField(ref _DoNotBreakWrappedTables, value, nameof(DoNotBreakWrappedTables));
  }
  private bool? _DoNotBreakWrappedTables;

  /// <summary>
  /// Do not snap to document grid in table cells with objects.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DoNotSnapToGridInCell))]
  public bool? DoNotSnapToGridInCell
  {
    get => _DoNotSnapToGridInCell ??= GetElement<bool?, DXW.DoNotSnapToGridInCell>(GetUpdatableElement());
    set => UpdateField(ref _DoNotSnapToGridInCell, value, nameof(DoNotSnapToGridInCell));
  }
  private bool? _DoNotSnapToGridInCell;

  /// <summary>
  /// Select field when first or last character is selected.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SelectFieldWithFirstOrLastChar))]
  public bool? SelectFieldWithFirstOrLastChar
  {
    get => _SelectFieldWithFirstOrLastChar ??= GetElement<bool?, DXW.SelectFieldWithFirstOrLastChar>(GetUpdatableElement());
    set => UpdateField(ref _SelectFieldWithFirstOrLastChar, value, nameof(SelectFieldWithFirstOrLastChar));
  }
  private bool? _SelectFieldWithFirstOrLastChar;

  /// <summary>
  /// Use legacy Ethiopic and Amharic line breaking rules.
  /// </summary>
  [OpenXmlElement(typeof(DXW.ApplyBreakingRules))]
  public bool? ApplyBreakingRules
  {
    get => _ApplyBreakingRules ??= GetElement<bool?, DXW.ApplyBreakingRules>(GetUpdatableElement());
    set => UpdateField(ref _ApplyBreakingRules, value, nameof(ApplyBreakingRules));
  }
  private bool? _ApplyBreakingRules;

  /// <summary>
  /// Do not allow hanging punctuation with character grid.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DoNotWrapTextWithPunctuation))]
  public bool? DoNotWrapTextWithPunctuation
  {
    get => _DoNotWrapTextWithPunctuation ??= GetElement<bool?, DXW.DoNotWrapTextWithPunctuation>(GetUpdatableElement());
    set => UpdateField(ref _DoNotWrapTextWithPunctuation, value, nameof(DoNotWrapTextWithPunctuation));
  }
  private bool? _DoNotWrapTextWithPunctuation;

  /// <summary>
  /// Do not compress compressible characters when using document grid.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DoNotUseEastAsianBreakRules))]
  public bool? DoNotUseEastAsianBreakRules
  {
    get => _DoNotUseEastAsianBreakRules ??= GetElement<bool?, DXW.DoNotUseEastAsianBreakRules>(GetUpdatableElement());
    set => UpdateField(ref _DoNotUseEastAsianBreakRules, value, nameof(DoNotUseEastAsianBreakRules));
  }
  private bool? _DoNotUseEastAsianBreakRules;

  /// <summary>
  /// Emulate Word 2002 table style rules.
  /// </summary>
  [OpenXmlElement(typeof(DXW.UseWord2002TableStyleRules))]
  public bool? UseWord2002TableStyleRules
  {
    get => _UseWord2002TableStyleRules ??= GetElement<bool?, DXW.UseWord2002TableStyleRules>(GetUpdatableElement());
    set => UpdateField(ref _UseWord2002TableStyleRules, value, nameof(UseWord2002TableStyleRules));
  }
  private bool? _UseWord2002TableStyleRules;

  /// <summary>
  /// Allow tables to autofit into page margins.
  /// </summary>
  [OpenXmlElement(typeof(DXW.GrowAutofit))]
  public bool? GrowAutofit
  {
    get => _GrowAutofit ??= GetElement<bool?, DXW.GrowAutofit>(GetUpdatableElement());
    set => UpdateField(ref _GrowAutofit, value, nameof(GrowAutofit));
  }
  private bool? _GrowAutofit;

  /// <summary>
  /// Do not bypass East Asian/complex script layout code.
  /// </summary>
  [OpenXmlElement(typeof(DXW.UseFarEastLayout))]
  public bool? UseFarEastLayout
  {
    get => _UseFarEastLayout ??= GetElement<bool?, DXW.UseFarEastLayout>(GetUpdatableElement());
    set => UpdateField(ref _UseFarEastLayout, value, nameof(UseFarEastLayout));
  }
  private bool? _UseFarEastLayout;

  /// <summary>
  /// Do not automatically apply list paragraph style to bulleted/numbered text.
  /// </summary>
  [OpenXmlElement(typeof(DXW.UseNormalStyleForList))]
  public bool? UseNormalStyleForList
  {
    get => _UseNormalStyleForList ??= GetElement<bool?, DXW.UseNormalStyleForList>(GetUpdatableElement());
    set => UpdateField(ref _UseNormalStyleForList, value, nameof(UseNormalStyleForList));
  }
  private bool? _UseNormalStyleForList;

  /// <summary>
  /// Ignore hanging indent when creating tab stop after numbering.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DoNotUseIndentAsNumberingTabStop))]
  public bool? DoNotUseIndentAsNumberingTabStop
  {
    get => _DoNotUseIndentAsNumberingTabStop ??= GetElement<bool?, DXW.DoNotUseIndentAsNumberingTabStop>(GetUpdatableElement());
    set => UpdateField(ref _DoNotUseIndentAsNumberingTabStop, value, nameof(DoNotUseIndentAsNumberingTabStop));
  }
  private bool? _DoNotUseIndentAsNumberingTabStop;

  /// <summary>
  /// Use alternate set of East Asian line breaking rules.
  /// </summary>
  [OpenXmlElement(typeof(DXW.UseAltKinsokuLineBreakRules))]
  public bool? UseAltKinsokuLineBreakRules
  {
    get => _UseAltKinsokuLineBreakRules ??= GetElement<bool?, DXW.UseAltKinsokuLineBreakRules>(GetUpdatableElement());
    set => UpdateField(ref _UseAltKinsokuLineBreakRules, value, nameof(UseAltKinsokuLineBreakRules));
  }
  private bool? _UseAltKinsokuLineBreakRules;

  /// <summary>
  /// Allow contextual spacing of paragraphs in tables.
  /// </summary>
  [OpenXmlElement(typeof(DXW.AllowSpaceOfSameStyleInTable))]
  public bool? AllowSpaceOfSameStyleInTable
  {
    get => _AllowSpaceOfSameStyleInTable ??= GetElement<bool?, DXW.AllowSpaceOfSameStyleInTable>(GetUpdatableElement());
    set => UpdateField(ref _AllowSpaceOfSameStyleInTable, value, nameof(AllowSpaceOfSameStyleInTable));
  }
  private bool? _AllowSpaceOfSameStyleInTable;

  /// <summary>
  /// Do not ignore floating objects when calculating paragraph indentation.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DoNotSuppressIndentation))]
  public bool? DoNotSuppressIndentation
  {
    get => _DoNotSuppressIndentation ??= GetElement<bool?, DXW.DoNotSuppressIndentation>(GetUpdatableElement());
    set => UpdateField(ref _DoNotSuppressIndentation, value, nameof(DoNotSuppressIndentation));
  }
  private bool? _DoNotSuppressIndentation;

  /// <summary>
  /// Do not autofit tables to fit next to wrapped objects.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DoNotAutofitConstrainedTables))]
  public bool? DoNotAutofitConstrainedTables
  {
    get => _DoNotAutofitConstrainedTables ??= GetElement<bool?, DXW.DoNotAutofitConstrainedTables>(GetUpdatableElement());
    set => UpdateField(ref _DoNotAutofitConstrainedTables, value, nameof(DoNotAutofitConstrainedTables));
  }
  private bool? _DoNotAutofitConstrainedTables;

  /// <summary>
  /// Allow table columns to exceed preferred widths of constituent cells.
  /// </summary>
  [OpenXmlElement(typeof(DXW.AutofitToFirstFixedWidthCell))]
  public bool? AutofitToFirstFixedWidthCell
  {
    get => _AutofitToFirstFixedWidthCell ??= GetElement<bool?, DXW.AutofitToFirstFixedWidthCell>(GetUpdatableElement());
    set => UpdateField(ref _AutofitToFirstFixedWidthCell, value, nameof(AutofitToFirstFixedWidthCell));
  }
  private bool? _AutofitToFirstFixedWidthCell;

  /// <summary>
  /// Underline following character following numbering.
  /// </summary>
  [OpenXmlElement(typeof(DXW.UnderlineTabInNumberingList))]
  public bool? UnderlineTabInNumberingList
  {
    get => _UnderlineTabInNumberingList ??= GetElement<bool?, DXW.UnderlineTabInNumberingList>(GetUpdatableElement());
    set => UpdateField(ref _UnderlineTabInNumberingList, value, nameof(UnderlineTabInNumberingList));
  }
  private bool? _UnderlineTabInNumberingList;

  /// <summary>
  /// Always use fixed width for Hangul characters.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DisplayHangulFixedWidth))]
  public bool? DisplayHangulFixedWidth
  {
    get => _DisplayHangulFixedWidth ??= GetElement<bool?, DXW.DisplayHangulFixedWidth>(GetUpdatableElement());
    set => UpdateField(ref _DisplayHangulFixedWidth, value, nameof(DisplayHangulFixedWidth));
  }
  private bool? _DisplayHangulFixedWidth;

  /// <summary>
  /// Always move paragraph mark to page after a page break.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SplitPageBreakAndParagraphMark))]
  public bool? SplitPageBreakAndParagraphMark
  {
    get => _SplitPageBreakAndParagraphMark ??= GetElement<bool?, DXW.SplitPageBreakAndParagraphMark>(GetUpdatableElement());
    set => UpdateField(ref _SplitPageBreakAndParagraphMark, value, nameof(SplitPageBreakAndParagraphMark));
  }
  private bool? _SplitPageBreakAndParagraphMark;

  /// <summary>
  /// Do not vertically align cells containing floating objects.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DoNotVerticallyAlignCellWithShape))]
  public bool? DoNotVerticallyAlignCellWithShape
  {
    get => _DoNotVerticallyAlignCellWithShape ??= GetElement<bool?, DXW.DoNotVerticallyAlignCellWithShape>(GetUpdatableElement());
    set => UpdateField(ref _DoNotVerticallyAlignCellWithShape, value, nameof(DoNotVerticallyAlignCellWithShape));
  }
  private bool? _DoNotVerticallyAlignCellWithShape;

  /// <summary>
  /// Do not break table rows around floating tables.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DoNotBreakConstrainedForcedTable))]
  public bool? DoNotBreakConstrainedForcedTable
  {
    get => _DoNotBreakConstrainedForcedTable ??= GetElement<bool?, DXW.DoNotBreakConstrainedForcedTable>(GetUpdatableElement());
    set => UpdateField(ref _DoNotBreakConstrainedForcedTable, value, nameof(DoNotBreakConstrainedForcedTable));
  }
  private bool? _DoNotBreakConstrainedForcedTable;

  /// <summary>
  /// Ignore vertical alignment in textboxes.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DoNotVerticallyAlignInTextBox))]
  public bool? DoNotVerticallyAlignInTextBox
  {
    get => _DoNotVerticallyAlignInTextBox ??= GetElement<bool?, DXW.DoNotVerticallyAlignInTextBox>(GetUpdatableElement());
    set => UpdateField(ref _DoNotVerticallyAlignInTextBox, value, nameof(DoNotVerticallyAlignInTextBox));
  }
  private bool? _DoNotVerticallyAlignInTextBox;

  /// <summary>
  /// Use ANSI kerning pairs from fonts.
  /// </summary>
  [OpenXmlElement(typeof(DXW.UseAnsiKerningPairs))]
  public bool? UseAnsiKerningPairs
  {
    get => _UseAnsiKerningPairs ??= GetElement<bool?, DXW.UseAnsiKerningPairs>(GetUpdatableElement());
    set => UpdateField(ref _UseAnsiKerningPairs, value, nameof(UseAnsiKerningPairs));
  }
  private bool? _UseAnsiKerningPairs;

  /// <summary>
  /// Use cached paragraph information for column balancing.
  /// </summary>
  [OpenXmlElement(typeof(DXW.CachedColumnBalance))]
  public bool? CachedColumnBalance
  {
    get => _CachedColumnBalance ??= GetElement<bool?, DXW.CachedColumnBalance>(GetUpdatableElement());
    set => UpdateField(ref _CachedColumnBalance, value, nameof(CachedColumnBalance));
  }
  private bool? _CachedColumnBalance;

  /// <summary>
  /// Compatibility settings collection for additional options.
  /// </summary>
  public OtherSettings OtherSettings { get => _OtherSettings ??= new OtherSettings(this, GetUpdatableElement()); }
  private OtherSettings? _OtherSettings;
}