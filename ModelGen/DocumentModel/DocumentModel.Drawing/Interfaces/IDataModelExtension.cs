namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DataModelExtension Class.
/// </summary>
public interface IDataModelExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IDataModelExtensionBlock? DataModelExtensionBlock { get ; set; }
  
  public System.Boolean? RecolorImages { get ; set; }
  
}
