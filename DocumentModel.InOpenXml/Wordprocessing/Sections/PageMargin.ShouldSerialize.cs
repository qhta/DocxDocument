namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class PageMargin
{
  public bool ShouldSerializeTop() => Top is not null;
  public bool ShouldSerializeRight() => Right is not null;
  public bool ShouldSerializeBottom() => Bottom is not null;
  public bool ShouldSerializeLeft() => Left is not null;
  public bool ShouldSerializeHeader() => Header is not null;
  public bool ShouldSerializeFooter() => Footer is not null;
  public bool ShouldSerializeGutter() => Gutter is not null;
}
