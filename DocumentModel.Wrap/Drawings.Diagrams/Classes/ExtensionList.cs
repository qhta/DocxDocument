namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ExtensionList Class.
/// </summary>
public class ExtensionList: ModelElement
{
  public Collection<Extension>? Extensions { get; set; }
}