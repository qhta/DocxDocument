namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DataModelExtensionList Class.
/// </summary>
public interface IDataModelExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IDataModelExtension>? DataModelExtensions { get ; set; }
  
}
