namespace DocumentModel.Drawing;

/// <summary>
/// List of extensions to the CT_DiagramDefintions type..
/// </summary>
public interface IDiagramDefinitionExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IDiagramDefinitionExtension>? DiagramDefinitionExtensions { get ; set; }
  
}
