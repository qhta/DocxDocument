namespace DocumentModel.WebExtensions;


/// <summary>
///   Defines the WebExtension Class.
/// </summary>
public partial class WebExtension
{
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
  public DMEX.WebExtensionStoreReference? WebExtensionStoreReference { get; set; }
  
  
  /// <summary>
  ///   WebExtensionReferenceList.
  /// </summary>
  public DMEX.WebExtensionReferenceList? WebExtensionReferenceList { get; set; }
  
  
  /// <summary>
  ///   WebExtensionPropertyBag.
  /// </summary>
  public DMEX.WebExtensionPropertyBag? WebExtensionPropertyBag { get; set; }
  
  
  /// <summary>
  ///   WebExtensionBindingList.
  /// </summary>
  public DMEX.WebExtensionBindingList? WebExtensionBindingList { get; set; }
  
  
  /// <summary>
  ///   Snapshot.
  /// </summary>
  public DMEX.Snapshot? Snapshot { get; set; }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public DMEX.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
