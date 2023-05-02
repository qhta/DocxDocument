namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the OfficeArtExtensionList Class.
/// </summary>
public class OfficeArtExtensionList: ModelElement
{
  public Collection<Drawings.Extension>? Extensions { get; set; }
}