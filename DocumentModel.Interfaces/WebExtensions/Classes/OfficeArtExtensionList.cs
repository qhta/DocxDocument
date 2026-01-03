namespace DocumentModel.WebExtensions;

/// <summary>
///   Defines the OfficeArtExtensionList Class.
/// </summary>
public interface OfficeArtExtensionList: IModelElement
{
  public Collection<Drawings.Extension>? Extensions { get; set; }
}