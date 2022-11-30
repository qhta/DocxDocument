namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ThemeElements Class.
/// </summary>
public interface IThemeElements // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ColorScheme.
  /// </summary>
  public DocumentModel.Drawing.IColorScheme? ColorScheme { get ; set; }
  
  /// <summary>
  /// Font Scheme.
  /// </summary>
  public DocumentModel.Drawing.IFontScheme? FontScheme { get ; set; }
  
  /// <summary>
  /// Format Scheme.
  /// </summary>
  public DocumentModel.Drawing.IFormatScheme? FormatScheme { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
