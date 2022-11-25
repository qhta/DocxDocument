namespace DocumentModel.Drawing;

/// <summary>
/// Theme Override.
/// </summary>
public interface IThemeOverride // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Color Scheme.
  /// </summary>
  public DocumentModel.Drawing.IColorScheme? ColorScheme { get ; set; }
  
  /// <summary>
  /// FontScheme.
  /// </summary>
  public DocumentModel.Drawing.IFontScheme? FontScheme { get ; set; }
  
  /// <summary>
  /// FormatScheme.
  /// </summary>
  public DocumentModel.Drawing.IFormatScheme? FormatScheme { get ; set; }
  
}
