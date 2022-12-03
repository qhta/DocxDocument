namespace DocumentModel;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public interface OfficeArtExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<DocumentModel.Drawings.Extension>? Extensions { get ; set; }
  
}
