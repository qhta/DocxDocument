namespace DocumentModel.WebExtensions;


/// <summary>
///   Defines the WebExtensionStoreReference Class.
/// </summary>
public partial class WebExtensionStoreReference
{
  
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   version, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Version { get; set; }
  
  
  /// <summary>
  ///   store, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Store { get; set; }
  
  
  /// <summary>
  ///   storeType, this property is only available in Office 2013 and later.
  /// </summary>
  public String? StoreType { get; set; }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public DMEX.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
