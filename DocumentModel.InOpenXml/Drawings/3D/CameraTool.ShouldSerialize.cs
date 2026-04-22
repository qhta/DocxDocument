namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class CameraTool
{
  public bool ShouldSerializeCellRange() => !String.IsNullOrEmpty(CellRange);
  public bool ShouldSerializeShapeId() => !String.IsNullOrEmpty(ShapeId);
}
