namespace DocumentModel.Drawings.Office.ScriptLink;

/// <summary>
///   Defines the OfficeArtExtensionList Class.
/// </summary>
public interface OfficeArtExtensionList: IModelElement
{
  public Collection<Extension>? Extensions { get; set; }
}