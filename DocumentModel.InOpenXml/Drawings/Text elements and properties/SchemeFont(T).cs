namespace DocumentModel.Drawings;
/// <summary>
///   Abstract base class for font scheme definitions in DrawingML, providing configuration for Latin, East Asian, and complex script fonts, as well as supplemental fonts and extensibility.
///   Used to define font mappings for different language scripts in document themes and styles.
/// </summary>
[DataContract]
[XmlRoot("SchemeFont", Namespace = "DocumentModel.Drawings")]
[DirectAccess]
public abstract partial class SchemeFont<T> : ModelElement<T>, IExtendableElement where T : DXD.FontCollectionType
{
  /// <summary>
  ///   TextFormat configuration for Latin script text (e.g., English and other languages based on Latin alphabet).
  /// </summary>
  [OpenXmlElement(typeof(DXD.LatinFont))]
  public TextFontType? LatinFont 
  {
    get => _LatinFont ??= GetElement<TextFontType?, DXD.LatinFont>(GetUpdatableElement());
    set => UpdateField(ref _LatinFont, value, nameof(LatinFont));
  }
  private TextFontType? _LatinFont;

  /// <summary>
  ///   TextFormat configuration for East Asian script text (e.g., Chinese, Japanese, Korean).
  /// </summary>
  [OpenXmlElement(typeof(DXD.EastAsianFont))]
  public TextFontType? EastAsianFont 
  {
    get => _EastAsianFont ??= GetElement<TextFontType?, DXD.EastAsianFont>(GetUpdatableElement());
    set => UpdateField(ref _EastAsianFont, value, nameof(EastAsianFont));
  }
  private TextFontType? _EastAsianFont;

  /// <summary>
  ///   TextFormat configuration for complex script text (e.g., Arabic, Hebrew, South Asian scripts).
  /// </summary>
  [OpenXmlElement(typeof(DXD.ComplexScriptFont))]
  public TextFontType? ComplexScriptFont 
  {
    get => _ComplexScriptFont ??= GetElement<TextFontType?, DXD.ComplexScriptFont>(GetUpdatableElement());
    set => UpdateField(ref _ComplexScriptFont, value, nameof(ComplexScriptFont));
  }
  private TextFontType? _ComplexScriptFont;

  /// <summary>
  ///   Collection of supplemental fonts for additional language and script support beyond the primary font definitions.
  /// </summary>
  [OpenXmlUpdateData(nameof(UpdateSupplementalFonts))]
  [OpenXmlLoadData(nameof(LoadSupplementalFonts))]

  public SupplementalFonts? SupplementalFonts
  {
    get => _SupplementalFonts ??= new SupplementalFonts(this, GetUpdatableElement());
    set => UpdateField(ref _SupplementalFonts, value, nameof(SupplementalFonts));
  }
  private SupplementalFonts? _SupplementalFonts;

  /// <summary>
  ///  Updates the supplemental fonts collection in the OpenXml element based on the current state of the SupplementalFonts property in the model. This method is called during the update process to synchronize the model with the underlying OpenXml representation.
  /// </summary>
  /// <param name="openXmlElement"></param>
  public void UpdateSupplementalFonts(DX.OpenXmlElement openXmlElement)
  {
    openXmlElement.RemoveAllChildren<DXD.SupplementalFont>();
    if (SupplementalFonts == null)
      return;
    if (SupplementalFonts.Count > 0)
    {
      foreach (var modelItem in SupplementalFonts)
      {
        var openXmlItem = OpenXmlModelConverter.ConvertTo(modelItem, typeof(DXD.SupplementalFont));
        if (openXmlItem is DXD.SupplementalFont supplementalFont)
          openXmlElement.AppendChild(supplementalFont);
      }
    }
  }

  /// <summary>
  /// Loads the supplemental fonts collection from the specified OpenXml element, populating the SupplementalFonts property in the model based on the child elements of type DXD.SupplementalFont found in the OpenXml element. This method is called during the loading process to synchronize the model with the underlying OpenXml representation.
  /// </summary>
  /// <param name="openXmlElement"></param>
  public void LoadSupplementalFonts(DX.OpenXmlElement openXmlElement)
  {
    SupplementalFonts?.Clear();
    var openXmlItems = openXmlElement.Elements<DXD.SupplementalFont>();
    foreach (var openXmlItem in openXmlItems)
    {
      var modelItem = OpenXmlModelConverter.ConvertTo(openXmlItem, typeof(DMD.SupplementalFont));
      if (modelItem is DMD.SupplementalFont supplementalFont)
        SupplementalFonts?.Add(supplementalFont);
    }
  }
  /// <summary>
  ///   List of extension elements for the scheme font, supporting extensibility and application-specific font data.
  /// </summary>
  [OpenXmlElement(typeof(DXD.ExtensionList))]
  public ExtensionList? ExtensionList 
  {
    get => _ExtensionList ??= GetElement<ExtensionList?, DXD.ExtensionList>(GetUpdatableElement());
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }
  private ExtensionList? _ExtensionList;
}