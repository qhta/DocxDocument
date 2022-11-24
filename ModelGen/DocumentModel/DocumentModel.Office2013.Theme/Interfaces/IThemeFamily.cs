namespace DocumentModel.Office2013.Theme;

/// <summary>
/// Defines the ThemeFamily Class.
/// </summary>
public interface IThemeFamily // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// vid, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Vid { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
