namespace DocumentModel.Drawing;

/// <summary>
/// Defines the OfficeStyleSheetExtension Class.
/// </summary>
public interface IOfficeStyleSheetExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Theme.IThemeFamily? ThemeFamily { get ; set; }
  
}
