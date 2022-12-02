namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommandManifest Class.
/// </summary>
public interface IAllocatedCommandManifest // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IAcceleratorKeymapType>? AllocatedCommandManifestEntries { get ; set; }
  
}
