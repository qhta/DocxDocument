namespace DocumentModel.Drawings;
/// <summary>
///   Represents a theme, including its name, identifier, theme elements, object defaults, color schemes, custom colors, and extension lists.
/// </summary>
[OpenXmlType(typeof(DXD.Theme))]
/// <summary>
///   Represents a theme, including its name, identifier, theme elements, object defaults, color schemes, custom colors, and extension lists.
/// </summary>
public partial class Theme : ModelElement<DXD.Theme>, IOfficeStyleSheetExtendableElement
{
 /// <summary>
 ///   FontName of the theme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Theme.Name))]
 [OpenXmlElement(typeof(DXD.Theme))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

 private string? _Name;
 /// <summary>
 ///   Identifier for the theme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Theme.ThemeId))]
 [OpenXmlElement(typeof(DXD.Theme))]
 public string? ThemeId { get => _ThemeId; set => UpdateField(ref _ThemeId, value, nameof(ThemeId)); }

 private string? _ThemeId;
 /// <summary>
 ///   Elements that define the theme's appearance.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Theme.ThemeElements))]
 [OpenXmlElement(typeof(DXD.Theme))]
 public ThemeElements? ThemeElements { get => _ThemeElements; set => UpdateField(ref _ThemeElements, value, nameof(ThemeElements)); }

 private ThemeElements? _ThemeElements;
 /// <summary>
 ///   Default formatting for objects in the theme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Theme.ObjectDefaults))]
 [OpenXmlElement(typeof(DXD.Theme))]
 public ObjectDefaults? ObjectDefaults { get => _ObjectDefaults; set => UpdateField(ref _ObjectDefaults, value, nameof(ObjectDefaults)); }

 private ObjectDefaults? _ObjectDefaults;
 /// <summary>
 ///   List of extra color schemes associated with the theme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Theme.ExtraColorSchemeList))]
 [OpenXmlElement(typeof(DXD.Theme))]
 public ExtraColorSchemeList? ExtraColorSchemeList { get => _ExtraColorSchemeList; set => UpdateField(ref _ExtraColorSchemeList, value, nameof(ExtraColorSchemeList)); }

 private ExtraColorSchemeList? _ExtraColorSchemeList;
 /// <summary>
 ///   List of custom colors defined for the theme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Theme.CustomColorList))]
 [OpenXmlElement(typeof(DXD.Theme))]
 public CustomColorList? CustomColorList { get => _CustomColorList; set => UpdateField(ref _CustomColorList, value, nameof(CustomColorList)); }

 private CustomColorList? _CustomColorList;
 /// <summary>
 ///   List of Office style sheet extensions associated with the theme.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Theme.OfficeStyleSheetExtensionList))]
 [OpenXmlElement(typeof(DXD.Theme))]
 public OfficeStyleSheetExtensionList? OfficeStyleSheetExtensionList { get => _OfficeStyleSheetExtensionList; set => UpdateField(ref _OfficeStyleSheetExtensionList, value, nameof(OfficeStyleSheetExtensionList)); }

 private OfficeStyleSheetExtensionList? _OfficeStyleSheetExtensionList;
}