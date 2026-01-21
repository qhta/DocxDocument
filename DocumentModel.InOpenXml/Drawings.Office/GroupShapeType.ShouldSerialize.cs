namespace DocumentModel.Drawings.Office;

public partial class GroupShapeType
{
  public bool ShouldSerializeGroupShapeNonVisualProperties() => GroupShapeNonVisualProperties is not null;
  public bool ShouldSerializeGroupShapeProperties() => GroupShapeProperties is not null;
}
