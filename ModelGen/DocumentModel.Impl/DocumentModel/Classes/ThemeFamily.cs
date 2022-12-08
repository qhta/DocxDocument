namespace DocumentModel;

/// <summary>
/// Defines the ThemeFamily Class.
/// </summary>
public class ThemeFamilyImpl: ModelElementImpl, ThemeFamily
{
  public DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// vid, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Vid
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
