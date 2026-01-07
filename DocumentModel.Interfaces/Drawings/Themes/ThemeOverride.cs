namespace DocumentModel.Drawings;

/// <summary>
///   Represents a theme override, allowing customization of color, font, and format schemes for a document theme.
/// </summary>
public interface ThemeOverride
{
  /// <summary>
  ///   Color scheme used for the theme override.
  /// </summary>
  public ColorScheme? ColorScheme { get; set; }

  /// <summary>
  ///   Font scheme used for the theme override.
  /// </summary>
  public FontScheme? FontScheme { get; set; }

  /// <summary>
  ///   Format scheme used for the theme override.
  /// </summary>
  public FormatScheme? FormatScheme { get; set; }
}