namespace DocumentModel.Drawings;

/// <summary>
///   Theme Override.
/// </summary>
public class ThemeOverride: ModelElement
{
  /// <summary>
  ///   Color Scheme.
  /// </summary>
  public ColorScheme? ColorScheme { get; set; }

  /// <summary>
  ///   FontScheme.
  /// </summary>
  public FontScheme? FontScheme { get; set; }

  /// <summary>
  ///   FormatScheme.
  /// </summary>
  public FormatScheme? FormatScheme { get; set; }
}