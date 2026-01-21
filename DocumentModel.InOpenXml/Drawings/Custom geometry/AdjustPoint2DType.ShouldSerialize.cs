namespace DocumentModel.Drawings;

public partial class AdjustPoint2DType
{
  public bool ShouldSerializeX() => X is not null;
  public bool ShouldSerializeY() => Y is not null;
}
