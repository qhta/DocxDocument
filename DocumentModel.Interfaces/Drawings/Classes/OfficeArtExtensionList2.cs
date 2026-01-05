namespace DocumentModel.Drawings;

/// <summary>
///   Defines the OfficeArtExtensionList interface.
/// </summary>
public interface OfficeArtExtensionList2:
{
  public Collection<Extension>? Extensions { get; set; }
}