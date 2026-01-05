namespace DocumentModel.WebExtensions;

/// <summary>
///   Defines the WebExtensionBinding Class.
/// </summary>
public interface WebExtensionBinding:
{
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   type
  /// </summary>
  public string? Type { get; set; }
  /// <summary>
  ///   appref
  /// </summary>
  public string? AppReference { get; set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}