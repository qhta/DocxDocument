namespace DocumentModel;

/// <summary>
///   Defines the ThemeFamily Class.
/// </summary>
public interface ThemeFamily: IModelElement
{
  /// <summary>
  ///   name, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   vid, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Vid { get; set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}