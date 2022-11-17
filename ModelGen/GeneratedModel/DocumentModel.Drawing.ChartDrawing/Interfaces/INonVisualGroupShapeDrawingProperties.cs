namespace DocumentModel.Drawing.ChartDrawing;

public interface INonVisualGroupShapeDrawingProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IGroupShapeLocks? GroupShapeLocks { get ; set; }
  
  public INonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList { get ; set; }
  
}
