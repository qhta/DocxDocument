namespace DocumentModel;

/// <summary>
///   Defines the ThemeFamily Class.
/// </summary>
public interface ThemeFamily
{
  /// <summary>
  ///   name
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   vid
  /// </summary>
  public string? Vid { get; set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}