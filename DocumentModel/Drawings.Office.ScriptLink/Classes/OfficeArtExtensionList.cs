namespace DocumentModel.Drawings.Office.ScriptLink;

/// <summary>
///   Defines the OfficeArtExtensionList Class.
/// </summary>
public record OfficeArtExtensionList
{
  public Collection<Extension>? Extensions { get; set; }
}