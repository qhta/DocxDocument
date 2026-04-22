namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class PageMargins
{
  public bool ShouldSerializeL() => L is not null;
  public bool ShouldSerializeR() => R is not null;
  public bool ShouldSerializeT() => T is not null;
  public bool ShouldSerializeB() => B is not null;
  public bool ShouldSerializeHeader() => Header is not null;
  public bool ShouldSerializeFooter() => Footer is not null;
}
