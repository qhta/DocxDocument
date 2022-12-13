namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommandManifest Class.
/// </summary>
public interface AllocatedCommandManifest
{
  public Collection<DocumentModel.Wordprocessing.AcceleratorKeymapType>? AllocatedCommandManifestEntries { get ; set; }
  
}
