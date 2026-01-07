namespace DocumentModel.WebExtensions;

/// <summary>
///   Defines the WebExtension Class.
/// </summary>
public interface WebExtension: Extension
{
  /// <summary>
  ///   Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public bool? Fronzen { get; set; }
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   frozen
  /// </summary>
  public bool? Frozen { get; set; }
  /// <summary>
  ///   WebExtensionStoreReference.
  /// </summary>
  public WebExtensionStoreReference? WebExtensionStoreReference { get; set; }
  /// <summary>
  ///   WebExtensionReferenceList.
  /// </summary>
  public WebExtensionReferenceList? WebExtensionReferenceList { get; set; }
  /// <summary>
  ///   WebExtensionPropertyBag.
  /// </summary>
  public WebExtensionPropertyBag? WebExtensionPropertyBag { get; set; }
  /// <summary>
  ///   WebExtensionBindingList.
  /// </summary>
  public WebExtensionBindingList? WebExtensionBindingList { get; set; }
  /// <summary>
  ///   Snapshot.
  /// </summary>
  public Snapshot? Snapshot { get; set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}