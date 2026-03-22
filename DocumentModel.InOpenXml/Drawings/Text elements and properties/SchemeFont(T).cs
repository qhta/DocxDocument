namespace DocumentModel.Drawings;
/// <summary>
///   Abstract base class for font scheme definitions in DrawingML, providing configuration for Latin, East Asian, and complex script fonts, as well as supplemental fonts and extensibility.
///   Used to define font mappings for different language scripts in document themes and styles.
/// </summary>
public abstract partial class SchemeFont<T> : ModelElement<T>, IExtendableElement where T : DX.OpenXmlElement
{
    /// <summary>
    ///   Font configuration for Latin script text (e.g., English, Western European languages).
    /// </summary>
    public TextFontType? LatinFont { get => _LatinFont; set => UpdateField(ref _LatinFont, value, nameof(LatinFont)); }
    private TextFontType? _LatinFont;
    /// <summary>
    ///   Font configuration for East Asian script text (e.g., Chinese, Japanese, Korean).
    /// </summary>
    public TextFontType? EastAsianFont { get => _EastAsianFont; set => UpdateField(ref _EastAsianFont, value, nameof(EastAsianFont)); }
    private TextFontType? _EastAsianFont;
    /// <summary>
    ///   Font configuration for complex script text (e.g., Arabic, Hebrew, South Asian scripts).
    /// </summary>
    public TextFontType? ComplexScriptFont { get => _ComplexScriptFont; set => UpdateField(ref _ComplexScriptFont, value, nameof(ComplexScriptFont)); }
    private TextFontType? _ComplexScriptFont;
    /// <summary>
    ///   Collection of supplemental fonts for additional language and script support beyond the primary font definitions.
    /// </summary>
    public SupplementalFonts? SupplementalFonts { get => _SupplementalFonts; set => UpdateField(ref _SupplementalFonts, value, nameof(SupplementalFonts)); }
    private SupplementalFonts? _SupplementalFonts;
    /// <summary>
    ///   List of extension elements for the scheme font, supporting extensibility and application-specific font data.
    /// </summary>
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
    private ExtensionList? _ExtensionList;
}
