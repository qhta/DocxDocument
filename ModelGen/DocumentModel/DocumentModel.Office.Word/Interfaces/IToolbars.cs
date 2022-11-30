namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the Toolbars Class.
/// </summary>
public interface IToolbars // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office.Word.IAllocatedCommandManifest>? AllocatedCommandManifests { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Office.Word.IToolbarData>? ToolbarDatas { get ; set; }
  
}
