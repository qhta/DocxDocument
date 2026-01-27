namespace DocumentModel.Drawings.Office;

#pragma warning disable CS1591

public partial class GroupShapeType
{
  public bool ShouldSerializeGroupShapeNonVisualProperties() => GroupShapeNonVisualProperties is not null;
  public bool ShouldSerializeGroupShapeProperties() => GroupShapeProperties is not null;
}
