namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class PageMargin
{
  public bool ShouldSerializeTop() => Top is not null && ShouldSerialize(Top);
  public bool ShouldSerializeRight() => Right is not null && ShouldSerialize(Right);
  public bool ShouldSerializeBottom() => Bottom is not null && ShouldSerialize(Bottom);
  public bool ShouldSerializeLeft() => Left is not null && ShouldSerialize(Left);
  public bool ShouldSerializeHeader() => Header is not null && ShouldSerialize(Header);
  public bool ShouldSerializeFooter() => Footer is not null && ShouldSerialize(Footer);
  public bool ShouldSerializeGutter() => Gutter is not null && ShouldSerialize(Gutter);
}
