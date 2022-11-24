namespace DocumentModel.Drawing;

/// <summary>
/// Theme.
/// </summary>
public interface ITheme // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? ThemeId { get ; set; }
  
  /// <summary>
  /// ThemeElements.
  /// </summary>
  public IThemeElements? ThemeElements { get ; set; }
  
  /// <summary>
  /// ObjectDefaults.
  /// </summary>
  public IObjectDefaults? ObjectDefaults { get ; set; }
  
  /// <summary>
  /// ExtraColorSchemeList.
  /// </summary>
  public IExtraColorSchemeList? ExtraColorSchemeList { get ; set; }
  
  /// <summary>
  /// CustomColorList.
  /// </summary>
  public ICustomColorList? CustomColorList { get ; set; }
  
  /// <summary>
  /// OfficeStyleSheetExtensionList.
  /// </summary>
  public IOfficeStyleSheetExtensionList? OfficeStyleSheetExtensionList { get ; set; }
  
  /// <summary>
  /// Gets the ThemePart associated with this element.
  /// </summary>
  public ThemePart? ThemePart { get ; set; }
  
}
