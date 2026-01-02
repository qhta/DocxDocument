namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the OfficeArtExtensionList Class.
/// </summary>
public class OfficeArtExtensionList: ModelElement
{
  public Collection<DocumentModel.Drawings.Extension>? Extensions { get; set; }
}