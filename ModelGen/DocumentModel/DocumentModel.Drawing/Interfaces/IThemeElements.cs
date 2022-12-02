namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ThemeElements Class.
/// </summary>
public interface IThemeElements // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ColorScheme.
  /// </summary>
  public IColorScheme? ColorScheme { get ; set; }
  
  /// <summary>
  /// Font Scheme.
  /// </summary>
  public IFontScheme? FontScheme { get ; set; }
  
  /// <summary>
  /// Format Scheme.
  /// </summary>
  public IFormatScheme? FormatScheme { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
