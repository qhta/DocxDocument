namespace DocumentModel.Drawing.Spreadsheet;

public interface INonVisualGroupShapeDrawingProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IGroupShapeLocks? GroupShapeLocks { get ; set; }

  public INonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList { get ; set; }

}
