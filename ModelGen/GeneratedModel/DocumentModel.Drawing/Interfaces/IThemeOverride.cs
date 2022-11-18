namespace DocumentModel.Drawing;

/// <summary>
/// Theme Override.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IColorScheme))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFontScheme))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFormatScheme))]
public interface IThemeOverride // : DocumentFormat.OpenXml.TypedOpenXmlPartRootElement
{
  /// <summary>
  /// Color Scheme.
  /// </summary>
  public IColorScheme? ColorScheme { get ; set; }
  
  /// <summary>
  /// FontScheme.
  /// </summary>
  public DocumentModel.Drawing.IFontScheme? FontScheme { get ; set; }
  
  /// <summary>
  /// FormatScheme.
  /// </summary>
  public IFormatScheme? FormatScheme { get ; set; }
  
}
