namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class PageMargins
{
  public bool ShouldSerializeLeft() => Left is not null;
  public bool ShouldSerializeRight() => Right is not null;
  public bool ShouldSerializeTop() => Top is not null;
  public bool ShouldSerializeBottom() => Bottom is not null;
  public bool ShouldSerializeHeader() => Header is not null;
  public bool ShouldSerializeFooter() => Footer is not null;
}
