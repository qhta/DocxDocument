namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommandManifest Class.
/// </summary>
public interface AllocatedCommandManifest // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<AcceleratorKeymapType>? AllocatedCommandManifestEntries { get ; set; }
  
}
