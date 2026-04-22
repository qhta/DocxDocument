namespace DocumentModel.Drawings;

/// <summary>
///   Represents a theme, including its name, identifier, theme elements, object defaults, color schemes, custom colors, and extension lists.
/// </summary>
[OpenXmlType(typeof(DXD.Theme))]
[XmlRoot("Theme", Namespace = "DocumentModel.Drawings")]
public sealed partial class Theme: ModelElement<DXD.Theme>, IOfficeStyleSheetExtendableElement
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public Theme() { }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name = "document">The document to attach to.</param>
  public Theme(DMW.Document document)
  {
    if (document.WordprocessingDocument != null)
      AttachAndLoad(document.WordprocessingDocument);
  }

  /// <summary>
  /// Attach this instance to the specified wordprocessingDocument. Data is loaded from the wordprocessingDocument's FontTable.
  /// </summary>
  /// <param name = "wordprocessingDocument">Document to attach to.</param>
  public override void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndLoad(wordprocessingDocument);
    var theme = wordprocessingDocument.GetTheme();
    SetUpdatableElement(theme);
    LoadData(theme);
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is stored to the document's FontTable.
  /// </summary>
  /// <param name = "wordprocessingDocument">Document to attach to.</param>
  public override void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndUpdate(wordprocessingDocument);
    var theme = wordprocessingDocument.GetTheme();
    SetUpdatableElement(theme);
    UpdateData(theme);
  }

  /// <summary>
  ///   Name of the theme.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Theme.Name))]
  public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
  private string? _Name;

  /// <summary>
  ///   Identifier for the theme.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Theme.ThemeId))]
  public string? ThemeId { get => _ThemeId; set => UpdateField(ref _ThemeId, value, nameof(ThemeId)); }
  private string? _ThemeId;

  /// <summary>
  ///   Elements that define the theme's appearance.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Theme.ThemeElements))]
  public ThemeElements? ThemeElements
  {
    get => _ThemeElements;
    set => UpdateField(ref _ThemeElements, value, nameof(ThemeElements));
  }
  private ThemeElements? _ThemeElements;

  /// <summary>
  ///   Default formatting for objects in the theme.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Theme.ObjectDefaults))]
  public ObjectDefaults? ObjectDefaults
  {
    get => _ObjectDefaults;
    set => UpdateField(ref _ObjectDefaults, value, nameof(ObjectDefaults));
  }
  private ObjectDefaults? _ObjectDefaults;

  /// <summary>
  ///   List of extra color schemes associated with the theme.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Theme.ExtraColorSchemeList))]
  public ExtraColorSchemeList? ExtraColorSchemeList
  {
    get => _ExtraColorSchemeList;
    set => UpdateField(ref _ExtraColorSchemeList, value, nameof(ExtraColorSchemeList));
  }
  private ExtraColorSchemeList? _ExtraColorSchemeList;

  /// <summary>
  ///   List of custom colors defined for the theme.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Theme.CustomColorList))]
  public CustomColorList? CustomColorList
  {
    get => _CustomColorList;
    set => UpdateField(ref _CustomColorList, value, nameof(CustomColorList));
  }
  private CustomColorList? _CustomColorList;

  /// <summary>
  ///   List of Office style sheet extensions associated with the theme.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Theme.OfficeStyleSheetExtensionList))]
  public OfficeStyleSheetExtensionList? OfficeStyleSheetExtensionList
  {
    get => _OfficeStyleSheetExtensionList;
    set => UpdateField(ref _OfficeStyleSheetExtensionList, value, nameof(OfficeStyleSheetExtensionList));
  }
  private OfficeStyleSheetExtensionList? _OfficeStyleSheetExtensionList;
}