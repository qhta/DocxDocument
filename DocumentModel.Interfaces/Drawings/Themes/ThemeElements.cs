namespace DocumentModel.Drawings;

/// <summary>
///   Represents the main elements of a theme, including color scheme, font scheme, and format scheme.
/// </summary>
public interface ThemeElements : ExtendableElement
{
  /// <summary>
  ///   Color scheme for the theme.
  /// </summary>
  public ColorScheme? ColorScheme { get; set; }

  /// <summary>
  ///   Font scheme for the theme.
  /// </summary>
  public FontScheme? FontScheme { get; set; }

  /// <summary>
  ///   Format scheme for the theme.
  /// </summary>
  public FormatScheme? FormatScheme { get; set; }
}