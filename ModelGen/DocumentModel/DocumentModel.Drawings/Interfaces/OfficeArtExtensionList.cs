namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public interface OfficeArtExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Extension>? Extensions { get ; set; }
  
}
