namespace DocumentModel.WebExtensions;

/// <summary>
///   Defines the OfficeArtExtensionList Class.
/// </summary>
public class OfficeArtExtensionList: ModelElement
{
  public Collection<Drawings.Extension>? Extensions { get; set; }
}