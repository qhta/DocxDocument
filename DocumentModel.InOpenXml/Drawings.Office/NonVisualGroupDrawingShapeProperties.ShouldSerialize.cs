namespace DocumentModel.Drawings.Office;

public partial class NonVisualGroupDrawingShapeProperties
{
  public bool ShouldSerializeGroupShapeLocks() => GroupShapeLocks is not null;
  public bool ShouldSerializeNonVisualGroupDrawingShapePropsExtensionList() => NonVisualGroupDrawingShapePropsExtensionList is not null;
}
