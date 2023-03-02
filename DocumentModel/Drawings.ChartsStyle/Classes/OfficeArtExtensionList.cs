namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///   Defines the OfficeArtExtensionList Class.
/// </summary>
public record OfficeArtExtensionList
{
  public Collection<Extension>? Extensions { get; set; }
}