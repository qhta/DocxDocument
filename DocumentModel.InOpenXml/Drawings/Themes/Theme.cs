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
    ///   Name of the theme.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Theme.Name))]
    public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

    private string? _Name;
    /// <summary>
    ///   Identifier for the theme.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Theme.ThemeId))]
    public string? ThemeId { get; set; }

    /// <summary>
    ///   Elements that define the theme's appearance.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Theme.ThemeElements))]
    public ThemeElements? ThemeElements { get; set; }

    /// <summary>
    ///   Default formatting for objects in the theme.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Theme.ObjectDefaults))]
    public ObjectDefaults? ObjectDefaults { get; set; }

    /// <summary>
    ///   List of extra color schemes associated with the theme.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Theme.ExtraColorSchemeList))]
    public ExtraColorSchemeList? ExtraColorSchemeList { get; set; }

    /// <summary>
    ///   List of custom colors defined for the theme.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Theme.CustomColorList))]
    public CustomColorList? CustomColorList { get; set; }

    /// <summary>
    ///   List of Office style sheet extensions associated with the theme.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Theme.OfficeStyleSheetExtensionList))]
    public OfficeStyleSheetExtensionList? OfficeStyleSheetExtensionList { get; set; }
}