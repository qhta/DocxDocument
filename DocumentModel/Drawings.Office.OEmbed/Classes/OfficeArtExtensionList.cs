namespace DocumentModel.Drawings.Office.OEmbed;

/// <summary>
///   Defines the OfficeArtExtensionList Class.
/// </summary>
public record OfficeArtExtensionList
{
  public Collection<Extension>? Extensions { get; set; }
}