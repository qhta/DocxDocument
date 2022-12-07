namespace DocumentModel.Drawings;

/// <summary>
/// Theme Override.
/// </summary>
public interface ThemeOverride
{
  /// <summary>
  /// Color Scheme.
  /// </summary>
  public ColorScheme? ColorScheme { get ; set; }
  
  /// <summary>
  /// FontScheme.
  /// </summary>
  public FontScheme? FontScheme { get ; set; }
  
  /// <summary>
  /// FormatScheme.
  /// </summary>
  public FormatScheme? FormatScheme { get ; set; }
  
}
