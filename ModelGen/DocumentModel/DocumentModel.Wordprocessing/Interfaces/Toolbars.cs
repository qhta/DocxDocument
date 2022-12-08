namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Toolbars Class.
/// </summary>
public interface Toolbars
{
  public Collection<AllocatedCommandManifest>? AllocatedCommandManifests { get ; set; }
  
  public Collection<ToolbarData>? ToolbarDatas { get ; set; }
  
}
