namespace DocumentModel.Drawings.Office;

/// <summary>
///   Defines the OfficeArtExtensionList Class.
/// </summary>
public class OfficeArtExtensionList: ModelElement
{
  public Collection<Extension>? Extensions { get; set; }
}