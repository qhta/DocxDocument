namespace DocumentModel.Presentation;

/// <summary>
/// Shape Tree.
/// </summary>
public interface IShapeTree // : DocumentModel.Presentation.IGroupShapeType
{
  public DocumentModel.Presentation.INonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  public DocumentModel.Presentation.IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public DocumentModel.Presentation.IShape? Shape { get ; set; }
  
  public DocumentModel.Presentation.IGroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Presentation.IGraphicFrame? GraphicFrame { get ; set; }
  
  public DocumentModel.Presentation.IConnectionShape? ConnectionShape { get ; set; }
  
  public DocumentModel.Presentation.IPicture? Picture { get ; set; }
  
  public DocumentModel.Presentation.IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
