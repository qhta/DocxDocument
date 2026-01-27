namespace DocumentModel.Drawings;

public partial class NonVisualGroupDrawingShapeProperties<T>
{
  public bool ShouldSerializeGroupShapeLocks() => GroupShapeLocks is not null;
  public bool ShouldSerializeNonVisualGroupDrawingShapePropsExtensionList() => NonVisualGroupDrawingShapePropsExtensionList is not null;
}
