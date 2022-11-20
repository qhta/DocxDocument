namespace DocumentModel.Office2013.Theme;

/// <summary>
/// Defines the ThemeFamily Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Theme.IOfficeArtExtensionList))]
public class ThemeFamily: IThemeFamily
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// vid, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Vid
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2013.Theme.IOfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
