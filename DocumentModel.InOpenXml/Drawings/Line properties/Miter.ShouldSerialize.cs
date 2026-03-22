namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class Miter
{
  public bool ShouldSerializeLimit() => Limit is not null;
}
