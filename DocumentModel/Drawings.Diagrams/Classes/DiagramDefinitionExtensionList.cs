namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   List of extensions to the CT_DiagramDefintions type..
/// </summary>
public class DiagramDefinitionExtensionList: ModelElement
{
  public Collection<DiagramDefinitionExtension>? DiagramDefinitionExtensions { get; set; }
}