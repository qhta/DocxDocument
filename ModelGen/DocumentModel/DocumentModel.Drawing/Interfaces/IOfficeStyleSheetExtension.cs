namespace DocumentModel.Drawing;

/// <summary>
/// Defines the OfficeStyleSheetExtension Class.
/// </summary>
public interface IOfficeStyleSheetExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.IThemeFamily? ThemeFamily { get ; set; }
  
}
