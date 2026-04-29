namespace DocumentModel.Drawings;
/// <summary>
///   Abstract base class for font scheme definitions in DrawingML, providing configuration for Latin, East Asian, and complex script fonts, as well as supplemental fonts and extensibility.
///   Used to define font mappings for different language scripts in document themes and styles.
/// </summary>
[XmlRoot("SchemeFont", Namespace = "DocumentModel.Drawings")]
[DirectAccess]
public abstract partial class SchemeFont<T> : ModelElement<T>, IExtendableElement where T : DXD.FontCollectionType
{
  /// <summary>
  ///   TextFormat configuration for Latin script text (e.g., English, Western European languages).
  /// </summary>
  [OpenXmlElement(typeof(DXD.LatinFont))]
  public TextFontType? LatinFont 
  {
    get => _LatinFont ??= GetElement<TextFontType?, DXD.LatinFont>(_openXmlElement);
    set => UpdateField(ref _LatinFont, value, nameof(LatinFont));
  }
  private TextFontType? _LatinFont;

  /// <summary>
  ///   TextFormat configuration for East Asian script text (e.g., Chinese, Japanese, Korean).
  /// </summary>
  [OpenXmlElement(typeof(DXD.EastAsianFont))]
  public TextFontType? EastAsianFont 
  {
    get => _EastAsianFont ??= GetElement<TextFontType?, DXD.EastAsianFont>(_openXmlElement);
    set => UpdateField(ref _EastAsianFont, value, nameof(EastAsianFont));
  }
  private TextFontType? _EastAsianFont;

  /// <summary>
  ///   TextFormat configuration for complex script text (e.g., Arabic, Hebrew, South Asian scripts).
  /// </summary>
  [OpenXmlElement(typeof(DXD.ComplexScriptFont))]
  public TextFontType? ComplexScriptFont 
  {
    get => _ComplexScriptFont ??= GetElement<TextFontType?, DXD.ComplexScriptFont>(_openXmlElement);
    set => UpdateField(ref _ComplexScriptFont, value, nameof(ComplexScriptFont));
  }
  private TextFontType? _ComplexScriptFont;

  /// <summary>
  ///   Collection of supplemental fonts for additional language and script support beyond the primary font definitions.
  /// </summary>
  public SupplementalFonts? SupplementalFonts 
  {
    get => _SupplementalFonts ??= new SupplementalFonts(this, _openXmlElement);
    set => UpdateField(ref _SupplementalFonts, value, nameof(SupplementalFonts));
  }
  private SupplementalFonts? _SupplementalFonts;


  /// <summary>
  ///   List of extension elements for the scheme font, supporting extensibility and application-specific font data.
  /// </summary>
  [OpenXmlElement(typeof(DXD.ExtensionList))]
  public ExtensionList? ExtensionList 
  {
    get => _ExtensionList ??= GetElement<ExtensionList?, DXD.ExtensionList>(_openXmlElement);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }
  private ExtensionList? _ExtensionList;
}