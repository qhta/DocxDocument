namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the properties for a phonetic guide (ruby text) in WordprocessingML documents.
/// This interface provides options for alignment, font size, distance between guide and base text, base text size, language, and field cache status, enabling advanced formatting and localization of ruby annotations.
/// </summary>
public partial class RubyProperties : ModelElement<DXW.RubyProperties>
{
    /// <summary>
    /// Alignment of the phonetic guide text relative to the base text.
    /// </summary>
    public RubyAlignKind? RubyAlign { get => _RubyAlign; set => UpdateField(ref _RubyAlign, value, nameof(RubyAlign)); }

    private RubyAlignKind? _RubyAlign;
    /// <summary>
    /// Font size of the phonetic guide text, specified in half-points.
    /// </summary>
    public HalfPoints? PhoneticGuideTextFontSize { get; set; }
    /// <summary>
    /// Distance between the phonetic guide text and the base text, specified in twips.
    /// </summary>
    public Int16? PhoneticGuideRaise { get; set; }
    /// <summary>
    /// Font size of the phonetic guide base text, specified in half-points.
    /// </summary>
    public HalfPoints? PhoneticGuideBaseTextSize { get; set; }
    /// <summary>
    /// Language ID for the phonetic guide, specifying the language used for annotation.
    /// </summary>
    public string? LanguageId { get; set; }
    /// <summary>
    /// Indicates whether the field cache is invalidated for the phonetic guide.
    /// </summary>
    public bool? Dirty { get; set; }
}