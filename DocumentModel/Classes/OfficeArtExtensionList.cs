namespace DocumentModel;

/// <summary>
///   Defines the OfficeArtExtensionList Class.
/// </summary>
public record OfficeArtExtensionList
{
  public Collection<Drawings.Extension>? Extensions { get; set; }
}