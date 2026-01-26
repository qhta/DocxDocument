namespace DocumentModel.Drawings;
/// <summary>
///   Represents properties for a text paragraph, including margins, indentation, alignment, tab size, line breaks, font alignment, spacing, and other formatting options.
/// </summary>
[OpenXmlType(typeof(DXD.ParagraphProperties))]
public partial class ParagraphProperties : ModelElement<DXD.ParagraphProperties>
{
    /// <summary>
    ///   Left margin of the paragraph.
    /// </summary>
    public Int32? LeftMargin { get => _LeftMargin; set => UpdateField(ref _LeftMargin, value, nameof(LeftMargin)); }

    private Int32? _LeftMargin;
    /// <summary>
    ///   Right margin of the paragraph.
    /// </summary>
    public Int32? RightMargin { get => _RightMargin; set => UpdateField(ref _RightMargin, value, nameof(RightMargin)); }

    private Int32? _RightMargin;
    /// <summary>
    ///   Outline level of the paragraph.
    /// </summary>
    public Int32? Level { get => _Level; set => UpdateField(ref _Level, value, nameof(Level)); }

    private Int32? _Level;
    /// <summary>
    ///   Indentation value for the paragraph.
    /// </summary>
    public Int32? Indent { get => _Indent; set => UpdateField(ref _Indent, value, nameof(Indent)); }

    private Int32? _Indent;
    /// <summary>
    ///   Alignment of the paragraph text.
    /// </summary>
    public TextAlignmentKind? Alignment { get => _Alignment; set => UpdateField(ref _Alignment, value, nameof(Alignment)); }

    private TextAlignmentKind? _Alignment;
    /// <summary>
    ///   Default tab size for the paragraph.
    /// </summary>
    public Int32? DefaultTabSize { get => _DefaultTabSize; set => UpdateField(ref _DefaultTabSize, value, nameof(DefaultTabSize)); }

    private Int32? _DefaultTabSize;
    /// <summary>
    ///   Indicates right-to-left text direction.
    /// </summary>
    public bool? RightToLeft { get => _RightToLeft; set => UpdateField(ref _RightToLeft, value, nameof(RightToLeft)); }

    private bool? _RightToLeft;
    /// <summary>
    ///   Enables East Asian line break rules.
    /// </summary>
    public bool? EastAsianLineBreak { get => _EastAsianLineBreak; set => UpdateField(ref _EastAsianLineBreak, value, nameof(EastAsianLineBreak)); }

    private bool? _EastAsianLineBreak;
    /// <summary>
    ///   Font alignment within the paragraph.
    /// </summary>
    public TextFontAlignmentKind? FontAlignment { get => _FontAlignment; set => UpdateField(ref _FontAlignment, value, nameof(FontAlignment)); }

    private TextFontAlignmentKind? _FontAlignment;
    /// <summary>
    ///   Enables Latin line break rules.
    /// </summary>
    public bool? LatinLineBreak { get => _LatinLineBreak; set => UpdateField(ref _LatinLineBreak, value, nameof(LatinLineBreak)); }

    private bool? _LatinLineBreak;
    /// <summary>
    ///   Enables hanging punctuation.
    /// </summary>
    public bool? Height { get => _Height; set => UpdateField(ref _Height, value, nameof(Height)); }

    private bool? _Height;
    /// <summary>
    ///   Line spacing for the paragraph.
    /// </summary>
    public LineSpacing? LineSpacing { get => _LineSpacing; set => UpdateField(ref _LineSpacing, value, nameof(LineSpacing)); }

    private LineSpacing? _LineSpacing;
    /// <summary>
    ///   Space before the paragraph.
    /// </summary>
    public SpaceBefore? SpaceBefore { get => _SpaceBefore; set => UpdateField(ref _SpaceBefore, value, nameof(SpaceBefore)); }

    private SpaceBefore? _SpaceBefore;
    /// <summary>
    ///   Space after the paragraph.
    /// </summary>
    public SpaceAfter? SpaceAfter { get => _SpaceAfter; set => UpdateField(ref _SpaceAfter, value, nameof(SpaceAfter)); }

    private SpaceAfter? _SpaceAfter;
}