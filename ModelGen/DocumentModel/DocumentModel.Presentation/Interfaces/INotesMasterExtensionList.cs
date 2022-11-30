namespace DocumentModel.Presentation;

/// <summary>
/// Defines the NotesMasterExtensionList Class.
/// </summary>
public interface INotesMasterExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.INotesMasterExtension>? NotesMasterExtensions { get ; set; }
  
}
