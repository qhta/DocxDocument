namespace DocumentModel.Drawings.ChartDrawing;

#pragma warning disable CS1591

public partial class NonVisualGroupShapeDrawingProperties
{
  public bool ShouldSerializeGroupShapeLocks() => GroupShapeLocks is not null;
  public bool ShouldSerializeNonVisualGroupDrawingShapePropsExtensionList() => NonVisualGroupDrawingShapePropsExtensionList is not null;
}
