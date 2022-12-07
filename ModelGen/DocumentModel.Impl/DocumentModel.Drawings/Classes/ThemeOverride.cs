namespace DocumentModel.Drawings;

/// <summary>
/// Theme Override.
/// </summary>
public class ThemeOverrideImpl: ModelElement<DocumentFormat.OpenXml.Drawing.ThemeOverride>, ThemeOverride
{
  /// <summary>
  /// Color Scheme.
  /// </summary>
  public ColorScheme? ColorScheme
  {
    get;
    set;
  }
  
  /// <summary>
  /// FontScheme.
  /// </summary>
  public FontScheme? FontScheme
  {
    get;
    set;
  }
  
  /// <summary>
  /// FormatScheme.
  /// </summary>
  public FormatScheme? FormatScheme
  {
    get;
    set;
  }
  
}
