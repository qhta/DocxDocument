namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionStoreReference Class.
/// </summary>
public interface IWebExtensionStoreReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// version, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Version { get ; set; }
  
  /// <summary>
  /// store, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Store { get ; set; }
  
  /// <summary>
  /// storeType, this property is only available in Office 2013 and later.
  /// </summary>
  public String? StoreType { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
