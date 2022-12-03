namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Toolbars Class.
/// </summary>
public interface Toolbars // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<AllocatedCommandManifest>? AllocatedCommandManifests { get ; set; }
  
  public Collection<ToolbarData>? ToolbarDatas { get ; set; }
  
}
