namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PtExtensionList Class.
/// </summary>
public class PtExtensionList: ModelElement
{
  public Collection<PtExtension>? PtExtensions { get; set; }
}