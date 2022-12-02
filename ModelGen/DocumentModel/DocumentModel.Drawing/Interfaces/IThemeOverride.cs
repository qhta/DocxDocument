namespace DocumentModel.Drawing;

/// <summary>
/// Theme Override.
/// </summary>
public interface IThemeOverride // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Color Scheme.
  /// </summary>
  public IColorScheme? ColorScheme { get ; set; }
  
  /// <summary>
  /// FontScheme.
  /// </summary>
  public IFontScheme? FontScheme { get ; set; }
  
  /// <summary>
  /// FormatScheme.
  /// </summary>
  public IFormatScheme? FormatScheme { get ; set; }
  
}
