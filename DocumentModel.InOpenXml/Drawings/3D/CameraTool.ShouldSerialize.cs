namespace DocumentModel.Drawings;

public partial class CameraTool
{
  public bool ShouldSerializeCellRange() => CellRange is not null;
  public bool ShouldSerializeShapeId() => ShapeId is not null;
}
