namespace DocumentModel.Drawings.Office;

public partial class GroupShapeNonVisualProperties
{
  public bool ShouldSerializeNonVisualDrawingProperties() => NonVisualDrawingProperties is not null;
  public bool ShouldSerializeNonVisualGroupDrawingShapeProperties() => NonVisualGroupDrawingShapeProperties is not null;
}
