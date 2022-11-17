namespace DocumentModel.Office2010.Word.DrawingGroup;

public interface INonVisualGroupDrawingShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IGroupShapeLocks? GroupShapeLocks { get ; set; }
  
  public INonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList { get ; set; }
  
}
