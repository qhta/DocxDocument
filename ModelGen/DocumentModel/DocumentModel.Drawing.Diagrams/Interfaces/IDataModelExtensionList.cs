namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Defines the DataModelExtensionList Class.
/// </summary>
public interface IDataModelExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IDataModelExtension>? DataModelExtensions { get ; set; }
  
}
