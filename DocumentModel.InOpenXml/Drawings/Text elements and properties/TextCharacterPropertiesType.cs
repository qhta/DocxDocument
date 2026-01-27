namespace DocumentModel.Drawings;
/// <summary>
///   Represents character-level formatting properties for text, including font, style, language, spacing, underline, strike, and outline settings.
/// </summary>
[OpenXmlType(typeof(DXD.TextCharacterPropertiesType))]
public partial class TextCharacterPropertiesType : ModelElement<DXD.TextCharacterPropertiesType>
{
    /// <summary>
    ///   Value available for backwards compatibility.
    /// </summary>
    public bool? SmtClean { get => _SmtClean; set => UpdateField(ref _SmtClean, value, nameof(SmtClean)); }

    private bool? _SmtClean;
    /// <summary>
    ///   Value available for backwards compatibility.
    /// </summary>
    public UInt32? SmtId { get => _SmtId; set => UpdateField(ref _SmtId, value, nameof(SmtId)); }

    private UInt32? _SmtId;
    /// <summary>
    ///   Indicates kumimoji (grouped characters) usage.
    /// </summary>
    public bool? Kumimoji { get => _Kumimoji; set => UpdateField(ref _Kumimoji, value, nameof(Kumimoji)); }

    private bool? _Kumimoji;
    /// <summary>
    ///   Language identifier.
    /// </summary>
    public string? Language { get => _Language; set => UpdateField(ref _Language, value, nameof(Language)); }

    private string? _Language;
    /// <summary>
    ///   Alternative language identifier.
    /// </summary>
    public string? AlternativeLanguage { get => _AlternativeLanguage; set => UpdateField(ref _AlternativeLanguage, value, nameof(AlternativeLanguage)); }

    private string? _AlternativeLanguage;
    /// <summary>
    ///   Font size.
    /// </summary>
    public Int32? FontSize { get => _FontSize; set => UpdateField(ref _FontSize, value, nameof(FontSize)); }

    private Int32? _FontSize;
    /// <summary>
    ///   Bold style.
    /// </summary>
    public bool? Bold { get => _Bold; set => UpdateField(ref _Bold, value, nameof(Bold)); }

    private bool? _Bold;
    /// <summary>
    ///   Italic style.
    /// </summary>
    public bool? Italic { get => _Italic; set => UpdateField(ref _Italic, value, nameof(Italic)); }

    private bool? _Italic;
    /// <summary>
    ///   Underline style.
    /// </summary>
    public TextUnderlineKind? Underline { get => _Underline; set => UpdateField(ref _Underline, value, nameof(Underline)); }

    private TextUnderlineKind? _Underline;
    /// <summary>
    ///   Strike-through style.
    /// </summary>
    public TextStrikeKind? Strike { get => _Strike; set => UpdateField(ref _Strike, value, nameof(Strike)); }

    private TextStrikeKind? _Strike;
    /// <summary>
    ///   Kerning value.
    /// </summary>
    public Int32? Kerning { get => _Kerning; set => UpdateField(ref _Kerning, value, nameof(Kerning)); }

    private Int32? _Kerning;
    /// <summary>
    ///   Capitalization style.
    /// </summary>
    public TextCapsKind? Capital { get => _Capital; set => UpdateField(ref _Capital, value, nameof(Capital)); }

    private TextCapsKind? _Capital;
    /// <summary>
    ///   Spacing value.
    /// </summary>
    public Int32? Spacing { get => _Spacing; set => UpdateField(ref _Spacing, value, nameof(Spacing)); }

    private Int32? _Spacing;
    /// <summary>
    ///   Indicates normalization of height.
    /// </summary>
    public bool? NormalizeHeight { get => _NormalizeHeight; set => UpdateField(ref _NormalizeHeight, value, nameof(NormalizeHeight)); }

    private bool? _NormalizeHeight;
    /// <summary>
    ///   Baseline offset.
    /// </summary>
    public Int32? Baseline { get => _Baseline; set => UpdateField(ref _Baseline, value, nameof(Baseline)); }

    private Int32? _Baseline;
    /// <summary>
    ///   Indicates proofing exclusion.
    /// </summary>
    public bool? NoProof { get => _NoProof; set => UpdateField(ref _NoProof, value, nameof(NoProof)); }

    private bool? _NoProof;
    /// <summary>
    ///   Indicates dirty state.
    /// </summary>
    public bool? Dirty { get => _Dirty; set => UpdateField(ref _Dirty, value, nameof(Dirty)); }

    private bool? _Dirty;
    /// <summary>
    ///   Indicates spelling error.
    /// </summary>
    public bool? SpellingError { get => _SpellingError; set => UpdateField(ref _SpellingError, value, nameof(SpellingError)); }

    private bool? _SpellingError;
    /// <summary>
    ///   Indicates smart tag clean state.
    /// </summary>
    public bool? SmartTagClean { get => _SmartTagClean; set => UpdateField(ref _SmartTagClean, value, nameof(SmartTagClean)); }

    private bool? _SmartTagClean;
    /// <summary>
    ///   Smart tag identifier.
    /// </summary>
    public UInt32? SmartTagId { get => _SmartTagId; set => UpdateField(ref _SmartTagId, value, nameof(SmartTagId)); }

    private UInt32? _SmartTagId;
    /// <summary>
    ///   Bookmark name.
    /// </summary>
    public string? Bookmark { get => _Bookmark; set => UpdateField(ref _Bookmark, value, nameof(Bookmark)); }

    private string? _Bookmark;
    /// <summary>
    ///   Outline properties for the text.
    /// </summary>
    public LineProperties? Outline { get => _Outline; set => UpdateField(ref _Outline, value, nameof(Outline)); }

    private LineProperties? _Outline;
}