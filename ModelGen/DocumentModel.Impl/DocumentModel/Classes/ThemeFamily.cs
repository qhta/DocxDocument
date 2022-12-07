namespace DocumentModel;

/// <summary>
/// Defines the ThemeFamily Class.
/// </summary>
public class ThemeFamilyImpl: ModelElement<DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily>, ThemeFamily
{
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
