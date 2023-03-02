namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   List of extensions to the CT_DiagramDefintions type..
/// </summary>
public record DiagramDefinitionExtensionList
{
  public Collection<DiagramDefinitionExtension>? DiagramDefinitionExtensions { get; set; }
}