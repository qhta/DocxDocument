namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the AllocatedCommandManifest Class.
/// </summary>
public record AllocatedCommandManifest
{
  public Collection<AcceleratorKeymapType>? AllocatedCommandManifestEntries { get; set; }
}