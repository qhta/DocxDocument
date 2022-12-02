namespace DocumentModel.Drawing;

/// <summary>
/// List of extensions to the CT_DiagramDefintions type..
/// </summary>
public interface IDiagramDefinitionExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IDiagramDefinitionExtension>? DiagramDefinitionExtensions { get ; set; }
  
}
