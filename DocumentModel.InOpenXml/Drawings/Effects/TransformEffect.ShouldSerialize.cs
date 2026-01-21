namespace DocumentModel.Drawings;

public partial class TransformEffect
{
  public bool ShouldSerializeHorizontalRatio() => HorizontalRatio is not null;
  public bool ShouldSerializeVerticalRatio() => VerticalRatio is not null;
  public bool ShouldSerializeHorizontalSkew() => HorizontalSkew is not null;
  public bool ShouldSerializeVerticalSkew() => VerticalSkew is not null;
  public bool ShouldSerializeHorizontalShift() => HorizontalShift is not null;
  public bool ShouldSerializeVerticalShift() => VerticalShift is not null;
}
