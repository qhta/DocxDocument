namespace DocumentModel.Drawings;
/// <summary>
///   Represents the main elements of a theme, including color scheme, font scheme, and format scheme.
/// </summary>
[OpenXmlType(typeof(DXD.ThemeElements))]
/// <summary>
///   Represents the main elements of a theme, including color scheme, font scheme, and format scheme.
/// </summary>
public partial class ThemeElements : ModelElement<DXD.ThemeElements>, IExtendableElement
{
    /// <summary>
    ///   Color scheme for the theme.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ThemeElements.ColorScheme))]
    public ColorScheme? ColorScheme { get => _ColorScheme; set => UpdateField(ref _ColorScheme, value, nameof(ColorScheme)); }

    private ColorScheme? _ColorScheme;
    /// <summary>
    ///   Font scheme for the theme.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ThemeElements.FontScheme))]
    public FontScheme? FontScheme { get => _FontScheme; set => UpdateField(ref _FontScheme, value, nameof(FontScheme)); }

    private FontScheme? _FontScheme;
    /// <summary>
    ///   Format scheme for the theme.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ThemeElements.FormatScheme))]
    public FormatScheme? FormatScheme { get => _FormatScheme; set => UpdateField(ref _FormatScheme, value, nameof(FormatScheme)); }

    private FormatScheme? _FormatScheme;
    /// <summary>
    /// List of extensions for the theme elements.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ThemeElements.ExtensionList))]
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
}