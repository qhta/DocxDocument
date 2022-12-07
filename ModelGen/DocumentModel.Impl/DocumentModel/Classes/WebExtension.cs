namespace DocumentModel;

/// <summary>
/// Defines the WebExtension Class.
/// </summary>
public class WebExtensionImpl: ModelElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension>, WebExtension
{
  /// <summary>
  /// WebExtensionStoreReference.
  /// </summary>
  public WebExtensionStoreReference? WebExtensionStoreReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// WebExtensionReferenceList.
  /// </summary>
  public WebExtensionReferenceList? WebExtensionReferenceList
  {
    get;
    set;
  }
  
  /// <summary>
  /// WebExtensionPropertyBag.
  /// </summary>
  public WebExtensionPropertyBag? WebExtensionPropertyBag
  {
    get;
    set;
  }
  
  /// <summary>
  /// WebExtensionBindingList.
  /// </summary>
  public WebExtensionBindingList? WebExtensionBindingList
  {
    get;
    set;
  }
  
  /// <summary>
  /// Snapshot.
  /// </summary>
  public Snapshot? Snapshot
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
