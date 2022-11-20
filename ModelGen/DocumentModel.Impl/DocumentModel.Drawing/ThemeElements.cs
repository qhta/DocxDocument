namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ThemeElements Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IColorScheme))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFontScheme))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFormatScheme))]
public class ThemeElements: IThemeElements
{
  /// <summary>
  /// ColorScheme.
  /// </summary>
  public IColorScheme? ColorScheme
  {
    get;
    set;
  }
  
  /// <summary>
  /// Font Scheme.
  /// </summary>
  public DocumentModel.Drawing.IFontScheme? FontScheme
  {
    get;
    set;
  }
  
  /// <summary>
  /// Format Scheme.
  /// </summary>
  public IFormatScheme? FormatScheme
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
