namespace DocumentModel;

/// <summary>
///   Defines the ThemeFamily Class.
/// </summary>
public record ThemeFamily
{
  /// <summary>
  ///   name, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Name { get; set; }

  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   vid, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Vid { get; set; }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}