namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   List of extensions to the CT_DiagramDefintions type..
/// </summary>
public interface DiagramDefinitionExtensionList: IModelElement
{
  public Collection<DiagramDefinitionExtension>? DiagramDefinitionExtensions { get; set; }
}