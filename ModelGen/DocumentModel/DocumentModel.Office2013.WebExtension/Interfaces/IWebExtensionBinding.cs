namespace DocumentModel.Office2013.WebExtension;

/// <summary>
/// Defines the WebExtensionBinding Class.
/// </summary>
public interface IWebExtensionBinding // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// type, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Type { get ; set; }
  
  /// <summary>
  /// appref, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? AppReference { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2013.WebExtension.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
