namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DataModelExtension Class.
/// </summary>
public interface IDataModelExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IDataModelExtensionBlock? DataModelExtensionBlock { get ; set; }
  
  public Boolean? RecolorImages { get ; set; }
  
}
