namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the OfficeArtExtensionList Class.
/// </summary>
public interface OfficeArtExtensionList: IModelElement
{
  public Collection<DocumentModel.Drawings.Extension>? Extensions { get; set; }
}