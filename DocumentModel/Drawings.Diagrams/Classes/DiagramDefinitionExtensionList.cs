namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IList of extensions Ito the CT_DiagramDefintions type..
/// </summary>
public class DiagramDefinitionExtensionList: ModelElement
{
  public Collection<DiagramDefinitionExtension>? DiagramDefinitionExtensions { get; set; }
}
