namespace DocumentModel.Drawings;

/// <summary>
///   Defines the OfficeArtExtensionList interface.
/// </summary>
public interface OfficeArtExtensionList6: IModelElement
{
  public Collection<Extension>? Extensions { get; set; }
}