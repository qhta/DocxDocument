namespace DocumentModel.Drawing;

/// <summary>
/// Theme.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IThemeElements))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtraColorSchemeList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ICustomColorList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IObjectDefaults))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IOfficeStyleSheetExtensionList))]
public class Theme: ITheme
{
  /// <summary>
  /// name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public string? ThemeId
  {
    get;
    set;
  }
  
  /// <summary>
  /// ThemeElements.
  /// </summary>
  public IThemeElements? ThemeElements
  {
    get;
    set;
  }
  
  /// <summary>
  /// ObjectDefaults.
  /// </summary>
  public IObjectDefaults? ObjectDefaults
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtraColorSchemeList.
  /// </summary>
  public IExtraColorSchemeList? ExtraColorSchemeList
  {
    get;
    set;
  }
  
  /// <summary>
  /// CustomColorList.
  /// </summary>
  public ICustomColorList? CustomColorList
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeStyleSheetExtensionList.
  /// </summary>
  public IOfficeStyleSheetExtensionList? OfficeStyleSheetExtensionList
  {
    get;
    set;
  }
  
}
