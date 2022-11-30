namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the AllocatedCommandManifest Class.
/// </summary>
public interface IAllocatedCommandManifest // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office.Word.IAcceleratorKeymapType>? AllocatedCommandManifestEntries { get ; set; }
  
}
