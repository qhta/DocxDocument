namespace DocumentModel.WebExtensions;

/// <summary>
/// Defines the WebExtension Class.
/// </summary>
public partial interface WebExtension
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public Boolean? Fronzen { get; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// frozen, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Frozen { get; set; }
  
  /// <summary>
  /// WebExtensionStoreReference.
  /// </summary>
  public DocumentModel.WebExtensions.WebExtensionStoreReference? WebExtensionStoreReference { get; set; }
  
  /// <summary>
  /// WebExtensionReferenceList.
  /// </summary>
  public DocumentModel.WebExtensions.WebExtensionReferenceList? WebExtensionReferenceList { get; set; }
  
  /// <summary>
  /// WebExtensionPropertyBag.
  /// </summary>
  public DocumentModel.WebExtensions.WebExtensionPropertyBag? WebExtensionPropertyBag { get; set; }
  
  /// <summary>
  /// WebExtensionBindingList.
  /// </summary>
  public DocumentModel.WebExtensions.WebExtensionBindingList? WebExtensionBindingList { get; set; }
  
  /// <summary>
  /// Snapshot.
  /// </summary>
  public DocumentModel.WebExtensions.Snapshot? Snapshot { get; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.WebExtensions.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
  /// <summary>
  /// Gets the WebExtensionPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.WebExtensionPart? WebExtensionPart { get; set; }
  
}
