namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommandManifest Class.
/// </summary>
public interface IAllocatedCommandManifest // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IAcceleratorKeymapType>? AllocatedCommandManifestEntries { get ; set; }
  
}
