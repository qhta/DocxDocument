namespace DocumentModel.WebExtensions;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public interface OfficeArtExtensionList
{
  public Collection<DocumentModel.Drawings.Extension>? Extensions { get ; set; }
  
}
