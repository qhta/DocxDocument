namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Toolbars Class.
/// </summary>
public interface IToolbars // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IAllocatedCommandManifest>? AllocatedCommandManifests { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IToolbarData>? ToolbarDatas { get ; set; }
  
}
