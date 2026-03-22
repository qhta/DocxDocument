namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591
public partial class Adjust
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeVal() => Val is not null;
}
