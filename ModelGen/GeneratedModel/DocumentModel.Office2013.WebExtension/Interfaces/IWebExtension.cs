namespace DocumentModel.Office2013.WebExtension;

/// <summary>
/// Defines the WebExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.WebExtension.ISnapshot))]
[ChildElementInfo(typeof(DocumentModel.Office2013.WebExtension.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2013.WebExtension.IWebExtensionBindingList))]
[ChildElementInfo(typeof(DocumentModel.Office2013.WebExtension.IWebExtensionPropertyBag))]
[ChildElementInfo(typeof(DocumentModel.Office2013.WebExtension.IWebExtensionStoreReference))]
[ChildElementInfo(typeof(DocumentModel.Office2013.WebExtension.IWebExtensionReferenceList))]
public interface IWebExtension // : DocumentFormat.OpenXml.TypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  [Obsolete("Please use the property 'Frozen' as this property will be removed in a future version")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public bool? Fronzen { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// frozen, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? Frozen { get ; set; }
  
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
  public DocumentModel.Office2013.WebExtension.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
