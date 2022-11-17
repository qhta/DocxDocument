namespace DocumentModel.Presentation;

public interface IShapeTree // : DocumentFormat.OpenXml.Presentation.GroupShapeType
{
  public DocumentModel.Presentation.INonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  public DocumentModel.Presentation.IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
}
