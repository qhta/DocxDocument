namespace DocumentModel.Drawing;

/// <summary>
/// Theme.
/// </summary>
public interface ITheme // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? ThemeId { get ; set; }
  
  /// <summary>
  /// ThemeElements.
  /// </summary>
  public DocumentModel.Drawing.IThemeElements? ThemeElements { get ; set; }
  
  /// <summary>
  /// ObjectDefaults.
  /// </summary>
  public DocumentModel.Drawing.IObjectDefaults? ObjectDefaults { get ; set; }
  
  /// <summary>
  /// ExtraColorSchemeList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtraColorSchemeList { get ; set; }
  
  /// <summary>
  /// CustomColorList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? CustomColorList { get ; set; }
  
  /// <summary>
  /// OfficeStyleSheetExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? OfficeStyleSheetExtensionList { get ; set; }
  
}
