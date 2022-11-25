namespace DocumentModel.Office2013.WebExtension;

/// <summary>
/// Defines the WebExtensionStoreReference Class.
/// </summary>
public interface IWebExtensionStoreReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// version, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Version { get ; set; }
  
  /// <summary>
  /// store, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Store { get ; set; }
  
  /// <summary>
  /// storeType, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? StoreType { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? OfficeArtExtensionList { get ; set; }
  
}
