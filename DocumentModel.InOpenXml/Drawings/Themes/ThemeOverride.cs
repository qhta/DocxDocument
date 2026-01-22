namespace DocumentModel.Drawings;
/// <summary>
///   Represents a theme override, allowing customization of color, font, and format schemes for a document theme.
/// </summary>
[OpenXmlType(typeof(DXD.ThemeOverride))]
/// <summary>
///   Represents a theme override, allowing customization of color, font, and format schemes for a document theme.
/// </summary>
public partial class ThemeOverride : ModelElement<DXD.ThemeOverride>
{
    /// <summary>
    ///   Color scheme used for the theme override.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ThemeOverride.ColorScheme))]
    public ColorScheme? ColorScheme { get => _ColorScheme; set => UpdateField(ref _ColorScheme, value, nameof(ColorScheme)); }

    private ColorScheme? _ColorScheme;
    /// <summary>
    ///   Font scheme used for the theme override.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ThemeOverride.FontScheme))]
    public FontScheme? FontScheme { get; set; }

    /// <summary>
    ///   Format scheme used for the theme override.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ThemeOverride.FormatScheme))]
    public FormatScheme? FormatScheme { get; set; }
}