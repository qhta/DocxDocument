namespace DocumentModel.Drawings;

/// <summary>
/// Theme.
/// </summary>
public partial interface Theme
{
  /// <summary>
  /// name
  /// </summary>
  public String? Name { get; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? ThemeId { get; set; }
  
  /// <summary>
  /// ThemeElements.
  /// </summary>
  public DocumentModel.Drawings.ThemeElements? ThemeElements { get; set; }
  
  /// <summary>
  /// ObjectDefaults.
  /// </summary>
  public DocumentModel.Drawings.ObjectDefaults? ObjectDefaults { get; set; }
  
  /// <summary>
  /// ExtraColorSchemeList.
  /// </summary>
  public DocumentModel.Drawings.ExtraColorSchemeList? ExtraColorSchemeList { get; set; }
  
  /// <summary>
  /// CustomColorList.
  /// </summary>
  public DocumentModel.Drawings.CustomColorList? CustomColorList { get; set; }
  
  /// <summary>
  /// OfficeStyleSheetExtensionList.
  /// </summary>
  public DocumentModel.Drawings.OfficeStyleSheetExtensionList? OfficeStyleSheetExtensionList { get; set; }
  
}
