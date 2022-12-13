namespace DocumentModel;

/// <summary>
/// Defines the WebExtension Class.
/// </summary>
public interface WebExtension
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public Boolean? Fronzen { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// frozen, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Frozen { get ; set; }
  
  /// <summary>
  /// WebExtensionStoreReference.
  /// </summary>
  public DocumentModel.WebExtensionStoreReference? WebExtensionStoreReference { get ; set; }
  
  /// <summary>
  /// WebExtensionReferenceList.
  /// </summary>
  public DocumentModel.WebExtensionReferenceList? WebExtensionReferenceList { get ; set; }
  
  /// <summary>
  /// WebExtensionPropertyBag.
  /// </summary>
  public DocumentModel.WebExtensionPropertyBag? WebExtensionPropertyBag { get ; set; }
  
  /// <summary>
  /// WebExtensionBindingList.
  /// </summary>
  public DocumentModel.WebExtensionBindingList? WebExtensionBindingList { get ; set; }
  
  /// <summary>
  /// Snapshot.
  /// </summary>
  public DocumentModel.Snapshot? Snapshot { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
