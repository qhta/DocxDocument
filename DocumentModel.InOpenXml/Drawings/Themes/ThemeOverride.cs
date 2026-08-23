namespace DocumentModel.Drawings;

/// <summary>
///   Represents a theme override, allowing customization of color, font, and format schemes for a document theme.
/// </summary>
[OpenXmlType(typeof(DXD.ThemeOverride))]
[DataContract]
[XmlRoot("ThemeOverride", Namespace = "DocumentModel.Drawings")]
public partial class ThemeOverride: ModelElement<DXD.ThemeOverride>
{
  /// <summary>
  ///   Color scheme used for the theme override.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ThemeOverride.ColorScheme))]
  public ColorScheme? ColorScheme
  {
    get => _ColorScheme ??= GetProperty<ColorScheme?>(GetUpdatableElement()?.ColorScheme);
    set => UpdateField(ref _ColorScheme, value, nameof(ColorScheme));
  }

  private ColorScheme? _ColorScheme;

  /// <summary>
  ///   TextFormat scheme used for the theme override.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ThemeOverride.FontScheme))]
  public FontScheme? FontScheme
  {
    get => _FontScheme ??= GetProperty<FontScheme?>(GetUpdatableElement()?.FontScheme);
    set => UpdateField(ref _FontScheme, value, nameof(FontScheme));
  }

  private FontScheme? _FontScheme;

  /// <summary>
  ///   Format scheme used for the theme override.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ThemeOverride.FormatScheme))]
  public FormatScheme? FormatScheme
  {
    get => _FormatScheme ??= GetProperty<FormatScheme?>(GetUpdatableElement()?.FormatScheme);
    set => UpdateField(ref _FormatScheme, value, nameof(FormatScheme));
  }

  private FormatScheme? _FormatScheme;
}