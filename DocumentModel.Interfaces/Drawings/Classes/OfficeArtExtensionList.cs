namespace DocumentModel.Drawings;

/// <summary>
///   Defines the OfficeArtExtensionList interface.
/// </summary>
public interface OfficeArtExtensionList: IModelElement
{
  public Collection<Extension>? Extensions { get; set; }
}