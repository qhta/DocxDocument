namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Point2DType
{
  public bool ShouldSerializeX() => X is not null;
  public bool ShouldSerializeY() => Y is not null;
}
