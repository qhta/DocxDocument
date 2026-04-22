namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class NonVisualGroupDrawingShapeProperties<T> 
{
  public bool ShouldSerializeGroupShapeLocks() => GroupShapeLocks is not null;
  public bool ShouldSerializeNonVisualGroupDrawingShapePropsExtensionList() => NonVisualGroupDrawingShapePropsExtensionList is not null;
}
