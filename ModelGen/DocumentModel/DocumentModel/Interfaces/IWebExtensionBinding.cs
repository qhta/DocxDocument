namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionBinding Class.
/// </summary>
public interface IWebExtensionBinding // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// type, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Type { get ; set; }
  
  /// <summary>
  /// appref, this property is only available in Office 2013 and later.
  /// </summary>
  public String? AppReference { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
