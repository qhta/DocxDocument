namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ThemeElements interface.
/// </summary>
public interface ThemeElements: ExtendableElement
{
  /// <summary>
  ///   ColorScheme.
  /// </summary>
  public ColorScheme? ColorScheme { get; set; }
  /// <summary>
  ///   Font Scheme.
  /// </summary>
  public FontScheme? FontScheme { get; set; }
  /// <summary>
  ///   Format Scheme.
  /// </summary>
  public FormatScheme? FormatScheme { get; set; }
}