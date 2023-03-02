namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the PtExtensionList Class.
/// </summary>
public record PtExtensionList
{
  public Collection<PtExtension>? PtExtensions { get; set; }
}