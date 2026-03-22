namespace DocumentModel.Math;
#pragma warning disable CS1591
public partial class PhantomProperties
{
  public bool ShouldSerializeShowPhantom() => ShowPhantom is not null;
  public bool ShouldSerializeZeroWidth() => ZeroWidth is not null;
  public bool ShouldSerializeZeroAscent() => ZeroAscent is not null;
  public bool ShouldSerializeZeroDescent() => ZeroDescent is not null;
  public bool ShouldSerializeTransparent() => Transparent is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
