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
    public FontScheme? FontScheme { get; set; }

    /// <summary>
    ///   Format scheme for the theme.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ThemeElements.FormatScheme))]
    public FormatScheme? FormatScheme { get; set; }

    /// <summary>
    /// List of extensions for the theme elements.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ThemeElements.ExtensionList))]
    public ExtensionList? ExtensionList { get; set; }
}