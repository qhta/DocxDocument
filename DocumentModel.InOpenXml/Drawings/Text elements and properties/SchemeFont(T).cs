namespace DocumentModel.Drawings;
public abstract partial class SchemeFont<T> : ModelElement<T>, IExtendableElement where T : DX.OpenXmlElement
{
    /// <summary>
    ///   Font settings for Latin text.
    /// </summary>
    public TextFontType? LatinFont { get => _LatinFont; set => UpdateField(ref _LatinFont, value, nameof(LatinFont)); }

    private TextFontType? _LatinFont;
    /// <summary>
    ///   Font settings for East Asian text.
    /// </summary>
    public TextFontType? EastAsianFont { get => _EastAsianFont; set => UpdateField(ref _EastAsianFont, value, nameof(EastAsianFont)); }

    private TextFontType? _EastAsianFont;
    /// <summary>
    ///   Font settings for complex script text.
    /// </summary>
    public TextFontType? ComplexScriptFont { get => _ComplexScriptFont; set => UpdateField(ref _ComplexScriptFont, value, nameof(ComplexScriptFont)); }

    private TextFontType? _ComplexScriptFont;
    /// <summary>
    ///   Collection of supplemental fonts for additional language support.
    /// </summary>
    public SupplementalFonts? SupplementalFonts { get => _SupplementalFonts; set => UpdateField(ref _SupplementalFonts, value, nameof(SupplementalFonts)); }

    private SupplementalFonts? _SupplementalFonts;
    /// <summary>
    /// List of extension properties for the scheme font, used for extensibility scenarios.
    /// </summary>
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
}