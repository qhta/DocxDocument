namespace DocumentModel.Drawings;

public partial class Point2DType
{
  public bool ShouldSerializeX() => X is not null;
  public bool ShouldSerializeY() => Y is not null;
}
