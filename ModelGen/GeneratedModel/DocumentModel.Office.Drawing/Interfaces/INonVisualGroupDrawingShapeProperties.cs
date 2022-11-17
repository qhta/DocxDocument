namespace DocumentModel.Office.Drawing;

public interface INonVisualGroupDrawingShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IGroupShapeLocks? GroupShapeLocks { get ; set; }

  public INonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList { get ; set; }

}
