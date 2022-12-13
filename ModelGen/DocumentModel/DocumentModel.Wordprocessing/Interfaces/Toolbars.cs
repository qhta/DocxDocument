namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Toolbars Class.
/// </summary>
public interface Toolbars
{
  public Collection<DocumentModel.Wordprocessing.AllocatedCommandManifest>? AllocatedCommandManifests { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ToolbarData>? ToolbarDatas { get ; set; }
  
}
