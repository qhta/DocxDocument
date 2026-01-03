namespace DocumentModel.WebExtensions.UI;

/// <summary>
///   Defines the OfficeArtExtensionList Class.
/// </summary>
public interface OfficeArtExtensionList: IModelElement
{
  public Collection<Drawings.Extension>? Extensions { get; set; }
}