namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// List of extensions to the CT_DiagramDefintions type..
/// </summary>
public interface IDiagramDefinitionExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Diagrams.IDiagramDefinitionExtension>? DiagramDefinitionExtensions { get ; set; }
  
}
