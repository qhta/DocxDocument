namespace DocumentModel.Drawings;
/// <summary>
///   Abstract base class for font scheme definitions in DrawingML, providing configuration for Latin, East Asian, and complex script fonts, as well as supplemental fonts and extensibility.
///   Used to define font mappings for different language scripts in document themes and styles.
/// </summary>
[XmlRoot("SchemeFont", Namespace = "DocumentModel.Drawings")]
public abstract partial class SchemeFont<T> : ModelElement<T>, IExtendableElement where T : DX.OpenXmlElement
{
  /// <summary>
  ///   TextFormat configuration for Latin script text (e.g., English, Western European languages).
  /// </summary>
  [OpenXmlElement(typeof(DXD.LatinFont))]
  public TextFontType? LatinFont { get => _LatinFont; set => UpdateField(ref _LatinFont, value, nameof(LatinFont)); }
  private TextFontType? _LatinFont;

  /// <summary>
  ///   TextFormat configuration for East Asian script text (e.g., Chinese, Japanese, Korean).
  /// </summary>
  [OpenXmlElement(typeof(DXD.EastAsianFont))]
  public TextFontType? EastAsianFont { get => _EastAsianFont; set => UpdateField(ref _EastAsianFont, value, nameof(EastAsianFont)); }
  private TextFontType? _EastAsianFont;

  /// <summary>
  ///   TextFormat configuration for complex script text (e.g., Arabic, Hebrew, South Asian scripts).
  /// </summary>
  [OpenXmlElement(typeof(DXD.ComplexScriptFont))]
  public TextFontType? ComplexScriptFont { get => _ComplexScriptFont; set => UpdateField(ref _ComplexScriptFont, value, nameof(ComplexScriptFont)); }
  private TextFontType? _ComplexScriptFont;

  /// <summary>
  ///   Collection of supplemental fonts for additional language and script support beyond the primary font definitions.
  /// </summary>
  [OpenXmlLoadData(nameof(LoadSupplementalFontsFromOpenXml))]
  [OpenXmlUpdateData(nameof(UpdateSupplementalFontsFromOpenXml))]
  public SupplementalFonts? SupplementalFonts { get => _SupplementalFonts; set => UpdateField(ref _SupplementalFonts, value, nameof(SupplementalFonts)); }
  private SupplementalFonts? _SupplementalFonts;

  /// <summary>
  /// Loads supplemental font information from the specified Open XML element into the current object.
  /// </summary>
  /// <param name="openXmlElement">The Open XML element containing supplemental font data to be loaded.</param>
  private void LoadSupplementalFontsFromOpenXml(DX.OpenXmlElement openXmlElement)
  {
    SupplementalFonts ??= new SupplementalFonts(this);
    SupplementalFonts.LoadData(openXmlElement);
  }

  /// <summary>
  /// Updates the supplemental fonts information using data from the specified Open XML element.
  /// </summary>
  /// <param name="openXmlElement">The Open XML element containing the supplemental fonts data to update from.</param>
  private void UpdateSupplementalFontsFromOpenXml(DX.OpenXmlElement openXmlElement)
  {
    SupplementalFonts?.UpdateData(openXmlElement);
  }

  /// <summary>
  ///   List of extension elements for the scheme font, supporting extensibility and application-specific font data.
  /// </summary>
  [OpenXmlElement(typeof(DXD.ExtensionList))]
  public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
  private ExtensionList? _ExtensionList;
}