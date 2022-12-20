namespace DocumentModel.Wordprocessing.DrawingShape;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public partial interface OfficeArtExtensionList
{
  public Collection<DocumentModel.Drawings.Extension>? Extensions { get; set; }
  
}
