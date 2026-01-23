namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the properties for a phonetic guide (ruby text) in WordprocessingML documents.
/// This class provides options for alignment, font size, distance between guide and base text, base text size, language, and field cache status, enabling advanced formatting and localization of ruby annotations.
/// </summary>
public partial class RubyProperties : ModelElement<DXW.RubyProperties>
{
    /// <summary>
    /// Alignment of the phonetic guide text relative to the base text.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.RubyProperties.RubyAlign))]
    /// <summary>
    /// Alignment of the phonetic guide text relative to the base text.
    /// </summary>
    [OpenXmlElement(typeof(DXW.RubyProperties))]
    public RubyAlignKind? RubyAlign { get => _RubyAlign; set => UpdateField(ref _RubyAlign, value, nameof(RubyAlign)); }

    private RubyAlignKind? _RubyAlign;
    /// <summary>
    /// Font size of the phonetic guide text, specified in half-points.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.RubyProperties.PhoneticGuideTextFontSize))]
    /// <summary>
    /// Font size of the phonetic guide text, specified in half-points.
    /// </summary>
    [OpenXmlElement(typeof(DXW.RubyProperties))]
    public HalfPoints? PhoneticGuideTextFontSize { get => _PhoneticGuideTextFontSize; set => UpdateField(ref _PhoneticGuideTextFontSize, value, nameof(PhoneticGuideTextFontSize)); }

    private HalfPoints? _PhoneticGuideTextFontSize;
    /// <summary>
    /// Distance between the phonetic guide text and the base text, specified in twips.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.RubyProperties.PhoneticGuideRaise))]
    /// <summary>
    /// Distance between the phonetic guide text and the base text, specified in twips.
    /// </summary>
    [OpenXmlElement(typeof(DXW.RubyProperties))]
    public Int16? PhoneticGuideRaise { get => _PhoneticGuideRaise; set => UpdateField(ref _PhoneticGuideRaise, value, nameof(PhoneticGuideRaise)); }

    private Int16? _PhoneticGuideRaise;
    /// <summary>
    /// Font size of the phonetic guide base text, specified in half-points.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.RubyProperties.PhoneticGuideBaseTextSize))]
    /// <summary>
    /// Font size of the phonetic guide base text, specified in half-points.
    /// </summary>
    [OpenXmlElement(typeof(DXW.RubyProperties))]
    public HalfPoints? PhoneticGuideBaseTextSize { get => _PhoneticGuideBaseTextSize; set => UpdateField(ref _PhoneticGuideBaseTextSize, value, nameof(PhoneticGuideBaseTextSize)); }

    private HalfPoints? _PhoneticGuideBaseTextSize;
    /// <summary>
    /// Language ID for the phonetic guide, specifying the language used for annotation.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.RubyProperties.LanguageId))]
    /// <summary>
    /// Language ID for the phonetic guide, specifying the language used for annotation.
    /// </summary>
    [OpenXmlElement(typeof(DXW.RubyProperties))]
    public string? LanguageId { get => _LanguageId; set => UpdateField(ref _LanguageId, value, nameof(LanguageId)); }

    private string? _LanguageId;
    /// <summary>
    /// Indicates whether the field cache is invalidated for the phonetic guide.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.RubyProperties.Dirty))]
    /// <summary>
    /// Indicates whether the field cache is invalidated for the phonetic guide.
    /// </summary>
    [OpenXmlElement(typeof(DXW.RubyProperties))]
    public bool? Dirty { get => _Dirty; set => UpdateField(ref _Dirty, value, nameof(Dirty)); }

    private bool? _Dirty;
}