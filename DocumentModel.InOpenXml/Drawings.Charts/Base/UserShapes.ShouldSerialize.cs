namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class UserShapes
{
  public bool ShouldSerializeRelativeAnchorSize() => RelativeAnchorSize is not null;
  public bool ShouldSerializeAbsoluteAnchorSize() => AbsoluteAnchorSize is not null;
}
