namespace DocumentModel.Drawings.Office;
#pragma warning disable CS1591
public partial class GroupShapeNonVisualProperties
{
  public bool ShouldSerializeNonVisualDrawingProperties() => NonVisualDrawingProperties is not null;
  public bool ShouldSerializeNonVisualGroupDrawingShapeProperties() => NonVisualGroupDrawingShapeProperties is not null;
}
