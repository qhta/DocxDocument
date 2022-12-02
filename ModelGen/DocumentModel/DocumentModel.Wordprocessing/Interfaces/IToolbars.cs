namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Toolbars Class.
/// </summary>
public interface IToolbars // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IAllocatedCommandManifest>? AllocatedCommandManifests { get ; set; }
  
  public Collection<IToolbarData>? ToolbarDatas { get ; set; }
  
}
