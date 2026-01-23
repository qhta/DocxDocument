namespace DocumentModel.Drawings;
/// <summary>
///   Represents a collection of font settings for different writing systems, including Latin, East Asian, and complex scripts.
/// </summary>
public partial class FontCollectionType : ModelElement<DXD.FontCollectionType>
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
}