namespace DocumentModel.Drawings;

/// <summary>
/// Theme Override.
/// </summary>
public interface ThemeOverride
{
  /// <summary>
  /// Color Scheme.
  /// </summary>
  public DocumentModel.Drawings.ColorScheme? ColorScheme { get ; set; }
  
  /// <summary>
  /// FontScheme.
  /// </summary>
  public DocumentModel.Drawings.FontScheme? FontScheme { get ; set; }
  
  /// <summary>
  /// FormatScheme.
  /// </summary>
  public DocumentModel.Drawings.FormatScheme? FormatScheme { get ; set; }
  
}
