namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class CameraTool
{
  public bool ShouldSerializeCellRange() => CellRange is not null;
  public bool ShouldSerializeShapeId() => ShapeId is not null;
}
