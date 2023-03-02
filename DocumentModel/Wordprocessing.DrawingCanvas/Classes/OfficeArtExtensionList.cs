namespace DocumentModel.Wordprocessing.DrawingCanvas;

/// <summary>
///   Defines the OfficeArtExtensionList Class.
/// </summary>
public record OfficeArtExtensionList
{
  public Collection<DocumentModel.Drawings.Extension>? Extensions { get; set; }
}