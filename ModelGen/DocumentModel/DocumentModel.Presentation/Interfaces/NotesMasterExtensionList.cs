namespace DocumentModel.Presentation;

/// <summary>
/// Defines the NotesMasterExtensionList Class.
/// </summary>
public interface NotesMasterExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<NotesMasterExtension>? NotesMasterExtensions { get ; set; }
  
}
