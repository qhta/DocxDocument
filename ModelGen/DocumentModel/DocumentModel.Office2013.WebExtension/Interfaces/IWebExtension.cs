namespace DocumentModel.Office2013.WebExtension;

/// <summary>
/// Defines the WebExtension Class.
/// </summary>
public interface IWebExtension // : DocumentModel.ITypedOpenXmlPartRootElement
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
  public IWebExtensionStoreReference? WebExtensionStoreReference { get ; set; }
  
  /// <summary>
  /// WebExtensionReferenceList.
  /// </summary>
  public IWebExtensionReferenceList? WebExtensionReferenceList { get ; set; }
  
  /// <summary>
  /// WebExtensionPropertyBag.
  /// </summary>
  public IWebExtensionPropertyBag? WebExtensionPropertyBag { get ; set; }
  
  /// <summary>
  /// WebExtensionBindingList.
  /// </summary>
  public IWebExtensionBindingList? WebExtensionBindingList { get ; set; }
  
  /// <summary>
  /// Snapshot.
  /// </summary>
  public ISnapshot? Snapshot { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
  /// <summary>
  /// Gets the WebExtensionPart associated with this element.
  /// </summary>
  public WebExtensionPart? WebExtensionPart { get ; set; }
  
}
