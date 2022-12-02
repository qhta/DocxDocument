namespace DocumentModel;

/// <summary>
/// Defines the WebExtension Class.
/// </summary>
public interface IWebExtension // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public System.Boolean? Fronzen { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// frozen, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? Frozen { get ; set; }
  
  /// <summary>
  /// WebExtensionStoreReference.
  /// </summary>
  public DocumentModel.IWebExtensionStoreReference? WebExtensionStoreReference { get ; set; }
  
  /// <summary>
  /// WebExtensionReferenceList.
  /// </summary>
  public DocumentModel.IWebExtensionReferenceList? WebExtensionReferenceList { get ; set; }
  
  /// <summary>
  /// WebExtensionPropertyBag.
  /// </summary>
  public DocumentModel.IWebExtensionPropertyBag? WebExtensionPropertyBag { get ; set; }
  
  /// <summary>
  /// WebExtensionBindingList.
  /// </summary>
  public DocumentModel.IWebExtensionBindingList? WebExtensionBindingList { get ; set; }
  
  /// <summary>
  /// Snapshot.
  /// </summary>
  public DocumentModel.ISnapshot? Snapshot { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
