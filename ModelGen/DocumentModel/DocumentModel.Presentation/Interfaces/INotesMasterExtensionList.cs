namespace DocumentModel.Presentation;

/// <summary>
/// Defines the NotesMasterExtensionList Class.
/// </summary>
public interface INotesMasterExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<INotesMasterExtension>? NotesMasterExtensions { get ; set; }
  
}
