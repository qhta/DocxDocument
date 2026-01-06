namespace DocumentModel.Drawings;

/// <summary>
///   Defines the OfficeArtExtensionList interface.
/// </summary>
public interface OfficeArtExtensionList
{
  public Collection<Extension>? Extensions { get; set; }
}