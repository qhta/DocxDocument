namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommandManifest Class.
/// </summary>
public interface AllocatedCommandManifest
{
  public Collection<AcceleratorKeymapType>? AllocatedCommandManifestEntries { get ; set; }
  
}
