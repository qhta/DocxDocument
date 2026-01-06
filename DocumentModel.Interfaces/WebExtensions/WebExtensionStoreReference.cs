namespace DocumentModel.WebExtensions;

/// <summary>
///   Defines the WebExtensionStoreReference Class.
/// </summary>
public interface WebExtensionStoreReference
{
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   version
  /// </summary>
  public string? Version { get; set; }
  /// <summary>
  ///   store
  /// </summary>
  public string? Store { get; set; }
  /// <summary>
  ///   storeType
  /// </summary>
  public string? StoreType { get; set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}