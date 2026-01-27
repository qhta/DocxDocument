namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Anchor
{
  public bool ShouldSerializeX() => X is not null;
  public bool ShouldSerializeY() => Y is not null;
  public bool ShouldSerializeZ() => Z is not null;
}
