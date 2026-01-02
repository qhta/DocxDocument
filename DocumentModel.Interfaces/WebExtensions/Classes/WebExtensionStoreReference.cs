namespace DocumentModel.WebExtensions;

/// <summary>
///   Defines the WebExtensionStoreReference Class.
/// </summary>
public class WebExtensionStoreReference: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   version, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Version { get; set; }
  /// <summary>
  ///   store, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Store { get; set; }
  /// <summary>
  ///   storeType, this property is only available in Office 2013 and later.
  /// </summary>
  public string? StoreType { get; set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}