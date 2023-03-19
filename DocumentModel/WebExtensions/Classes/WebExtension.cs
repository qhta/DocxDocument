namespace DocumentModel.WebExtensions;

/// <summary>
///   Defines the WebExtension Class.
/// </summary>
public class WebExtension: ModelElement
{
  /// <summary>
  ///   Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public Boolean? Fronzen { get; set; }

  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   frozen, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Frozen { get; set; }

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