namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Toolbars Class.
/// </summary>
public partial interface Toolbars
{
  public Collection<DocumentModel.Wordprocessing.AllocatedCommandManifest>? AllocatedCommandManifests { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.ToolbarData>? ToolbarDatas { get; set; }
  
}
